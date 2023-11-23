
const WebSocket = require('ws');

const serverAddress = "ws://127.0.0.1:5000";

const ws = new WebSocket(serverAddress);

ws.on('open', function () {
    ws.send("This is a client.")
});

ws.on('message', function (msg) {
    console.log("Recieved from the server: \n" + msg);
});

