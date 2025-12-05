using System;
using System.Diagnostics;

namespace CS586Project
{
    public class SmartTV : TV
    {
        public bool smartModeStatus { get; private set; }
        public string currentApp { get; private set; }

        private string[] appList = { "Netflix", "YouTube", "Hulu", "Disney+", "Spotify", "Amazon Video", "Paramount+" };

        public SmartTV() : base()
        {
            smartModeStatus = false;
            currentApp = "";
        }

        public void SmartModeToggle()
        {
            if (powerStatus)
            {
                smartModeStatus = !smartModeStatus;
                if (!smartModeStatus)
                {
                    currentApp = "";
                    Console.WriteLine("Exited Smart TV.");
                }
                else
                {
                    Console.WriteLine("Entered Smart TV.");
                }
            }
            Notify();
        }

        public override void Open(string app)
        {
            if (powerStatus && smartModeStatus && appList.Contains(app))
            {
                currentApp = app;
                Console.WriteLine($"{app} opened.");
            }
            else
            {
                Console.WriteLine("App not available");
            }

            Notify();
        }


        public override void currentStatus()
        {
            if (!powerStatus)
            {
                Console.WriteLine("The TV is off.");

            }
            else
            {
                Console.WriteLine("TV Status");
                Console.WriteLine($"Power: {(powerStatus ? "On" : "Off")}");
                Console.WriteLine($"Channel: {channelStatus}");

                if (muteStatus)
                {
                    Console.WriteLine("TV is muted.");
                }
                else
                {
                    Console.WriteLine($"Volume: {volumeStatus}");
                }
                if (smartModeStatus)
                {
                    Console.WriteLine($"Smart TV is currently on.");
                    Console.WriteLine($"Current App {currentApp}");
                }
                else
                {
                    Console.WriteLine("Mode: TV");

                }
            }
        }

    }
}