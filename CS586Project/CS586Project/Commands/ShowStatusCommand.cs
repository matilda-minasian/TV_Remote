namespace CS586Project
{
    public class ShowStatusCommand : iCommand
    {
        private iTV tv;

        public ShowStatusCommand(iTV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.Notify();
        }
    }
}