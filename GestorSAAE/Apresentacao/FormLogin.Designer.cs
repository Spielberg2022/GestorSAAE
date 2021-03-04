
namespace GestorSAAE.Apresentacao
{
    partial class FormLogin
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
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.senhaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.identificadorTextBox = new System.Windows.Forms.TextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.identificadorLabel = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.entrarButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.autenticarCheckBox = new System.Windows.Forms.CheckBox();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.autenticarCheckBox);
            this.loginGroupBox.Controls.Add(this.senhaMaskedTextBox);
            this.loginGroupBox.Controls.Add(this.identificadorTextBox);
            this.loginGroupBox.Controls.Add(this.senhaLabel);
            this.loginGroupBox.Controls.Add(this.identificadorLabel);
            this.loginGroupBox.Controls.Add(this.cancelarButton);
            this.loginGroupBox.Controls.Add(this.limparButton);
            this.loginGroupBox.Controls.Add(this.entrarButton);
            this.loginGroupBox.Controls.Add(this.loginLabel);
            this.loginGroupBox.Location = new System.Drawing.Point(12, 12);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(396, 256);
            this.loginGroupBox.TabIndex = 0;
            this.loginGroupBox.TabStop = false;
            // 
            // senhaMaskedTextBox
            // 
            this.senhaMaskedTextBox.Location = new System.Drawing.Point(131, 132);
            this.senhaMaskedTextBox.Name = "senhaMaskedTextBox";
            this.senhaMaskedTextBox.Size = new System.Drawing.Size(181, 20);
            this.senhaMaskedTextBox.TabIndex = 3;
            this.senhaMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // identificadorTextBox
            // 
            this.identificadorTextBox.Location = new System.Drawing.Point(131, 106);
            this.identificadorTextBox.Name = "identificadorTextBox";
            this.identificadorTextBox.Size = new System.Drawing.Size(181, 20);
            this.identificadorTextBox.TabIndex = 1;
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(84, 135);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(41, 13);
            this.senhaLabel.TabIndex = 2;
            this.senhaLabel.Text = "Senha:";
            // 
            // identificadorLabel
            // 
            this.identificadorLabel.AutoSize = true;
            this.identificadorLabel.Location = new System.Drawing.Point(57, 109);
            this.identificadorLabel.Name = "identificadorLabel";
            this.identificadorLabel.Size = new System.Drawing.Size(68, 13);
            this.identificadorLabel.TabIndex = 4;
            this.identificadorLabel.Text = "Identificador:";
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(237, 189);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(156, 189);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 6;
            this.limparButton.Text = "&Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            // 
            // entrarButton
            // 
            this.entrarButton.Location = new System.Drawing.Point(75, 189);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(75, 23);
            this.entrarButton.TabIndex = 5;
            this.entrarButton.Text = "&Entrar";
            this.entrarButton.UseVisualStyleBackColor = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginLabel.Location = new System.Drawing.Point(150, 44);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(91, 33);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // autenticarCheckBox
            // 
            this.autenticarCheckBox.AutoSize = true;
            this.autenticarCheckBox.Location = new System.Drawing.Point(238, 158);
            this.autenticarCheckBox.Name = "autenticarCheckBox";
            this.autenticarCheckBox.Size = new System.Drawing.Size(74, 17);
            this.autenticarCheckBox.TabIndex = 4;
            this.autenticarCheckBox.Text = "Autenticar";
            this.autenticarCheckBox.UseVisualStyleBackColor = true;
            this.autenticarCheckBox.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.loginGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.MaskedTextBox senhaMaskedTextBox;
        private System.Windows.Forms.TextBox identificadorTextBox;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label identificadorLabel;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.CheckBox autenticarCheckBox;
    }
}