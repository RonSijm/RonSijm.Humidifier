namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using OriginAccessControlTypes;

    public class OriginAccessControl : Humidifier.Base.BaseResource, IHaveCloudFrontOriginAccessControlTypesOriginAccessControlConfigOriginAccessControlConfig
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.OriginAccessControl; }

        /// <summary>
        /// OriginAccessControlConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-originaccesscontrol.html#cfn-cloudfront-originaccesscontrol-originaccesscontrolconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: OriginAccessControlConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig, BaseFunction>? OriginAccessControlConfig { get; set; }
    }

    namespace OriginAccessControlTypes
    {
        public class OriginAccessControlConfig : Humidifier.Base.BaseSubResource, IHaveSigningBehavior, IHaveDescription, IHaveOriginAccessControlOriginType, IHaveSigningProtocol, IHaveName
        {
            /// <summary>
            /// SigningBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originaccesscontrol-originaccesscontrolconfig.html#cfn-cloudfront-originaccesscontrol-originaccesscontrolconfig-signingbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SigningBehavior { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originaccesscontrol-originaccesscontrolconfig.html#cfn-cloudfront-originaccesscontrol-originaccesscontrolconfig-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// OriginAccessControlOriginType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originaccesscontrol-originaccesscontrolconfig.html#cfn-cloudfront-originaccesscontrol-originaccesscontrolconfig-originaccesscontrolorigintype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OriginAccessControlOriginType { get; set; }
            /// <summary>
            /// SigningProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originaccesscontrol-originaccesscontrolconfig.html#cfn-cloudfront-originaccesscontrol-originaccesscontrolconfig-signingprotocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SigningProtocol { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originaccesscontrol-originaccesscontrolconfig.html#cfn-cloudfront-originaccesscontrol-originaccesscontrolconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}