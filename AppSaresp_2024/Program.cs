using AppSaresp_2024.Repository;
using AppSaresp_2024.Repository.Contract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Adicionando a Interface do aluno como serviço
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

// Adicionando a Interface do professor como serviço
builder.Services.AddScoped<IProfessorAplicadorRepository, ProfessorAplicadorRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
