using AutoMapper;
using iShopCore.DbContexts;
using iShopCore.Helpers;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Repositories.Repos;
using iShopCore.Repositories.Repos.Configs;
using iShopCore.Services.Interfaces.Configs;
using iShopCore.Services.Services.Configs;

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
    IMapper mapper = AutoMapperConfig.RegisterMaps().CreateMapper();
    builder.Services.AddSingleton(mapper);
    builder.Services.AddAutoMapper(typeof(Program));
    
   
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
    builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
    builder.Services.AddScoped<ICompanyService, CompanyService>();
    builder.Services.AddScoped<IProductSpecService, ProductSpecService>();
    builder.Services.AddScoped<IProductSpecDeatilsService, ProductSpecDetailsService>();
    builder.Services.AddScoped<IDiscountService, DiscountService>();
    builder.Services.AddScoped<IPaymentGatewayApiService, PaymentGatewayApiService>();
    builder.Services.AddScoped<IBankService, BankService>();
    builder.Services.AddScoped<IBankAccountService, BankAccountService>();
    builder.Services.AddScoped<IDeliveryAgentService, DeliveryAgentService>();
    builder.Services.AddScoped<IAccountTypeService, AccountTypeService>();


    builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
    builder.Services.AddScoped<IProductSpecRepository, ProductSpecRepository>();
    builder.Services.AddScoped<IProductSpecDetailsRepository, ProductSpecDetailsRepository>();
    builder.Services.AddScoped<IDiscountRepository, DiscountRepository>();
    builder.Services.AddScoped<IPaymentGatewayApiRepository, PaymentGatewayApiRepository>();
    builder.Services.AddScoped<IBankRepository, BankRepository>();
    builder.Services.AddScoped<IBankAccountRepository, BankAccountRepository>();
    builder.Services.AddScoped<IDeliveryAgentRepository, DeliveryAgentRepository>();
    builder.Services.AddScoped<IAccountTypeRepository, AccountTypeRepository>();


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