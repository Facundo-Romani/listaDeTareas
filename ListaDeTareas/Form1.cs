using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeTareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // BTN de agregar al la lista si la tarea esta chequeada.
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (checkEntrenar.Checked == true)
                listView1.Items.Add(checkEntrenar.Text);
                checkEntrenar.Checked = false;

            if (checkEstudiar.Checked == true)
                listView1.Items.Add(checkEstudiar.Text);
                checkEstudiar.Checked = false;

            if (checkLavar.Checked == true)
                listView1.Items.Add(checkLavar.Text);
                checkLavar.Checked = false;

            if (checkYoga.Checked == true)
                listView1.Items.Add (checkYoga.Text);
                checkYoga.Checked = false;

            if (checkCompras.Checked == true)
                listView1.Items.Add(checkCompras.Text);
                checkCompras.Checked = false;

            if (checkPerro.Checked == true)
                listView1.Items.Add(checkPerro.Text);
                checkPerro.Checked = false; 
        }

        // Limpiar Lista.
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); 
        }
    }
}
