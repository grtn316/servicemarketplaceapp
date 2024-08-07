﻿import React, { Component } from 'react';
import './UserBooking.css';

export class UserBooking extends Component {
    static displayName = UserBooking.name;

    constructor(props) {
        super(props);
        this.state = {
            selectedSlot: null,
            customerId: null
        };
    }

    componentDidMount() {
        this.fetchCustomerId();
    }

    fetchCustomerId = async () => {
        try {
            const response = await fetch('/pingauth');
            if (!response.ok) {
                throw new Error('Failed to fetch customer ID');
            }
            const user = await response.json();
            this.setState({ customerId: user.id });
        } catch (error) {
            console.error('Error fetching customer ID:', error);
        }
    };

    handleSlotChange = (event) => {
        this.setState({ selectedSlot: event.target.value });
    }

    handleSubmit = async (event) => {
        event.preventDefault();
        const { service, updateServiceAvailability } = this.props;
        const { selectedSlot, customerId } = this.state;

        const selectedAvailability = service.availability.find(slot => slot.id === parseInt(selectedSlot));

        if (!selectedAvailability) {
            alert('Please select an available time slot.');
            return;
        }

        const booking = {
            serviceId: service.id,
            customerId: customerId, // Use the actual customer ID
            timeSlotId: selectedAvailability.id, // Include the selected time slot ID
            status: 0 // Confirmed status
        };

        try {
            const response = await fetch('/api/booking', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(booking)
            });

            if (response.ok) {
                const updatedAvailability = service.availability.filter(slot => slot.id !== parseInt(selectedSlot));
                updateServiceAvailability(service.id, updatedAvailability);
                alert('Booking successfully submitted!');
            } else {
                alert('There was an error submitting the booking. Please try again.');
            }
        } catch (error) {
            console.error('Error submitting booking:', error);
            alert('There was an error submitting the booking. Please try again.');
        }
    }

    render() {
        const { service } = this.props;
        const { selectedSlot } = this.state;

        return (
            <div className="booking-form">
                <form onSubmit={this.handleSubmit}>
                    <div className="container-sm">
                        {/* Service Name */}
                        <div className="form-group">
                            <label className="form-label">Service Name</label>
                            <p className="form-control-static">{service.serviceName}</p>
                        </div>
                        <br />

                        {/* Description */}
                        <div className="form-group">
                            <label className="form-label">Description</label>
                            <p className="form-control-static">{service.description}</p>
                        </div>
                        <br />

                        {/* Price */}
                        <div className="form-group">
                            <label className="form-label">Price</label>
                            <p className="form-control-static">${service.price}</p>
                        </div>
                        <br />

                        {/* Duration */}
                        <div className="form-group">
                            <label className="form-label">Duration</label>
                            <p className="form-control-static">{service.duration}</p>
                        </div>
                        <br />

                        {/* Set Availability */}
                        <label className="form-label">Availability</label>
                        <div className="form-group">
                            {service.availability.map(slot => (
                                <div key={slot.id} className="form-check form-check-inline">
                                    <input
                                        className="form-check-input"
                                        type="radio"
                                        id={`availability-${slot.id}`}
                                        name="availability"
                                        value={slot.id}
                                        checked={selectedSlot === slot.id.toString()}
                                        onChange={this.handleSlotChange}
                                    />
                                    <label className="form-check-label" htmlFor={`availability-${slot.id}`}>
                                        {new Date(slot.startTime).toLocaleString()} - {new Date(slot.endTime).toLocaleString()}
                                    </label>
                                </div>
                            ))}
                        </div>
                        <br />

                        {/* Submit */}
                        <div>
                            <button className="btn btn-primary" type="submit">Submit</button>
                        </div>
                    </div>
                </form>
            </div>
        );
    }
}


