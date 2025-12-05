using System;
using System.Runtime.InteropServices;

namespace CS586Project
{
    public class Remote
    {
        private iTV tv;

        private iCommand powerCommand;
        private iCommand volumeUpCommand;
        private iCommand volumeDownCommand;
        private iCommand channelUpCommand;
        private iCommand channelDownCommand;
        private iCommand muteToggleCommand;

        public Remote(iTV tv)
        {
            this.tv = tv;
            powerCommand = new PowerCommand(tv);
            volumeUpCommand = new VolumeUpCommand(tv);
            volumeDownCommand = new VolumeDownCommand(tv);
            channelUpCommand = new ChannelUpCommand(tv);
            channelDownCommand = new ChannelDownCommand(tv);
            muteToggleCommand = new MuteCommand(tv);
        }

        public void Power()
        {
            powerCommand.Execute();
        }

        public void VolumeUp()
        {
            volumeUpCommand.Execute();
        }
        public void VolumeDown()
        {
            volumeDownCommand.Execute();
        }
        public void ChannelUp()
        {
            channelUpCommand.Execute();
        }
        public void ChannelDown()
        {
            channelDownCommand.Execute();
        }
        public void ChannelByNum(int num)
        {
            SetChannelCommand setChannel = new SetChannelCommand(tv, num);
            setChannel.Execute();
        }
        public void MuteToggle()
        {
            muteToggleCommand.Execute();
        }
        public void Open(string app)
        {
            OpenAppCommand openApp = new OpenAppCommand(tv, app);
            openApp.Execute();
        }

        public virtual void showStatus()
        {
            tv.currentStatus();
        }

    }
}