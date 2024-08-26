using CommunityToolkit.Mvvm.ComponentModel;
using Microcharts;
using System.Collections.ObjectModel;

namespace ChartsTest.ViewModels;

public partial class MainVM : ObservableObject
{
  private const int CornerRadius = 1000;
  private static readonly SkiaSharp.SKColor bgColor = SkiaSharp.SKColor.Parse("#00000000");
  private static readonly SkiaSharp.SKColor posColor = SkiaSharp.SKColor.Parse("#00FF00");
  private static readonly SkiaSharp.SKColor negColor = SkiaSharp.SKColor.Parse("#FF0000");
  public MainVM()
  {
    Positive.CornerRadius = CornerRadius;
    Positive.BackgroundColor = bgColor;
    Positive.ValueLabelOption = ValueLabelOption.None;

    Negative.CornerRadius = CornerRadius;
    Negative.BackgroundColor = bgColor;
    Negative.ValueLabelOption = ValueLabelOption.None;
  }

  [ObservableProperty]
  private BarChart _positive = new() { Entries = _posEntries };
  [ObservableProperty]
  private BarChart _negative = new() { Entries = _negEntries };

  private static readonly ObservableCollection<ChartEntry> _posEntries = [
    new(0.1f){Color = posColor},
    new(0.2f){Color = posColor},
    new(0.3f){Color = posColor},
    new(0.4f){Color = posColor},
    new(0.5f){Color = posColor},
    new(0.6f){Color = posColor},
    new(0.7f){Color = posColor}
    ];

  private static readonly ObservableCollection<ChartEntry> _negEntries = [
    new(0.1f){Color = negColor},
    new(0.2f){Color = negColor},
    new(0.3f){Color = negColor},
    new(0.4f){Color = negColor},
    new(0.5f){Color = negColor},
    new(0.6f){Color = negColor},
    new(0.7f){Color = negColor}
  ];
}
