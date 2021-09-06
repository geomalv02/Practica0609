using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_060921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //evento load(), inicia cuando se ejecuta la aplicacion
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Programacion Computacional I");
        }

        //evento Click(), se ejecuta cuando damos click al objeto
        private void btnClic_Click(object sender, EventArgs e)
        {
            //declarar un arreglo de numero
            int[] nums = new int[] { 8, 9, 4, 6, 7, 10, 7, 8 };
            //llenar el ListBox utilizando linq
            var num = from n in nums select n; //usamos sintaxis linq para leer el arreglo
            object lstData = null;
            foreach (int i in num)
                lstData.Items.Add(i); //llenamos ListBox
        }
    }
}
