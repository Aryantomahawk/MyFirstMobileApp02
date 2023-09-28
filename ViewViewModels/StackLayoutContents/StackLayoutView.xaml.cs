namespace MyFirstMobileApp.ViewViewModels.StackLayoutContents;

public partial class StackLayoutView : ContentPage
{
    public StackLayoutView()
    {
        InitializeComponent();

        //creating a binding context so that my xaml file works
        BindingContext = new StackLayoutViewModel();

    }
}