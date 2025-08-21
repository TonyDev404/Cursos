import PropTypes from "prop-types";
import Spinner from "./Spinner";
import styles from "./CountryList.module.css";
import CountryItem from "./CountryItem";
import Message from "./Message";

const CountryList = ({ cities, isLoading }) => {
    if (isLoading) return <Spinner />;

    if (!cities.length)
        return (
            <Message message="Add you first city on a city on the map" />
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
        } else {
            return arr;
        }
    }, []);

    return (
        <ul className={styles.cityList}>
            {countries.map((country) => (
                <CountryItem
                    country={country}
                    key={country.id}
                />
            ))}
        </ul>
    );
};

CountryList.propTypes = {
    cities: PropTypes.arrayOf(
        PropTypes.shape({
            id: PropTypes.oneOfType([
                PropTypes.string,
                PropTypes.number,
            ]).isRequired,
            name: PropTypes.string,
            country: PropTypes.string,
        })
    ).isRequired,
    isLoading: PropTypes.bool.isRequired,
};

export default CountryList;
