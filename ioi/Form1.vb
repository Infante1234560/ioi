Using System.Text;
Using System.Windows;
Using System.Windows.Controls;
Using System.Windows.Data;
Using System.Windows.Documents;
Using System.Windows.Input;
Using System.Windows.Media;
Using System.Windows.Media.Imaging;
Using System.Windows.Navigation;
Using System.Windows.Shapes;
Using System.Windows.Threading;

Namespace SamGanda_Pacman_Sample_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    Partial Public Class MainWindow :  Window
    {

        DispatcherTimer gameTimer = New DispatcherTimer();

        bool goLeft, goRight, goDown, goUp;
        bool noLeft, noRight, noDown, noUp;

        int speed = 8;

        Rect pacmanHitBox;

        int ghostSpeed = 10;
        int ghostMoveStep = 130;
        int currentGhostStep;
        int score = 0;

        Public MainWindow()
        {
            InitializeComponent();

            GameSetUp();
        }

        Private void CanvasKeyDown(Object sender, KeyEventArgs e)
        {

        }

        Private void GameSetUp()
        {

            MyCanvas.Focus();

            gameTimer.Tick += GameLoop;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Start();
            currentGhostStep = ghostMoveStep;

            ImageBrush pacmanImage = New ImageBrush();
            pacmanImage.ImageSource = New BitmapImage(New Uri("pack://application:,,,/images/pacman.jpg"));
            pacman.Fill = pacmanImage;

            ImageBrush redGhost = New ImageBrush();
            redGhost.ImageSource = New BitmapImage(New Uri("pack://application:,,,/images/red.jpg"));
            pacman.Fill = redGhost;

            ImageBrush orangeGhost = New ImageBrush();
            orangeGhost.ImageSource = New BitmapImage(New Uri("pack://application:,,,/images/orange.jpg"));
            pacman.Fill = orangeGhost;

            ImageBrush pinkGhost = New ImageBrush();
            pinkGhost.ImageSource = New BitmapImage(New Uri("pack://application:,,,/images/pink.jpg"));
            pacman.Fill = pinkGhost;

            ImageBrush blueGhost = New ImageBrush();
            blueGhost.ImageSource = New BitmapImage(New Uri("pack://application:,,,/images/blue.png"));
            pacman.Fill = blueGhost;
        }

        Private void GameLoop(Object? sender, EventArgs e)
        {

        }

        Private void GameOver()
        {

        }

    }
}