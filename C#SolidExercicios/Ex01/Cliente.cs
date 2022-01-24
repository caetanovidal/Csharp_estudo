using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }
        public static List<Cliente> GetClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>()
            {
                new Cliente
                {
                    Nome="Pedro", Pais="Brasil", Email="pedro@email.com"
                },
                new Cliente
                {
                    Nome="Maria", Pais="Chile", Email="maria@email.com"
                }
            };
            return listaClientes;
        }
    }
}
