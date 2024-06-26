using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PHPet.Models;

namespace PHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instancia do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Celma Maria", "397.986.243-08", "paulohumberto@outlook.com", "Strelinha");
        Cliente cliente2 = new Cliente(02, "Isadora Maria", "213.785.214-18", "isaraimunda@outlook.com", "Patera");
        Cliente cliente3 = new Cliente(03, "Ianara", "797.986.543-08", "ianaralarissa@outlook.com", "Lolinha");
        Cliente cliente4 = new Cliente(04, "Maria dos Remédios", "548.216.214-12", "mariadosremediuos@outlook.com", "Jade");
        Cliente cliente5 = new Cliente(05, "Sandra maria", "587.256.147-08", "sandrabrandao@outlook.com", "Dolly");
        Cliente cliente6 = new Cliente(06, "Paulo Humberto", "497.986.243-18", "paulohumberto@outlook.com", "Petrus");
        
        //Lista Clientes
        List<Cliente> listaClientes = new List<Cliente>();
        
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        listaClientes.Add(cliente6);

        ViewBag.listaClientes = listaClientes;    


        //Instancia dos Fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "Celma maria LTDA", "03.386.983/0001-34", "paulohumberto@outlook.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Isadora Maria S/A", "23.785.214/0001-18", "isaraimunda@outlook.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Ianara LTDA", "97.986.543//0001-08", "ianaralarissa@outlook.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Maria dos Remédios S/A", "58.216.214/0001-12", "mariadosremediuos@outlook.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Sandra maria LTDA", "57.256.147/0001-08", "sandrabrandao@outlook.com");
        Fornecedor fornecedor6 = new Fornecedor(06, "Paulo Humberto S/A", "49.986.243/0001-18", "paulohumberto@outlook.com");
        
        //Lista Fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        listaFornecedores.Add(fornecedor6);

        ViewBag.listaFornecedores = listaFornecedores;
        return View();
    }

    public IActionResult Privacy()
    {               
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
