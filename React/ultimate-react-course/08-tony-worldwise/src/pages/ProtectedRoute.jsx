/* eslint-disable react/prop-types */
import { useEffect } from "react";
import { useAuth } from "../Contexts/FakeAuthContext";
import { useNavigate } from "react-router-dom";

function ProtectedRoute({ children }) {
    const { isAuthenticated } = useAuth();
    const navigate = useNavigate();

    useEffect(
        function () {
            if (!isAuthenticated) {     
                navigate("/");
            }
        },
        [isAuthenticated, navigate]
    );

    //Preguntamos si esta autenticado y si es falso devolvemos null para no tener problemas con los datos de User que se renderizan
    return isAuthenticated ? children : null;
}

export default ProtectedRoute;
