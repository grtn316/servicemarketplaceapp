import React from 'react';
import { useNavigate } from 'react-router-dom';

function withNavigate(Component) {
    return function WrapperComponent(props) {
        const navigate = useNavigate();
        return <Component {...props} navigate={navigate} />;
    };
}

export default withNavigate;
