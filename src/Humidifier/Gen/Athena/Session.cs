namespace Humidifier.Athena
{
    using global::System.Collections.Generic;
    using SessionTypes;

    public class Session : Humidifier.Base.BaseResource, IHaveExecutionRole, IHaveWorkGroup
    {
        public class Attributes
        {
            public static string EngineVersion =  "EngineVersion" ;
            public static string Arn =  "Arn" ;
            public static string SessionId =  "SessionId" ;
        }

        public override string AWSTypeName { get => AWS.Athena.Session; }

        /// <summary>
        /// WorkGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-session.html#cfn-athena-session-workgroup
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic WorkGroup { get; set; }

        /// <summary>
        /// EngineConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-session.html#cfn-athena-session-engineconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: EngineConfiguration
        /// </summary>
        [Required]
        public Humidifier.Athena.SessionTypes.EngineConfiguration EngineConfiguration { get; set; }
        /// <summary>
        /// ExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-session.html#cfn-athena-session-executionrole
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionRole { get; set; }
    }

    namespace SessionTypes
    {
        public class EngineConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SparkProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-session-engineconfiguration.html#cfn-athena-session-engineconfiguration-sparkproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> SparkProperties { get; set; }
            /// <summary>
            /// MaxConcurrentDpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-session-engineconfiguration.html#cfn-athena-session-engineconfiguration-maxconcurrentdpus
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConcurrentDpus { get; set; }
            /// <summary>
            /// CoordinatorDpuSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-session-engineconfiguration.html#cfn-athena-session-engineconfiguration-coordinatordpusize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CoordinatorDpuSize { get; set; }
            /// <summary>
            /// DefaultExecutorDpuSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-session-engineconfiguration.html#cfn-athena-session-engineconfiguration-defaultexecutordpusize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DefaultExecutorDpuSize { get; set; }
            /// <summary>
            /// AdditionalConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-session-engineconfiguration.html#cfn-athena-session-engineconfiguration-additionalconfigs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> AdditionalConfigs { get; set; }
        }
    }
}