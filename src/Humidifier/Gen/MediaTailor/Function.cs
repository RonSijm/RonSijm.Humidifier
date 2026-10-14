namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
    using FunctionTypes;

    public class Function : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
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
        public dynamic FunctionId { get; set; }
        /// <summary>
        /// AwsServiceRequestConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-awsservicerequestconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AwsServiceRequestConfiguration
        /// </summary>
        public Humidifier.MediaTailor.FunctionTypes.AwsServiceRequestConfiguration AwsServiceRequestConfiguration { get; set; }
        /// <summary>
        /// ConcurrentExecutorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-concurrentexecutorconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConcurrentExecutorConfiguration
        /// </summary>
        public Humidifier.MediaTailor.FunctionTypes.ConcurrentExecutorConfiguration ConcurrentExecutorConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// FunctionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-functiontype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FunctionType { get; set; }
        /// <summary>
        /// SequentialExecutorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-sequentialexecutorconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SequentialExecutorConfiguration
        /// </summary>
        public Humidifier.MediaTailor.FunctionTypes.SequentialExecutorConfiguration SequentialExecutorConfiguration { get; set; }
        /// <summary>
        /// VastRequestConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-vastrequestconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VastRequestConfiguration
        /// </summary>
        public Humidifier.MediaTailor.FunctionTypes.VastRequestConfiguration VastRequestConfiguration { get; set; }
        /// <summary>
        /// HttpRequestConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-httprequestconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HttpRequestConfiguration
        /// </summary>
        public Humidifier.MediaTailor.FunctionTypes.HttpRequestConfiguration HttpRequestConfiguration { get; set; }
        /// <summary>
        /// CustomOutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-customoutputconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomOutputConfiguration
        /// </summary>
        public Humidifier.MediaTailor.FunctionTypes.CustomOutputConfiguration CustomOutputConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-function.html#cfn-mediatailor-function-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace FunctionTypes
    {
        public class AwsServiceRequestConfiguration : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveBody, IHaveRuntime, IHaveTargetRegion
        {
            /// <summary>
            /// TargetRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-targetregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetRegion { get; set; }
            /// <summary>
            /// MethodType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-methodtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MethodType { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
            /// <summary>
            /// TargetService
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-targetservice
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetService { get; set; }
            /// <summary>
            /// RequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-requesttimeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Headers { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Output { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Body { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-awsservicerequestconfiguration.html#cfn-mediatailor-function-awsservicerequestconfiguration-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class ConcurrentExecutorConfiguration : Humidifier.Base.BaseSubResource, IHaveRuntime, IHaveMaxConcurrency
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-output
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Output { get; set; }
            /// <summary>
            /// FunctionList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-functionlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FunctionRef
            /// </summary>
            public List<Humidifier.MediaTailor.FunctionTypes.FunctionRef> FunctionList { get; set; }
            /// <summary>
            /// MaxConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-maxconcurrency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConcurrency { get; set; }
            /// <summary>
            /// TimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-concurrentexecutorconfiguration.html#cfn-mediatailor-function-concurrentexecutorconfiguration-timeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutMilliseconds { get; set; }
        }

        public class CustomOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveRuntime
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-customoutputconfiguration.html#cfn-mediatailor-function-customoutputconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-customoutputconfiguration.html#cfn-mediatailor-function-customoutputconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Output { get; set; }
        }

        public class FunctionRef : Humidifier.Base.BaseSubResource, IHaveAlias
        {
            /// <summary>
            /// FunctionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-functionref.html#cfn-mediatailor-function-functionref-functionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionId { get; set; }
            /// <summary>
            /// RunCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-functionref.html#cfn-mediatailor-function-functionref-runcondition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RunCondition { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-functionref.html#cfn-mediatailor-function-functionref-alias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
        }

        public class HttpRequestConfiguration : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveBody, IHaveRuntime
        {
            /// <summary>
            /// MethodType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-methodtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MethodType { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
            /// <summary>
            /// RequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-requesttimeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Headers { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Output { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Body { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-httprequestconfiguration.html#cfn-mediatailor-function-httprequestconfiguration-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class SequentialExecutorConfiguration : Humidifier.Base.BaseSubResource, IHaveRuntime
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-sequentialexecutorconfiguration.html#cfn-mediatailor-function-sequentialexecutorconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-sequentialexecutorconfiguration.html#cfn-mediatailor-function-sequentialexecutorconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Output { get; set; }
            /// <summary>
            /// FunctionList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-sequentialexecutorconfiguration.html#cfn-mediatailor-function-sequentialexecutorconfiguration-functionlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FunctionRef
            /// </summary>
            public List<Humidifier.MediaTailor.FunctionTypes.FunctionRef> FunctionList { get; set; }
            /// <summary>
            /// TimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-sequentialexecutorconfiguration.html#cfn-mediatailor-function-sequentialexecutorconfiguration-timeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutMilliseconds { get; set; }
        }

        public class VastRequestConfiguration : Humidifier.Base.BaseSubResource, IHaveUrl, IHaveBody, IHaveRuntime
        {
            /// <summary>
            /// MethodType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-methodtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MethodType { get; set; }
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-runtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
            /// <summary>
            /// RequestTimeoutMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-requesttimeoutmilliseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RequestTimeoutMilliseconds { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Headers { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-output
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Output { get; set; }
            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Body { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-function-vastrequestconfiguration.html#cfn-mediatailor-function-vastrequestconfiguration-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }
    }
}