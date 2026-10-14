namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using WebFunctionEndpointTypes;

    public class WebFunctionEndpoint : Humidifier.Base.BaseResource, IHaveDescription, IHaveEndpointName, IHaveAuthType, IHaveEndpointType, IHaveFunctionName, IHaveRegions
    {
        public class Attributes
        {
            public static string FunctionArn =  "FunctionArn" ;
            public static string UpdateStatus =  "UpdateStatus" ;
            public static string RegionalEndpoints =  "RegionalEndpoints" ;
            public static string DomainName =  "DomainName" ;
            public static string State =  "State" ;
            public static string StateReason =  "StateReason" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string EndpointArn =  "EndpointArn" ;
            public static string UpdateStatusReason =  "UpdateStatusReason" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.WebFunctionEndpoint; }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-functionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FunctionName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// RevisionWeights
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-revisionweights
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RevisionWeight
        /// </summary>
        public List<Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight> RevisionWeights { get; set; }
        /// <summary>
        /// ScalingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-scalingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScalingConfig
        /// </summary>
        public Humidifier.Lambda.WebFunctionEndpointTypes.ScalingConfig ScalingConfig { get; set; }
        /// <summary>
        /// ThrottleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-throttleconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThrottleConfig
        /// </summary>
        public Humidifier.Lambda.WebFunctionEndpointTypes.ThrottleConfig ThrottleConfig { get; set; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-endpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EndpointName { get; set; }

        /// <summary>
        /// EndpointType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-endpointtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EndpointType { get; set; }
        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-regions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Regions { get; set; }

        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-authtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AuthType { get; set; }
    }

    namespace WebFunctionEndpointTypes
    {
        public class RegionalEndpoint : Humidifier.Base.BaseSubResource, IHaveState, IHaveDomainName, IHaveAuthType, IHaveUpdateStatus
        {
            /// <summary>
            /// RevisionWeights
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-revisionweights
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RevisionWeight
            /// </summary>
            public List<Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight> RevisionWeights { get; set; }
            /// <summary>
            /// ScalingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-scalingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScalingConfig
            /// </summary>
            public Humidifier.Lambda.WebFunctionEndpointTypes.ScalingConfig ScalingConfig { get; set; }
            /// <summary>
            /// UpdateStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-updatestatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateStatus { get; set; }
            /// <summary>
            /// ThrottleConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-throttleconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThrottleConfig
            /// </summary>
            public Humidifier.Lambda.WebFunctionEndpointTypes.ThrottleConfig ThrottleConfig { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-domainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// StateReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-statereason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StateReason { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-authtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthType { get; set; }
            /// <summary>
            /// UpdateStatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-updatestatusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateStatusReason { get; set; }
        }

        public class RevisionWeight : Humidifier.Base.BaseSubResource, IHaveWeight
        {
            /// <summary>
            /// RevisionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-revisionweight.html#cfn-lambda-webfunctionendpoint-revisionweight-revisionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RevisionId { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-revisionweight.html#cfn-lambda-webfunctionendpoint-revisionweight-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Weight { get; set; }
        }

        public class ScalingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxEnvironments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-scalingconfig.html#cfn-lambda-webfunctionendpoint-scalingconfig-maxenvironments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxEnvironments { get; set; }
        }

        public class ThrottleConfig : Humidifier.Base.BaseSubResource, IHaveRateLimit
        {
            /// <summary>
            /// RateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-throttleconfig.html#cfn-lambda-webfunctionendpoint-throttleconfig-ratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RateLimit { get; set; }
        }
    }
}