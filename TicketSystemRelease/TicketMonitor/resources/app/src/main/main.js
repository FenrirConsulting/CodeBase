  const fs = require('fs');
  const path = require('path');
  const customTitlebar = require('custom-electron-titlebar');
  const sqlite3 = require('sqlite3').verbose();
  var file = '../../../../../localDatabase.sqlite';
  var resolvedPath = path.resolve(__dirname, file);
  var ticketList = [];
  var tempString = "";

  window.onload = function () {

    let db = new sqlite3.Database(resolvedPath, (err) => {
      if (err) {
        console.error(err.message);
      }
      console.log('Connected to the chinook database.');
      fetchData(db);
    });


    function fetchData(db) {

      db.serialize(() => {
        db.each(`SELECT TicketID as id,
                    Requestor as requestor,
                    Category as category, 
                    Created as created,
                    Modified as modified,
                    Request as request,
                    Status as status
                   FROM Tickets 
                  WHERE Status LIKE '%Open%'  `, (err, row) => {
          if (err) {
            console.error(err.message);
          }

          tempString =
            row.id + "," +
            row.requestor + "," +
            row.category + "," +
            row.created + "," +
            row.modified + "," +
            row.request;

          ticketList.push(tempString);

        });

        buildTable(ticketList);

      });

    }



    db.close((err) => {
      if (err) {
        console.error(err.message);
      }
      console.log('Close the database connection.');
    });

  };

  function buildTable(ticketList) {

    console.log(ticketList);







    
  }











  new customTitlebar.Titlebar({
    backgroundColor: customTitlebar.Color.fromHex('#000'),
    icon: '../../build/icon.ico'
  });

  document.addEventListener("keydown", function (e) {
    if (e.which === 123) {
      require('electron').remote.getCurrentWindow().webContents.openDevTools();
    } else if (e.which === 116) {
      location.reload();
    }
  });