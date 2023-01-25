using AwesomeNetwork.ViewModels.Account;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AwesomeNetwork.Pages
{
    public class IndexModel : PageModel
    {
        public RegisterViewModel RegisterView { get; set; }

        public LoginViewModel LoginView { get; set; }

        public IndexModel()
        {
            RegisterView = new RegisterViewModel();
            LoginView = new LoginViewModel();
        }

        public void OnGet()
        {

        }
    }
}
