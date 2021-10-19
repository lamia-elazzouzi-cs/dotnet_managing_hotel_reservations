
namespace GestionHotel
{
    partial class Utilisateurs
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajoutter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.textboxnom = new System.Windows.Forms.TextBox();
            this.textboxadr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxtype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_actualiser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_acceuil
            // 
            this.btn_acceuil.Location = new System.Drawing.Point(869, 12);
            this.btn_acceuil.Name = "btn_acceuil";
            this.btn_acceuil.Size = new System.Drawing.Size(97, 41);
            this.btn_acceuil.TabIndex = 1;
            this.btn_acceuil.Text = "Acceuil";
            this.btn_acceuil.UseVisualStyleBackColor = true;
            this.btn_acceuil.Click += new System.EventHandler(this.btn_acceuil_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(377, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 368);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresse";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Numero";
            this.columnHeader5.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textboxnum);
            this.groupBox1.Controls.Add(this.textboxtype);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textboxadr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textboxnom);
            this.groupBox1.Controls.Add(this.btn_supprimer);
            this.groupBox1.Controls.Add(this.btn_modifier);
            this.groupBox1.Controls.Add(this.btn_ajoutter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 368);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulaire:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
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
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btn_modifier.Location = new System.Drawing.Point(104, 323);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(88, 39);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btn_supprimer.Location = new System.Drawing.Point(238, 323);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(88, 39);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // textboxnom
            // 
            this.textboxnom.Location = new System.Drawing.Point(108, 70);
            this.textboxnom.Name = "textboxnom";
            this.textboxnom.Size = new System.Drawing.Size(164, 26);
            this.textboxnom.TabIndex = 4;
            // 
            // textboxadr
            // 
            this.textboxadr.Location = new System.Drawing.Point(108, 120);
            this.textboxadr.Name = "textboxadr";
            this.textboxadr.Size = new System.Drawing.Size(164, 26);
            this.textboxadr.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresse:";
            // 
            // textboxtype
            // 
            this.textboxtype.Location = new System.Drawing.Point(108, 171);
            this.textboxtype.Name = "textboxtype";
            this.textboxtype.Size = new System.Drawing.Size(164, 26);
            this.textboxtype.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type:";
            // 
            // textboxnum
            // 
            this.textboxnum.Location = new System.Drawing.Point(108, 215);
            this.textboxnum.Name = "textboxnum";
            this.textboxnum.Size = new System.Drawing.Size(164, 26);
            this.textboxnum.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numéro:";
            // 
            // btn_actualiser
            // 
            this.btn_actualiser.Location = new System.Drawing.Point(768, 12);
            this.btn_actualiser.Name = "btn_actualiser";
            this.btn_actualiser.Size = new System.Drawing.Size(95, 41);
            this.btn_actualiser.TabIndex = 12;
            this.btn_actualiser.Text = "Actualiser";
            this.btn_actualiser.UseVisualStyleBackColor = true;
            this.btn_actualiser.Click += new System.EventHandler(this.btn_actualiser_Click);
            // 
            // Utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 454);
            this.Controls.Add(this.btn_actualiser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_acceuil);
            this.Name = "Utilisateurs";
            this.Text = "Utilisateurs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_acceuil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxnum;
        private System.Windows.Forms.TextBox textboxtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxadr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxnom;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajoutter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualiser;
    }
}