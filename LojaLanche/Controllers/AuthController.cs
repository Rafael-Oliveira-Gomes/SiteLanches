using Microsoft.AspNetCore.Mvc;
using LojaLanche.Core.Dto;
using LojaLanche.Core.Interface.Command;
using System;
using System.Threading.Tasks;

namespace LojaLanche.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthCommand _authCommand;

        public AuthController(IAuthCommand authCommand)
        {
            _authCommand = authCommand;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto signUpDto)
        {
            if (!ModelState.IsValid)
            {
                return View(signUpDto);
            }

            var response = await _authCommand.SignUp(signUpDto);

            if (!response.Success)
            {
                ModelState.AddModelError("", response.Message);
                return View(signUpDto);
            }

            return RedirectToAction("SignIn");
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInDto signInDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(signInDTO);
            }

            var response = await _authCommand.SignIn(signInDTO);

            if (!response.Success)
            {
                ModelState.AddModelError("", response.Message);
                return View(signInDTO);
            }

            // Aqui você pode adicionar a lógica para redirecionar para a página desejada após o login bem-sucedido
            return RedirectToAction("Index", "Home");
        }
    }
}
