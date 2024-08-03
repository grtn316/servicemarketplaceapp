import React, { Component } from "react";
import { withNavigate } from '../utils/navigate';


class Register extends Component {
    constructor(props) {
        super(props);
        this.state = {
            accountType: 0, // 0 for Standard and 1 for Business
            firstName: "",
            lastName: "",
            address: "",
            city: "",
            state: "",
            zipCode: "",
            phoneNumber: "",
            email: "",
            password: "",
            confirmPassword: "",
            error: ""
        };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(e) {
        const { name, value } = e.target;
        const parsedValue = name === 'accountType' ? parseInt(value, 10) : value;
        this.setState({ [name]: parsedValue });
    }

    handleSubmit(e) {
        e.preventDefault();
        const {
            accountType,
            firstName,
            lastName,
            address,
            city,
            state,
            zipCode,
            phoneNumber,
            email,
            password,
            confirmPassword
        } = this.state;

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

            // post data to the /registeruser api
            fetch("/registeruser", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify({
                    accountType: accountType,
                    firstName: firstName,
                    lastName: lastName,
                    address: address,
                    city: city,
                    state: state,
                    zipCode: zipCode,
                    phoneNumber: phoneNumber,
                    email: email,
                    password: password,
                }),
            })
                .then((data) => {
                    // handle success or error from the server
                    console.log(data);
                    if (data.ok) {
                        this.setState({ error: "Successful register." });
                        this.props.navigate("/");
                    }
                    else {
                        this.setState({ error: "Error registering." });
                    }
                })
                .catch((error) => {
                    // handle network error
                    console.error(error);
                    this.setState({ error: "Error registering." });
                });
        }
    }

    render() {
        const {
            accountType,
            firstName,
            lastName,
            address,
            city,
            state,
            zipCode,
            phoneNumber,
            email,
            password,
            confirmPassword,
            error
        } = this.state;

        return (
            <div className="containerbox">
                <h3>Register</h3>

                <form onSubmit={this.handleSubmit}>
                    <div>
                        <label htmlFor="accountType" className="form-label">Account Type</label>
                        <div className="form-check">
                            <input
                                className="form-check-input"
                                type="radio"
                                name="accountType"
                                id="accountType1"
                                value='0'
                                checked={accountType === 0}
                                onChange={this.handleChange}
                            />
                            <label className="form-check-label" htmlFor="accountType1">
                                Standard Account
                            </label>
                        </div>
                        <div className="form-check">
                            <input
                                className="form-check-input"
                                type="radio"
                                name="accountType"
                                id="accountType2"
                                value='1'
                                checked={accountType === 1}
                                onChange={this.handleChange}
                            />
                            <label className="form-check-label" htmlFor="accountType2">
                                Business Account
                            </label>
                        </div>
                    </div>

                    <div>
                        <label htmlFor="email" className="form-label">Email:</label>
                    </div>
                    <div>
                        <input
                            className="form-control"
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
                        <input
                            className="form-control"
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
                        <input
                            className="form-control"
                            type="password"
                            id="confirmPassword"
                            name="confirmPassword"
                            value={confirmPassword}
                            onChange={this.handleChange}
                        />
                    </div>

                    <div className="form-group">
                        <div className="row">
                            <div className="col-md-3">
                                <label htmlFor="firstName" className="form-label">First Name</label>
                                <input
                                    type="text"
                                    className="form-control"
                                    name="firstName"
                                    placeholder="John"
                                    value={firstName}
                                    onChange={this.handleChange}
                                />
                            </div>
                            <div className="col-md-3">
                                <label htmlFor="lastName" className="form-label">Last Name</label>
                                <input
                                    type="text"
                                    className="form-control"
                                    name="lastName"
                                    placeholder="Doe"
                                    value={lastName}
                                    onChange={this.handleChange}
                                />
                            </div>
                        </div>
                    </div>

                    <div className="form-group col-md-4">
                        <label htmlFor="address" className="form-label">Address</label>
                        <input
                            type="text"
                            className="form-control"
                            name="address"
                            id="address"
                            placeholder="612 Wharf Avenue"
                            value={address}
                            onChange={this.handleChange}
                        />
                    </div>

                    <div className="row">
                        <div className="form-group col-md-2">
                            <label htmlFor="city" className="form-label">City</label>
                            <input
                                type="text"
                                className="form-control"
                                name="city"
                                id="city"
                                placeholder="Seattle"
                                value={city}
                                onChange={this.handleChange}
                            />
                        </div>
                        <div className="form-group col-md-1">
                            <label htmlFor="state" className="form-label">State</label>
                            <select
                                id="state"
                                name="state"
                                className="form-control"
                                value={state}
                                onChange={this.handleChange}
                            >
                                <option value="">Select State</option>
                                <option value="AL">AL</option>
                                <option value="AK">AK</option>
                                <option value="AZ">AZ</option>
                                <option value="AR">AR</option>
                                <option value="CA">CA</option>
                                <option value="CO">CO</option>
                                <option value="CT">CT</option>
                                <option value="DE">DE</option>
                                <option value="DC">DC</option>
                                <option value="FL">FL</option>
                                <option value="GA">GA</option>
                                <option value="HI">HI</option>
                                <option value="ID">ID</option>
                                <option value="IL">IL</option>
                                <option value="IN">IN</option>
                                <option value="IA">IA</option>
                                <option value="KS">KS</option>
                                <option value="KY">KY</option>
                                <option value="LA">LA</option>
                                <option value="ME">ME</option>
                                <option value="MD">MD</option>
                                <option value="MA">MA</option>
                                <option value="MI">MI</option>
                                <option value="MN">MN</option>
                                <option value="MS">MS</option>
                                <option value="MO">MO</option>
                                <option value="MT">MT</option>
                                <option value="NE">NE</option>
                                <option value="NV">NV</option>
                                <option value="NH">NH</option>
                                <option value="NJ">NJ</option>
                                <option value="NM">NM</option>
                                <option value="NY">NY</option>
                                <option value="NC">NC</option>
                                <option value="ND">ND</option>
                                <option value="OH">OH</option>
                                <option value="OK">OK</option>
                                <option value="OR">OR</option>
                                <option value="PA">PA</option>
                                <option value="RI">RI</option>
                                <option value="SC">SC</option>
                                <option value="SD">SD</option>
                                <option value="TN">TN</option>
                                <option value="TX">TX</option>
                                <option value="UT">UT</option>
                                <option value="VT">VT</option>
                                <option value="VA">VA</option>
                                <option value="WA">WA</option>
                                <option value="WV">WV</option>
                                <option value="WI">WI</option>
                            </select>
                        </div>
                        <div className="form-group col-md-1">
                            <label htmlFor="zipCode" className="form-label">Zipcode</label>
                            <input
                                type="text"
                                className="form-control"
                                name="zipCode"
                                id="zipCode"
                                placeholder="66666"
                                value={zipCode}
                                onChange={this.handleChange}
                            />
                        </div>
                    </div>

                    <div className="form-group col-3">
                        <label htmlFor="phoneNumber" className="form-label">Phone Number</label>
                        <input
                            className="form-control"
                            name="phoneNumber"
                            id="phoneNumber"
                            placeholder="555-555-5555"
                            value={phoneNumber}
                            onChange={this.handleChange}
                        />
                    </div>

                    <div>
                        <button type="submit">Register</button>
                    </div>
                </form>

                {error && <p className="error">{error}</p>}
            </div>
        );
    }
}

export default withNavigate(Register);