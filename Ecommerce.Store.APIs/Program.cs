
using Ecommerce.Store.APIs.Errors;
using Ecommerce.Store.APIs.Helper;
using Ecommerce.Store.APIs.MiddleWares;
using Ecommerce.Store.Core;
using Ecommerce.Store.Core.Mapping.Products;
using Ecommerce.Store.Core.Services.Contract;
using Ecommerce.Store.Repository;
using Ecommerce.Store.Repository.Data;
using Ecommerce.Store.Repository.Data.Contexts;
using Ecommerce.Store.Service.Services.Products;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.APIs
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add Services To The Container.
            builder.Services.AddDependency(builder.Configuration);
            //
            var app = builder.Build();
            //
            await app.ConfigureMiddlewaresAsync();
            //
            app.Run();
        }
    }
}
