﻿import React, { Component } from 'react';
import './Listings.css';
import { GoogleMap, LoadScript, Marker } from '@react-google-maps/api';

const mapContainerStyle = {
    height: "200px",
    width: "100%"
};

const googleMapsApiKey = "AIzaSyBHBIIaxRnkkLvtY0mY1B8HmwNb91M9JcI";

const mapOptions = {
    streetViewControl: false // Disable the Street View control
};

export class Listings extends Component {
    static displayName = Listings.name;

    constructor(props) {
        super(props);
        this.state = {
            listings: [],
            customerName: '',
            customerEmail: '',
            customerPhone: ''
        };
    }

    componentDidMount() {
        this.fetchUserBookings();
    }

    fetchUserBookings = async () => {
        try {
            // Fetch user information to get the customer ID, name, email, and phone number
            const userResponse = await fetch('/pingauth');
            if (!userResponse.ok) {
                throw new Error('Failed to fetch user information');
            }
            const user = await userResponse.json();
            const customerId = user.id;
            const customerName = `${user.firstName} ${user.lastName}`;
            const customerEmail = user.email;
            const customerPhone = user.phoneNumber;

            // Fetch bookings for the customer
            const bookingsResponse = await fetch(`/api/booking?customerId=${customerId}`);
            if (!bookingsResponse.ok) {
                throw new Error('Failed to fetch bookings');
            }
            const bookings = await bookingsResponse.json();

            // Filter bookings for the current customer
            const userBookings = bookings.filter(booking => booking.customerId === customerId);

            // Fetch services and businesses related to the user bookings
            const services = await Promise.all(userBookings.map(async (booking) => {
                const serviceResponse = await fetch(`/api/service/${booking.serviceId}`);
                if (!serviceResponse.ok) {
                    throw new Error('Failed to fetch service');
                }
                return await serviceResponse.json();
            }));

            const businesses = await Promise.all(services.map(async (service) => {
                const businessResponse = await fetch(`/api/business/${service.businessId}`);
                if (!businessResponse.ok) {
                    throw new Error('Failed to fetch business');
                }
                return await businessResponse.json();
            }));

            // Format the listings data
            const listings = await Promise.all(userBookings.map(async (booking, index) => {
                const service = services[index];
                const business = businesses.find(b => b.id === service.businessId);
                if (!business) {
                    console.error('Business not found for service:', service); // Debug statement
                    return null;
                }
                const coordinates = await this.getCoordinates(business.address);
                const status = booking.status === 0 ? 'Confirmed' : 'Pending';

                return {
                    id: booking.id,
                    customerName: customerName,
                    customerEmail: customerEmail,
                    customerPhone: customerPhone,
                    status: status,
                    business: {
                        id: business.id.toString(),
                        name: business.name,
                        description: business.description,
                        address: {
                            street: business.address.street,
                            city: business.address.city,
                            state: business.address.state,
                            zip: business.address.zipcode,
                            lat: coordinates.lat,
                            lng: coordinates.lng
                        },
                        phoneNumber: {
                            countryCode: '+1',
                            number: business.phoneNumber
                        }
                    },
                    serviceName: service.serviceName,
                    description: service.description,
                    price: service.price,
                    rating: service.rating,
                };
            }));

            // Filter out any null listings caused by the missing businesses
            const filteredListings = listings.filter(listing => listing !== null);
            this.setState({ listings: filteredListings });
        } catch (error) {
            console.error('Error fetching user bookings:', error);
        }
    };

    getCoordinates = async (address) => {
        try {
            const response = await fetch(`https://maps.googleapis.com/maps/api/geocode/json?address=${encodeURIComponent(address.street + ', ' + address.city + ', ' + address.state + ' ' + address.zipcode)}&key=${googleMapsApiKey}`);
            const data = await response.json();
            if (data.status === 'OK') {
                const location = data.results[0].geometry.location;
                return {
                    lat: location.lat,
                    lng: location.lng
                };
            } else {
                throw new Error('Geocoding failed: ' + data.status);
            }
        } catch (error) {
            console.error('Error getting coordinates:', error);
            return {
                lat: 0,
                lng: 0
            };
        }
    };

    render() {
        return (
            <div className="listings-container">
                <h1>My Bookings</h1>
                <ul>
                    {this.state.listings.map(listing => (
                        <li key={listing.id} className="listing-item">
                            <h2>{listing.serviceName}</h2>
                            <p>{listing.description}</p>
                            <p><span>Price:</span> ${listing.price}</p>
                            <p><span>Rating:</span> {listing.rating} stars</p>
                            <h3>Booking Info</h3>
                            <ul className="booking-info">
                                <li>
                                    <p><span>Customer Name:</span> {listing.customerName}</p>
                                    <p><span>Customer Email:</span> {listing.customerEmail}</p>
                                    <p><span>Customer Phone:</span> {listing.customerPhone}</p>
                                    <p><span>Status:</span> {listing.status}</p>
                                </li>
                            </ul>
                            <h3>Business Information</h3>
                            <ul className="business-info">
                                <li>
                                    <p><span>Name:</span> {listing.business.name}</p>
                                    <p><span>Description:</span> {listing.business.description}</p>
                                    <p><span>Address:</span> {listing.business.address.street}, {listing.business.address.city}, {listing.business.address.state} {listing.business.address.zip}</p>
                                    <p><span>Phone:</span> {listing.business.phoneNumber.countryCode} {listing.business.phoneNumber.number}</p>
                                </li>
                            </ul>
                            <h3>Location</h3>
                            <div className="map-container">
                                <LoadScript googleMapsApiKey={googleMapsApiKey}>
                                    <GoogleMap
                                        mapContainerStyle={mapContainerStyle}
                                        center={{ lat: listing.business.address.lat, lng: listing.business.address.lng }}
                                        zoom={15}
                                        options={mapOptions}
                                    >
                                        <Marker position={{ lat: listing.business.address.lat, lng: listing.business.address.lng }} />
                                    </GoogleMap>
                                </LoadScript>
                            </div>
                        </li>
                    ))}
                </ul>
            </div>
        );
    }
}


