using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xcersise.Api.Models.Excersise;

namespace Xcersise.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcersiseController : ControllerBase
    {
		[HttpGet("GetExcersises")]
		public IEnumerable<ExcersiseType> GetExcersises()
        {
			return new ExcersiseType[] {
				new()
                {
					Title = "Jog",
					Description = "Train stamina and last longer on the road"
				},
				new() { 
					Title = "Weight Lifting",
					Description = "Grow stronger and more powerful"
				},
				new() {
					Title = "Yoga",
					Description = "Find peace within yourself"
				}
			};
		}
    }
}
