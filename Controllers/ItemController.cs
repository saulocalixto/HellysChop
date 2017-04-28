using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;
using HelloWorld.Persistencia;
using HelloWorld.Conexao;

namespace HelloWorld.Controllers
{
    public class ItemController : Controller
    {
        //
        // GET: /Item/

        [HttpGet]
        public ActionResult Index()
        {
            return View("IndexCardapio", PersistenciaDoItem.Atual().Itens);
        }

        public ActionResult IndexCadastro()
        {
            return View("IndexCadastroItem");
        }

        [HttpPost]
        public ActionResult IndexCadastro(ItemModel item)
        {
            //PersistenciaDoItem.Atual().Itens.Add(item);
            String StringSQL = "SELECT * FROM ITEM";
            var con = new ConexaoBancoDeDados(StringSQL);
            con.ObtenhaConexaoExecuteComando();
            return View("IndexCadastroItem");
        }

        //public ActionResult Edit(int codigo)
        //{
        //    //ItemModel produto = new ItemModel();
        //    //foreach(var item in PersistenciaDoItem.Atual().Itens)
        //    //{
        //    //    if(item.Codigo == codigo)
        //    //    {
        //    //        produto = item;
        //    //    }
        //    //}
        //    //return View("IndexCadastroItem", produto);
        //}

        //[HttpPost]
        //public ActionResult Edit(ItemModel produto, int codigo)
        //{
        //    //if(produto != null)
        //    //{
        //    //    for (int i = 0; i < PersistenciaDoItem.Atual().Itens.Count; i++)
        //    //    {
        //    //        if(codigo == PersistenciaDoItem.Atual().Itens[i].Codigo)
        //    //        {
        //    //            PersistenciaDoItem.Atual().Itens[i] = produto;
        //    //        }
        //    //    }
        //    //    return RedirectToAction("Index");
        //    //}
        //    //else
        //    //{
        //    //    return View();
        //    //}
        //}

        //public ActionResult Delete(int codigo)
        //{
        //    //ItemModel produto = new ItemModel();
        //    //foreach (var item in PersistenciaDoItem.Atual().Itens)
        //    //{
        //    //    if (item.Codigo == codigo)
        //    //    {
        //    //        produto = item;
        //    //    }
        //    //}
        //    //return View("IndexDelete", produto);
        //}

        //[HttpPost]
        //public ActionResult Delete(ItemModel produto, int codigo)
        //{
        //    //if (produto != null)
        //    //{
        //    //    for (int i = 0; i < PersistenciaDoItem.Atual().Itens.Count; i++)
        //    //    {
        //    //        if (codigo == PersistenciaDoItem.Atual().Itens[i].Codigo)
        //    //        {
        //    //            produto = PersistenciaDoItem.Atual().Itens[i];
        //    //            PersistenciaDoItem.Atual().Itens.Remove(produto);
        //    //        }
        //    //    }
        //    //    return RedirectToAction("Index");
        //    //}
        //    //else
        //    //{
        //    //    return View();
        //    //}
        //}

    }
}
