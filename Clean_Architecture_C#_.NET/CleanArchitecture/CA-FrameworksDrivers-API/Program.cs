using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapter_Repository;
using CA_InferfaceAdapter_Data;
using CA_InterfaceAdapter_Mapper;
using CA_InterfaceAdapter_Mapper.Dtos.Requests;
using CA_InterfaceAdapter_Presenters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//dependencies
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration
            .GetConnectionString("DefaultConnection")); //Toma la conexión que tenemos en appsettings.json
});
builder.Services.AddScoped<IRepository<Beer>, Repository>(); //Scoped, cada solicitud que se haga, se va hacer un objeto
builder.Services.AddScoped<IPresenter<Beer, BeerViewModel>, BeerPresenter>();
builder.Services.AddScoped<IMapper<BeerRequestDto, Beer>, BeerMapper>();
builder.Services.AddScoped<GetBeerUseCase<Beer, BeerViewModel>>();
builder.Services.AddScoped<AddBeerUseCase<BeerRequestDto>>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/beer",
        async (GetBeerUseCase<Beer, BeerViewModel> beerUseCase) => { return await beerUseCase.ExecuteAsync(); })
    .WithName("beers")
    .WithOpenApi();

app.MapPost("/beer", async (BeerRequestDto beerRequest,
    AddBeerUseCase<BeerRequestDto> beerUseCase) =>
    {
        await beerUseCase.ExecuteAsync(beerRequest);
        return Results.Created();
    }).WithName("addBeer")
.WithOpenApi();

app.Run();