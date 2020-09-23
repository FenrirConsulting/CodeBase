  const fs = require('fs');
  const path = require('path');
  const customTitlebar = require('custom-electron-titlebar');
  const sqlite3 = require('sqlite3').verbose();
  var file = '../../../../../localDatabase.sqlite';
  var resolvedPath = path.resolve(__dirname,file);

  window.onload = function() {
    
    let db = new sqlite3.Database(resolvedPath, (err) => {
      if (err) {
        console.error(err.message);
      }
      console.log('Connected to the chinook database.');
    });


    db.serialize(() => {
      db.each(`SELECT TicketID as id,
                      Requestor as requestor,
                      Category as category, 
                      Status as status
               FROM Tickets 
               WHERE Status LIKE '%Close%'  `, (err, row) => {
        if (err) {
          console.error(err.message);
        }
        console.log(row.id + "\t" + row.requestor + "\t" + row.category + "\t" + row.status);
      });
    });

    db.close((err) => {
      if (err) {
        console.error(err.message);
      }
      console.log('Close the database connection.');
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