using System;
using System.Windows;

namespace Win32ListViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set up ListView columns
            listViewItems.Columns.Add("Items", -2, HorizontalAlignment.Left);
            listViewItems.FullRowSelect = true;
            listViewItems.GridLines = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNewItem.Text))
            {
                ListViewItem item = new ListViewItem(textBoxNewItem.Text);
                listViewItems.Items.Add(item);
                textBoxNewItem.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an item.");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count > 0)
            {
                listViewItems.Items.Remove(listViewItems.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }
    }
}
