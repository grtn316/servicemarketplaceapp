import React, { Component } from 'react';

export class CreateBooking extends Component {
    static displayName = CreateBooking.name;

    render() {
        const placeholderFunction = () => {

        }

        return (
            <>
                <div className="container-sm col-10" >
                    {/*Service Name*/}
                    <div className="form-group col-3">
                        <label htmlFor="service-name" className="form-label">Service Name</label>
                        <input className="form-control" placeholder="Service" />
                    </div>
                    <br></br>

                    {/*Description*/}
                    <div className="form-group col-3">
                        <label htmlFor="service-description" className="form-label">Description</label>
                        <textarea className="form-control" placeholder="Description" />
                    </div>
                    <br></br>


                    {/*Price*/}
                    <div className="form-group col-3">
                        <label htmlFor="service-price" className="form-label">Price</label>
                        <input className="form-control" placeholder="Price" />
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
                                <option>7</option><option>8</option><option>9</option><option>10</option><option>11</option><option>12</option>                                </select>

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
                        <button className="btn btn-primary" type="submit" onClick={placeholderFunction}>Submit</button>
                    </div>
                </div>
            </>
        );
    }
}
