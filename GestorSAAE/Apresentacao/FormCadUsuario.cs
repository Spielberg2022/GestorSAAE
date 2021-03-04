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
    public partial class FormCadUsuario : Form
    {
        public FormCadUsuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.usuarioBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.gestorWslyDataSet);

        }

        private void FormCadUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestorWslyDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            //this.usuarioTableAdapter.Fill(this.gestorWslyDataSet.Usuario);
            // TODO: esta linha de código carrega dados na tabela 'gestorWslyDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            //this.usuarioTableAdapter.Fill(this.gestorWslyDataSet.Usuario);

        }

        private void usuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            //this.usuarioBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.gestorWslyDataSet);

        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            identificadorTextBox.Enabled = true;
            senhaTextBox.Enabled = true;
            situacaoComboBox.Enabled = true;
            autenticacaoCheckBox.Enabled = true;
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {

        }
    }
}
