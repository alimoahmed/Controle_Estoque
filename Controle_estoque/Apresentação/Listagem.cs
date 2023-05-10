using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using RawDataPrint;

namespace Controle_estoque
{
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"sua_conexao");
        public int id;

        private void Listagem_Load(object sender, EventArgs e)
        {
            GetProdutos();
        }

        private void GetProdutos()
        {
            SqlConnection con = new SqlConnection(@"sua_conexao");
            SqlCommand cmd = new SqlCommand("Select * from produto", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            ProdutosDataGridView.DataSource = dt;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO produto (nome, descricao, validade, setor, qtdmin, qtdmax,qtdatual, emailfor, emailcom) values (@nome,@descricao,@validade,@setor,@qtdmin,@qtdmax,@qtdatual,@emailfor,@emailcom);", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@validade", txtvalidade.Text);
                cmd.Parameters.AddWithValue("@setor", txtsetor.Text);
                cmd.Parameters.AddWithValue("@qtdmin", txtqtdmin.Text);
                cmd.Parameters.AddWithValue("@qtdmax", txtqtdmax.Text);
                cmd.Parameters.AddWithValue("@qtdatual", txtqtdatual.Text);
                cmd.Parameters.AddWithValue("@emailfor", txtemailfor.Text);
                cmd.Parameters.AddWithValue("@emailcom", txtemailcom.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastrado com sucesso!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetProdutos();
                ResetForm();

            }
        }

        private bool IsValid()
        {
            if (txtnome.Text == string.Empty || txtsetor.Text == string.Empty || txtqtdmin.Text == string.Empty || txtqtdmax.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            id = 0;
            txtnome.Clear();
            txtdescricao.Clear();
            txtvalidade.Clear();
            txtsetor.Clear();
            txtqtdmin.Clear();
            txtqtdmax.Clear();
            txtqtdatual.Clear();
            txtemailfor.Clear();
            txtemailcom.Clear();

            txtnome.Focus();
        }

        private void ProdutosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(ProdutosDataGridView.SelectedRows[0].Cells[0].Value);
            txtnome.Text = ProdutosDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtdescricao.Text = ProdutosDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtvalidade.Text = ProdutosDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtsetor.Text = ProdutosDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtqtdmin.Text = ProdutosDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtqtdmax.Text = ProdutosDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            txtqtdatual.Text = ProdutosDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            txtemailfor.Text = ProdutosDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            txtemailcom.Text = ProdutosDataGridView.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE produto SET nome = @nome, descricao = @descricao, validade = @validade, setor = @setor, qtdmin = @qtdmin, qtdmax = @qtdmax, qtdatual = @qtdatual, emailfor = @emailfor, emailcom = @emailcom WHERE id = @id;", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@validade", txtvalidade.Text);
                cmd.Parameters.AddWithValue("@setor", txtsetor.Text);
                cmd.Parameters.AddWithValue("@qtdmin", txtqtdmin.Text);
                cmd.Parameters.AddWithValue("@qtdmax", txtqtdmax.Text);
                cmd.Parameters.AddWithValue("@qtdatual", txtqtdatual.Text);
                cmd.Parameters.AddWithValue("@emailfor", txtemailfor.Text);
                cmd.Parameters.AddWithValue("@emailcom", txtemailcom.Text);
                cmd.Parameters.AddWithValue("@id", this.id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Editado com sucesso!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetProdutos();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Selecione um produto", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult result = MessageBox.Show("Você realmente deseja excluir este produto?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM produto WHERE id = @id;", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", this.id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Excluido com sucesso!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetProdutos();
                    ResetForm();
                }
                else
                {
                    GetProdutos();
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProdutosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtqtdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtqtdmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtqtdatual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtvalidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtvalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.TextTexto(e);
        }

        private void btncomprimir_Click(object sender, EventArgs e)
        {

            con.Open();

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook newWorkbook = excelApp.Workbooks.Add();

            Excel.Worksheet newWorksheet = newWorkbook.Sheets.Add();
            newWorksheet.Name = "produto";

            string sql = "SELECT * FROM produto";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            int row = 1;
            while (dataReader.Read())
            {
                for (int col = 1; col <= dataReader.FieldCount; col++)
                {
                    newWorksheet.Cells[row, col] = dataReader.GetValue(col - 1).ToString();
                }
                row++;
            }

            Excel.ListObject table = newWorksheet.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange,
                newWorksheet.Range[newWorksheet.Cells[1, 1], newWorksheet.Cells[row - 1, dataReader.FieldCount]], Type.Missing, Excel.XlYesNoGuess.xlYes, Type.Missing);
            table.TableStyle = "TableStyleMedium2";

            string fileName = "_Estoque  " + DateTime.Now.ToString("yyyy-MM-dd HH-mm") + ".xlsx";
            string filePath = "Controle" + fileName;
            newWorkbook.SaveAs(filePath);
            MessageBox.Show("Documento gerado na pasta Documentos", "Document", MessageBoxButtons.OK, MessageBoxIcon.Information);

            newWorkbook.Close();
            excelApp.Quit();
            dataReader.Close();
            cmd.Dispose();
            con.Close();
        }

        private void btnetiqueta_Click(object sender, EventArgs e)
        {

            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand("SELECT nome, setor, data, qtdmin, qtdmax, qtdatual FROM produto WHERE id = @id;", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.id);

                con.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();

                string dadosImpressao = "^XA";
                dadosImpressao += "^MMT";
                dadosImpressao += "^PW1063";
                dadosImpressao += "^LL0827";
                dadosImpressao += "^LS0";
                dadosImpressao += @"^FT73,289^A0N,42,40^FH\^FDAPTIV - JAMBEIRO^FS";
                dadosImpressao += "^BY6,3,132^FT259,681^BCN,,Y,N";
                dadosImpressao += "^FD>:" + this.id + "^FS";
                dadosImpressao += @"^FT541,371^A0N,29,28^FH\^FD" + dataReader["qtdmin"].ToString() + "^FS";
                dadosImpressao += @"^FT505,335^A0N,29,28^FH\^FD" + dataReader["data"].ToString() + "^FS";
                dadosImpressao += @"^FT204,371^A0N,29,28^FH\^FD" + dataReader["qtdmax"].ToString() + "^FS";
                dadosImpressao += @"^FT409,373^A0N,29,28^FH\^FDQTD MIN:^FS";
                dadosImpressao += @"^FT410,335^A0N,29,28^FH\^FDDATA:^FS";
                dadosImpressao += @"^FT72,371^A0N,29,28^FH\^FDQTD MAX:^FS";
                dadosImpressao += @"^FT165,335^A0N,29,28^FH\^FD" + dataReader["nome"].ToString() + "^FS";
                dadosImpressao += @"^FT72,337^A0N,29,28^FH\^FDNOME:^FS";
                dadosImpressao += "^FO34,305^GB791,0,1^FS";
                dadosImpressao += "^PQ1,0,1,Y^XZ";

                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtém a impressora selecionada pelo usuário
                    string printerName = printDialog.PrinterSettings.PrinterName;

                    // Imprime na impressora selecionada
                    if (RawPrinterHelper.SendStringToPrinter(printerName, dadosImpressao))
                    {
                        MessageBox.Show("Etiqueta gerada com sucesso!", "Etiqueta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao imprimir etiqueta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
                dataReader.Close();
                cmd.Dispose();
                GetProdutos();
            }
            else
            {
                MessageBox.Show("Selecione um produto", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}