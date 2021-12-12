using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace FormularioExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnInserirPlanilha_Click(object sender, EventArgs e)
        {
            InserirNaPlanilha();
        }
        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            LimparPlanilha();
        }
        private void btnIVerificarAtualizar_Click(object sender, EventArgs e)
        {
            VerificarPlanilha();
        }      
        private void btnNovoLocal_Click(object sender, EventArgs e)
        {
            AlterarLocal();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            SairPlanilha();
        }
    }
}
