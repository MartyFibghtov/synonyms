using synonyms_project.Core;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5000); // to listen for incoming http connection on port 5001
    // options.ListenAnyIP(5001, configure => configure.UseHttps()); // to listen for incoming https connection on port 7001
});

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add SynonymsStorage Singleton 
builder.Services.AddSingleton<SynonymsStorage>();
builder.Services.AddHealthChecks();

var app = builder.Build();

app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().WithExposedHeaders("WebSocket-Protocol"));

// Health
app.MapHealthChecks("/health");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();