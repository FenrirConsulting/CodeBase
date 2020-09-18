  const fs = require('fs');
  const path = require('path');
  const customTitlebar = require('custom-electron-titlebar');
  var file = '../../../../localDatabase.sdf';
  var resolvedPath = path.resolve(__dirname,file);

  

  new customTitlebar.Titlebar({
    backgroundColor: customTitlebar.Color.fromHex('#000')
  });

  document.addEventListener("keydown", function (e) {
    if (e.which === 123) {
      require('electron').remote.getCurrentWindow().webContents.openDevTools();
    } else if (e.which === 116) {
      location.reload();
    }
  });