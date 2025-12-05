namespace CS586Project
{
    public class PowerCommand : iCommand
    {
        private iTV tv;

        public PowerCommand(iTV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.PowerToggle();
        }
    }
}