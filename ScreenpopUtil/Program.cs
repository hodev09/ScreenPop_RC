using ScreenpopUtil.Services;
using Topshelf;

namespace ScreenpopUtil
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Topshelf config
            HostFactory.Run(x =>
            {
                x.Service<RestfulService>(s =>
                {
                    s.ConstructUsing(() => new RestfulService());
                    s.WhenStarted(rs => rs.Start());
                    s.WhenStopped(rs => rs.Stop());
                    s.WhenShutdown(rs => rs.Stop());
                });
                x.RunAsLocalSystem();
                x.StartAutomatically();

                x.SetServiceName("Screenpop rest service");
                x.SetDisplayName("Screenpop rest service");                
            });
        }
    }
}
