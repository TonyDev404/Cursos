//Create Folder
//npm init -y
//npm i express
//Create instance express
//Provide Port: 8000

import express from "express";


const app = express();

console.clear();

//HTTP METHODS
//GET = Retrieve Data
//POST = Create/Insert Data
//PUT = Completely Update Data
//PATCH = Partially Update Data
//DELETE = Delete Data
//ALL = Any HTTP Request Method

//-------------------------------------------------------------------------------------
//Basic Routing

/*
app.get('/', (req, res) => {
    res.send("<h1> WELCOME HOME</h1>");
});

app.get('/about', (req, res) => {
    res.send("<h1> ABOUT 🤓</h1>");
});

app.get('/contact', (req, res) => {
    res.send("<h1>CONTACT PAGE</h1>");
});
*/
//-------------------------------------------------------------------------------------
//Advance Routing

//String Pattern Path

/*
app.get('/ab?cd', (req, res) => {
    res.send("If the user thi (adc) or (abcd) then this will run.");
});
*/

//Regex

/*
app.get(/x/, (req, res) => {
    res.send('If the path includes the letter (x) it will work.');
});

app.get(/^\/users\/[0-9]{4}$/, (req, res) => {
    res.send('Work if users/four numbers.');
});
*/
//-------------------------------------------------------------------------------------
/*
app.get('/products/iphone', (req, res) => {
    res.send("This code will only run if you provide /products/iphone");
});
*/

/*
app.get(
    '/double-cb', 
    (req, res, next) => {
        // res.send("Single Callback");
        console.log("First Callback");
        next();
    }, 
    (req, res) => {
        res.send("Second Callback");
    }
);
*/

/*
const cb1 = (req, res, next) => {
    console.log('First Callback');
    next();
}
const cb2 = (req, res, next) => {
    console.log('Second Callback')
    next();
}
const cb3 = (req, res) => {
    console.log('Third Callback')
    res.send("Array Of Callbacks");
}

app.get("/array-cb", [cb1, cb2, cb3]);
*/

/*
const cb1 = (req, res, next) => {
    console.log("First Callback");
    next();
};
const cb2 = (req, res, next) => {
    console.log("Second Callback");
    next();
};

app.get(
    '/crazyness', 
    [cb1, cb2], 
    (req, res, next) => {
        console.log("Third Callback");
        next();
    }, (req, res, next) => {
        console.log("Fourth Callback");
        res.send('Crazyness');
    }
);
*/
//-------------------------------------------------------------------------------------
//Ugly code

/*
app.get('/student', (req, res) => {
    res.send('All Students');
})

app.post('/student', (req, res) => {
    res.send('Add New Student');
})

app.put('/student', (req, res) => {
    res.send('Update Student');
})

app.delete('/student', (req, res) => {
    res.send('Delete Student');
})
*/

//Refactor
//app.route()

/*
app
    .route('/student')
    .get((req, res) => res.send("All Students"))
    .post((req, res) => res.send("Add New Student"))
    .put((req, res) => res.send("Update Student"))
    .delete((req, res) => res.send("Delete Student"));
*/
//-------------------------------------------------------------------------------------
//1. Create routes folder and put your routes in a separete file
//2. Create instance of express.Router()
//3. Instead of app.method change that to "router.method"
//4. Export router
//5. Import router
//6. Use the (app.use) built-in middleware & provide your routes.

/*
import students from "./routes/student.js";
import teachers from "./routes/teacher.js";

app.use('/students', students);
app.use('/teachers', teachers);

*/
//-------------------------------------------------------------------------------------
// Route Params
//ecom/products/iphone/:iphoneId

/*
app.get('/student/delete/:id', (req, res) => { //:id se especifica en el endpoint pero en la url es id
    res.send(req.params.id);
});
*/

/*
app.get("/ecom/products/iphone/:model", (req, res) => {
    const { model } = req.params;
    res.send(`Iphone ${model} Pro Max`);
});
*/

/*
app.get("/product/:category/:id", (req, res) => {
    const { category, id } = req.params;
    res.send(`Product Category (${category}) & Product Id (${id})`);
});
*/

/*
app.get("/product/order/:day/:month/:year", (req, res) => {
    const { day, month, year } = req.params;
    res.send(`Product was order on: ${day}/${month}/${year}`);
});
*/

/*
app.param("id", (req, res, next, id) => {
    console.log(`id: ${id}`);
    next();
});

app.get('/user/:id', (req, res) => {
    console.log('This is User ID Path');
    res.send("Response Ok");
});
*/
//-------------------------------------------------------------------------------------
//Controllers

/*
import students from './ControllersLesson/routes/student.js';

app.use('/students', students);
*/
//-------------------------------------------------------------------------------------
//Query String

/*
app.get('/product', (req, res) => {
    const {category, id} = req.query;

    res.send(`Product Category: ${category} & Product ID: ${id}`); 
    --> //localhost:8000/product?category=iphone&id=404 
});
*/  
//-------------------------------------------------------------------------------------
//JSON

/*
import products from "./products.js";

app.get('/products', (req, res) => {
    res.json(products);
});
*/
//-------------------------------------------------------------------------------------
//Middleware

/*
    Request
    Middleware
    Response
*/

/*
import userCredentials from "./middlewares/logs.js";

app.use(userCredentials);

app.get('/', (req, res) => {
    res.send("<h1> Hello Admin</h1>")
});

app.get('/about', (req, res) => {
    res.send("<h1> About Section</h1>")
});

app.get('/contact', (req, res) => {
    res.send("<h1> Contact Page</h1>")
});
*/

/*
app.get('/', userCredentials, (req, res) => {
    res.send("<h1> Hello Admin")
});
*/
//-------------------------------------------------------------------------------------
//Serving Staic Files

/*
import path from 'path';

app.use(express.static('./public'));

app.get('/', (req, res) => {
    res.sendFile(path.join(process.cwd(), "./public/index.html"));
});
*/
//-------------------------------------------------------------------------------------

import {join} from "path";
import route from "./ejsLesson/routes/route.js";

app.set('view engine', 'ejs');

app.use('/', route);

app.listen(8000, () => console.log("Server Up!"));