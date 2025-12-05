namespace CS586Project
{
    public class SetChannelCommand : iCommand
    {
        private iTV tv;
        private int channel;

        public SetChannelCommand(iTV tv, int channel)
        {
            this.tv = tv;
            this.channel = channel;
        }

        public void Execute()
        {
            tv.ChannelByNum(channel);
        }
    }
}