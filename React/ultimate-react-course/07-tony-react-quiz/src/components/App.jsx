import Header from "./Header";
import Principal from "./Principal";
import Loader from "./Loader";
import Error from "./Error";
import Question from "./Question";
import NextButton from "./NextButton";
import StartScreen from "./StartScreen";
import Progress from "./Progress";
import FinishScreen from "./FinishScreen";
import Footer from "./Footer";
import Timer from "./Timer";
import { useQuiz } from "../Context/QuizContext";

export default function App() {
    const { status } = useQuiz();
    return (
        <div className="app">
            <Header />
            <Principal>
                {status === "loading" && <Loader />}
                {status === "error" && <Error />}
                {status === "ready" && <StartScreen />}
                {status === "active" && (
                <>
                    <Progress />
                    <Question />
                    <Footer>
                    <Timer />
                    <NextButton />
                    </Footer>
                </>
                )}
                {status == "finished" && <FinishScreen />}
            </Principal>
        </div>
    );
}

// "server": "json-server --watch data/questions.json --port 8000" // "json-server" is used to mock a backend server
