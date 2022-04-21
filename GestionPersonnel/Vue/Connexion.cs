using GestionPersonnel.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonnel.Vue
{
    /// <summary>
    /// Fenêtre de connexion à l'application
    /// </summary>
    public partial class Connexion : Form
    {

        private Controleur.Controleur Controleur;
        /// <summary>
        /// Initialise la fenêtre
        /// </summary>
        public Connexion(Controleur.Controleur controleur)
        {
            this.Controleur = controleur;
            InitializeComponent();
            AcceptButton = btnConnect;
        }
        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Se connecter"
        /// </summary>
        /// <param name="sender">sender de type objet</param>
        /// <param name="e">e de type EventArgs</param>
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(txtPwd.Text == "")
            {
                txtPwd.Focus();
                ShowError("Veuillez entrer un mot de passe");
            }

            else if (txtId.Text == "")
            {
                txtId.Focus();
                ShowError("Veuillez entrer un identifiant");
            }

            else
            {
                if(!Controleur.Connect(txtId.Text, txtPwd.Text))
                {
                    ShowError("Identifiant ou Mot de passe incorrect");
                }
            }
        }

        /// <summary>
        /// Fonction affichant sur l'écran s'il y a une erreur de connection
        /// </summary>
        /// <param name="erreur">Cause de l'erreur</param>
        private void ShowError(string erreur)
        {
            Controleur.ShowError(erreur);
        }

        /// <summary>
        /// Script s'éxécutant au chargement de la fenêtre
        /// </summary>
        /// <param name="sender">sender de type objet</param>
        /// <param name="e">e de type EventArgs</param>
        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
