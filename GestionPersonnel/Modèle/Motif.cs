using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Classe Motif
/// </summary>
namespace GestionPersonnel.Modèle
{
    class Motif
    {
        private int id;
        private string nom;

        /// <summary>
        /// Getter sur l'id du motif
        /// </summary>
        public int Id { get => id; }
        /// <summary>
        /// getter sur le nom du motif
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Constructeur d'un motif
        /// </summary>
        /// <param name="id">Id du motif</param>
        /// <param name="nom">Libellé du motif</param>
        public Motif(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        /// <summary>
        /// @Overide ToString()
        /// </summary>
        /// <returns>le nom du motif</returns>
        public override string ToString()
        {
            return this.nom;
        }

    }
}
