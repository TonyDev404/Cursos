//This will allows us to use that function from
// that (greet.js) file, and we can use it right here
const greet = require("./greet");
const {person1, person2, person3} = require("./people");

greet(person1);
greet(person2);
greet(person3);
