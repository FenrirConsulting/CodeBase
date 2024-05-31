using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using CVSHealth.IAM.IAPF.Tools.ApplicationShell;

var builder = WebApplication.CreateBuilder(args);

// Use static web assets
builder.WebHost.UseStaticWebAssets();

// Add application services
builder.Services
    .AddServerUI(builder.Configuration);

var app = builder.Build();

app.ConfigureServer(builder.Configuration);

await app.RunAsync();