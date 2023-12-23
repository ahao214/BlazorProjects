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
        .UseMonitorCommand(cmd => Console.WriteLine($"Sql��{cmd.CommandText}"))//����SQL���
        .UseAutoSyncStructure(true) //�Զ�ͬ��ʵ��ṹ�����ݿ⣬FreeSql����ɨ����򼯣�ֻ��CRUDʱ�Ż����ɱ�
        .Build();

// �������ʱ�򣬽�Entityȥ��
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
