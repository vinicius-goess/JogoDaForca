
namespace JogoDaForca
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxForca = new System.Windows.Forms.PictureBox();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.textPalavra = new System.Windows.Forms.TextBox();
            this.textBoxTentativas = new System.Windows.Forms.TextBox();
            this.textBoxLetrasTentadas = new System.Windows.Forms.TextBox();
            this.btnTentar = new System.Windows.Forms.Button();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForca)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxLetrasTentadas);
            this.groupBox1.Controls.Add(this.btnNovoJogo);
            this.groupBox1.Controls.Add(this.txtLetra);
            this.groupBox1.Controls.Add(this.btnTentar);
            this.groupBox1.Controls.Add(this.textBoxTentativas);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS DO JOGO";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(210, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FORCA";
            // 
            // pictureBoxForca
            // 
            this.pictureBoxForca.Location = new System.Drawing.Point(245, 37);
            this.pictureBoxForca.Name = "pictureBoxForca";
            this.pictureBoxForca.Size = new System.Drawing.Size(285, 289);
            this.pictureBoxForca.TabIndex = 2;
            this.pictureBoxForca.TabStop = false;
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(6, 34);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(78, 20);
            this.txtLetra.TabIndex = 3;
            // 
            // textPalavra
            // 
            this.textPalavra.Enabled = false;
            this.textPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPalavra.Location = new System.Drawing.Point(46, 394);
            this.textPalavra.Name = "textPalavra";
            this.textPalavra.Size = new System.Drawing.Size(307, 29);
            this.textPalavra.TabIndex = 4;
            // 
            // textBoxTentativas
            // 
            this.textBoxTentativas.Location = new System.Drawing.Point(6, 146);
            this.textBoxTentativas.Name = "textBoxTentativas";
            this.textBoxTentativas.Size = new System.Drawing.Size(100, 20);
            this.textBoxTentativas.TabIndex = 5;
            // 
            // textBoxLetrasTentadas
            // 
            this.textBoxLetrasTentadas.Enabled = false;
            this.textBoxLetrasTentadas.Location = new System.Drawing.Point(6, 79);
            this.textBoxLetrasTentadas.Name = "textBoxLetrasTentadas";
            this.textBoxLetrasTentadas.Size = new System.Drawing.Size(171, 20);
            this.textBoxLetrasTentadas.TabIndex = 6;
            // 
            // btnTentar
            // 
            this.btnTentar.Location = new System.Drawing.Point(9, 186);
            this.btnTentar.Name = "btnTentar";
            this.btnTentar.Size = new System.Drawing.Size(75, 23);
            this.btnTentar.TabIndex = 7;
            this.btnTentar.Text = "Tentar";
            this.btnTentar.UseVisualStyleBackColor = true;
            this.btnTentar.Click += new System.EventHandler(this.btnTentar_Click);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Location = new System.Drawing.Point(9, 230);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(75, 23);
            this.btnNovoJogo.TabIndex = 8;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite uma letra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tentativas feitas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Qnt restantes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Palavra";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(122, 362);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(179, 29);
            this.lblMensagem.TabIndex = 13;
            this.lblMensagem.Text = "Voce Venceu !!!";
            this.lblMensagem.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 467);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPalavra);
            this.Controls.Add(this.pictureBoxForca);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLetrasTentadas;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnTentar;
        private System.Windows.Forms.TextBox textBoxTentativas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxForca;
        private System.Windows.Forms.TextBox textPalavra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMensagem;
    }
}