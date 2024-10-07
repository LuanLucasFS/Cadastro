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
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            fm_cadastro form = new fm_cadastro();
            this.Hide();
            form.ShowDialog();
        }

        private void Entrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }
    }
}
