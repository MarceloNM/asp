/*
 * UFCD-10792-ASP.Net-Tarefa 2 - Projeto Final: Ponto de situa��o
 * Para entrega a 28 de maio de 2024 �s 23:59
 * Instru��es
 * Anexar a esta tarefa o seguinte:
 * Apresentar num pdf o desenvolvimento e implementa��o que j� fizeram 
 * at� ao momentos do vosso projeto no 
 * Visual Studio (site, c�digo c#, base de dados, etc.)
 * Anexar os ficheiros relevantes das pastas Models, Views e Controllers 
 * dos respetivos ficheiros (.cs .cshtml, etc.) que foram desenvolvidos 
 * Anexar outros documentos que entendam ser relevantes que n�o est�o 
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
