namespace NavBarApp;

public sealed partial class MainPage : Page
{
    public int NotificationCount { get; set; } = 0;
    public int ShareCount { get; set; } = 0;
    public MainPage()
    {
        this.InitializeComponent();
        
        NotifCountRun.Text = NotificationCount.ToString();
        ShareCountRun.Text = ShareCount.ToString();
    }

    public void NavBtn_Click(object sender, object args)
    {
        Frame.Navigate(typeof(SecondPage));
    }

    public void Notification_Click(object sender, object args)
    {
        NotifCountRun.Text = (++NotificationCount).ToString();
    }

    public void Share_Click(object sender, object args)
    {
         ShareCountRun.Text = (++ShareCount).ToString();
    }
}
