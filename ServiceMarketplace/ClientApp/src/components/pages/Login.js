import React, { Component } from 'react';

export class Login extends Component {
    static displayName = Login.name;

    render() {
        return (
            <>
                <div className="loginContainer">
                    <label for="username">Username</label>
                    <input/>
                    <br></br>

                    <label for="password">Password</label>
                    <input />
                    <br></br>

                    <button type="submit" onclick="">Login</button>
                </div>
            </>
        );
    }
}
