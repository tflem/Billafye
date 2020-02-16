using System;
using System.ComponentModel.DataAnnotations;

namespace Billafye.Models
{
  public class BillItem
  {
    public Guid Id { get; set; }
    public bool IsPaid { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int BillAmount { get; set; }
    public DateTimeOffset? DueDate { get; set; }
  }
}