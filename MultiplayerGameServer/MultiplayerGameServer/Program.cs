using System;

namespace MultiplayerGameServer {
    class Program {
        static void Main(string[] args)
        {
            Console.Title = "Multiplayer Game Server";

            Server.Start(50, 7777);

            Console.ReadKey();
        }
    }
}
