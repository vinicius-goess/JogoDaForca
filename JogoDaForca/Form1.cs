using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        private JogoDaForca jogo = null;
        private Timer timerMensagem;

        public Form1()
        {
            InitializeComponent();
            timerMensagem = new Timer();
            timerMensagem.Interval = 400;
            timerMensagem.Tick += timerMensagem_Tick;
            IniciarNovoJogo();
        }

        private void IniciarNovoJogo()
        {
            try
            {
                jogo = new JogoDaForca();
                jogo.SortearPalavra();
                txtLetra.Enabled = true;
                btnTentar.Enabled = true;
                lblMensagem.Visible = false;
                timerMensagem.Stop();
                AtualizarInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar palavra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void AtualizarInterface()
        {
            textPalavra.Text = jogo.PalavraEscondida;
            textBoxTentativas.Text = $"{jogo.TentativasRestantes}";
            textBoxLetrasTentadas.Text = string.Join(", ", jogo.LetrasTentadas);
            txtLetra.Clear();
            txtLetra.Focus();
            int erros = 6 - jogo.TentativasRestantes;
            DesenharForca(erros);
        }

       

        private void FinalizarJogo(bool venceu)
        {
            txtLetra.Enabled = false;
            btnTentar.Enabled = false;

            if (venceu)
            {
                lblMensagem.Text = "VOCÊ VENCEU!";
                lblMensagem.ForeColor = Color.Green;
                textPalavra.ForeColor = Color.Green;
            }
            else
            {
                lblMensagem.Text = "VOCÊ PERDEU!";
                lblMensagem.ForeColor = Color.Red;
                textPalavra.ForeColor = Color.Red;
            }

            lblMensagem.Visible = true;
            timerMensagem.Start();
        }

        private void btnNovoJogo_Click_1(object sender, EventArgs e)
        {
            IniciarNovoJogo();
        }

        private void timerMensagem_Tick(object sender, EventArgs e)
        {
            lblMensagem.Visible = !lblMensagem.Visible;
        }

        private void DesenharForca(int erros)
        {
            Bitmap bmp = new Bitmap(pictureBoxForca.Width, pictureBoxForca.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            using (Pen pen = new Pen(Color.DarkBlue, 3))
            using (Brush bodyBrush = new SolidBrush(Color.DarkBlue))
            using (Brush headBrush = new SolidBrush(Color.Beige))  // Cabeça cor de pele
            using (Brush eyeBrush = new SolidBrush(Color.Black))   // Olhos pretos
            {
                g.Clear(this.BackColor);

                // Estrutura da forca
                g.DrawLine(pen, 20, 250, 150, 250); // Base
                g.DrawLine(pen, 85, 250, 85, 50);   // Poste
                g.DrawLine(pen, 85, 50, 200, 50);   // Topo
                g.DrawLine(pen, 200, 50, 200, 80);  // Corda

                // Cabeça
                if (erros >= 1)
                {
                    g.FillEllipse(headBrush, 170, 80, 60, 60); // Cabeça
                    g.DrawEllipse(pen, 170, 80, 60, 60);       // Contorno da cabeça

                    // Olhos
                    g.FillEllipse(eyeBrush, 185, 100, 6, 6);
                    g.FillEllipse(eyeBrush, 205, 100, 6, 6);

                    // Boca triste
                    g.DrawArc(new Pen(Color.Black, 2), 185, 115, 30, 15, 200, 140);

                    // Cabelo (risquinhos no topo da cabeça)
                    g.DrawLine(pen, 185, 75, 185, 85);
                    g.DrawLine(pen, 200, 72, 200, 85);
                    g.DrawLine(pen, 215, 75, 215, 85);
                }

                // Tronco
                if (erros >= 2)
                    g.FillRectangle(bodyBrush, 185, 140, 30, 70);

                // Braço esquerdo
                if (erros >= 3)
                {
                    g.DrawLine(new Pen(Color.DarkBlue, 8), 185, 150, 150, 190);
                    g.FillEllipse(bodyBrush, 142, 185, 10, 10); // mão
                }

                // Braço direito
                if (erros >= 4)
                {
                    g.DrawLine(new Pen(Color.DarkBlue, 8), 215, 150, 250, 190);
                    g.FillEllipse(bodyBrush, 248, 185, 10, 10); // mão
                }

                // Perna esquerda
                if (erros >= 5)
                {
                    g.DrawLine(new Pen(Color.DarkBlue, 10), 190, 210, 170, 250);
                    g.FillEllipse(bodyBrush, 162, 245, 15, 8); // pé
                }

                // Perna direita
                if (erros >= 6)
                {
                    g.DrawLine(new Pen(Color.DarkBlue, 10), 210, 210, 230, 250);
                    g.FillEllipse(bodyBrush, 222, 245, 15, 8); // pé
                }
            }

            pictureBoxForca.Image = bmp;
        }

        private void btnTentar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLetra.Text) || !char.IsLetter(txtLetra.Text[0]))
            {
                MessageBox.Show("Por favor, digite uma letra válida.", "Entrada Inválida");
                return;
            }

            char letra = txtLetra.Text[0];
            jogo.TentarLetra(letra);
            AtualizarInterface();

            if (jogo.VerificarVitoria())
            {
                FinalizarJogo(venceu: true);
            }
            else if (jogo.VerificarDerrota())
            {
                FinalizarJogo(venceu: false);
            }
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            IniciarNovoJogo();
        }
    }
}
