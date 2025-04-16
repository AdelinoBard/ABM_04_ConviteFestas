using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Ambiente de desenvolvimento: mostra página de erros detalhada
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    // Ambiente de produção: página de erro genérica
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Middleware padrão
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Roteamento padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
