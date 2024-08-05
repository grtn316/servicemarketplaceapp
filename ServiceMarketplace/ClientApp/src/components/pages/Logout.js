import { useEffect } from "react";
import { useNavigate } from "react-router-dom";

function Logout() {
    const navigate = useNavigate();

    useEffect(() => {
        const handleSubmit = () => {
            fetch("/logout", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: ""
            })
                .then((data) => {
                    if (data.ok) {
                        navigate("/lin");
                        window.location.reload();
                    }
                })
                .catch((error) => {
                    console.error(error);
                    navigate("/lin");
                    window.location.reload();
                });
        };

        handleSubmit();
    }, [navigate]);

    return null;
}

export default Logout;
