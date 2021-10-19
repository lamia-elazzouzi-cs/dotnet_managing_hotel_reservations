
namespace GestionHotel
{
    partial class Acceuil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reservations = new System.Windows.Forms.Button();
            this.btn_utilisateurs = new System.Windows.Forms.Button();
            this.btn_chambres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reservations);
            this.groupBox1.Controls.Add(this.btn_utilisateurs);
            this.groupBox1.Controls.Add(this.btn_chambres);
            this.groupBox1.Location = new System.Drawing.Point(387, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Principal";
            // 
            // btn_reservations
            // 
            this.btn_reservations.Location = new System.Drawing.Point(36, 177);
            this.btn_reservations.Name = "btn_reservations";
            this.btn_reservations.Size = new System.Drawing.Size(124, 36);
            this.btn_reservations.TabIndex = 2;
            this.btn_reservations.Text = "Réservations";
            this.btn_reservations.UseVisualStyleBackColor = true;
            this.btn_reservations.Click += new System.EventHandler(this.btn_reservations_Click);
            // 
            // btn_utilisateurs
            // 
            this.btn_utilisateurs.Location = new System.Drawing.Point(36, 63);
            this.btn_utilisateurs.Name = "btn_utilisateurs";
            this.btn_utilisateurs.Size = new System.Drawing.Size(124, 36);
            this.btn_utilisateurs.TabIndex = 0;
            this.btn_utilisateurs.Text = "Utilisateurs";
            this.btn_utilisateurs.UseVisualStyleBackColor = true;
            this.btn_utilisateurs.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_chambres
            // 
            this.btn_chambres.Location = new System.Drawing.Point(36, 121);
            this.btn_chambres.Name = "btn_chambres";
            this.btn_chambres.Size = new System.Drawing.Size(124, 36);
            this.btn_chambres.TabIndex = 1;
            this.btn_chambres.Text = "Chambres";
            this.btn_chambres.UseVisualStyleBackColor = true;
            this.btn_chambres.Click += new System.EventHandler(this.btn_chambres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenu";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(846, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "Déconnexion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 454);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reservations;
        private System.Windows.Forms.Button btn_utilisateurs;
        private System.Windows.Forms.Button btn_chambres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}