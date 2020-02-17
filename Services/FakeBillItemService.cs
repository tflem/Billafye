using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Billafye.Models;

namespace Billafye.Services
{
  public class FakeBillItemService : IBillItemService
  {
    public Task<BillItem[]> GetUnpaidBillItemsAsync()
    {
      var billItemOne = new BillItem
      {
        Name = "Sask Power",
        BillAmount = 89.45M,
        DueDate = DateTimeOffset.Now.AddDays(1)
      };

      var billItemTwo = new BillItem
      {
        Name = "Regina Water",
        BillAmount = 132.16M,
        DueDate = DateTimeOffset.Now.AddDays(1)
      };

      return Task.FromResult(new[] { billItemOne, billItemTwo });
    }
  }
}