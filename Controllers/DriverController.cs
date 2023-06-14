using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

namespace bus_project.Controllers;

public class DriverController : Controller
{
    private readonly YourDbContext _dbContext;

    public DriverController(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult DriverList()
    {
        var driversList = _dbContext.DriversList.ToList();
        return View("~/Views/Driver/DriverList.cshtml", driversList);

    }


}