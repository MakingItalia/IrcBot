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

        public static string server_ip = "irc.rizon.net";
        public static int server_port = 6669;
        public static string IrcBot_nick = "Dante";
        public static string chan = "#Rpg2s";
        public static string data;
        public static string nick;
        public static StreamWriter sw;
        public static StreamReader sr;
        public static bool ConsoleMsg = false;

        //Eventi
        public static event CommandRevice EventReciver;
        public static event OnJoin onJoin;

        //Delegate
        public delegate void CommandRevice(string IrcMessage);
        public delegate void OnJoin(string data);



        /// <summary>
        /// Connect Void
        /// </summary>
        public static void Connect()
        {
            //Start Listen Thread
            Thread thr = new Thread(new ThreadStart(Listen));
            thr.Name = "Listen";
            thr.Start();

            //Start IDLE Thread Prenvet TimeOut.
            Thread Idle = new Thread(new ThreadStart(IDLE));
            Idle.Name = "Idle";
            Idle.Start();

            //Events initialization
            onJoin += new OnJoin(IrcEngine_onJoin);
        }

        

        /// <summary>
        /// Data Reciver
        /// </summary>
        /// <param name="IrcMessage">Stream Data</param>
        static void IrcEngine_EventReciver(string IrcMessage)
        {
           
            if (IrcMessage.EndsWith("JOIN :" + chan))
            {
                onJoin(IrcMessage);
            }
        }



        /// <summary>
        /// OnJoin Event
        /// </summary>
        /// <param name="data">Stream Data</param>
        static void IrcEngine_onJoin(string data)
        {
            /* OnJoin Event Your Code Here */

            ConsoleUtility.InfoMessage("Joined to chan");
                      
        }
 


        /// <summary>
        /// Listen Stream Thread
        /// </summary>
        public static void Listen()
        {
            try
            {
                TcpClient irc = new TcpClient();
                irc.Connect(server_ip, server_port);
                NetworkStream netstr;
                netstr = irc.GetStream();
                sr = new StreamReader(netstr);
                sw = new StreamWriter(netstr);

                sw.WriteLine("PING " + server_ip);
                sw.Flush();
                Thread.Sleep(1500);

                sw.WriteLine(String.Format("USER {0} {1} * :{2}", IrcBot_nick, 0, IrcBot_nick));
                sw.Flush();

                sw.WriteLine(string.Format("NICK {0}", IrcBot_nick));
                sw.Flush();

                sw.WriteLine(string.Format("JOIN {0}", chan));
                sw.Flush();

                ConsoleUtility.DefaultColor();
          
                while (true)
                {
                    while ((data = sr.ReadLine()) != null)
                    {
                   
                        Console.WriteLine(data);
                        EventReciver += new CommandRevice(IrcEngine_EventReciver);

                        EventReciver(data);
                    

                    }
                }
            }
            catch (Exception a)
            {
                ConsoleUtility.ErrorMessage(a.Message);
            }

        }



        /// <summary>
        /// Dispose Resources
        /// </summary>
        public void Dispose()
        {
            this.Dispose();
            sr.Dispose();
            sw.Dispose();
            
        }


        /// <summary>
        /// Prevent TimeOut
        /// </summary>
        public static void IDLE()
        {
            Thread.Sleep(30000);
            sw.WriteLine("PING :" + server_ip);
            sw.Flush();
        }
    }
}
