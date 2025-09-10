function userCredentials(req, res, next)
{
    console.log("username: (antonio)");
    console.log("email: (antonio@gmail.com)");
    console.log("password: (antonio123)");
    console.log("age: (22)");
    next();
}

export default userCredentials;