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
    /// Fenêtre de Gestion du Personnel et Absences
    /// </summary>
    public partial class Gestion : Form
    {

        private int Mode = 0;

        /// <summary>
        /// Initialise la fenêtre
        /// </summary>
        public Gestion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Met a jour le DataGridView du Personnel
        /// </summary>
        private void UpdateDataGrid()
        {
            this.personnelTableAdapter.Fill(this.gestpersoDataSet.personnel);
            dataGrid1.Update();
            dataGrid1.Refresh();
        }

        /// <summary>
        /// Met à jour le DataGridView des absences
        /// </summary>
        private void UpdateDataGrid2()
        {
            dataGrid2.DataSource = Dal.GestDonneesDB.GetAbsences((int)dataGrid1.SelectedRows[0].Cells[0].Value);
            dataGrid2.Columns["IDMOTIF"].Visible = false;
            dataGrid2.Columns["IDPERSONNEL"].Visible = false;
            dataGrid2.Update();
            dataGrid2.Refresh();
        }
        /// <summary>
        /// Script s'éxécutant au chargement de la fenêtre
        /// </summary>
        /// <param name="sender">sender de type objet</param>
        /// <param name="e">e de type EventArgs</param>
        private void Gestion_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestpersoDataSet.personnel'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.personnelTableAdapter.Fill(this.gestpersoDataSet.personnel);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cmbServiceStaff.DataSource = Dal.GestDonneesDB.GetLesServices();
            cmbReasonAbs.DataSource = Dal.GestDonneesDB.GetLesMotifs();
        }

        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton Ajouter dans l'onglet Personnel
        /// Permet de passer en mode Ajouter un Personnel
        /// </summary>
        /// <param name="sender">sender de type objet</param>
        /// <param name="e">e de type EventArgs</param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Mode = 1;
            grpAddModStaff.Text = "Ajouter";
            btnValidateStaff.Text = "Ajouter";
            grpStaff.Enabled = false;
            grpAddModStaff.Enabled = true;
        }

        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Gerer les absences"
        /// Permet de changer d'onglet si un Personnel est séléctionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGrid1.SelectedRows.Count == 1)
            {
                tabControl1.SelectedTab = tabPage2;
                UpdateDataGrid2();
            }

        }
        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Gérer le Personnel"
        /// Permet de changer d'onglet et retourner la liste du Personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton Ajouter/Modifier dans l'onglet Absences
        /// Permet d'ajouter ou modifier une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            if (dtpStartAbs.Value <= dtpEndAbs.Value)
            {
                if (this.Mode == 3)
                {
                    if (Dal.GestDonneesDB.AddAbsence(new Modèle.Absence((int)dataGrid1.SelectedRows[0].Cells[0].Value, dtpStartAbs.Value, ((Modèle.Motif)cmbReasonAbs.SelectedItem).Id, dtpEndAbs.Value)))
                    {
                        UpdateDataGrid2();
                        btnCancelAbs_Click(null, null);
                    }
                }
                else
                {
                    if (Dal.GestDonneesDB.UpdateAbsence(new Modèle.Absence((int)dataGrid1.SelectedRows[0].Cells[0].Value, dtpStartAbs.Value, ((Modèle.Motif)cmbReasonAbs.SelectedItem).Id, dtpEndAbs.Value), (DateTime)dataGrid2.SelectedRows[0].Cells[1].Value))
                    {
                        UpdateDataGrid2();
                        btnCancelAbs_Click(null, null);
                    }
                }
            }
            else
            {
                errLblAbs.Text = "Erreur : Date de fin inférieur à la date de début";
            }
        }

        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton Ajouter/Modifier dans l'onglet Personnel
        /// Permet d'ajouter ou modifier une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidateStaff_Click(object sender, EventArgs e)
        {
            if(this.Mode == 1) {
                if (Dal.GestDonneesDB.AddPersonnel(new Modèle.Personnel(0, ((Modèle.Service)cmbServiceStaff.SelectedItem).Id, txtSNStaff.Text, txtFNStaff.Text, txtPhoneStaff.Text, txtMailStaff.Text)))
                {
                    UpdateDataGrid();
                    btnCancelStaff_Click(null, null);
                }
            }
            else
            {
                if (Dal.GestDonneesDB.UpdatePersonnel(new Modèle.Personnel((int)dataGrid1.SelectedRows[0].Cells[0].Value, ((Modèle.Service)cmbServiceStaff.SelectedItem).Id, txtSNStaff.Text, txtFNStaff.Text, txtPhoneStaff.Text, txtMailStaff.Text)))
                {
                    UpdateDataGrid();
                    btnCancelStaff_Click(null, null);
                }
            }
        }

        /// <summary>
        /// Fonction s'éxecutant au clique sur le bouton Annuler dans l'onglet Personnel
        /// Permet d'annuler l'ajout ou la modification d'un Personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelStaff_Click(object sender, EventArgs e)
        {
            this.Mode = 0;
            grpAddModStaff.Text = "Ajouter/Modifier";
            btnValidateStaff.Text = "Ajouter/Modifier";
            grpAddModStaff.Enabled = false;
            grpStaff.Enabled = true;
            txtFNStaff.Text = "";
            txtMailStaff.Text = "";
            txtPhoneStaff.Text = "";
            txtSNStaff.Text = "";
        }

        /// <summary>
        /// Fonction s'éxecutant au clique sur le bouton supprimer dans l'onglet Personnel
        /// Permet de supprimer un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            if (Dal.GestDonneesDB.DeletePersonnel((int)dataGrid1.SelectedRows[0].Cells[0].Value))
            {
                this.personnelTableAdapter.Fill(this.gestpersoDataSet.personnel);
                dataGrid1.Update();
                dataGrid1.Refresh();
            }
        }

        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Modifier" dans l'onglet Personnel
        /// Permet de passer en mode Modification d'un Personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModStaff_Click(object sender, EventArgs e)
        {
            if (dataGrid1.SelectedRows.Count == 1)
            {
                this.Mode = 2;
                grpStaff.Enabled = false;
                grpAddModStaff.Text = "Modifier";
                btnValidateStaff.Text = "Modifier";
                grpAddModStaff.Enabled = true;
                Modèle.Personnel personnel = new Modèle.Personnel((int)dataGrid1.SelectedRows[0].Cells[0].Value, (int)dataGrid1.SelectedRows[0].Cells[1].Value, (string)dataGrid1.SelectedRows[0].Cells[2].Value, (string)dataGrid1.SelectedRows[0].Cells[3].Value, (string)dataGrid1.SelectedRows[0].Cells[5].Value, (string)dataGrid1.SelectedRows[0].Cells[6].Value);
                txtFNStaff.Text = personnel.Prenom;
                txtSNStaff.Text = personnel.Nom;
                txtMailStaff.Text = personnel.Mail;
                txtPhoneStaff.Text = personnel.Tel;
                cmbServiceStaff.SelectedIndex = personnel.IdService - 1;
            }
        }

        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Ajouter" dans l'onglet absence
        /// Permet de passer en mode ajouter une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAbs_Click(object sender, EventArgs e)
        {
            grpAbs.Enabled = false;
            grpAddModAbs.Enabled = true;
            grpAddModAbs.Text = "Ajouter";
            btnValidateAbs.Text = "Ajouter";
            this.Mode = 3;
        }

        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Annuler" dans l'onglet absence
        /// Permet d'annuler l'ajout ou la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAbs_Click(object sender, EventArgs e)
        {
            grpAbs.Enabled = true;
            grpAddModAbs.Enabled = false;
            grpAddModAbs.Text = "Ajouter/Modifier";
            btnValidateAbs.Text = "Ajouter/Modifier";
            errLblAbs.Text = "";
            this.Mode = 0;
        }
        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "Modifier" dans l'onglet absence
        /// Permet de passer en mode modifier une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModAbs_Click(object sender, EventArgs e)
        {
            grpAbs.Enabled = false;
            grpAddModAbs.Enabled = true;
            grpAddModAbs.Text = "Modifier";
            btnValidateAbs.Text = "Modifier";
            dtpStartAbs.Value = (DateTime)dataGrid2.SelectedRows[0].Cells[1].Value;
            dtpEndAbs.Value = (DateTime)dataGrid2.SelectedRows[0].Cells[3].Value;
            cmbReasonAbs.SelectedIndex = (int)dataGrid2.SelectedRows[0].Cells[2].Value-1;
            this.Mode = 4;
        }

        /// <summary>
        /// Fonction s'éxécutant au clique sur le bouton "supprimer" dans l'onglet absence
        /// Permet de supprimer un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelAbs_Click(object sender, EventArgs e)
        {
            if (dataGrid2.SelectedRows.Count == 1)
            {
                if(Dal.GestDonneesDB.DeleteAbsence((int)dataGrid2.SelectedRows[0].Cells[0].Value, (DateTime)dataGrid2.SelectedRows[0].Cells[1].Value))
                {
                    UpdateDataGrid2();
                }
            }
        }
    }
}
