using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jsonc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_email.Clear();
            tx_telefone.Clear();
            tx_nascimento.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var estetica = new Estetica();///
            estetica.Nome = tx_nome.Text;
            estetica.Email = tx_email.Text; 
            estetica.Cpf = tx_cpf.Text;
            estetica.datanascimento = tx_nascimento.Text;   
            estetica.telefone = tx_telefone.Text;
            estetica.Endereço = tx_endereço.Text;
            



            try
            {
                using (StreamWriter a = new StreamWriter(@"c:/dados/arquivos.json"))
                {
                    a.WriteLine(estetica.JsonSerializar(estetica));
                }
                MessageBox.Show("Arquivo salvo");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);


            }
        }
    }
}
