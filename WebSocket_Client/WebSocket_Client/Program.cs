using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Newtonsoft.Json;

namespace WebSocket_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // create a scoped instance of a websocket client and then it will be displosed
            //using (WebSocket ws = new WebSocket("ws://websocket-server-echo-project.glitch.me"))
            using (WebSocket ws = new WebSocket("ws://127.0.0.1:4561/EchoAll")) //Echo
            {
                ws.OnMessage += Ws_OnMessage;

                ws.Connect();
                ws.Send("Hello from C#"); // this throws error because is not a JSON 

                Console.ReadKey();
            }
        }

        private static void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("Message from the server: " + e.Data);

            try
            {
                Vector pos = JsonConvert.DeserializeObject<Vector>(e.Data);
                //Console.WriteLine("The vector is: " + pos.x + ", " + pos.y);
                DrawDot(pos.x, pos.y, 50, 15, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private static void DrawDot(double xPos, double yPos, int width, int height, int borderWidth)
        {
            // Convert from normalize coordinate to "Character" to "pixel" coordinates
            int x = (int)Math.Round(xPos * width);
            int y = (int)Math.Round(yPos * height);

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (i == x && j == y)
                    {
                        Console.Write("0");
                    }
                    else if (j < borderWidth || j > height - 1 - borderWidth 
                        || i < borderWidth || i > width - 1 - borderWidth)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    public class Vector
    {
        public double x { get; set; }
        public double y { get; set; }
    }   

}
