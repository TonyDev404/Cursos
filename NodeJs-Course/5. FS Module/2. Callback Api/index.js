import * as fs from "fs";

fs.mkdir("c:\\nodejs", function (error) {
    if (error) throw error;
    console.log("Directory Created...");
});