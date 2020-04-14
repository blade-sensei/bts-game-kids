using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Media;
using System.Speech.Synthesis;
using System.Speech;

namespace jeux
{
    public partial class Form4 : Form
    {
        
        string hibou = "hibou"; //reponse qu'on va utiliser après
        string banane = "banane";
        string poisson = "poisson";
        
        public Form4()
        {
            InitializeComponent();
        }

       

        private void Form4_Load(object sender, EventArgs e)
        {
            string var = Convert.ToString(listBox1.Items[0]);
            label1.Text = var;
            button2.BackgroundImage = imageList1.Images[0]; //On donne des images B et P
            button3.BackgroundImage = imageList1.Images[1];
            pictureBox1.Image = ilImages.Images[0]; //Images du picturebox
            label1.AccessibleDescription = banane;
            pictureBox2.Image = ilPicturebox2.Images[0];
            SpeechSynthesizer info = new SpeechSynthesizer(); 
            info.Rate = -4; //Vitesse réduite de la voix
            info.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            info.Speak("Choisie entre la lettre B ou P, tu peux cliquer sur l'image pour écouter le son, si tu veux récouter ce message clique sur Mické ");
        }

       

        private void button2_Click(object sender, EventArgs e) //bouton P
        {

            //On complete le mot avec la réponse choisie 
            if (label1.Text == "_anane")
            {
                label1.Text = "panane";
                btvalider.Visible = true;
            }
            if (label1.Text == "hi_ou")
            {
                label1.Text = "hipou";
                btvalider.Visible = true;
            }
            if (label1.Text == "_oisson")
            {
                label1.Text = poisson;
                btvalider.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           //on complete des mots avec la lettre b
            if (label1.Text == "_anane")
            {
                label1.Text = banane;
                btvalider.Visible = true;
            }
            if (label1.Text == "hi_ou")
            {
                label1.Text = hibou;
                btvalider.Visible = true;
            }
            if (label1.Text == "_oisson")
            {
                label1.Text = "boisson";
                btvalider.Visible = true;
            }

        }

        private void btvalider_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "banane") || (label1.Text == "hibou") || (label1.Text == "poisson"))
            { //Si le mot complete donne la bonne réponse on a un message Bien joue et le bouton SUIVANT et visible
                MessageBox.Show("Bien joué !!");
               
                Outils.bonneReponse();
                button4.Visible = true;
                
                //cas des mauvaises réponses 
            }
            else if (label1.Text == "panane")
            {
                Outils.mauvaiseReponse();
                MessageBox.Show("la réponse était banane");
                label1.Text = banane;
                button4.Visible = true;
            }
            else if (label1.Text == "hipou")
            {
                Outils.mauvaiseReponse();
                MessageBox.Show("la réponse était hibou");
                label1.Text = hibou;
                button4.Visible = true;
            }

            else if (label1.Text =="boisson")
              {
                  Outils.mauvaiseReponse();
                MessageBox.Show("la réponse était poisson");
                label1.Text = poisson;
                button4.Visible = true;
            }

            
            
                
                 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "banane")
            {
                string var = Convert.ToString(listBox1.Items[1]);
                label1.Text = var;
                pictureBox1.Image = ilImages.Images[1];
                label1.AccessibleDescription = hibou;
            }
            if (label1.Text == "hibou")
            {
                string var = Convert.ToString(listBox1.Items[2]);
                label1.Text = var;
                pictureBox1.Image = ilImages.Images[2];
                label1.AccessibleDescription = poisson;
                
 
            }
           
            

        }

        private void pictureBox1_Click(object sender, EventArgs e) 
        { //Si on clique sur l'image on a la son du mot correspondant a l'images
          
                SpeechSynthesizer image = new SpeechSynthesizer();
                image.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
                image.Speak(label1.AccessibleDescription);
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer info= new SpeechSynthesizer();
            info.Rate = -4;
            info.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            info.Speak("Choisie entre la lettre B ou P, tu peux cliquer sur l'image pour écouter le son");
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 home = new Form1();
            home.Show();
        }
    }
}
