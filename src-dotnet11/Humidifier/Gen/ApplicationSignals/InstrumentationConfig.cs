namespace Humidifier.ApplicationSignals
{
    using global::System.Collections.Generic;
    using InstrumentationConfigTypes;

    public class InstrumentationConfig : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveSignalType, IHaveAttributeFilters_Json, IHaveInstrumentationType, IHaveApplicationSignalsInstrumentationConfigTypesCaptureConfigurationCaptureConfiguration, IHaveService, IHaveEnvironment, IHaveExpiresAt, IHaveApplicationSignalsInstrumentationConfigTypesLocationLocation
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string LocationHash =  "LocationHash" ;
        }

        public override string AWSTypeName { get => AWS.ApplicationSignals.InstrumentationConfig; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// SignalType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-signaltype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SignalType { get; set; }
        /// <summary>
        /// AttributeFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-attributefilters
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? AttributeFilters { get; set; }

        /// <summary>
        /// InstrumentationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-instrumentationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstrumentationType { get; set; }

        /// <summary>
        /// CaptureConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-captureconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CaptureConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration, BaseFunction>? CaptureConfiguration { get; set; }

        /// <summary>
        /// Service
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-service
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Service { get; set; }

        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-environment
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Environment { get; set; }
        /// <summary>
        /// ExpiresAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-expiresat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpiresAt { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-location
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Location
        /// </summary>
        [Required]
        public Union<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location, BaseFunction>? Location { get; set; }
    }

    namespace InstrumentationConfigTypes
    {
        public class CaptureConfiguration : Humidifier.Base.BaseSubResource, IHaveApplicationSignalsInstrumentationConfigTypesCodeCaptureConfigurationCodeCapture
        {
            /// <summary>
            /// CodeCapture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-captureconfiguration.html#cfn-applicationsignals-instrumentationconfig-captureconfiguration-codecapture
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CodeCaptureConfiguration
            /// </summary>
            public Union<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration, BaseFunction>? CodeCapture { get; set; }
        }

        public class CaptureLimitsConfig : Humidifier.Base.BaseSubResource, IHaveMaxStringLength_Integer, IHaveMaxCollectionDepth_Integer, IHaveMaxCollectionWidth_Integer, IHaveMaxObjectDepth_Integer, IHaveMaxHits_Integer, IHaveMaxStackFrames_Integer, IHaveMaxStackTraceSize_Integer, IHaveMaxFieldsPerObject_Integer
        {
            /// <summary>
            /// MaxStringLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxstringlength
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxStringLength { get; set; }
            /// <summary>
            /// MaxCollectionDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxcollectiondepth
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCollectionDepth { get; set; }
            /// <summary>
            /// MaxCollectionWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxcollectionwidth
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCollectionWidth { get; set; }
            /// <summary>
            /// MaxObjectDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxobjectdepth
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxObjectDepth { get; set; }
            /// <summary>
            /// MaxHits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxhits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxHits { get; set; }
            /// <summary>
            /// MaxStackFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxstackframes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxStackFrames { get; set; }
            /// <summary>
            /// MaxStackTraceSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxstacktracesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxStackTraceSize { get; set; }
            /// <summary>
            /// MaxFieldsPerObject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxfieldsperobject
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFieldsPerObject { get; set; }
        }

        public class CodeCaptureConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfCaptureLocals, IHaveCaptureReturn_Boolean, IHaveApplicationSignalsInstrumentationConfigTypesCaptureLimitsConfigCaptureLimits, IHaveStringListOfCaptureArguments, IHaveCaptureStackTrace_Boolean
        {
            /// <summary>
            /// CaptureLocals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturelocals
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CaptureLocals { get; set; }
            /// <summary>
            /// CaptureReturn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturereturn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CaptureReturn { get; set; }
            /// <summary>
            /// CaptureLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturelimits
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CaptureLimitsConfig
            /// </summary>
            public Union<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig, BaseFunction>? CaptureLimits { get; set; }
            /// <summary>
            /// CaptureArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturearguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CaptureArguments { get; set; }
            /// <summary>
            /// CaptureStackTrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturestacktrace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CaptureStackTrace { get; set; }
        }

        public class CodeLocation : Humidifier.Base.BaseSubResource, IHaveFilePath, IHaveLanguage, IHaveClassName, IHaveMethodName, IHaveLineNumber_Integer, IHaveCodeUnit
        {
            /// <summary>
            /// FilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-filepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilePath { get; set; }
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-language
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Language { get; set; }
            /// <summary>
            /// ClassName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-classname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClassName { get; set; }
            /// <summary>
            /// MethodName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-methodname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MethodName { get; set; }
            /// <summary>
            /// LineNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-linenumber
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LineNumber { get; set; }
            /// <summary>
            /// CodeUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-codeunit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodeUnit { get; set; }
        }

        public class Location : Humidifier.Base.BaseSubResource, IHaveApplicationSignalsInstrumentationConfigTypesCodeLocationCodeLocation
        {
            /// <summary>
            /// CodeLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-location.html#cfn-applicationsignals-instrumentationconfig-location-codelocation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CodeLocation
            /// </summary>
            public Union<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation, BaseFunction>? CodeLocation { get; set; }
        }
    }
}