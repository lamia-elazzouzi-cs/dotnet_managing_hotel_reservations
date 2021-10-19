
namespace GestionHotel
{
    partial class Reservations
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
            this.btn_acceuil = new System.Windows.Forms.Button();
            this.listViewChambre = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUtilisateur = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ajoutter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualiser = new System.Windows.Forms.Button();
            this.tboxiduser = new System.Windows.Forms.TextBox();
            this.tboxidchambre = new System.Windows.Forms.TextBox();
            this.tboxduree = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_acceuil
            // 
            this.btn_acceuil.Location = new System.Drawing.Point(869, 12);
            this.btn_acceuil.Name = "btn_acceuil";
            this.btn_acceuil.Size = new System.Drawing.Size(97, 41);
            this.btn_acceuil.TabIndex = 2;
            this.btn_acceuil.Text = "Acceuil";
            this.btn_acceuil.UseVisualStyleBackColor = true;
            this.btn_acceuil.Click += new System.EventHandler(this.btn_acceuil_Click);
            // 
            // listViewChambre
            // 
            this.listViewChambre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewChambre.HideSelection = false;
            this.listViewChambre.Location = new System.Drawing.Point(377, 85);
            this.listViewChambre.Name = "listViewChambre";
            this.listViewChambre.Size = new System.Drawing.Size(589, 144);
            this.listViewChambre.TabIndex = 16;
            this.listViewChambre.UseCompatibleStateImageBehavior = false;
            this.listViewChambre.View = System.Windows.Forms.View.Details;
            this.listViewChambre.SelectedIndexChanged += new System.EventHandler(this.listViewChambre_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numero";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Etage";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 100;
            // 
            // listViewUtilisateur
            // 
            this.listViewUtilisateur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewUtilisateur.HideSelection = false;
            this.listViewUtilisateur.Location = new System.Drawing.Point(377, 264);
            this.listViewUtilisateur.Name = "listViewUtilisateur";
            this.listViewUtilisateur.Size = new System.Drawing.Size(589, 144);
            this.listViewUtilisateur.TabIndex = 17;
            this.listViewUtilisateur.UseCompatibleStateImageBehavior = false;
            this.listViewUtilisateur.View = System.Windows.Forms.View.Details;
            this.listViewUtilisateur.SelectedIndexChanged += new System.EventHandler(this.listViewUtilisateur_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nom";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Adresse";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Type";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Numero";
            this.columnHeader10.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tboxduree);
            this.groupBox1.Controls.Add(this.tboxidchambre);
            this.groupBox1.Controls.Add(this.tboxiduser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_ajoutter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 368);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulaire:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Rés:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durée (jours):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Chambre:";
            // 
            // btn_ajoutter
            // 
            this.btn_ajoutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btn_ajoutter.Location = new System.Drawing.Point(10, 323);
            this.btn_ajoutter.Name = "btn_ajoutter";
            this.btn_ajoutter.Size = new System.Drawing.Size(88, 39);
            this.btn_ajoutter.TabIndex = 1;
            this.btn_ajoutter.Text = "Ajoutter";
            this.btn_ajoutter.UseVisualStyleBackColor = true;
            this.btn_ajoutter.Click += new System.EventHandler(this.btn_ajoutter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Utilisateur:";
            // 
            // btn_actualiser
            // 
            this.btn_actualiser.Location = new System.Drawing.Point(768, 12);
            this.btn_actualiser.Name = "btn_actualiser";
            this.btn_actualiser.Size = new System.Drawing.Size(95, 41);
            this.btn_actualiser.TabIndex = 19;
            this.btn_actualiser.Text = "Actualiser";
            this.btn_actualiser.UseVisualStyleBackColor = true;
            this.btn_actualiser.Click += new System.EventHandler(this.btn_actualiser_Click);
            // 
            // tboxiduser
            // 
            this.tboxiduser.Location = new System.Drawing.Point(127, 70);
            this.tboxiduser.Name = "tboxiduser";
            this.tboxiduser.Size = new System.Drawing.Size(199, 26);
            this.tboxiduser.TabIndex = 12;
            // 
            // tboxidchambre
            // 
            this.tboxidchambre.Location = new System.Drawing.Point(127, 117);
            this.tboxidchambre.Name = "tboxidchambre";
            this.tboxidchambre.Size = new System.Drawing.Size(199, 26);
            this.tboxidchambre.TabIndex = 13;
            // 
            // tboxduree
            // 
            this.tboxduree.Location = new System.Drawing.Point(127, 165);
            this.tboxduree.Name = "tboxduree";
            this.tboxduree.Size = new System.Drawing.Size(199, 26);
            this.tboxduree.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 454);
            this.Controls.Add(this.btn_actualiser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewUtilisateur);
            this.Controls.Add(this.listViewChambre);
            this.Controls.Add(this.btn_acceuil);
            this.Name = "Reservations";
            this.Text = "Reservations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_acceuil;
        private System.Windows.Forms.ListView listViewChambre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listViewUtilisateur;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ajoutter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tboxduree;
        private System.Windows.Forms.TextBox tboxidchambre;
        private System.Windows.Forms.TextBox tboxiduser;
        private System.Windows.Forms.Button btn_actualiser;
    }
}