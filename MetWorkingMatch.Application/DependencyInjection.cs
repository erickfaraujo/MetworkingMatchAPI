﻿using System;
using System.Reflection;
using AutoMapper;
using MediatR;
using MetWorkingMatch.Application.Contracts;
using MetWorkingMatch.Application.Pedido.Commands;
using MetWorkingMatch.Application.Pedido.Handlers;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;

namespace MetWorkingMatch.Application
{
    public static class DependencyInjection
    {
        public static void addAplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
