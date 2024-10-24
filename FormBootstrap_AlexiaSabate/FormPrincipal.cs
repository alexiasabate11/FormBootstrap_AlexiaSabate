using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBootstrap_AlexiaSabate
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void lblType_Click(object sender, EventArgs e){}

        private void chckEmail_CheckedChanged(object sender, EventArgs e)
        {
            butEnviar.Enabled = true;
        }

        private void butEnviar_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != null)
            {
                if (txtTitle.Text != null) 
                { 
                    if (chckDemo.Checked || chckProd.Checked || chckPreprod.Checked) 
                    {
                        String entornos = "";
                        String fecha = "\nNinguna fecha de inicio seleccionada.";
                        if (chckDemo.Checked) { entornos += " Demo "; }
                        if (chckPreprod.Checked) { entornos += " Preprod "; }
                        if (chckProd.Checked) { entornos += " Prod "; }
                        if (DateInitial.Checked) 
                        {
                            fecha = "\nFecha Inicial: " + DateInitial.Value.ToString();
                        }

                        MessageBox.Show(
                            "Titulo: " + txtTitle.Text +
                            "\nUbicación: " + cmbLocation.SelectedItem.ToString() +
                            "\nTipo: " + cmbType.SelectedItem.ToString() +
                            "\nNecesidad: " + cmbCriticity.SelectedItem.ToString() +
                            "\nEntornos: " + entornos +
                            "\nDescrición: " + txtDescription.Text +
                            fecha +
                            "\nDuración: " + numDuration.Value.ToString() +
                            "\nEstado: " + cmbEstate.SelectedItem.ToString() +
                            "\nPorcentaje completado: " + cmbPercent.SelectedItem.ToString()
                            );
                    }
                    else
                    {
                        MessageBox.Show("No hay marcado ningún estado.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay título.");
                }
            }
            else
            {
                MessageBox.Show("No hay descripción.");
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
