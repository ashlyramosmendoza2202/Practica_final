namespace Practica_Final
{
    partial class FrmAsistenteGlamy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistenteGlamy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPreguntar = new System.Windows.Forms.Button();
            this.txtPregunta = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnPreguntar);
            this.panel1.Controls.Add(this.txtPregunta);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(52, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 401);
            this.panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Location = new System.Drawing.Point(229, 191);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(187, 43);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPreguntar
            // 
            this.btnPreguntar.Image = ((System.Drawing.Image)(resources.GetObject("btnPreguntar.Image")));
            this.btnPreguntar.Location = new System.Drawing.Point(229, 142);
            this.btnPreguntar.Name = "btnPreguntar";
            this.btnPreguntar.Size = new System.Drawing.Size(187, 43);
            this.btnPreguntar.TabIndex = 4;
            this.btnPreguntar.Text = "ENVAR";
            this.btnPreguntar.UseVisualStyleBackColor = true;
            this.btnPreguntar.Click += new System.EventHandler(this.btnPreguntar_Click);
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(30, 104);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(349, 26);
            this.txtPregunta.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 240);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(409, 146);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Hola! Soy Glammy, \r\n\r\ntu asistente virtual de GlamInventory.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAsistenteGlamy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAsistenteGlamy";
            this.Text = "GLAMMY";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPregunta;
        private System.Windows.Forms.Button btnPreguntar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}