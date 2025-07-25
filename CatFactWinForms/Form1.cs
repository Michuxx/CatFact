using CatFactWinForms.Interfaces;

namespace CatFactWinForms
{
    public partial class Form1 : Form
    {
        private readonly ICatFactService _catFactService;
        private readonly IFileWriter _fileWriter;
        public Form1(ICatFactService catFactService, IFileWriter fileWriter)
        {
            InitializeComponent();
            _catFactService = catFactService ?? throw new ArgumentNullException(nameof(catFactService));
            _fileWriter = fileWriter ?? throw new ArgumentNullException(nameof(fileWriter));
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var catFact = await _catFactService.GetCatFactAsync(); 
                if (catFact != null)
                {
                    txtFactDisplay.Text = catFact.Fact;
                    _fileWriter.AppendLine(catFact.Fact);
                }
                else
                {
                    MessageBox.Show("Nie uda³o siê pobraæ faktu o kocie.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst¹pi³ b³¹d: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
