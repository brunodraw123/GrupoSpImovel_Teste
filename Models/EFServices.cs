using System.Linq;
namespace Gerenciamento_Clientes.Models
{
    public class EFServices
    {
        public Cliente acharCliente(int id)
        {
            Cliente clienteEncontrado = null;
            using (var context = new DemoDbContext())
            {
                clienteEncontrado = context.Clientes.Where(s => s.ClienteId == id).FirstOrDefault<Cliente>();
            }
            return clienteEncontrado;
        }

    }
}