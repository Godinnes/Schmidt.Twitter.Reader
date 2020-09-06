using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Schmidt.Twitter.Reader.Api.Controllers
{
    [Controller]
    public class TwittersController
    {
        public TwittersController()
        {

        }
        [HttpGet("Search")]
        public Task<IActionResult> SearchAsync()
        {
            throw new NotImplementedException();
        }
    }
}
