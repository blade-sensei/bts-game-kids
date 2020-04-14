using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech;
using System.Media;

namespace jeux
{
    public partial class Form3 : Form
    {
        int score = 0;
        int compteur = 0;
        public Form3()
        {
            InitializeComponent();
            
        }

        private void btrep_Click(object sender, EventArgs e)
        {

            SpeechSynthesizer indication = new SpeechSynthesizer();
            indication.Rate = -5;
            indication.SelectVoice("ScanSoft Virginie_Dri40_16kHz"); //instrcution par voix
            indication.Speak("Coche les image où tu entends le son A, tu peux cliquer sur l'image pour entendre le son");
            rbballon.Visible = true; //On chaque tout les radio boutons
            rbcahier.Visible = true;
            rbchaussure.Visible = true;
            rbmain.Visible = true;
            rbsac.Visible = true;
            rbtable.Visible = true;
            button1.Visible = true;
            bt1.BackgroundImage = imageList1.Images[0]; //On donne les images au boutons
            bt1.AccessibleDescription = "Ballon";
            bt2.BackgroundImage = imageList1.Images[1];
            bt2.AccessibleDescription = "Cahier";
            bt3.BackgroundImage = imageList1.Images[2];
            bt3.AccessibleDescription = "Chaussure";
            bt4.BackgroundImage = imageList1.Images[3];
            bt4.AccessibleDescription = "Main";
            bt5.BackgroundImage = imageList1.Images[4];
            bt5.AccessibleDescription = "Sac";
            bt6.BackgroundImage = imageList1.Images[5];
            bt6.AccessibleDescription = "Table";
            
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer repeter = new SpeechSynthesizer();
            repeter.Rate = -4; //On diminue la vitesse la voix .Meilleur compréhension
            repeter.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            repeter.Speak(bt1.AccessibleDescription);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer repeter = new SpeechSynthesizer(); //Quand on click sur une image on a le son correspondant
            repeter.Rate = -4;
            repeter.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            repeter.Speak(bt2.AccessibleDescription);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer repeter = new SpeechSynthesizer();
            repeter.Rate = -4;
            repeter.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            repeter.Speak(bt3.AccessibleDescription);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer repeter = new SpeechSynthesizer();
            repeter.Rate = -4;
            repeter.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            repeter.Speak(bt4.AccessibleDescription);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer repeter = new SpeechSynthesizer();
            repeter.Rate = -4;
            repeter.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            repeter.Speak(bt5.AccessibleDescription);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer repeter = new SpeechSynthesizer();
            repeter.Rate = -4;
            repeter.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            repeter.Speak(bt6.AccessibleDescription); //fin des attribution de son
        }

        

        private void bt1_BackgroundImageChanged(object sender, EventArgs e)
        {
            bt1.Visible = true; //quand on change l'image du bouton on affiche le bouton
        }

        private void bt2_BackgroundImageChanged(object sender, EventArgs e)
        {
            bt2.Visible = true;
        }

        private void bt3_BackgroundImageChanged(object sender, EventArgs e)
        {
            bt3.Visible = true;
        }

        private void bt4_BackgroundImageChanged(object sender, EventArgs e)
        {
            bt4.Visible = true;
        }

        private void bt5_BackgroundImageChanged(object sender, EventArgs e)
        {
            bt5.Visible = true;
        }

        private void bt6_BackgroundImageChanged(object sender, EventArgs e)
        {
            bt6.Visible = true; //fin
        }

        private void button1_Click(object sender, EventArgs e) //bouton validation
        {
            //Si chaussure et main sont cochés c'est faux pour le reste des radio boutons c'est bon
                
                if (rbchaussure.Checked == true || rbmain.Checked == true)
                {
                    Outils.mauvaiseReponse();
                    MessageBox.Show("Faux =( , on retrouve la lettre a dans le mot mais pas le son");
                    score = score - 1;
                    compteur = compteur + 1;
                    if (compteur == 4) {
                        MessageBox.Show("Ton score est:" +score.ToString()+"/4");
                    }
                }

                else
                {
                    Outils.bonneReponse();
                    MessageBox.Show("Bien joué !!!");
                    score = score + 1;
                    compteur = compteur + 1;
                    if (compteur == 4)
                    {
                        MessageBox.Show("Ton score est :"+score.ToString()+"/4");
                    }
                }
            
            
            

        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 home = new Form1();
            home.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        
    }
}
