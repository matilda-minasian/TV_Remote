namespace CS586Project
{
    public class ChannelUpCommand : iCommand
    {
        private iTV tv;

        public ChannelUpCommand(iTV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.ChannelUp();
        }
    }
}