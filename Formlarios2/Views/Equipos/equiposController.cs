using AspNetCore;
using Microsoft.AspNetCore.Mvc

namespace Formlarios2.Views.Equipos



public class equiposController : Controller
{
    private readonly equiposDbContext _equiposDbContext;

    public equiposController(equiposDbContext equiposDbContext)
    {
        _equiposDbContext=equiposDbContext;
    }
}
