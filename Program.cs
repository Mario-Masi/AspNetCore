public class Program        
{
   public static void Main(string[] args)
    {
        string? firstArgument = args.FirstOrDefault<string>();
        var builder = WebApplication.CreateBuilder(args);        
        
        builder.Services.AddMvc();

        var app = builder.Build();

        //HttpContext context = app.
        //string nome = context.Request.Query["nome"];
        //app.MapGet("/", () => $"Hello World Modificato");
        app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

        if (app.Environment.IsDevelopment()) 
        {
            app.UseDeveloperExceptionPage();
        }        

        app.UseStaticFiles();
        
        //app.UseMvc(routebuilder => {
        //    routebuilder.MapRoute("default", "{controller}/{action}/{id}");
        //});
        //app.UseMvcWithDefaultRoute();
        app.Run();

        //app.Run(async (context) => {
        //    string nome = context.Request.Query["nome"];
        //    await context.Response.WriteAsync($"Hello {nome}");
        //});
    }
}


