namespace NavBarApp;

public sealed partial class SecondPage : Page
{
    private int _rotation = 0;
    public SecondPage()
    {
        this.InitializeComponent();
    }

    public void Notification_Click(object sender, object args)
    {
        Rotate(-15);
    }

    public void Share_Click(object sender, object args)
    {
         Rotate(15);
    }

    private void Rotate(int step)
    {
        _rotation = (_rotation + step) % 360;

        myRotate.Angle = _rotation;
    }
}

