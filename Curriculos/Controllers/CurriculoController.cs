using Curriculos.DAO;
using Curriculos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Curriculos.Controllers
{
    public class CurriculoController : Controller
    {
        public IActionResult Index()
        {
            CurriculoDAO dao = new CurriculoDAO();
            List<CurriculoViewModel> c = dao.GetAll();
            return View(c);
        }
        public IActionResult Form()
        {
            CurriculoViewModel c = new CurriculoViewModel();
            return View(c);
        }
        public IActionResult EditarCurriculo()
        {
            CurriculoViewModel c = new CurriculoViewModel();
            return View(c);
        }

        //A partir daki
        public IActionResult Put(CurriculoViewModel curriculo)
        {
            CurriculoDAO dao = new CurriculoDAO();
            dao.Put(curriculo);
            return RedirectToAction("Index");
        }
        public IActionResult Post(CurriculoViewModel curriculo)
        {
            CurriculoDAO dao = new CurriculoDAO();
            dao.Post(curriculo);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int curriculoId)
        {
            CurriculoDAO dao = new CurriculoDAO();
            dao.Delete(curriculoId);
            return RedirectToAction("Index");
        }
        public IActionResult Get(int curriculoId)
        {
            CurriculoDAO dao = new CurriculoDAO();
            CurriculoViewModel curriculo = dao.Get(curriculoId);
            return View("ExibirCurriculo", curriculo);
        }
        public IActionResult GetPut(int curriculoId)
        {
            CurriculoDAO dao = new CurriculoDAO();
            CurriculoViewModel curriculo = dao.Get(curriculoId);
            return View("EditarCurriculo", curriculo);
        }
    }
}
