namespace TrabalhoEMG
{
    partial class Exame
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
            this.comecar = new System.Windows.Forms.Button();
            this.labelHoraExame = new System.Windows.Forms.Label();
            this.labelDataExame = new System.Windows.Forms.Label();
            this.botaoRetroceder = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            this.textBoxNomeExame = new System.Windows.Forms.TextBox();
            this.labelNomeExame = new System.Windows.Forms.Label();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.panelExame = new System.Windows.Forms.Panel();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comecar
            // 
            this.comecar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comecar.BackColor = System.Drawing.Color.White;
            this.comecar.BackgroundImage = global::TrabalhoEMG.Properties.Resources.Icon_3_256;
            this.comecar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comecar.FlatAppearance.BorderSize = 0;
            this.comecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comecar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comecar.Location = new System.Drawing.Point(71, 312);
            this.comecar.Name = "comecar";
            this.comecar.Size = new System.Drawing.Size(53, 44);
            this.comecar.TabIndex = 1;
            this.comecar.UseVisualStyleBackColor = false;
            this.comecar.Click += new System.EventHandler(this.comecar_Click);
            // 
            // labelHoraExame
            // 
            this.labelHoraExame.AutoSize = true;
            this.labelHoraExame.BackColor = System.Drawing.Color.White;
            this.labelHoraExame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraExame.Location = new System.Drawing.Point(9, 9);
            this.labelHoraExame.Name = "labelHoraExame";
            this.labelHoraExame.Size = new System.Drawing.Size(167, 18);
            this.labelHoraExame.TabIndex = 6;
            this.labelHoraExame.Text = "HoraMinutosSegundos";
            // 
            // labelDataExame
            // 
            this.labelDataExame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataExame.AutoSize = true;
            this.labelDataExame.BackColor = System.Drawing.Color.White;
            this.labelDataExame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataExame.Location = new System.Drawing.Point(450, 9);
            this.labelDataExame.Name = "labelDataExame";
            this.labelDataExame.Size = new System.Drawing.Size(91, 18);
            this.labelDataExame.TabIndex = 7;
            this.labelDataExame.Text = "DiaMesAno";
            // 
            // botaoRetroceder
            // 
            this.botaoRetroceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoRetroceder.BackColor = System.Drawing.Color.White;
            this.botaoRetroceder.BackgroundImage = global::TrabalhoEMG.Properties.Resources.Button_Back_2_512_3;
            this.botaoRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoRetroceder.FlatAppearance.BorderSize = 0;
            this.botaoRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRetroceder.Location = new System.Drawing.Point(12, 313);
            this.botaoRetroceder.Name = "botaoRetroceder";
            this.botaoRetroceder.Size = new System.Drawing.Size(53, 44);
            this.botaoRetroceder.TabIndex = 10;
            this.botaoRetroceder.UseVisualStyleBackColor = false;
            this.botaoRetroceder.Click += new System.EventHandler(this.botaoRetroceder_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonParar.BackColor = System.Drawing.Color.White;
            this.buttonParar.BackgroundImage = global::TrabalhoEMG.Properties.Resources.afcacb3f2a1c518ca5400088f66e7b2d_parar__cone_de_m_dia_plana_by_vexels;
            this.buttonParar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonParar.FlatAppearance.BorderSize = 0;
            this.buttonParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParar.Location = new System.Drawing.Point(130, 312);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(53, 44);
            this.buttonParar.TabIndex = 11;
            this.buttonParar.UseVisualStyleBackColor = false;
            // 
            // textBoxNomeExame
            // 
            this.textBoxNomeExame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomeExame.Location = new System.Drawing.Point(412, 326);
            this.textBoxNomeExame.Name = "textBoxNomeExame";
            this.textBoxNomeExame.Size = new System.Drawing.Size(223, 20);
            this.textBoxNomeExame.TabIndex = 12;
            // 
            // labelNomeExame
            // 
            this.labelNomeExame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNomeExame.AutoSize = true;
            this.labelNomeExame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeExame.Location = new System.Drawing.Point(413, 305);
            this.labelNomeExame.Name = "labelNomeExame";
            this.labelNomeExame.Size = new System.Drawing.Size(128, 18);
            this.labelNomeExame.TabIndex = 13;
            this.labelNomeExame.Text = "Nome Do Exame";
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProcurar.BackColor = System.Drawing.Color.White;
            this.buttonProcurar.BackgroundImage = global::TrabalhoEMG.Properties.Resources.Search;
            this.buttonProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProcurar.FlatAppearance.BorderSize = 0;
            this.buttonProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcurar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurar.Location = new System.Drawing.Point(189, 313);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(53, 44);
            this.buttonProcurar.TabIndex = 14;
            this.buttonProcurar.UseVisualStyleBackColor = false;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // panelExame
            // 
            this.panelExame.BackColor = System.Drawing.Color.White;
            this.panelExame.Location = new System.Drawing.Point(12, 50);
            this.panelExame.Name = "panelExame";
            this.panelExame.Size = new System.Drawing.Size(623, 240);
            this.panelExame.TabIndex = 15;
            this.panelExame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelExame_Paint);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(262, 322);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 16;
            this.buttonGravar.Text = "button1";
            this.buttonGravar.UseVisualStyleBackColor = true;
           
            // 
            // Exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoEMG.Properties.Resources.Vm1lKT;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 364);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.panelExame);
            this.Controls.Add(this.buttonProcurar);
            this.Controls.Add(this.labelNomeExame);
            this.Controls.Add(this.textBoxNomeExame);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.botaoRetroceder);
            this.Controls.Add(this.labelDataExame);
            this.Controls.Add(this.labelHoraExame);
            this.Controls.Add(this.comecar);
            this.Name = "Exame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button comecar;
        private System.Windows.Forms.Label labelHoraExame;
        private System.Windows.Forms.Label labelDataExame;
        private System.Windows.Forms.Button botaoRetroceder;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.TextBox textBoxNomeExame;
        private System.Windows.Forms.Label labelNomeExame;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.Panel panelExame;
        private System.Windows.Forms.Button buttonGravar;
    }
}