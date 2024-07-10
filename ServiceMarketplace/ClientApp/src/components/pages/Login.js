import React, { Component } from 'react';
import {Link} from "react-router-dom"

export class Login extends Component {
    static displayName = Login.name;

    render() {
        return (
            <>
                <div className="container-sm col-4" >
                    {/*Username*/}
                    <div className="form-group">
                        <label for="username" className="form-label">Username</label>
                        <input className="form-control" placeholder="Username" />
                    </div>

                    {/*Password*/}
                    <div className="form-group">
                        <label for="password" className="form-label">Password</label>
                        <input className="form-control" placeholder="Password" />
                    </div>

                    {/*Button*/}
                    <div>
                        <button className="btn btn-primary" type="submit" onclick="">Login</button>
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
