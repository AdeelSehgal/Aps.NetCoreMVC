using Microsoft.AspNetCore.Mvc;

namespace MyBookStore.Controllers
{
	public class HomeController:Controller
	{
		public string Index()
		{
			return "Hello Adeel";
		}
	}
}
