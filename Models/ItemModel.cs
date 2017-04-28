using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class ItemModel
    {
        public ItemModel()
        {
            //Codigo = _Codigo;
            //_Codigo++;
        }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        //private static int _Codigo = 0;
        public int Codigo { get; set; }
        public TabelaNutricional TabelaNutricional { get; set; }
        public Nutriente NutrientePrincipal { get; set; }
    }
}