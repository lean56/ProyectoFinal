namespace ProyectoFinal.UI.Registro
{
    partial class RegistroUsuario
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
            this.NivelUsergroupBox = new System.Windows.Forms.GroupBox();
            this.UserradioButton = new System.Windows.Forms.RadioButton();
            this.AdminradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FechaIngresodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NivelUsergroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NivelUsergroupBox
            // 
            this.NivelUsergroupBox.Controls.Add(this.UserradioButton);
            this.NivelUsergroupBox.Controls.Add(this.AdminradioButton);
            this.NivelUsergroupBox.Location = new System.Drawing.Point(99, 97);
            this.NivelUsergroupBox.Name = "NivelUsergroupBox";
            this.NivelUsergroupBox.Size = new System.Drawing.Size(158, 36);
            this.NivelUsergroupBox.TabIndex = 37;
            this.NivelUsergroupBox.TabStop = false;
            // 
            // UserradioButton
            // 
            this.UserradioButton.AutoSize = true;
            this.UserradioButton.Location = new System.Drawing.Point(6, 13);
            this.UserradioButton.Name = "UserradioButton";
            this.UserradioButton.Size = new System.Drawing.Size(61, 17);
            this.UserradioButton.TabIndex = 1;
            this.UserradioButton.TabStop = true;
            this.UserradioButton.Text = "Usuario";
            this.UserradioButton.UseVisualStyleBackColor = true;
            // 
            // AdminradioButton
            // 
            this.AdminradioButton.AutoSize = true;
            this.AdminradioButton.Location = new System.Drawing.Point(67, 13);
            this.AdminradioButton.Name = "AdminradioButton";
            this.AdminradioButton.Size = new System.Drawing.Size(88, 17);
            this.AdminradioButton.TabIndex = 0;
            this.AdminradioButton.TabStop = true;
            this.AdminradioButton.Text = "Administrador";
            this.AdminradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.EliminarButton);
            this.groupBox1.Controls.Add(this.NuevoButton);
            this.groupBox1.Controls.Add(this.GuardarButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 85);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Eliminar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nuevo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Guardar";
            // 
            // FechaIngresodateTimePicker
            // 
            this.FechaIngresodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresodateTimePicker.Location = new System.Drawing.Point(99, 194);
            this.FechaIngresodateTimePicker.Name = "FechaIngresodateTimePicker";
            this.FechaIngresodateTimePicker.Size = new System.Drawing.Size(155, 20);
            this.FechaIngresodateTimePicker.TabIndex = 35;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(99, 166);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(155, 20);
            this.ClaveTextBox.TabIndex = 34;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(99, 139);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(155, 20);
            this.UsuarioTextBox.TabIndex = 33;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(99, 77);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(158, 20);
            this.EmailTextBox.TabIndex = 32;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(99, 48);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(158, 20);
            this.NombreTextBox.TabIndex = 31;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(99, 16);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.IdnumericUpDown.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Clave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nivel Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ProyectoFinal.Properties.Resources.search_locate_find_icon_icons_com_67287__1_;
            this.BuscarButton.Location = new System.Drawing.Point(175, 7);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(47, 35);
            this.BuscarButton.TabIndex = 38;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources.action_exit_close_remove_13915;
            this.EliminarButton.Location = new System.Drawing.Point(171, 16);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 49);
            this.EliminarButton.TabIndex = 23;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::ProyectoFinal.Properties.Resources.file_new_22051;
            this.NuevoButton.Location = new System.Drawing.Point(9, 16);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 49);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources.save_21411;
            this.GuardarButton.Location = new System.Drawing.Point(90, 16);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 49);
            this.GuardarButton.TabIndex = 21;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 319);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.NivelUsergroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechaIngresodateTimePicker);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroUsuario";
            this.Text = "Registro Usuario";
            this.NivelUsergroupBox.ResumeLayout(false);
            this.NivelUsergroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox NivelUsergroupBox;
        private System.Windows.Forms.RadioButton UserradioButton;
        private System.Windows.Forms.RadioButton AdminradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.DateTimePicker FechaIngresodateTimePicker;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button BuscarButton;
    }
}