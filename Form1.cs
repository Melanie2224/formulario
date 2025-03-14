using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntxtBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == 13) ;

            {
                txtNom.Focus();
            }

            if (e.KeyChar == 8) ;


            if (e.KeyChar >= 48 &&
                e.KeyChar <=57) ;

            {

                con++;
            }


            if (e.KeyChar = 10);

            

           


        }

        private void btntxtBoxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            {


                if (e.KeyChar == 13) ;


                {
                    txtNom.Focus();
                }

                if (e.KeyChar == 8) ;

                if (e.KeyChar >= 65 &&
                    e.KeyChar <= 90) ;

                if (e.KeyChar >= 97 &&
                    e.KeyChar <= 122) ;


                {

                    con++;
                }

                if (e.KeyChar = 10) ;


            }


        }

        private void btntxtBoxApll_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13) ;


            {
                txtNom.Focus();
            }

            if (e.KeyChar == 8) ;

            if (e.KeyChar >= 65 &&
                e.KeyChar <= 90) ;

            if (e.KeyChar >= 97 &&
                e.KeyChar <= 122) ;


            {

                con++;
            }

            if (e.KeyChar = 10) ;

        }

        private void gpBoxId_Enter(object sender, EventArgs e)
        {

        }

        private void gpBoxContacto_Enter(object sender, EventArgs e)
        {

        }

        private void btntxtBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13) ;

            {
                txtNom.Focus();
            }

            if (e.KeyChar == 8) ;


            if (e.KeyChar >= 48 &&
                e.KeyChar <= 57) ;

            {

                con++;
            }


            if (e.KeyChar = 10) ;



        }

        private void btntxtBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) ;

            {
                txtNom.Focus();
            }

            if (e.KeyChar == 8) ;


            if (e.KeyChar >= 48 &&
                e.KeyChar <= 57) ;

          

            if (e.KeyChar >= 65 &&
                e.KeyChar <= 90) ;

            if (e.KeyChar >= 97 &&
                e.KeyChar <= 122) ;


            if (e.KeyChar == 64) ;

            if (e.KeyChar == 46) ;

            if (e.KeyChar == 127) ;

            {

                con++;
            }


            if (e.KeyChar = 10) ;


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
