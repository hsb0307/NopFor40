
namespace Nop.Services.Shipping
{
    /// <summary>
    /// 运费计算类型
    /// Represents a shipping rate computation method type
    /// </summary>
    public enum ShippingRateComputationMethodType : int
    {
        /// <summary>
        /// 未知
        /// Unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// 离线
        /// Offline
        /// </summary>
        Offline = 10,
        /// <summary>
        /// 实时
        /// Realtime
        /// </summary>
        Realtime = 20
    }
}
