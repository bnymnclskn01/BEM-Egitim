using ECommerce.BusinessLayer.Abstract;
using ECommerce.WebUI.Extensions;
using ECommerce.WebUI.Identity;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IEmailSender _emailSender;
        private ICartService _cartService;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender emailSender, ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _cartService = cartService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new Models.RegisterModel());
        }
        [Route("Account/Register")]
        [HttpPost]
        public async Task<IActionResult> Register(Models.RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.Email,
                FullName = model.FullName
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await _userManager.GenerateChangeEmailTokenAsync(user, user.Email);
                var callbackUrl = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                await _emailSender.SendEmailAsync(model.Email, "Hesabınızı Onaylayınız.", $"Lütfen email hesabınızı onaylamak için linke tıklayınız <a href='#'>Hesabınızı Onaylayınız</a>");
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Hesap Onayı",
                    Message = "E-posta adresine gelen link ile hesabınızı onaylayınız",
                    Css = "warning"
                });
                ModelState.AddModelError("", "Bilinmeyen Bir Hata Oluştu Lütfen Tekrar Deneyiniz");
            }
            return View(model);
        }

        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new Models.LoginModel()
            {
                ReturnUrl = ReturnUrl,
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(Models.LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Bu E-posta adresi ile daha önceden hesap oluşturulmamıştır. Lütfen hesabınız yoksa kayıt oluşturunuz.");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lütfen hesabınızı email ile onaylayınız.");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            ModelState.AddModelError("", "Email veya parola yanlış girdiniz. Lütfen tekrar deneyiniz.");
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData.Put("message", new Models.ResultMessage()
            {
                Title = "Oturum Kapatıldı",
                Message = "Hesabınız güvenli bir şekilde sonlandırıldı",
                Css = "Warning"
            });
            return Redirect("~/");
        }

        public async Task<IActionResult> ConfirmEmail(string userID, string Token)
        {
            if (userID == null || Token == null)
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Hesap Onayı",
                    Message = "Hesap onayı için bilgileriniz yanlış",
                    Css = "danger"
                }); ;
                return Redirect("~/");
            }
            else
            {
                var user = await _userManager.FindByIdAsync(userID);
                if (user != null)
                {
                    var result = await _userManager.ConfirmEmailAsync(user, Token);
                    if (result.Succeeded)
                    {
                        _cartService.InitializeCart(user.Id);
                        TempData.Put("message", new ResultMessage()
                        {
                            Title = "Hesap Onayı",
                            Message = "Hesabınız başarıyla onaylanmıştır",
                            Css = "success"
                        });
                        return RedirectToAction(nameof(Login));
                    }
                }
                else
                {
                    TempData.Put("message", new ResultMessage()
                    {
                        Title = "Hesap Onayı",
                        Message = "Hesabınız onaylanamadı.",
                        Css = "danger"
                    });
                    return View();
                }
                return View();
            }
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Şifremi Unuttum",
                    Message = "Bilgileriniz Hatalı",
                    Css = "danger"
                });
                return View();
            }
            var user = await _userManager.FindByEmailAsync(Email);
            if (user == null) 
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title="Şifremi Unuttum",
                    Message="E-posta adresi ile bir kullanıcı bulunamadı",
                    Css="danger"
                });
                return View();
            }
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = Url.Action("ResetPassword", "Account", new
            {
                token = "code"
            });
            await _emailSender.SendEmailAsync(Email, "Şifremi Unuttum", $"Parolanızı yenilemek için linke <a href='#'>Tıklayınız</a>");
            TempData.Put("message", new ResultMessage()
            {
                Title="Şifremi Unuttum",
                Message="Parolanızı yenilemek için hesabınıza mail gönderildi",
                Css="warning"
            });
            return RedirectToAction(nameof(Login));
        }
    }
}
