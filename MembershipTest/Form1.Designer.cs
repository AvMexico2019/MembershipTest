namespace MembershipTest
{
    partial class Form1
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
            this.comboBoxAplicaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuarioBuscado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxRolesUsuario = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxUsuariosEncontrados = new System.Windows.Forms.ListBox();
            this.buttonBorraUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAplicaciones
            // 
            this.comboBoxAplicaciones.FormattingEnabled = true;
            this.comboBoxAplicaciones.Location = new System.Drawing.Point(16, 29);
            this.comboBoxAplicaciones.Name = "comboBoxAplicaciones";
            this.comboBoxAplicaciones.Size = new System.Drawing.Size(328, 21);
            this.comboBoxAplicaciones.TabIndex = 0;
            this.comboBoxAplicaciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxAplicaciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aplicaciones";
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.Location = new System.Drawing.Point(16, 69);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(328, 368);
            this.listBoxRoles.TabIndex = 2;
            this.listBoxRoles.SelectedIndexChanged += new System.EventHandler(this.listBoxRoles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Roles del sistema";
            // 
            // textBoxUsuarioBuscado
            // 
            this.textBoxUsuarioBuscado.Location = new System.Drawing.Point(351, 29);
            this.textBoxUsuarioBuscado.Name = "textBoxUsuarioBuscado";
            this.textBoxUsuarioBuscado.Size = new System.Drawing.Size(437, 20);
            this.textBoxUsuarioBuscado.TabIndex = 4;
            this.textBoxUsuarioBuscado.TextChanged += new System.EventHandler(this.textBoxUsuarioBuscado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "usuario buscado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario Encontrado (IsApproved, Deleted, IsLockedOut)";
            // 
            // listBoxRolesUsuario
            // 
            this.listBoxRolesUsuario.FormattingEnabled = true;
            this.listBoxRolesUsuario.Location = new System.Drawing.Point(350, 225);
            this.listBoxRolesUsuario.Name = "listBoxRolesUsuario";
            this.listBoxRolesUsuario.Size = new System.Drawing.Size(431, 212);
            this.listBoxRolesUsuario.TabIndex = 8;
            this.listBoxRolesUsuario.SelectedIndexChanged += new System.EventHandler(this.listBoxRolesUsuario_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Roles del usuario";
            // 
            // listBoxUsuariosEncontrados
            // 
            this.listBoxUsuariosEncontrados.FormattingEnabled = true;
            this.listBoxUsuariosEncontrados.Location = new System.Drawing.Point(351, 86);
            this.listBoxUsuariosEncontrados.Name = "listBoxUsuariosEncontrados";
            this.listBoxUsuariosEncontrados.Size = new System.Drawing.Size(437, 108);
            this.listBoxUsuariosEncontrados.TabIndex = 10;
            this.listBoxUsuariosEncontrados.SelectedIndexChanged += new System.EventHandler(this.listBoxUsuariosEncontrados_SelectedIndexChanged);
            // 
            // buttonBorraUsuario
            // 
            this.buttonBorraUsuario.Location = new System.Drawing.Point(707, 55);
            this.buttonBorraUsuario.Name = "buttonBorraUsuario";
            this.buttonBorraUsuario.Size = new System.Drawing.Size(81, 23);
            this.buttonBorraUsuario.TabIndex = 11;
            this.buttonBorraUsuario.Text = "Borra Usuario";
            this.buttonBorraUsuario.UseVisualStyleBackColor = true;
            this.buttonBorraUsuario.Click += new System.EventHandler(this.buttonBorraUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBorraUsuario);
            this.Controls.Add(this.listBoxUsuariosEncontrados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxRolesUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsuarioBuscado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxRoles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAplicaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAplicaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsuarioBuscado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxRolesUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxUsuariosEncontrados;
        private System.Windows.Forms.Button buttonBorraUsuario;
    }
}

