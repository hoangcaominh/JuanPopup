using System;
using System.Windows.Forms;
using JsonData;

namespace Modify
{
    public partial class Form1 : Form
    {
        int mode = 0;

        public Form1()
        {
            InitializeComponent();
        }

        readonly DataClass data = new DataClass();

        private void Form1_Load(object sender, EventArgs e)
        {
            DataList.DataSource = data.Printable();
            ModeLabel.Text = "Mode: Add";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            mode = 0;
            ModeLabel.Text = "Mode: Add";
            AuthorText.Text = HeaderText.Text = ContentText.Text = "";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            mode = 1;
            ModeLabel.Text = "Mode: Edit";
            (AuthorText.Text, HeaderText.Text, ContentText.Text) = data.Load(DataList.SelectedIndex);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this quote?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteObject(DataList.SelectedIndex);
                DataList.DataSource = data.Printable();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                // Add
                case 0:
                    data.AddObject(AuthorText.Text, HeaderText.Text, ContentText.Text);
                    break;
                // Edit
                case 1:
                    data.EditObject(DataList.SelectedIndex, AuthorText.Text, HeaderText.Text, ContentText.Text);
                    break;
                default:
                    break;
            }
            DataList.DataSource = data.Printable();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            data.SaveData();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (data.HasChanges())
            {
                DialogResult result = MessageBox.Show("Do you want to save your changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    data.SaveData();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
