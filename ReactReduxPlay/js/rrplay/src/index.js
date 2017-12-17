import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import registerServiceWorker from './registerServiceWorker';
import { createStore }  from 'redux';
import anyBullshit from './reducers';

let store = createStore(anyBullshit);

function render(){
    ReactDOM.render(<App store={ store } />, document.getElementById('root'));
}

store.subscribe(render);
render();

registerServiceWorker();
