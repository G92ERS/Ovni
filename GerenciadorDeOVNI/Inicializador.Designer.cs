namespace GerenciadorDeOVNI
{
    partial class Inicializador
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltripulantes = new System.Windows.Forms.Label();
            this.lblabduzidos = new System.Windows.Forms.Label();
            this.txbtripulantes = new System.Windows.Forms.NumericUpDown();
            this.txbabduzidos = new System.Windows.Forms.NumericUpDown();
            this.lblplaneta = new System.Windows.Forms.Label();
            this.cmbplanetas = new System.Windows.Forms.ComboBox();
            this.btncriar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txbtripulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbabduzidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERENCIADOR DE OVNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbltripulantes
            // 
            this.lbltripulantes.AutoSize = true;
            this.lbltripulantes.Location = new System.Drawing.Point(361, 107);
            this.lbltripulantes.Name = "lbltripulantes";
            this.lbltripulantes.Size = new System.Drawing.Size(113, 13);
            this.lbltripulantes.TabIndex = 1;
            this.lbltripulantes.Text = "Maximo de Tripulantes";
            // 
            // lblabduzidos
            // 
            this.lblabduzidos.AutoSize = true;
            this.lblabduzidos.Location = new System.Drawing.Point(364, 140);
            this.lblabduzidos.Name = "lblabduzidos";
            this.lblabduzidos.Size = new System.Drawing.Size(110, 13);
            this.lblabduzidos.TabIndex = 2;
            this.lblabduzidos.Text = "Maximo de Abduzidos";
            // 
            // txbtripulantes
            // 
            this.txbtripulantes.Location = new System.Drawing.Point(538, 107);
            this.txbtripulantes.Name = "txbtripulantes";
            this.txbtripulantes.Size = new System.Drawing.Size(120, 20);
            this.txbtripulantes.TabIndex = 3;
            // 
            // txbabduzidos
            // 
            this.txbabduzidos.Location = new System.Drawing.Point(538, 140);
            this.txbabduzidos.Name = "txbabduzidos";
            this.txbabduzidos.Size = new System.Drawing.Size(120, 20);
            this.txbabduzidos.TabIndex = 4;
            // 
            // lblplaneta
            // 
            this.lblplaneta.AutoSize = true;
            this.lblplaneta.Location = new System.Drawing.Point(377, 180);
            this.lblplaneta.Name = "lblplaneta";
            this.lblplaneta.Size = new System.Drawing.Size(97, 13);
            this.lblplaneta.TabIndex = 5;
            this.lblplaneta.Text = "Planeta de Origem:";
            // 
            // cmbplanetas
            // 
            this.cmbplanetas.FormattingEnabled = true;
            this.cmbplanetas.Location = new System.Drawing.Point(538, 177);
            this.cmbplanetas.Name = "cmbplanetas";
            this.cmbplanetas.Size = new System.Drawing.Size(120, 21);
            this.cmbplanetas.TabIndex = 6;
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(361, 224);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(297, 63);
            this.btncriar.TabIndex = 7;
            this.btncriar.Text = "Criar Nave";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.cmbplanetas);
            this.Controls.Add(this.lblplaneta);
            this.Controls.Add(this.txbabduzidos);
            this.Controls.Add(this.txbtripulantes);
            this.Controls.Add(this.lblabduzidos);
            this.Controls.Add(this.lbltripulantes);
            this.Controls.Add(this.label1);
            this.Name = "Inicializador";
            this.Text = "Inicializador";
            this.Activated += new System.EventHandler(this.Inicializador_Activated);
            this.Load += new System.EventHandler(this.Inicializador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbtripulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbabduzidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltripulantes;
        private System.Windows.Forms.Label lblabduzidos;
        private System.Windows.Forms.NumericUpDown txbtripulantes;
        private System.Windows.Forms.NumericUpDown txbabduzidos;
        private System.Windows.Forms.Label lblplaneta;
        private System.Windows.Forms.ComboBox cmbplanetas;
        private System.Windows.Forms.Button btncriar;
    }
}