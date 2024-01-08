using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CourseAgendaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CourseAgendaDbContext") ?? throw new InvalidOperationException("Connection string 'CourseAgendaDbContext' not found.")));

dotenv.net.DotEnv.Load();

var dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
var dbUser = Environment.GetEnvironmentVariable("DB_USER");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");

var connectionString = $"Server={dbServer};Database={dbName};User Id={dbUser};Password={dbPassword};Trusted_Connection=false;MultipleActiveResultSets=true;Trust Server Certificate=true";

// builder.Services.AddDbContext<ClassAgendaDbContext>(options =>
    // options.UseSqlServer(builder.Configuration.GetConnectionString("ClassAgendaDbContext") ?? throw new InvalidOperationException("Connection string 'ClassAgendaDbContext' not found.")));

builder.Services.AddDbContext<ClassAgendaDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

// builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
} else {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
