namespace CS586Project
{
    public class VolumeUpCommand : iCommand
    {
        private iTV tv;

        public VolumeUpCommand(iTV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.VolumeUp();
        }
    }
}