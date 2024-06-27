using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenAdo
{
    public partial class FormManRegion : Form
    {
        public FormManRegion()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BRegion bRegion = new BRegion();
                Entidad.Region region = new Entidad.Region { RegionName = txtRegion.Text };
                bRegion.Insert(region)
                MessageBox.Show("CORRECTO");

            }
            catch
            {
                MessageBox.Show("ERROR");

            }
            

        }
    }
}
