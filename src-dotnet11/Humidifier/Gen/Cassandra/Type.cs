namespace Humidifier.Cassandra
{
    using global::System.Collections.Generic;
    using TypeTypes;

    public class Type : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTypeName, IHaveListOfCassandraTypeTypesFieldFields, IHaveKeyspaceName
    {
        public class Attributes
        {
            public static string DirectParentTypes =  "DirectParentTypes" ;
            public static string DirectReferringTables =  "DirectReferringTables" ;
            public static string MaxNestingDepth =  "MaxNestingDepth" ;
            public static string LastModifiedTimestamp =  "LastModifiedTimestamp" ;
            public static string KeyspaceArn =  "KeyspaceArn" ;
        }

        public override string AWSTypeName { get => AWS.Cassandra.Type; }
        public Union<string, BaseFunction>? TypeName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Fields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-type.html#cfn-cassandra-type-fields
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Field
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Cassandra.TypeTypes.Field>, IReadOnlyList<Union<Humidifier.Cassandra.TypeTypes.Field, BaseFunction>>, BaseFunction>? Fields { get; set; }

        /// <summary>
        /// KeyspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-type.html#cfn-cassandra-type-keyspacename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KeyspaceName { get; set; }
    }

    namespace TypeTypes
    {
        public class Field : Humidifier.Base.BaseSubResource, IHaveFieldName, IHaveFieldType
        {
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-type-field.html#cfn-cassandra-type-field-fieldname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
            /// <summary>
            /// FieldType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-type-field.html#cfn-cassandra-type-field-fieldtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldType { get; set; }
        }
    }
}