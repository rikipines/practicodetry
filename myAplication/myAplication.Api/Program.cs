using myAplication.core.Repostories;
using myAplication.core.serveis;
using myAplication.Data;
using myAplication.Data.Repostory;
using myAplication.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IChildServer, ChildServer>();
builder.Services.AddScoped<IChildReposetoreis,ChildReposetory>();

builder.Services.AddScoped<IManegerServies, ManegerServies>();
builder.Services.AddScoped<IManegerReposetory, ManegerReposetory>();

builder.Services.AddScoped<IMParentServer, ParentServer>();
builder.Services.AddScoped<IParentReposetory, ParentReposetory>();

builder.Services.AddDbContext<DataContex>();

//builder.Services.AddSingleton<DataContex>();





var app = builder.Build();

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
