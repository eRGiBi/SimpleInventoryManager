using SIM.Model;
using SIM.Parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIM.View
{
    internal partial class LoadForm : Form
    {
        private ItemStorage storage;
        public LoadForm (ItemStorage storage)
        {
            InitializeComponent();
            this.storage = storage;
        }

        private void NamesButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                NamesTextBox.Text = openFileDialog.FileName;
            }        
        }

        private void CountsButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CountsTextBox.Text = openFileDialog.FileName;
            }               
        }

        private void PricesButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PricesTextBox.Text = openFileDialog.FileName;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            storage.AddRange(Loader.Load<Item>(NamesTextBox.Text, new ItemNameParser()));

            storage.AddRange(Loader.Load<Item>(CountsTextBox.Text, new ItemPiecesParser()));

            storage.AddRange(Loader.Load<Item>(PricesTextBox.Text, new ItemPricesParser()));
           
            Close();
        }
    }
}
