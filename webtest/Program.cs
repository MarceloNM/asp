/*
 * UFCD-10792-ASP.Net-Tarefa 2 - Projeto Final: Ponto de situação
 * Para entrega a 28 de maio de 2024 às 23:59
 * Instruções
 * Anexar a esta tarefa o seguinte:
 * Apresentar num pdf o desenvolvimento e implementação que já fizeram 
 * até ao momentos do vosso projeto no 
 * Visual Studio (site, código c#, base de dados, etc.)
 * Anexar os ficheiros relevantes das pastas Models, Views e Controllers 
 * dos respetivos ficheiros (.cs .cshtml, etc.) que foram desenvolvidos 
 * Anexar outros documentos que entendam ser relevantes que não estão 
 * mencionados nos pontos anteriores
 */


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
