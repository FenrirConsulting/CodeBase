  const fs = require('fs');
  const path = require('path');
  const customTitlebar = require('custom-electron-titlebar');
  const sql = require('mssql')
  var file = '../../../../localDatabase.sdf';
  var resolvedPath = path.resolve(__dirname,file);
 
  var config = {
    server : 'localhost',
  };



  window.onload = function() {
    
    sql.connect(config, function (err) {
    
      if (err) console.log(err);
  
      // create Request object
      var request = new sql.Request();
         
      // query to the database and get the records
      request.query('select * from Tickets', function (err, recordset) {
          
          if (err) console.log(err)
  
          // send records as a response
          res.send(recordset);
          
      });
  });

  };

  

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