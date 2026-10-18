namespace Humidifier.RefactorSpaces
{
    using global::System.Collections.Generic;
    using ServiceTypes;

    public class Service : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRefactorSpacesServiceTypesLambdaEndpointInputLambdaEndpoint, IHaveRefactorSpacesServiceTypesUrlEndpointInputUrlEndpoint, IHaveDescription, IHaveEnvironmentIdentifier, IHaveVpcId, IHaveEndpointType, IHaveApplicationIdentifier, IHaveName
    {
        public class Attributes
        {
            public static string ServiceIdentifier =  "ServiceIdentifier" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RefactorSpaces.Service; }
        /// <summary>
        /// LambdaEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-service.html#cfn-refactorspaces-service-lambdaendpoint
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LambdaEndpointInput
        /// </summary>
        public Union<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput, BaseFunction>? LambdaEndpoint { get; set; }
        /// <summary>
        /// UrlEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-service.html#cfn-refactorspaces-service-urlendpoint
        /// Required: False
        /// UpdateType: Immutable
        /// Type: UrlEndpointInput
        /// </summary>
        public Union<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput, BaseFunction>? UrlEndpoint { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-service.html#cfn-refactorspaces-service-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-service.html#cfn-refactorspaces-service-environmentidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EnvironmentIdentifier { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-service.html#cfn-refactorspaces-service-vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// EndpointType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-service.html#cfn-refactorspaces-service-endpointtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointType { get; set; }

        /// <summary>
        /// ApplicationIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-service.html#cfn-refactorspaces-service-applicationidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-service.html#cfn-refactorspaces-service-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ServiceTypes
    {
        public class LambdaEndpointInput : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-service-lambdaendpointinput.html#cfn-refactorspaces-service-lambdaendpointinput-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class UrlEndpointInput : Humidifier.Base.BaseSubResource, IHaveHealthUrl, IHaveUrl
        {
            /// <summary>
            /// HealthUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-service-urlendpointinput.html#cfn-refactorspaces-service-urlendpointinput-healthurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HealthUrl { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-service-urlendpointinput.html#cfn-refactorspaces-service-urlendpointinput-url
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }
    }
}