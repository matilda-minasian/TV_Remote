namespace CS586Project
{
    public class OpenAppCommand : iCommand
    {
        private iTV tv;
        private string app;
        public OpenAppCommand(iTV tv, string app)
        {
            this.tv = tv;
            this.app = app;
        }

        public void Execute()
        {
            tv.Open(app);
        }
    }
}