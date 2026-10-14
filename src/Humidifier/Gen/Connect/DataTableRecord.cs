namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using DataTableRecordTypes;

    public class DataTableRecord : Humidifier.Base.BaseResource, IHaveInstanceArn
    {
        public class Attributes
        {
            public static string RecordId =  "RecordId" ;
        }

        public override string AWSTypeName { get => AWS.Connect.DataTableRecord; }

        /// <summary>
        /// DataTableRecord_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatablerecord.html#cfn-connect-datatablerecord-datatablerecord
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataTableRecord
        /// </summary>
        [Required]
        public Humidifier.Connect.DataTableRecordTypes.DataTableRecord DataTableRecord_ { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatablerecord.html#cfn-connect-datatablerecord-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }

        /// <summary>
        /// DataTableArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatablerecord.html#cfn-connect-datatablerecord-datatablearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DataTableArn { get; set; }
    }

    namespace DataTableRecordTypes
    {
        public class DataTableRecord : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrimaryValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatablerecord-datatablerecord.html#cfn-connect-datatablerecord-datatablerecord-primaryvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Value
            /// </summary>
            public List<Humidifier.Connect.DataTableRecordTypes.Value> PrimaryValues { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatablerecord-datatablerecord.html#cfn-connect-datatablerecord-datatablerecord-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Value
            /// </summary>
            public List<Humidifier.Connect.DataTableRecordTypes.Value> Values { get; set; }
        }

        public class Value : Humidifier.Base.BaseSubResource, IHaveAttributeValue
        {
            /// <summary>
            /// AttributeValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatablerecord-value.html#cfn-connect-datatablerecord-value-attributevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeValue { get; set; }
            /// <summary>
            /// AttributeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatablerecord-value.html#cfn-connect-datatablerecord-value-attributeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeId { get; set; }
        }
    }
}