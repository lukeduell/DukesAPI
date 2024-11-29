using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukesAPI.Controllers.ESPN
{
    [Route("api/ESPN/EspnMLB/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "EspnMLB/")]
    [Authorize]
    public class EspnMLB : IEspnMLB
    {
        
    }
}
