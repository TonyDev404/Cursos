import {
    createContext,
    useContext,
    useEffect,
    useMemo,
    useState,
} from "react";
import { faker } from "@faker-js/faker";

function createRandomPost() {
    return {
        title: `${faker.hacker.adjective()} ${faker.hacker.noun()}`,
        body: faker.hacker.phrase(),
    };
}

//1) Create a context
const PostContext = createContext();

function PostProvider({ children }) {
    const [isFakeDark, setIsFakeDark] = useState(false);

    const [posts, setPosts] = useState(() =>
        Array.from({ length: 30 }, () => createRandomPost())
    );

    const [searchQuery, setSearchQuery] = useState("");

    useEffect(
        function () {
            document.documentElement.classList.toggle(
                "fake-dark-mode"
            );
        },
        [isFakeDark]
    );
    // Derived state. These are the posts that will actually be displayed
    const searchedPosts =
        searchQuery.length > 0
            ? posts.filter((post) =>
                  `${post.title} ${post.body}`
                      .toLowerCase()
                      .includes(searchQuery.toLowerCase())
              )
            : posts;

    function handleAddPost(post) {
        setPosts((posts) => [post, ...posts]);
    }

    function handleClearPosts() {
        setPosts([]);
    }

    const value = useMemo(() => {
        return {
            posts: searchedPosts,
            onAddPost: handleAddPost,
            onClearPosts: handleClearPosts,
            searchQuery,
            setSearchQuery,
        };
    }, [searchedPosts, searchQuery]);

    //2) Provide value to the child components
    return (
        <PostContext.Provider value={value}>
            {children}
        </PostContext.Provider>
    );
}

//3) Custom hook to use the context
function usePosts() {
    const context = useContext(PostContext);
    if (context === undefined) {
        throw new Error(
            "PostContext was used outside fo the PostProvider"
        );
    }

    return context;
}

export { PostProvider, usePosts };
