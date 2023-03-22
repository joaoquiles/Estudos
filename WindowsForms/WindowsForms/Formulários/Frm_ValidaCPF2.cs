using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBiblioteca;

namespace WindowsForms
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo= Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();
            if (vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 digitos ", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Você deseja realmente validar o CPF ? ", "Mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool validaCPF = false;
                        validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
                        if (validaCPF == true)
                        {
                            MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF INVÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }

                
            }


        }
    }
}
