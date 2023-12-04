using MentalHospital.BLL.Extensions;
using MentalHospital.API.Mapper;
using MentalHospital.API.FluentValidation;
using FluentValidation;
using MentalHospital.API.ViewModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IValidator<PatientViewModel>, PatientValidator>();
builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(MentalHospital.BLL.Mapper.MappingProfile));
builder.Services.AddControllers();
builder.Services.AddBusinessLayer(builder.Configuration);
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
