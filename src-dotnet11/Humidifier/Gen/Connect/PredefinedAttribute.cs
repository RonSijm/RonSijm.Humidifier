namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using PredefinedAttributeTypes;

    public class PredefinedAttribute : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveConnectPredefinedAttributeTypesAttributeConfigurationAttributeConfiguration, IHaveInstanceArn, IHaveConnectPredefinedAttributeTypesValuesValues, IHaveStringListOfPurposes, IHaveName
    {
        public class Attributes
        {
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string LastModifiedRegion =  "LastModifiedRegion" ;
        }

        public override string AWSTypeName { get => AWS.Connect.PredefinedAttribute; }
        /// <summary>
        /// AttributeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-predefinedattribute.html#cfn-connect-predefinedattribute-attributeconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AttributeConfiguration
        /// </summary>
        public Union<Humidifier.Connect.PredefinedAttributeTypes.AttributeConfiguration, BaseFunction>? AttributeConfiguration { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-predefinedattribute.html#cfn-connect-predefinedattribute-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// Values
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-predefinedattribute.html#cfn-connect-predefinedattribute-values
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Values
        /// </summary>
        public Union<Humidifier.Connect.PredefinedAttributeTypes.Values, BaseFunction>? Values { get; set; }
        /// <summary>
        /// Purposes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-predefinedattribute.html#cfn-connect-predefinedattribute-purposes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Purposes { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PredefinedAttributeTypes
    {
        public class AttributeConfiguration : Humidifier.Base.BaseSubResource, IHaveEnableValueValidationOnAssociation_Boolean, IHaveIsReadOnly_Boolean
        {
            /// <summary>
            /// EnableValueValidationOnAssociation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-predefinedattribute-attributeconfiguration.html#cfn-connect-predefinedattribute-attributeconfiguration-enablevaluevalidationonassociation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableValueValidationOnAssociation { get; set; }
            /// <summary>
            /// IsReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-predefinedattribute-attributeconfiguration.html#cfn-connect-predefinedattribute-attributeconfiguration-isreadonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsReadOnly { get; set; }
        }

        public class Values : Humidifier.Base.BaseSubResource, IHaveStringListOfStringList
        {
            /// <summary>
            /// StringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-predefinedattribute-values.html#cfn-connect-predefinedattribute-values-stringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StringList { get; set; }
        }
    }
}