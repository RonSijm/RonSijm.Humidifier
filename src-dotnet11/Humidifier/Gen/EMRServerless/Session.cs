namespace Humidifier.EMRServerless
{
    using global::System.Collections.Generic;
    using SessionTypes;

    public class Session : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveExecutionRoleArn, IHaveEMRServerlessSessionTypesConfigurationOverridesConfigurationOverrides, IHaveIdleTimeoutMinutes_Double, IHaveApplicationId, IHaveName
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string StateDetails =  "StateDetails" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string IdleSince =  "IdleSince" ;
            public static string State =  "State" ;
            public static string NetworkConfiguration =  "NetworkConfiguration" ;
            public static string StartedAt =  "StartedAt" ;
            public static string Arn =  "Arn" ;
            public static string ReleaseLabel =  "ReleaseLabel" ;
            public static string SessionId =  "SessionId" ;
        }

        public override string AWSTypeName { get => AWS.EMRServerless.Session; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-session.html#cfn-emrserverless-session-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// ConfigurationOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-session.html#cfn-emrserverless-session-configurationoverrides
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConfigurationOverrides
        /// </summary>
        public Union<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides, BaseFunction>? ConfigurationOverrides { get; set; }
        /// <summary>
        /// IdleTimeoutMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-session.html#cfn-emrserverless-session-idletimeoutminutes
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? IdleTimeoutMinutes { get; set; }
        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-session.html#cfn-emrserverless-session-applicationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-session.html#cfn-emrserverless-session-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SessionTypes
    {
        public class Configuration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfProperties, IHaveListOfEMRServerlessSessionTypesConfigurationConfigurations, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-session-configuration.html#cfn-emrserverless-session-configuration-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-session-configuration.html#cfn-emrserverless-session-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRServerless.SessionTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMRServerless.SessionTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-session-configuration.html#cfn-emrserverless-session-configuration-classification
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
        }

        public class ConfigurationOverrides : Humidifier.Base.BaseSubResource, IHaveListOfEMRServerlessSessionTypesConfigurationRuntimeConfiguration
        {
            /// <summary>
            /// RuntimeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-session-configurationoverrides.html#cfn-emrserverless-session-configurationoverrides-runtimeconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRServerless.SessionTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMRServerless.SessionTypes.Configuration, BaseFunction>>, BaseFunction>? RuntimeConfiguration { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-session-networkconfiguration.html#cfn-emrserverless-session-networkconfiguration-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-session-networkconfiguration.html#cfn-emrserverless-session-networkconfiguration-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}