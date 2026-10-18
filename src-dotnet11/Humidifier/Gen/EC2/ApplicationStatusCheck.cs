namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ApplicationStatusCheckTypes;

    public class ApplicationStatusCheck : Humidifier.Base.BaseResource, IHaveTags, IHavePath, IHaveListOfEC2ApplicationStatusCheckTypesHealthCheckPathHealthCheckPaths, IHaveIpVersion, IHaveDeviceIndex_Integer, IHaveTimeout_Integer, IHavePort_Integer, IHaveInitializationGracePeriodSeconds_Integer, IHaveIpScope, IHaveStatusCodeMatcher, IHaveSuccessThreshold_Integer, IHaveAggregation, IHaveFailureThreshold_Integer, IHaveProtocol, IHaveInterval_Integer
    {
        public class Attributes
        {
            public static string ApplicationStatusCheckId =  "ApplicationStatusCheckId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.ApplicationStatusCheck; }
        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-path
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Path { get; set; }
        /// <summary>
        /// HealthCheckPaths
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-healthcheckpaths
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HealthCheckPath
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath>, IReadOnlyList<Union<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath, BaseFunction>>, BaseFunction>? HealthCheckPaths { get; set; }
        /// <summary>
        /// IpVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-ipversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpVersion { get; set; }
        /// <summary>
        /// DeviceIndex
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-deviceindex
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DeviceIndex { get; set; }
        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-timeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Timeout { get; set; }

        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-port
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// InitializationGracePeriodSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-initializationgraceperiodseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? InitializationGracePeriodSeconds { get; set; }
        /// <summary>
        /// IpScope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-ipscope
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpScope { get; set; }
        /// <summary>
        /// StatusCodeMatcher
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-statuscodematcher
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StatusCodeMatcher { get; set; }
        /// <summary>
        /// SuccessThreshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-successthreshold
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SuccessThreshold { get; set; }
        /// <summary>
        /// Aggregation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-aggregation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Aggregation { get; set; }
        /// <summary>
        /// FailureThreshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-failurethreshold
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? FailureThreshold { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-protocol
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Protocol { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Interval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-applicationstatuscheck.html#cfn-ec2-applicationstatuscheck-interval
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Interval { get; set; }
    }

    namespace ApplicationStatusCheckTypes
    {
        public class HealthCheckPath : Humidifier.Base.BaseSubResource, IHaveListOfEC2ApplicationStatusCheckTypesHealthCheckPathDestinationDestinations, IHaveEC2ApplicationStatusCheckTypesHealthCheckPathSourceSource
        {
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-applicationstatuscheck-healthcheckpath.html#cfn-ec2-applicationstatuscheck-healthcheckpath-destinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HealthCheckPathDestination
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathDestination>, IReadOnlyList<Union<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathDestination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-applicationstatuscheck-healthcheckpath.html#cfn-ec2-applicationstatuscheck-healthcheckpath-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HealthCheckPathSource
            /// </summary>
            public Union<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource, BaseFunction>? Source { get; set; }
        }

        public class HealthCheckPathDestination : Humidifier.Base.BaseSubResource, IHaveSecurityGroupId, IHaveSubnetId
        {
            /// <summary>
            /// SecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-applicationstatuscheck-healthcheckpathdestination.html#cfn-ec2-applicationstatuscheck-healthcheckpathdestination-securitygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityGroupId { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-applicationstatuscheck-healthcheckpathdestination.html#cfn-ec2-applicationstatuscheck-healthcheckpathdestination-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
        }

        public class HealthCheckPathSource : Humidifier.Base.BaseSubResource, IHaveSecurityGroupId, IHaveSubnetId
        {
            /// <summary>
            /// SecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-applicationstatuscheck-healthcheckpathsource.html#cfn-ec2-applicationstatuscheck-healthcheckpathsource-securitygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityGroupId { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-applicationstatuscheck-healthcheckpathsource.html#cfn-ec2-applicationstatuscheck-healthcheckpathsource-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
        }
    }
}