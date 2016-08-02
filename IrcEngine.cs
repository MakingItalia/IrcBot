using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace IrcBot
{
    class IrcEngine : IDisposable
    {

        public static string server_ip = "irc.pierotofy.it";
        public static int server_port = 6669;
        public static string IrcBot_nick = "Dante";
        public static string chan = "#prova";
        public static string data;
        public static string nick;
        public static StreamWriter sw;
        public static StreamReader sr;
        
        public static void Connect()
        {
            Thread thr = new Thread(new ThreadStart(Listen));
            thr.Name = "Listen";
            thr.Start();
        }

 

        public static void Listen()
        {

            //eventi
            //ImIRC im = new ImIRC();
            //im.OnJoin += new ImIRC.JoinHandles(im_OnJoin);

            TcpClient irc = new TcpClient();
            irc.Connect(server_ip, server_port);
            NetworkStream netstr;
            netstr = irc.GetStream();
            sr = new StreamReader(netstr);
            sw = new StreamWriter(netstr);
            sw.WriteLine("PING :" + server_ip);
            sw.Flush();
            Thread.Sleep(1500);
            sw.WriteLine("USER " + IrcBot_nick + " 0 * : IRCBot");
            sw.Flush();
            sw.WriteLine("NICK " + IrcBot_nick);
            sw.Flush();
            sw.WriteLine("JOIN " + chan);
            sw.Flush();

            //Thread thr = new Thread(new ThreadStart(idle));
            //thr.Start();


            while (true)
            {
                while ((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);

                    if (data.EndsWith("JOIN :" + chan))
                    {
                        //im.On_Join(nicks(dati));
                    }
                }
            }

        }




        public void Dispose()
        {
            this.Dispose();
            sr.Dispose();
            sw.Dispose();
            
        }
    }
}
