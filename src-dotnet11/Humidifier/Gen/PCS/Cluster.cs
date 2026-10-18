namespace Humidifier.PCS
{
    using global::System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHavePCSClusterTypesNetworkingNetworking, IHavePCSClusterTypesSchedulerScheduler, IHaveSize, IHavePCSClusterTypesSlurmConfigurationSlurmConfiguration, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Endpoints =  "Endpoints" ;
            public static string Status =  "Status" ;
            public static string ErrorInfo =  "ErrorInfo" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.PCS.Cluster; }

        /// <summary>
        /// Networking
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-cluster.html#cfn-pcs-cluster-networking
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Networking
        /// </summary>
        [Required]
        public Union<Humidifier.PCS.ClusterTypes.Networking, BaseFunction>? Networking { get; set; }

        /// <summary>
        /// Scheduler
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-cluster.html#cfn-pcs-cluster-scheduler
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Scheduler
        /// </summary>
        [Required]
        public Union<Humidifier.PCS.ClusterTypes.Scheduler, BaseFunction>? Scheduler { get; set; }

        /// <summary>
        /// Size
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-cluster.html#cfn-pcs-cluster-size
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Size { get; set; }
        /// <summary>
        /// SlurmConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-cluster.html#cfn-pcs-cluster-slurmconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SlurmConfiguration
        /// </summary>
        public Union<Humidifier.PCS.ClusterTypes.SlurmConfiguration, BaseFunction>? SlurmConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-cluster.html#cfn-pcs-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ClusterTypes
    {
        public class Accounting : Humidifier.Base.BaseSubResource, IHaveDefaultPurgeTimeInDays_Integer, IHaveMode
        {
            /// <summary>
            /// DefaultPurgeTimeInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-accounting.html#cfn-pcs-cluster-accounting-defaultpurgetimeindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DefaultPurgeTimeInDays { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-accounting.html#cfn-pcs-cluster-accounting-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class AuthKey : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveSecretVersion
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-authkey.html#cfn-pcs-cluster-authkey-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// SecretVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-authkey.html#cfn-pcs-cluster-authkey-secretversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretVersion { get; set; }
        }

        public class CgroupCustomSetting : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterName
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-cgroupcustomsetting.html#cfn-pcs-cluster-cgroupcustomsetting-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-cgroupcustomsetting.html#cfn-pcs-cluster-cgroupcustomsetting-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
        }

        public class Endpoint : Humidifier.Base.BaseSubResource, IHavePublicIpAddress, IHaveType, IHavePrivateIpAddress, IHavePort, IHaveIpv6Address
        {
            /// <summary>
            /// PublicIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-endpoint.html#cfn-pcs-cluster-endpoint-publicipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PublicIpAddress { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-endpoint.html#cfn-pcs-cluster-endpoint-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-endpoint.html#cfn-pcs-cluster-endpoint-privateipaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-endpoint.html#cfn-pcs-cluster-endpoint-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-endpoint.html#cfn-pcs-cluster-endpoint-ipv6address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Address { get; set; }
        }

        public class ErrorInfo : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-errorinfo.html#cfn-pcs-cluster-errorinfo-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-errorinfo.html#cfn-pcs-cluster-errorinfo-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class JwtAuth : Humidifier.Base.BaseSubResource, IHavePCSClusterTypesJwtKeyJwtKey
        {
            /// <summary>
            /// JwtKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-jwtauth.html#cfn-pcs-cluster-jwtauth-jwtkey
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JwtKey
            /// </summary>
            public Union<Humidifier.PCS.ClusterTypes.JwtKey, BaseFunction>? JwtKey { get; set; }
        }

        public class JwtKey : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveSecretVersion
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-jwtkey.html#cfn-pcs-cluster-jwtkey-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// SecretVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-jwtkey.html#cfn-pcs-cluster-jwtkey-secretversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretVersion { get; set; }
        }

        public class Networking : Humidifier.Base.BaseSubResource, IHaveNetworkType, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// NetworkType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-networking.html#cfn-pcs-cluster-networking-networktype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-networking.html#cfn-pcs-cluster-networking-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-networking.html#cfn-pcs-cluster-networking-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class Scheduler : Humidifier.Base.BaseSubResource, IHaveType, IHaveVersion
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-scheduler.html#cfn-pcs-cluster-scheduler-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-scheduler.html#cfn-pcs-cluster-scheduler-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
        }

        public class SlurmConfiguration : Humidifier.Base.BaseSubResource, IHavePCSClusterTypesJwtAuthJwtAuth, IHaveListOfPCSClusterTypesSlurmdbdCustomSettingSlurmdbdCustomSettings, IHaveListOfPCSClusterTypesCgroupCustomSettingCgroupCustomSettings, IHavePCSClusterTypesAccountingAccounting, IHavePCSClusterTypesAuthKeyAuthKey, IHaveScaleDownIdleTimeInSeconds_Integer, IHaveListOfPCSClusterTypesSlurmCustomSettingSlurmCustomSettings, IHavePCSClusterTypesSlurmRestSlurmRest
        {
            /// <summary>
            /// JwtAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmconfiguration.html#cfn-pcs-cluster-slurmconfiguration-jwtauth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JwtAuth
            /// </summary>
            public Union<Humidifier.PCS.ClusterTypes.JwtAuth, BaseFunction>? JwtAuth { get; set; }
            /// <summary>
            /// SlurmdbdCustomSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmconfiguration.html#cfn-pcs-cluster-slurmconfiguration-slurmdbdcustomsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlurmdbdCustomSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.PCS.ClusterTypes.SlurmdbdCustomSetting>, IReadOnlyList<Union<Humidifier.PCS.ClusterTypes.SlurmdbdCustomSetting, BaseFunction>>, BaseFunction>? SlurmdbdCustomSettings { get; set; }
            /// <summary>
            /// CgroupCustomSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmconfiguration.html#cfn-pcs-cluster-slurmconfiguration-cgroupcustomsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CgroupCustomSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.PCS.ClusterTypes.CgroupCustomSetting>, IReadOnlyList<Union<Humidifier.PCS.ClusterTypes.CgroupCustomSetting, BaseFunction>>, BaseFunction>? CgroupCustomSettings { get; set; }
            /// <summary>
            /// Accounting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmconfiguration.html#cfn-pcs-cluster-slurmconfiguration-accounting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Accounting
            /// </summary>
            public Union<Humidifier.PCS.ClusterTypes.Accounting, BaseFunction>? Accounting { get; set; }
            /// <summary>
            /// AuthKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmconfiguration.html#cfn-pcs-cluster-slurmconfiguration-authkey
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthKey
            /// </summary>
            public Union<Humidifier.PCS.ClusterTypes.AuthKey, BaseFunction>? AuthKey { get; set; }
            /// <summary>
            /// ScaleDownIdleTimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmconfiguration.html#cfn-pcs-cluster-slurmconfiguration-scaledownidletimeinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleDownIdleTimeInSeconds { get; set; }
            /// <summary>
            /// SlurmCustomSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmconfiguration.html#cfn-pcs-cluster-slurmconfiguration-slurmcustomsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlurmCustomSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.PCS.ClusterTypes.SlurmCustomSetting>, IReadOnlyList<Union<Humidifier.PCS.ClusterTypes.SlurmCustomSetting, BaseFunction>>, BaseFunction>? SlurmCustomSettings { get; set; }
            /// <summary>
            /// SlurmRest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmconfiguration.html#cfn-pcs-cluster-slurmconfiguration-slurmrest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlurmRest
            /// </summary>
            public Union<Humidifier.PCS.ClusterTypes.SlurmRest, BaseFunction>? SlurmRest { get; set; }
        }

        public class SlurmCustomSetting : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterName
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmcustomsetting.html#cfn-pcs-cluster-slurmcustomsetting-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmcustomsetting.html#cfn-pcs-cluster-slurmcustomsetting-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
        }

        public class SlurmRest : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmrest.html#cfn-pcs-cluster-slurmrest-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class SlurmdbdCustomSetting : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterName
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmdbdcustomsetting.html#cfn-pcs-cluster-slurmdbdcustomsetting-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-cluster-slurmdbdcustomsetting.html#cfn-pcs-cluster-slurmdbdcustomsetting-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
        }
    }
}