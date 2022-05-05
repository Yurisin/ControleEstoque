using Controle_de_Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class frmSaida : ControleEstoque1.FrmBase
    {
        public frmSaida()
        {
            InitializeComponent();
            DesabilitarText();
        }

        private void HabilitarText()
        {
            txtIDProduto.Enabled = true;
            txtQtdeSaida.Enabled = true;
            txtValorUnidade.Enabled = true;
            txtValorTotal.Enabled = true;
            txtQtdeSaida.Enabled = true;
        }

        private void DesabilitarText()
        {
            txtID.Enabled = false;
            txtIDProduto.Enabled = false;
            txtNomeProduto.Enabled = false;
            txtQtdeSaida.Enabled = false;
            txtValorUnidade.Enabled = false;    
            txtValorTotal.Enabled = false; 
        }

        private void txtIDProduto_Leave(object sender, EventArgs e)
        {
            Model get = new Model();
            DtoProduto produto = get.GetProdutoID(int.Parse(txtIDProduto.Text));
            txtNomeProduto.Text = produto.nome;
            txtEstoque.Text = produto.quantidade.ToString();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.IDProduto != 0)
            {
                txtIDProduto.Text = c.IDProduto.ToString();
                txtIDProduto.Focus();
            }
        }

        private void txtQtdeSaida_Leave(object sender, EventArgs e)
        {
            Model get = new Model();
            DtoProduto produto = get.GetProdutoID(int.Parse(txtIDProduto.Text));

            txtValorUnidade.Text = produto.valorcusto.ToString();
            decimal total = decimal.Parse(txtQtdeSaida.Text) * decimal.Parse(txtValorUnidade.Text);
            txtValorTotal.Text = total.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
                Model set = new Model();
                DtoSaida u = new DtoSaida();
                u.idproduto = int.Parse(txtIDProduto.Text);
                u.qtdeproduto = Decimal.Parse(txtQtdeSaida.Text);
                u.valortotalproduto = Decimal.Parse(txtValorTotal.Text);
                u.valorcustoproduto = Decimal.Parse(txtValorUnidade.Text);
                u.dtcompra = DateTime.Now;

                set.setSaida(u);

                DtoProduto prod = new DtoProduto();
                prod.id = int.Parse(txtIDProduto.Text);
                prod.quantidade = Decimal.Parse(txtQtdeSaida.Text);
                prod.valorvenda = Decimal.Parse(txtValorTotal.Text);
                prod.valorcusto = Decimal.Parse(txtValorUnidade.Text);

                set.salvarSaida(prod);
            
            
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtIDProduto.Text = string.Empty;
            txtQtdeSaida.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtValorTotal.Text = string.Empty;
            txtValorUnidade.Text = string.Empty;
            HabilitarText();
            txtIDProduto.Focus();
        }

        
    }
}
