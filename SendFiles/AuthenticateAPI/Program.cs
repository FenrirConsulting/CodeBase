using CVSHealth.IAM.IAPF.Tools.AuthenticateAPI;

#region Program
var builder = WebApplication.CreateBuilder(args);

// Add Application Services in Dependency Injection
#pragma warning disable CA1416
builder.Services.AddServerUI(builder.Configuration);

var app = builder.Build();

// Build Application Configuration from Dependency Injection
app.ConfigureServer(builder.Configuration);
#pragma warning restore CA1416

await app.RunAsync();
#endregion