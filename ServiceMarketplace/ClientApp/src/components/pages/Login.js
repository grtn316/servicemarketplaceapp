import React, { Component } from "react";
import { Link } from "react-router-dom";
import { withNavigate } from '../utils/navigate';


class Login extends Component {
    constructor(props) {
        super(props);
        this.state = {
            email: "",
            password: "",
            rememberme: false,
            error: ""
        };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        //this.handleRegisterClick = this.handleRegisterClick.bind(this);
    }

    handleChange(e) {
        const { name, value, type, checked } = e.target;
        if (type === "checkbox") {
            this.setState({ [name]: checked });
        } else {
            this.setState({ [name]: value });
        }
    }

    //handleRegisterClick() {
    //    this.props.navigate("/register");
    //}

    handleSubmit(e) {
        
        e.preventDefault();
        const { email, password, rememberme } = this.state;

        if (!email || !password) {
            this.setState({ error: "Please fill in all fields." });
        } else {
            this.setState({ error: "" });

            const loginurl = rememberme ? "/login?useCookies=true" : "/login?useSessionCookies=true";

            fetch(loginurl, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify({ email, password }),
            })
                .then((data) => {
                    if (data.ok) {
                        this.setState({ error: "Successful Login." });
                        this.props.navigate("/search-listings");
                        window.location.reload();
                        
                    } else {
                        this.setState({ error: "Error Logging In." });
                    }
                })
                .catch((error) => {
                    console.error(error);
                    this.setState({ error: "Error Logging in." });
                });
        }
    }

    render() {
        const { email, password, rememberme, error } = this.state;

        return (
            <div className="container-sm col-4">
                <h3>Login</h3>
                <form onSubmit={this.handleSubmit}>
                    <div>
                        <label className="form-label" htmlFor="email">Email:</label>
                    </div>
                    <div>
                        <input className="form-control"
                            type="email"
                            id="email"
                            name="email"
                            value={email}
                            onChange={this.handleChange}
                        />
                    </div>
                    <div>
                        <label className="form-label" htmlFor="password">Password:</label>
                    </div>
                    <div>
                        <input className="form-control"
                            type="password"
                            id="password"
                            name="password"
                            value={password}
                            onChange={this.handleChange}
                        />
                    </div>
                    <div>
                        <input
                            type="checkbox"
                            id="rememberme"
                            name="rememberme"
                            checked={rememberme}
                            onChange={this.handleChange} /><span>Remember Me</span>
                    </div>
                    <div>
                        <button className="btn btn-primary" type="submit">Login</button>
                        <Link to="/register" className="btn btn-secondary">Register</Link>
                    </div>
                </form>
                {error && <p className="error">{error}</p>}
            </div>
        );
    }
}

export default withNavigate(Login);