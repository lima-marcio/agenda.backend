using Agenda.API.Extensions;
using Agenda.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);
var secretKey = builder.Configuration["SecretKey"];

builder.Services.AddCustomAuthentication(secretKey ?? throw new InvalidOperationException("JWT Secret Key not found!"));
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerDocumentation();
// builder.Services.AddCustomServices();
builder.Services.AddInfrastructure(builder.Configuration);

var corsPolicy = "_myCorsPolicy";

builder.Services.AddCustomCors(corsPolicy);
builder.Services.AddValidation();

var app = builder.Build();
app.UseCustomBuilder(corsPolicy);
app.Run();