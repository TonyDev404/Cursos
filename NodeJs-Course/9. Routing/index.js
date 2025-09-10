import http from "http";

const server = http.createServer((req, res) => {
    // /homepage
    if (req.url === '/')
    {
        // res.end("<H1>Home</H1>");
        res.writeHead(200, "Ok", {"Content-Type": "text/html"});
        res.end("<a href='/contact'>Contact Page </a>")
    }
    // /about
    else if (req.url === '/about')
    {
        res.writeHead(200, "Ok", {"Content-Type": "text/html"});
        res.end("h2>About Section</h2>");
    }
    // /contact:id
    else if (req.url === "/contact")
    {
        res.writeHead(200, "Ok", {"Content-Type": "text/html"});
        res.end("<h3>Contact</h3>")
    }
    // /not found
    else
    {
        res.writeHead(404, "Bad", {"Content-Type": "text/html"});
        res.end("<h1>404 Page not found UnU </h1>")
    }
})

server.listen(8000, () => console.log("Server Up!"));