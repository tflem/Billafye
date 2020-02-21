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

    public async Task<bool> AddBillItemAsync(BillItem newBillItem)
    {
      newBillItem.Id = Guid.NewGuid();
      newBillItem.IsPaid = false;
      //newBillItem.DueDate = DateTimeOffset.Now.AddDays(3);

      //_context.Items.Add(newBillItem);
      _context.Items.Add(newBillItem);

      var saveResult = await _context.SaveChangesAsync();
      return saveResult == 1;
    }
  }
}
