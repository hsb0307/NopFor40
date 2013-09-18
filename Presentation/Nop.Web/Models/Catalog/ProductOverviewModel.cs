using System;
using System.Collections.Generic;
using Nop.Web.Framework.Mvc;
using Nop.Web.Models.Media;

namespace Nop.Web.Models.Catalog
{
    /// <summary>
    /// 商品概述页面模型
    /// </summary>
    public partial class ProductOverviewModel : BaseNopEntityModel
    {
        public ProductOverviewModel()
        {
            ProductPrice = new ProductPriceModel();
            DefaultPictureModel = new PictureModel();
            SpecificationAttributeModels = new List<ProductSpecificationModel>();
            ReviewOverviewModel = new ProductReviewOverviewModel();
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        /// <summary>
        /// SEO名称
        /// </summary>
        public string SeName { get; set; }

        //price
        /// <summary>
        /// 商品价格
        /// </summary>
        public ProductPriceModel ProductPrice { get; set; }
        //picture
        public PictureModel DefaultPictureModel { get; set; }
        //specification attributes
        public IList<ProductSpecificationModel> SpecificationAttributeModels { get; set; }
        //price
        public ProductReviewOverviewModel ReviewOverviewModel { get; set; }

		#region Nested Classes

        /// <summary>
        /// 商品价格
        /// </summary>
        public partial class ProductPriceModel : BaseNopModel
        {
            public string OldPrice { get; set; }
            public string Price {get;set;}

            /// <summary>
            /// 不显示购买按钮
            /// </summary>
            public bool DisableBuyButton { get; set; }
            /// <summary>
            /// 不显示收藏按钮
            /// </summary>
            public bool DisableWishlistButton { get; set; }

            /// <summary>
            /// 预订有效
            /// </summary>
            public bool AvailableForPreOrder { get; set; }
            public DateTime? PreOrderAvailabilityStartDateTimeUtc { get; set; }
            /// <summary>
            /// 转到购物车
            /// </summary>
            public bool ForceRedirectionAfterAddingToCart { get; set; }
        }

		#endregion
    }
}