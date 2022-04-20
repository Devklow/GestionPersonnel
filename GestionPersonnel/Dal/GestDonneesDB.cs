using GestionPersonnel.Connexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonnel.Dal
{
    /// <summary>
    /// Gère les demandes concernant les données distantes
    /// </summary>
    class GestDonneesDB
    {
        /// <summary>
        /// chaine de connection
        /// </summary>
        private static string connectionString = "server=localhost;user id=atelier;password=btssio;database=gestperso";

        /// <summary>
        /// Permet au responsable de s'authentifier
        /// </summary>
        /// <param name="nom">nom d'utilisateur</param>
        /// <param name="pwd">mot de passe</param>
        /// <returns>Vrai si le login et le mot de passe correspondent</returns>
        public static Boolean Connect(string nom, string pwd)
        {
            string req = "Select * from responsable where login=@nom and pwd=SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", nom);
            parameters.Add("@pwd", pwd);
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            connection.Select(req, parameters);
            if(connection.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        /// <summary>
        /// Permet d'avoir la liste des Motifs d'absence
        /// </summary>
        /// <returns>lesMotifs une liste contenant plusieurs Motifs</returns>
        public static List<Modèle.Motif> GetLesMotifs()
        {
            string req = "Select * from motif;";
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            connection.Select(req, null);
            List<Modèle.Motif> lesMotifs = new List<Modèle.Motif> { };
            while (connection.Read())
            {
                lesMotifs.Add(new Modèle.Motif((int)connection.Field("IDMOTIF"), (string)connection.Field("LIBELLE")));
            }
            connection.Close();
            return lesMotifs;
        }

        /// <summary>
        /// Permet d'avoir la liste des Services liés au personnel
        /// </summary>
        /// <returns>lesMotifs une liste contenant plusieurs Services</returns>
        public static List<Modèle.Service> GetLesServices()
        {
            string req = "Select * from service;";
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            connection.Select(req, null);
            List<Modèle.Service> lesServices = new List<Modèle.Service> { };
            while (connection.Read())
            {
                lesServices.Add(new Modèle.Service((int)connection.Field("IDSERVICE"), (string)connection.Field("NOM")));
            }
            connection.Close();
            return lesServices;
        }

        /// <summary>
        /// Permet d'avoir la table de donnée des Absences d'un Personnel
        /// </summary>
        /// <param name="id">Id du personnel</param>
        /// <returns>La table de données dt</returns>
        public static DataTable GetAbsences(int id)
        {
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            DataTable dt = connection.FillData("SELECT absence.*, motif.LIBELLE as MOTIF from absence JOIN motif ON absence.IDMOTIF = motif.IDMOTIF WHERE IDPERSONNEL="+id);
            connection.Close();
            return dt;
        }
        /// <summary>
        /// Met à jour les informations d'un Personnel
        /// </summary>
        /// <param name="personnel">Objet de type Personnel contenant toutes les information sur le Personnel choisit</param>
        /// <returns>vrai si la requête est éxécuté</returns>
        public static bool UpdatePersonnel(Modèle.Personnel personnel)
        {
            string req = "UPDATE personnel ";
            req += "SET IDSERVICE=@idService, NOM=@nom, PRENOM=@prenom, TEL=@tel, MAIL=@mail ";
            req += "WHERE IDPERSONNEL=@idPersonnel;";
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            connection.Update(req, new Dictionary<string, object> { ["@idPersonnel"] = personnel.Id, ["@idService"] = personnel.IdService, ["@nom"] = personnel.Nom, ["@prenom"] = personnel.Prenom, ["@tel"] = personnel.Tel, ["@mail"] = personnel.Mail });
            connection.Close();
            return true;
        }

        /// <summary>
        /// Permet de supprimer un Personnel
        /// </summary>
        /// <param name="id">Id du personnel choisit</param>
        /// <returns>Vrai si la requête est éxécuté</returns>
        public static bool DeletePersonnel(int id)
        {
            string req = "DELETE FROM personnel WHERE IDPERSONNEL = @idPersonnel;";
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            connection.Update(req, new Dictionary<string, object> { ["@idPersonnel"] = id });
            connection.Close();
            return true;
        }
        /// <summary>
        /// Permet d'ajouteur un Personnel
        /// </summary>
        /// <param name="personnel">Objet de type Personnel contenant toutes les information sur le Personnel choisit</param>
        /// <returns>Vrai si la requête est éxécuté</returns>
        public static bool AddPersonnel(Modèle.Personnel personnel)
        {
            string req = "INSERT INTO personnel(IDSERVICE, NOM, PRENOM, TEL, MAIL) ";
            req += "VALUES (@idService, @nom, @prenom, @tel, @mail);";
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            connection.Update(req, new Dictionary<string, object> { ["@idService"] = personnel.IdService, ["@nom"] = personnel.Nom, ["@prenom"] = personnel.Prenom, ["@tel"] = personnel.Tel, ["@mail"] = personnel.Mail, ["@idPersonnel"] = personnel.Id });
            connection.Close();
            return true;
        }
        /// <summary>
        /// Ajoute une absence à la base de donnée
        /// </summary>
        /// <param name="absence">Objet de type Absence contenant les informations nécéssaire</param>
        /// <returns>Vrai si la requête est éxécuté</returns>
        public static bool AddAbsence(Modèle.Absence absence)
        {
            string req = "INSERT INTO absence(IDPERSONNEL, DATEDEBUT, IDMOTIF, DATEFIN) ";
            req += "VALUES (@idPersonnel, @dateDebut, @idMotif, @dateFin);";
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            connection.Update(req, new Dictionary<string, object> { ["@idPersonnel"] = absence.IdPersonnel, ["@dateDebut"] = absence.DateDebut.ToString("yyyy'-'MM'-'dd"), ["@idMotif"] = absence.IdMotif, ["@dateFin"] = absence.DateFin.ToString("yyyy'-'MM'-'dd")});
            connection.Close();
            return true;
        }
        /// <summary>
        /// Met à jour les informations concernant une absence
        /// </summary>
        /// <param name="absence">Contient les informations de l'absence à jour</param>
        /// <param name="oldDate">Contient l'ancienne date de l'absence</param>
        /// <returns>Vrai si la demande est éxécuté</returns>
        public static bool UpdateAbsence(Modèle.Absence absence, DateTime oldDate)
        {
            string req = "UPDATE absence ";
            req += "SET DATEDEBUT=@dateDebut, IDMOTIF=@idMotif, DATEFIN=@dateFin ";
            req += "WHERE IDPERSONNEL=@idPersonnel AND DATEDEBUT=@oldDate;";
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            connection.Update(req, new Dictionary<string, object> { ["@idPersonnel"] = absence.IdPersonnel, ["@oldDate"] = oldDate.ToString("yyyy'-'MM'-'dd"), ["@dateDebut"] = absence.DateDebut.ToString("yyyy'-'MM'-'dd"), ["@idMotif"] = absence.IdMotif, ["@dateFin"] = absence.DateFin.ToString("yyyy'-'MM'-'dd") });
            connection.Close();
            return true;
        }
        /// <summary>
        /// Permet de supprimer une Absence
        /// </summary>
        /// <param name="id">Id du Personnel lié a l'absence</param>
        /// <param name="datedebut">Date de début de l'absence</param>
        /// <returns>Vrai si la demande est éxécuté</returns>
        public static bool DeleteAbsence(int id, DateTime datedebut)
        {
            string req = "DELETE FROM absence WHERE IDPERSONNEL = @idPersonnel AND DATEDEBUT = @dateDebut;";
            ConnexionDB connection = ConnexionDB.GetInstance(connectionString);
            connection.Update(req, new Dictionary<string, object> { ["@idPersonnel"] = id, ["@dateDebut"] = datedebut.ToString("yyyy'-'MM'-'dd") });
            connection.Close();
            return true;
        }
    }
}
