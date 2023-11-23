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
            // create an instance of a websocket client
            WebSocket ws = new WebSocket("");

            Console.ReadKey();
        }
    }
}
