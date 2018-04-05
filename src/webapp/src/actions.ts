'use strict';

const UPDATE_TODO: 'UPDATE_TODO' = 'UPDATE_TODO';
const DELETE_TODO: 'DELETE_TODO' = 'DELETE_TODO';
const CREATE_TODO: 'CREATE_TODO' = 'CREATE_TODO';

export type TodoAction = CreateTodoAction | DeleteTodoAction | UpdateTodoAction;

export interface CreateTodoAction {
    type: typeof CREATE_TODO;
    title: string;
    done: boolean;
}

export interface UpdateTodoAction {
    type: typeof UPDATE_TODO;
    id: number;
    title: string;
    done: boolean;
}

export interface DeleteTodoAction {
    type: typeof DELETE_TODO;
    id: number;
}

export const createAction = (title: string, isDone: boolean): CreateTodoAction => ({
   type: CREATE_TODO,
   done: isDone,
   title: title
});

export const updateAction = (id: number, title: string, isDone: boolean): UpdateTodoAction => ({
    type: UPDATE_TODO,
    id: id,
    done: isDone,
    title: title
});

export const deleteAction = (id: number): DeleteTodoAction => ({
    type: DELETE_TODO,
    id: id
});