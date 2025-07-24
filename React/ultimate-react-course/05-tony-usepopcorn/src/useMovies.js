import { useEffect, useState } from "react";


const KEY = "3d5c8b5e";

export function useMovies(query) {
    const [movies, setMovies] = useState([]);
    const [isLoading, setIsLoading] = useState(false);
    const [error, setError] = useState("");
    
    useEffect(
        function () {
            // callback?.();
            const controller = new AbortController(); //Para poder cancelar la petición si el usuario cambia la búsqueda antes de que se complete

            async function fetchMovies() {
                try {
                setIsLoading(true);
                setError("");
                const res = await fetch(
                    `http://www.omdbapi.com/?apikey=${KEY}&s=${query}`, {signal: controller.signal}
                );

                if (!res.ok)
                    throw new Error("Something went wrong with fetching movies");

                const data = await res.json();

                if (data.Response === "False") throw new Error("Movie not found");

                setMovies(data.Search);
                setError("");
                
                } catch (err) {
                
                if(err.name !== "AbortError") {
                    console.error(err.message);
                    setError(err.message);
                }

                } finally {
                setIsLoading(false);
                }
            }

            if (query.length < 3) {
                setMovies([]);
                setError("");
                return;
            }

            //Borramos la película antes de que el usuario haga una busqueda
            fetchMovies();

            console.log("Aborting previous request")

            return function()
            {
                controller.abort();
            };
            },[query]
    ); //Se ejecuta cada vez que cambia la query

    return {movies, isLoading, error};
}