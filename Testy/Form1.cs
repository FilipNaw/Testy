namespace Testy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonClicked(object sender, EventArgs e)
        {
            //Application.Exit();

            int windowWidth = Size.Width;
            int windowHeight = Size.Height;

            windowWidth -= AAA.Width;
            windowHeight -= AAA.Height;

            Random rnd = new Random();

            int randomLeft = rnd.Next(windowWidth);
            int randomTop = rnd.Next(windowHeight);

            Point topLeftCorner = new Point(randomLeft, randomTop);
            AAA.Location = topLeftCorner;   
        }
    }
}