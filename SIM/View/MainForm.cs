using SIM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIM.View
{
    public partial class MainForm : Form
    {
        private ItemStorage storage = new ItemStorage();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EditItemButton.Enabled = false;
            editItemToolStripMenuItem.Enabled = false;
            EditItemButton.Click += editItemToolStripMenuItem_Click;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storage.Clear();
            LoadForm loadForm = new LoadForm(storage);            
            loadForm.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                
            loadForm.Show();      
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm newform = new NewForm(storage);
            newform.FormClosed += new FormClosedEventHandler(ChildFormClosed);

            newform.Show();                      
        }      

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null) 
            {
                EditSelectedItem();
            }
            else
            {
                MessageBox.Show("Select an item!", "Selection missed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void EditItemButton_Click(object sender, EventArgs e)
        {
            //EditSelectedItem();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Inventory Manager\nby me", "About...", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClosing -= MainForm_FormClosing;
            Close();
        }
    
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "Confirm", MessageBoxButtons.YesNo)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshPage();
        }
 
        private void RefreshPage()
        {
            listBox.Items.Clear();
            
            foreach (Item item in storage)
            {
                listBox.Items.Add(item);
            }
            /*
            listBox.DataSource = storage.ToList();
            listBox.Update();*/
            
            if (storage.Count > 0)
            {
                EditItemButton.Enabled = true;
                editItemToolStripMenuItem.Enabled = true;
            }
            else 
            {
                EditItemButton.Enabled = false;
                editItemToolStripMenuItem.Enabled = false;
            }
        }
        private void EditSelectedItem()
        {
            NewForm newform = new NewForm(storage, listBox.SelectedItem);
            newform.FormClosed += new FormClosedEventHandler(ChildFormClosed);

            newform.Show();
        }

    }
}
