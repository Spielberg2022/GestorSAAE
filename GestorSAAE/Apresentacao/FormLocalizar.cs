using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestorSAAE.Apresentacao
{
    public partial class FormLocalizar : Form
    {
        public FormLocalizar()
        {
            InitializeComponent();
        }

        private void codigoTextBox_Leave(object sender, EventArgs e)
        {
            if (codigoTextBox.Text != null || codigoTextBox.Text != "")
                localizarButton_Click(sender, e);
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
