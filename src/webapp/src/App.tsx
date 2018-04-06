import * as React from 'react';
import './App.css';
import TodoItem from './TodoItem';
import EditItem from './EditItem';
import {
  ServicesTodo,
  TodoServiceApi,
  TodoServiceApiFactory as af,
  TodoServiceApiFp as api
} from './api/api';

const logo = require('./logo.svg');

interface State {
  todos: Todo[];
  error: string;
  selected: Todo;
}

interface Todo {
  id: number;
  title: string;
  done: boolean;
}

class App extends React.Component<{}, State> {
  state = {
    todos: [] as Todo[],
    selected: { id: 0, title: '', done: false },
    error: ''
  };

  private api: TodoServiceApi;

  constructor(props: {}) {
    super(props);
    this.api = new TodoServiceApi();
    this.api.basePath = 'http://localhost:8080';
  }

  componentDidMount() {
    this.loadTodos();
  }

  render() {
    const { id: ident, title: text, done: isDone } = this.state.selected;
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Welcome to Grpc TodoService Experiment</h1>
        </header>
        <div style={{ color: 'red', padding: '15px 0' }}>
          {this.state.error}
        </div>
        <EditItem
          id={ident}
          title={text}
          done={isDone}
          style={{ padding: '15px 0' }}
          onSave={(id, title, done) => this.saveItem(id, title, done)}
          onAbort={() => this.resetSelection()}
        />
        <button onClick={() => this.loadTodos()}>Refresh</button>
        <hr />
        <h1>Todos</h1>
        <div style={{ textAlign: 'center', display: 'inline-block' }}>
          {this.state.todos &&
            this.state.todos.map(t => (
              <TodoItem
                key={t.id}
                id={t.id}
                title={t.title}
                done={t.done}
                onDelete={id => this.deleteItem(id)}
                onEdit={id =>
                  this.setState({
                    selected: { id: t.id, title: t.title, done: t.done }
                  })
                }
              />
            ))}
        </div>
      </div>
    );
  }

  private async deleteItem(id: number) {
    this.setState({ error: '' });
    try {
      await this.api._delete({ id: id });
      await this.loadTodos();
    } catch (ex) {
      this.handleError(ex);
    }
  }

  private async saveItem(id: number, title: string, done: boolean) {
    this.setState({ error: '' });
    try {
      if (id === 0) {
        await this.api.create({ body: { id: 0, text: title, done: done } });
      } else {
        await this.api.update({
          id: id,
          body: { id: id, text: title, done: done }
        });
      }
      this.resetSelection();
      await this.loadTodos();
    } catch (ex) {
      this.handleError(ex);
    }
  }

  private resetSelection() {
    this.setState({ error: '', selected: { id: 0, title: '', done: false } });
  }

  private async loadTodos() {
    try {
      this.setState({ error: '' });
      const result = await this.api.list();
      const todos = result.todos
        ? result.todos.map(t => {
            return {
              id: t.id || 0,
              title: t.text || '',
              done: t.done || false
            };
          })
        : [];

      this.setState({ todos: todos });
    } catch (ex) {
      this.handleError(ex);
    }
  }

  private handleError(e: any) {
    if (e && typeof e.json === 'function') {
      const response = e as Response;
      response
        .json()
        .then(res => this.setState({ error: res.error }))
        .catch(reason => this.setState({ error: `${e}` }));
      return;
    }
    this.setState({ error: `${e}` });
  }
}

export default App;
