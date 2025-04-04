// Global parameters
const EASING_SPEED = 0.05;


// Current ball position
let pos = {
  x : 0,
  y : 0
};

// Target ball possition
let target = {
  x : 0,
  y : 0
};

function setup() {
  createCanvas(400, 400);
  
  background(0);
  noStroke();
  
  
}

function draw() {
  //background(220);
  fill(0, 15);  
  rect(0, 0, width, height);
  fill(255);
  
  //circle(width /2, height / 2, 20);
  circle(pos.x, pos.y, 20);
  
  // Ease position into target
  pos.x += EASING_SPEED * (target.x - pos.x);
  pos.y += EASING_SPEED * (target.y - pos.y);
  
}

function mouseClicked() {
  
  setTarget(mouseX, mouseY)
  sendTargetToServer();
  
  // console.log('New target is: ');
  // console.log(target);
}

function setTarget(tx, ty){
  target = {
    x: tx,
    y: ty
  };
}

function sendTargetToServer(){
  let norm = {
    x: target.x / width,
    y: target.y / height
  }
  let str = JSON.stringify(norm);
  serverConnection.send(str);
}

// WebSocket stuff
const cloudServerAddress = "wss://websocket-server-echo-project.glitch.me/";

const serverConnection = new WebSocket(cloudServerAddress);

serverConnection.onopen = function() {
  console.log("I just connected from p5 to " + cloudServerAddress);
  // serverConnection.send('hello from p5')

}

serverConnection.onmessage = function(event) 
{
  console.log("Recieved: " + event.data);
  let obj = JSON.parse(event.data);
  obj.x *= width;
  obj.y *= height;
  target = obj;
}

