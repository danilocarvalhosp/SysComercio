
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCategoria
    {
        public static string Inserir(string nome, string descricao)
        {
            DCategoria Obj = new ();
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            return Obj.Inserir(Obj);
        }

        public static string Editar(int idCategoria, string nome, string descricao)
        {
            DCategoria Obj = new ();
            Obj.IdCategoria = idCategoria;
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            return Obj.Editar(Obj);
        }

        public static string Excluir(int idCategoria)
        {
            DCategoria Obj = new ();
            Obj.IdCategoria = idCategoria;
            return Obj.Excluir(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }

        public static DataTable BuscarNome(string textoBuscar)
        {
            DCategoria Obj = new ();
            Obj.TextoBuscar = textoBuscar;
            return Obj.BuscarNome(Obj);
        }
    }
}
