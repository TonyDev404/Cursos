import * as fs from "fs/promises";

//Creating Directory / Folder
//Si las carpetas no existen, con 'recursive' se crean hasta donde llegue la ultima carpeta
// await fs.mkdir("c:\\nodejs\\courses\\redux\\toolkit", { recursive: true });

//Read the content
// const files = await fs.readdir("c:\\nodejs");
// for (const file of files) {
//     console.log(file);
// }

//Remove Folder/Directory
// await fs.rmdir("c:\\nodejs\\courses");

//Create and Write Files
// await fs.writeFile('README.md', "Hello Tony webdev");
// await fs.appendFile("README.md", "Nodejs is the best");

//Read File
// const data = await fs.readFile("README.md", "utf-8");
// console.log(data);

//Copy File
// await fs.copyFile("README.md", "info.txt");

//Get File Information
// const info = await fs.stat("info.txt");
// console.log(info);
// console.log(info.isDirectory());
// console.log(info.isFile());

try {
}
catch (error)
{
    console.log(error);
}