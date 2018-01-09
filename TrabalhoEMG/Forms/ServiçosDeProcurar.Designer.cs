namespace TrabalhoEMG
{
    partial class ServiçosDeProcurar
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
            this.listBoxProcurar = new System.Windows.Forms.ListBox();
            this.buttonProcura = new System.Windows.Forms.Button();
            this.labelHoraExame = new System.Windows.Forms.Label();
            this.labelDataExame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxProcurar
            // 
            this.listBoxProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProcurar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProcurar.FormattingEnabled = true;
            this.listBoxProcurar.ItemHeight = 18;
            this.listBoxProcurar.Location = new System.Drawing.Point(13, 33);
            this.listBoxProcurar.Name = "listBoxProcurar";
            this.listBoxProcurar.Size = new System.Drawing.Size(518, 274);
            this.listBoxProcurar.TabIndex = 0;
            this.listBoxProcurar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxDevices_MouseDoubleClick);
            // 
            // buttonProcura
            // 
            this.buttonProcura.BackColor = System.Drawing.Color.White;
            this.buttonProcura.BackgroundImage = global::TrabalhoEMG.Properties.Resources.Search;
            this.buttonProcura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProcura.FlatAppearance.BorderSize = 0;
            this.buttonProcura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcura.Location = new System.Drawing.Point(12, 328);
            this.buttonProcura.Name = "buttonProcura";
            this.buttonProcura.Size = new System.Drawing.Size(53, 44);
            this.buttonProcura.TabIndex = 1;
            this.buttonProcura.UseVisualStyleBackColor = false;
            this.buttonProcura.Click += new System.EventHandler(this.buttonProcura_Click);
            // 
            // labelHoraExame
            // 
            this.labelHoraExame.AutoSize = true;
            this.labelHoraExame.BackColor = System.Drawing.Color.White;
            this.labelHoraExame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraExame.Location = new System.Drawing.Point(12, 9);
            this.labelHoraExame.Name = "labelHoraExame";
            this.labelHoraExame.Size = new System.Drawing.Size(167, 18);
            this.labelHoraExame.TabIndex = 7;
            this.labelHoraExame.Text = "HoraMinutosSegundos";
            // 
            // labelDataExame
            // 
            this.labelDataExame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataExame.AutoSize = true;
            this.labelDataExame.BackColor = System.Drawing.Color.White;
            this.labelDataExame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataExame.Location = new System.Drawing.Point(327, 9);
            this.labelDataExame.Name = "labelDataExame";
            this.labelDataExame.Size = new System.Drawing.Size(91, 18);
            this.labelDataExame.TabIndex = 8;
            this.labelDataExame.Text = "DiaMesAno";
            // 
            // ServiçosDeProcurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoEMG.Properties.Resources.Vm1lKT;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 384);
            this.Controls.Add(this.labelDataExame);
            this.Controls.Add(this.labelHoraExame);
            this.Controls.Add(this.buttonProcura);
            this.Controls.Add(this.listBoxProcurar);
            this.Name = "ServiçosDeProcurar";
            this.Text = "ServiçosDeProcurar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcurar;
        private System.Windows.Forms.Button buttonProcura;
        private System.Windows.Forms.Label labelHoraExame;
        private System.Windows.Forms.Label labelDataExame;
    }
}