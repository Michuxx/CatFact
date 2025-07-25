using CatFactWinForms.Interfaces;
using CatFactWinForms.Services;

namespace CatFactWinForms
{
    public partial class Form1 : Form
    {
        private readonly ICatFactService _catFactService;
        private readonly FileWriter _fileWriter;
        public Form1(ICatFactService catFactService, FileWriter fileWriter)
        {
            InitializeComponent();
            _catFactService = catFactService ?? throw new ArgumentNullException(nameof(catFactService));
            _fileWriter = fileWriter ?? throw new ArgumentNullException(nameof(fileWriter));
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Pobieranie faktu o kocie...";

            try
            {
                var catFact = await _catFactService.GetCatFactAsync();
                if (catFact != null)
                {
                    txtFactDisplay.Text += catFact.Fact + Environment.NewLine;
                    lblTextLength.Text = $"D³ugoœæ tekstu to: {catFact.Length}";
                    string path = _fileWriter.getValidatedPath(folderBrowserDialog.SelectedPath);
                    _fileWriter.AppendLine(catFact.Fact, path);
                    lblStatus.Text = String.Empty;
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

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ChooseFolder(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (!string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                label2.Text = $"Wybrany folder: {folderBrowserDialog.SelectedPath}";
            }
            else
            {
                label2.Text = "Nie wybrano folderu. Zostanie domyœlnie wybrany folder lokalny";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTextLength_Click(object sender, EventArgs e)
        {

        }
    }
}
