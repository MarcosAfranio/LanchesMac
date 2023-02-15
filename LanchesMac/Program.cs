namespace LanchesMac;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBilder(args)
            .Build()
            .Run();
    }

    public static IHostBuilder CreateHostBilder(string[] agrs) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(WebHostBuilder =>
        {
            WebHostBuilder.UseStartup<Startap>();
        });
}
