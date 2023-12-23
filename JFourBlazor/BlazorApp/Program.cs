using BlazorApp.Data;
using BlazorApp.Entity;
using FreeSql;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args).Inject();

builder.Services.AddBootstrapBlazor();
// Add services to the container.
builder.Services.AddRazorPages().AddInjectBase();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

#region Freesql

var connStr = builder.Configuration["Db:ConnStr"];
IFreeSql fsql = new FreeSql.FreeSqlBuilder()
        .UseConnectionString(FreeSql.DataType.Sqlite, connStr)
        .UseMonitorCommand(cmd => Console.WriteLine($"Sql：{cmd.CommandText}"))//监听SQL语句
        .UseAutoSyncStructure(true) //自动同步实体结构到数据库，FreeSql不会扫描程序集，只有CRUD时才会生成表。
        .Build();

// 创建表的时候，将Entity去掉
fsql.Aop.ConfigEntity += (sender, e) =>
{
    e.ModifyResult.Name = e.EntityType.Name.Replace("Entity", "");
};

BaseEntity.Initialization(fsql, () => null);
UserEntity.Select.ToList();

#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseInjectBase();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
