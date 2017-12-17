import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { setAccountData } from './actions';

class App extends Component {
  constructor(props){
    super(props);
    this.store = this.props.store;
    this.handleNameChange = this.handleNameChange.bind(this);
  }

  handleNameChange(event){
    this.store.dispatch(setAccountData({name:event.target.value}));
  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Welcome to React</h1>
        </header>
        <p className="App-intro">
          To get started, edit <code>src/App.js</code> and save to reload.
          <br />reload 
        </p>
        <div>
          <input type="text" name="name" value={this.store.getState().account.name} onChange={this.handleNameChange} />
        </div>
        <div>
          <p>{this.store.getState().account.name}</p>
        </div>
      </div>
    );
  }
}

export default App;
