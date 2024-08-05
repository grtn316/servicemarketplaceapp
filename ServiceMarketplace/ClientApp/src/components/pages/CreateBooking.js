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
                          // JSON format: https://learn.microsoft.com/en-us/dotnet/core/compatibility/serialization/6.0/timespan-serialization-format
            hours: "0",
            minutes: "0",
            starthour: "1",
            startminute: "0",
            startperiod: "am",
            sunday: "0",
            monday: "0",
            tuesday: "0",
            wednesday: "0",
            thursday: "0",
            friday: "0",
            saturday: "0",
        };                

        this.handleSubmit = this.handleSubmit.bind(this); // "this" becomes undefined in other functions without this line

        
    }

    calculateDay(today, dayWant) {
        var difference = today - dayWant;
        if (difference <= 0) {
            difference = difference + 7;
        }
        return difference;
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

    changeSunday = (event) => {
        if (this.state.sunday === "0") {
            this.setState({
                sunday: "1"
            })
        } else {
            this.setState({
                sunday: "0"
            })
        }
    }

    changeMonday = (event) => {
        if (this.state.monday === "0") {
            this.setState({
                monday: "1"
            })
        } else {
            this.setState({
                monday: "0"
            })
        }
    }

    changeTuesday = (event) => {
        if (this.state.tuesday === "0") {
            this.setState({
                tuesday: "1"
            })
        } else {
            this.setState({
                tuesday: "0"
            })
        }
    }

    changeWednesday = (event) => {
        if (this.state.wednesday === "0") {
            this.setState({
                wednesday: "1"
            })
        } else {
            this.setState({
                wednesday: "0"
            })
        }
    }

    changeThursday = (event) => {
        if (this.state.thursday === "0") {
            this.setState({
                thursday: "1"
            })
        } else {
            this.setState({
                thursday: "0"
            })
        }
    }

    changeFriday = (event) => {
        if (this.state.friday === "0") {
            this.setState({
                friday: "1"
            })
        } else {
            this.setState({
                friday: "0"
            })
        }
    }

    changeSaturday = (event) => {
        if (this.state.saturday === "0") {
            this.setState({
                saturday: "1"
            })
        } else {
            this.setState({
                saturday: "0"
            })
        }
    }

    changeStartHours = (event) => {
        this.setState({
            starthour: event.target.value
        })
    }

    changeStartMinutes = (event) => {
        this.setState({
            startminute: event.target.value
        })
    }

    changeStartPeriod = (event) => {
        this.setState({
            startperiod: event.target.value
        })
    }


    changeHours = (event) => {
        this.setState({
            hours: event.target.value
        })
    }

    changeMinutes = (event) => {
        this.setState({
            minutes: event.target.value
        })
    }


    handleSubmit = async (event) => {
        event.preventDefault();

        let { businessId, serviceName, description, price, duration, hours, minutes, sunday, monday, tuesday, wednesday, thursday, friday, saturday, starthour, startminute, startperiod} = this.state;

        // Calculating duration.
        businessId = "1"; // TODO: RETRIEVE BUSINESS ID, USING DUMMY BUSINESS ID FOR NOW.
        var now = new Date();
        var dayOfWeek = now.getDay(); // 0 = sunday, 1 = monday,...
        var displaceDay = 0;
        var extraDay = 0;
        starthour = parseInt(starthour);
        hours = parseInt(hours);
        startminute = parseInt(startminute);
        minutes = parseInt(minutes);

        var finalminute = startminute + minutes;
        var finalhour = starthour + hours;

        if (startperiod === "pm") {
            starthour = starthour + 12;
        }
        if (finalminute >= 60) {
            finalminute = finalminute - 60;
            finalhour = finalhour + 1;
        }
        if (finalhour >= 24) {
            finalhour = finalhour - 24;
            extraDay = extraDay + 1;
        }


        var timeSlots = [];


        // get current date
        // get wanted days + start time (hour,min,AM/PM) + duration (hour, min)

        var startday;
        var endday;

        if (sunday === "1") {
            displaceDay = this.calculateDay(dayOfWeek, 0);
            startday = new Date(new Date().getTime() + displaceDay * 24 * 60 * 60 * 1000);
            startday.setHours(starthour, startminute, 0);
            startday.toISOString();
            endday = new Date(new Date().getTime() + (displaceDay + extraDay) * 24 * 60 * 60 * 1000);
            endday.setHours(finalhour, finalminute, 0);
            endday.toISOString();
            timeSlots.push({
                startTime: startday,
                endTime: endday,
            })
        }
        if (monday === "1") {

        }
        if (tuesday === "1") {

        }
        if (wednesday === "1") {

        }
        if (thursday === "1") {

        }
        if (friday === "1") {

        }
        if (saturday === "1") {

        }

        const serviceData = {
            businessId: businessId,
            serviceName: serviceName,
            description: description,
            price: price,
            duration: duration,
            rating: 0, // no reviews
            reviews: [ //no reviews
            ],
            timeSlots: timeSlots
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

                        

                        {/*Set Availability*/}
                        <label htmlFor="service-availability" className="form-label">Availability</label>

                        {/*Days*/}
                        <div className="form-group">
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="sundayBox" value="Sunday"
                                    onChange={this.changeSunday}/>
                                <label className="form-check-label" htmlFor="sundayBox">Sunday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="mondayBox" value="Monday"
                                    onChange={this.changeMonday} />
                                <label className="form-check-label" htmlFor="mondayBox">Monday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="tuesdayBox" value="Tuesday"
                                    onChange={this.changeTuesday} />
                                <label className="form-check-label" htmlFor="tuesdayBox">Tuesday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="wednesdayBox" value="Wednesday"
                                    onChange={this.changeWednesday} />
                                <label className="form-check-label" htmlFor="wednesdayBox">Wednesday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="thursdayBox" value="Thursday"
                                    onChange={this.changeThursday} />
                                <label className="form-check-label" htmlFor="thursdayBox">Thursday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="fridayBox" value="Friday"
                                    onChange={this.changeFriday} />
                                <label className="form-check-label" htmlFor="fridayBox">Friday</label>
                            </div>
                            <div className="form-check form-check-inline">
                                <input className="form-check-input" type="checkbox" id="saturdayBox" value="Saturday"
                                    onChange={this.changeSaturday} />
                                <label className="form-check-label" htmlFor="saturdayBox">Saturday</label>
                            </div>
                        </div>
                        <br></br>

                        {/*Time Range*/}

                        {/*Start Time*/}
                        <div className="row">
                            <label htmlFor="service-duration">Start</label>
                            <div className="form-group col-md-1">
                                <select id="start-hours" className="form-control" onChange={this.changeStartHours}>
                                    <option>1</option><option>2</option><option>3</option><option>4</option><option>5</option><option>6</option>
                                    <option>7</option><option>8</option><option>9</option><option>10</option><option>11</option><option>12</option>                                </select>

                            </div>
                            <div className="form-group col-md-1">
                                <select id="start-minutes" className="form-control" onChange={this.changeStartMinutes}>
                                    <option value="0">00</option><option>15</option><option>30</option><option>45</option>
                                </select>
                            </div>
                            <div className="form-group col-md-1">
                                <select id="start-period" className="form-control" placeholder="am" onChange={this.changeStartPeriod}>
                                    <option>am</option><option>pm</option>
                                </select>
                            </div>
                        </div>

                        {/*Duration*/}
                        <div className="row">
                            <label htmlFor="service-duration">Duration</label>


                            {/*Hours*/}
                            <div className="form-group col-md-1">
                                <p>Hours</p>
                                <select id="hours" className="form-control" placeholder="0" onChange={this.changeHours}>
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
                                <select id="minutes" className="form-control" placeholder="0" onChange={this.changeMinutes}>
                                    <option>0</option><option>15</option><option>30</option><option>45</option>
                                </select>
                            </div>
                        </div>
                        <br></br>

                        {/*End Time*/}
                        {/*<div className="row">*/}
                        {/*    <label htmlFor="service-duration">End</label>*/}
                        {/*    <div className="form-group col-md-1">*/}
                        {/*        <select id="end-hours" className="form-control">*/}
                        {/*            <option>1</option><option>2</option><option>3</option><option>4</option><option>5</option><option>6</option>*/}
                        {/*            <option>7</option><option>8</option><option>9</option><option>10</option><option>11</option><option>12</option></select>*/}

                        {/*    </div>*/}
                        {/*    <div className="form-group col-md-1">*/}
                        {/*        <select id="end-minutes" className="form-control">*/}
                        {/*            <option>00</option><option>15</option><option>30</option><option>45</option>*/}
                        {/*        </select>*/}
                        {/*    </div>*/}
                        {/*    <div className="form-group col-md-1">*/}
                        {/*        <select id="end-period" className="form-control" placeholder="am">*/}
                        {/*            <option>am</option><option>pm</option>*/}
                        {/*        </select>*/}
                        {/*    </div>*/}
                        {/*</div>*/}
                        {/*<br></br>*/}

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






