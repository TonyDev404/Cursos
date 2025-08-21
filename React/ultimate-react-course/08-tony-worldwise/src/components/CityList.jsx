import PropTypes from "prop-types";
import Spinner from "./Spinner";
import styles from "./CityList.module.css";
import CityItem from "./CityItem";
import Message from "./Message";

const CityList = ({ cities, isLoading }) => {
    if (isLoading) return <Spinner />;

    if(!cities.length) return  <Message message="Add you first city on a city on the map" />

    return (
        <ul className={styles.cityList}>
            {cities.map(city => (
                <CityItem city={city} key={city.id} />
            ))}
        </ul>
    );
};

CityList.propTypes = {
    cities: PropTypes.arrayOf(
        PropTypes.shape({
            id: PropTypes.oneOfType([
                PropTypes.string,
                PropTypes.number,
            ]).isRequired,
            name: PropTypes.string, // ajusta según tu API
            country: PropTypes.string, // ajusta según tu API
        })
    ).isRequired,
    isLoading: PropTypes.bool.isRequired,
};

export default CityList;
