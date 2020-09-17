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
let mainWindow; 

const nativeImage = require('electron').nativeImage;
    var image = nativeImage.createFromPath(__dirname + '/build/icon/icon.ico'); 
 // where public folder on the root dir
 image.setTemplateImage(true);


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
            frame: true,
            devTools: true,
            maximize : true,
            icon: image
        });
        mainWindow.loadFile(fileName);
        mainWindow.maximize();
        
    }
})



app.on('window-all-closed', function () {
    app.quit()
})