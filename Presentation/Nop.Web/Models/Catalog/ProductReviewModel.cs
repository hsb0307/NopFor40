using System.Collections.Generic;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;
using Nop.Web.Validators.Catalog;

namespace Nop.Web.Models.Catalog
{
    public partial class ProductReviewOverviewModel : BaseNopModel
    {
        public int ProductId { get; set; }

        /// <summary>
        /// 评价积分
        /// </summary>
        public int RatingSum { get; set; }

        /// <summary>
        /// 总的评论数
        /// </summary>
        public int TotalReviews { get; set; }

        /// <summary>
        /// 允许会员评论
        /// </summary>
        public bool AllowCustomerReviews { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [Validator(typeof(ProductReviewsValidator))]
    public partial class ProductReviewsModel : BaseNopModel
    {
        public ProductReviewsModel()
        {
            Items = new List<ProductReviewModel>();
            AddProductReview = new AddProductReviewModel();
        }
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductSeName { get; set; }

        public IList<ProductReviewModel> Items { get; set; }
        public AddProductReviewModel AddProductReview { get; set; }
    }

    public partial class ProductReviewModel : BaseNopEntityModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        /// <summary>
        /// 允许查看用户信息
        /// </summary>
        public bool AllowViewingProfiles { get; set; }
        
        /// <summary>
        /// 评论标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string ReviewText { get; set; }

        /// <summary>
        /// 评价得分
        /// </summary>
        public int Rating { get; set; }

        public ProductReviewHelpfulnessModel Helpfulness { get; set; }

        public string WrittenOnStr { get; set; }
    }


    public partial class ProductReviewHelpfulnessModel : BaseNopModel
    {
        public int ProductReviewId { get; set; }

        public int HelpfulYesTotal { get; set; }

        public int HelpfulNoTotal { get; set; }
    }

    public partial class AddProductReviewModel : BaseNopModel
    {
        [AllowHtml]
        [NopResourceDisplayName("Reviews.Fields.Title")]
        public string Title { get; set; }

        [AllowHtml]
        [NopResourceDisplayName("Reviews.Fields.ReviewText")]
        public string ReviewText { get; set; }

        [NopResourceDisplayName("Reviews.Fields.Rating")]
        public int Rating { get; set; }

        public bool DisplayCaptcha { get; set; }

        public bool CanCurrentCustomerLeaveReview { get; set; }
        public bool SuccessfullyAdded { get; set; }
        public string Result { get; set; }
    }
}