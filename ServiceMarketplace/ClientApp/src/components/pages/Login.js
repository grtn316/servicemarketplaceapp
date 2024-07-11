import React, { Component } from 'react';
import {Link} from "react-router-dom"

export class Login extends Component {
    static displayName = Login.name;

    render() {
        function placeholderFunction() {
        }
        return (
            <>
                <div className="container-sm col-4" >
                    {/*Username*/}
                    <div className="form-group">
                        <label htmlFor="username" className="form-label">Username</label>
                        <input className="form-control" placeholder="Username" />
                    </div>

                    {/*Password*/}
                    <div className="form-group">
                        <label htmlFor="password" className="form-label">Password</label>
                        <input className="form-control" placeholder="Password" />
                    </div>

                    {/*Button*/}
                    <div>
                        <button className="btn btn-primary" type="submit" onClick={placeholderFunction}>Login</button>
                    </div>


                    {/*"Create Account" link*/}
                    <div>
                        <Link to="/register">Create Account</Link>
                    </div>
                </div>
            </>
        );
    }
}
