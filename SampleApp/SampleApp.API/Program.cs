using AutoMapper;
using SampleApp.Domain.Business;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var mappingConfiguration = new MapperConfiguration(configuration =>
{
    configuration.AddProfile(new SampleApp.API.Mapping.DTOToModelProfile());
});
IMapper mapper = mappingConfiguration.CreateMapper();

builder.Services.AddScoped<ICommonManager, SampleApp.Domain.Business.Services.CommonManager>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAngularApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
