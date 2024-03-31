using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;


namespace Transferth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxIsolationParois.SelectedIndexChanged += ComboBoxIsolationParois_SelectedIndexChanged;
            ComboBoxIsolationPlafond.SelectedIndexChanged += ComboBoxIsolationPlafond_SelectedIndexChanged;

       
        }


        private void ComboBoxIsolationPlafond_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = ComboBoxIsolationPlafond.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Panneaux industriels 80 mm":
                    txtkPlafond.Text = "0.30";
                    txtepPlafond.Text = "80";
                    break;
                case "Panneaux industriels 120 mm":
                    txtkPlafond.Text = "0.21";
                    txtepPlafond.Text = "120";
                    break;
                case "Panneaux industriels 140 mm":
                    txtkPlafond.Text = "0.18";
                    txtepPlafond.Text = "140";
                    break;
                default:
                    // Gérer le cas par défaut si nécessaire
                    break;
            }
        }
       
        private void ComboBoxIsolationParois_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = ComboBoxIsolationParois.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Panneaux industriels 80 mm":
                    txtkParois.Text = "0.30";
                    txtepParois.Text = "80";
                    break;
                case "Panneaux industriels 120 mm":
                    txtkParois.Text = "0.21";
                    txtepParois.Text = "120";
                    break;
                case "Panneaux industriels 140 mm":
                    txtkParois.Text = "0.18";
                    txtepParois.Text = "140";
                    break;
                default:
                    // Gérer le cas par défaut si nécessaire
                    break;
            }
        }

        private void comboBoxTypeEnceinte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeEnceinte = comboBoxTypeEnceinte.SelectedItem.ToString();
            labelBilanThermique.Text = $"Dimensions de la {typeEnceinte} :";
        }

       

        private void Calculer_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void WireUpTextChangedEvents()
        {
            LongueurInt.TextChanged += ValidateInput;
            LargeurInt.TextChanged += ValidateInput;
            HauteurInt.TextChanged += ValidateInput;
            txtkParois.TextChanged += ValidateInput;
            txtkPlafond.TextChanged += ValidateInput;
            txtkSol.TextChanged += ValidateInput;
            txtepParois.TextChanged += ValidateInput;
            txtepPlafond.TextChanged += ValidateInput;
            txtepSol.TextChanged += ValidateInput;
            txtTempExt.TextChanged += ValidateInput;
            txtTempInt.TextChanged += ValidateInput;
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                double value;
                if (!double.TryParse(textBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out value) || value <= 0)
                {
                    textBox.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    textBox.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }




        private void Calculate()
        {
            try
            {
                // Extraction des valeurs des champs
                double longueurInt = Convert.ToDouble(LongueurInt.Text);
                double largeurInt = Convert.ToDouble(LargeurInt.Text);
                double hauteurInt = Convert.ToDouble(HauteurInt.Text);

                double kParois = Convert.ToDouble(txtkParois.Text, CultureInfo.InvariantCulture);
                double kPlafond = Convert.ToDouble(txtkPlafond.Text, CultureInfo.InvariantCulture);
                double kSol = Convert.ToDouble(txtkSol.Text, CultureInfo.InvariantCulture);

                double epParois = Convert.ToDouble(txtepParois.Text, CultureInfo.InvariantCulture);
                double epPlafond = Convert.ToDouble(txtepPlafond.Text, CultureInfo.InvariantCulture);
                double epSol = Convert.ToDouble(txtepSol.Text, CultureInfo.InvariantCulture);

                double tempExt = Convert.ToDouble(txtTempExt.Text, CultureInfo.InvariantCulture);
                double tempInt = Convert.ToDouble(txtTempInt.Text, CultureInfo.InvariantCulture);

                // Calcul des surfaces
                double surfaceParois = 2 * (longueurInt * hauteurInt + largeurInt * hauteurInt);
                double surfacePlafond = longueurInt * largeurInt;
                double surfaceSol = longueurInt * largeurInt;

                // Calcul des apports thermiques
                double qCondParois = (kParois * surfaceParois * (tempExt - tempInt)) / epParois;
                double qCondPlafond = (kPlafond * surfacePlafond * (tempExt - tempInt)) / epPlafond;
                double qCondSol = (kSol * surfaceSol * (tempExt - tempInt)) / epSol;

                // Calcul du bilan thermique
                double bilanThermique = qCondParois + qCondPlafond + qCondSol;

                // Récupérer les valeurs de cycle et temps de marche
                double cycle = Convert.ToDouble(txtCycle.Text, CultureInfo.InvariantCulture);
                double tempsMarche = Convert.ToDouble(txtTempsMarche.Text, CultureInfo.InvariantCulture);

                // Calcul de la charge thermique totale en tenant compte du cycle de fonctionnement
                double chargeThermiqueTotale = bilanThermique * tempsMarche / cycle;

                // Mise à jour des champs de résultat
                Volume.Text = (longueurInt * largeurInt * hauteurInt).ToString(); // Mettre à jour le champ Volume
                txtResultatBilan.Text = $"Pertes chaleurs par les parois: {qCondParois} W" + Environment.NewLine +
                         $"Pertes chaleurs par le plafond: {qCondPlafond} W" + Environment.NewLine +
                         $"Pertes chaleurs par le sol: {qCondSol} W" + Environment.NewLine +
                         $"Bilan Thermique Total: {bilanThermique} W" + Environment.NewLine +
                         $"Bilan Thermique Totale (avec cycle): {chargeThermiqueTotale} W" + Environment.NewLine;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du calcul : " + ex.Message, "Erreur de calcul", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ComboBoxSol_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
                string selectedOption = ComboBoxSol.SelectedItem.ToString();

                switch (selectedOption)
                {
                    case "Sans isolation":
                        txtkSol.Text = "2.4";
                        txtepSol.Text = "100";
                        break;

                    default:
                        // Gérer le cas par défaut si nécessaire
                        break;
                }
            }

     private void btnQuitter_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
           
                // Réinitialiser le texte des champs à une chaîne vide
                LongueurInt.Text = "";
                LargeurInt.Text = "";
                HauteurInt.Text = "";
                txtkParois.Text = "";
                txtkPlafond.Text = "";
                txtkSol.Text = "";
                txtepParois.Text = "";
                txtepPlafond.Text = "";
                txtepSol.Text = "";
                txtTempExt.Text = "";
                txtTempInt.Text = "";
                txtCycle.Text = "";
                txtTempsMarche.Text = "";
                Volume.Text = "";
                txtResultatBilan.Text = "";
            }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Fichier texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
                    saveFileDialog.Title = "Enregistrer le bilan thermique";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string cheminFichier = saveFileDialog.FileName;

                        // Enregistrez les données dans le fichier spécifié
                        using (StreamWriter writer = new StreamWriter(cheminFichier))
                        {
                            writer.WriteLine($"Longueur: {LongueurInt.Text}");
                            writer.WriteLine($"Largeur: {LargeurInt.Text}");
                            writer.WriteLine($"Hauteur: {HauteurInt.Text}");
                            writer.WriteLine($"Coefficient de conductivité thermique des parois (kParois): {txtkParois.Text}");
                            writer.WriteLine($"Epaisseur des parois (en mm): {txtepParois.Text}");
                            writer.WriteLine($"Coefficient de conductivité thermique du plafond (kPlafond): {txtkPlafond.Text}");
                            writer.WriteLine($"Epaisseur du plafond (en mm): {txtepPlafond.Text}");
                            writer.WriteLine($"Coefficient de conductivité thermique du sol (kSol): {txtkSol.Text}");
                            writer.WriteLine($"Epaisseur du sol (en mm): {txtepSol.Text}");
                            writer.WriteLine($"Température extérieure: {txtTempExt.Text}");
                            writer.WriteLine($"Température intérieure: {txtTempInt.Text}");
                            writer.WriteLine($"Cycle de fonctionnement (en heures): {txtCycle.Text}");
                            writer.WriteLine($"Temps de marche (en heures): {txtTempsMarche.Text}");
                        }

                        MessageBox.Show("Les données ont été enregistrées avec succès !", "Enregistrement réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'enregistrement des données : " + ex.Message, "Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string nomBilanImporte = "";

        private void btnImporter_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Fichier texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
                    openFileDialog.Title = "Importer un bilan thermique";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string cheminFichier = openFileDialog.FileName;

                        // Lisez les données à partir du fichier sélectionné
                        using (StreamReader reader = new StreamReader(cheminFichier))
                        {
                            LongueurInt.Text = GetValueFromLine(reader.ReadLine());
                            LargeurInt.Text = GetValueFromLine(reader.ReadLine());
                            HauteurInt.Text = GetValueFromLine(reader.ReadLine());
                            txtkParois.Text = GetValueFromLine(reader.ReadLine());
                            txtepParois.Text = GetValueFromLine(reader.ReadLine());
                            txtkPlafond.Text = GetValueFromLine(reader.ReadLine());
                            txtepPlafond.Text = GetValueFromLine(reader.ReadLine());
                            txtkSol.Text = GetValueFromLine(reader.ReadLine());
                            txtepSol.Text = GetValueFromLine(reader.ReadLine());
                            txtTempExt.Text = GetValueFromLine(reader.ReadLine());
                            txtTempInt.Text = GetValueFromLine(reader.ReadLine());
                            txtCycle.Text = GetValueFromLine(reader.ReadLine());
                            txtTempsMarche.Text = GetValueFromLine(reader.ReadLine());
                            nomBilanImporte = openFileDialog.SafeFileName; // Enregistrez le nom du fichier importé
                        }

                        // Afficher le nom du bilan importé dans le TextBox approprié
                        txtNomBilanImporte.Text = nomBilanImporte;

                        MessageBox.Show("Les données ont été importées avec succès !", "Importation réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'importation des données : " + ex.Message, "Erreur d'importation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetValueFromLine(string line)
        {
            // Séparez la ligne en deux parties : le libellé et la valeur
            string[] parts = line.Split(':');

            // Retournez la valeur (deuxième partie)
            return parts.Length > 1 ? parts[1].Trim() : string.Empty;
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // Créez un objet PrintDocument
                PrintDocument printDocument = new PrintDocument();

                // Associez un gestionnaire d'événements pour l'événement PrintPage
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                // Appelez la boîte de dialogue d'impression
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Imprimez les données
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'impression : " + ex.Message, "Erreur d'impression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Définissez le contenu à imprimer (par exemple, le texte des champs de votre formulaire)
            string contenu = "Données du bilan thermique :\n\n" +
                      "Dimensions de la chambre froide :\n" +
                      $"Longueur: {LongueurInt.Text}\n" +
                      $"Largeur: {LargeurInt.Text}\n" +
                      $"Hauteur: {HauteurInt.Text}\n\n" +

                      "Isolation des parois :\n" +
                      $"Coefficient de conductivité thermique (kParois): {txtkParois.Text}\n" +
                      $"Epaisseur (en mm): {txtepParois.Text}\n\n" +

                      "Isolation du plafond :\n" +
                      $"Coefficient de conductivité thermique (kPlafond): {txtkPlafond.Text}\n" +
                      $"Epaisseur (en mm): {txtepPlafond.Text}\n\n" +

                      "Isolation du sol :\n" +
                      $"Coefficient de conductivité thermique (kSol): {txtkSol.Text}\n" +
                      $"Epaisseur (en mm): {txtepSol.Text}\n\n" +

                      "Conditions environnementales :\n" +
                      $"Température extérieure: {txtTempExt.Text} °C\n" +
                      $"Température intérieure: {txtTempInt.Text} °C\n\n" +

                      "Cycle de fonctionnement :\n" +
                      $"Cycle de fonctionnement (en heures): {txtCycle.Text}\n" +
                      $"Temps de marche (en heures): {txtTempsMarche.Text}";


            // Définissez la police et les dimensions de la zone d'impression
            Font police = new Font("Arial", 15);
            Rectangle zoneImprimable = new Rectangle(50, 50, 700, 800);

            // Dessinez le contenu sur la page
            e.Graphics.DrawString(contenu, police, Brushes.Black, zoneImprimable);
        }

    }
}
 



