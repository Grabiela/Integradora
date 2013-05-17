namespace UniKino.Programacion.ProyectoIntegrador.Forms
{
    partial class FormUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusBarStrip = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.DetallesBox = new System.Windows.Forms.GroupBox();
            this.PasswordTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.StatusBarStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.DetallesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(14, 75);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(198, 154);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.UsernameLabel.Location = new System.Drawing.Point(92, 16);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(46, 13);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Usuario:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordLabel.Location = new System.Drawing.Point(92, 39);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagen";
            // 
            // StatusBarStrip
            // 
            this.StatusBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel});
            this.StatusBarStrip.Location = new System.Drawing.Point(0, 269);
            this.StatusBarStrip.Name = "StatusBarStrip";
            this.StatusBarStrip.Size = new System.Drawing.Size(651, 22);
            this.StatusBarStrip.TabIndex = 5;
            this.StatusBarStrip.Text = "statusStrip1";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(118, 17);
            this.StatusBarLabel.Text = "toolStripStatusLabel1";
            // 
            // GridUsuarios
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 12);
            this.Grid.Name = "GridUsuarios";
            this.Grid.Size = new System.Drawing.Size(388, 250);
            this.Grid.TabIndex = 6;
            this.Grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuarios_CellEnter);
            // 
            // DetallesBox
            // 
            this.DetallesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesBox.Controls.Add(this.PasswordTitle);
            this.DetallesBox.Controls.Add(this.label2);
            this.DetallesBox.Controls.Add(this.ImageBox);
            this.DetallesBox.Controls.Add(this.label3);
            this.DetallesBox.Controls.Add(this.PasswordLabel);
            this.DetallesBox.Controls.Add(this.UsernameLabel);
            this.DetallesBox.Location = new System.Drawing.Point(418, 12);
            this.DetallesBox.Name = "DetallesBox";
            this.DetallesBox.Size = new System.Drawing.Size(221, 250);
            this.DetallesBox.TabIndex = 7;
            this.DetallesBox.TabStop = false;
            this.DetallesBox.Text = " Detalles ";
            // 
            // PasswordTitle
            // 
            this.PasswordTitle.AutoSize = true;
            this.PasswordTitle.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordTitle.Location = new System.Drawing.Point(33, 39);
            this.PasswordTitle.Name = "PasswordTitle";
            this.PasswordTitle.Size = new System.Drawing.Size(56, 13);
            this.PasswordTitle.TabIndex = 6;
            this.PasswordTitle.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(43, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(UniKino.Programacion.ProyectoIntegrador.Models.User);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 291);
            this.Controls.Add(this.DetallesBox);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.StatusBarStrip);
            this.Name = "FormUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.StatusBarStrip.ResumeLayout(false);
            this.StatusBarStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.DetallesBox.ResumeLayout(false);
            this.DetallesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip StatusBarStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.GroupBox DetallesBox;
        private System.Windows.Forms.Label PasswordTitle;
        private System.Windows.Forms.Label label2;
    }
}