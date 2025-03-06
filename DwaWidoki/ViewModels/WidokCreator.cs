using DwaWidoki.Views;

namespace DwaWidoki.ViewModels;

public class WidokCreator
{
    public Widok1 CreateWidok1(MainWindowViewModel viewModel)
    {
        return new Widok1(viewModel);
    }

    public Widok2 CreateWidok2(MainWindowViewModel viewModel)
    {
        return new Widok2(viewModel);
    }
}