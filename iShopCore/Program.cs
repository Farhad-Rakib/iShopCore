using AutoMapper;
using iShopCore.DbContexts;


var builder = WebApplication.CreateBuilder(args);

{

    builder.Services.AddCors();
    builder.Services.AddControllers();

    // Database Context
    builder.Services.AddDbContext<ApplicationDbContext>();
    AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
   
    // configure automapper with all automapper profiles from this assembly
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
   
    var devCorsPolicy = "devCorsPolicy";
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(devCorsPolicy, builder =>
        {
            builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        });
    });

    // configure strongly typed settings object
    //services.Configure<AppSettings>(builder.Configuration.GetSection("AppSecret"));

    // configure DI for application services
    //services.AddScoped<IJwtUtils, JwtUtils>();
    //services.AddScoped<IUserRepository, UserRepository>();
    //services.AddScoped<IUserService, UserService>();
}

var app = builder.Build();
{
    // configure HTTP request pipeline

    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
    // global cors policy
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());



    app.MapControllers();
}
if (app.Environment.IsDevelopment())
{
    app.Run();
}
else
{
    app.Run("http://0.0.0.0:3000");
}