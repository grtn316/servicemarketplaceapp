import React, { Component } from 'react';
import './SearchListings.css';
import { GoogleMap, LoadScript, Marker } from '@react-google-maps/api';
import { UserBooking } from './UserBooking';

const mapContainerStyle = {
    height: "200px",
    width: "100%"
};

const googleMapsApiKey = "AIzaSyBHBIIaxRnkkLvtY0mY1B8HmwNb91M9JcI";

const mapOptions = {
    fullscreenControl: true,
    streetViewControl: false // Disable the Street View control
};

export class SearchListings extends Component {
    static displayName = SearchListings.name;

    constructor(props) {
        super(props);
        this.state = {
            searchTerm: '',
            withinRadius: false,
            userLocation: null,
            selectedService: null,
            listings: []
        };
    }

    componentDidMount() {
        this.fetchServices();
        this.fetchUserAddress();
    }

    fetchUserAddress = async () => {
        try {
            const authResponse = await fetch('/pingauth');
            if (!authResponse.ok) {
                throw new Error('Failed to fetch user information');
            }
            const authData = await authResponse.json();
            const coordinates = await this.getCoordinates({ street: authData.street, city: authData.city, state: authData.state, zipcode: authData.zipcode });

            this.setState({
                userLocation: {
                    lat: coordinates.lat,
                    lng: coordinates.lng
                }
            });
        } catch (error) {
            console.error('Error fetching user address:', error);
        }
    };

    fetchServices = async () => {
        try {
            const response = await fetch('/api/service');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const services = await response.json();
            const listings = await Promise.all(services.map(async (service) => {
                const businessResponse = await fetch(`/api/business/${service.businessId}`);
                if (!businessResponse.ok) {
                    throw new Error('Network response was not ok');
                }
                const business = await businessResponse.json();
                const coordinates = await this.getCoordinates(business.address);
                return {
                    id: service.id,
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
                    reviews: service.reviews,
                    availability: service.timeSlots
                };
            }));
            this.setState({ listings });
        } catch (error) {
            console.error('Error fetching services:', error);
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

    handleSearchChange = (event) => {
        this.setState({ searchTerm: event.target.value });
    };

    handleRadiusChange = (event) => {
        this.setState({ withinRadius: event.target.checked });
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

    calculateDistance = (lat1, lon1, lat2, lon2) => {
        const R = 3958.8; // Radius of the Earth in miles
        const dLat = (lat2 - lat1) * (Math.PI / 180);
        const dLon = (lon2 - lon1) * (Math.PI / 180);
        const a =
            Math.sin(dLat / 2) * Math.sin(dLat / 2) +
            Math.cos(lat1 * (Math.PI / 180)) * Math.cos(lat2 * (Math.PI / 180)) *
            Math.sin(dLon / 2) * Math.sin(dLon / 2);
        const c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
        return R * c;
    };

    filterListings = () => {
        const { searchTerm, withinRadius, listings, userLocation } = this.state;
        const searchLower = searchTerm.toLowerCase();
        return listings.filter(listing => {
            const matchesSearchTerm =
                listing.serviceName.toLowerCase().includes(searchLower) ||
                listing.business.name.toLowerCase().includes(searchLower) ||
                listing.business.description.toLowerCase().includes(searchLower);

            if (!withinRadius || !userLocation) {
                return matchesSearchTerm;
            }

            const distance = this.calculateDistance(
                userLocation.lat,
                userLocation.lng,
                listing.business.address.lat,
                listing.business.address.lng
            );
            return matchesSearchTerm && distance <= 20;
        });
    };

    render() {
        const { searchTerm, withinRadius, selectedService } = this.state;
        const filteredListings = this.filterListings();

        return (
            <div className="listings-container">
                <h1>Service Listings</h1>
                <div className="search-bar-container">
                    <input
                        type="text"
                        className="search-bar"
                        placeholder="Search for services or businesses..."
                        value={searchTerm}
                        onChange={this.handleSearchChange}
                    />
                    <label className="radius-checkbox">
                        <input
                            type="checkbox"
                            checked={withinRadius}
                            onChange={this.handleRadiusChange}
                        />
                        Search within 20 mi radius
                    </label>
                </div>
                <ul>
                    {filteredListings.map(listing => (
                        <li key={listing.id} className="listing-item">
                            <h2>{listing.serviceName}</h2>
                            <p>{listing.description}</p>
                            <p><span>Price:</span> ${listing.price}</p>
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
                            <h3>Reviews:</h3>
                            <ul className="reviews-list">
                                {listing.reviews.map(review => (
                                    <li key={review.id}>
                                        <p><span>Review:</span> {review.comment} - {review.rating} stars</p>
                                    </li>
                                ))}
                            </ul>
                            <h3>Availability:</h3>
                            <ul className="availability-list">
                                {listing.availability.map(slot => (
                                    <li key={slot.id}>
                                        <p><span>From:</span> {new Date(slot.startTime).toLocaleString()} <span>To:</span> {new Date(slot.endTime).toLocaleString()}</p>
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
