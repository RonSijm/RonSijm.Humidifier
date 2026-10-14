namespace Humidifier.ApplicationSignals
{
    using global::System.Collections.Generic;
    using InstrumentationConfigTypes;

    public class InstrumentationConfig : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveService, IHaveEnvironment
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
        public dynamic Description { get; set; }

        /// <summary>
        /// SignalType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-signaltype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SignalType { get; set; }
        /// <summary>
        /// AttributeFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-attributefilters
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic AttributeFilters { get; set; }

        /// <summary>
        /// InstrumentationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-instrumentationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstrumentationType { get; set; }

        /// <summary>
        /// CaptureConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-captureconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CaptureConfiguration
        /// </summary>
        [Required]
        public Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration CaptureConfiguration { get; set; }

        /// <summary>
        /// Service
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-service
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Service { get; set; }

        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-environment
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Environment { get; set; }
        /// <summary>
        /// ExpiresAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-expiresat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExpiresAt { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-instrumentationconfig.html#cfn-applicationsignals-instrumentationconfig-location
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Location
        /// </summary>
        [Required]
        public Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location Location { get; set; }
    }

    namespace InstrumentationConfigTypes
    {
        public class CaptureConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CodeCapture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-captureconfiguration.html#cfn-applicationsignals-instrumentationconfig-captureconfiguration-codecapture
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CodeCaptureConfiguration
            /// </summary>
            public Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration CodeCapture { get; set; }
        }

        public class CaptureLimitsConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxStringLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxstringlength
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxStringLength { get; set; }
            /// <summary>
            /// MaxCollectionDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxcollectiondepth
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCollectionDepth { get; set; }
            /// <summary>
            /// MaxCollectionWidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxcollectionwidth
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCollectionWidth { get; set; }
            /// <summary>
            /// MaxObjectDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxobjectdepth
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxObjectDepth { get; set; }
            /// <summary>
            /// MaxHits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxhits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxHits { get; set; }
            /// <summary>
            /// MaxStackFrames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxstackframes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxStackFrames { get; set; }
            /// <summary>
            /// MaxStackTraceSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxstacktracesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxStackTraceSize { get; set; }
            /// <summary>
            /// MaxFieldsPerObject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-capturelimitsconfig.html#cfn-applicationsignals-instrumentationconfig-capturelimitsconfig-maxfieldsperobject
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxFieldsPerObject { get; set; }
        }

        public class CodeCaptureConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CaptureLocals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturelocals
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CaptureLocals { get; set; }
            /// <summary>
            /// CaptureReturn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturereturn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CaptureReturn { get; set; }
            /// <summary>
            /// CaptureLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturelimits
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CaptureLimitsConfig
            /// </summary>
            public Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig CaptureLimits { get; set; }
            /// <summary>
            /// CaptureArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturearguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CaptureArguments { get; set; }
            /// <summary>
            /// CaptureStackTrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codecaptureconfiguration.html#cfn-applicationsignals-instrumentationconfig-codecaptureconfiguration-capturestacktrace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CaptureStackTrace { get; set; }
        }

        public class CodeLocation : Humidifier.Base.BaseSubResource, IHaveLanguage
        {
            /// <summary>
            /// FilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-filepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilePath { get; set; }
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-language
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Language { get; set; }
            /// <summary>
            /// ClassName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-classname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClassName { get; set; }
            /// <summary>
            /// MethodName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-methodname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MethodName { get; set; }
            /// <summary>
            /// LineNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-linenumber
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LineNumber { get; set; }
            /// <summary>
            /// CodeUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-codelocation.html#cfn-applicationsignals-instrumentationconfig-codelocation-codeunit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodeUnit { get; set; }
        }

        public class Location : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CodeLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-instrumentationconfig-location.html#cfn-applicationsignals-instrumentationconfig-location-codelocation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CodeLocation
            /// </summary>
            public Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation CodeLocation { get; set; }
        }
    }
}