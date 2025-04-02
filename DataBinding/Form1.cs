using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryData = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = countryData;
            countryDataBindingSource.DataSource = countryData;
            dataGridView1.DataSource = countryDataBindingSource;

        }

        private void button2_Click(object sender, EventArgs e) //törlés
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e) //betöltés
        {
            
            using (StreamReader reader = new StreamReader("european_countries.csv"))
            using ( var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var rekordok = csv.GetRecords<CountryData>();
                foreach ( var rekord in rekordok)
                {
                    countryData.Add(rekord);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //szerkesztés
        {
            FormCountryEdit fce = new FormCountryEdit();
            fce.CountryData = (CountryData)countryDataBindingSource.Current;
            fce.Show(); //vagy fce.ShowDialog();
        }
    }
}
