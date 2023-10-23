﻿namespace MercadoPago.Resource.MerchantOrder
{
    using System;

    /// <summary>
    /// Estimated delivery time information.
    /// </summary>
    public class MerchantOrderShippingEstimatedDelivery
    {
        /// <summary>
        /// Estimated delivery date.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Estimated lower delivery time.
        /// </summary>
        public string TimeFrom { get; set; }

        /// <summary>
        /// Estimated upper delivery time.
        /// </summary>
        public string TimeTo { get; set; }
    }
}
