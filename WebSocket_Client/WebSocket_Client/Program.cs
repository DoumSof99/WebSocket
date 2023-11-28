using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace WebSocket_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a scoped instance of a websocket client and then it will be displosed
            using (WebSocket ws = new WebSocket("ws://websocket-server-echo-project.glitch.me"))
            {
                ws.OnMessage += Ws_OnMessage;

                ws.Connect();
                ws.Send("Hello from C#");

                Console.ReadKey();
            }
        }

        private static void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("Message from the server: " + e.Data);
        }
    }
}
