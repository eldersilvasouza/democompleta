using Demo.App.Interfaces;
using Demo.Domain.Entities;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {

        private IClienteAppService clienteAppService { get; set; }


        public HomeController(IClienteAppService clienteApp)
        {
            this.clienteAppService = clienteApp ?? throw new ArgumentNullException(nameof(clienteAppService));
        }


        public Task <ActionResult> Index()
        {

            return Task.Factory.StartNew<ActionResult>(() => View());            
        }


        [HttpGet]
        public async Task<ActionResult> List()
        {
            return await Task.Factory.StartNew<ActionResult>(() =>
            {
                var clientes = this.clienteAppService.GetAllAsync().Result;

                List<ClienteViewModel> result = new List<ClienteViewModel>();

                foreach (var item in clientes)
                {
                    result.Add(new ClienteViewModel()
                    {
                        Id = item.Id,
                        Agencia = item.Agencia,
                        Conta = item.Conta,
                        Cpf = item.Cpf,
                        Estado = item.Estado,
                        Nome = item.Nome
                    });
                }

                return View(result);

            });
        }


        [HttpPost]
        public async Task<ActionResult> Salvar(ClienteViewModel model)
        {

            if (!ModelState.IsValid)
                return await
                        Task.Factory.StartNew<ActionResult>(() => View("Index", ModelState));


            return await Task.Factory.StartNew<ActionResult>(() =>
            {
                Cliente cliente = new Cliente()
                {
                    Agencia = model.Agencia,
                    Conta = model.Conta,
                    Cpf = model.Cpf,
                    Estado = model.Estado,
                    Nome = model.Nome
                };


                this.clienteAppService.SaveAsync(cliente);

                ViewBag.Sucesso = 1;

                return View("Index");
            }

            );

        }


    }
}
