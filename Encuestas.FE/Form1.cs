using Encuestas.BKEND;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuestas.FE
{
    public partial class Form1 : Form
    {
        Encuesta encuestita = new Encuesta();
        ListaEncuestas encuestas { get; set; } = new ListaEncuestas();
        public Form1()
        {
            InitializeComponent();
        }


        private bool RadioButtonSelected(TableLayoutPanel tableLayoutPanel)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return true;
                }
            }
            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            bool panel1Selected = RadioButtonSelected(tableLayoutPanel2);
            bool panel2Selected = RadioButtonSelected(tableLayoutPanel3);
            bool panel3Selected = RadioButtonSelected(tableLayoutPanel1);

            if (!panel1Selected || !panel2Selected || !panel3Selected)
            {
                MessageBox.Show("Por favor, seleccione una opción en cada panel antes de enviar los datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int x = 0;
                int y = 0;
                int z = 0;

                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        switch (radioButton.Name)
                        {
                            case "radioButton1":
                                x = 1; 
                                break;
                            case "radioButton2":
                                x = 2; 
                                break;
                            case "radioButton3":
                                x = 3;
                                break;
                            case "radioButton4":
                                x = 4;
                                break;
                            case "radioButton5":
                                x = 5;
                                break;
                        }
                       
                        break;
                    }
                }


                foreach (Control control in tableLayoutPanel2.Controls)
                {
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        switch (radioButton.Name)
                        {
                            case "radioButton6":
                                y = 1;
                                break;
                            case "radioButton7":
                                y = 2;
                                break;
                            case "radioButton8":
                                y = 3;
                                break;
                            case "radioButton9":
                                y = 4;
                                break;
                            case "radioButton10":
                                y = 5;
                                break;
                        }

                        break;
                    }
                }



                foreach (Control control in tableLayoutPanel3.Controls)
                {
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        switch (radioButton.Name)
                        {
                            case "radioButton11":
                                z = 1;
                                break;
                            case "radioButton12":
                                z = 2;
                                break;
                            case "radioButton13":
                                z = 3;
                                break;
                            case "radioButton14":
                                z = 4;
                                break;
                            case "radioButton15":
                                z = 5;
                                break;
                        }

                        break;
                    }
                }


                encuestita.Agregar(x,y,z);
                encuestas.InsertEncuesta(encuestita);
                MessageBox.Show("Sus datos fueron cargados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }

}