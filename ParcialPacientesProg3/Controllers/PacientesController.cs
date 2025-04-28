using Microsoft.AspNetCore.Mvc;
using ParcialPacientesProg3.Models;
using ParcialPacientesProg3.Data;

namespace ParcialPacientesProg3.Controllers
{
    public class PacientesController : Controller
    {

        public BaseDeDatos db = new BaseDeDatos();

        public IActionResult Index()
        {
            var listas = db.ObtenerPacientes();
            return View(listas);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Paciente paciente)
        {
            if (string.IsNullOrEmpty(paciente.Nombre) || string.IsNullOrEmpty(paciente.ObraSocial) ||
                paciente.Edad < 0 || string.IsNullOrEmpty(paciente.Sintomas))
            {
                ViewBag.Mensaje = "Debe llenar todos los campos!!! ";
                return View();
            }

            db.GuardarPaciente(paciente);
            return RedirectToAction("Index");
        }
    }
}

