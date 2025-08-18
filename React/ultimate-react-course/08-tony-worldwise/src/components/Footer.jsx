import styles from "./Footer.module.css"

const Footer = () => {
    return (
        <footer className={styles.footer}>
            <p className={styles.copyright}>
                &copy; Copyright {new Date().getFullYear()} Tonys Worldwise
            </p>
        </footer>
    )
}

export default Footer