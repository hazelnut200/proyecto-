namespace POOYECTO_DE_CATEDRA
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.barraMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.menuConteiner1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRpedido = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPagos = new System.Windows.Forms.Button();
            this.menuConteiner2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menu2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.transicion_menú = new System.Windows.Forms.Timer(this.components);
            this.transicion_menú2 = new System.Windows.Forms.Timer(this.components);
            this.timerbarra = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.barraMenu.SuspendLayout();
            this.menuConteiner1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.menuConteiner2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pupuseria Don Bosco ";
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.menu_hamburguesa__2_;
            this.btnMenu.Location = new System.Drawing.Point(8, 7);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(45, 37);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.barraMenu.Controls.Add(this.menuConteiner1);
            this.barraMenu.Controls.Add(this.menuConteiner2);
            this.barraMenu.Controls.Add(this.panel2);
            this.barraMenu.Location = new System.Drawing.Point(0, 54);
            this.barraMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(73, 480);
            this.barraMenu.TabIndex = 1;
            this.barraMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.barraMenu_Paint);
            // 
            // menuConteiner1
            // 
            this.menuConteiner1.Controls.Add(this.panel4);
            this.menuConteiner1.Controls.Add(this.panel6);
            this.menuConteiner1.Controls.Add(this.panel7);
            this.menuConteiner1.Location = new System.Drawing.Point(4, 4);
            this.menuConteiner1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuConteiner1.Name = "menuConteiner1";
            this.menuConteiner1.Size = new System.Drawing.Size(284, 60);
            this.menuConteiner1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menu);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 60);
            this.panel4.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.CadetBlue;
            this.menu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.nota_medica;
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(-5, -5);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.menu.Size = new System.Drawing.Size(281, 73);
            this.menu.TabIndex = 3;
            this.menu.Text = "         Pedidos";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnRpedido);
            this.panel6.Location = new System.Drawing.Point(4, 72);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(267, 60);
            this.panel6.TabIndex = 8;
            // 
            // btnRpedido
            // 
            this.btnRpedido.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRpedido.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRpedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRpedido.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.diario_alternativo;
            this.btnRpedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRpedido.Location = new System.Drawing.Point(-5, -5);
            this.btnRpedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRpedido.Name = "btnRpedido";
            this.btnRpedido.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnRpedido.Size = new System.Drawing.Size(281, 73);
            this.btnRpedido.TabIndex = 3;
            this.btnRpedido.Text = "      Realizar Pedido";
            this.btnRpedido.UseVisualStyleBackColor = false;
            this.btnRpedido.Click += new System.EventHandler(this.btnRpedido_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPagos);
            this.panel7.Location = new System.Drawing.Point(4, 140);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 60);
            this.panel7.TabIndex = 9;
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPagos.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPagos.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.carro_de_compras_rapido;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(-5, -5);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPagos.Size = new System.Drawing.Size(281, 73);
            this.btnPagos.TabIndex = 3;
            this.btnPagos.Text = "         Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // menuConteiner2
            // 
            this.menuConteiner2.Controls.Add(this.panel3);
            this.menuConteiner2.Controls.Add(this.panel5);
            this.menuConteiner2.Location = new System.Drawing.Point(4, 72);
            this.menuConteiner2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuConteiner2.Name = "menuConteiner2";
            this.menuConteiner2.Size = new System.Drawing.Size(280, 60);
            this.menuConteiner2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menu2);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 60);
            this.panel3.TabIndex = 6;
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.Color.CadetBlue;
            this.menu2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu2.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.usuarios_alt;
            this.menu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2.Location = new System.Drawing.Point(-5, -5);
            this.menu2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu2.Name = "menu2";
            this.menu2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.menu2.Size = new System.Drawing.Size(281, 73);
            this.menu2.TabIndex = 3;
            this.menu2.Text = "         Empleados";
            this.menu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2.UseVisualStyleBackColor = false;
            this.menu2.Click += new System.EventHandler(this.menu2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLogin);
            this.panel5.Location = new System.Drawing.Point(4, 72);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 60);
            this.panel5.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLogin.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.alt_de_inicio_de_sesion__1_;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(-5, -5);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(281, 73);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "    Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(4, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 60);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::POOYECTO_DE_CATEDRA.Properties.Resources.informacion_del_circulo_de_archivos__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-5, -5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(281, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "          Acerca de";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // transicion_menú
            // 
            this.transicion_menú.Tick += new System.EventHandler(this.transicion_menú_Tick);
            // 
            // transicion_menú2
            // 
            this.transicion_menú2.Tick += new System.EventHandler(this.transicion_menú2_Tick);
            // 
            // timerbarra
            // 
            this.timerbarra.Tick += new System.EventHandler(this.timerbarra_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1105, 535);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pupuseria Don Bosco ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.barraMenu.ResumeLayout(false);
            this.menuConteiner1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.menuConteiner2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel barraMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button menu2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRpedido;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.FlowLayoutPanel menuConteiner2;
        private System.Windows.Forms.FlowLayoutPanel menuConteiner1;
        private System.Windows.Forms.Timer transicion_menú;
        private System.Windows.Forms.Timer transicion_menú2;
        private System.Windows.Forms.Timer timerbarra;
    }
}

