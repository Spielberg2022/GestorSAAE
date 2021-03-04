
namespace GestorSAAE.Apresentacao
{
    partial class FormCadUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label identificadorLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label situacaoLabel;
            this.usuariosGroupBox = new System.Windows.Forms.GroupBox();
            this.codigoLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.identificadorTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.autenticacaoCheckBox = new System.Windows.Forms.CheckBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.editarButton = new System.Windows.Forms.Button();
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imprimirButton = new System.Windows.Forms.Button();
            codigoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            identificadorLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            this.usuariosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosGroupBox
            // 
            this.usuariosGroupBox.Controls.Add(situacaoLabel);
            this.usuariosGroupBox.Controls.Add(this.situacaoComboBox);
            this.usuariosGroupBox.Controls.Add(codigoLabel);
            this.usuariosGroupBox.Controls.Add(this.codigoLabel1);
            this.usuariosGroupBox.Controls.Add(nomeLabel);
            this.usuariosGroupBox.Controls.Add(this.nomeTextBox);
            this.usuariosGroupBox.Controls.Add(identificadorLabel);
            this.usuariosGroupBox.Controls.Add(this.identificadorTextBox);
            this.usuariosGroupBox.Controls.Add(senhaLabel);
            this.usuariosGroupBox.Controls.Add(this.senhaTextBox);
            this.usuariosGroupBox.Controls.Add(this.autenticacaoCheckBox);
            this.usuariosGroupBox.Location = new System.Drawing.Point(143, 79);
            this.usuariosGroupBox.Name = "usuariosGroupBox";
            this.usuariosGroupBox.Size = new System.Drawing.Size(399, 206);
            this.usuariosGroupBox.TabIndex = 1;
            this.usuariosGroupBox.TabStop = false;
            this.usuariosGroupBox.Text = "Usuários";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(11, 35);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Código:";
            // 
            // codigoLabel1
            // 
            this.codigoLabel1.Location = new System.Drawing.Point(89, 35);
            this.codigoLabel1.Name = "codigoLabel1";
            this.codigoLabel1.Size = new System.Drawing.Size(104, 23);
            this.codigoLabel1.TabIndex = 1;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(11, 64);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(89, 61);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(304, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // identificadorLabel
            // 
            identificadorLabel.AutoSize = true;
            identificadorLabel.Location = new System.Drawing.Point(11, 90);
            identificadorLabel.Name = "identificadorLabel";
            identificadorLabel.Size = new System.Drawing.Size(68, 13);
            identificadorLabel.TabIndex = 4;
            identificadorLabel.Text = "Identificador:";
            // 
            // identificadorTextBox
            // 
            this.identificadorTextBox.Enabled = false;
            this.identificadorTextBox.Location = new System.Drawing.Point(89, 87);
            this.identificadorTextBox.Name = "identificadorTextBox";
            this.identificadorTextBox.Size = new System.Drawing.Size(121, 20);
            this.identificadorTextBox.TabIndex = 5;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(11, 116);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 6;
            senhaLabel.Text = "Senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Enabled = false;
            this.senhaTextBox.Location = new System.Drawing.Point(89, 113);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(121, 20);
            this.senhaTextBox.TabIndex = 7;
            // 
            // autenticacaoCheckBox
            // 
            this.autenticacaoCheckBox.Enabled = false;
            this.autenticacaoCheckBox.Location = new System.Drawing.Point(89, 166);
            this.autenticacaoCheckBox.Name = "autenticacaoCheckBox";
            this.autenticacaoCheckBox.Size = new System.Drawing.Size(180, 24);
            this.autenticacaoCheckBox.TabIndex = 10;
            this.autenticacaoCheckBox.Text = "Exige autenticação de 2 fatores";
            this.autenticacaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginLabel.Location = new System.Drawing.Point(254, 25);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(139, 33);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Usuários";
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(548, 162);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(64, 23);
            this.editarButton.TabIndex = 3;
            this.editarButton.Text = "&Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Location = new System.Drawing.Point(11, 142);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(52, 13);
            situacaoLabel.TabIndex = 8;
            situacaoLabel.Text = "Situação:";
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.situacaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.situacaoComboBox.Enabled = false;
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Items.AddRange(new object[] {
            "Ativo",
            "Cancelado"});
            this.situacaoComboBox.Location = new System.Drawing.Point(89, 139);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(121, 21);
            this.situacaoComboBox.TabIndex = 9;
            // 
            // salvarButton
            // 
            this.salvarButton.Image = global::GestorSAAE.Properties.Resources.salvar_arquivo__2_;
            this.salvarButton.Location = new System.Drawing.Point(548, 191);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(64, 64);
            this.salvarButton.TabIndex = 4;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salvarButton.UseVisualStyleBackColor = true;
            // 
            // localizarButton
            // 
            this.localizarButton.Image = global::GestorSAAE.Properties.Resources.encontrar__2_;
            this.localizarButton.Location = new System.Drawing.Point(548, 92);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(64, 64);
            this.localizarButton.TabIndex = 2;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestorSAAE.Properties.Resources.Cadastro;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 341);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imprimirButton
            // 
            this.imprimirButton.Location = new System.Drawing.Point(548, 262);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(64, 23);
            this.imprimirButton.TabIndex = 5;
            this.imprimirButton.Text = "&Imprimir";
            this.imprimirButton.UseVisualStyleBackColor = true;
            // 
            // FormCadUsuario
            // 
            this.AcceptButton = this.localizarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.usuariosGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FormCadUsuario_Load);
            this.usuariosGroupBox.ResumeLayout(false);
            this.usuariosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox usuariosGroupBox;
        private System.Windows.Forms.Label codigoLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox identificadorTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox autenticacaoCheckBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private System.Windows.Forms.Button imprimirButton;
    }
}