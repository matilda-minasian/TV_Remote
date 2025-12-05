using System;

namespace CS586Project
{
    public interface iTV
    {
        void PowerToggle();
        void VolumeUp();
        void VolumeDown();
        void ChannelUp();
        void ChannelDown();
        void ChannelByNum(int num);
        void MuteToggle();
        void currentStatus();

        void Open(string app);

    }
}