using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioExemplo
{
    public partial class Form1
    {
        private void InserirNaPlanilha()
        {
            if(txtbNome.Text == string.Empty)
            {
                MessageBox.Show("Insira um argumento válido no campo nome!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtbData.MaskCompleted)
            {
                MessageBox.Show("Insira uma Data válida!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
