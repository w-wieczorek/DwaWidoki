using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DwaWidoki.ViewModels;

namespace DwaWidoki.Views;

public partial class Widok1 : UserControl
{
    public Widok1(MainWindowViewModel mainViewModel)
    {
        InitializeComponent();
        DataContext = mainViewModel;
    }
}