using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    /// <summary>
    /// Представляет собой запись в таблице доставок
    /// </summary>
    public class Shipment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public string CourierInfo { get; set; }
    }
}
