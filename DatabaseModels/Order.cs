using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    /// <summary>
    /// Представляет собой запись в таблице заказов
    /// </summary>
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; } 
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public Shipment? Shipment { get; set; }
    }
}
