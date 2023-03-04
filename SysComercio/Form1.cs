using System.Data.SqlClient;

namespace SysComercio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cnx;
                SqlConnection conn;
                cnx = @"Data Source=DCSQL\DANILO;Initial Catalog=dbComercio;User Id=Sa;Password=Dan@8257";
                conn = new SqlConnection(cnx);
                conn.Open();
                MessageBox.Show("Conexão Aberta");
                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro de conexão: " + erro.Message);
            }
        }
    }
}