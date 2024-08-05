import React, { Component } from 'react';
import './Profile.css';
import { GoogleMap, LoadScript, Marker } from '@react-google-maps/api';

const mapContainerStyle = {
    height: "200px",
    width: "100%"
};

const googleMapsApiKey = "AIzaSyBHBIIaxRnkkLvtY0mY1B8HmwNb91M9JcI";

const mapOptions = {
    streetViewControl: false // Disable the Street View control
};

export class Profile extends Component {
    static displayName = Profile.name;

    constructor(props) {
        super(props);
        this.state = {
            user: null,
            business: null,
            services: [],
            error: null,
            coordinates: { lat: 0, lng: 0 }
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
            this.setState({ user }, this.fetchBusinessUserData);
        } catch (error) {
            this.setState({ error: error.message });
        }
    };

    fetchBusinessUserData = async () => {
        const { user } = this.state;
        if (!user) return;

        try {
            const businessUserResponse = await fetch(`/api/businessuser?userId=${user.id}`);
            if (!businessUserResponse.ok) {
                throw new Error('Failed to fetch business user information');
            }
            const businessUsers = await businessUserResponse.json();
            const userBusiness = businessUsers.find(bu => bu.userId === user.id);
            if (userBusiness) {
                const businessId = userBusiness.businessId;
                this.fetchBusinessData(businessId);
            } else {
                throw new Error('No business associated with this user.');
            }
        } catch (error) {
            this.setState({ error: error.message });
        }
    };

    fetchBusinessData = async (businessId) => {
        try {
            const businessResponse = await fetch(`/api/business`);
            if (!businessResponse.ok) {
                throw new Error('Failed to fetch business information');
            }
            const businesses = await businessResponse.json();
            const business = businesses.find(b => b.id === businessId);
            if (business) {
                this.setState({ business }, () => {
                    this.fetchServicesData(businessId);
                    this.getCoordinates(business.address);
                });
            } else {
                throw new Error('Business not found.');
            }
        } catch (error) {
            this.setState({ error: error.message });
        }
    };

    fetchServicesData = async (businessId) => {
        try {
            const servicesResponse = await fetch(`/api/service`);
            if (!servicesResponse.ok) {
                throw new Error('Failed to fetch services information');
            }
            const services = await servicesResponse.json();
            const businessServices = services.filter(service => service.businessId === businessId);
            this.setState({ services: businessServices });
        } catch (error) {
            this.setState({ error: error.message });
        }
    };

    getCoordinates = async (address) => {
        try {
            const response = await fetch(`https://maps.googleapis.com/maps/api/geocode/json?address=${encodeURIComponent(address.street + ', ' + address.city + ', ' + address.state + ' ' + address.zipcode)}&key=${googleMapsApiKey}`);
            const data = await response.json();
            if (data.status === 'OK') {
                const location = data.results[0].geometry.location;
                this.setState({
                    coordinates: {
                        lat: location.lat,
                        lng: location.lng
                    }
                });
            } else {
                throw new Error('Geocoding failed: ' + data.status);
            }
        } catch (error) {
            console.error('Error getting coordinates:', error);
            this.setState({
                coordinates: { lat: 0, lng: 0 }
            });
        }
    };

    render() {
        const { user, business, services, error, coordinates } = this.state;

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
                                {business ? `${business.address.street}, ${business.address.city}, ${business.address.state} ${business.address.zipcode}` : 'Address'}
                            </p>
                            <div className="map-container">
                                <LoadScript googleMapsApiKey={googleMapsApiKey}>
                                    <GoogleMap
                                        mapContainerStyle={mapContainerStyle}
                                        center={coordinates}
                                        zoom={15}
                                        options={mapOptions}
                                    >
                                        <Marker position={coordinates} />
                                    </GoogleMap>
                                </LoadScript>
                            </div>

                            <h5 className="card-title">Contact</h5>
                            <p className="card-text email">Email: {user ? user.email : 'Email'}</p>
                            <p className="card-text phone-number">Phone Number: {business ? business.phoneNumber : 'Phone Number'}</p>

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



