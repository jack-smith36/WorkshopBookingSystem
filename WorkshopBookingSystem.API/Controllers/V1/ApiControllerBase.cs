using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace WorkshopBookingSystem.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
public abstract class ApiControllerBase : ControllerBase
{
    
}