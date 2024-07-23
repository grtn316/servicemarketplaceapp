import React, { Component } from "react";
import { withRouter } from "react-router-dom";

export class Register extends Component {
    constructor(props) {
        super(props);
        this.state = {
            email: "",
            password: "",
            confirmPassword: "",
            error: ""
        };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.handleLoginClick = this.handleLoginClick.bind(this);
    }

    handleChange(e) {
        const { name, value } = e.target;
        this.setState({ [name]: value });
    }

    handleLoginClick() {
        this.props.history.push("/login");
    }

    handleSubmit(e) {
        e.preventDefault();
        const { email, password, confirmPassword } = this.state;

        // validate email and passwords
        if (!email || !password || !confirmPassword) {
            this.setState({ error: "Please fill in all fields." });
        } else if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
            this.setState({ error: "Please enter a valid email address." });
        } else if (password !== confirmPassword) {
            this.setState({ error: "Passwords do not match." });
        } else {
            // clear error message
            this.setState({ error: "" });

            // post data to the /register api
            fetch("/register", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify({
                    email: email,
                    password: password,
                }),
            })
                .then((data) => {
                    // handle success or error from the server
                    console.log(data);
                    if (data.ok)
                        this.setState({ error: "Successful register." });
                    else
                        this.setState({ error: "Error registering." });
                })
                .catch((error) => {
                    // handle network error
                    console.error(error);
                    this.setState({ error: "Error registering." });
                });
        }
    }

    render() {
        const { email, password, confirmPassword, error } = this.state;

        return (
            <div className="containerbox">
                <h3>Register</h3>

                <form onSubmit={this.handleSubmit}>
                    <div>
                        <label htmlFor="accountType" className="form-label">Account Type</label>
                        <div className="form-check">
                            <input className="form-check-input" type="radio" name="accountType" id="accountType1" value="option1" />
                            <label className="form-check-label" htmlFor="accountType1">
                                Standard Account
                            </label>
                        </div>
                        <div className="form-check">
                            <input className="form-check-input" type="radio" name="accountType" id="accountType2" value="option2" />
                            <label className="form-check-label" htmlFor="accountType2">
                                Business Account
                            </label>
                        </div>
                    </div>

                    <div>
                        <label htmlFor="email" className="form-label">Email:</label>
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
                        <label htmlFor="password" className="form-label">Password:</label>
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
                        <label htmlFor="confirmPassword" className="form-label">Confirm Password:</label>
                    </div>
                    <div>
                        <input className="form-control"
                            type="password"
                            id="confirmPassword"
                            name="confirmPassword"
                            value={confirmPassword}
                            onChange={this.handleChange}
                        />
                    </div>
                    {/*First name, Last Name*/}
                    <div className="form-group">
                        <div className="row">
                            <div className="col-md-3">
                                <label htmlFor="username" className="form-label">First Name</label>
                                <input type="text" className="form-control" placeholder="John" />
                            </div>
                            <div className="col-md-3">
                                <label htmlFor="username" className="form-label">Last Name</label>
                                <input type="text" className="form-control" placeholder="Doe" />
                            </div>
                        </div>
                    </div>

                    {/*Address*/}
                    <div className="form-group col-md-4">
                        <label htmlFor="address">Address</label>
                        <input type="text" className="form-control" id="address" placeholder="612 Wharf Avenue" />
                    </div>

                    {/*City, State, Zipcode*/}
                    <div className="row">
                        <div className="form-group col-md-2">
                            <label htmlFor="city">City</label>
                            <input type="text" className="form-control" id="city" placeholder="Seattle" />
                        </div>
                        <div className="form-group col-md-1">
                            <label htmlFor="state">State</label>
                            <select id="state" className="form-control" placeholder="WA">
                                <option></option><option>AL</option><option>AK</option><option>AZ</option><option>AR</option><option>CA</option><option>CO</option><option>CT</option><option>DE</option><option>DC</option><option>FL</option><option>GA</option><option>HI</option><option>ID</option><option>IL</option><option>IN</option><option>IA</option><option>KS</option><option>KY</option><option>LA</option><option>ME</option><option>MD</option><option>MA</option><option>MI</option><option>MN</option><option>MS</option><option>MO</option><option>MT</option><option>NE</option><option>NV</option><option>NH</option><option>NJ</option><option>NM</option><option>NY</option><option>NC</option><option>ND</option><option>OH</option><option>OK</option><option>OR</option><option>PA</option><option>RI</option><option>SC</option><option>SD</option><option>TN</option><option>TX</option><option>UT</option><option>VT</option><option>VA</option><option>WA</option><option>WV</option><option>WI</option>
                            </select>
                        </div>
                        <div className="form-group col-md-1">
                            <label htmlFor="zipcode">Zipcode</label>
                            <input type="text" className="form-control" id="zipcode" placeholder="66666" />
                        </div>
                    </div>

                    {/*Phone Number*/}
                    <div className="form-group col-3">
                        <label htmlFor="phone" className="form-label">Phone Number</label>
                        <input className="form-control" placeholder="555-555-5555" />
                    </div>

                    <div>
                        <button type="submit">Register</button>
                    </div>
                    <div>
                        <button type="button" onClick={this.handleLoginClick}>Go to Login</button>
                    </div>
                </form>

                {error && <p className="error">{error}</p>}
            </div>
        );
    }
}
