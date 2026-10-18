namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
    using FunctionTypes;

    public class Function : Humidifier.Base.BaseResource, IHaveTags, IHaveFunctionId, IHaveMediaTailorFunctionTypesAwsServiceRequestConfigurationAwsServiceRequestConfiguration, IHaveMediaTailorFunctionTypesConcurrentExecutorConfigurationConcurrentExecutorConfiguration, IHaveDescription, IHaveFunctionType, IHaveMediaTailorFunctionTypesSequentialExecutorConfigurationSequentialExecutorConfiguration, IHaveMediaTailorFunctionTypesVastRequestConfigurationVastRequestConfiguration, IHaveMediaTailorFunctionTypesHttpRequestConfigurationHttpRequestConfiguration, IHaveMediaTailorFunctionTypesCustomOutputConfigurationCustomOutputConfiguration
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaTailor.Function; }

        /// <summary>
        /// FunctionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-functionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FunctionId { get; set; }
        /// <summary>
        /// AwsServiceRequestConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-awsservicerequestconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AwsServiceRequestConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.FunctionTypes.AwsServiceRequestConfiguration, BaseFunction>? AwsServiceRequestConfiguration { get; set; }
        /// <summary>
        /// ConcurrentExecutorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-concurrentexecutorconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConcurrentExecutorConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.FunctionTypes.ConcurrentExecutorConfiguration, BaseFunction>? ConcurrentExecutorConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// FunctionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-functiontype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FunctionType { get; set; }
        /// <summary>
        /// SequentialExecutorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-sequentialexecutorconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SequentialExecutorConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.FunctionTypes.SequentialExecutorConfiguration, BaseFunction>? SequentialExecutorConfiguration { get; set; }
        /// <summary>
        /// VastRequestConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-vastrequestconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VastRequestConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.FunctionTypes.VastRequestConfiguration, BaseFunction>? VastRequestConfiguration { get; set; }
        /// <summary>
        /// HttpRequestConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-httprequestconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HttpRequestConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.FunctionTypes.HttpRequestConfiguration, BaseFunction>? HttpRequestConfiguration { get; set; }
        /// <summary>
        /// CustomOutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-customoutputconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomOutputConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.FunctionTypes.CustomOutputConfiguration, BaseFunction>? CustomOutputConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FunctionTypes
    {
        public class AwsServiceRequestConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetRegion, IHaveMethodType, IHaveRuntime, IHaveTargetService, IHaveRequestTimeoutMilliseconds_Integer, IHaveStringDictionaryOfHeaders, IHaveStringDictionaryOfOutput, IHaveBody, IHaveUrl
        {
            /// <summary>
            /// TargetRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-targetregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetRegion { get; set; }
            /// <summary>
            /// MethodType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-methodtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MethodType { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// TargetService
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-targetservice
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetService { get; set; }
            /// <summary>
            /// RequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-requesttimeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Output { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class ConcurrentExecutorConfiguration : Humidifier.Base.BaseSubResource, IHaveRuntime, IHaveStringDictionaryOfOutput, IHaveListOfMediaTailorFunctionTypesFunctionRefFunctionList, IHaveMaxConcurrency_Integer, IHaveTimeoutMilliseconds_Integer
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-output
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Output { get; set; }
            /// <summary>
            /// FunctionList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-functionlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FunctionRef
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaTailor.FunctionTypes.FunctionRef>, IReadOnlyList<Union<Humidifier.MediaTailor.FunctionTypes.FunctionRef, BaseFunction>>, BaseFunction>? FunctionList { get; set; }
            /// <summary>
            /// MaxConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-maxconcurrency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConcurrency { get; set; }
            /// <summary>
            /// TimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-timeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutMilliseconds { get; set; }
        }

        public class CustomOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveRuntime, IHaveStringDictionaryOfOutput
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-customoutputconfiguration.html#cfn-mediatailor-function-customoutputconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-customoutputconfiguration.html#cfn-mediatailor-function-customoutputconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Output { get; set; }
        }

        public class FunctionRef : Humidifier.Base.BaseSubResource, IHaveFunctionId, IHaveRunCondition, IHaveAlias
        {
            /// <summary>
            /// FunctionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-functionref.html#cfn-mediatailor-function-functionref-functionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionId { get; set; }
            /// <summary>
            /// RunCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-functionref.html#cfn-mediatailor-function-functionref-runcondition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RunCondition { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-functionref.html#cfn-mediatailor-function-functionref-alias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
        }

        public class HttpRequestConfiguration : Humidifier.Base.BaseSubResource, IHaveMethodType, IHaveRuntime, IHaveRequestTimeoutMilliseconds_Integer, IHaveStringDictionaryOfHeaders, IHaveStringDictionaryOfOutput, IHaveBody, IHaveUrl
        {
            /// <summary>
            /// MethodType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-methodtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MethodType { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// RequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-requesttimeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Output { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class SequentialExecutorConfiguration : Humidifier.Base.BaseSubResource, IHaveRuntime, IHaveStringDictionaryOfOutput, IHaveListOfMediaTailorFunctionTypesFunctionRefFunctionList, IHaveTimeoutMilliseconds_Integer
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-sequentialexecutorconfiguration.html#cfn-mediatailor-function-sequentialexecutorconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-sequentialexecutorconfiguration.html#cfn-mediatailor-function-sequentialexecutorconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Output { get; set; }
            /// <summary>
            /// FunctionList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-sequentialexecutorconfiguration.html#cfn-mediatailor-function-sequentialexecutorconfiguration-functionlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FunctionRef
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaTailor.FunctionTypes.FunctionRef>, IReadOnlyList<Union<Humidifier.MediaTailor.FunctionTypes.FunctionRef, BaseFunction>>, BaseFunction>? FunctionList { get; set; }
            /// <summary>
            /// TimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-sequentialexecutorconfiguration.html#cfn-mediatailor-function-sequentialexecutorconfiguration-timeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutMilliseconds { get; set; }
        }

        public class VastRequestConfiguration : Humidifier.Base.BaseSubResource, IHaveMethodType, IHaveRuntime, IHaveRequestTimeoutMilliseconds_Integer, IHaveStringDictionaryOfHeaders, IHaveStringDictionaryOfOutput, IHaveBody, IHaveUrl
        {
            /// <summary>
            /// MethodType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-methodtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MethodType { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// RequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-requesttimeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Output { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Body { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }
    }
}