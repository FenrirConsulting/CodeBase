/*
    Written by Christopher Olson 08-01-2019
    For CVS Health
*/

const fs = require('fs');
const path = require('path');
const config = require('../resources/config.json');

var dirPath = '../../../../../DisplayScreens/';
var file1 = config.mod1B.fileOne;
var file2 = config.mod1B.fileTwo;
var title = config.mod1B.mainTitle;
var fPath = path.join(dirPath, file2);
var count = 1;
var myTime;
document.title = title;

myStartFunction();

function timerFunc() {
    /*Auto scrolls and refreshes table data with new information */

    var objTbl = document.getElementById("DataStream");

    objTbl.scrollTop = objTbl.scrollTop + 1;

    if (objTbl.scrollHeight - objTbl.scrollTop === objTbl.clientHeight) {

        // Add or remove counts, then add Case statements to add files to cycle through.
        // Counts need to point to the next file, 1->2, 2->3, 3->1, etc.
        switch (count) {
            case 1:

                fPath = path.join(dirPath, file1);
                runData(objTbl);
                count = 2;
                break;

            case 2:
                fPath = path.join(dirPath, file2);
                runData(objTbl);
                count = 1;
                break;
        }

    }

}


function myStartFunction() { // Start interval

    myTime = setInterval(function () {
        timerFunc()
    }, 12);
    console.log("startInterval");
}

function myStopFunction() { // Clear interval timer

    clearInterval(myTime);
    console.log("clearInterval");
}

function runData(objTbl) {

    // Fades out Divs, Stops scroll interval, runs new table, fades in on timer
    $(".mod1BSet").fadeOut(3000);

    setTimeout(function () {
        objTbl.scrollTop = function () {
            return 0;
        }
    }, 3000);

    myStopFunction();

    setTimeout(function () {

        readData();
        $(".mod1BSet").fadeIn(4000);
        setTimeout(function () {
            myStartFunction();
        }, 1000);

    }, 3000);

}


function readData() {

    fs.readFile((path.resolve(__dirname, fPath)), function (error, data) {
        console.log("runData");

        if (error) {
            throw error;
        }

        $("tbody").children().remove()

        // File is read into table string array. Lines 1-3 are used to store the Title, Date,
        // and Week into string variables that are displayed in their respective boxes. Trims | out of Title/Date/Week

        var table = data.toString().split("\n");
        var pretitle = table[1];
        var predate = table[2];
        var preweek = table[3];
        var title = pretitle.replace(/\|.*/, '');;
        var date = predate.replace(/\|.*/, '');;
        var week = preweek.replace(/\|.*/, '');;
        console.log(title);
        console.log(date);
        console.log(week);

        // Creates empty fields for spacing between different .txt Files
        // Change n count for more or less empty lines between files.
        for (n = 0; n < 15; n++) {

            var f = [];
            var td = [];
            var tar = document.getElementById("DataStream");
            var tr = document.createElement('tr');

            for (i = 0; i < 16; i++) {
                f[i] = ("");
                td[i] = document.createElement('td');
                td[i].innerHTML = f[i];
                td[i].setAttribute("id", "remove");
                tr.appendChild(td[i]);
            }

            tar.appendChild(tr);
        }

        for (i = 4; i < table.length - 1; i++) {

            var f1 = table[i].trim().split("|", 16);
            var tar = document.getElementById("DataStream");
            var tr = document.createElement('tr');
            var td = [];

            for (n = 0; n < 16; n++) {
                td[n] = document.createElement('td');
                td[n].innerHTML = f1[n];
                td[n].setAttribute("id", "remove")
                tr.appendChild(td[n]);
            }

            tar.appendChild(tr);

            var valueCheck = parseInt(td[6].innerHTML, 10);
            changeColor(td[6], valueCheck);

            var valueCheck = parseInt(td[7].innerHTML, 10);
            changeColor(td[7], valueCheck);

            var valueCheck = parseFloat(td[8].innerHTML, 10);
            changeColor(td[8], valueCheck);

            function changeColor(input, valueCheck) {
                $(input).removeClass();

                if (valueCheck > 99.99) {
                    $(input).addClass('pass');
                } else if (valueCheck > 99.89 && input == td[8]) {
                    $(input).addClass('warning');
                } else {
                    $(input).addClass('fail');
                }
            }

        };

        // Creates empty fields for spacing between different .txt Files
        // Change n count for more or less empty lines between files. 
        for (n = 0; n < 14; n++) {

            var f = [];
            var td = [];
            var tar = document.getElementById("DataStream");
            var tr = document.createElement('tr');

            for (i = 0; i < 16; i++) {
                f[i] = ("");
                td[i] = document.createElement('td');
                td[i].innerHTML = f[i];
                td[i].setAttribute("id", "remove");
                tr.appendChild(td[i]);
            }

            tar.appendChild(tr);
        }

        document.getElementById("Title").innerHTML = title;
        document.getElementById("Date").innerHTML = date;
        document.getElementById("Week").innerHTML = week;

    });
}

// Allows for reloading and DevTools inside app, using F5 & F12
document.addEventListener("keydown", function (e) {
    if (e.which === 123) {
        require('electron').remote.getCurrentWindow().webContents.openDevTools();
    } else if (e.which === 116) {
        location.reload();
    }
});