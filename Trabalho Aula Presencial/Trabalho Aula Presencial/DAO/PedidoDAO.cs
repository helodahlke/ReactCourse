using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Aula_Presencial.Model;
namespace Trabalho_Aula_Presencial.DAO
{
    class PedidoDAO
    {
        private static List<Pedido> pedidos = new List<Pedido>();
        Context ctx = new Context();

        public bool Cadastrar(Pedido novoPedido)
        {
            try
            {
                ctx.Pedidos.Add(novoPedido);
                ctx.SaveChanges();
                ctx.Dispose();
                Console.WriteLine("Pedido Cadastrado!\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao cadastrar pedido!\n\n" + e);
            }
            return true;
        }

        public Pedido Buscar(Pedido pedido)
        {
            pedidos = ctx.Pedidos.ToList();
            int a = 0;
            pedidos = ctx.Pedidos.ToList();
            int tamPedidos = pedidos.IndexOf(pedido);
            for (a = 0; a < tamPedidos; a++)
            {
                if (pedidos.Contains(pedido))
                {
                    return pedido;

                } 
                
            }
            return pedido;
        }
        public List<Pedido> Listar()
        {
            return ctx.Pedidos.ToList();

        }
        public void Remover(Pedido pedido)
        {
            int a = 0;
            pedidos = ctx.Pedidos.ToList();
            int tamPedidos = pedidos.IndexOf(pedido);
            for (a = 0; a < tamPedidos; a++)
            {
                if (pedidos.Contains(pedido))
                {
                    ctx.Pedidos.Remove(pedido);
                    ctx.SaveChanges();
                    ctx.Dispose();
                }
                else
                {
                    Console.WriteLine("Erro ao apagar pedido!\n\n");
                }
            }


        }
        public void Alterar(Pedido pedido)
        {
            int a = 0;
            pedidos = ctx.Pedidos.ToList();
            int tamPedidos = pedidos.IndexOf(pedido);
            for (a = 0; a < tamPedidos; a++)
            {
                if (pedidos.Contains(pedido))
                {
                    ctx.Pedidos.Update(pedido);
                    ctx.SaveChanges();
                    ctx.Dispose();
                }
                else
                {
                    Console.WriteLine("Erro ao editar pedido!\n\n");
                }
            }
        }
        
    }
}

