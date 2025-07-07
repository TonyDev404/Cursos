var beerData = new BeerData();
beerData.Add("Corona");
beerData.Add("Delirium");
beerData.Add("Erdinger");

var reportGeneratorBeer = new ReportGeneratorBeer(beerData);
var reportGeneratorHtmlBeer = new ReportGeneratorHtmlBeer(beerData);
var report = new Report();
var data = reportGeneratorBeer.Generate();
//report.Save(reportGeneratorBeer, "cervezas.txt");
report.Save(reportGeneratorHtmlBeer, "cervezas.html");


public interface IReportGenerator
{
    public string Generate();
}

public class BeerData
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
    private BeerData _beerData = new BeerData();
    private int _limit;
    private int _count;

    public LimitedBeerData(int limit)
    {
        _limit = limit;
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

public class ReportGeneratorBeer : IReportGenerator
{
    private BeerData _beerData;

    public ReportGeneratorBeer(BeerData beerData)
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
}

public class ReportGeneratorHtmlBeer : IReportGenerator
{
    private BeerData _beerData;

    public ReportGeneratorHtmlBeer(BeerData beerData)
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