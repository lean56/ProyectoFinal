namespace ProyectoFinal.UI.Consulta
{
    partial class ConsultaCargo
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
            this.ConsultaCargoDataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsultaCargobutton = new System.Windows.Forms.Button();
            this.CriterioCargoTextBox = new System.Windows.Forms.TextBox();
            this.FiltroCargocomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaCargoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultaCargoDataGridView
            // 
            this.ConsultaCargoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ConsultaCargoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaCargoDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ConsultaCargoDataGridView.Location = new System.Drawing.Point(14, 15);
            this.ConsultaCargoDataGridView.Name = "ConsultaCargoDataGridView";
            this.ConsultaCargoDataGridView.Size = new System.Drawing.Size(299, 137);
            this.ConsultaCargoDataGridView.TabIndex = 9;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ConsultaCargobutton);
            this.groupBox1.Controls.Add(this.CriterioCargoTextBox);
            this.groupBox1.Controls.Add(this.FiltroCargocomboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // ConsultaCargobutton
            // 
            this.ConsultaCargobutton.Image = global::ProyectoFinal.Properties.Resources.Search_find_3519;
            this.ConsultaCargobutton.Location = new System.Drawing.Point(262, 17);
            this.ConsultaCargobutton.Name = "ConsultaCargobutton";
            this.ConsultaCargobutton.Size = new System.Drawing.Size(51, 39);
            this.ConsultaCargobutton.TabIndex = 13;
            this.ConsultaCargobutton.UseVisualStyleBackColor = true;
            this.ConsultaCargobutton.Click += new System.EventHandler(this.ConsultaCargobutton_Click_1);
            // 
            // CriterioCargoTextBox
            // 
            this.CriterioCargoTextBox.Location = new System.Drawing.Point(110, 38);
            this.CriterioCargoTextBox.Name = "CriterioCargoTextBox";
            this.CriterioCargoTextBox.Size = new System.Drawing.Size(135, 20);
            this.CriterioCargoTextBox.TabIndex = 12;
            // 
            // FiltroCargocomboBox
            // 
            this.FiltroCargocomboBox.FormattingEnabled = true;
            this.FiltroCargocomboBox.Items.AddRange(new object[] {
            "Todos",
            "ID Cargo",
            "Descripcion"});
            this.FiltroCargocomboBox.Location = new System.Drawing.Point(5, 37);
            this.FiltroCargocomboBox.Name = "FiltroCargocomboBox";
            this.FiltroCargocomboBox.Size = new System.Drawing.Size(86, 21);
            this.FiltroCargocomboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Criterio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConsultaCargoDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(13, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 159);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Consulta";
            // 
            // ConsultaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 267);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaCargo";
            this.Text = "Consulta Cargo";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaCargoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ConsultaCargoDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConsultaCargobutton;
        private System.Windows.Forms.TextBox CriterioCargoTextBox;
        private System.Windows.Forms.ComboBox FiltroCargocomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}