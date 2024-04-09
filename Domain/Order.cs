using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class Order
{
    public Guid OrderId { get; set; }
    public Guid UserID { get; set; }
    public int OrderTotal { get; set; }
    public DateTime OederPlaced { get; set; }
    public bool OrderPaid { get; set; }
}
