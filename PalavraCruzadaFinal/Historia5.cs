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
    public partial class Historia5 : Form
    {
        public Historia5()
        {
            InitializeComponent();
            lblPontos.Text = pontuacao.ToString();
        }

        int pontuacao = 0;
       
        private void button1_Click(object sender, EventArgs e)
        {
            string[] mesopotamia = new string[] { "M", "E", "S", "O", "P", "O", "T", "A", "M", "I", "A" };
            string[] Mesopotamiav = new string[] { txtBxMesopotamiaM.Text, txtBxMesopotamiaE.Text, txtBxMesopotamiaS.Text, txtBxMesopotamiaO.Text, txtBxMesopotamiaP.Text, txtBxMesopotamiaO2.Text, txtBxMesopotamiaT.Text, txtBxMesopotamiaA.Text, txtBxMesopotamiaM2.Text, txtBxMesopotamiaI.Text, txtBxMesopotamiaA2.Text };
            if (mesopotamia.SequenceEqual(Mesopotamiav) == true) 
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxMesopotamiaM.Enabled = false;
                txtBxMesopotamiaE.Enabled = false;
                txtBxMesopotamiaS.Enabled = false;
                txtBxMesopotamiaO.Enabled = false;
                txtBxMesopotamiaP.Enabled = false;
                txtBxMesopotamiaO2.Enabled = false;
                txtBxMesopotamiaT.Enabled = false;
                txtBxMesopotamiaA.Enabled = false;
                txtBxMesopotamiaM2.Enabled = false;
                txtBxMesopotamiaI.Enabled = false;
                txtBxMesopotamiaA2.Enabled = false;
            }

            string[] grecia = new string[] { "G", "R", "E", "C", "I", "A" };
            string[] greciav = new string[] { txtBxGreciaG.Text, txtBxGreciaR.Text, txtBxMesopotamiaE.Text, txtBxGreciaC.Text, txtBxGreciaI.Text, txtBxGreciaA.Text };
            if (grecia.SequenceEqual(greciav) == true)
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxGreciaG.Enabled = false;
                txtBxGreciaR.Enabled = false;
                txtBxMesopotamiaE.Enabled = false;
                txtBxGreciaC.Enabled = false;
                txtBxGreciaI.Enabled = false;
                txtBxGreciaA.Enabled = false;
            }

            string[] egito = new string[] { "E", "G", "I", "T", "O" };
            string[] egitov = new string[] { txtBxEgitoE.Text, txtBxEgitoG.Text, txtBxGreciaI.Text, txtBxEgitoT.Text, txtBxEgitoO.Text };
            if (egito.SequenceEqual(egitov))
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxEgitoE.Enabled = false;
                txtBxEgitoG.Enabled = false;
                txtBxGreciaI.Enabled = false;
                txtBxEgitoT.Enabled = false;
                txtBxEgitoO.Enabled = false;
            }

            string[] roma = new string[] { "R", "O", "M", "A" };
            string[] romav = new string[] { txtBxRomaR.Text, txtBxRomaO.Text, txtBxRomaM.Text, txtBxMesopotamiaA2.Text };
            if (roma.SequenceEqual(romav))
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxRomaR.Enabled = false;
                txtBxRomaO.Enabled = false;
                txtBxRomaM.Enabled = false;
                txtBxMesopotamiaA2.Enabled = false;
            }

            string[] astecas = new string[] { "A", "S", "T", "E", "C", "A", "S" };
            string[] astecasv = new string[] { txtBxAstecasA.Text, txtBxAstecasS.Text, txtBxMesopotamiaT.Text, txtBxAstecasE.Text, txtBxAstecasC.Text, txtBxAstecasA2.Text, txtBxAstecasS2.Text };
            if (astecas.SequenceEqual(astecasv))
            {
                pontuacao = pontuacao + 1;
                lblPontos.Text = pontuacao.ToString();
                txtBxAstecasA.Enabled = false;
                txtBxAstecasS.Enabled = false;
                txtBxMesopotamiaT.Enabled = false;
                txtBxAstecasE.Enabled = false;
                txtBxAstecasC.Enabled = false;
                txtBxAstecasA2.Enabled = false;
                txtBxAstecasS2.Enabled = false;
            }

            if (pontuacao >= 5)
            {
                lblGanhou.Text = "VOCÊ GANHOU!!!";
            }
        }
    }
}
