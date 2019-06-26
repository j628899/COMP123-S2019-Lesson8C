using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123__S2019_Lesson8C
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the constructor for the Lab 8 Form
        /// </summary>
        public Lab08Form()
        {
            InitializeComponent();
        }

        private void Sumitbutten_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            UserAge = float.Parse(agetextBox.Text);
            Output_label.Text = NameTextBox.Text + " " + agetextBox.Text;
            NameTextBox.Text = string.Empty;
            agetextBox.Text = string.Empty;
            

        }

        private void Lab8form_Load(object sender, EventArgs e)
        {
            Sumitbutten.Enabled = false;
        }

        private void agetextBox_TextChanged(object sender, EventArgs e)
        {
            Sumitbutten.Enabled = true;
        }
    }
}
