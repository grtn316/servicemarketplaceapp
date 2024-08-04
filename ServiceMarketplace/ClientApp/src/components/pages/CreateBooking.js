import React, { Component } from 'react';
import './CreateBooking.css';

export class CreateBooking extends Component {
    static displayName = CreateBooking.name;

    constructor(props) {
        super(props);
        this.state = {
            businessId: "", // can be retrieved from the loggedin user during submission
            serviceName: "",
            description: "",
            price: "0", // any number (double)
            duration: "", // TimeSpanConvert in C# takes the following format:
        };                // JSON format: https://learn.microsoft.com/en-us/dotnet/core/compatibility/serialization/6.0/timespan-serialization-format

        this.handleSubmit = this.handleSubmit.bind(this); // "this" becomes undefined in other functions without this line
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

    changePrice = (event) => {
        this.setState({
            price: event.target.value
        })
    }

    handleSubmit = async (event) => {
        event.preventDefault();

        let { businessId, serviceName, description, price, duration } = this.state;

        // Calculating duration.
        //let hours = this.props.hours; // this is wrong
        //let minutes = this.props.minutes; // this is wrong
        duration = "2.00:00:01"; // TODO: properly format duration, using test duration
        businessId = "1"; // TODO: RETRIEVE BUSINESS ID, USING DUMMY BUSINESS ID FOR NOW.


        const serviceData = {
            businessId: businessId,
            serviceName: serviceName,
            description: description,
            price: price,
            duration: duration,
            rating: 0, // no reviews
            reviews: [ //no reviews
            ],
            timeSlots: [
                {
                    startTime: new Date().toISOString(),
                    endTime: new Date(new Date().getTime() + 60 * 60 * 1000).toISOString()
                }
            ]
        };

        // POST request to the service controller.
        // Persist new service listing to the controller/database.
        const response = await fetch('/api/service',
            {
                method: 'POST',
                headers: {
                    "Content-Type": "application/json",
                },
                //body: JSON.stringify({ businessId, serviceName, description, price, duration })
                body: JSON.stringify(serviceData)
            }
        ).then(r => r.json());
    }

    render() {

        return (
            <>
                <form onSubmit={this.handleSubmit}>
                    <div className="container-sm col-10" >
                        {/*Service Name*/}
                        <div className="form-group col-3">
                            <label htmlFor="service-name" className="form-label">Service Name</label>
                            <input className="form-control"
                                placeholder="Service"
                                value={this.state.serviceName}
                                onChange={this.changeServiceName} />
                        </div>
                        <br></br>

                        {/*Description*/}
                        <div className="form-group col-3">
                            <label htmlFor="service-description" className="form-label">Description</label>
                            <textarea className="form-control"
                                placeholder="Description"
                                value={this.state.description}
                                onChange={this.changeDescription} />
                        </div>
                        <br></br>


                        {/*Price*/}
                        <div className="form-group col-3">
                            <label htmlFor="service-price" className="form-label">Price</label>
                            <input className="form-control" placeholder="Price"
                                value={this.state.Price}
                                onChange={this.changePrice} />
                        </div>
                        <br></br>

                        {/*Duration*/}
                        <div className="row">
                            <label htmlFor="service-duration">Duration</label>


                            {/*Hours*/}
                            <div className="form-group col-md-1">
                                <p>Hours</p>
                                <select id="hours" className="form-control" placeholder="0">
                                    <option>0</option>
                                    <option>1</option><option>2</option><option>3</option><option>4</option><option>5</option><option>6</option>
                                    <option>7</option><option>8</option><option>9</option><option>10</option><option>11</option><option>12</option>
                                    <option>13</option><option>14</option><option>15</option><option>16</option><option>17</option><option>18</option>
                                    <option>19</option><option>20</option><option>21</option><option>22</option><option>23</option><option>24</option>
                                </select>

                            </div>

                            {/*Minutes*/}
                            <div className="form-group col-md-1">
                                <p>Minutes</p>
                                <select id="minutes" className="form-control" placeholder="0">
                                    <option>0</option><option>15</option><option>30</option><option>45</option>
                                </select>
                            </div>
                        </div>
                        <br></br>

                        {/*Set Availability*/}
                        <label htmlFor="service-availability" className="form-label">Availability</label>

                        {/*Days*/}
                        <div className="form-group">
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="sundayBox" value="Sunday" />
                                <label className="form-check-label" htmlFor="sundayBox">Sunday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="mondayBox" value="Monday" />
                                <label className="form-check-label" htmlFor="mondayBox">Monday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="tuesdayBox" value="Tuesday" />
                                <label className="form-check-label" htmlFor="tuesdayBox">Tuesday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="wednesdayBox" value="Wednesday" />
                                <label className="form-check-label" htmlFor="wednesdayBox">Wednesday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="thursdayBox" value="Thursday" />
                                <label className="form-check-label" htmlFor="thursdayBox">Thursday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="fridayBox" value="Friday" />
                                <label className="form-check-label" htmlFor="fridayBox">Friday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="saturdayBox" value="Saturday" />
                                <label className="form-check-label" htmlFor="saturdayBox">Saturday</label>
                            </div>
                        </div>
                        <br></br>

                        {/*Time Range*/}

                        {/*Start Time*/}
                        <div className="row">
                            <label htmlFor="service-duration">Start</label>
                            <div className="form-group col-md-1">
                                <select id="start-hours" className="form-control">
                                    <option>1</option><option>2</option><option>3</option><option>4</option><option>5</option><option>6</option>
                                    <option>7</option><option>8</option><option>9</option><option>10</option><option>11</option><option>12</option>                                </select>

                            </div>
                            <div className="form-group col-md-1">
                                <select id="start-minutes" className="form-control">
                                    <option>00</option><option>15</option><option>30</option><option>45</option>
                                </select>
                            </div>
                            <div className="form-group col-md-1">
                                <select id="start-period" className="form-control" placeholder="am">
                                    <option>am</option><option>pm</option>
                                </select>
                            </div>
                        </div>

                        {/*End Time*/}
                        <div className="row">
                            <label htmlFor="service-duration">End</label>
                            <div className="form-group col-md-1">
                                <select id="end-hours" className="form-control">
                                    <option>1</option><option>2</option><option>3</option><option>4</option><option>5</option><option>6</option>
                                    <option>7</option><option>8</option><option>9</option><option>10</option><option>11</option><option>12</option></select>

                            </div>
                            <div className="form-group col-md-1">
                                <select id="end-minutes" className="form-control">
                                    <option>00</option><option>15</option><option>30</option><option>45</option>
                                </select>
                            </div>
                            <div className="form-group col-md-1">
                                <select id="end-period" className="form-control" placeholder="am">
                                    <option>am</option><option>pm</option>
                                </select>
                            </div>
                        </div>
                        <br></br>

                        {/*Submit*/}
                        <div>
                            <button className="btn btn-primary" type="submit">Submit</button>
                        </div>
                    </div>
                </form>
            </>

                
                

        );
    }
}






