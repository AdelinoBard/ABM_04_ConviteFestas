namespace ABM_ConviteFestas.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() => View();

        [HttpGet]
        public ViewResult RsvpForm() => View();

        [HttpPost]
        public ViewResult RsvpForm(ConvidadoResposta convidadoResposta) {
            if (ModelState.IsValid) {
                Repository.AddResponse(convidadoResposta);
                return View("Thanks", convidadoResposta);
            }
            return View();
        }

        public ViewResult ListResponses() => 
            View(Repository.Responses.Where(r => r.WillAttend == true));
    }
}