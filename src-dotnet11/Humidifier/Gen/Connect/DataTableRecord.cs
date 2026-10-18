namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using DataTableRecordTypes;

    public class DataTableRecord : Humidifier.Base.BaseResource, IHaveConnectDataTableRecordTypesDataTableRecordDataTableRecord_, IHaveInstanceArn, IHaveDataTableArn
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
        public Union<Humidifier.Connect.DataTableRecordTypes.DataTableRecord, BaseFunction>? DataTableRecord_ { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatablerecord.html#cfn-connect-datatablerecord-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }

        /// <summary>
        /// DataTableArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatablerecord.html#cfn-connect-datatablerecord-datatablearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataTableArn { get; set; }
    }

    namespace DataTableRecordTypes
    {
        public class DataTableRecord : Humidifier.Base.BaseSubResource, IHaveListOfConnectDataTableRecordTypesValuePrimaryValues, IHaveListOfConnectDataTableRecordTypesValueValues
        {
            /// <summary>
            /// PrimaryValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatablerecord-datatablerecord.html#cfn-connect-datatablerecord-datatablerecord-primaryvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Value
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.DataTableRecordTypes.Value>, IReadOnlyList<Union<Humidifier.Connect.DataTableRecordTypes.Value, BaseFunction>>, BaseFunction>? PrimaryValues { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatablerecord-datatablerecord.html#cfn-connect-datatablerecord-datatablerecord-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Value
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.DataTableRecordTypes.Value>, IReadOnlyList<Union<Humidifier.Connect.DataTableRecordTypes.Value, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class Value : Humidifier.Base.BaseSubResource, IHaveAttributeValue, IHaveAttributeId
        {
            /// <summary>
            /// AttributeValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatablerecord-value.html#cfn-connect-datatablerecord-value-attributevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeValue { get; set; }
            /// <summary>
            /// AttributeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatablerecord-value.html#cfn-connect-datatablerecord-value-attributeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeId { get; set; }
        }
    }
}