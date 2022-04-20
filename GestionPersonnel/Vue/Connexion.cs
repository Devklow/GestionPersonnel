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
        /// <summary>
        /// Initialise la fenêtre
        /// </summary>
        public Connexion()
        {
            InitializeComponent();
            AcceptButton = btnConnect;
        }
        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Se connecter"
        /// </summary>
        /// <param name="sender">sender de type objet</param>
        /// <param name="e">e de type EventArgs</param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(txtPwd.Text == "")
            {
                txtPwd.Focus();
                showError("Veuillez entrer un mot de passe");
            }

            else if (txtId.Text == "")
            {
                txtId.Focus();
                showError("Veuillez entrer un identifiant");
            }

            else
            {
                //connexion
            }
        }

        /// <summary>
        /// Fonction affichant sur l'écran s'il y a une erreur de connection
        /// </summary>
        /// <param name="erreur">Cause de l'erreur</param>
        private void showError(string erreur)
        {
            if(lblError.Visible == false)
            { 
                lblError.Visible = true;
            }
            lblError.Text = "Erreur : " + erreur;
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
