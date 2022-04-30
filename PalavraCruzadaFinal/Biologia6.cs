using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalavraCruzadaFinal
{
    public partial class Biologia6 : Form
    {
        public Biologia6()
        {
            InitializeComponent();
            lblPontos.Text = pontuacao.ToString();
        }

        int pontuacao = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string[] boca = new string[] { "B", "O", "C", "A" };
            string[] bocav = new string[] { txtBxBocaB.Text, txtBxBocaO.Text, txtBxBocaC.Text, txtBxOrelhaA.Text };
            if (boca.SequenceEqual(bocav))
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxBocaB.Enabled = false;
                txtBxBocaO.Enabled = false;
                txtBxBocaC.Enabled = false;
                txtBxOrelhaA.Enabled = false;
            }

            string[] olhos = new string[] { "O", "L", "H", "O", "S" };
            string[] olhosv = new string[] { txtBxBocaO.Text, txtBxOlhosL.Text, txtBxOlhosH.Text, txtBxOlhosO.Text, txtBxOlhosS.Text };
            if (olhos.SequenceEqual(olhosv))
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxBocaO.Enabled = false;
                txtBxOlhosL.Enabled = false;
                txtBxOlhosH.Enabled = false;
                txtBxOlhosO.Enabled = false;
                txtBxOlhosS.Enabled = false;
            }

            string[] humano = new string[] { "H", "U", "M", "A", "N", "O" };
            string[] humanov = new string[] { txtBxOlhosH.Text, txtBxHumanoU.Text, txtBxHumanoM.Text, txtBxHumanoA.Text, txtBxHumanoN.Text, txtBxHumanoO.Text };
            if (humano.SequenceEqual(humanov))
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxOlhosH.Enabled = false;
                txtBxHumanoU.Enabled = false;
                txtBxHumanoM.Enabled = false;
                txtBxHumanoA.Enabled = false;
                txtBxHumanoN.Enabled = false;
                txtBxHumanoO.Enabled = false;
            }

            string[] nariz = new string[] { "N", "A", "R", "I", "Z" };
            string[] narizv = new string[] { txtBxHumanoN.Text, txtBxNarizA.Text, txtBxNarizR.Text, txtBxNarizI.Text, txtBxNarizZ.Text };
            if (humano.SequenceEqual(humanov))
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxHumanoN.Enabled = false;
                txtBxNarizA.Enabled = false;
                txtBxNarizR.Enabled = false;
                txtBxNarizI.Enabled = false;
                txtBxNarizZ.Enabled = false;
            }

            string[] orelha = new string[] { "O", "R", "E", "L", "H", "A" };
            string[] orelhav = new string[] { txtBxOrelhaO.Text, txtBxOrelhaR.Text, txtBxOrelhaE.Text, txtBxOrelhaL.Text, txtBxOrelhaH.Text, txtBxOrelhaA.Text };
            if (orelha.SequenceEqual(orelhav))
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxOrelhaO.Enabled = false;
                txtBxOrelhaR.Enabled = false;
                txtBxOrelhaE.Enabled = false;
                txtBxOrelhaL.Enabled = false;
                txtBxOrelhaH.Enabled = false;
                txtBxOrelhaA.Enabled = false;
            }

            string[] pele = new string[] { "P", "E", "L", "E" };
            string[] pelev = new string[] { txtBxPeleP.Text, txtBxOrelhaE.Text, txtBxPeleL.Text, txtBxPeleE.Text };
            if (pele.SequenceEqual(pelev))
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxPeleP.Enabled = false;
                txtBxOrelhaE.Enabled = false;
                txtBxPeleL.Enabled = false;
                txtBxPeleE.Enabled = false;
            }

            if (pontuacao >= 6)
            {
                lblGanhou.Text = "VOCÊ GANHOU!!!";
            }
        }
    }
}
