
using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lógica
{
    public class Validacion
    {
        public Boolean ValidarEmail(string Email)
        {
            string strModel = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][- \\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            return System.Text.RegularExpressions.Regex.IsMatch(Email, strModel);

        }

        public void Vali_letras(KeyPressEventArgs e)
        {
            try
            {
                if(char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo letras");
                }
            }
            catch
            {
            }
        }
        public void Vali_num(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber (e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo numeros");
                }
            }
            catch
            {
            }
        }
        public void Vali_letras_numeros_simbolos(KeyPressEventArgs e)
        {
            try
            {
                if(char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(char.IsSymbol(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl (e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo letras, numeros  y simbalos");
                }
            }
            catch
            {
            }
        }
        public void Vali_Mayusculas(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsUpper(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo letras MAYUSCULAS");
                }
            }
            catch
            {
            }
        }


    }
}
