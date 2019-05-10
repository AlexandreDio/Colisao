using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colisao
{
    public partial class frmJogo : Form
    {
        private bool paraEsquerda;
        private bool paraDireita;
        private bool paraCima;
        private bool paraBaixo;
        private int velocidade = 10;
        private int pontos = 0;

        //Criar Lista de mídias via Windows Media Player
        List<System.Windows.Media.MediaPlayer> audios = new List<System.Windows.Media.MediaPlayer>();

        public frmJogo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPontos.Text = "Pontos: " + pontos;
            //Lógica para manter o jogador dentro do form
            LimitaTela();
            MovimentaJogador();

            foreach (Control item in this.Controls)
            {
                //Verifica se PB e colisões entre o herói e demais itens no formulário
                if (item is PictureBox && VerificaColisao(item, pbHeroi))
                {
                    switch (item.Tag)
                    {
                        case "coletaveis":
                            pontos++;
                            TocaAudio("smb_coin.wav");
                            this.Controls.Remove(item);
                            break;
                        case "inimigo":
                            FinalizaJogo();
                            TocaAudio("smb_mariodie.wav");
                            break;
                    }
                }
            }
        }

        private void TocaAudio(string audioNome)
        {
            string url = Application.StartupPath + @"\" + audioNome;
            var som = new System.Windows.Media.MediaPlayer();
            som.Open(new Uri(url));
            som.Play();
            audios.Add(som);
        }

        private void MovimentaJogador()
        {
            if (paraEsquerda)
            {
                pbHeroi.Left -= velocidade;
            }

            if (paraDireita)
            {
                pbHeroi.Left += velocidade;
            }

            if (paraCima)
            {
                pbHeroi.Top -= velocidade;
            }

            if (paraBaixo)
            {
                pbHeroi.Top += velocidade;
            }
        }

        private void LimitaTela()
        {
            if (pbHeroi.Location.Y > (ClientSize.Height - pnlMsgGameOver.Size.Height))
                pbHeroi.Top = (ClientSize.Height - pnlMsgGameOver.Size.Height);

            if (pbHeroi.Location.Y < pnlMsgGameOver.Size.Height)
                pbHeroi.Top = pnlMsgGameOver.Size.Height;

            if (pbHeroi.Location.X < 0)
                pbHeroi.Left = 0;

            if (pbHeroi.Location.X > (ClientSize.Width - pbHeroi.Size.Width))
                pbHeroi.Left = (ClientSize.Width - pbHeroi.Size.Width);
        }

        private bool VerificaColisao(Control controle, PictureBox objogo)
        {
            if (((PictureBox)controle).Bounds.IntersectsWith(objogo.Bounds))
                return true;
            return false;
        }

        private void ColetaItens()
        {
            pbMoeda.Visible = false;
            lblPontos.Text += pontos;
        }

        private void FinalizaJogo()
        {
            timer1.Stop();
            EncerraAudios();
            pbHeroi.Visible = false;
            lblMsgGameOver.Visible = true;
            lblMsgGameOver.Text = "GAME OVER";
        }

        private void EncerraAudios()
        {
            for (int i = audios.Count -1; i >= 0; i--)
            {
                audios[i].Stop();
                audios.RemoveAt(i);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paraEsquerda = true;
                paraDireita = false;
                paraCima = false;
                paraBaixo = false;
                pbHeroi.Image = Properties.Resources.Left;
            }

            if (e.KeyCode == Keys.Right)
            {
                paraDireita = true;
                paraCima = false;
                paraBaixo = false;
                paraEsquerda = false;
                pbHeroi.Image = Properties.Resources.Right;
            }

            if (e.KeyCode == Keys.Up)
            {
                paraCima = true;
                paraDireita = false;
                paraEsquerda = false;
                paraBaixo = false;
                pbHeroi.Image = Properties.Resources.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                paraBaixo = true;
                paraCima = false;
                paraDireita = false;
                paraEsquerda = false;
                pbHeroi.Image = Properties.Resources.down;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paraEsquerda = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                paraDireita = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                paraCima = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                paraBaixo = false;
            }
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            TocaAudio("overworld.mp3");
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
