IRepository<string> beerData = new BeerData();
beerData.Add("Corona");
beerData.Add("Delirium");
beerData.Add("Erdinger");

var reportGeneratorBeer = new ReportGeneratorBeer(beerData);
var reportGeneratorHtmlBeer = new ReportGeneratorHtmlBeer(beerData);
var report = new Report();
var data = reportGeneratorBeer.Generate();
//report.Save(reportGeneratorBeer, "cervezas.txt");
report.Save(reportGeneratorHtmlBeer, "cervezas.html");

Show(reportGeneratorBeer);
void Show(IReportShow report)
{
    report.Show();
}

public interface IReportGenerator
{
    public string Generate();
}
public interface IReportShow
{
    public void Show();
}

public interface IRepository<T>
{
    public void Add(T item);
    public List<T> Get();
}

public class BeerData : IRepository<string>
{
    protected List<string> _beers;

    public BeerData()
    {
        _beers = new List<string>();
    }

    public virtual void Add(string beer) => _beers.Add(beer);
    public List<string> Get() => _beers;
}

// public class LimitedBeerData : BeerData
// {
//     private int _limit;
//     
//     public LimitedBeerData(int limit) => _limit = limit;
//
//     public override void Add(string beer)
//     {
//         if (_beers.Count >= _limit)
//         {
//             throw new InvalidOperationException("Limite de cervezas alcanzado");
//         }
//         base.Add(beer);    
//     }
// }

public class LimitedBeerData
{
    private IRepository<string> _beerData;
    private int _limit;
    private int _count = 0;

    public LimitedBeerData(int limit, IRepository<string> beerData)
    {
        _limit = limit;
        _beerData = beerData;
    }

    public void Add(string beer)
    {
        if (_count >= _limit)
        {
            throw new InvalidOperationException("Limite de cervezas alcanzado");
        }
        _beerData.Add(beer);
        _count++;
    }
}

public class ReportGeneratorBeer : IReportGenerator, IReportShow
{
    private IRepository<string> _beerData;

    public ReportGeneratorBeer(IRepository<string> beerData)
    {
        _beerData = beerData;
    }

    public string Generate()
    {
        string data = "";
        foreach (var beer in _beerData.Get())
        {
            data += "Cerveza: " + beer + Environment.NewLine; //Es una salgo de línea en un archivo de texto
        }

        return data;
    }

    public void Show()
    {
        foreach (var beer in _beerData.Get())
        {
            Console.WriteLine("Cerveza: " + beer);
        }
    }
}

public class ReportGeneratorHtmlBeer : IReportGenerator
{
    private IRepository<string> _beerData;

    public ReportGeneratorHtmlBeer(IRepository<string> beerData)
    {
        _beerData = beerData;
    }
    public string Generate()
    {
        string data = "<div>";

        foreach (var beer in _beerData.Get())
        {
            data += "<b>" + beer + "<b></br>";
        }

        data += "</div>";
        return data;
    }

    public void Show()
    {
        throw new NotImplementedException();
    }
}

public class Report
{
    public void Save(IReportGenerator reportGenerator, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            string data = reportGenerator.Generate();
            writer.WriteLine(data);
        }
    }
}


// Rectangle rectangle = new Square();
// rectangle.setWidth(10);
// rectangle.setHeight(20);
// Console.WriteLine(rectangle.getArea());
//
// public class Rectangle
// {
//     private int _width;
//     private int _height;
//
//     public virtual void setWidth(int width)
//     {
//         _width = width;
//     }
//
//     public virtual void setHeight(int height)
//     {
//         _height = height; 
//     }
//
//     public int getArea()
//     {
//         return _width * _height;
//     }
// }
//
// public class Square : Rectangle
// {
//     public override void setWidth(int width)
//     {
//         base.setWidth(width);
//         base.setHeight(width);
//     }
//
//     public override void setHeight(int height)
//     {
//         base.setHeight(height);
//         base.setWidth(height);
//     }
// }