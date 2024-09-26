namespace Humidifier.Connect
{
    using System.Collections.Generic;
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
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Values
        /// </summary>
        [Required]
        public Humidifier.Connect.PredefinedAttributeTypes.Values Values { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace PredefinedAttributeTypes
    {
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