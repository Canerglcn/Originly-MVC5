﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Originly_MVC5.Startup))]
namespace Originly_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
