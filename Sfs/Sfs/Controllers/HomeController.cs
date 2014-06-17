﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sfs.Services;
using Sfs.ViewModels;

namespace Sfs.Controllers
{
    public class HomeController : CustomController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult VerLista(Guid id)
        {
            var atividade = Context.Atividades.Find(id);
            atividade.Inscricoes = atividade.Inscricoes.OrderByDescending(i => i.CoeficienteSorte).ToList();
            return View(new _ListarViewModel { Atividade = atividade, IdAtividade = atividade.Id, MostrarCheckboxes = false});
        }
    }
}