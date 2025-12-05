using System;
using System.Runtime.InteropServices;

namespace CS586Project
{
    public class Remote
    {
        private iTV tv;

        public Remote(iTV tv)
        {
            this.tv = tv;
        }

        public void Power()
        {
            tv.PowerToggle();
        }

        public void VolumeUp()
        {
            tv.VolumeUp();
        }
        public void VolumeDown()
        {
            tv.VolumeDown();
        }
        public void ChannelUp()
        {
            tv.ChannelUp();
        }
        public void ChannelDown()
        {
            tv.ChannelDown();
        }
        public void ChannelByNum(int num)
        {
            tv.ChannelByNum(num);
        }
        public void MuteToggle()
        {
            tv.MuteToggle();
        }
        public void Open(string app)
        {
            tv.Open(app);
        }

        public virtual void showStatus()
        {
            tv.currentStatus();
        }

    }
}