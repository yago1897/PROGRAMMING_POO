using Services.Core.Interfaces;
using Services.Infraestructure.Notificaciones;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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

app.UseAuthorization();

app.MapRazorPages();

// 🧪 Ejecución de prueba del patrón Observer
app.MapGet("/test/observer", () =>
{
    var gestorPedidos = new GestorPedidos();

    gestorPedidos.Suscribir(new NotificadorUI());
    gestorPedidos.Suscribir(new GestorInventario());

    gestorPedidos.CambiarEstadoPedido(101, "Enviado");

    return Results.Ok("Se ejecutó la prueba del patrón Observer. Revisa la salida de la consola.");
});



app.Run();
