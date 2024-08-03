import React, { Component } from 'react';
import './SearchListings.css';
import { GoogleMap, LoadScript, Marker } from '@react-google-maps/api';
import { UserBooking } from './UserBooking';

const mapContainerStyle = {
    height: "200px",
    width: "100%"
};

export class SearchListings extends Component {
    static displayName = SearchListings.name;

    constructor(props) {
        super(props);
        this.state = {
            searchTerm: '',
            selectedService: null,
            listings: [
                {
                    id: 1,
                    business: {
                        id: '101',
                        name: 'Alpha Services',
                        description: 'Providing top-notch alpha services.',
                        address: {
                            street: '123 Main St',
                            city: 'Townsville',
                            state: 'TS',
                            zip: '12345',
                            lat: 37.7749,
                            lng: -122.4194
                        },
                        phoneNumber: {
                            countryCode: '+1',
                            number: '123-456-7890'
                        }
                    },
                    serviceName: 'Web Development',
                    description: 'Building modern and responsive websites.',
                    price: 50.0,
                    duration: 60,
                    rating: 4.5,
                    reviews: [
                        { id: 1, content: 'Great service!', rating: 5 },
                        { id: 2, content: 'Very professional.', rating: 4 }
                    ],
                    availability: [
                        { id: 1, startTime: new Date('2024-07-13T09:00:00'), endTime: new Date('2024-07-13T10:00:00') },
                        { id: 2, startTime: new Date('2024-07-13T11:00:00'), endTime: new Date('2024-07-13T12:00:00') }
                    ]
                },
                {
                    id: 2,
                    business: {
                        id: '102',
                        name: 'Beta Solutions',
                        description: 'Innovative solutions for your business needs.',
                        address: {
                            street: '456 Oak St',
                            city: 'Villageton',
                            state: 'VS',
                            zip: '67890',
                            lat: 34.0522,
                            lng: -118.2437
                        },
                        phoneNumber: {
                            countryCode: '+1',
                            number: '987-654-3210'
                        }
                    },
                    serviceName: 'Graphic Design',
                    description: 'Creating stunning visual content.',
                    price: 75.0,
                    duration: 90,
                    rating: 4.0,
                    reviews: [
                        { id: 3, content: 'Good value for money.', rating: 4 },
                        { id: 4, content: 'Satisfactory.', rating: 3 }
                    ],
                    availability: [
                        { id: 3, startTime: new Date('2024-07-13T13:00:00'), endTime: new Date('2024-07-13T14:30:00') },
                        { id: 4, startTime: new Date('2024-07-13T15:00:00'), endTime: new Date('2024-07-13T16:30:00') }
                    ]
                },
                {
                    id: 3,
                    business: {
                        id: '103',
                        name: 'Gamma Enterprises',
                        description: 'Your go-to partner for business growth.',
                        address: {
                            street: '789 Pine St',
                            city: 'Cityburg',
                            state: 'CB',
                            zip: '11223',
                            lat: 40.7128,
                            lng: -74.0060
                        },
                        phoneNumber: {
                            countryCode: '+1',
                            number: '555-123-4567'
                        }
                    },
                    serviceName: 'SEO Optimization',
                    description: 'Improving your website ranking on search engines.',
                    price: 100.0,
                    duration: 120,
                    rating: 5.0,
                    reviews: [
                        { id: 5, content: 'Excellent service!', rating: 5 },
                        { id: 6, content: 'Highly recommended.', rating: 5 }
                    ],
                    availability: [
                        { id: 5, startTime: new Date('2024-07-13T17:00:00'), endTime: new Date('2024-07-13T19:00:00') },
                        { id: 6, startTime: new Date('2024-07-13T20:00:00'), endTime: new Date('2024-07-13T22:00:00') }
                    ]
                }
            ]
        };
    }

    handleSearchChange = (event) => {
        this.setState({ searchTerm: event.target.value });
    };

    handleBookClick = (service) => {
        this.setState({ selectedService: service });
    };

    handleCloseForm = () => {
        this.setState({ selectedService: null });
    };

    updateServiceAvailability = (serviceId, updatedAvailability) => {
        this.setState(prevState => {
            const updatedListings = prevState.listings.map(listing => {
                if (listing.id === serviceId) {
                    return { ...listing, availability: updatedAvailability };
                }
                return listing;
            });
            return { listings: updatedListings, selectedService: null };
        });
    };

    render() {
        const { searchTerm, listings, selectedService } = this.state;
        const filteredListings = listings.filter(listing => {
            const searchLower = searchTerm.toLowerCase();
            return (
                listing.serviceName.toLowerCase().includes(searchLower) ||
                listing.business.name.toLowerCase().includes(searchLower) ||
                listing.business.description.toLowerCase().includes(searchLower)
            );
        });

        return (
            <div className="listings-container">
                <h1>Service Listings</h1>
                <input
                    type="text"
                    className="search-bar"
                    placeholder="Search for services or businesses..."
                    value={searchTerm}
                    onChange={this.handleSearchChange}
                />
                <ul>
                    {filteredListings.map(listing => (
                        <li key={listing.id} className="listing-item">
                            <h2>{listing.serviceName}</h2>
                            <p>{listing.description}</p>
                            <p><span>Price:</span> ${listing.price}</p>
                            <p><span>Duration:</span> {listing.duration} minutes</p>
                            <p><span>Rating:</span> {listing.rating} stars</p>
                            <h3>Business Information:</h3>
                            <ul className="business-info">
                                <li>
                                    <p><span>Name:</span> {listing.business.name}</p>
                                    <p><span>Description:</span> {listing.business.description}</p>
                                    <p><span>Address:</span> {listing.business.address.street}, {listing.business.address.city}, {listing.business.address.state} {listing.business.address.zip}</p>
                                    <p><span>Phone:</span> {listing.business.phoneNumber.countryCode} {listing.business.phoneNumber.number}</p>
                                </li>
                            </ul>
                            <h3>Location:</h3>
                            <div className="map-container">
                                <LoadScript googleMapsApiKey="AIzaSyBHBIIaxRnkkLvtY0mY1B8HmwNb91M9JcI">
                                    <GoogleMap
                                        mapContainerStyle={mapContainerStyle}
                                        center={{ lat: listing.business.address.lat, lng: listing.business.address.lng }}
                                        zoom={15}
                                    >
                                        <Marker position={{ lat: listing.business.address.lat, lng: listing.business.address.lng }} />
                                    </GoogleMap>
                                </LoadScript>
                            </div>
                            <h3>Reviews:</h3>
                            <ul className="reviews-list">
                                {listing.reviews.map(review => (
                                    <li key={review.id}>
                                        <p><span>Review:</span> {review.content} - {review.rating} stars</p>
                                    </li>
                                ))}
                            </ul>
                            <h3>Availability:</h3>
                            <ul className="availability-list">
                                {listing.availability.map(slot => (
                                    <li key={slot.id}>
                                        <p><span>From:</span> {slot.startTime.toLocaleString()} <span>To:</span> {slot.endTime.toLocaleString()}</p>
                                    </li>
                                ))}
                            </ul>
                            <button className="book-button" onClick={() => this.handleBookClick(listing)}>Book</button>
                        </li>
                    ))}
                </ul>
                {selectedService && (
                    <div className="booking-form-overlay">
                        <div className="booking-form-container">
                            <button className="close-button" onClick={this.handleCloseForm}>X</button>
                            <UserBooking service={selectedService} updateServiceAvailability={this.updateServiceAvailability} />
                        </div>
                    </div>
                )}
            </div>
        );
    }
}
