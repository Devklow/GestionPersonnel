using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonnel.Modèle
{
    /// <summary>
    /// Classe Service
    /// </summary>
    class Service
    {
        private int id;
        private string nom;

        /// <summary>
        /// Getter sur l'id du service
        /// </summary>
        public int Id { get => id; }
        /// <summary>
        /// Getter sur le Nom du service
        /// </summary>
        public string Nom { get => nom; }
        /// <summary>
        /// Constructeur du service
        /// </summary>
        /// <param name="id">Id du service</param>
        /// <param name="nom">Nom du service</param>
        public Service(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        /// <summary>
        /// @Override de ToString()
        /// </summary>
        /// <returns>Renvoie le nom du service</returns>
        public override string ToString()
        {
            return this.nom;
        }
    }
}
