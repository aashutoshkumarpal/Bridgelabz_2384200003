using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Multilevel_Inheritance
{
    // Base class
    class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order placed";
        }
    }

    // Subclass ShippedOrder
    class ShippedOrder : Order
    {
        public string TrackingNumber { get; set; }

        public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order shipped with Tracking Number: " + TrackingNumber;
        }
    }

    // Subclass DeliveredOrder
    class DeliveredOrder : ShippedOrder
    {
        public DateTime DeliveryDate { get; set; }

        public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
            : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order delivered on: " + DeliveryDate.ToShortDateString();
        }
    }

}
