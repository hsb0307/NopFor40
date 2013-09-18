
namespace Nop.Services.Shipping
{
    /// <summary>
    /// �˷Ѽ�������
    /// Represents a shipping rate computation method type
    /// </summary>
    public enum ShippingRateComputationMethodType : int
    {
        /// <summary>
        /// δ֪
        /// Unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// ����
        /// Offline
        /// </summary>
        Offline = 10,
        /// <summary>
        /// ʵʱ
        /// Realtime
        /// </summary>
        Realtime = 20
    }
}
