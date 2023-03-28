﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security;
using Core.Utilities.Security.JWT;
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
            builder.RegisterType<BranchManager>().As<IBranchService>().SingleInstance();
            builder.RegisterType<EfBranchDal>().As<IBranchDal>().SingleInstance();

            builder.RegisterType<EvaluationManager>().As<IEvaluationService>().SingleInstance();
            builder.RegisterType<EfEvaluationDal>().As<IEvaluationDal>().SingleInstance();

            builder.RegisterType<MealCategoryManager>().As<IMealCategoryService>().SingleInstance();
            builder.RegisterType<EfMealCategoryDal>().As<IMealCategoryDal>().SingleInstance();

            builder.RegisterType<ImageManager>().As<IImageService>().SingleInstance();
            builder.RegisterType<EfImageDal>().As<IImageDal>().SingleInstance();

            builder.RegisterType<ImageCategoryManager>().As<IImageCategoryService>().SingleInstance();
            builder.RegisterType<EfImageCategoryDal>().As<IImageCategoryDal>().SingleInstance();

            builder.RegisterType<MenuManager>().As<IMenuService>().SingleInstance();
            builder.RegisterType<EfMenuDal>().As<IMenuDal>().SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<ReservationManager>().As<IReservationService>().SingleInstance();
            builder.RegisterType<EfReservationDal>().As<IReservationDal>().SingleInstance();

            builder.RegisterType<RestaurantManager>().As<IRestaurantService>().SingleInstance();
            builder.RegisterType<EfRestaurantDal>().As<IRestaurantDal>().SingleInstance();

            builder.RegisterType<TableManager>().As<ITableService>().SingleInstance();
            builder.RegisterType<EfTableDal>().As<ITableDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
