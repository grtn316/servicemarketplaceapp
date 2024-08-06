import { Account } from "./components/pages/Account";
import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { Messages } from "./components/pages/Messages";
import { default as Register } from "./components/pages/Register";
import { SearchListings } from "./components/pages/SearchListings";
import { Appointments } from "./components/pages/Appointments";
import { Listings } from "./components/pages/Listings";
import { Profile } from "./components/pages/Profile";
import { CreateBooking } from "./components/pages/CreateBooking";
import { UserBooking } from "./components/pages/UserBooking"
import { default as Login } from "./components/pages/Login";
import Logout from "./components/pages/Logout";

const AppRoutes = [
    {
        index: true,
        element: <SearchListings />
    },
    {
        path: '/create-booking',
        element: <CreateBooking />
    },
    {
        path: '/user-booking',
        element: <UserBooking />
    },
    {
        path: '/listings',
        element: <Listings />
    },
    {
        path: '/search-listings',
        element: <SearchListings />
    },
    {
        path: '/appointments',
        element: <Appointments />
    },
    {
        path: '/messages',
        element: <Messages />
    },
    {
        path: '/profile',
        element: <Profile />
    },
    {
        path: '/account',
        element: <Account />
    },
    {
        path: '/lin',
        element: <Login />
    },
    {
        path: '/lo',
        element: <Logout />
    },
    {
        path: '/register',
        element: <Register />
    },
    {
        path: '/counter',
        element: <Counter />
    },
    {
        path: '/fetch-data',
        element: <FetchData />
    }
];

export default AppRoutes;
