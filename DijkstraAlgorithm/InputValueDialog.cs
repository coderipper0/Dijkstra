using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraAlgorithm
{
    public partial class InputValueDialog : Form
    {
        public InputValueDialog()
        {
            InitializeComponent();
        }

        public DialogResult Show(string title, string description, int defaultResponse)
        {
            Text = title;
            DescriptionLabel.Text = description;
            DefaultLabel.Text = "El valor por defecto es: " + defaultResponse;
            return (ShowDialog());
        }

        public int InputBox(string title, string description, int defaultResponse)
        {
            Text = title;
            DescriptionLabel.Text = description;
            DefaultLabel.Text = "El valor por defecto es: " + defaultResponse;


            DialogResult resultCode = ShowDialog();
            if (resultCode == DialogResult.OK) {
                string input = ValueTextBox.Text.Trim();
                return (!String.IsNullOrEmpty(input)) ? int.Parse(input) : defaultResponse;
            }

            return defaultResponse;
        }

        private void RelationValueChange(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
