using Microsoft.Owin.Hosting;
using ScreenpopUtil.Configurations;
using System;

namespace ScreenpopUtil.Services
{
    public class RestfulService
    {
        private IDisposable _app;
        public void Start()
        {
            _app = WebApp.Start<Startup>("http://localhost:6090");
        }
        public void Stop()
        {
            if (_app != null)
                _app.Dispose();
        }
    }
}
