using System.Windows.Forms;

namespace Transferth
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxTypeEnceinte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBilanThermique = new System.Windows.Forms.Label();
            this.LongueurInt = new System.Windows.Forms.TextBox();
            this.LargeurInt = new System.Windows.Forms.TextBox();
            this.HauteurInt = new System.Windows.Forms.TextBox();
            this.Volume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkSol = new System.Windows.Forms.TextBox();
            this.txtkPlafond = new System.Windows.Forms.TextBox();
            this.txtepParois = new System.Windows.Forms.TextBox();
            this.txtkParois = new System.Windows.Forms.TextBox();
            this.txtResultatBilan = new System.Windows.Forms.TextBox();
            this.txtepPlafond = new System.Windows.Forms.TextBox();
            this.txtepSol = new System.Windows.Forms.TextBox();
            this.txtTempExt = new System.Windows.Forms.TextBox();
            this.txtTempInt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.Calculer = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboBoxSol = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ComboBoxIsolationPlafond = new System.Windows.Forms.ComboBox();
            this.ComboBoxIsolationParois = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.StockProduit = new System.Windows.Forms.TextBox();
            this.labelStockProduit = new System.Windows.Forms.Label();
            this.TypeProduit = new System.Windows.Forms.ComboBox();
            this.TempEntreeProduit = new System.Windows.Forms.TextBox();
            this.labelTempEntreeProduit = new System.Windows.Forms.Label();
            this.labelTypeProduit = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTempsMarche = new System.Windows.Forms.TextBox();
            this.txtCycle = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnImporter = new System.Windows.Forms.Button();
            this.lblNomBilanImporte = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txtNomBilanImporte = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTypeEnceinte
            // 
            this.comboBoxTypeEnceinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeEnceinte.FormattingEnabled = true;
            this.comboBoxTypeEnceinte.Items.AddRange(new object[] {
            "Chambre froide positive",
            "Chambre froide négative"});
            this.comboBoxTypeEnceinte.Location = new System.Drawing.Point(292, 9);
            this.comboBoxTypeEnceinte.Name = "comboBoxTypeEnceinte";
            this.comboBoxTypeEnceinte.Size = new System.Drawing.Size(279, 32);
            this.comboBoxTypeEnceinte.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisir le type d\'enceinte";
            // 
            // labelBilanThermique
            // 
            this.labelBilanThermique.AutoSize = true;
            this.labelBilanThermique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilanThermique.Location = new System.Drawing.Point(12, 81);
            this.labelBilanThermique.Name = "labelBilanThermique";
            this.labelBilanThermique.Size = new System.Drawing.Size(0, 24);
            this.labelBilanThermique.TabIndex = 3;
            // 
            // LongueurInt
            // 
            this.LongueurInt.Location = new System.Drawing.Point(151, 80);
            this.LongueurInt.Name = "LongueurInt";
            this.LongueurInt.Size = new System.Drawing.Size(47, 30);
            this.LongueurInt.TabIndex = 4;
            // 
            // LargeurInt
            // 
            this.LargeurInt.Location = new System.Drawing.Point(151, 159);
            this.LargeurInt.Name = "LargeurInt";
            this.LargeurInt.Size = new System.Drawing.Size(47, 30);
            this.LargeurInt.TabIndex = 5;
            // 
            // HauteurInt
            // 
            this.HauteurInt.Location = new System.Drawing.Point(151, 119);
            this.HauteurInt.Name = "HauteurInt";
            this.HauteurInt.Size = new System.Drawing.Size(47, 30);
            this.HauteurInt.TabIndex = 6;
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(376, 80);
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.Size = new System.Drawing.Size(47, 30);
            this.Volume.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "LongueurInt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "LargeurInt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "HauteurInt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Volume";
            // 
            // txtkSol
            // 
            this.txtkSol.Location = new System.Drawing.Point(135, 102);
            this.txtkSol.Name = "txtkSol";
            this.txtkSol.Size = new System.Drawing.Size(47, 30);
            this.txtkSol.TabIndex = 13;
            // 
            // txtkPlafond
            // 
            this.txtkPlafond.Location = new System.Drawing.Point(135, 67);
            this.txtkPlafond.Name = "txtkPlafond";
            this.txtkPlafond.Size = new System.Drawing.Size(47, 30);
            this.txtkPlafond.TabIndex = 14;
            // 
            // txtepParois
            // 
            this.txtepParois.Location = new System.Drawing.Point(575, 27);
            this.txtepParois.Name = "txtepParois";
            this.txtepParois.Size = new System.Drawing.Size(47, 30);
            this.txtepParois.TabIndex = 16;
            // 
            // txtkParois
            // 
            this.txtkParois.Location = new System.Drawing.Point(135, 27);
            this.txtkParois.Name = "txtkParois";
            this.txtkParois.Size = new System.Drawing.Size(47, 30);
            this.txtkParois.TabIndex = 17;
            // 
            // txtResultatBilan
            // 
            this.txtResultatBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtResultatBilan.Location = new System.Drawing.Point(158, 562);
            this.txtResultatBilan.Multiline = true;
            this.txtResultatBilan.Name = "txtResultatBilan";
            this.txtResultatBilan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultatBilan.Size = new System.Drawing.Size(544, 173);
            this.txtResultatBilan.TabIndex = 18;
            // 
            // txtepPlafond
            // 
            this.txtepPlafond.Location = new System.Drawing.Point(575, 67);
            this.txtepPlafond.Name = "txtepPlafond";
            this.txtepPlafond.Size = new System.Drawing.Size(47, 30);
            this.txtepPlafond.TabIndex = 19;
            // 
            // txtepSol
            // 
            this.txtepSol.Location = new System.Drawing.Point(575, 109);
            this.txtepSol.Name = "txtepSol";
            this.txtepSol.Size = new System.Drawing.Size(47, 30);
            this.txtepSol.TabIndex = 21;
            // 
            // txtTempExt
            // 
            this.txtTempExt.Location = new System.Drawing.Point(263, 44);
            this.txtTempExt.Name = "txtTempExt";
            this.txtTempExt.Size = new System.Drawing.Size(35, 30);
            this.txtTempExt.TabIndex = 22;
            // 
            // txtTempInt
            // 
            this.txtTempInt.Location = new System.Drawing.Point(263, 107);
            this.txtTempInt.Name = "txtTempInt";
            this.txtTempInt.Size = new System.Drawing.Size(35, 30);
            this.txtTempInt.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(21, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Kplafond";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(399, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Epaisseur Sol";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(399, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Epaisseur Parois";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(21, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Ksol";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(399, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Epaisseur Plafond";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(21, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Kparois";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(220, 25);
            this.label22.TabIndex = 49;
            this.label22.Text = "Température extérieure ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label27.Location = new System.Drawing.Point(48, 565);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 25);
            this.label27.TabIndex = 54;
            this.label27.Text = "Bilan Total";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label40.Location = new System.Drawing.Point(200, 30);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(89, 25);
            this.label40.TabIndex = 81;
            this.label40.Text = "W/m2/°c";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label41.Location = new System.Drawing.Point(200, 109);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(89, 25);
            this.label41.TabIndex = 82;
            this.label41.Text = "W/m2/°c";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label42.Location = new System.Drawing.Point(200, 70);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(89, 25);
            this.label42.TabIndex = 83;
            this.label42.Text = "W/m2/°c";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label43.Location = new System.Drawing.Point(656, 30);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(44, 25);
            this.label43.TabIndex = 84;
            this.label43.Text = "mm";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label44.Location = new System.Drawing.Point(656, 66);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(44, 25);
            this.label44.TabIndex = 85;
            this.label44.Text = "mm";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(656, 118);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(44, 25);
            this.label45.TabIndex = 86;
            this.label45.Text = "mm";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(450, 83);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(40, 25);
            this.label46.TabIndex = 87;
            this.label46.Text = "M3";
            // 
            // Calculer
            // 
            this.Calculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Calculer.Location = new System.Drawing.Point(728, 565);
            this.Calculer.Name = "Calculer";
            this.Calculer.Size = new System.Drawing.Size(170, 32);
            this.Calculer.TabIndex = 88;
            this.Calculer.Text = "Calculer";
            this.Calculer.UseVisualStyleBackColor = true;
            this.Calculer.Click += new System.EventHandler(this.Calculer_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(26, 110);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(214, 25);
            this.label47.TabIndex = 89;
            this.label47.Text = "Température intérieure ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LongueurInt);
            this.groupBox1.Controls.Add(this.LargeurInt);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.HauteurInt);
            this.groupBox1.Controls.Add(this.Volume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(7, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 274);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(285, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 129);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComboBoxSol);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.ComboBoxIsolationPlafond);
            this.groupBox2.Controls.Add(this.ComboBoxIsolationParois);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtkSol);
            this.groupBox2.Controls.Add(this.txtkPlafond);
            this.groupBox2.Controls.Add(this.txtepParois);
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.txtkParois);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.txtepPlafond);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Controls.Add(this.txtepSol);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox2.Location = new System.Drawing.Point(517, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 251);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Isolations";
            // 
            // ComboBoxSol
            // 
            this.ComboBoxSol.FormattingEnabled = true;
            this.ComboBoxSol.Items.AddRange(new object[] {
            "Sans isolation"});
            this.ComboBoxSol.Location = new System.Drawing.Point(587, 190);
            this.ComboBoxSol.Name = "ComboBoxSol";
            this.ComboBoxSol.Size = new System.Drawing.Size(205, 33);
            this.ComboBoxSol.TabIndex = 93;
            this.ComboBoxSol.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSol_SelectedIndexChanged_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label20.Location = new System.Drawing.Point(582, 159);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 25);
            this.label20.TabIndex = 92;
            this.label20.Text = "Isolation sol";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label19.Location = new System.Drawing.Point(296, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 25);
            this.label19.TabIndex = 91;
            this.label19.Text = "Isolation plafond";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label18.Location = new System.Drawing.Point(17, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 25);
            this.label18.TabIndex = 90;
            this.label18.Text = "Isolation parois";
            // 
            // ComboBoxIsolationPlafond
            // 
            this.ComboBoxIsolationPlafond.FormattingEnabled = true;
            this.ComboBoxIsolationPlafond.Items.AddRange(new object[] {
            "Panneaux industriels 80 mm",
            "Panneaux industriels 120 mm",
            "Panneaux industriels 140 mm"});
            this.ComboBoxIsolationPlafond.Location = new System.Drawing.Point(301, 190);
            this.ComboBoxIsolationPlafond.Name = "ComboBoxIsolationPlafond";
            this.ComboBoxIsolationPlafond.Size = new System.Drawing.Size(268, 33);
            this.ComboBoxIsolationPlafond.TabIndex = 89;
            this.ComboBoxIsolationPlafond.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIsolationPlafond_SelectedIndexChanged);
            // 
            // ComboBoxIsolationParois
            // 
            this.ComboBoxIsolationParois.FormattingEnabled = true;
            this.ComboBoxIsolationParois.Items.AddRange(new object[] {
            "Panneaux industriels 80 mm",
            "Panneaux industriels 120 mm",
            "Panneaux industriels 140 mm"});
            this.ComboBoxIsolationParois.Location = new System.Drawing.Point(21, 190);
            this.ComboBoxIsolationParois.Name = "ComboBoxIsolationParois";
            this.ComboBoxIsolationParois.Size = new System.Drawing.Size(268, 33);
            this.ComboBoxIsolationParois.TabIndex = 88;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txtTempExt);
            this.groupBox3.Controls.Add(this.txtTempInt);
            this.groupBox3.Controls.Add(this.label47);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox3.Location = new System.Drawing.Point(7, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 195);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Temperature";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(304, 110);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 25);
            this.label26.TabIndex = 91;
            this.label26.Text = "°C";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(304, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 25);
            this.label25.TabIndex = 90;
            this.label25.Text = "°C";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.StockProduit);
            this.groupBox4.Controls.Add(this.labelStockProduit);
            this.groupBox4.Controls.Add(this.TypeProduit);
            this.groupBox4.Controls.Add(this.TempEntreeProduit);
            this.groupBox4.Controls.Add(this.labelTempEntreeProduit);
            this.groupBox4.Controls.Add(this.labelTypeProduit);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox4.Location = new System.Drawing.Point(879, 359);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 197);
            this.groupBox4.TabIndex = 93;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produits";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button6.Location = new System.Drawing.Point(341, 158);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 33);
            this.button6.TabIndex = 95;
            this.button6.Text = "Ajouter";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(294, 92);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 25);
            this.label28.TabIndex = 94;
            this.label28.Text = "°C";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(293, 141);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 25);
            this.label24.TabIndex = 93;
            this.label24.Text = "kg";
            // 
            // StockProduit
            // 
            this.StockProduit.Location = new System.Drawing.Point(229, 136);
            this.StockProduit.Name = "StockProduit";
            this.StockProduit.Size = new System.Drawing.Size(58, 30);
            this.StockProduit.TabIndex = 92;
            // 
            // labelStockProduit
            // 
            this.labelStockProduit.AutoSize = true;
            this.labelStockProduit.Location = new System.Drawing.Point(20, 136);
            this.labelStockProduit.Name = "labelStockProduit";
            this.labelStockProduit.Size = new System.Drawing.Size(203, 25);
            this.labelStockProduit.TabIndex = 91;
            this.labelStockProduit.Text = "Stock (masse produit)";
            // 
            // TypeProduit
            // 
            this.TypeProduit.FormattingEnabled = true;
            this.TypeProduit.Items.AddRange(new object[] {
            "Produits Divers",
            "Autres produits"});
            this.TypeProduit.Location = new System.Drawing.Point(229, 40);
            this.TypeProduit.Name = "TypeProduit";
            this.TypeProduit.Size = new System.Drawing.Size(202, 33);
            this.TypeProduit.TabIndex = 90;
            // 
            // TempEntreeProduit
            // 
            this.TempEntreeProduit.Location = new System.Drawing.Point(230, 89);
            this.TempEntreeProduit.Name = "TempEntreeProduit";
            this.TempEntreeProduit.Size = new System.Drawing.Size(58, 30);
            this.TempEntreeProduit.TabIndex = 37;
            // 
            // labelTempEntreeProduit
            // 
            this.labelTempEntreeProduit.AutoSize = true;
            this.labelTempEntreeProduit.Location = new System.Drawing.Point(20, 92);
            this.labelTempEntreeProduit.Name = "labelTempEntreeProduit";
            this.labelTempEntreeProduit.Size = new System.Drawing.Size(199, 25);
            this.labelTempEntreeProduit.TabIndex = 36;
            this.labelTempEntreeProduit.Text = "Temperature d\'entrée";
            // 
            // labelTypeProduit
            // 
            this.labelTypeProduit.AutoSize = true;
            this.labelTypeProduit.Location = new System.Drawing.Point(20, 43);
            this.labelTypeProduit.Name = "labelTypeProduit";
            this.labelTypeProduit.Size = new System.Drawing.Size(148, 25);
            this.labelTypeProduit.TabIndex = 34;
            this.labelTypeProduit.Text = "Type de produit";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtTempsMarche);
            this.groupBox5.Controls.Add(this.txtCycle);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox5.Location = new System.Drawing.Point(517, 361);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(365, 195);
            this.groupBox5.TabIndex = 94;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fonctionnement";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 25);
            this.label15.TabIndex = 34;
            this.label15.Text = "Temps de marche";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Cycle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(267, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "H/Cycle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "H";
            // 
            // txtTempsMarche
            // 
            this.txtTempsMarche.Location = new System.Drawing.Point(182, 80);
            this.txtTempsMarche.Name = "txtTempsMarche";
            this.txtTempsMarche.Size = new System.Drawing.Size(66, 30);
            this.txtTempsMarche.TabIndex = 1;
            // 
            // txtCycle
            // 
            this.txtCycle.Location = new System.Drawing.Point(182, 33);
            this.txtCycle.Name = "txtCycle";
            this.txtCycle.Size = new System.Drawing.Size(66, 30);
            this.txtCycle.TabIndex = 0;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEnregistrer.Location = new System.Drawing.Point(1080, 703);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(170, 32);
            this.btnEnregistrer.TabIndex = 95;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnImporter
            // 
            this.btnImporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnImporter.Location = new System.Drawing.Point(1080, 665);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(170, 32);
            this.btnImporter.TabIndex = 96;
            this.btnImporter.Text = "Importer";
            this.btnImporter.UseVisualStyleBackColor = true;
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // lblNomBilanImporte
            // 
            this.lblNomBilanImporte.AutoSize = true;
            this.lblNomBilanImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNomBilanImporte.Location = new System.Drawing.Point(899, 14);
            this.lblNomBilanImporte.Name = "lblNomBilanImporte";
            this.lblNomBilanImporte.Size = new System.Drawing.Size(126, 25);
            this.lblNomBilanImporte.TabIndex = 97;
            this.lblNomBilanImporte.Text = "Nom du bilan";
            // 
            // btnImprimer
            // 
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnImprimer.Location = new System.Drawing.Point(1080, 627);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(170, 32);
            this.btnImprimer.TabIndex = 99;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnQuitter.Location = new System.Drawing.Point(1080, 565);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(170, 32);
            this.btnQuitter.TabIndex = 100;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEffacer.Location = new System.Drawing.Point(904, 565);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(170, 32);
            this.btnEffacer.TabIndex = 101;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // txtNomBilanImporte
            // 
            this.txtNomBilanImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNomBilanImporte.Location = new System.Drawing.Point(1031, 12);
            this.txtNomBilanImporte.Multiline = true;
            this.txtNomBilanImporte.Name = "txtNomBilanImporte";
            this.txtNomBilanImporte.Size = new System.Drawing.Size(199, 30);
            this.txtNomBilanImporte.TabIndex = 102;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 774);
            this.Controls.Add(this.txtNomBilanImporte);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.lblNomBilanImporte);
            this.Controls.Add(this.btnImporter);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calculer);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtResultatBilan);
            this.Controls.Add(this.labelBilanThermique);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeEnceinte);
            this.Name = "Form1";
            this.Text = "Calculateur de puissance frigorifique";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTypeEnceinte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBilanThermique;
        private System.Windows.Forms.TextBox LongueurInt;
        private System.Windows.Forms.TextBox LargeurInt;
        private System.Windows.Forms.TextBox HauteurInt;
        private System.Windows.Forms.TextBox Volume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkSol;
        private System.Windows.Forms.TextBox txtkPlafond;
        private System.Windows.Forms.TextBox txtepParois;
        private System.Windows.Forms.TextBox txtkParois;
        private System.Windows.Forms.TextBox txtResultatBilan;
        private System.Windows.Forms.TextBox txtepPlafond;
        private System.Windows.Forms.TextBox txtepSol;
        private System.Windows.Forms.TextBox txtTempExt;
        private System.Windows.Forms.TextBox txtTempInt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button Calculer;
        private System.Windows.Forms.Label label47;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label7;
        private TextBox txtTempsMarche;
        private TextBox txtCycle;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label labelTempEntreeProduit;
        private Label labelTypeProduit;
        private Button btnEnregistrer;
        private ComboBox ComboBoxIsolationParois;
        private Label label18;
        private ComboBox ComboBoxIsolationPlafond;
        private Label label19;
        private PictureBox pictureBox1;
        private ComboBox ComboBoxSol;
        private Label label20;
        private Button btnImporter;
        private Label lblNomBilanImporte;
        private Button btnImprimer;
        private Label labelStockProduit;
        private ComboBox TypeProduit;
        private TextBox TempEntreeProduit;
        private Label label24;
        private TextBox StockProduit;
        private Button btnQuitter;
        private Button btnEffacer;
        private Label label26;
        private Label label25;
        private Label label28;
        private Button button6;
        private TextBox txtNomBilanImporte;
    }
}

