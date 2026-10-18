namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using LoggerDefinitionTypes;

    public class LoggerDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGreengrassLoggerDefinitionTypesLoggerDefinitionVersionInitialVersion, IHaveTags_Json, IHaveName
    {
        public class Attributes
        {
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Greengrass.LoggerDefinition; }
        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-loggerdefinition.html#cfn-greengrass-loggerdefinition-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LoggerDefinitionVersion
        /// </summary>
        public Union<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion, BaseFunction>? InitialVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-loggerdefinition.html#cfn-greengrass-loggerdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace LoggerDefinitionTypes
    {
        public class Logger : Humidifier.Base.BaseSubResource, IHaveSpace_Integer, IHaveType, IHaveLevel, IHaveId, IHaveComponent
        {
            /// <summary>
            /// Space
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-loggerdefinition-logger.html#cfn-greengrass-loggerdefinition-logger-space
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Space { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-loggerdefinition-logger.html#cfn-greengrass-loggerdefinition-logger-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-loggerdefinition-logger.html#cfn-greengrass-loggerdefinition-logger-level
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-loggerdefinition-logger.html#cfn-greengrass-loggerdefinition-logger-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Component
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-loggerdefinition-logger.html#cfn-greengrass-loggerdefinition-logger-component
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Component { get; set; }
        }

        public class LoggerDefinitionVersion : Humidifier.Base.BaseSubResource, IHaveListOfGreengrassLoggerDefinitionTypesLoggerLoggers
        {
            /// <summary>
            /// Loggers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-loggerdefinition-loggerdefinitionversion.html#cfn-greengrass-loggerdefinition-loggerdefinitionversion-loggers
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Logger
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Greengrass.LoggerDefinitionTypes.Logger>, IReadOnlyList<Union<Humidifier.Greengrass.LoggerDefinitionTypes.Logger, BaseFunction>>, BaseFunction>? Loggers { get; set; }
        }
    }
}