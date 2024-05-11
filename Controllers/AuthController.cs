
using Microsoft.AspNetCore.Mvc;
using RealStateApplication.Models.ViewModels.Auth;


namespace RealStateApplication.Controllers
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginViewModel model){
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            return Redirect("/home/index");
        }

        [HttpGet("Register")]
        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterViewModel model){
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            return Redirect("/home/index");
        }

        [HttpGet("forgot-my-password")]
        public IActionResult ForgotMyPassword()
        {
            return View();
        }

    }
}