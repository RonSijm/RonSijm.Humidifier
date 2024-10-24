namespace Humidifier.Pinpoint
{
    using System.Collections.Generic;

    public class APNSVoipSandboxChannel : Humidifier.Base.BaseResource, IHaveEnabled, IHaveApplicationId, IHavePrivateKey, IHaveBundleId, IHaveCertificate, IHaveTeamId, IHaveDefaultAuthenticationMethod, IHaveTokenKey, IHaveTokenKeyId
    {
        public override string AWSTypeName { get => AWS.Pinpoint.APNSVoipSandboxChannel; }
        /// <summary>
        /// BundleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html#cfn-pinpoint-apnsvoipsandboxchannel-bundleid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BundleId { get; set; }
        /// <summary>
        /// PrivateKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html#cfn-pinpoint-apnsvoipsandboxchannel-privatekey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PrivateKey { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html#cfn-pinpoint-apnsvoipsandboxchannel-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Enabled { get; set; }
        /// <summary>
        /// DefaultAuthenticationMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html#cfn-pinpoint-apnsvoipsandboxchannel-defaultauthenticationmethod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultAuthenticationMethod { get; set; }
        /// <summary>
        /// TokenKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html#cfn-pinpoint-apnsvoipsandboxchannel-tokenkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TokenKey { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html#cfn-pinpoint-apnsvoipsandboxchannel-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationId { get; set; }
        /// <summary>
        /// TeamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html#cfn-pinpoint-apnsvoipsandboxchannel-teamid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TeamId { get; set; }
        /// <summary>
        /// Certificate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html#cfn-pinpoint-apnsvoipsandboxchannel-certificate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Certificate { get; set; }
        /// <summary>
        /// TokenKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipsandboxchannel.html#cfn-pinpoint-apnsvoipsandboxchannel-tokenkeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TokenKeyId { get; set; }
    }
}