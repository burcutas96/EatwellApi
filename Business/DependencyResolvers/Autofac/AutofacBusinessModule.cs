﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Business.Mapping;
using Business.Security;
using Business.Security.JWT;
using Castle.DynamicProxy;
using Core.Utilities.Email;
using Core.Utilities.Email.Sendinblue;
using Core.Utilities.FileHelper;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.Configuration;
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
            builder.RegisterType<RestaurantContext>().InstancePerLifetimeScope();
            builder.RegisterType<FileHelper>().As<IFileHelper>().InstancePerLifetimeScope();
            builder.RegisterType<DashboardManager>().As<IDashboardService>().SingleInstance();
            builder.RegisterType<SendinblueService>().As<IEmailService>().SingleInstance();

            builder.RegisterType<BranchManager>().As<IBranchService>().SingleInstance();
            builder.RegisterType<EfBranchDal>().As<IBranchDal>().SingleInstance();

            builder.RegisterType<BranchImageManager>().As<IBranchImageService>().SingleInstance();
            builder.RegisterType<EfBranchImageDal>().As<IBranchImageDal>().SingleInstance();

            builder.RegisterType<BranchEmployeeManager>().As<IBranchEmployeeService>().SingleInstance();
            builder.RegisterType<EfBranchEmployeeDal>().As<IBranchEmployeeDal>().SingleInstance();

            builder.RegisterType<EvaluationManager>().As<IEvaluationService>().SingleInstance();
            builder.RegisterType<EfEvaluationDal>().As<IEvaluationDal>().SingleInstance();

            builder.RegisterType<MealCategoryManager>().As<IMealCategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<EfMealCategoryDal>().As<IMealCategoryDal>().InstancePerLifetimeScope();

            builder.RegisterType<ProductManager>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<EfProductDal>().As<IProductDal>().InstancePerLifetimeScope();

            builder.RegisterType<ReservationManager>().As<IReservationService>().InstancePerLifetimeScope();
            builder.RegisterType<EfReservationDal>().As<IReservationDal>().InstancePerLifetimeScope();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            
            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>().SingleInstance();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();

            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<TableManager>().As<ITableService>().InstancePerLifetimeScope();
            builder.RegisterType<EfTableDal>().As<ITableDal>().InstancePerLifetimeScope();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
