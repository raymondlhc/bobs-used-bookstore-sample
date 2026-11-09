using Microsoft.AspNetCore.Builder;

using Bookstore.Web.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.AddApplicationServices();

var app = builder.Build();

await app.ConfigureMiddlewareAsync();

app.Run();
