import React, { Component } from 'react';
import './CreateBooking.css';

export class CreateBooking extends Component {
    static displayName = CreateBooking.name;

    constructor(props) {
        super(props);
        this.state = {
            selectedSlot: null,
            errorMessage: '',
            bookingSuccessful: false
        };
    }

    handleSlotChange = (event) => {
        this.setState({ selectedSlot: event.target.value });
    }

    handleSubmit = async (event) => {
        event.preventDefault();

        const { service } = this.props;
        const { selectedSlot } = this.state;

        if (!selectedSlot) {
            this.setState({ errorMessage: 'Please select a time slot.' });
            return;
        }

        const selectedSlotDetails = service.availability.find(slot => slot.id.toString() === selectedSlot);

        const booking = {
            startTime: selectedSlotDetails.startTime,
            endTime: selectedSlotDetails.endTime,
            duration: selectedSlotDetails.endTime - selectedSlotDetails.startTime,
            serviceId: service.id,
            customerID: 1, // Example customer ID, replace with actual logged-in user ID
            businessID: service.business.id,
            cost: service.price,
            status: 'Confirmed'
        };

        console.log('Booking data to be sent:', booking);

        try {
            const response = await fetch('/api/Booking', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(booking)
            });

            if (response.ok) {
                this.setState({ bookingSuccessful: true });
                alert('Booking successful!');
                // Remove the booked slot from availability
                const updatedAvailability = service.availability.filter(slot => slot.id !== selectedSlotDetails.id);
                this.props.updateServiceAvailability(service.id, updatedAvailability);
            } else {
                const errorData = await response.json();
                console.error('Error response:', errorData);
                this.setState({ errorMessage: `Booking failed: ${response.statusText}` });
            }
        } catch (error) {
            console.error('There was an error submitting the booking!', error);
            this.setState({ errorMessage: 'There was an error submitting the booking. Please try again.' });
        }
    }

    render() {
        const { service } = this.props;
        const { selectedSlot, errorMessage, bookingSuccessful } = this.state;

        return (
            <div className="booking-form">
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
                        <p className="form-control-static">{`${Math.floor(service.duration / 60)} hours ${service.duration % 60} minutes`}</p>
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
                                    disabled={bookingSuccessful}
                                />
                                <label className="form-check-label" htmlFor={`availability-${slot.id}`}>
                                    {slot.startTime.toLocaleString()} - {slot.endTime.toLocaleString()}
                                </label>
                            </div>
                        ))}
                    </div>
                    <br />

                    {errorMessage && <p className="text-danger">{errorMessage}</p>}

                    {/* Submit */}
                    <div>
                        <button className="btn btn-primary" type="submit" onClick={this.handleSubmit} disabled={bookingSuccessful}>Submit</button>
                    </div>
                </div>
            </div>
        );
    }
}






