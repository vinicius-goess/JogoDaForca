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
            {
                g.Clear(this.BackColor);
                // Estrutura da forca
                g.DrawLine(pen, 20, 250, 150, 250); // Base
                g.DrawLine(pen, 85, 250, 85, 50);   // Poste
                g.DrawLine(pen, 85, 50, 200, 50);   // Topo
                g.DrawLine(pen, 200, 50, 200, 80);  // Corda

                if (erros >= 1) g.DrawEllipse(pen, 175, 80, 50, 50);    // Cabeça
                if (erros >= 2) g.DrawLine(pen, 200, 130, 200, 200);   // Tronco
                if (erros >= 3) g.DrawLine(pen, 200, 150, 170, 180);   // Braço esquerdo
                if (erros >= 4) g.DrawLine(pen, 200, 150, 230, 180);   // Braço direito
                if (erros >= 5) g.DrawLine(pen, 200, 200, 170, 240);   // Perna esquerda
                if (erros >= 6) g.DrawLine(pen, 200, 200, 230, 240);   // Perna direita
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
