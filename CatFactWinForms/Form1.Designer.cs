namespace CatFactWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFetch = new Button();
            txtFactDisplay = new TextBox();
            lblStatus = new Label();
            label1 = new Label();
            folderBrowserDialog = new FolderBrowserDialog();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnFetch
            // 
            btnFetch.Location = new Point(327, 26);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(128, 46);
            btnFetch.TabIndex = 0;
            btnFetch.Text = "Pobierz Fakt o kocie";
            btnFetch.UseVisualStyleBackColor = true;
            btnFetch.Click += button1_Click;
            // 
            // txtFactDisplay
            // 
            txtFactDisplay.Location = new Point(127, 191);
            txtFactDisplay.Multiline = true;
            txtFactDisplay.Name = "txtFactDisplay";
            txtFactDisplay.ReadOnly = true;
            txtFactDisplay.ScrollBars = ScrollBars.Vertical;
            txtFactDisplay.Size = new Size(532, 129);
            txtFactDisplay.TabIndex = 1;
            txtFactDisplay.TextAlign = HorizontalAlignment.Center;
            txtFactDisplay.TextChanged += textBox1_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(299, 156);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 339);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            folderBrowserDialog.HelpRequest += folderBrowserDialog_HelpRequest;
            // 
            // button1
            // 
            button1.Location = new Point(299, 130);
            button1.Name = "button1";
            button1.Size = new Size(185, 23);
            button1.TabIndex = 4;
            button1.Text = "Wybierz Folder zapisu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ChooseFolder;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 112);
            label2.Name = "label2";
            label2.Size = new Size(375, 15);
            label2.TabIndex = 5;
            label2.Text = "Nie wybrano folderu. Domyślnie wybrany pozostanie `My Documents`";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(txtFactDisplay);
            Controls.Add(btnFetch);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetch;
        private TextBox txtFactDisplay;
        private Label lblStatus;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog;
        private Button button1;
        private Label label2;
    }
}
