

import styles from "./AppLayout.module.css";
import AppNav from "../components/AppNav";

function AppLayout() {
    return (
        <div className={styles.app}>
            <AppNav />
        </div>
    );
}

export default AppLayout;