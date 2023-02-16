using ImageHoster.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ImageHoster.Blazor.Controllers
{
    [Route("controller")]
    public class BasicPhotoController : Controller
    {
        private readonly IBasicPhotoService _basicPhotoService;

        public BasicPhotoController(IBasicPhotoService basicPhotoService)
        {
            _basicPhotoService = basicPhotoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allPhotos = _basicPhotoService.GetAllPhotos();
            return new JsonResult(allPhotos);
        }
    }
}
