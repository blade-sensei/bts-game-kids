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
using System.Windows.Forms.Design;
namespace jeux
{
    public partial class Form2 : Form
    {
        
        
        public Form2()
        {
            InitializeComponent();
        }
        int reponse; //On pourra comparer les reponses à cette variable

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = img2.Images[0]; //Atribution des images et instruction
            label1.Text = "Combien de côtés il y a dans cette figure";
            reponse = 4; //on donne la chiffre de la bonne reponse
        }

        private void btvalider_Click(object sender, EventArgs e)
        {
            if (tbreponse.Text == reponse.ToString())
            {
                Outils.bonneReponse(); //Appel de la classe outils pour produire un son
                MessageBox.Show("Bien joué");
                btsuivant.Visible = true; //Afficher le bouton suivant pour changer de question
            }
            else
            {
                Outils.mauvaiseReponse(); 
                MessageBox.Show("la bonne réponse était "+reponse);
                btsuivant.Visible = true;
            }
        }

        private void btsuivant_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = img2.Images[2];
            reponse = 0; //Changement de la réponse
            
        }

        private void bt_accueuil_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 home = new Form1();
            home.Show();
        }


       
            
            
        }
}

