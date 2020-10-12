window.$ = window.jQuery = require('../resources/chart.js');
window.$ = window.jQuery = require('../resources/d3.js');
window.$ = window.jQuery = require('../resources/canvasJS.js'); 
const path = require('path');
const fs = require('fs');
const config = require('../resources/config.json');
var title = config.chart1.titleOne;
var mainTitle = config.chart1.mainTitle; 
var dirPath = '../../../../../DisplayScreens/';
document.title = mainTitle;
document.getElementById("Title").innerHTML = title;
var parentPath = '../../../../../ReportGenerator/Reports/';//It goes three folders or directories back from given __dirname.
var fileName = config.chart1.fileOne;

var totalsFile = config.news1.fileOne;
var fPath = path.join(dirPath,totalsFile);
var dpsTotal = 0;
var mpsTotal = 0;
var cpsTotal = 0;
var repackTotal = 0;
var productionHours = 0;
var dpsRunningTotal = 0;
var cpsRunningTotal = 0;
var mpsRunningTotal = 0;
var repackRunningTotal = 0;
var dpsHourlyGoal = 0;
var mpsHourlyGoal = 0;
var cpsHourlyGoal = 0;
var repackHourlyGoal = 0;
var dpsToGoal = 0;
var mpsToGoal = 0 ;
var cpsToGoal = 0;
var repackToGoal = 0;



function fetchTotals(){

    fs.readFile((path.resolve(__dirname, fPath)), function (error, data) {
        console.log("runData");
    
        if (error) {
            throw error;
        }

        var builtbox ="";


        var lines = data.toString().split("\n");
     
        
        dpsTotal = parseInt(lines[34].replace(',', '')); 
        cpsTotal = parseInt(lines[35].replace(',', ''));
        mpsTotal = parseInt(lines[36].replace(',', ''));
        repackTotal = parseInt(lines[37].replace(',', '')); 
        productionHours = parseInt(lines[38].replace(',', ''));
        dpsHourlyGoal = dpsTotal / productionHours; dpsHourlyGoal = Math.round(dpsHourlyGoal);
        mpsHourlyGoal = mpsTotal / productionHours; mpsHourlyGoal = Math.round(mpsHourlyGoal);
        cpsHourlyGoal = cpsTotal / productionHours; cpsHourlyGoal = Math.round(cpsHourlyGoal);
        repackHourlyGoal = repackTotal / productionHours; repackHourlyGoal = Math.round(repackHourlyGoal);

        
    
        dpsToGoal = dpsTotal - dpsRunningTotal;
        mpsToGoal = mpsTotal - mpsRunningTotal; 
        cpsToGoal = cpsTotal - cpsRunningTotal; 
        repackToGoal = repackTotal - repackRunningTotal; 
    
        var valueCheck = 0;
     
        document.getElementById("dpsTotal").innerHTML = "Goal : " + dpsTotal; 
        document.getElementById("dpsRunningTotal").innerHTML = "Current Total : " + dpsRunningTotal;
        document.getElementById("dpsHourlyGoal").innerHTML = "Hourly Goal : " + dpsHourlyGoal;
        document.getElementById("dpsToGoal").innerHTML = "To Goal : " + dpsToGoal; 
        if (dpsToGoal < 0) { document.getElementById("dpsToGoal").innerHTML = "Past Goal : " + (dpsToGoal* -1);  };

        document.getElementById("mpsTotal").innerHTML = "Goal : " + mpsTotal;
        document.getElementById("mpsRunningTotal").innerHTML = "Current Total : " + mpsRunningTotal;
        document.getElementById("mpsHourlyGoal").innerHTML = "Hourly Goal : " + mpsHourlyGoal;
        document.getElementById("mpsToGoal").innerHTML = "To Goal : " + mpsToGoal;
        if (mpsToGoal < 0) { document.getElementById("mpsToGoal").innerHTML = "Past Goal : " + (mpsToGoal* -1); };

        document.getElementById("cpsTotal").innerHTML = "Goal : " + cpsTotal;
        document.getElementById("cpsRunningTotal").innerHTML = "Current Total : " + cpsRunningTotal;
        document.getElementById("cpsHourlyGoal").innerHTML = "Hourly Goal : " + cpsHourlyGoal;
        var cpsGoalHTML = document.getElementById("cpsToGoal").innerHTML = "To Goal : " + cpsToGoal;
        if (cpsToGoal < 0) { cpsGoalHTML= "Past Goal : " + (cpsToGoal* -1); };

        document.getElementById("repackTotal").innerHTML = "Goal : " + repackTotal;
        document.getElementById("repackRunningTotal").innerHTML = "Current Total : " + repackRunningTotal;
        document.getElementById("repackHourlyGoal").innerHTML = "Hourly Goal : " + repackHourlyGoal;
        document.getElementById("repackToGoal").innerHTML = "To Goal : " + repackToGoal;
        if (repackToGoal < 0) { document.getElementById("dpsToGoal").innerHTML = "Past Goal : " + (repackToGoal* -1); };

        


        console.log(dpsRunningTotal);
        console.log(mpsRunningTotal);
        console.log(cpsRunningTotal);
        console.log(repackRunningTotal);

        console.log(dpsTotal);
        console.log(cpsTotal);
        console.log(mpsTotal);
        console.log(repackTotal);

        console.log(dpsToGoal);
        console.log(mpsToGoal);
        console.log(cpsToGoal);
        console.log(repackToGoal);

        console.log(dpsHourlyGoal);
        console.log(mpsHourlyGoal);
        console.log(cpsHourlyGoal);
        console.log(repackHourlyGoal);

        console.log(productionHours);
        
    });

}

var doc = path.join(parentPath,fileName)
console.log(doc);

d3.text(doc).then(function(text){
    var fixedData = d3.csvParse(text.split('\n').slice(1).join('\n'));
    fetchTotals();
    makeChart(fixedData);
})

function makeChart(data) {


    data = data.splice(0, data.length - 1);

    data.splice(0,1);
    
    const newArray = data.map(data => ({
        date: data["Date"].split(" ")[0],
        time: data["Date"].match(/^(\S+)\s(.*)/).slice(2),
        
        data1: data["DPS Pick EA *"].replace(/,/g, ''),
        data2: data["MPS Pick Case *"].replace(/,/g, ''),
        data3: data["CPS Pick Case *"].replace(/,/g, ''),
        data4: data["Totes from Rep"].replace(/,/g, '')
    }));

    
    var dateLabel = newArray.map(function(newArray){return newArray.date});
    var timeLabel = newArray.map(function(newArray){return newArray.time});

    var data1 = newArray.map(function(newArray) {return +newArray.data1});
    var data2 = newArray.map(function(newArray) {return +newArray.data2});
    var data3 = newArray.map(function(newArray) {return +newArray.data3});
    var data4 = newArray.map(function(newArray) {return +newArray.data4});

    finalDate = (dateLabel.length - 1);
    document.getElementById("Date").innerHTML = dateLabel[finalDate];

    
    for( var i = 0; i < data1.length; i++ ){
        dpsRunningTotal += parseInt( data1[i], 10 ); //don't forget to add the base
    }

    for( var i = 0; i < data1.length; i++ ){
        mpsRunningTotal += parseInt( data2[i], 10 ); //don't forget to add the base
    }

    for( var i = 0; i < data1.length; i++ ){
        cpsRunningTotal += parseInt( data3[i], 10 ); //don't forget to add the base
    }

    for( var i = 0; i < data1.length; i++ ){
        repackRunningTotal += parseInt( data4[i], 10 ); //don't forget to add the base
    }


    console.log(data1);
    console.log(data2);
    console.log(data3);
    console.log(data4);    

    var Chart1 = new Chart('chart', {

        type: 'horizontalBar',

        fontColor: "#FFFFFF",

        data: {
            labels: timeLabel,

            datasets: [
                {
                    data: data1,
                    backgroundColor: ["#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222",
                                      "#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222"] ,
                    fontColor: "#fff"
                }
            ]
        },

        options: {

            title: {
                display: true,
                text: "DPS Hourly Pick",
                fontColor:"white",
                fontSize: 24
            },

            legend: {
                display: false,
                labels: {
                    fontColor: "white",
                    fontSize: 18
                }
            },

            scales: {
                xAxes: [
                    {
                        
                        ticks: {
                            fontColor: "white",
                            fontSize: 14,
                            position : 'left'
                        }
                    }
                ],
                yAxes: [{
                    ticks: {
                    fontColor: "white",
                    fontSize: 14
                    }
                }]
            }
        }
    });



    var Chart2 = new Chart('chart2', {

        type: 'horizontalBar',

        fontColor: "#FFFFFF",

        data: {
            labels: timeLabel,

            datasets: [
                {
                    data: data2,
                    backgroundColor: ["#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222",
                                      "#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222"] ,
                    fontColor: "#fff"
                }
            ]
        },

        options: {

            title: {
                display: true,
                text: "MPS Hourly Pick",
                fontColor:"white",
                fontSize: 24
            },

            legend: {
                display: false,
                labels: {
                    fontColor: "white",
                    fontSize: 18
                }
            },

            scales: {
                xAxes: [
                    {
                        ticks: {
                            fontColor: "white",
                            fontSize: 14
                        }
                    }
                ],
                yAxes: [{
                    ticks: {
                    fontColor: "white",
                    fontSize: 14
                    }
                }]
            }
        }
    });


    
    var Chart3 = new Chart('chart3', {

        type: 'horizontalBar',

        fontColor: "#FFFFFF",

        data: {
            labels: timeLabel,

            datasets: [
                {
                    data: data3,
                    backgroundColor: ["#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222",
                                      "#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222"] ,
                    fontColor: "#fff"
                }
            ]
        },

        options: {

            title: {
                display: true,
                text: "CPS Hourly Pick",
                fontColor:"white",
                fontSize: 24
            },

            legend: {
                display: false,
                labels: {
                    fontColor: "white",
                    fontSize: 18
                }
            },

            scales: {
                xAxes: [
                    {
                        ticks: {
                            fontColor: "white",
                            fontSize: 14
                        }
                    }
                ],
                yAxes: [{
                    ticks: {
                    fontColor: "white",
                    fontSize: 14
                    }
                }]
            }
        }
    });



    var Chart4 = new Chart('chart4', {

        type: 'horizontalBar',

        fontColor: "#FFFFFF",

        data: {
            labels: timeLabel,

            datasets: [
                {
                    data: data4,
                    backgroundColor: ["#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222",
                                      "#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222","#cc2222", "#cc2222"] ,
                    fontColor: "#fff"
                }
            ]
        },

        options: {

            title: {
                display: true,
                text: "Repack Totes per Hour",
                fontColor:"white",
                fontSize: 24
            },

            legend: {
                display: false,
                labels: {
                    fontColor: "white",
                    fontSize: 18
                }
            },

            scales: {
                xAxes: [
                    {
                        ticks: {
                            fontColor: "white",
                            fontSize: 14
                        }
                    }
                ],
                yAxes: [{
                    ticks: {
                    fontColor: "white",
                    fontSize: 14
                    }
                }]
            }
        }
    });

}





document.addEventListener("keydown", function (e) {
    if (e.which === 123) {
        require('electron').remote.getCurrentWindow().webContents.openDevTools();
    } else if (e.which === 116) {
        location.reload();
    }
});


function fadeInOut(div, callback) {

    $(div).fadeOut(1000);
    callback(3000);
}


