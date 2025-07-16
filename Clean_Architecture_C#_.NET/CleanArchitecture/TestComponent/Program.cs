using BusinessComponent;
using Microsoft.Extensions.DependencyInjection;
using RepositoryComponent;

var container = new ServiceCollection()
    .AddSingleton<IRepository, BeerRepository>()//mismo objeto siempre
    //.AddSingleton<IRepository, DefaultRepository>() //cambiamos la clase
    .AddTransient<BeerManager>()//los objetos van a ser unicos cada vez que se solicite
    .BuildServiceProvider();
//Esto lo hacemos, ya que si cambiamos, por ejemplo, la clase que implementa IRepository solo la cambiamos arriba y listo

var beerManager = container.GetService<BeerManager>();
var beerManager2 = container.GetService<BeerManager>();
var beerManager3 = container.GetService<BeerManager>();
var beerManager4 = container.GetService<BeerManager>();

beerManager.Add("Delrium Red");
beerManager.Add("London Porter");
Console.WriteLine(beerManager.Get());

//clase provisional
public class DefaultRepository : IRepository
{
    public void Add(string beer)
    { }

    public string Get() => "Algo";
}