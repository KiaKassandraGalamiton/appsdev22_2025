namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] characters = { "Gumball", "Darwin", "Anais", "Larry" };
            comboBox1.Items.AddRange(characters);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            switch (selectedCharacter)
            {
                case "Gumball":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\OO122\\Desktop\\CC\\Gumball.jpg");
                    break;
                case "Darwin":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\OO122\\Desktop\\CC\\Darwin.jpg");
                    break;
                case "Anais":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\OO122\\Desktop\\CC\\Anais.jpg");
                    break;
                case "Larry":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\OO122\\Desktop\\CC\\Larry.jpg");
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}
