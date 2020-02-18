using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Billafye.Services;
using Billafye.Models;

namespace Billafye.Controllers
{
  public class BillController : Controller
  {
    // Actions Go Here
    private readonly IBillItemService _billItemService;

    public BillController(IBillItemService billItemService)
    {
      _billItemService = billItemService;
    }
    public async Task<IActionResult> Index()
    {
      // Get List of Bills from DB
      var items = await _billItemService.GetUnpaidBillItemsAsync();

      // Place Bill Items into Model
      var model = new BillafyeViewModel()
      {
        Items = items
      };

      return View(model);
    }
  }

}