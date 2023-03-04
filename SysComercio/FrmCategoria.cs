using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace SysComercio
{
    public partial class FrmCategoria : Form
    {
        #region VARIÁVEIS GLOBAIS

        private bool eNovo = false;
        private bool eEditar = false;

        #endregion

        #region EVENTOS DE FORMULÁRIO
        public FrmCategoria()
        {
            InitializeComponent();
            ttMensagem.SetToolTip(txtNome, "Insira o nome da Categoria");
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            MostrarColunas();
            HabilitarCampos(false);
            HabilitarBotoes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            eNovo = true;
            eEditar = false;
            HabilitarBotoes();
            LimparCampos();
            HabilitarCampos(true);
            txtNome.Focus();
            txtIdCategoria.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (txtNome.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos");
                    errorIcone.SetError(txtNome, "Insira o nome");
                }
                else
                {
                    if (eNovo)
                    {
                        resp = NCategoria.Inserir(txtNome.Text.Trim().ToUpper(), txtDescricao.Text.Trim().ToUpper());
                    }
                    else
                    {
                        resp = NCategoria.Editar(Convert.ToInt32(txtIdCategoria.Text), txtNome.Text.Trim().ToUpper(), txtDescricao.Text.Trim().ToUpper());
                    }

                    if (resp.Equals("Ok"))
                    {
                        if (eNovo)
                        {
                            MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            MensagemOk("Registro atualizado com sucesso");
                        }
                    }
                    else
                    {
                        MensagemErro(resp);
                    }

                    eNovo = false;
                    eEditar = false;
                    HabilitarBotoes();
                    LimparCampos();
                    MostrarColunas();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            txtIdCategoria.Text = Convert.ToString(dataLista.CurrentRow.Cells ["idcategoria"].Value);
            txtNome.Text = Convert.ToString(dataLista.CurrentRow.Cells ["nome"].Value);
            txtDescricao.Text = Convert.ToString(dataLista.CurrentRow.Cells ["descricao"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIdCategoria.Text.Equals(""))
            {
                MensagemErro("Selecione um registro para inserir");
            }
            else
            {
                eEditar = true;
                HabilitarBotoes();
                HabilitarCampos(true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            eNovo = false;
            eEditar = false;
            HabilitarBotoes();
            HabilitarCampos(false);
            LimparCampos();
        }

        private void chkExcluir_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluir.Checked)
            {
                dataLista.Columns [0].Visible = true;
            }
            else
            {
                dataLista.Columns [0].Visible = false;
            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns ["Excluir"].Index)
            {
                DataGridViewCheckBoxCell chkExcluir = (DataGridViewCheckBoxCell) dataLista.Rows [e.RowIndex].Cells ["Excluir"];
                chkExcluir.Value = !Convert.ToBoolean(chkExcluir.Value);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar os registros selecionados?", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcao == DialogResult.OK)
                {
                    string codigo;
                    string resp = "";

                    foreach (DataGridViewRow linha in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(linha.Cells [0].Value))
                        {
                            codigo = linha.Cells [1].Value.ToString();
                            resp = NCategoria.Excluir(Convert.ToInt32(codigo));

                            if (resp.Equals("Ok"))
                            {
                                MensagemOk("Registros excluídos com sucesso.");
                            }
                            else
                            {
                                MensagemErro(resp);
                            }
                        }
                    }
                    MostrarColunas();
                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region MÉTODOS
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Comércio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Comércio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdCategoria.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        private void HabilitarCampos(bool valor)
        {
            txtNome.ReadOnly = !valor;
            txtIdCategoria.ReadOnly = !valor;
            txtDescricao.ReadOnly = !valor;
        }

        private void HabilitarBotoes()
        {
            if (eNovo || eEditar)
            {
                HabilitarCampos(true);
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                HabilitarCampos(false);
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void OcultarColunas()
        {
            dataLista.Columns [0].Visible = false;
            dataLista.Columns [1].Visible = false;
        }

        private void MostrarColunas()
        {
            dataLista.DataSource = NCategoria.Mostrar();
            OcultarColunas();
            lblTotal.Text = $"Total de registros: {dataLista.Rows.Count.ToString()}";
        }

        private void BuscarNome()
        {
            dataLista.DataSource = NCategoria.BuscarNome(txtBuscar.Text);
            OcultarColunas();
            lblTotal.Text = $"Total de registros: {dataLista.Rows.Count}";
        }
        #endregion

    }
}
