using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ClientStatusOrganizer.Data;
using ClientStatusOrganizer.ViewModel;

namespace ClientStatusOrganizer.StartUp
{
    public class Bootstrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<ClientDataService>().As<IClientDataService>();

            return builder.Build();
        }
    }
}
