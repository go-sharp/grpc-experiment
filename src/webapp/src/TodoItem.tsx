'use strict';
import * as React from 'react';

interface Props {
  id: number;
  title: string;
  done: boolean;
  onEdit: (id: number) => void;
  onDelete: (id: number) => void;
}

const css = {
  lineHeight: 20,
  margin: '0 5px'
};

export default class TodoItem extends React.PureComponent<Props> {
  state = {
    editable: false
  };

  render() {
    const { id, title, done } = this.props;

    return (
      <div style={{ display: 'flex', alignItems: 'flex-start' }}>
        <input type="checkbox" disabled={true} checked={done} style={css} />
        <span
          style={{
            width: 300,
            display: 'inline-block',
            textAlign: 'left',
            ...css
          }}
        >
          {title}
        </span>
        <button style={css} onClick={() => this.props.onEdit(id)}>
          Edit
        </button>
        <button style={css} onClick={() => this.props.onDelete(id)}>
          Delete
        </button>
      </div>
    );
  }
}
