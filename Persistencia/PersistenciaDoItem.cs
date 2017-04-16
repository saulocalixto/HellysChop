using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloWorld.Models;

namespace HelloWorld.Persistencia
{
    public class PersistenciaDoItem
    {
        public IList<ItemModel> Itens { get; set; }

        private PersistenciaDoItem()
        {
            this.Itens = new List<ItemModel>();
            AddProdutos();
        }

        private void AddProdutos()
        {
            ItemModel produto1 = new ItemModel()
            {
                Nome = "Hellys Beer",
                Descricao = "Uma Hellys cerveja para você que quer"
                +"ser cachaceiro que nem o Hellys!",
                Preco = "15,85"
            };
            Itens.Add(produto1);

            ItemModel produto2 = new ItemModel()
            {
            Nome = "Hellys Suco de Fruta",
            Descricao = "Porque Hellys também é saúde!",
            Preco = "10,85"
            };
        Itens.Add(produto2);

        ItemModel produto3 = new ItemModel()
        {
            Nome = "Hellys Big Burger",
            Descricao = "É mais caro que o X-Salada da esquina de sua casa, mas isso Hellys importa!",
        Preco = "10,85"
        };
        Itens.Add(produto3);

        }

        private static PersistenciaDoItem _instancia;

        public static PersistenciaDoItem Atual()
        {

            if (_instancia == null)
            {
                _instancia = new PersistenciaDoItem();
            }

            return _instancia;
        }
    }
}