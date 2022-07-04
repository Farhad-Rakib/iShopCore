﻿using iShopCore.Entities.config;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.DbContexts;

public class ApplicationDbContext : DbContext
{
    protected readonly IConfiguration Configuration;
    public ApplicationDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to pgsql server database

        options.UseNpgsql(Configuration.GetConnectionString("ShopConnectionStringDev"));
    }
    public DbSet<Company> Companies { get; set; }
    public DbSet<ProductSpec> ProductSpecs { get; set; }
    public DbSet<ProductSpecDetails> ProductSpecDetails { get; set; }
}

