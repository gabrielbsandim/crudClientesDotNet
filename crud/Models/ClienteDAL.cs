using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public class ClienteDAL : IClienteDAL
    {
        string connectionString = @"Data Source=LAPTOP-F2MTS77P\SQLEXPRESS01;Initial Catalog=db_gabriel;Integrated Security=True;";
        public IEnumerable<Cliente> GetAllClientes()
        {
            List<Cliente> lstcliente = new List<Cliente>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT ClienteId, Nome, Telefone, Endereco, Cep," +
                    " Sexo, Idade from Clientes", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ClienteId = Convert.ToInt32(rdr["ClienteId"]);
                    cliente.Nome = rdr["Nome"].ToString();
                    cliente.Telefone = rdr["Telefone"].ToString();
                    cliente.Endereco = rdr["Endereco"].ToString();
                    cliente.Cep = rdr["Cep"].ToString();
                    cliente.Sexo = rdr["Sexo"].ToString();
                    cliente.Idade = Convert.ToInt32(rdr["Idade"]);
                    lstcliente.Add(cliente);
                }
                con.Close();
            }
            return lstcliente;
        }
                      
        public void AddCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Insert into Clientes (Nome, Telefone, Endereco, Cep, Sexo, Idade) " +
                    "Values(@Nome, @Telefone, @Endereco, @Cep, @Sexo, @Idade)";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@Cep", cliente.Cep);
                cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                cmd.Parameters.AddWithValue("@Idade", cliente.Idade);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteCliente(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Delete from Clientes where ClienteId = @ClienteId";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ClienteId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        /*public IEnumerable<Cliente> GetAllClientes()
        {
            throw new NotImplementedException();
        }*/

        public Cliente GetCliente(int? id)
        {
            Cliente cliente = new Cliente();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Clientes WHERE ClienteId= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cliente.ClienteId = Convert.ToInt32(rdr["ClienteId"]);
                    cliente.Nome = rdr["Nome"].ToString();
                    cliente.Telefone = rdr["Telefone"].ToString();
                    cliente.Endereco = rdr["Endereco"].ToString();
                    cliente.Cep = rdr["Cep"].ToString();
                    cliente.Sexo = rdr["Sexo"].ToString();
                    cliente.Idade = Convert.ToInt32(rdr["Idade"]);
                }
            }
            return cliente;
        }

        public void UpdateCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Update Funcionarios set Nome = @Nome, Telefone = @Telefone, Endereco = @Endereco, " +
                    "Cep = @Cep, Sexo = @Sexo, Idade = @Idade where ClienteId = @ClienteId";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteId);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@Cep", cliente.Cep);
                cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                cmd.Parameters.AddWithValue("@Idade", cliente.Idade);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
