import React, { Component } from 'react';
import './Listings.css';

export class Listings extends Component {
    static displayName = Listings.name;

    constructor(props) {
        super(props);
        this.state = {
            listings: [
                {
                    id: 1,
                    business: {
                        id: '101',
                        name: 'Business A',
                        description: 'Description for Business A',
                        address: {
                            street: '123 Main St',
                            city: 'Townsville',
                            state: 'TS',
                            zip: '12345'
                        },
                        phoneNumber: {
                            countryCode: '+1',
                            number: '123-456-7890'
                        }
                    },
                    serviceName: 'Service A',
                    description: 'Description for Service A',
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
                        name: 'Business B',
                        description: 'Description for Business B',
                        address: {
                            street: '456 Oak St',
                            city: 'Villageton',
                            state: 'VS',
                            zip: '67890'
                        },
                        phoneNumber: {
                            countryCode: '+1',
                            number: '987-654-3210'
                        }
                    },
                    serviceName: 'Service B',
                    description: 'Description for Service B',
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
                        name: 'Business C',
                        description: 'Description for Business C',
                        address: {
                            street: '789 Pine St',
                            city: 'Cityburg',
                            state: 'CB',
                            zip: '11223'
                        },
                        phoneNumber: {
                            countryCode: '+1',
                            number: '555-123-4567'
                        }
                    },
                    serviceName: 'Service C',
                    description: 'Description for Service C',
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

    render() {
        return (
            <div className="listings-container">
                <h1>My Listings</h1>
                <ul>
                    {this.state.listings.map(listing => (
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
                        </li>
                    ))}
                </ul>
            </div>
        );
    }
}
