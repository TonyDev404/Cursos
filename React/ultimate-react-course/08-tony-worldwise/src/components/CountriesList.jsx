/* eslint-disable react/prop-types */
import Spinner from "./Spinner";
import styles from "./CityList.module.css";
import CountriesItem from "./CountriesItem";
import Message from "./Message";
import { useCities } from "../Contexts/CitiesContext";

function CityList() {

    const {cities, isLoading} = useCities();

    if (isLoading) return <Spinner />;

    if (!cities.length)
        return (
            <Message mesage="Add your first country by clicking on a city on the map" />
        );

    const countries = cities.reduce((arr, city) => {
        if (
            !arr.map((el) => el.country).includes(city.country)
        ) {
            return [
                ...arr,
                {
                    country: city.country,
                    emoji: city.emoji,
                },
            ];
        } 
        else {
            return arr;
        }
    }, []);

    return (
        <ul className={styles.countryList}>
            {countries.map((country) => (
                <CountriesItem
                    country={country}
                    key={country.country}
                />
            ))}
        </ul>
    );
}

export default CityList;
