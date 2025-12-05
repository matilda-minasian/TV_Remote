namespace CS586Project
{
    public class VolumeDownCommand : iCommand
    {
        private iTV tv;
        public VolumeDownCommand(iTV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.VolumeDown();
        }
    }
}