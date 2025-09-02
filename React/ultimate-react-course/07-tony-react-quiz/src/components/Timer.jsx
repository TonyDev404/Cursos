import { useEffect } from "react";
import { useQuiz } from "../Context/QuizContext";

function Timer() {
    const { dispatch, secondsRemaining } = useQuiz();
    
    const mins = Math.floor(secondsRemaining / 60); //We calculate the minutes
    const secs = secondsRemaining % 60;
    useEffect(() => {
        if (secondsRemaining <= 0) return;

        const id = setInterval(function () {
            dispatch({ type: "tick" });
        }, 1000);

        return () => clearInterval(id); // Cleanup function to clear the interval
    }, [dispatch, secondsRemaining]);

    return (
        <div className="timer">
            {mins < 10 && "0"}
            {mins}:{secs < 10 && "0"}
            {secs}
        </div>
    );
}
export default Timer;
