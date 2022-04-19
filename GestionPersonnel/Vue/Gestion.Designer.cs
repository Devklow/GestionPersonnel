
namespace GestionPersonnel.Vue
{
    partial class Gestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.grpAddModStaff = new System.Windows.Forms.GroupBox();
            this.btnModStaff = new System.Windows.Forms.Button();
            this.btnDelStaff = new System.Windows.Forms.Button();
            this.btnAbsStaff = new System.Windows.Forms.Button();
            this.txtSNStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFNStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneStaff = new System.Windows.Forms.TextBox();
            this.txtMailStaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbServiceStaff = new System.Windows.Forms.ComboBox();
            this.btnValidateStaff = new System.Windows.Forms.Button();
            this.btnCancelStaff = new System.Windows.Forms.Button();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.grpAbs = new System.Windows.Forms.GroupBox();
            this.btnAddAbs = new System.Windows.Forms.Button();
            this.btnModAbs = new System.Windows.Forms.Button();
            this.btnDelAbs = new System.Windows.Forms.Button();
            this.btnStaffAbs = new System.Windows.Forms.Button();
            this.grpAddModAbs = new System.Windows.Forms.GroupBox();
            this.dtpStartAbs = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtbEndAbs = new System.Windows.Forms.DateTimePicker();
            this.cmbReasonAbs = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnValidateAbs = new System.Windows.Forms.Button();
            this.btnCancelAbs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpStaff.SuspendLayout();
            this.grpAddModStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.grpAbs.SuspendLayout();
            this.grpAddModAbs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(6, 19);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(630, 240);
            this.dataGrid1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 485);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.grpAddModStaff);
            this.tabPage1.Controls.Add(this.grpStaff);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personnel";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.grpAddModAbs);
            this.tabPage2.Controls.Add(this.grpAbs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Absences";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(6, 264);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Ajouter";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpStaff
            // 
            this.grpStaff.Controls.Add(this.btnAbsStaff);
            this.grpStaff.Controls.Add(this.btnDelStaff);
            this.grpStaff.Controls.Add(this.btnModStaff);
            this.grpStaff.Controls.Add(this.btnAddStaff);
            this.grpStaff.Controls.Add(this.dataGrid1);
            this.grpStaff.Location = new System.Drawing.Point(3, 6);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Size = new System.Drawing.Size(649, 289);
            this.grpStaff.TabIndex = 2;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Personnel";
            // 
            // grpAddModStaff
            // 
            this.grpAddModStaff.Controls.Add(this.btnCancelStaff);
            this.grpAddModStaff.Controls.Add(this.btnValidateStaff);
            this.grpAddModStaff.Controls.Add(this.cmbServiceStaff);
            this.grpAddModStaff.Controls.Add(this.label5);
            this.grpAddModStaff.Controls.Add(this.txtMailStaff);
            this.grpAddModStaff.Controls.Add(this.label4);
            this.grpAddModStaff.Controls.Add(this.txtPhoneStaff);
            this.grpAddModStaff.Controls.Add(this.label3);
            this.grpAddModStaff.Controls.Add(this.txtFNStaff);
            this.grpAddModStaff.Controls.Add(this.label2);
            this.grpAddModStaff.Controls.Add(this.label1);
            this.grpAddModStaff.Controls.Add(this.txtSNStaff);
            this.grpAddModStaff.Enabled = false;
            this.grpAddModStaff.Location = new System.Drawing.Point(9, 301);
            this.grpAddModStaff.Name = "grpAddModStaff";
            this.grpAddModStaff.Size = new System.Drawing.Size(643, 135);
            this.grpAddModStaff.TabIndex = 3;
            this.grpAddModStaff.TabStop = false;
            this.grpAddModStaff.Text = "Ajouter/Modifier";
            this.grpAddModStaff.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnModStaff
            // 
            this.btnModStaff.Location = new System.Drawing.Point(87, 264);
            this.btnModStaff.Name = "btnModStaff";
            this.btnModStaff.Size = new System.Drawing.Size(75, 23);
            this.btnModStaff.TabIndex = 2;
            this.btnModStaff.Text = "Modifier";
            this.btnModStaff.UseVisualStyleBackColor = true;
            // 
            // btnDelStaff
            // 
            this.btnDelStaff.Location = new System.Drawing.Point(168, 264);
            this.btnDelStaff.Name = "btnDelStaff";
            this.btnDelStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDelStaff.TabIndex = 3;
            this.btnDelStaff.Text = "Supprimer";
            this.btnDelStaff.UseVisualStyleBackColor = true;
            // 
            // btnAbsStaff
            // 
            this.btnAbsStaff.Location = new System.Drawing.Point(249, 264);
            this.btnAbsStaff.Name = "btnAbsStaff";
            this.btnAbsStaff.Size = new System.Drawing.Size(122, 23);
            this.btnAbsStaff.TabIndex = 4;
            this.btnAbsStaff.Text = "Gerer les absences";
            this.btnAbsStaff.UseVisualStyleBackColor = true;
            this.btnAbsStaff.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSNStaff
            // 
            this.txtSNStaff.Location = new System.Drawing.Point(9, 32);
            this.txtSNStaff.Name = "txtSNStaff";
            this.txtSNStaff.Size = new System.Drawing.Size(174, 20);
            this.txtSNStaff.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom :";
            // 
            // txtFNStaff
            // 
            this.txtFNStaff.Location = new System.Drawing.Point(9, 75);
            this.txtFNStaff.Name = "txtFNStaff";
            this.txtFNStaff.Size = new System.Drawing.Size(174, 20);
            this.txtFNStaff.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Téléphone :";
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.Location = new System.Drawing.Point(243, 32);
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.Size = new System.Drawing.Size(174, 20);
            this.txtPhoneStaff.TabIndex = 5;
            // 
            // txtMailStaff
            // 
            this.txtMailStaff.Location = new System.Drawing.Point(243, 75);
            this.txtMailStaff.Name = "txtMailStaff";
            this.txtMailStaff.Size = new System.Drawing.Size(174, 20);
            this.txtMailStaff.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Service :";
            // 
            // cmbServiceStaff
            // 
            this.cmbServiceStaff.FormattingEnabled = true;
            this.cmbServiceStaff.Location = new System.Drawing.Point(453, 31);
            this.cmbServiceStaff.Name = "cmbServiceStaff";
            this.cmbServiceStaff.Size = new System.Drawing.Size(184, 21);
            this.cmbServiceStaff.TabIndex = 9;
            // 
            // btnValidateStaff
            // 
            this.btnValidateStaff.Location = new System.Drawing.Point(524, 106);
            this.btnValidateStaff.Name = "btnValidateStaff";
            this.btnValidateStaff.Size = new System.Drawing.Size(113, 23);
            this.btnValidateStaff.TabIndex = 10;
            this.btnValidateStaff.Text = "Ajouter/Modifier";
            this.btnValidateStaff.UseVisualStyleBackColor = true;
            // 
            // btnCancelStaff
            // 
            this.btnCancelStaff.Location = new System.Drawing.Point(443, 106);
            this.btnCancelStaff.Name = "btnCancelStaff";
            this.btnCancelStaff.Size = new System.Drawing.Size(75, 23);
            this.btnCancelStaff.TabIndex = 11;
            this.btnCancelStaff.Text = "Annuler";
            this.btnCancelStaff.UseVisualStyleBackColor = true;
            // 
            // dataGrid2
            // 
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Location = new System.Drawing.Point(6, 19);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(630, 240);
            this.dataGrid2.TabIndex = 0;
            // 
            // grpAbs
            // 
            this.grpAbs.Controls.Add(this.btnStaffAbs);
            this.grpAbs.Controls.Add(this.btnDelAbs);
            this.grpAbs.Controls.Add(this.btnModAbs);
            this.grpAbs.Controls.Add(this.btnAddAbs);
            this.grpAbs.Controls.Add(this.dataGrid2);
            this.grpAbs.Location = new System.Drawing.Point(3, 6);
            this.grpAbs.Name = "grpAbs";
            this.grpAbs.Size = new System.Drawing.Size(649, 289);
            this.grpAbs.TabIndex = 1;
            this.grpAbs.TabStop = false;
            this.grpAbs.Text = "Absences";
            // 
            // btnAddAbs
            // 
            this.btnAddAbs.Location = new System.Drawing.Point(6, 264);
            this.btnAddAbs.Name = "btnAddAbs";
            this.btnAddAbs.Size = new System.Drawing.Size(75, 23);
            this.btnAddAbs.TabIndex = 1;
            this.btnAddAbs.Text = "Ajouter";
            this.btnAddAbs.UseVisualStyleBackColor = true;
            // 
            // btnModAbs
            // 
            this.btnModAbs.Location = new System.Drawing.Point(87, 264);
            this.btnModAbs.Name = "btnModAbs";
            this.btnModAbs.Size = new System.Drawing.Size(75, 23);
            this.btnModAbs.TabIndex = 2;
            this.btnModAbs.Text = "Modifier";
            this.btnModAbs.UseVisualStyleBackColor = true;
            // 
            // btnDelAbs
            // 
            this.btnDelAbs.Location = new System.Drawing.Point(168, 264);
            this.btnDelAbs.Name = "btnDelAbs";
            this.btnDelAbs.Size = new System.Drawing.Size(75, 23);
            this.btnDelAbs.TabIndex = 3;
            this.btnDelAbs.Text = "Supprimer";
            this.btnDelAbs.UseVisualStyleBackColor = true;
            // 
            // btnStaffAbs
            // 
            this.btnStaffAbs.Location = new System.Drawing.Point(249, 264);
            this.btnStaffAbs.Name = "btnStaffAbs";
            this.btnStaffAbs.Size = new System.Drawing.Size(113, 23);
            this.btnStaffAbs.TabIndex = 4;
            this.btnStaffAbs.Text = "Gerer le personnel";
            this.btnStaffAbs.UseVisualStyleBackColor = true;
            this.btnStaffAbs.Click += new System.EventHandler(this.button10_Click);
            // 
            // grpAddModAbs
            // 
            this.grpAddModAbs.Controls.Add(this.btnCancelAbs);
            this.grpAddModAbs.Controls.Add(this.btnValidateAbs);
            this.grpAddModAbs.Controls.Add(this.label9);
            this.grpAddModAbs.Controls.Add(this.cmbReasonAbs);
            this.grpAddModAbs.Controls.Add(this.label7);
            this.grpAddModAbs.Controls.Add(this.dtbEndAbs);
            this.grpAddModAbs.Controls.Add(this.label6);
            this.grpAddModAbs.Controls.Add(this.dtpStartAbs);
            this.grpAddModAbs.Enabled = false;
            this.grpAddModAbs.Location = new System.Drawing.Point(9, 301);
            this.grpAddModAbs.Name = "grpAddModAbs";
            this.grpAddModAbs.Size = new System.Drawing.Size(643, 135);
            this.grpAddModAbs.TabIndex = 2;
            this.grpAddModAbs.TabStop = false;
            this.grpAddModAbs.Text = "Ajouter/Modifier";
            // 
            // dtpStartAbs
            // 
            this.dtpStartAbs.Location = new System.Drawing.Point(9, 45);
            this.dtpStartAbs.Name = "dtpStartAbs";
            this.dtpStartAbs.Size = new System.Drawing.Size(200, 20);
            this.dtpStartAbs.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date de début :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date de fin :";
            // 
            // dtbEndAbs
            // 
            this.dtbEndAbs.Location = new System.Drawing.Point(245, 45);
            this.dtbEndAbs.Name = "dtbEndAbs";
            this.dtbEndAbs.Size = new System.Drawing.Size(200, 20);
            this.dtbEndAbs.TabIndex = 2;
            // 
            // cmbReasonAbs
            // 
            this.cmbReasonAbs.FormattingEnabled = true;
            this.cmbReasonAbs.Location = new System.Drawing.Point(467, 45);
            this.cmbReasonAbs.Name = "cmbReasonAbs";
            this.cmbReasonAbs.Size = new System.Drawing.Size(165, 21);
            this.cmbReasonAbs.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Motif :";
            // 
            // btnValidateAbs
            // 
            this.btnValidateAbs.Location = new System.Drawing.Point(524, 106);
            this.btnValidateAbs.Name = "btnValidateAbs";
            this.btnValidateAbs.Size = new System.Drawing.Size(113, 23);
            this.btnValidateAbs.TabIndex = 7;
            this.btnValidateAbs.Text = "Ajouter/Modifier";
            this.btnValidateAbs.UseVisualStyleBackColor = true;
            this.btnValidateAbs.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnCancelAbs
            // 
            this.btnCancelAbs.Location = new System.Drawing.Point(443, 106);
            this.btnCancelAbs.Name = "btnCancelAbs";
            this.btnCancelAbs.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAbs.TabIndex = 8;
            this.btnCancelAbs.Text = "Annuler";
            this.btnCancelAbs.UseVisualStyleBackColor = true;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 482);
            this.Controls.Add(this.tabControl1);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpStaff.ResumeLayout(false);
            this.grpAddModStaff.ResumeLayout(false);
            this.grpAddModStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.grpAbs.ResumeLayout(false);
            this.grpAddModAbs.ResumeLayout(false);
            this.grpAddModAbs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.GroupBox grpAddModStaff;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.Button btnCancelStaff;
        private System.Windows.Forms.Button btnValidateStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMailStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFNStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSNStaff;
        private System.Windows.Forms.Button btnAbsStaff;
        private System.Windows.Forms.Button btnDelStaff;
        private System.Windows.Forms.Button btnModStaff;
        private System.Windows.Forms.GroupBox grpAddModAbs;
        private System.Windows.Forms.GroupBox grpAbs;
        private System.Windows.Forms.Button btnStaffAbs;
        private System.Windows.Forms.Button btnDelAbs;
        private System.Windows.Forms.Button btnModAbs;
        private System.Windows.Forms.Button btnAddAbs;
        private System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.Button btnCancelAbs;
        private System.Windows.Forms.Button btnValidateAbs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbReasonAbs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtbEndAbs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartAbs;
        private System.Windows.Forms.ComboBox cmbServiceStaff;
        private System.Windows.Forms.TextBox txtPhoneStaff;
    }
}