using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public interface IClienteDAL
    {
        IEnumerable<Cliente> GetAllClientes();
        void AddCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        Cliente GetCliente(int? id);
        void DeleteCliente(int? id);
    }
}
