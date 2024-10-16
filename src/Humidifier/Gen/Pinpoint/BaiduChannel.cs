namespace Humidifier.Pinpoint
{
    using System.Collections.Generic;

    public class BaiduChannel : Humidifier.Base.BaseResource, IHaveEnabled, IHaveApplicationId, IHaveApiKey, IHaveSecretKey
    {
        public override string AWSTypeName { get => AWS.Pinpoint.BaiduChannel; }

        /// <summary>
        /// SecretKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-baiduchannel.html#cfn-pinpoint-baiduchannel-secretkey
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SecretKey { get; set; }

        /// <summary>
        /// ApiKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-baiduchannel.html#cfn-pinpoint-baiduchannel-apikey
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApiKey { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-baiduchannel.html#cfn-pinpoint-baiduchannel-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Enabled { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-baiduchannel.html#cfn-pinpoint-baiduchannel-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationId { get; set; }
    }
}