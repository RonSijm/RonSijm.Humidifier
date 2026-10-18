namespace Humidifier.RDS
{
    using global::System.Collections.Generic;

    public class DBClusterEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfExcludedMembers, IHaveDBClusterIdentifier, IHaveDBClusterEndpointIdentifier, IHaveStringListOfStaticMembers, IHaveCustomEndpointType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DBClusterEndpointArn =  "DBClusterEndpointArn" ;
            public static string Endpoint =  "Endpoint" ;
            public static string DBClusterEndpointResourceIdentifier =  "DBClusterEndpointResourceIdentifier" ;
            public static string EndpointType =  "EndpointType" ;
        }

        public override string AWSTypeName { get => AWS.RDS.DBClusterEndpoint; }
        /// <summary>
        /// ExcludedMembers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterendpoint.html#cfn-rds-dbclusterendpoint-excludedmembers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedMembers { get; set; }

        /// <summary>
        /// DBClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterendpoint.html#cfn-rds-dbclusterendpoint-dbclusteridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DBClusterIdentifier { get; set; }

        /// <summary>
        /// DBClusterEndpointIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterendpoint.html#cfn-rds-dbclusterendpoint-dbclusterendpointidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DBClusterEndpointIdentifier { get; set; }
        /// <summary>
        /// StaticMembers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterendpoint.html#cfn-rds-dbclusterendpoint-staticmembers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StaticMembers { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterendpoint.html#cfn-rds-dbclusterendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// CustomEndpointType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterendpoint.html#cfn-rds-dbclusterendpoint-customendpointtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CustomEndpointType { get; set; }
    }
}