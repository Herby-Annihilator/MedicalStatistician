using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace MedicalStatistician.UI.Blazor.Pages
{
    public class LoginModel : ComponentBase
    {
                

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public LoginViewModel LoginData { get; set; }
        public LoginModel()
        {
            LoginData = new();
        }

        protected Task LoginAsync()
        {
            
            NavigationManager.NavigateTo("/statisticalMap");
            return Task.CompletedTask;
        }
        
    }

    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
