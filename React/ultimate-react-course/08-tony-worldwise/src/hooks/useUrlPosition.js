import { useSearchParams } from "react-router-dom";

export function useUrlPosition() {
    //searchparam se usa para leer query strings
    const [searchParams] = useSearchParams();
    const lat = searchParams.get("lat");
    const lng = searchParams.get("lng");

    return [lat, lng];
}
