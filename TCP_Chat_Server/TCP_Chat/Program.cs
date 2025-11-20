using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace TCP_Chat
{
    class Program
    {
        static void Main(string[] args)
        {

            string nick;
            int port;
            Console.Write("Enter Nickname : ");
            nick = Console.ReadLine();
            Console.Write("Port to Open : ");
            port = Convert.ToInt16(Console.ReadLine());
            TcpListener listener = new TcpListener(port);
            listener.Start();
            Console.WriteLine("Server Started.");
            Console.WriteLine("Waiting for remote...");
            Socket socket = listener.AcceptSocket();
            Console.WriteLine("Remote Connected!");
            NetworkStream nw = new NetworkStream(socket);
            BinaryReader reader = new BinaryReader(nw);
            BinaryWriter writer = new BinaryWriter(nw);
            start:
            string mesaj, gmesaj = reader.ReadString();
            Console.WriteLine(gmesaj);
            Console.Write("You : ");
            mesaj = Console.ReadLine();
            writer.Write(nick + " : " + mesaj);
            goto start;

        }
    }
}
