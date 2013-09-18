using System.Collections.Generic;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Directory;
using Nop.Core.Domain.Orders;

namespace Nop.Services.Shipping
{
    /// <summary>
    /// 获取运费参数的请求
    /// Represents a request for getting shipping rate options
    /// </summary>
    public partial class GetShippingOptionRequest
    {
        public GetShippingOptionRequest()
        {
            this.Items = new List<ShoppingCartItem>();
        }

        /// <summary>
        /// 客户
        /// Gets or sets a customer
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// 购物车中的条目
        /// Gets or sets a shopping cart items
        /// </summary>
        public virtual IList<ShoppingCartItem> Items { get; set; }

        /// <summary>
        /// 送货地址
        /// Gets or sets a shipping address
        /// </summary>
        public virtual Address ShippingAddress { get; set; }

        /// <summary>
        /// 从哪个国家送货
        /// Shipped from country
        /// </summary>
        public virtual Country CountryFrom { get; set; }

        /// <summary>
        /// 省
        /// Shipped from state/province
        /// </summary>
        public virtual StateProvince StateProvinceFrom { get; set; }

        /// <summary>
        /// 邮编
        /// Shipped from zip/postal code
        /// </summary>
        public virtual string ZipPostalCodeFrom { get; set; }
    }
}
