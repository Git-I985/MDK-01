const { app, BrowserWindow } = require("electron");

app.whenReady().then(() => {
  new BrowserWindow({
    width: 800,
    height: 800,
    autoHideMenuBar: true,
  }).loadFile("./views/index.html");
});
