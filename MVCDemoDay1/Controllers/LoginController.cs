//using GoogleAuthenticatorService.Core;
//using Microsoft.AspNetCore.Mvc;
//using MVCDemoDay1.Models;

//namespace MVCDemoDay1.Controllers
//{
//    public class LoginController : Controller
//    {
//        private readonly IConfiguration _configuration;
//        public LoginController(IConfiguration configuration)
//        {
//            _configuration = configuration;
//        }
//        [HttpGet]
//        [Route("login")]
//        public IActionResult Login()
//        {
//            GlobalData.isLoggedIn = false;
//            var message = TempData["message"];
//            ViewBag.Message = message;
//            return View();
//        }

//        [HttpPost]
//        [Route("login")]
//        public ActionResult Verify(LoginModel login)
//        {
//            string? username = HttpContext.Session.GetString("Username");
//            string isValidStr = HttpContext.Session.GetString("IsValidTwoFactorAuthentication");
//            bool? isValidTwoFactorAuthentication = isValidStr != null ? bool.Parse(isValidStr) : (bool?)null;

//            if (username == null || isValidTwoFactorAuthentication == false || isValidTwoFactorAuthentication == null)
//            {
//                if (login.Username == "Admin" && login.Password == "12345")
//                {
//                    HttpContext.Session.SetString("Username", login.Username);
//                    return RedirectToAction("MultiFactorAuthentication");
//                }
//            }
//            return RedirectToAction("Index");
//        }
//        [HttpGet]
//        [Route("multi-factor-authentication")]
//        public IActionResult MultiFactorAuthentication()
//        {
//            if (HttpContext.Session.GetString("Username") == null)
//            {
//                return RedirectToAction("Login");
//            }
//            string? username = HttpContext.Session.GetString("Username");
//            string authKey = _configuration.GetValue<string>("AuthenticatorKey");
//            string userUniqueKey = username + authKey;
//            // Two Factor Authentication Setup
//            TwoFactorAuthenticator twoFacAuth = new();
//            var setupInfo = twoFacAuth.GenerateSetupCode(
//                "MultiFactorAuthenticationDemo",
//                username,ConvertSecretToBytes(userUniqueKey, false),
//                300
//            );
//            HttpContext.Session.SetString("UserUniqueKey", userUniqueKey);
//            ViewBag.BarcodeImageUrl = setupInfo.QrCodeSetupImageUrl;
//            ViewBag.SetupCode = setupInfo.ManualEntryKey;
//            return View();
//        }
//        [HttpPost]
//        public ActionResult MultiFactorAuthenticate()
//        {
//            var token = Request.Form["CodeDigit"];
//            TwoFactorAuthenticator TwoFacAuth = new();
//            string? UserUniqueKey = HttpContext.Session.GetString("UserUniqueKey");

//            // bool isValid = TwoFacAuth.ValidateTwoFactorPIN(UserUniqueKey, token);
//            bool isValid = TwoFacAuth.ValidateTwoFactorPIN(UserUniqueKey, token, TimeSpan.FromSeconds(90)); // will be valid for 30 seconds
//            if (isValid)
//            {
//                HttpContext.Session.SetString("IsValidTwoFactorAuthentication", "true");
//                GlobalData.isLoggedIn = true;
//                return RedirectToAction("Dashboard");
//            }
//            TempData["message"] = "Google Two Factor PIN is expired or wrong";
//            return RedirectToAction("Login");
//        }

//        public ActionResult Dashboard()
//        {
//            if (HttpContext.Session.GetString("IsValidTwoFactorAuthentication") == "true")
//            {
//                return View();
//            }
//            else
//            {
//                return RedirectToAction("Login");
//            }
//        }

//        public ActionResult Logout()
//        {
//            HttpContext.Session.Remove("UserName");
//            HttpContext.Session.Remove("IsValidTwoFactorAuthentication");
//            HttpContext.Session.Remove("UserUniqueKey");
//            return RedirectToAction("Login");
//        }


//    }
//}
