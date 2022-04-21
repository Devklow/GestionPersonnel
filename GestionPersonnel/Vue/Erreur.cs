using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonnel.Vue
{
    /// <summary>
    /// Fenêtre d'erreur, montre une erreur et demande la validation de prise de connaissance de celle-ci
    /// </summary>
    public partial class Erreur : Form
    {
        private Controleur.Controleur Controleur;
        private string ErrMsg;
        /// <summary>
        /// Constructeur qui valorise les propriétés
        /// </summary>
        /// <param name="controleur">Objet de type Controleur qui sera le controleur de l'application</param>
        /// <param name="errMsg">Chaine de caractère contenant la raison de l'erreur</param>
        public Erreur(Controleur.Controleur controleur, string errMsg)
        {
            this.Controleur = controleur;
            this.ErrMsg = "Erreur : "+errMsg;
            InitializeComponent();
        }
        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton Ok
        /// Permet de fermer le fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Script s'éxécutant au chargement de la fenêtre
        /// Permet de jouer un son d'exclamation et définir le text du label d'erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Erreur_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            this.Location = new Point(Controleur.GetLocation().X - (this.Size.Width / 2), Controleur.GetLocation().Y - (this.Size.Height / 2));
            this.lblError.Text = this.ErrMsg;
        }
        /// <summary>
        /// Script s'éxécutant à la fermeture de la fenêtre
        /// Appelle la fonction dispose qui libère la mémoire de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Erreur_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
