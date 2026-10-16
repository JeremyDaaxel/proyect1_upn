namespace proyecto1;

public partial class SplashScreen : Form
{
    public SplashScreen()
    {
        InitializeComponent();
        timer1.Start();
    }

    //timer de windows tools pa q aparezca el screen
    //se activa con el evento timer (3 segundos)
    private void timer1_Tick(object sender, EventArgs e)
    {
        timer1.Stop();
        this.Close();
    }
}