using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyStoreDuplicate.Pages.Client
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo=new ClientInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
            clientInfo.name=Request.Form["name"];
            clientInfo.email=Request.Form["email"];
            clientInfo.phone=Request.Form["phone"];
            clientInfo.address=Request.Form["address"];
            if(clientInfo.name.Length==0 || clientInfo.email.Length==0 || clientInfo.phone.Length==0 
                || clientInfo.address.Length==0)
            {
               errorMessage="All fields are required";
                return;
            }

            /* Saving in database*/

            clientInfo.name="";
            clientInfo.email="";
            clientInfo.phone="";
            clientInfo.address="";

            successMessage="New Client Added Successfully";
        }
    }
}
