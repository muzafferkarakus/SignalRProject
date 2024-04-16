using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.MenuComponent
{
    public class _MenuNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
