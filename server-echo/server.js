
const WebSocket = require('ws');

const PORT = 5000;

const wsServer = new WebSocket.Server({
     port: 5000
});

wsServer.on('connection', function (socket) {

    // Some feedback on the console
    console.log('A client just connected');

    // Attach some behavior to the incoming socket
    socket.on('message', function (msg) {
        console.log('Recieve message from the client: ' + msg);
        
        //Sends the message from the server to the client
        //socket.send("Echo: " + msg);

        //Broadcast that message to all connected clients
        wsServer.clients.forEach( function (client) {
            client.send("Another client send: " + msg);
        });
    });
});

console.log( (new Date()) + " Server is listening to port " + PORT);