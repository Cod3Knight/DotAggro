using Business;
using Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Authorize]
    public class PoleController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly DataContext _ctx;

        /// <summary>
        /// 
        /// </summary>
        public PoleController(DataContext context)
        {
            _ctx = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "read")]
        public IActionResult Index()
        {
            var poleList = new ServicePole(_ctx).Get();

            ViewBag.Toto = "Bonjour";
            ViewData["result"] = "Bonjour 2";

            return View(poleList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("/Pole/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var result = new ServicePole(_ctx).Get(id);
            return View(result);
        }

        [HttpPost("/pole/add")]
        public IActionResult Add(Pole model)
        {
            new ServicePole(_ctx).Update(model);

            TempData["message"] = "Bravo pour l'ajout";

            return RedirectToAction("Index");
        }
    }
}