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
                        <p className="card-text address"></p>

                        <h5 className="card-title">Contact</h5>
                        <p className="card-text email">Email: </p>
                        <p className="card-text phone-number">Phone Number: </p>

                        <h5 className="card-title">About</h5>
                        <p className="card-text about"></p>
                    </div>
                    <div className="">
                        <div className="card-body">
                            <h5 className="card-title">Services</h5>
                        </div>
                        <div>
                            <div className="card">
                                <h5 className="card-title">Service Name</h5>
                                <p className="">Description</p>
                                <p className="">Rating</p>
                            </div>
                            <div className="card">
                                <h5 className="card-title">Service Name</h5>
                                <p className="">Description</p>
                                <p className="">Rating</p>
                            </div>
                        </div>
                    </div>
                </div>
                
            </>
        );
    }
}
