namespace Agenda.API.Extensions
{
  public static class BuilderExtensions
  {
    public static IApplicationBuilder UseCustomBuilder(this IApplicationBuilder app, string corsPolicy)
    {
      app.UseCors(corsPolicy);
      app.UseRouting();
      app.UseAuthentication();
      app.UseAuthorization();
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
      app.UseSwagger();
      app.UseSwaggerUI();
      return app;
    }
  }
}