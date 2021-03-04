/*
    Written by Christopher Olson 08-01-2019
    For CVS Health
*/

const {
    app,
    BrowserWindow
} = require('electron');

const electron = require('electron');
const path = require('path');
const os = require('os');
const username = os.userInfo().username;
const hostname = os.hostname();
const config = require('./src/resources/config.json');
app.disableHardwareAcceleration();



app.on('ready', () => {

    const mod1AHTML = config.index.pageOne;
    const mod1BHTML = config.index.pageTwo;

    const mod2AHTML = config.index.pageThree;
    const mod2BHTML = config.index.pageFour;
    const mod2CHTML = config.index.pageFifteen;

    const mod3AHTML = config.index.pageFive;
    const mod3BHTML = config.index.pageSix;

    const news1HTML = config.index.pageSeven;
    const news2HTML = config.index.pageEight;

    const chart1HTML = config.index.pageNine;
    const chart2HTML = config.index.pageTen;

    const testHTML = config.index.pageEleven;
    const dashHTML = config.index.pageTwelve;
    const tempHTML = config.index.pageThirteen;
    const jsonHTML = config.index.pageFourteen;


    var userCheck = 0;

    if (username == "dpsPicker" || username == "DPSBoard" || hostname == "DPSPERFBOARD") {
        userCheck = 1
    };
    if (username == "DPSBoardB" || hostname == "DPSBOARDB") {
        userCheck = 2
    };


    if (username == "CasesBoard" || hostname == "CASESPERFBOARD") {
        userCheck = 3
    };
    if (username == "CasesBoardB" || hostname == "CASESBOARDB") {
        userCheck = 4
    };


    if (username == "RepackBoard" || hostname == "REPACKPERFBOARD") {
        userCheck = 5
    };
    if (username == "RepackBoardB" || hostname == "REPACKBOARDB") {
        userCheck = 6
    };

    
    if (username == "c067460" || username =="COlson" || username == "GABenjamin") {
        userCheck = 7
    };

    if (hostname == "IBMM715MJ0622BP" || hostname == "PCITREPORT" || username=="rfl6wmsdom\\kfrye" || username=="rfl6wmsdom\\PCITHUBCONTROL"){
        userCheck = 8;
    };

    switch (userCheck) {

        case 1:
            windowLauncher(mod1AHTML);  
            break;

        case 2:
            windowLauncher(mod1BHTML); 
            break;

        case 3:
            windowLauncher(mod2AHTML);   
            break;

        case 4:
            windowLauncher(news1HTML); 
            break;

        case 5:
            windowLauncher(mod3AHTML);
            break;

        case 6:
            windowLauncher(mod3BHTML); 
            //windowLauncher(news1HTML);
            //windowLauncher(chart1HTML);
            break;

        case 7:
            //windowLauncher(mod1AHTML); 
            //windowLauncher(mod1BHTML); 
            //windowLauncher(mod2AHTML);
            //windowLauncher(mod2bHTML);
            //windowLauncher(mod2CHTML);
            //windowLauncher(mod3AHTML);
            //windowLauncher(mod3BHTML);
            //windowLauncher(news1HTML);
            //windowLauncher(news2HTML);
            //windowLauncher(dashHTML);
            //windowLauncher(chart1HTML);
            //windowLauncher(chart2HTML);
            //windowLauncher(testHTML);
            //windowLauncher(tempHTML);
            //windowLauncher(jsonHTML);
            //windowLauncher(dashHTML);
            dashLauncher(dashHTML); 
            break;

        case 8 :
            windowLauncher(chart1HTML);
            break; 

        default:
            dashLauncher(dashHTML); 
    }

    function dashLauncher(fileName){

        dashWindow = new BrowserWindow({
            webPreferences: {
                nodeIntegration: true
            },
            autoHideMenuBar: true,
            fullscreen: false,
            frame: false,
            devTools: true,
            maximize : true,
        });

        dashWindow.loadFile(fileName);
        dashWindow.maximize();
    }

    function windowLauncher(fileName){

        mainWindow = new BrowserWindow({
            webPreferences: {
                nodeIntegration: true
            },
            autoHideMenuBar: true,
            fullscreen: false,
            frame: false,
            devTools: true,
            maximize : true,
        });

        mainWindow.loadFile(fileName);
        secondMonitor(fileName);
        mainWindow.maximize();
    }

    function secondMonitor(fileName) {
        var electronScreen = electron.screen;
        var displays = electronScreen.getAllDisplays();
        var externalDisplay = null;
        for (var i in displays) {
            if (displays[i].bounds.x != 0 || displays[i].bounds.y != 0) {
                externalDisplay = displays[i];

                if (fileName == mod1AHTML || fileName == mod2AHTML || fileName == mod3AHTML){

                    secondWindow = new BrowserWindow({
                        webPreferences: {
                            nodeIntegration: true
                        },
                        x: externalDisplay.bounds.x + 50,
                        y: externalDisplay.bounds.y + 50,
                        autoHideMenuBar: true,
                        fullscreen: false,
                        frame: false,
                        devTools: true,
                        maximize : true,
                    });

                    if (externalDisplay) {

                        if (fileName == mod1AHTML) {
                            secondWindow.loadFile(mod1BHTML);
                        } 
                        if (fileName == mod2AHTML) {
                            secondWindow.loadFile(mod2BHTML);
                        }    
                        if (fileName == mod3AHTML) { //casesHTML
                            secondWindow.loadFile(mod3BHTML);
                        }
                        if (fileName == news1HTML){
                            secondWindow.loadFile(news2HTML);
                        }
                        if (fileName == chart1HTML){
                            secondWindow.loadFile(chart2HTML);
                        }
                        secondWindow.maximize();
            
                    };

                }

                break;
            }
        }
    }

})

app.on('window-all-closed', function () {
    app.quit()
})