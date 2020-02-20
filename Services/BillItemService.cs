using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Billafye.Data;
using Billafye.Models;
using Microsoft.EntityFrameworkCore;

namespace Billafye.Services
{
  public class BillItemService : IBillItemService
  {
    private readonly ApplicationDbContext _context;

    public BillItemService(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task<BillItem[]> GetUnpaidBillItemsAsync()
    {
      return await _context.Items
        .Where(billItem => billItem.IsPaid == false)
        .ToArrayAsync();
    }
  }
}
