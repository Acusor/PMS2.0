using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PMS2
{ 
    public partial class Form1 : Form
    {
        private const decimal MinPret = 0;

        private List<Medicament> medicamente;

        public Form1()
        {
            InitializeComponent();
            medicamente = new List<Medicament>();

            // Inițializare și afișare medicamente
            AfiseazaMedicamente();  
        }

        private void AfiseazaMedicamente()
        {
            string filePath = @"C:\programir\proiecte\PMS2\Medicamente.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("Fișierul de date nu există și a fost creat!");
                return;
            }

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 4)
                {
                    try
                    {
                        Medicament medicament = new Medicament
                        {
                            Nume = parts[0],
                            Producator = parts[1],
                            Pret = decimal.Parse(parts[2]),
                            Cantitate = int.Parse(parts[3])
                        };
                        medicamente.Add(medicament);
                        AdaugaMedicamentLaFormular(medicament);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Eroare la parsarea uneia dintre linii.");
                        return;
                    }
                }
            }
        }

        private void AdaugaMedicamentLaFormular(Medicament medicament)
        {
            TextBox textBoxNume = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Nume: {medicament.Nume}"
            };

            TextBox textBoxProducator = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Producator: {medicament.Producator}"
            };

            TextBox textBoxPret = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Preț: {medicament.Pret} lei"
            };

            TextBox textBoxCantitate=new TextBox
            {
                Multiline=true,
                ReadOnly=true,
                Text=$"Cantitate:{medicament.Cantitate} bucati"
            };

            flowLayoutPanelMedicamente.Controls.Add(textBoxNume);
            flowLayoutPanelMedicamente.Controls.Add(textBoxProducator);
            flowLayoutPanelMedicamente.Controls.Add(textBoxPret);
            flowLayoutPanelMedicamente.Controls.Add(textBoxCantitate);
        }

        private void btnAdaugaMedicament_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) || string.IsNullOrWhiteSpace(txtProducator.Text) || nudPret.Value <= MinPret)
            {
                MessageBox.Show("Introduceți date valide pentru medicament!");
                return;
            }

            if (!int.TryParse(txtCantitate.Text, out int cantitate) || cantitate < 0)
            {
                MessageBox.Show("Cantitatea introdusă nu este validă!");
                return;
            }

            Medicament medicament = new Medicament
            {
                Nume = txtNume.Text,
                Producator = txtProducator.Text,
                Pret = nudPret.Value,
                Cantitate= cantitate
               
            };

            AdaugaMedicamentInFisier(medicament);
            AdaugaMedicamentLaFormular(medicament);

            // Resetare câmpuri
            txtNume.Text = "";
            txtProducator.Text = "";
            nudPret.Value = MinPret;
            txtCantitate.Text = "";
        }

        private void AdaugaMedicamentInFisier(Medicament medicament)
        {
            string filePath = @"C:\programir\proiecte\PMS2\Medicamente.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{ medicament.Nume},{medicament.Producator},{medicament.Pret},{medicament.Cantitate}");
            }
        }

      

        private void CautaMedicamente(string termen)
        {
            // Șterge medicamentele existente afișate înainte de a afișa rezultatele căutării
            flowLayoutPanelMedicamente.Controls.Clear();

            // Caută în lista de medicamente după termenul introdus de utilizator
            foreach (var medicament in medicamente)
            {
                // Verifică dacă numele sau producătorul medicamentului conține termenul de căutare
                if (medicament.Nume.Contains(termen) || medicament.Producator.Contains(termen))
                {
                    AdaugaMedicamentLaFormular(medicament);
                }
            }
        }

        private void flowLayoutPanelMedicamente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducator_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPret_ValueChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) || string.IsNullOrWhiteSpace(txtProducator.Text) || nudPret.Value <= MinPret)
            {
                MessageBox.Show("Introduceți date valide pentru medicament!");
                return;
            }

            if (!int.TryParse(txtCantitate.Text, out int cantitate) || cantitate < 0)
            {
                MessageBox.Show("Cantitatea introdusă nu este validă!");
                return;
            }

            Medicament medicament = new Medicament
            {
                Nume = txtNume.Text,
                Producator = txtProducator.Text,
                Pret = nudPret.Value,
                Cantitate = cantitate
                
                
            };

            AdaugaMedicamentInFisier(medicament);
            AdaugaMedicamentLaFormular(medicament);

            // Resetare câmpuri
            txtNume.Text = "";
            txtProducator.Text = "";
            nudPret.Value = MinPret;
            txtCantitate.Text = "";
           
        }

      

        private void txtCantitate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
    }

    public class Medicament
    {
        public string Nume { get; set; }
        public string Producator { get; set; }
        public decimal Pret { get; set; }
        public int Cantitate { get; set; }
    }
}
