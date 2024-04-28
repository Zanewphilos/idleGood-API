using idleGood_WebAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Tokens;
using System.Text;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//db
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5, // 
            maxRetryDelay: TimeSpan.FromSeconds(3),
            errorNumbersToAdd: null); 
    }));

//identity
builder.Services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

//jwt
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
            ValidateIssuer = false,
            ValidateAudience = false,
            
            // ValidIssuer = builder.Configuration["Jwt:Issuer"],
            // ValidAudience = builder.Configuration["Jwt:Audience"],
        };
    });


var app = builder.Build();

    using (var scope = app.Services.CreateScope())
    {
        var serviceProvider = scope.ServiceProvider;
        var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

        // password generate method
        async Task ResetUserPassword(UserManager<User> userManager, string userId, string newPassword)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user != null)
            {
                // 移除当前密码
                var removePasswordResult = await userManager.RemovePasswordAsync(user);
                if (removePasswordResult.Succeeded)
                {
                    // set new password
                    var addPasswordResult = await userManager.AddPasswordAsync(user, newPassword);
                    if (!addPasswordResult.Succeeded)
                    {
                        // if setting failed, throw exception
                        throw new InvalidOperationException($"Error setting new password for user {userId}");
                    }
                }
                else
                {
                    // if remove failed, throw exception
                    throw new InvalidOperationException($"Error removing old password for user {userId}");
                }
            }
        }

        //create user password 
        await ResetUserPassword(userManager, "1", "Password123.");
        await ResetUserPassword(userManager, "2", "Password123.");

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        // In production, handle exceptions in a user-friendly way
        app.UseExceptionHandler("/Error");
    }

    // Optionally, enable Swagger in production if needed
    if (app.Environment.IsDevelopment() || app.Environment.IsProduction()) // 或者使用其他环境标识
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();


    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}

