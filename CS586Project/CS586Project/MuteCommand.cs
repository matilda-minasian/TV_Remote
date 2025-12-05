namespace CS586Project
{
    public class MuteCommand : iCommand
    {
        private iTV tv;

        public MuteCommand(iTV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.MuteToggle();
        }
    }
}