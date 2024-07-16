import React, { Component } from 'react';

export class Profile extends Component {
    static displayName = Profile.name;

    render() {
        return (
            <>
                <div className="card container-sm col-8">
                    <h5 className="card-header">Business Name</h5>
                    <div className="card-body">
                        <h5 className="card-title">Location</h5>
                        <p className="card-text">(address)</p>

                        <h5 className="card-title">Contact</h5>
                        <p className="card-text">Email: </p>
                        <p className="card-text">Phone Number: </p>

                        <h5 className="card-title">About</h5>
                        <p className="card-text">(...)</p>
                    </div>
                </div>
                <div className="card container-sm col-8">
                    <div className="card-body">
                        <h5 className="card-title">Services</h5>
                    </div>
                </div>
            </>
        );
    }
}
