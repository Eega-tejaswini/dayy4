using System.Diagnostics;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;




namespace ReliabiltyDemo.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel

    {
        public int StatusCode { get; private set; }




        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int code)
        {

            StatusCode = code;
            if (code == 500)
            {
                _logger.LogError("A 500 Internal Server Error Occured ");
            }
            else if (code == 404)
            {
                _logger.LogError("A 404 Not Found Error Occured ");
            }
            else
            {
                _logger.LogInformation("Error with status code {StatusCode} occured", StatusCode);
            }
        }
    }
    }

