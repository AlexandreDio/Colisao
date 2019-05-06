namespace Colisao
{
    partial class frmJogo
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMsgGameOver = new System.Windows.Forms.Panel();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblMsgGameOver = new System.Windows.Forms.Label();
            this.pbVilao = new System.Windows.Forms.PictureBox();
            this.pbHeroi = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMoeda = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMsgGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVilao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoeda)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMsgGameOver
            // 
            this.pnlMsgGameOver.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMsgGameOver.Controls.Add(this.lblPontos);
            this.pnlMsgGameOver.Controls.Add(this.lblMsgGameOver);
            this.pnlMsgGameOver.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMsgGameOver.Location = new System.Drawing.Point(0, 0);
            this.pnlMsgGameOver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMsgGameOver.Name = "pnlMsgGameOver";
            this.pnlMsgGameOver.Size = new System.Drawing.Size(807, 81);
            this.pnlMsgGameOver.TabIndex = 3;
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPontos.Location = new System.Drawing.Point(22, 23);
            this.lblPontos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(109, 39);
            this.lblPontos.TabIndex = 1;
            this.lblPontos.Text = "label1";
            // 
            // lblMsgGameOver
            // 
            this.lblMsgGameOver.AutoSize = true;
            this.lblMsgGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgGameOver.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMsgGameOver.Location = new System.Drawing.Point(310, 23);
            this.lblMsgGameOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsgGameOver.Name = "lblMsgGameOver";
            this.lblMsgGameOver.Size = new System.Drawing.Size(109, 39);
            this.lblMsgGameOver.TabIndex = 0;
            this.lblMsgGameOver.Text = "label1";
            this.lblMsgGameOver.Visible = false;
            // 
            // pbVilao
            // 
            this.pbVilao.Image = global::Colisao.Properties.Resources.red_guy;
            this.pbVilao.Location = new System.Drawing.Point(413, 254);
            this.pbVilao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbVilao.Name = "pbVilao";
            this.pbVilao.Size = new System.Drawing.Size(57, 60);
            this.pbVilao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVilao.TabIndex = 5;
            this.pbVilao.TabStop = false;
            this.pbVilao.Tag = "inimigo";
            // 
            // pbHeroi
            // 
            this.pbHeroi.Image = global::Colisao.Properties.Resources.Right;
            this.pbHeroi.Location = new System.Drawing.Point(28, 118);
            this.pbHeroi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbHeroi.Name = "pbHeroi";
            this.pbHeroi.Size = new System.Drawing.Size(69, 71);
            this.pbHeroi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeroi.TabIndex = 5;
            this.pbHeroi.TabStop = false;
            this.pbHeroi.Tag = "";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Colisao.Properties.Resources.Moeda;
            this.pictureBox7.Location = new System.Drawing.Point(105, 318);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "coletaveis";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Colisao.Properties.Resources.Moeda;
            this.pictureBox6.Location = new System.Drawing.Point(328, 403);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "coletaveis";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Colisao.Properties.Resources.Moeda;
            this.pictureBox5.Location = new System.Drawing.Point(350, 104);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "coletaveis";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Colisao.Properties.Resources.Moeda;
            this.pictureBox4.Location = new System.Drawing.Point(586, 86);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "coletaveis";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Colisao.Properties.Resources.Moeda;
            this.pictureBox3.Location = new System.Drawing.Point(724, 183);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coletaveis";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Colisao.Properties.Resources.Moeda;
            this.pictureBox2.Location = new System.Drawing.Point(658, 395);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coletaveis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Colisao.Properties.Resources.Moeda;
            this.pictureBox1.Location = new System.Drawing.Point(499, 503);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coletaveis";
            // 
            // pbMoeda
            // 
            this.pbMoeda.Image = global::Colisao.Properties.Resources.Moeda;
            this.pbMoeda.Location = new System.Drawing.Point(47, 475);
            this.pbMoeda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMoeda.Name = "pbMoeda";
            this.pbMoeda.Size = new System.Drawing.Size(29, 27);
            this.pbMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoeda.TabIndex = 4;
            this.pbMoeda.TabStop = false;
            this.pbMoeda.Tag = "coletaveis";
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 611);
            this.Controls.Add(this.pnlMsgGameOver);
            this.Controls.Add(this.pbVilao);
            this.Controls.Add(this.pbHeroi);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMoeda);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmJogo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.pnlMsgGameOver.ResumeLayout(false);
            this.pnlMsgGameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVilao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoeda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlMsgGameOver;
        private System.Windows.Forms.Label lblMsgGameOver;
        private System.Windows.Forms.PictureBox pbMoeda;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.PictureBox pbHeroi;
        private System.Windows.Forms.PictureBox pbVilao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

