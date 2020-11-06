using System.Threading.Tasks;
using Fluent.Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fluent.Validation.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DeveloperController: ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(Developer developer)
        {
            return await Task.FromResult(Ok());
        }
    }
}