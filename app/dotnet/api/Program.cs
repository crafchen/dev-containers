using api.Configurations;
using api.Helpers.Utilities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// AutoMapper Settings
builder.Services.AddAutoMapperConfiguration();

// Setting DBContexts
// builder.Services.AddDatabaseConfiguration(builder.Configuration);

// Add Authentication
builder.Services.AddAuthenticationConfiguration(builder.Configuration);

// RepositoryAccessor and Service
builder.Services.AddDependencyInjectionConfiguration();

// Swagger Config
builder.Services.AddSwaggerGenConfiguration();

// builder.Services.AddSignalR();

// Aspose Config
// AsposeUtility.Install();

//Exception Handling Middleware Error
builder.Services.AddTransient<ExceptionHandlingMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
});
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseHttpsRedirection();
app.UseRouting();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();