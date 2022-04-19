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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            AcceptButton = btnConnect;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(txtPwd.Text == "")
            {
                txtPwd.Focus();
                showError("Veuillez entrer un mot de passe");
            }

            else if (txtId.Text == "")
            {
                txtPwd.Focus();
                showError("Veuillez entrer un identifiant");
            }

            else
            {
                //connection
            }
        }

        private void showError(string erreur)
        {
            if(lblError.Visible == false)
            { 
                lblError.Visible = true;
            }
            lblError.Text = "Erreur : " + erreur;
        }
    }
}
