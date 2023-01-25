
namespace SIM.View
{
    partial class LoadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NamesTextBox = new System.Windows.Forms.TextBox();
            this.CountsTextBox = new System.Windows.Forms.TextBox();
            this.PricesTextBox = new System.Windows.Forms.TextBox();
            this.NamesButton = new System.Windows.Forms.Button();
            this.CountsButton = new System.Windows.Forms.Button();
            this.PricesButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Counts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prices";
            // 
            // NamesTextBox
            // 
            this.NamesTextBox.Location = new System.Drawing.Point(110, 33);
            this.NamesTextBox.Name = "NamesTextBox";
            this.NamesTextBox.Size = new System.Drawing.Size(441, 23);
            this.NamesTextBox.TabIndex = 3;
            this.NamesTextBox.Text = "item_names.csv";
            // 
            // CountsTextBox
            // 
            this.CountsTextBox.Location = new System.Drawing.Point(110, 82);
            this.CountsTextBox.Name = "CountsTextBox";
            this.CountsTextBox.Size = new System.Drawing.Size(441, 23);
            this.CountsTextBox.TabIndex = 4;
            this.CountsTextBox.Text = "item_pieces.csv";
            // 
            // PricesTextBox
            // 
            this.PricesTextBox.Location = new System.Drawing.Point(110, 133);
            this.PricesTextBox.Name = "PricesTextBox";
            this.PricesTextBox.Size = new System.Drawing.Size(441, 23);
            this.PricesTextBox.TabIndex = 5;
            this.PricesTextBox.Text = "item_prices.csv";
            // 
            // NamesButton
            // 
            this.NamesButton.Location = new System.Drawing.Point(571, 33);
            this.NamesButton.Name = "NamesButton";
            this.NamesButton.Size = new System.Drawing.Size(31, 23);
            this.NamesButton.TabIndex = 6;
            this.NamesButton.Text = "...";
            this.NamesButton.UseVisualStyleBackColor = true;
            this.NamesButton.Click += new System.EventHandler(this.NamesButton_Click);
            // 
            // CountsButton
            // 
            this.CountsButton.Location = new System.Drawing.Point(571, 81);
            this.CountsButton.Name = "CountsButton";
            this.CountsButton.Size = new System.Drawing.Size(31, 23);
            this.CountsButton.TabIndex = 7;
            this.CountsButton.Text = "...";
            this.CountsButton.UseVisualStyleBackColor = true;
            this.CountsButton.Click += new System.EventHandler(this.CountsButton_Click);
            // 
            // PricesButton
            // 
            this.PricesButton.Location = new System.Drawing.Point(571, 136);
            this.PricesButton.Name = "PricesButton";
            this.PricesButton.Size = new System.Drawing.Size(31, 23);
            this.PricesButton.TabIndex = 8;
            this.PricesButton.Text = "...";
            this.PricesButton.UseVisualStyleBackColor = true;
            this.PricesButton.Click += new System.EventHandler(this.PricesButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(287, 178);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 9;
            this.LoadButton.Text = "Load data";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Title = "Select file";
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 213);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.PricesButton);
            this.Controls.Add(this.CountsButton);
            this.Controls.Add(this.NamesButton);
            this.Controls.Add(this.PricesTextBox);
            this.Controls.Add(this.CountsTextBox);
            this.Controls.Add(this.NamesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoadForm";
            this.Text = "Load Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NamesTextBox;
        private System.Windows.Forms.TextBox CountsTextBox;
        private System.Windows.Forms.TextBox PricesTextBox;
        private System.Windows.Forms.Button NamesButton;
        private System.Windows.Forms.Button CountsButton;
        private System.Windows.Forms.Button PricesButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}