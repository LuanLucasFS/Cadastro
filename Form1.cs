using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class fm_cadastro : Form
    {
        public fm_cadastro()
        {
            InitializeComponent();
        }

        private void fm_cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text == string .Empty)
            {
                lb_nome.ForeColor = Color.Red;
            }
            else
            {
                lb_nome.ForeColor = Color.SeaGreen;
            }
            if(tb_sobrenome.Text == string.Empty)
            {
                lb_Sobrenome.ForeColor = Color.Red;
            }
            else
            {
                lb_Sobrenome.ForeColor= Color.SeaGreen;
            }
            if(tb_email.Text == string.Empty)
            {
                lb_Email.ForeColor = Color.Red;
            }
            else
            {
                lb_Email.ForeColor = Color.SeaGreen;
            }
            if(tb_ConfirmaEmail.Text == string.Empty)
            {
                lb_Email.ForeColor = Color.Red;
            }
            else
            {
                lb_Email.ForeColor = Color.SeaGreen;
            }
            if(tb_ConfirmaEmail.Text == string.Empty)
            {
                lb_ConfirmaEmail.ForeColor = Color.Red;
            }
            else
            {
                lb_ConfirmaEmail.ForeColor = Color.SeaGreen;
            }
            if (tb_ConfirmaEmail.Text.Equals(tb_email.Text))
            {
                lb_Email.ForeColor = Color.Red;
                lb_ConfirmaEmail.ForeColor = Color.Red;
            }
            else
            {
                lb_Email.ForeColor = Color.SeaGreen;
                lb_ConfirmaEmail.ForeColor = Color.SeaGreen;
            }
            if(tb_Celular.Text.Equals("(   )      -"))
            {
                lb_Celular.ForeColor = Color.Red;
            }
            else
            {
                lb_Celular.ForeColor = Color.SeaGreen;
            }
            if(tb_RG.Text == string.Empty)
            {
                lb_RG.ForeColor = Color.Red;
            }
            else
            {
                lb_RG.ForeColor = Color.SeaGreen;
            }
            if(!r_Solteiro.Checked && !r_Casado.Checked &&  !r_Viuvo.Checked && !r_Divorciado.Checked)
            {
                lb_EstadoCivil.ForeColor = Color.Red;
            }
            else
            {
                lb_EstadoCivil.ForeColor = Color.SeaGreen;
            }
            if(tb_Endereco.Text == string.Empty)
            {
                lb_Endereco.ForeColor = Color.Red;
            }
            else
            {
                lb_Endereco.ForeColor = Color.SeaGreen;
            }
            if(tb_Numero.Text == string.Empty)
            {
                lb_Numero.ForeColor = Color.Red;
            }
            else
            {
                lb_Numero.ForeColor = Color.SeaGreen;
            }
            if(cb_Estado.SelectedText == string.Empty) 
            {
                lb_Estado.ForeColor = Color.Red;
            }
            else
            {
                lb_Estado.ForeColor = Color.SeaGreen;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void fm_cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Entrar entrar = new Entrar();
            this.Hide();
            entrar.Show();
        }
    }
}
