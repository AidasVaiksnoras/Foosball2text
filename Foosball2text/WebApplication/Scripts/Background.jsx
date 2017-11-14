import React, { Component } from 'react';

class Background extends Component {
    constructor() {
        super();
        this.state = {
            Game: null,
        };
    }
}
componentDidMount() {
    return fetch('http://localhost:63526/api/CurrentGame')
        .then((response) => response.json())
        .then((responseJson) => {
            responseJson;
        })
        .catch((error) => {
            console.error(error);
        });
}

render() {
    return (
        <div className = "constainer2">
        )
}