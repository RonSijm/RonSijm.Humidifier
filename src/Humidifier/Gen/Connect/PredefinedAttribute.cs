namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using PredefinedAttributeTypes;

    public class PredefinedAttribute : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveInstanceArn
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
        public Humidifier.Connect.PredefinedAttributeTypes.AttributeConfiguration AttributeConfiguration { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-predefinedattribute.html#cfn-connect-predefinedattribute-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// Values
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-predefinedattribute.html#cfn-connect-predefinedattribute-values
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Values
        /// </summary>
        public Humidifier.Connect.PredefinedAttributeTypes.Values Values { get; set; }
        /// <summary>
        /// Purposes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-predefinedattribute.html#cfn-connect-predefinedattribute-purposes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Purposes { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace PredefinedAttributeTypes
    {
        public class AttributeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnableValueValidationOnAssociation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-predefinedattribute-attributeconfiguration.html#cfn-connect-predefinedattribute-attributeconfiguration-enablevaluevalidationonassociation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableValueValidationOnAssociation { get; set; }
            /// <summary>
            /// IsReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-predefinedattribute-attributeconfiguration.html#cfn-connect-predefinedattribute-attributeconfiguration-isreadonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsReadOnly { get; set; }
        }

        public class Values : Humidifier.Base.BaseSubResource, IHaveStringList
        {
            /// <summary>
            /// StringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-predefinedattribute-values.html#cfn-connect-predefinedattribute-values-stringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StringList { get; set; }
        }
    }
}