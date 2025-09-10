//Annotations are used to scpecify the data type of a variable, parameter, function return value and other types of values.

//Annotations help developers catch errors early in development by allowing them to specify what types of values can be assigned to a given variable or passed as an argument to a function.

/*
//let myVar: type = value;

//Strings
let myName: string = "Tony WebDev";
myName = "Other Name";
console.log(myName);

//Numbers
let favNumber: number = 7;
favNumber += 1;
console.log(favNumber); 

//Booleans
let tsHard: boolean = false;
tsHard = true;
console.log(tsHard);
*/

//===============================================================================================
//Type inference is a feature in TypeScript that allows the compiler to automatically determine the type of a variable base on it's value. In other words, if you declare a varaible wothout explicitly specifying its type, TypeScript will try to infer the type based on the value assigned to it.

/*
//Here we're inferring the types!
let tech = "TypeScript";
let favNumber = 8;
let tsHard = true;

console.log(tech, favNumber, tsHard);

// ERROR
// tech = "false";
// favNumber = "Hello";
// tsHard = 1;
*/

//===============================================================================================
//Any Type
//TypeScript has a special any type that can be used to represent any type. When a variable is annotated with the any type, TypeScript wil allow it to have any value and disable all type checking for that variable and its properties.