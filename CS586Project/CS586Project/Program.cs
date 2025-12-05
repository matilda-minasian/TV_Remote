using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using CS586Project;

namespace TVRemoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TV regTV = new TV();
            SmartTV smartTV = new SmartTV();
            TVInterface tv = ChooseTV(regTV, smartTV);


            Remote remote = new Remote(tv);
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== TV Remote ===");
                Console.WriteLine("1. Power On/Off");
                Console.WriteLine("2. Volume Up");
                Console.WriteLine("3. Volume Down");
                Console.WriteLine("4. Channel Up");
                Console.WriteLine("5. Channel Down");
                Console.WriteLine("6. Choose Channel by Number");
                Console.WriteLine("7. Mute TV");
                Console.WriteLine("8. Choose TV Mode");
                Console.WriteLine("9. Open App (Smart TV only)");
                Console.WriteLine("10. Show Status of Current TV");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine() ?? string.Empty;

                switch (input)
                {
                    case "1": remote.Power(); break;
                    case "2": remote.VolumeUp(); break;
                    case "3": remote.VolumeDown(); break;
                    case "4": remote.ChannelUp(); break;
                    case "5": remote.ChannelDown(); break;
                    case "6":
                        Console.WriteLine("Enter a channel number:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        remote.ChannelByNum(num);
                        break;
                    case "7":
                        remote.MuteToggle();
                        break;
                    case "8":
                        tv = ChooseTV(regTV, smartTV);
                        remote = new Remote(tv);
                        break;

                    case "9":
                        Console.Write("Enter app name: ");
                        string app = Console.ReadLine() ?? string.Empty;
                        remote.Open(app);
                        break;
                    case "10":
                        remote.showStatus();
                        break;
                    case "0": running = false; break;
                    default: Console.WriteLine("Invalid input."); break;
                }
            }

            Console.WriteLine("Exiting TV Remote. Goodbye!");
        }


        static TVInterface ChooseTV(TV regTV, SmartTV smartTV)
        {
            Console.WriteLine("\nChoose TV Mode:");
            Console.WriteLine("1) Basic TV");
            Console.WriteLine("2) Smart TV");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine() ?? string.Empty;
            if (choice == "2")
            {
                smartTV.PowerToggle();
                smartTV.SmartModeToggle();

            }
            return choice == "1" ? (TVInterface)regTV : (TVInterface)smartTV;

        }
    }
}
