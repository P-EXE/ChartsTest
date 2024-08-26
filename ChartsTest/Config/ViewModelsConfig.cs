using ChartsTest.ViewModels;

namespace ChartsTest.Config;

internal static class ViewModelsConfig
{
  internal static Task ConfigureViewModels(this IServiceCollection services)
  {
    services.AddTransient<MainVM>();

    return Task.CompletedTask;
  }
}
