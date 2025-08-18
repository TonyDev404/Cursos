import AppNav from './AppNav'
import styles from './Sidebar.module.css'
import Logo from './Logo'
import Footer from './Footer'

const SideBar = () => {
    return (
        <div className={styles.sidebar}>
            <Logo />
            <AppNav />

            <p>List of cities</p>
            <Footer />
        </div>
    )
}

export default SideBar