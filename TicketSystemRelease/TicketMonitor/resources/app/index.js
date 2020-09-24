/*
    Written by Christopher Olson 09-16-2020
    For CVS Health
*/

const {
    app,
    BrowserWindow,
    Menu
} = require('electron');


const electron = require('electron');
const os = require('os');
const path = require('path');
const username = os.userInfo().username;
app.commandLine.appendSwitch('auto-detect', 'false');
app.commandLine.appendSwitch('no-proxy-server')
app.disableHardwareAcceleration();

app.on('ready', () => {

    const mainHTML = ('./src/main/main.html');

    windowLauncher(mainHTML); 
    function windowLauncher(fileName){

        mainWindow = new BrowserWindow({
            webPreferences: {
                nodeIntegration: true, 
                enableRemoteModule: true
            },
            autoHideMenuBar: true,
            fullscreen: false,
            frame: false,
            devTools: true,
            maximize : true
        });
        mainWindow.loadFile(fileName);
        mainWindow.maximize();
        
    }
})



app.on('window-all-closed', function () {
    app.quit()
})