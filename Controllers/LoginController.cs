using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
  //      TravelDbContext context = new TravelDbContext();
  //      public IActionResult Index()
  //      {
  //          return View();
  //      }
		//public IActionResult Login()
		//{
		//	return View();
		//}
		//[HttpPost]
  //      public async Task<IActionResult> LoginAsync(Admin datas)
  //      {
		//	var loginDatas = context.Admins.FirstOrDefault(a => a.User == datas.User && a.Password == datas.Password);

		//	if (loginDatas != null)
		//	{
		//		List<Claim> claims = new List<Claim>
		//		{
		//			new Claim(ClaimTypes.NameIdentifier, loginDatas.User) // You can add more claims if needed
		//		};

		//		ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
		//			CookieAuthenticationDefaults.AuthenticationScheme);
		//		AuthenticationProperties properties = new AuthenticationProperties()
		//		{ 
		//			AllowRefresh = true,
		//			IsPersistent = false,
		//		};

		//		await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
		//			new ClaimsPrincipal(claimsIdentity), properties);

		//		return RedirectToAction("Index","Admin"); // Redirect to a dashboard or some other page after successful login
		//	}
			

		//	// Handle invalid login here
		//	return View();
		//}
    }
}
