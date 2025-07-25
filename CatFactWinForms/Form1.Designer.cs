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
            SuspendLayout();
            // 
            // btnFetch
            // 
            btnFetch.Location = new Point(326, 71);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(128, 46);
            btnFetch.TabIndex = 0;
            btnFetch.Text = "Pobierz Fakt o kocie";
            btnFetch.UseVisualStyleBackColor = true;
            btnFetch.Click += button1_Click;
            // 
            // txtFactDisplay
            // 
            txtFactDisplay.Location = new Point(125, 155);
            txtFactDisplay.Multiline = true;
            txtFactDisplay.Name = "txtFactDisplay";
            txtFactDisplay.ReadOnly = true;
            txtFactDisplay.Size = new Size(532, 129);
            txtFactDisplay.TabIndex = 1;
            txtFactDisplay.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFactDisplay);
            Controls.Add(btnFetch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetch;
        private TextBox txtFactDisplay;
    }
}
