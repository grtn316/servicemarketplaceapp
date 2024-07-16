import React, { Component } from 'react';

export class CreateBooking extends Component {
    static displayName = CreateBooking.name;
    /* form submission resources: https://www.youtube.com/watch?v=7Vo_VCcWupQ */

    constructor(props) {
        super(props)

        this.state = {
            Id: "",
            BusinessId: "",
            ServiceName: "",
            Description: "",
            Price: "", // number or string?, need number validation?
            duration: "" // number or string?, need number validation?

        }
    }

    changeServiceName = (event) => {
        this.setState({
            ServiceName: event.target.value
        })
    }

    changeDescription = (event) => {
        this.setState({
            Description: event.target.value
        })
    }

    changePrice = (event) => {
        this.setState({
            Price: event.target.value
        })
    }

    changeDuration = (event) => {
        this.setState({
            Duration: event.target.value
        })
    }

    handleSubmit = async (event) => {
        event.preventDefault();

        // TEMPORARY: Need a way to assign unique ids.
        this.setState({
            Id: 0,
            BusinessId: 0
        });

        console.log(this.state.Id, this.state.BusinessId, this.state.ServiceName, this.state.Description, this.state.Price, this.state.Duration);

        // POST request to the service controller.
        // Persist new service listing to the controller/database.
        const response = await fetch('/api/service',
            {
                method: 'POST',
                body: JSON.stringify(this.state)
            }
        ).then(r => r.json());

    }

    render() {

        return (
            <>
                {/* This layout is for create a detailed listing as a business owner.
                    This is NOT for creating a booking. Just using this page as a placeholder.
                */}

                <form onSubmit={this.handleSubmit}>
                    <div className="container" >
                        {/*Service Name*/}
                        <div className="form-group col-3">
                            <label htmlFor="serviceName" className="form-label">Service Name</label>
                            <input className="form-control"
                                placeholder="Service Name"
                                value={this.state.serviceName}
                                onChange={this.changeServiceName} />
                        </div>

                        {/*Description*/}
                        <div className="form-group col-3">
                            <label htmlFor="description" className="form-label">Description</label>
                            <input
                                className="form-control"
                                placeholder="Description"
                                value={this.state.description}
                                onChange={this.changeDescription}
                            />
                        </div>

                        {/*Price*/}
                        <div className="form-group col-3">
                            <label htmlFor="price" className="form-label">Price</label>
                            <input className="form-control"
                                placeholder="19.99"
                                value={this.state.Price}
                                onChange={this.changePrice}
                            /> {/* unit of currency (dollars?/$)*/}
                        </div>

                        {/*Duration*/}
                        <div className="form-group col-3">
                            <label htmlFor="duration" className="form-label">Duration</label>
                            <input className="form-control"
                                placeholder="2"
                                value={this.state.Duration}
                                onChange={this.changeDuration}
                            /> {/* unit of time? (hours?) */}
                        </div>

                        {/*Submit*/}
                        <div>
                            <button className="btn btn-primary" type="submit">Create Listing</button>
                        </div>
                    </div>
                </form>


            </>
        );
    }
}
