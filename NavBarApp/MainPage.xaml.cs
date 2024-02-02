namespace NavBarApp;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    public void NavBtn_Click(object sender, object args)
    {
        Frame.Navigate(typeof(SecondPage));
    }
}
