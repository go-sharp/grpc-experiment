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
  lineHeiht: 20,
  margin: '0 5px'
};

export default class TodoItem extends React.PureComponent<Props> {
  state = {
    editable: false
  };

  render() {
    const { id, title, done } = this.props;

    return (
      <div>
        <input type="checkbox" disabled={true} checked={done} style={css} />
        <span style={css}>{title}</span>
        <input
          style={css}
          type="button"
          onClick={() => this.props.onEdit(id)}
          value="Edit"
        />
        <input
          style={css}
          type="button"
          onClick={() => this.props.onDelete(id)}
          value="Delete"
        />
      </div>
    );
  }
}
