using Microsoft.AspNetCore.Mvc;
using WineShop.Services;

namespace WineShop.ViewComponents
{
    public class ArdoakViewComponent : ViewComponent
    {
        private readonly IArdoaService _ardoaService;
        public ArdoakViewComponent(IArdoaService ardoaService)
        {
            _ardoaService = ardoaService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.mota = id;
            return View(await _ardoaService.GetMota(id));
        }
    }
}
