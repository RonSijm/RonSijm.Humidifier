namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using SessionTypes;

    public class Session : Humidifier.Base.BaseResource, IHaveTags, IHaveGlueSessionTypesConnectionsListConnections, IHaveDescription, IHaveTimeout_Integer, IHaveRequestOrigin, IHaveIdleTimeout_Integer, IHaveRole, IHaveStringDictionaryOfDefaultArguments, IHaveWorkerType, IHaveGlueSessionTypesSessionCommandCommand, IHaveGlueVersion, IHaveId, IHaveSecurityConfiguration, IHaveNumberOfWorkers_Integer, IHaveMaxCapacity_Double
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Progress =  "Progress" ;
            public static string CreatedOn =  "CreatedOn" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Glue.Session; }
        /// <summary>
        /// Connections
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-connections
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectionsList
        /// </summary>
        public Union<Humidifier.Glue.SessionTypes.ConnectionsList, BaseFunction>? Connections { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-timeout
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Timeout { get; set; }
        /// <summary>
        /// RequestOrigin
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-requestorigin
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RequestOrigin { get; set; }
        /// <summary>
        /// IdleTimeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-idletimeout
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? IdleTimeout { get; set; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-role
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Role { get; set; }
        /// <summary>
        /// DefaultArguments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-defaultarguments
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DefaultArguments { get; set; }
        /// <summary>
        /// WorkerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-workertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkerType { get; set; }

        /// <summary>
        /// Command
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-command
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SessionCommand
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.SessionTypes.SessionCommand, BaseFunction>? Command { get; set; }
        /// <summary>
        /// GlueVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-glueversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GlueVersion { get; set; }

        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-id
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Id { get; set; }
        /// <summary>
        /// SecurityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-securityconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityConfiguration { get; set; }
        /// <summary>
        /// NumberOfWorkers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-numberofworkers
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? NumberOfWorkers { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MaxCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-session.html#cfn-glue-session-maxcapacity
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? MaxCapacity { get; set; }
    }

    namespace SessionTypes
    {
        public class ConnectionsList : Humidifier.Base.BaseSubResource, IHaveStringListOfConnections
        {
            /// <summary>
            /// Connections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-session-connectionslist.html#cfn-glue-session-connectionslist-connections
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Connections { get; set; }
        }

        public class SessionCommand : Humidifier.Base.BaseSubResource, IHavePythonVersion, IHaveName
        {
            /// <summary>
            /// PythonVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-session-sessioncommand.html#cfn-glue-session-sessioncommand-pythonversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PythonVersion { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-session-sessioncommand.html#cfn-glue-session-sessioncommand-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}