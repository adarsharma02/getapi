using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentnamebyId.bl;
using studentnamebyId.model;

namespace studentnamebyId.controler
{
    [Route("api/[controller]")]
    [ApiController]
    public class monthController1 : ControllerBase
    {
        [HttpGet("{month}")]
        public monthmodel myMonth(int month)
        {
            monthinfo monthfullDetails = new monthinfo();
            return monthfullDetails.getDetails(month);
        }
    }
}
