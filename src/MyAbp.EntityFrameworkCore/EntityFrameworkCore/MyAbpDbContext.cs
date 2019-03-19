﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyAbp.Authorization.Roles;
using MyAbp.Authorization.Users;
using MyAbp.MultiTenancy;

namespace MyAbp.EntityFrameworkCore
{
    public class MyAbpDbContext : AbpZeroDbContext<Tenant, Role, User, MyAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyAbpDbContext(DbContextOptions<MyAbpDbContext> options)
            : base(options)
        {
        }
    }
}
