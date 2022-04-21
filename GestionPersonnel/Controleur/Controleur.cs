using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPersonnel.Modèle;

namespace GestionPersonnel.Controleur
{
    /// <summary>
    /// Classe controleur, Permet de controler l'application et lier les Classes entre-elles
    /// </summary>
    public class Controleur
    {

        private Vue.Gestion GestionFrm;
        private Vue.Connexion ConnexionFrm;
        private Vue.Demande_de_confirmation ddcFrm;
        private Vue.Erreur ErrFrm;
        private bool Confirmation =false;
        public Controleur()
        {
            this.ConnexionFrm = new Vue.Connexion(this);
            this.ConnexionFrm.ShowDialog();
        }
        /// <summary>
        /// Permet de se connecter en tant que responsable
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool Connect(string nom, string pwd)
        {
            if(Dal.GestDonneesDB.Connect(nom, pwd))
            {
                this.GestionFrm = new Vue.Gestion(this);
                this.ConnexionFrm.Dispose();
                this.GestionFrm.ShowDialog();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Getter sur la location de la fenêtre Gestion
        /// </summary>
        /// <returns>La location</returns>
        public System.Drawing.Point GetLocation()
        {
            if (this.GestionFrm != null)
            {
                return new System.Drawing.Point(this.GestionFrm.Location.X + (this.GestionFrm.Size.Width) / 2, this.GestionFrm.Location.Y + (this.GestionFrm.Size.Height) / 2);
            }
            else
            {
                return new System.Drawing.Point(this.ConnexionFrm.Location.X + (this.ConnexionFrm.Size.Width) / 2, this.ConnexionFrm.Location.Y + (this.ConnexionFrm.Size.Height) / 2);
            }
        }
        /// <summary>
        /// Permet d'obtenir la liste des Motifs
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesMotifs()
        {
            return Dal.GestDonneesDB.GetLesMotifs();
        }

        /// <summary>
        /// Permet d'obtenir la liste des Services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetLesServices()
        {
            return Dal.GestDonneesDB.GetLesServices();
        }
        /// <summary>
        /// Permet d'obtenir le tableau des données Absences lié au Personnel
        /// </summary>
        /// <param name="id">Id du Personnel</param>
        /// <returns>True si la requête est éxécuté</returns>
        public DataTable GetAbsences(int id)
        {
            return Dal.GestDonneesDB.GetAbsences(id);
        }
        /// <summary>
        /// Permet de montrer une erreur
        /// </summary>
        /// <returns></returns>
        public bool ShowError(string errMsg)
        {
            this.ErrFrm = new Vue.Erreur(this, errMsg);
            this.ErrFrm.ShowDialog();
            return true;
        }
        /// <summary>
        /// Ouvre la boite de dialogue de confirmation
        /// </summary>
        public bool Ask()
        {
            this.ddcFrm = new Vue.Demande_de_confirmation(this);
            this.ddcFrm.ShowDialog();
            while (!this.ddcFrm.IsDisposed)
            {

            }
            if (this.Confirmation)
            {
                this.Confirmation = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Permet de confirmer ou infirmer le choix
        /// </summary>
        /// <param name="choix"></param>
        /// <returns></returns>
        public void Confirm(bool choix)
        {
            this.Confirmation = choix;
            this.ddcFrm.Dispose();
        }
        /// <summary>
        /// Met à jour un personnel
        /// </summary>
        /// <param name="personnel">Objet de type Personnel contenant les informations concernant</param>
        /// <returns>True si la requête est éxécuté</returns>
        public bool UpdatePersonnel(Personnel personnel)
        {
            if (Dal.GestDonneesDB.UpdatePersonnel(personnel))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Permet de supprimer un Personnel
        /// </summary>
        /// <param name="id">Id du personnel concerné</param>
        /// <returns>True si la requête est éxécuté</returns>
        public bool DeletePersonnel(int id)
        {
            if (Dal.GestDonneesDB.DeletePersonnel(id))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Ajoute un Personnel
        /// </summary>
        /// <param name="personnel">Objet de type Personnel contenant les informations concernant</param>
        /// <returns></returns>
        public bool AddPersonnel(Personnel personnel)
        {
            if (Dal.GestDonneesDB.AddPersonnel(personnel))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Permet d'ajouter une Absence
        /// </summary>
        /// <param name="absence">Objet de type Absence contenant les informations concernant</param>
        /// <returns></returns>
        public bool AddAbsence(Absence absence)
        {
            if (Dal.GestDonneesDB.AddAbsence(absence))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Met à jour les informations concernant une Absence
        /// </summary>
        /// <param name="absence">Objet de type Absence contenant les informations concernant</param>
        /// <param name="oldDate">Objet de type DateTime contenant l'ancienne Date de début</param>
        /// <returns></returns>
        public bool UpdateAbsence(Absence absence, DateTime oldDate)
        {
            if(Dal.GestDonneesDB.UpdateAbsence(absence, oldDate))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Permet de supprimer une Absence
        /// </summary>
        /// <param name="id">Id du Personnel lié a l'absence</param>
        /// <param name="datedebut">Date de début de l'absence</param>
        /// <returns>Vrai si la demande est éxécuté</returns>
        public bool DeleteAbsence(int id, DateTime datedebut)
        {
            if(Dal.GestDonneesDB.DeleteAbsence(id, datedebut))
            {
                return true;
            }
            return false;
        }
    }
}
