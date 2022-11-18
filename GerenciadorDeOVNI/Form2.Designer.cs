namespace GerenciadorDeOVNI
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbTribulacao = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grbestatisticas = new System.Windows.Forms.GroupBox();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.grbplaneta = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grbTribulacao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbestatisticas.SuspendLayout();
            this.grbplaneta.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ligar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Desligar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grbTribulacao
            // 
            this.grbTribulacao.Controls.Add(this.button4);
            this.grbTribulacao.Controls.Add(this.button3);
            this.grbTribulacao.Location = new System.Drawing.Point(37, 127);
            this.grbTribulacao.Name = "grbTribulacao";
            this.grbTribulacao.Size = new System.Drawing.Size(200, 100);
            this.grbTribulacao.TabIndex = 3;
            this.grbTribulacao.TabStop = false;
            this.grbTribulacao.Text = "Tripulacao";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 31);
            this.button4.TabIndex = 1;
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(37, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abduzidos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 31);
            this.button5.TabIndex = 1;
            this.button5.Text = "Remover";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 31);
            this.button6.TabIndex = 0;
            this.button6.Text = "Adicionar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "GERENCIADOR DE OVNI";
            // 
            // grbestatisticas
            // 
            this.grbestatisticas.Controls.Add(this.label3);
            this.grbestatisticas.Controls.Add(this.label1);
            this.grbestatisticas.Controls.Add(this.lblTripulantes);
            this.grbestatisticas.Location = new System.Drawing.Point(317, 127);
            this.grbestatisticas.Name = "grbestatisticas";
            this.grbestatisticas.Size = new System.Drawing.Size(200, 100);
            this.grbestatisticas.TabIndex = 6;
            this.grbestatisticas.TabStop = false;
            this.grbestatisticas.Text = "Estatisticas";
            this.grbestatisticas.Enter += new System.EventHandler(this.grbestatisticas_Enter);
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(7, 20);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(62, 13);
            this.lblTripulantes.TabIndex = 0;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abduzidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Planeta Atual:";
            // 
            // grbplaneta
            // 
            this.grbplaneta.Controls.Add(this.comboBox1);
            this.grbplaneta.Location = new System.Drawing.Point(317, 254);
            this.grbplaneta.Name = "grbplaneta";
            this.grbplaneta.Size = new System.Drawing.Size(200, 100);
            this.grbplaneta.TabIndex = 7;
            this.grbplaneta.TabStop = false;
            this.grbplaneta.Text = "Planeta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbplaneta);
            this.Controls.Add(this.grbestatisticas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbTribulacao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grbTribulacao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grbestatisticas.ResumeLayout(false);
            this.grbestatisticas.PerformLayout();
            this.grbplaneta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grbTribulacao;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbestatisticas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox grbplaneta;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}