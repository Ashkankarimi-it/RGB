namespace RGB
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb
                (redHScrollbar.Value, greenHScrolbar.Value, blueHScrollbar.Value);
        }
        private void HScrollbar_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            BackColor = System.Drawing.Color.FromArgb
                (redHScrollbar.Value, greenHScrolbar.Value, blueHScrollbar.Value);
        }


    }
}
