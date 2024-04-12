using System;
using System.Net;
namespace nslook
{
    internal class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            if (args.Length < 1 || args[0].Equals("-help"))
            {
                Console.WriteLine("Usage is: nslookup [Host Name] | [Host IP] | -help");
                return -1;
            }
            else
            {
                try
                {
                    IPHostEntry ipEntry;
                    IPAddress[] ipAddr;
                    char[] alpha = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ-".ToCharArray();
                    if (args[0].IndexOfAny(alpha) != -1)
                    {
                        ipEntry = Dns.GetHostEntry(args[0]);
                        ipAddr = ipEntry.AddressList;
                        Console.WriteLine("\nHost Name : " + args[0]);
                        int i = 0;
                        int len = ipAddr.Length;
                        for (i = 0; i < len; i++)
                        {
                            Console.WriteLine("Address {0} : {1} ", i, ipAddr[i].ToString());
                        }
                        return 0;
                    }
                    else
                    {
                        ipEntry = Dns.GetHostEntry(args[0]);
                        Console.WriteLine("Address : " + args[0]);
                        Console.WriteLine("Host Name : " + ipEntry.HostName);
                        return 0;
                    }
                }
                catch (System.Net.Sockets.SocketException se)
                {
                    Console.WriteLine(se.Message.ToString());
                    return -1;
                }
                catch (System.FormatException fe)
                {
                    Console.WriteLine(fe.Message.ToString());
                    return -1;
                }
            }
        }
    }
}