namespace Humidifier.SSO
{
    using global::System.Collections.Generic;
    using InstanceAccessControlAttributeConfigurationTypes;

    public class InstanceAccessControlAttributeConfiguration : Humidifier.Base.BaseResource, IHaveInstanceArn, IHaveListOfSSOInstanceAccessControlAttributeConfigurationTypesAccessControlAttributeAccessControlAttributes
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
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// AccessControlAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-instanceaccesscontrolattributeconfiguration.html#cfn-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessControlAttribute
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute>, IReadOnlyList<Union<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttribute, BaseFunction>>, BaseFunction>? AccessControlAttributes { get; set; }
    }

    namespace InstanceAccessControlAttributeConfigurationTypes
    {
        public class AccessControlAttribute : Humidifier.Base.BaseSubResource, IHaveSSOInstanceAccessControlAttributeConfigurationTypesAccessControlAttributeValueValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattribute.html#cfn-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattribute-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccessControlAttributeValue
            /// </summary>
            public Union<Humidifier.SSO.InstanceAccessControlAttributeConfigurationTypes.AccessControlAttributeValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattribute.html#cfn-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattribute-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class AccessControlAttributeValue : Humidifier.Base.BaseSubResource, IHaveStringListOfSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattributevalue.html#cfn-sso-instanceaccesscontrolattributeconfiguration-accesscontrolattributevalue-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Source { get; set; }
        }
    }
}