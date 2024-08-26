using ChartsTest.ViewModels;

namespace ChartsTest.Pages;

public partial class MainPage : ContentPage
{
  public MainPage(MainVM vm)
  {
    InitializeComponent();

    BindingContext = vm;
  }
}
