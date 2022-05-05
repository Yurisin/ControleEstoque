using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmConsulta : Form
    {
        public int IDProduto = 0;
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
           Model m = new Model();
            List<DtoProduto2> list = m.ListProdutoNome(txtConsulta.Text);
            GridConsulta.DataSource = list;
        }

        private void GridConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex > 0)
            {
                IDProduto = (Int32)GridConsulta.CurrentRow.Cells[0].Value;
                Close();
            }
        }
    }
}
