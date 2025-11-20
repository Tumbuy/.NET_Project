using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TCP_Chat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip, nick;
            int port;
            Console.Write("Enter IP : ");
            ip = Console.ReadLine();
            Console.Write("Enter Port : ");
            port = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Nickname : ");
            nick = Console.ReadLine();
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(IPAddress.Parse(ip), port);
            NetworkStream ag = new NetworkStream(socket);
            BinaryReader reader = new BinaryReader(ag);
            BinaryWriter writer = new BinaryWriter(ag);

            baslangic:
            string mesaj;
            Console.Write("Enter Message : ");
            mesaj = Console.ReadLine();
            writer.Write(nick + " : " + mesaj);
            Console.WriteLine("Wait for remote message...");
            string gelen = reader.ReadString();
            Console.WriteLine(gelen);
            goto baslangic;
        }
    }
}
