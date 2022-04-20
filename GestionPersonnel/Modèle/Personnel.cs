namespace GestionPersonnel.Modèle
{
    /// <summary>
    /// Classe Personnel
    /// </summary>
    class Personnel
    {
        private int id;
        private int idService;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;

        /// <summary>
        /// Getter sur l'id du personnel
        /// </summary>
        public int Id { get => id; }
        /// <summary>
        /// Getter sur l'id du service
        /// </summary>
        public int IdService { get => idService; }
        /// <summary>
        /// Getter sur le nom
        /// </summary>
        public string Nom { get => nom; }
        /// <summary>
        /// Getter sur le prénom
        /// </summary>
        public string Prenom { get => prenom; }
        /// <summary>
        /// Getter sur le numéro de téléphone
        /// </summary>
        public string Tel { get => tel; }
        /// <summary>
        /// Gettet sur le mail
        /// </summary>
        public string Mail { get => mail; }

        /// <summary>
        /// Constructeur du Personnel
        /// </summary>
        /// <param name="id">Id du personnel</param>
        /// <param name="idService">Id du service</param>
        /// <param name="nom">Nom</param>
        /// <param name="prenom">Prénom</param>
        /// <param name="tel">Téléphone</param>
        /// <param name="mail">Adresse mail</param>
        public Personnel(int id, int idService, string nom, string prenom, string tel, string mail)
        {
            this.id = id;
            this.idService = idService;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }
    }
}
