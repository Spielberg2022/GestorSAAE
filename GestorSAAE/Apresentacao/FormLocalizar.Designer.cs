
namespace GestorSAAE.Apresentacao
{
    partial class FormLocalizar
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
            this.localizarTabControl = new System.Windows.Forms.TabControl();
            this.codigoTabPage = new System.Windows.Forms.TabPage();
            this.nomeTabPage = new System.Windows.Forms.TabPage();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.exibirButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.codigoDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.localizarTabControl.SuspendLayout();
            this.codigoTabPage.SuspendLayout();
            this.nomeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // localizarTabControl
            // 
            this.localizarTabControl.Controls.Add(this.codigoTabPage);
            this.localizarTabControl.Controls.Add(this.nomeTabPage);
            this.localizarTabControl.Location = new System.Drawing.Point(12, 12);
            this.localizarTabControl.Name = "localizarTabControl";
            this.localizarTabControl.SelectedIndex = 0;
            this.localizarTabControl.Size = new System.Drawing.Size(465, 159);
            this.localizarTabControl.TabIndex = 0;
            // 
            // codigoTabPage
            // 
            this.codigoTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.codigoTabPage.Controls.Add(this.codigoDataGridView);
            this.codigoTabPage.Controls.Add(this.codigoTextBox);
            this.codigoTabPage.Location = new System.Drawing.Point(4, 22);
            this.codigoTabPage.Name = "codigoTabPage";
            this.codigoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.codigoTabPage.Size = new System.Drawing.Size(457, 133);
            this.codigoTabPage.TabIndex = 0;
            this.codigoTabPage.Text = "Código";
            // 
            // nomeTabPage
            // 
            this.nomeTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.nomeTabPage.Controls.Add(this.nomeDataGridView);
            this.nomeTabPage.Controls.Add(this.nomeTextBox);
            this.nomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.nomeTabPage.Name = "nomeTabPage";
            this.nomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nomeTabPage.Size = new System.Drawing.Size(457, 133);
            this.nomeTabPage.TabIndex = 1;
            this.nomeTabPage.Text = "Nome";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(6, 3);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(445, 20);
            this.codigoTextBox.TabIndex = 0;
            this.codigoTextBox.Leave += new System.EventHandler(this.codigoTextBox_Leave);
            // 
            // exibirButton
            // 
            this.exibirButton.Image = global::GestorSAAE.Properties.Resources.verifica__2_;
            this.exibirButton.Location = new System.Drawing.Point(483, 104);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(64, 64);
            this.exibirButton.TabIndex = 2;
            this.exibirButton.Text = "&Exibir";
            this.exibirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exibirButton.UseVisualStyleBackColor = true;
            // 
            // localizarButton
            // 
            this.localizarButton.Image = global::GestorSAAE.Properties.Resources.encontrar__2_;
            this.localizarButton.Location = new System.Drawing.Point(483, 34);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(64, 64);
            this.localizarButton.TabIndex = 1;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarButton.UseVisualStyleBackColor = true;
            this.localizarButton.Click += new System.EventHandler(this.localizarButton_Click);
            // 
            // codigoDataGridView
            // 
            this.codigoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codigoDataGridView.Location = new System.Drawing.Point(6, 29);
            this.codigoDataGridView.Name = "codigoDataGridView";
            this.codigoDataGridView.Size = new System.Drawing.Size(445, 98);
            this.codigoDataGridView.TabIndex = 1;
            // 
            // nomeDataGridView
            // 
            this.nomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nomeDataGridView.Location = new System.Drawing.Point(6, 30);
            this.nomeDataGridView.Name = "nomeDataGridView";
            this.nomeDataGridView.Size = new System.Drawing.Size(445, 98);
            this.nomeDataGridView.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(6, 4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(445, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // FormLocalizar
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 183);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.localizarTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLocalizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar";
            this.localizarTabControl.ResumeLayout(false);
            this.codigoTabPage.ResumeLayout(false);
            this.codigoTabPage.PerformLayout();
            this.nomeTabPage.ResumeLayout(false);
            this.nomeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl localizarTabControl;
        private System.Windows.Forms.TabPage codigoTabPage;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TabPage nomeTabPage;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.DataGridView codigoDataGridView;
        private System.Windows.Forms.DataGridView nomeDataGridView;
        private System.Windows.Forms.TextBox nomeTextBox;
    }
}