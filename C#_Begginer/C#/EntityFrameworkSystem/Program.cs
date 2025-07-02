using DB;
using Microsoft.EntityFrameworkCore;

DbContextOptionsBuilder<CsharpDbContext> optionsBuilder = new DbContextOptionsBuilder<CsharpDbContext>();
optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=CsharpDB; Trusted_Connection=True; TrustServerCertificate=True;");

bool again = true;
int op = 0;

do
{
    ShowMenu();
    Console.WriteLine("Elige una opción");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Show(optionsBuilder);
            break;
        case 2:
            Add(optionsBuilder);
            break;
        case 3:
            Edit(optionsBuilder);
            break;
        case 4:
            Delete(optionsBuilder);
            break;
        case 5:
            again = false;
            break;
    }
} while (again);

static void Show(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
{
    Console.Clear();
    Console.WriteLine("Cervezas en la base de datos");
    
    using (var context = new CsharpDbContext(optionsBuilder.Options))
    {
        // var beers = context.Beers.ToList();
        // var beers = context.Beers.OrderBy(b => b.Name).ToList();
        var beers2 = (from b in context.Beers
            where b.BrandId == 2
            orderby b.Name
            select b).Include(b => b.Brand).ToList();
        
        
        foreach (var beer in beers2)
        {
            Console.WriteLine($"{beer.Id} - {beer.Name} {beer.Brand.Name}");
        }
    }
}

static void Add(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
{
    Console.Clear();
    Console.WriteLine("Agregar nueva cerveza");
    Console.WriteLine("Escribe el nombre:");
    string name = Console.ReadLine();

    Console.WriteLine("Escribe el id de la marca:");
    int brandId = int.Parse(Console.ReadLine());

    using (var context = new CsharpDbContext(optionsBuilder.Options))
    {
        Beer beer = new Beer()
        {
            Name = name,
            BrandId = brandId
        };
        context.Add(beer); //Aquí solo se agrega el objeto, pero no se guarda en la DB
        context.SaveChanges(); //Este manda la información a la DB
    }
}

static void Edit(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
{
    Console.Clear();
    Show(optionsBuilder);
    Console.WriteLine("Editar cerveza");
    Console.WriteLine("Escribe el ID de tu cerveza a editar:");
    int id = int.Parse(Console.ReadLine());

    using (var context = new CsharpDbContext(optionsBuilder.Options))
    {
        Beer beer = context.Beers.Find(id); //Finds an entity with the given primary key values

        if (beer != null)
        {
            Console.WriteLine("Escribe el nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el ID de la marca: ");
            int brandId = int.Parse(Console.ReadLine());
            
            beer.Name = name;
            beer.BrandId = brandId;
            context.Entry(beer).State = EntityState.Modified; //Entry - Recibe el objeto que estamos modificando, Modified - indica que a sido modificado
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("La cerveza no existe");
        }
    }
}

static void Delete(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
{
    Console.Clear();
    Show(optionsBuilder);
    Console.WriteLine("Eliminar cerveza");
    Console.WriteLine("Escribe el ID de la cerveza a eliminar");
    int id = int.Parse(Console.ReadLine());

    using (var context = new CsharpDbContext(optionsBuilder.Options))
    {
        Beer beer = context.Beers.Find(id);
        if (beer != null)
        {
            context.Beers.Remove(beer);
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("La cerveza no existe");
        }
    }
}

static void ShowMenu()
{
    Console.WriteLine("\n--------------Menú--------------");
    Console.WriteLine("1.- Mostrar");
    Console.WriteLine("2.- Agregar");
    Console.WriteLine("3.- Editar");
    Console.WriteLine("4.- Eliminar");
    Console.WriteLine("5.- Salir");
}



// using (CsharpDbContext context = new CsharpDbContext(optionsBuilder.Options)) //Ejecuta el método Dispose (para cerrar la conexión) dentro de este micro universo (ámbito) donde lo usemos
// {
//     var beers = context.Beers.ToList();
//
//     foreach (var beer in beers)
//     {
//         Console.WriteLine(beer.Name);
//     }
// }

