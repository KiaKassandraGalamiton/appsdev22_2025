namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cuisines = { "Filipino", "Chinese", "Korean", "Japanese" };
            comboBox1.Items.AddRange(cuisines);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

            checkedListBox1.CheckOnClick = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisinesList = { "Adobo", "Lumpia", "Pancit", "Sinigang" };
            string[] chineseCuisinesList = { "Wonton Soup", "Dumplings", "Dimsum", "Tofu" };
            string[] koreanCuisinesList = { "Kimchi", "Tteokbokki", "Jajangmyeon", "Samgyeopsal" };
            string[] japaneseCuisinesList = { "Ramen", "Sushi", "Udon", "Tonkatsu" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(filipinoCuisinesList);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox1.Items.AddRange(chineseCuisinesList);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox1.Items.AddRange(koreanCuisinesList);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox1.Items.AddRange(japaneseCuisinesList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count >= 1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
