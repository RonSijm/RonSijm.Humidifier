namespace Humidifier.RDS
{
    using global::System.Collections.Generic;
    using DBProxyTargetGroupTypes;

    public class DBProxyTargetGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveDBProxyName, IHaveStringListOfDBInstanceIdentifiers, IHaveTargetGroupName, IHaveRDSDBProxyTargetGroupTypesConnectionPoolConfigurationInfoFormatConnectionPoolConfigurationInfo, IHaveStringListOfDBClusterIdentifiers
    {
        public class Attributes
        {
            public static string TargetGroupArn =  "TargetGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.RDS.DBProxyTargetGroup; }

        /// <summary>
        /// DBProxyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxytargetgroup.html#cfn-rds-dbproxytargetgroup-dbproxyname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DBProxyName { get; set; }
        /// <summary>
        /// DBInstanceIdentifiers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxytargetgroup.html#cfn-rds-dbproxytargetgroup-dbinstanceidentifiers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DBInstanceIdentifiers { get; set; }

        /// <summary>
        /// TargetGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxytargetgroup.html#cfn-rds-dbproxytargetgroup-targetgroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetGroupName { get; set; }
        /// <summary>
        /// ConnectionPoolConfigurationInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxytargetgroup.html#cfn-rds-dbproxytargetgroup-connectionpoolconfigurationinfo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectionPoolConfigurationInfoFormat
        /// </summary>
        public Union<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat, BaseFunction>? ConnectionPoolConfigurationInfo { get; set; }
        /// <summary>
        /// DBClusterIdentifiers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxytargetgroup.html#cfn-rds-dbproxytargetgroup-dbclusteridentifiers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DBClusterIdentifiers { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxytargetgroup.html#cfn-rds-dbproxytargetgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DBProxyTargetGroupTypes
    {
        public class ConnectionPoolConfigurationInfoFormat : Humidifier.Base.BaseSubResource, IHaveMaxIdleConnectionsPercent_Integer, IHaveMaxConnectionsPercent_Integer, IHaveInitQuery, IHaveConnectionBorrowTimeout_Integer, IHaveStringListOfSessionPinningFilters
        {
            /// <summary>
            /// MaxIdleConnectionsPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat.html#cfn-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat-maxidleconnectionspercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxIdleConnectionsPercent { get; set; }
            /// <summary>
            /// MaxConnectionsPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat.html#cfn-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat-maxconnectionspercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConnectionsPercent { get; set; }
            /// <summary>
            /// InitQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat.html#cfn-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat-initquery
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InitQuery { get; set; }
            /// <summary>
            /// ConnectionBorrowTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat.html#cfn-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat-connectionborrowtimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConnectionBorrowTimeout { get; set; }
            /// <summary>
            /// SessionPinningFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat.html#cfn-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat-sessionpinningfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SessionPinningFilters { get; set; }
        }
    }
}