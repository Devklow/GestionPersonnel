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
    /// Fenêtre de confirmation de suppression
    /// Le controleur attend une action
    /// </summary>
    public partial class Demande_de_confirmation : Form
    {
        private Controleur.Controleur Controleur;
        /// <summary>
        /// Constructeur de la fenêtre
        /// </summary>
        /// <param name="controleur">Controleur de type Controleur</param>
        public Demande_de_confirmation(Controleur.Controleur controleur)
        {
            this.Controleur = controleur;
            InitializeComponent();
        }
        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Oui"
        /// Envoie true au Controleur en attente de réponse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnYes_Click(object sender, EventArgs e)
        {
            this.Controleur.Confirm(true);
        }
        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Non"
        /// Envoie false au Controleur en attente de réponse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.Controleur.Confirm(false);
        }
        /// <summary>
        /// Script s'éxécutant au chargement de la fenêtre
        /// Permet de centrer la fenêtre par rapport à la fenêtre Gestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Demande_de_confirmation_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            this.Location = new Point(Controleur.GetLocation().X-(this.Size.Width/2), Controleur.GetLocation().Y-(this.Size.Height/2));
        }
        /// <summary>
        /// Fonction s'éxécutant lors de la fermeture de fenêtre
        /// Dispose la fenêtre évitant un freeze sur le controleur qui attend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Demande_de_confirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
