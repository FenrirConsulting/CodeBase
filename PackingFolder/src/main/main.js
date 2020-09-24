  const fs = require('fs');
  const path = require('path');
  const customTitlebar = require('custom-electron-titlebar');
  const sqlite3 = require('sqlite3').verbose();
  var file = '../../../../../localDatabase.sqlite';
  var resolvedPath = path.resolve(__dirname, file);
  var tempString = "";
  var builtList = [];

  setInterval(function() {buildPage();}, 10000);

  function buildPage () {

    const emptyTable = document.getElementById("DataStream");
    emptyTable.innerHTML = '';

    fetchData();
    setTimeout(function(){buildTable()},2000)

  }

  function fetchData() {

    let db = new sqlite3.Database(resolvedPath, (err) => {
      if (err) {
        console.error(err.message);
      }
    });

    builtList = [];

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

        builtList.push(tempString);

      });


    });


    db.close((err) => {
      if (err) {
        console.error(err.message);
      }
      console.log('Close the database connection.');
    });

  }

  function buildTable() {

    console.log(builtList);
    console.log(builtList.length);


    for (i = 0; i < builtList.length; i++) {

      var storedRow = builtList[i].trim().split(",");
      var docTable = document.getElementById("DataStream");
      var newRow = document.createElement('tr');
      var newCell = [];
      console.log(storedRow.length);

      for (n = 0; n < storedRow.length-1; n++) {
        newCell[n] = document.createElement('td');
        newCell[n].innerHTML = storedRow[n];
        newRow.appendChild(newCell[n]);
      }

      newCell[5] = document.createElement('td2');
      newCell[5].innerHTML = storedRow[5];
      //var requestRow = document.createElement('tr2');
      //requestRow.appendChild(newCell[5]);


      docTable.appendChild(newRow);
      docTable.appendChild(newCell[5]);

    };

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