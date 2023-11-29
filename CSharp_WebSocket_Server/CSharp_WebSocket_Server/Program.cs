
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSocketSharp;
using WebSocketSharp.Server;

namespace CSharp_WebSocket_Server
{

    public class Echo : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            //base.OnMessage(e);
            Console.WriteLine("Recieved msg from echo client in C# server " + e.Data);
            Send("Send " + e.Data);
        }
    }

    public class EchoToAllClients : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            //base.OnMessage(e);
            Console.WriteLine("Recieved msg from echoAll client in C# server " + e.Data);
            Sessions.Broadcast("Send all " + e.Data);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            WebSocketServer server = new WebSocketServer("ws://127.0.0.1:4561");

            // Route
            //server.AddWebSocketService<Echo>("/Echo");
            server.AddWebSocketService<EchoToAllClients>("/EchoAll");

            server.Start();
            Console.WriteLine("Server started from C# on ws://127.0.0.1:4561/EchoAll");

            Console.ReadKey();
            server.Stop();
        }
    }
}
