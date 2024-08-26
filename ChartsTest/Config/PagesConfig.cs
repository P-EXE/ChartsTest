using ChartsTest.Pages;

namespace ChartsTest.Config;

internal static class PagesConfig
{
  internal static Task ConfigurePages(this IServiceCollection services)
  {
    services.AddTransient<MainPage>();

    return Task.CompletedTask;
  }
}
