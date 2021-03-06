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
            if(codigoLabel1.Text != "")
            {
                nomeTextBox.Enabled = true;
                identificadorTextBox.Enabled = true;
                senhaTextBox.Enabled = true;
                situacaoComboBox.Enabled = true;
                autenticacaoCheckBox.Enabled = true;
            }
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {

        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            //Deixar essa opção para o final, depois de confirmado o salvamento
            nomeTextBox.Enabled = false;
            identificadorTextBox.Enabled = false;
            senhaTextBox.Enabled = false;
            situacaoComboBox.Enabled = false;
            autenticacaoCheckBox.Enabled = false;
            codigoLabel1.Text = "";
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            FormLocalizar formLocalizar = new FormLocalizar();
            formLocalizar.ShowDialog();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            codigoLabel1.Text = "NOVO CÓDIGO";
            nomeTextBox.Clear();
            identificadorTextBox.Clear();
            senhaTextBox.Clear();
            situacaoComboBox.Text = "";
            autenticacaoCheckBox.Checked = false;
            nomeTextBox.Enabled = true;
            identificadorTextBox.Enabled = true;
            senhaTextBox.Enabled = true;
            situacaoComboBox.Enabled = true;
            autenticacaoCheckBox.Enabled = true;
            nomeTextBox.Focus();
        }

        private void imprimirButton_Click_1(object sender, EventArgs e)
        {
            FormImp formImp = new FormImp();
            formImp.ShowDialog();
        }
    }
}
