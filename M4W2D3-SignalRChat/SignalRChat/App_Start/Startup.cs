using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;

[assembly:OwinStartup(typeof(SignalRChat.App_Start.Startup))]
namespace SignalRChat.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}