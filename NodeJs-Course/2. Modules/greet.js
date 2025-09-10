function greet(username)
{
    console.log("Hello: ", username);
}

//Tell other file you have access to this function
module.exports = greet;