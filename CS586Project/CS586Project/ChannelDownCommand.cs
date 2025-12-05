namespace CS586Project
{
    public class ChannelDownCommand : iCommand
    {
        private iTV tv;

        public ChannelDownCommand(iTV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.ChannelDown();
        }
    }
}