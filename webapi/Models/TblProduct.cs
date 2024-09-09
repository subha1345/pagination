using System;
using System.Collections.Generic;

namespace webapi.Models;

public partial class TblProduct
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? TypeId { get; set; }

    public int? Quantity { get; set; }

    public bool? InStock { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }
}
