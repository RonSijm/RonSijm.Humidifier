namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using WebFunctionEndpointTypes;

    public class WebFunctionEndpoint : Humidifier.Base.BaseResource, IHaveFunctionName, IHaveDescription, IHaveListOfLambdaWebFunctionEndpointTypesRevisionWeightRevisionWeights, IHaveLambdaWebFunctionEndpointTypesScalingConfigScalingConfig, IHaveLambdaWebFunctionEndpointTypesThrottleConfigThrottleConfig, IHaveEndpointName, IHaveEndpointType, IHaveStringListOfRegions, IHaveAuthType
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
        public Union<string, BaseFunction>? FunctionName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// RevisionWeights
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-revisionweights
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RevisionWeight
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight>, IReadOnlyList<Union<Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight, BaseFunction>>, BaseFunction>? RevisionWeights { get; set; }
        /// <summary>
        /// ScalingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-scalingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScalingConfig
        /// </summary>
        public Union<Humidifier.Lambda.WebFunctionEndpointTypes.ScalingConfig, BaseFunction>? ScalingConfig { get; set; }
        /// <summary>
        /// ThrottleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-throttleconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThrottleConfig
        /// </summary>
        public Union<Humidifier.Lambda.WebFunctionEndpointTypes.ThrottleConfig, BaseFunction>? ThrottleConfig { get; set; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-endpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointName { get; set; }

        /// <summary>
        /// EndpointType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-endpointtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointType { get; set; }
        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-regions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }

        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-webfunctionendpoint.html#cfn-lambda-webfunctionendpoint-authtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthType { get; set; }
    }

    namespace WebFunctionEndpointTypes
    {
        public class RegionalEndpoint : Humidifier.Base.BaseSubResource, IHaveListOfLambdaWebFunctionEndpointTypesRevisionWeightRevisionWeights, IHaveLambdaWebFunctionEndpointTypesScalingConfigScalingConfig, IHaveUpdateStatus, IHaveLambdaWebFunctionEndpointTypesThrottleConfigThrottleConfig, IHaveDomainName, IHaveState, IHaveStateReason, IHaveAuthType, IHaveUpdateStatusReason
        {
            /// <summary>
            /// RevisionWeights
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-revisionweights
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RevisionWeight
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight>, IReadOnlyList<Union<Humidifier.Lambda.WebFunctionEndpointTypes.RevisionWeight, BaseFunction>>, BaseFunction>? RevisionWeights { get; set; }
            /// <summary>
            /// ScalingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-scalingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScalingConfig
            /// </summary>
            public Union<Humidifier.Lambda.WebFunctionEndpointTypes.ScalingConfig, BaseFunction>? ScalingConfig { get; set; }
            /// <summary>
            /// UpdateStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-updatestatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateStatus { get; set; }
            /// <summary>
            /// ThrottleConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-throttleconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThrottleConfig
            /// </summary>
            public Union<Humidifier.Lambda.WebFunctionEndpointTypes.ThrottleConfig, BaseFunction>? ThrottleConfig { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-domainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// StateReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-statereason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateReason { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-authtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthType { get; set; }
            /// <summary>
            /// UpdateStatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-regionalendpoint.html#cfn-lambda-webfunctionendpoint-regionalendpoint-updatestatusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateStatusReason { get; set; }
        }

        public class RevisionWeight : Humidifier.Base.BaseSubResource, IHaveRevisionId, IHaveWeight_Integer
        {
            /// <summary>
            /// RevisionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-revisionweight.html#cfn-lambda-webfunctionendpoint-revisionweight-revisionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RevisionId { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-revisionweight.html#cfn-lambda-webfunctionendpoint-revisionweight-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }

        public class ScalingConfig : Humidifier.Base.BaseSubResource, IHaveMaxEnvironments_Integer
        {
            /// <summary>
            /// MaxEnvironments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-scalingconfig.html#cfn-lambda-webfunctionendpoint-scalingconfig-maxenvironments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxEnvironments { get; set; }
        }

        public class ThrottleConfig : Humidifier.Base.BaseSubResource, IHaveRateLimit_Integer
        {
            /// <summary>
            /// RateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-webfunctionendpoint-throttleconfig.html#cfn-lambda-webfunctionendpoint-throttleconfig-ratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RateLimit { get; set; }
        }
    }
}