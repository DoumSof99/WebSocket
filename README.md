# WebSocket
- how to write a simple WebSocket locally in js, both the client and server side.
- how to upload the server into a cloud, share it, and use it on the open web.
- create a ball animation game and connect to the glitch server.
- Creates a processing sketch that communicates with the WebSocket server and synchronizes data.
- Create a client in C# and connect with the Glitch server.

1) in the vs code I open the server-echo project and in the PowerShell, I go to this path and run:
![image](https://github.com/DoumSof99/WebSocket/assets/71881384/899632e2-f8e3-4a7d-ba77-226e72400bab)
2) That means the server started, and I can open this WebSocket Client (Chrome extension): chrome-extension://gobngblklhkgmjhbpbdlkglbhhlafjnh/index.html
3) In 2 tabs, I can see the messages passed from one client sent to the server, and the server sends this to every other client.
4) ![image](https://github.com/DoumSof99/WebSocket/assets/71881384/e91ce2b7-c7ce-4e52-aa44-b2d11b0cb78d)
5) now that a simple client is created in the js we can call and receive messages from one client to the server and to the other client.
6) ![image](https://github.com/DoumSof99/WebSocket/assets/71881384/792e8866-50ec-4df6-b09e-fe6b36c2bcb5)
7) By connection to the site Glitch, it can host and share the project online https://glitch.com/dashboard, add the server there, and correct some things, finally, it does what it was doing before but it can be shared.
8) My project: https://websocket-server-echo-project.glitch.me
   ![image](https://github.com/DoumSof99/WebSocket/assets/71881384/4e7fcc08-2930-4c5d-bc07-a299ad8290c1)
9) In the p5.js, I created a ball game where it follows the mouse click here: https://editor.p5js.org/DoumSof99/sketches/3BhfYq67G
10) In the vs code install the p5.js and the live server. By adding some code the ball game client is connected with the server on the glitch.
11) ![image](https://github.com/DoumSof99/WebSocket/assets/71881384/8b3d314b-d8a3-479f-b709-59ec98202b70)
12) Created a new project in the Glitch (Website), named it ball-game-sync, then deleted everything from the files and copied - pasted mine. So now the ball game is hosted/is static on the Glitch. (https://glitch.com/edit/#!/ball-game-sync)
13) Downloaded processor, and then connected it to my local server and then to my glitch server. Needed to add 2 libs from https://github.com/ParametricCamp/TutorialFiles/tree/master/Misc/WebSockets/procesing_websocket_client repo and also add an additional one .jar lib to the processor's path.
14) ![image](https://github.com/DoumSof99/WebSocket/assets/71881384/1ade8d5d-5db9-495c-b344-d5e577193da6)
15) So now there are 2 different projects (p5.js in vs code and the processor) connected to the glitch server and each one sends the coordinates to the other.
16) Now in C# I installed the Nuget package WebSocket-sharp and connected with my Glitch server: https://glitch.com/edit/#!/websocket-server-echo-project?path=server.js%3A22%3A20
17) ![image](https://github.com/DoumSof99/WebSocket/assets/71881384/97651ede-222e-40f2-9020-89ddb42f8991)
18) From the above image, I will deserialize the numbers from the C# console, and by extracting these numbers we will draw something on the C# console.
19) Below is an image of the server in C# (left) and a client in C# (Right), but this is a 1-1 relation, which means if I open another client, these 2 clients cannot interact together but only with the server.
20) ![image](https://github.com/DoumSof99/WebSocket/assets/71881384/1a9a5603-477e-4293-ad40-08ddc9f06097)
21) In the below image, the server is getting a message from one client and is able to share it with the rest in C#.
22) ![image](https://github.com/DoumSof99/WebSocket/assets/71881384/af5b33de-c29e-4fdf-8769-f53ccca6b37b)


