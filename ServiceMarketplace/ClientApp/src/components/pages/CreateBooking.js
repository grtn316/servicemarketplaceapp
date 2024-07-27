import React, { Component } from 'react';

export class CreateBooking extends Component {
    static displayName = CreateBooking.name;

    constructor(props) {
        super(props);
        this.state = {
            // businessId: can be retrieved from the loggedin user during submission
            serviceName: "",
            description: "",
            price: "0.00", // any number (double)
            duration: "", // TimeSpanConvert in C# takes a string number (eg. 1000 for 1000 ticks, where there's 10000 ticks in 1 millisecond)
        };
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

        // Calculating duration.
        const index = event.target.selectedIndex;
        const el = event.target.childNodes[index]
        let hours = el.getAttribute('hours');
        let minutes = el.getAttribute('minutes');
        let form_duration = toString(36000000000 * parseInt(hours) + 600000000 * parseInt(minutes)); // ticks conversion (10000 ticks = 1ms, 36000000000 ticks = 1hr, 600000000 ticks = 1min)
        
        this.setState({
            duration: form_duration
        });
        
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
                            <div class="form-check form-check-inline">
                                <input class="form-check-input" type="checkbox" id="sundayBox" value="Sunday" />
                                <label class="form-check-label" for="sundayBox">Sunday</label>
                            </div>
                            <div class="form-check form-check-inline">
                                <input class="form-check-input" type="checkbox" id="mondayBox" value="Monday" />
                                <label class="form-check-label" for="mondayBox">Monday</label>
                            </div>
                            <div class="form-check form-check-inline">
                                <input class="form-check-input" type="checkbox" id="tuesdayBox" value="Tuesday" />
                                <label class="form-check-label" for="tuesdayBox">Tuesday</label>
                            </div>
                            <div class="form-check form-check-inline">
                                <input class="form-check-input" type="checkbox" id="wednesdayBox" value="Wednesday" />
                                <label class="form-check-label" for="wednesdayBox">Wednesday</label>
                            </div>
                            <div class="form-check form-check-inline">
                                <input class="form-check-input" type="checkbox" id="thursdayBox" value="Thursday" />
                                <label class="form-check-label" for="thursdayBox">Thursday</label>
                            </div>
                            <div class="form-check form-check-inline">
                                <input class="form-check-input" type="checkbox" id="fridayBox" value="Friday" />
                                <label class="form-check-label" for="fridayBox">Friday</label>
                            </div>
                            <div class="form-check form-check-inline">
                                <input class="form-check-input" type="checkbox" id="saturdayBox" value="Saturday" />
                                <label class="form-check-label" for="saturdayBox">Saturday</label>
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
