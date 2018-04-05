'use strict';
import * as React from 'react';
import { CSSProperties } from 'react';

interface Props {
  id?: number;
  title?: string;
  done?: boolean;
  onSave: (id: number, title: string, done: boolean) => void;
  onAbort?: () => void;
  style?: CSSProperties;
}

interface State {
  id: number;
  title: string;
  done: boolean;
}

export default class EditItem extends React.PureComponent<Props, State> {
  state = {
    id: 0,
    title: '',
    done: false
  };

  static getDerivedStateFromProps(props: Props): State {
    const { title, done, id } = props;
    return { title: title || '', done: done || false, id: id || 0 };
  }

  render() {
    const { title, done } = this.state;
    const saveButton =
      this.props.id && this.props.id > 0 ? (
        <button>Update</button>
      ) : (
        <button>Create</button>
      );

    return (
      <div style={this.props.style}>
        <label>
          Done:
          <input
            type="checkbox"
            checked={done}
            onChange={ev => this.setState({ done: ev.currentTarget.checked })}
          />
        </label>
        <label>
          Title:
          <input
            type="text"
            value={title}
            onChange={ev => this.setState({ title: ev.currentTarget.value })}
          />
        </label>
        <button onClick={() => this.saveTodo()}>
          {this.props.id && this.props.id > 0 ? 'Update' : 'Add'}
        </button>
        <button onClick={() => this.reset()}>Reset</button>
      </div>
    );
  }

  private reset() {
    if (this.props.onAbort) {
      this.props.onAbort();
    } else {
      this.setState({ title: '', id: 0, done: false });
    }
  }

  private saveTodo() {
    this.props.onSave(this.state.id, this.state.title, this.state.done);
  }
}
