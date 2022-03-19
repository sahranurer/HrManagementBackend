using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<JobManager>().As<IJobService>().SingleInstance();
            builder.RegisterType<JobDal>().As<IJobDal>().SingleInstance();

            builder.RegisterType<RegionManager>().As<IRegionService>().SingleInstance();
            builder.RegisterType<RegionDal>().As<IRegionDal>().SingleInstance();

            builder.RegisterType<CountryManager>().As<ICountryService>().SingleInstance();
            builder.RegisterType<CountryDal>().As<ICountryDal>().SingleInstance();

            builder.RegisterType<LocationManager>().As<ILocationService>().SingleInstance();
            builder.RegisterType<LocationDal>().As<ILocationDal>().SingleInstance();

        }
    }
}
