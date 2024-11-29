using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukesAPI.Controllers.ESPN
{
    [Route("api/ESPN/EspnNFL/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "EspnNFL/")]
    [Authorize]
    public class EspnNFL : IEspnNFL
    {

    }
}
