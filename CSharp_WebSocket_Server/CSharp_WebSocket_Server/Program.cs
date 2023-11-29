
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
            base.OnMessage(e);
            Console.WriteLine("Recieved msg from client in C# server " + e.Data);
            Send("Send " + e.Data);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            WebSocketServer server = new WebSocketServer("ws://127.0.0.1:4561");

            // Route
            server.AddWebSocketService<Echo>("/Echo");

            server.Start();
            Console.WriteLine("Server started from C#");

            Console.ReadKey();
            server.Stop();
        }
    }
}
