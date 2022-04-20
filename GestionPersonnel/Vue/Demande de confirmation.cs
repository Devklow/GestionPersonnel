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
    /// Fenêtre de confirmation de suppression
    /// </summary>
    public partial class Demande_de_confirmation : Form
    {
        public Demande_de_confirmation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Oui"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Non"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {

        }
    }
}
