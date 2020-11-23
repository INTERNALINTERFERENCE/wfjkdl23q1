import {ActionCreators} from '../redux/notesReducer';
import * as axios from 'axios';

const axiosInstance = axios.create({
    baseUrl: "https://localhost:5001/",
});

export const GetNotes = async (dispatch) => {
    try{
        const {data} = await axiosInstance.get('https://localhost:5001/api/values');
        const names = data.map(({ fname  }) => ({ fname }));
        dispatch(ActionCreators.setNotes(names));
    }catch{
        console.log('Error!');
    }
}

export const DeleteNote = async (dispatch, note) => {
    try{
        // fake api call      
        dispatch(ActionCreators.deleteNote(note));
    }catch{
        console.log('Error!');
    }
}

export const NewNote = async (dispatch, note) => {
    try{
        // fake api call
        const response = {value: note, id: 1};
        dispatch(ActionCreators.newNote(response));
    }catch{
        console.log('Error!');
    }
}

export const EditNote = async (dispatch, note) => {
    try{
        // fake api call
        const response = {value: note, id: 1};
        dispatch(ActionCreators.editNote(response));
    }catch{
        console.log('Error!');
    }
}