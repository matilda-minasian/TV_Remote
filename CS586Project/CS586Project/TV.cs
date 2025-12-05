using System;
using System.Threading.Channels;

namespace CS586Project
{
    public class TV : iTV
    {
        public bool powerStatus { get; protected set; }
        public int volumeStatus { get; protected set; }
        public int channelStatus { get; protected set; }
        public bool muteStatus { get; protected set; }

        private List<iTVObserver> observers = new List<iTVObserver>();

        public void Attach(iTVObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(iTVObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
        public TV()
        {
            powerStatus = false;
            volumeStatus = 10;
            channelStatus = 1;
            muteStatus = false;
        }

        public virtual void PowerToggle()
        {
            powerStatus = !powerStatus;
            if (!powerStatus)
            {
                muteStatus = false;
                Console.WriteLine("TV is off.");
            }
            else
            {
                Console.WriteLine("TV is on.");
            }

            Notify();

        }

        public virtual void VolumeUp()
        {
            if (powerStatus && !muteStatus && volumeStatus < 100)
            {
                Console.WriteLine($"The volume is now {++volumeStatus}");

            }
            else if (powerStatus && muteStatus)
            {
                Console.WriteLine("The TV is muted. Can not change volume.");
            }
            else
            {
                Console.WriteLine("The tv is off.");
            }

            Notify();
        }

        public virtual void VolumeDown()
        {
            if (powerStatus && !muteStatus && volumeStatus >= 1)
            {
                Console.WriteLine($"The volume is now {--volumeStatus}");

            }
            else if (powerStatus && !muteStatus && volumeStatus == 0)
            {
                Console.WriteLine($"The volume is {volumeStatus}.");
            }
            else if (powerStatus && muteStatus)
            {
                Console.WriteLine("The TV is muted. Can not change volume.");
            }
            else
            {
                Console.WriteLine("The tv is off.");
            }

            Notify();
        }

        public virtual void ChannelUp()
        {
            if (!powerStatus)
            {
                Console.WriteLine("TV Power is off. Turn on TV.");
                return;
            }

            if (channelStatus < 150)
            {
                Console.WriteLine($"The channel is now {++channelStatus}");

            }
            else
            {
                Console.WriteLine("Channel does not exist. Channel can only go up to 150.");
            }

            Notify();
        }
        public virtual void ChannelDown()
        {
            if (!powerStatus)
            {
                Console.WriteLine("TV Power is off. Turn on TV.");
                return;
            }

            if (channelStatus > 1)
            {
                Console.WriteLine($"The channel is now {--channelStatus}");

            }
            else
            {
                Console.WriteLine($"Channel can not go lower. Channel is still {channelStatus}");
            }
            Notify();
        }

        public virtual void ChannelByNum(int num)
        {
            if (num > 0 && num <= 150 && powerStatus)
            {
                channelStatus = num;

            }
            else if (num > 150 && powerStatus)
            {
                Console.WriteLine("Channel does not exist. Channel can only go up to 150.");
            }
            else if (num < 1 && powerStatus)
            {
                Console.WriteLine("Invalid number entered. Please enter a number higher than 0.");
            }
            else
            {
                Console.WriteLine("TV Power is off. Turn on TV.");
            }

            Notify();
        }
        public virtual void MuteToggle()
        {
            muteStatus = !muteStatus;
            if (muteStatus)
            {
                Console.WriteLine("The TV is now muted.");
            }
            else
            {
                Console.WriteLine($"The TV is now unmuted. The volume is now {volumeStatus}");

            }
            Notify();
        }

        public virtual void currentStatus()
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
            }

        }
        public virtual void Open(string app)
        {
            Console.WriteLine("This TV does not support apps.");
            Notify();
        }
    }
}