
using Microsoft.AspNetCore.Mvc;

public class AlunoController : Controller
{
   
    public IActionResult Index()
    {
        ViewBag.Nome = "Endy";
        ViewBag.Curso= "ADS - Analise e desenvolvimento de sistemas";
        ViewBag.Semestre= "1º semestre";
        return View();
    }

     public IActionResult detalhes(int id)
    {
        ViewBag.Aluno = id;
        return View();
    }

}