namespace OOP8.Model
{
    internal class ColorFiller
    {
        private Color[] _colors;
        private ComboBox[] _comboBoxes;

        public ColorFiller(params ComboBox[] checkBoxes)
        {
            _comboBoxes = checkBoxes;
            _colors = new Color[]
            {
                Color.White,
                Color.Black,
                Color.Blue,
                Color.Green,
                Color.Orange,
                Color.Pink
            };
        }

        public void Work()
        {
            foreach (var comboBox in _comboBoxes)
            {
                comboBox.Items.AddRange(_colors.Select(color => (object)color).ToArray());
            }
        }
    }
}
