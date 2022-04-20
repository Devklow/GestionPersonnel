using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonnel.Modèle
{
    /// <summary>
    /// Classe Absence
    /// </summary>
    class Absence
    {
        private int idPersonnel;
        private DateTime dateDebut;
        private int idMotif;
        private DateTime dateFin;

        /// <summary>
        /// Getter sur l'id du personnel
        /// </summary>
        public int IdPersonnel { get => idPersonnel;  }
        /// <summary>
        /// Getter sur l'id du motif
        /// </summary>
        public int IdMotif { get => idMotif; }
        /// <summary>
        /// Getter sur la date de début
        /// </summary>
        public DateTime DateDebut { get => dateDebut; }
        /// <summary>
        /// Getter sur la Date de fin
        /// </summary>
        public DateTime DateFin { get => dateFin; }

        /// <summary>
        /// Constructeur de l'absence
        /// </summary>
        /// <param name="idPersonnel">Id du Personnel</param>
        /// <param name="dateDebut">Date de début de l'absence</param>
        /// <param name="idMotif">Id du motif de l'absence</param>
        /// <param name="dateFin">Date de fin de l'absence</param>
        public Absence(int idPersonnel, DateTime dateDebut, int idMotif, DateTime dateFin)
        {
            this.idPersonnel = idPersonnel;
            this.dateDebut = dateDebut;
            this.idMotif = idMotif;
            this.dateFin = dateFin;
        }

    }
}
