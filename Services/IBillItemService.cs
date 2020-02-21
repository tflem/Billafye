using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Billafye.Models;

namespace Billafye.Services
{
  public interface IBillItemService
  {
    Task<BillItem[]> GetUnpaidBillItemsAsync();

    Task<bool> AddBillItemAsync(BillItem newBillItem);
  }
}