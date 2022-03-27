using OOP8.Model;

namespace OOP8
{
    public partial class Form1 : Form
    {
        private Graphics _graphics;
        private ComboBox[] _comboBoxes;
        private Drawer _drawer;
        private RadioButton[] _radioButtons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _graphics = Canvas.CreateGraphics();
            _comboBoxes = new ComboBox[] { lineColor, backColor, fillColor };

            var colorFiller = new ColorFiller(_comboBoxes);

            colorFiller.Work();

            _radioButtons = new RadioButton[]
            {
                radioButton1,
                radioButton2,
                radioButton3,
            };

            _drawer = new Drawer(_graphics);


        }

        private void backColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            var color = (Color) box.SelectedItem;
            Canvas.BackColor = color;
        }

        private void lineColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            _drawer.SetPenColor(box.SelectedItem);
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            _drawer.CreateNewPoint(e.Location);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFigureType(sender);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFigureType(sender);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFigureType(sender);
        }

        private void UpdateFigureType(object sender)
        {
            var radio = (RadioButton)sender;

            var index = Array.IndexOf(_radioButtons, radio);
            _drawer.SetFigure(index);
        }

        private void fillColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;

            _drawer.SetBrush(box.SelectedItem);
        }
    }
}