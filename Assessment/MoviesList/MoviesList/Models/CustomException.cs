using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MoviesList.Models
{
    public class CustomException : ExceptionFilterAttribute
    {
        public void OnException(ExceptionContext context)
        {

            context.Result = new ViewResult
            {
                ViewName = "Error",

            };
          
            var errorMsg = context.Exception.Message;

           
               
           
        }
    }
}
