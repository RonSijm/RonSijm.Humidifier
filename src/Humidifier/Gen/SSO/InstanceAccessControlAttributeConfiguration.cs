namespace Humidifier.SSO
{
    using System.Collections.Generic;
    using InstanceAccessControlAttributeConfigurationTypes;

    public class InstanceAccessControlAttributeConfiguration : Humidifier.Base.BaseResource, IHaveInstanceArn
    {
        public override string AWSTypeName { get => AWS.SSO.InstanceAccessControlAttributeConfiguration; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-instanceaccesscontrolattributeconfiguration.html#cfn-sso-instanceaccesscontrolattributeconfiguration-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// AccessControlAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-instanceaccesscontrolattributeconfiguration.html#cfn-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessControlAttribute
        /// </summary>
        public List<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute> AccessControlAttributes { get; set; }
    }

    namespace InstanceAccessControlAttributeConfigurationTypes
    {
        public class AccessControlAttribute : Humidifier.Base.BaseSubResource, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattribute.html#cfn-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattribute-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccessControlAttributeValue
            /// </summary>
            public Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattribute.html#cfn-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattribute-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class AccessControlAttributeValue : Humidifier.Base.BaseSubResource, IHaveSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattributevalue.html#cfn-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattributevalue-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Source { get; set; }
        }
    }
}