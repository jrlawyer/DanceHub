﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanceHub.Startup))]
namespace DanceHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
