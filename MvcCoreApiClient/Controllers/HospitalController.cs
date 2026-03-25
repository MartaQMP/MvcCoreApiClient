using MvcCoreApiClient.Models;
using Microsoft.AspNetCore.Mvc;
using MvcCoreApiClient.Services;

namespace MvcCoreApiClient.Controllers
{
    public class HospitalController : Controller
    {
        private ServiceHospitales service;

        public HospitalController(ServiceHospitales service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Servidor()
        {
            List<Hospital> hospitales = await this.service.GetHospitalesAsync();
            return View(hospitales);
        }

        public IActionResult Cliente()
        {
            return View();
        }

        public async Task<IActionResult> Detalles(int id)
        {
            Hospital hospital = await this.service.FindHospitalAsync(id);
            return View(hospital);
        }
    }
}
