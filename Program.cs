using System.Drawing;
using Console = Colorful.Console;
using System.Net.NetworkInformation;
using System.Globalization;
using TimeZoneNames;
Ping pingSender = new Ping();
Console.Title = "PingIt | Created By Gam3rrXD | Main Menu";
Console.WriteLine(@" /$$$$$$$  /$$                     /$$$$$$ /$$    ", Color.Gold);
Console.WriteLine(@"| $$__  $$|__/                    |_  $$_/| $$    ", Color.Gold);
Console.WriteLine(@"| $$  \ $$ /$$ /$$$$$$$   /$$$$$$   | $$ /$$$$$$  ", Color.Gold);
Console.WriteLine(@"| $$$$$$$/| $$| $$__  $$ /$$__  $$  | $$|_  $$_/  ", Color.Gold);
Console.WriteLine(@"| $$____/ | $$| $$  \ $$| $$  \ $$  | $$  | $$    ", Color.Gold);
Console.WriteLine(@"| $$      | $$| $$  | $$| $$  | $$  | $$  | $$ /$$", Color.Gold);
Console.WriteLine(@"| $$      | $$| $$  | $$|  $$$$$$$ /$$$$$$|  $$$$/", Color.Gold);
Console.WriteLine(@"|__/      |__/|__/  |__/ \____  $$|______/ \___/  ", Color.Gold);
Console.WriteLine(@"                         /$$  \ $$                ", Color.Gold);
Console.WriteLine(@"                        |  $$$$$$/                ", Color.Gold);
Console.WriteLine(@"                         \______/                 ", Color.Gold);
Console.WriteLine("Enter Host", Color.Gold);
var xd = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Enter Cooldown (ms)", Color.Gold);
var it = Console.ReadLine();
Console.WriteLine();
int result = Int32.Parse(it);
Console.WriteLine("Show Timestamp (Y/N)", Color.Gold);
var tim = Console.ReadLine().ToString().ToLower();
int a = 0;
int e = 0;
while (true)
{
    try 
    { 
        PingReply reply = pingSender.Send(xd);
        try
        {
            if (reply.Status == IPStatus.Success)
            {
                a++;
                Console.Title = "PingIt | Host: " + xd + " | Pings Sent: " + a.ToString() + " | Host Status: Online | Created By Gam3rrXD";
                Console.WriteLine();
                if (tim == "y" )
                {
                    DateTime localDate = DateTime.Now;
                    TimeZone localZone = TimeZone.CurrentTimeZone;
                    string lang = CultureInfo.CurrentCulture.Name;
                    var abbreviations = TZNames.GetAbbreviationsForTimeZone(localZone.StandardName, lang);
                    Console.Write("[", Color.White);
                    Console.Write(localDate + " ", Color.Aqua);
                    Console.Write(abbreviations.Standard, Color.Aqua);
                    Console.Write("] ", Color.White);
                }
                if (tim == "Y")
                {
                    DateTime localDate = DateTime.Now;
                    TimeZone localZone = TimeZone.CurrentTimeZone;
                    string lang = CultureInfo.CurrentCulture.Name;
                    var abbreviations = TZNames.GetAbbreviationsForTimeZone(localZone.StandardName, lang);
                    Console.Write("[", Color.White);
                    Console.Write(localDate + " ", Color.Aqua);
                    Console.Write(abbreviations.Standard, Color.Aqua);
                    Console.Write("] ", Color.White);
                }
                Console.Write("IP: ", Color.White);
                Console.Write(reply.Address.ToString(), Color.Lime);
                Console.Write(" | Time Taken: ", Color.White);
                Console.Write(reply.RoundtripTime, Color.Aqua);
                Console.Write(" ms", Color.White);
                Console.Write(" | Packets Sent: ", Color.White);
                Console.Write(reply.Buffer.Length, Color.Orange);
                Console.Write(" | Pings Sent: ", Color.White);
                Console.Write(a.ToString(), Color.Purple);
                Console.Write(" | Status: ", Color.White);
                Console.Write(reply.Status, Color.Green);
                Console.Write(" | PingIt ~", Color.White);
                Console.Write(" Gam3rrXD", Color.Red);
                Thread.Sleep(result);
            }
            else
            {
                Console.WriteLine();
                Console.Write("Host ", Color.White);
                Console.Write("Offline ", Color.Red);
                Console.Write(" | Status: ", Color.White);
                Console.Write(reply.Status, Color.Red);
                Console.Title = "PingIt | Host: " + xd + " | Pings Sent: " + a.ToString() + " | Host Status: Offline | Created By ~ Gam3rrXD";
                continue;
            }
        }
        catch (Exception ex)
        {
            e++;
            Console.WriteLine();
            Console.Title = "PingIt | Host: " + xd + " | Error's: " + e.ToString() + " | Host Status: Unknown | ERROR! | Created By ~ Gam3rrXD";
            Console.Write("Error ", Color.Red);
            Console.Write("| PingIt ~ Created By ", Color.White);
            Console.Write("Gam3rrXD", Color.Red);
            continue;
        }

    }
    catch (Exception ex)
    {
        e++;
        Console.WriteLine();
        Console.Title = "PingIt | Host: " + xd + " | Error's: " + e.ToString() + " | Host Status: Unknown | ERROR! | Created By ~ Gam3rrXD";
        Console.Write("Error ", Color.Red);
        Console.Write("| PingIt ~ Created By ", Color.White);
        Console.Write("Gam3rrXD", Color.Red);
        continue;
    }
    
    
}

