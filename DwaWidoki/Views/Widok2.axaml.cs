using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DwaWidoki.ViewModels;

namespace DwaWidoki.Views;

public partial class Widok2 : UserControl
{
    public Widok2(MainWindowViewModel mainViewModel)
    {
        InitializeComponent();
        DataContext = mainViewModel;
    }
}