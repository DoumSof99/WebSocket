
const WebSocket = require('ws');

const localServerAddress = "ws://127.0.0.1:5000";
const cloudServerAddress = "https://websocket-server-echo-project.glitch.me/";

// const ws = new WebSocket(localServerAddress);
const ws = new WebSocket(cloudServerAddress, {
    headers: {
        "User-Agent": "Brave"
    }
});

ws.on('open', function () {
    ws.send("This is a client.")
});

ws.on('message', function (msg) {
    console.log("Recieved from the server: \n" + msg);
});

