using CarAPIProject;
using CarModel.Car.CarDB;
using CarModel.Car.CarTypes;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers().AddNewtonsoftJson(setup => { setup.SerializerSettings.NullValueHandling = NullValueHandling.Ignore; setup.UseMemberCasing(); });

builder.Services.AddEndpointsApiExplorer();
                
builder.Services.AddSwaggerGen();

var app = builder.Build();

JsonOperations jsonOp = new JsonOperations();
await jsonOp.WriteJsonAsync(CarDB.list);
Cache.CarList= await jsonOp.ReadJsonAsync();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); 

app.MapControllers();

app.Run();
