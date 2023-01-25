using SIM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIM.View
{
    internal partial class NewForm : Form
    {
        ItemStorage items;
        Item selectedItem;
        public NewForm(ItemStorage items)
        {
            InitializeComponent();
            this.items = items;
        }
        public NewForm(ItemStorage items, object selectedItem)
        {
            InitializeComponent();
            this.items = items;
            this.selectedItem = selectedItem as Item;
        }
        private void NewForm_Load(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                IdTextBox.Text = selectedItem.Id;
                NameTextBox.Text = selectedItem.Name;
                CountTextBox.Text = selectedItem.Count.ToString();
                PriceTextBox.Text = selectedItem.Price.ToString();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckValidity())
            {
                if (selectedItem == null)
                {
                    AddItem();
                    Close();
                }
                else
                {
                    foreach (Item item in items)
                    {
                        if (item.Id == selectedItem.Id)
                        {
                            items.Remove(item);
                            break;
                        }
                    }
                    AddItem();
                    Close();
                }
            }
        } 
        private void AddItem()
        {           
            {               
                items.Add(          
                    new Item(             
                        IdTextBox.Text,
                        NameTextBox.Text,
                        int.Parse(CountTextBox.Text),
                        double.Parse(PriceTextBox.Text)));              
            }
            
        }
        private bool CheckValidity()
        {
            bool validity = true;
            try
            {               
                if (string.IsNullOrEmpty(IdTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) 
                    || string.IsNullOrEmpty(CountTextBox.Text) || string.IsNullOrEmpty(PriceTextBox.Text))
                {
                    validity = false;
                    throw new FormatException();   
                    
                }                    
            }     
            
            catch (FormatException ex)
            {               
                MessageBox.Show(ex.Message, "Not in correct format!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            return validity;
        }
    }
}
