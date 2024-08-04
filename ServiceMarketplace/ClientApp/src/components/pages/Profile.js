import React, { Component } from 'react';
import './Profile.css';

export class Profile extends Component {
    static displayName = Profile.name;

    constructor(props) {
        super(props);
        this.state = {
            user: null,
            business: null,
            services: [],
            error: null
        };
    }

    componentDidMount() {
        this.fetchUserData();
    }

    fetchUserData = async () => {
        try {
            const authResponse = await fetch('/pingauth');
            if (!authResponse.ok) {
                throw new Error('Failed to fetch user information');
            }
            const user = await authResponse.json();
            this.setState({ user }, this.fetchBusinessData);
        } catch (error) {
            this.setState({ error: error.message });
        }
    };

    fetchBusinessData = async () => {
        const { user } = this.state;
        if (!user) return;

        try {
            const businessResponse = await fetch(`/api/business?address=${encodeURIComponent(user.address)}`);
            if (!businessResponse.ok) {
                throw new Error('Failed to fetch business information');
            }
            const business = await businessResponse.json();
            this.setState({ business }, this.fetchServicesData);
        } catch (error) {
            this.setState({ error: error.message });
        }
    };

    fetchServicesData = async () => {
        const { business } = this.state;
        if (!business) return;

        try {
            const servicesResponse = await fetch(`/api/service?businessId=${business.id}`);
            if (!servicesResponse.ok) {
                throw new Error('Failed to fetch services information');
            }
            const services = await servicesResponse.json();
            this.setState({ services });
        } catch (error) {
            this.setState({ error: error.message });
        }
    };

    render() {
        const { user, business, services, error } = this.state;

        if (error) {
            return <div className="error-message">Error: {error}</div>;
        }

        return (
            <>
                <div className="card-container container-sm col-8">
                    <div className="card business-card">
                        <h5 className="card-header">{business ? business.name : 'Business Name'}</h5>
                        <div className="card-body">
                            <h5 className="card-title">Location</h5>
                            <p className="card-text address">
                                {user ? `${user.address}, ${user.city}, ${user.state} ${user.zipCode}` : 'Address'}
                            </p>

                            <h5 className="card-title">Contact</h5>
                            <p className="card-text email">Email: {user ? user.email : 'Email'}</p>
                            <p className="card-text phone-number">Phone Number: {user ? user.phoneNumber : 'Phone Number'}</p>

                            <h5 className="card-title">About</h5>
                            <p className="card-text about">{business ? business.description : 'Description'}</p>
                        </div>
                    </div>
                    <div className="services-container">
                        <div className="card-body">
                            <h5 className="card-title">Services</h5>
                        </div>
                        <div>
                            {services.map(service => (
                                <div key={service.id} className="card service-card">
                                    <h5 className="card-title">{service.serviceName}</h5>
                                    <p className="card-text">Description: {service.description}</p>
                                    <p className="card-text">Rating: {service.rating}</p>
                                </div>
                            ))}
                        </div>
                    </div>
                </div>
            </>
        );
    }
}




