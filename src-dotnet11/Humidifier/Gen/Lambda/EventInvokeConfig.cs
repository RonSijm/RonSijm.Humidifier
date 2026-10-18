namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using EventInvokeConfigTypes;

    public class EventInvokeConfig : Humidifier.Base.BaseResource, IHaveFunctionName, IHaveMaximumRetryAttempts_Integer, IHaveLambdaEventInvokeConfigTypesDestinationConfigDestinationConfig, IHaveQualifier, IHaveMaximumEventAgeInSeconds_Integer
    {
        public override string AWSTypeName { get => AWS.Lambda.EventInvokeConfig; }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventinvokeconfig.html#cfn-lambda-eventinvokeconfig-functionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FunctionName { get; set; }
        /// <summary>
        /// MaximumRetryAttempts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventinvokeconfig.html#cfn-lambda-eventinvokeconfig-maximumretryattempts
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumRetryAttempts { get; set; }
        /// <summary>
        /// DestinationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventinvokeconfig.html#cfn-lambda-eventinvokeconfig-destinationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DestinationConfig
        /// </summary>
        public Union<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig, BaseFunction>? DestinationConfig { get; set; }

        /// <summary>
        /// Qualifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventinvokeconfig.html#cfn-lambda-eventinvokeconfig-qualifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Qualifier { get; set; }
        /// <summary>
        /// MaximumEventAgeInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventinvokeconfig.html#cfn-lambda-eventinvokeconfig-maximumeventageinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumEventAgeInSeconds { get; set; }
    }

    namespace EventInvokeConfigTypes
    {
        public class DestinationConfig : Humidifier.Base.BaseSubResource, IHaveLambdaEventInvokeConfigTypesOnSuccessOnSuccess, IHaveLambdaEventInvokeConfigTypesOnFailureOnFailure
        {
            /// <summary>
            /// OnSuccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventinvokeconfig-destinationconfig.html#cfn-lambda-eventinvokeconfig-destinationconfig-onsuccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnSuccess
            /// </summary>
            public Union<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess, BaseFunction>? OnSuccess { get; set; }
            /// <summary>
            /// OnFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventinvokeconfig-destinationconfig.html#cfn-lambda-eventinvokeconfig-destinationconfig-onfailure
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnFailure
            /// </summary>
            public Union<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure, BaseFunction>? OnFailure { get; set; }
        }

        public class OnFailure : Humidifier.Base.BaseSubResource, IHaveDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventinvokeconfig-onfailure.html#cfn-lambda-eventinvokeconfig-onfailure-destination
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
        }

        public class OnSuccess : Humidifier.Base.BaseSubResource, IHaveDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventinvokeconfig-onsuccess.html#cfn-lambda-eventinvokeconfig-onsuccess-destination
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
        }
    }
}