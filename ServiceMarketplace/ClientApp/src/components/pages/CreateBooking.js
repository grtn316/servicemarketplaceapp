import React, { Component } from 'react';

export class CreateBooking extends Component {
    static displayName = CreateBooking.name;
    /* form submission resources: https://www.youtube.com/watch?v=7Vo_VCcWupQ */

    constructor(props) {
        super(props)

        this.state = {
            serviceName: "",
            description: "",
            cost: "", // number or string?, need number validation?
            duration: "" // number or string?, need number validation?

        }
    }

    changeServiceName = (event) => {
        this.setState({
            serviceName: event.target.value
        })
    }

    changeDescription = (event) => {
        this.setState({
            description: event.target.value
        })
    }

    changeCost = (event) => {
        this.setState({
            cost: event.target.value
        })
    }

    changeDuration = (event) => {
        this.setState({
            duration: event.target.value
        })
    }

    handleSubmit = (event) => {
        event.preventDefault();
        console.log(this.state.serviceName, this.state.description, this.state.cost, this.state.duration);



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

                        {/*Cost*/}
                        <div className="form-group col-3">
                            <label htmlFor="cost" className="form-label">Cost</label>
                            <input className="form-control"
                                placeholder="19.99"
                                value={this.state.cost}
                                onChange={this.changeCost}
                            /> {/* unit of currency (dollars?/$)*/}
                        </div>

                        {/*Duration*/}
                        <div className="form-group col-3">
                            <label htmlFor="duration" className="form-label">Duration</label>
                            <input className="form-control"
                                placeholder="2"
                                value={this.state.duration}
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
