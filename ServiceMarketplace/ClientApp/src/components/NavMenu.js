import React, { Component } from 'react';
import { Collapse, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link, withRouter } from 'react-router-dom';
import './NavMenu.css';
import AuthorizeView, { AuthorizedUser } from '../components/utils/authorize';


export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = {
            collapsed: true,
            accountType: null,
            activeLink: null,
        };
    }

    componentDidMount() {
        this.fetchAccountType();
        this.setActiveLink();

    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
    }

    setActiveLink() {
        const currentPath = window.location.pathname;

        if (currentPath === '/') {
            this.setState({ activeLink: "/" });
        } else if (currentPath === '/create-booking') {
            this.setState({ activeLink: "/create-booking" });
            //console.log(this.state.activeLink);
        } else if (currentPath === '/listings') {
            this.setState({ activeLink: "/listings" });
        } else if (currentPath === '/search-listings') {
            this.setState({ activeLink: "/search-listings" });
        } else if (currentPath === '/appointments') {
            this.setState({ activeLink: "/appointments" });
        } else if (currentPath === '/messages') {
            this.setState({ activeLink: "/messages" });
        } else if (currentPath === '/profile') {
            this.setState({ activeLink: "/profile" });
        } else if (currentPath === '/account') {
            this.setState({ activeLink: "/account" });
        }
        //console.log(currentPath);
        //console.log(this.state.activeLink);
    }

    fetchAccountType = async () => {
        try {
            const response = await fetch('/pingauth');
            if (!response.ok) {
                throw new Error('User not logged in.');
            }
            const user = await response.json();
            this.setState({ accountType: user.accountType });
        } catch (error) {
            console.error('Error fetching user info:', error);

        }
    };

    isActive = (path) => {
        console.log(window.location.pathname);
        return window.location.pathname === path ? 'bg-gray' : ''; //select menu item
    };

    render() {

        const { accountType, activeLink } = this.state;
        console.log(activeLink);

        return (
            <header>
                <Navbar id="navbar" className="navbar-expand-sm navbar-toggleable-sm border-bottom box-shadow mb-3" container light>
                    <NavbarBrand tag={Link} to="/">ServiceMarketplace</NavbarBrand>
                    <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
                    <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
                        <ul className="navbar-nav flex-grow">
                            {accountType !== null && (
                                <>
                                    <NavItem>
                                        <NavLink tag={Link} to="/" className={activeLink === "/" ? "selectedLink" : ""}>Home</NavLink>
                                    </NavItem>
                                    {accountType === 1 && (
                                        <>
                                            <NavItem>
                                                <NavLink tag={Link} to="/create-booking" className={activeLink === "/create-booking" ? "selectedLink" : ""}>Create Listing</NavLink>
                                            </NavItem>
                                        </>
                                    )}
                                    <NavItem>
                                        <NavLink tag={Link} to="/listings" className={activeLink === "/listings" ? "selectedLink" : ""} activeClassName="selectedLink">My Bookings</NavLink>
                                    </NavItem>
                                    <NavItem>
                                        <NavLink tag={Link} to="/search-listings" className={activeLink === "/search-listings" ? "selectedLink" : ""}>Search</NavLink>
                                    </NavItem>
                                    {accountType === 1 && (
                                        <>
                                            <NavItem>
                                                <NavLink tag={Link} to="/appointments" className={activeLink === "/appointments" ? "selectedLink" : ""}>Appointments</NavLink>
                                            </NavItem>

                                            <NavItem>
                                                <NavLink tag={Link} to="/messages" >Messages</NavLink>
                                            </NavItem>
                                        </>
                                    )}
                                    <NavItem>
                                        <NavLink tag={Link} to="/profile" className={activeLink === "/profile" ? "selectedLink" : ""}>My Profile</NavLink>
                                    </NavItem>
                                    {accountType === 1 && (
                                        <>
                                            <NavItem>
                                                <NavLink tag={Link} to="/account" className={activeLink === "/account" ? "selectedLink" : ""}>Account</NavLink>
                                            </NavItem>
                                        </>
                                    )}
                                    {/*<NavItem>*/}
                                    {/*    <NavLink tag={Link} className="text-dark" to="/lin">Login</NavLink>*/}
                                    {/*</NavItem>*/}
                                    {/*<NavItem>*/}
                                    {/*    <NavLink tag={Link} className="text-dark" to="/register">Register</NavLink>*/}
                                    {/*</NavItem>*/}
                                    <NavItem>
                                        <NavLink tag={Link} to="/lo">Logout</NavLink>
                                    </NavItem>


                                    {/*<NavItem>*/}
                                    {/*  <NavLink tag={Link} className="text-dark" to="/counter">Counter</NavLink>*/}
                                    {/*</NavItem>*/}
                                    {/*<NavItem>*/}
                                    {/*  <NavLink tag={Link} className="text-dark" to="/fetch-data">Fetch data</NavLink>*/}
                                    {/*</NavItem>*/}
                                </>
                            )}
                        </ul>
                    </Collapse>
                </Navbar>
            </header>
        );
    }
}