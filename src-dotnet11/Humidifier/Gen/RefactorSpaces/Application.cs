namespace Humidifier.RefactorSpaces
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEnvironmentIdentifier, IHaveVpcId, IHaveRefactorSpacesApplicationTypesApiGatewayProxyInputApiGatewayProxy, IHaveProxyType, IHaveName
    {
        public class Attributes
        {
            public static string NlbArn =  "NlbArn" ;
            public static string ProxyUrl =  "ProxyUrl" ;
            public static string NlbName =  "NlbName" ;
            public static string StageName =  "StageName" ;
            public static string ApiGatewayId =  "ApiGatewayId" ;
            public static string VpcLinkId =  "VpcLinkId" ;
            public static string ApplicationIdentifier =  "ApplicationIdentifier" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RefactorSpaces.Application; }

        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-application.html#cfn-refactorspaces-application-environmentidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EnvironmentIdentifier { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-application.html#cfn-refactorspaces-application-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// ApiGatewayProxy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-application.html#cfn-refactorspaces-application-apigatewayproxy
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ApiGatewayProxyInput
        /// </summary>
        public Union<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput, BaseFunction>? ApiGatewayProxy { get; set; }

        /// <summary>
        /// ProxyType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-application.html#cfn-refactorspaces-application-proxytype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProxyType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-refactorspaces-application.html#cfn-refactorspaces-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ApplicationTypes
    {
        public class ApiGatewayProxyInput : Humidifier.Base.BaseSubResource, IHaveStageName, IHaveEndpointType
        {
            /// <summary>
            /// StageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-application-apigatewayproxyinput.html#cfn-refactorspaces-application-apigatewayproxyinput-stagename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StageName { get; set; }
            /// <summary>
            /// EndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-refactorspaces-application-apigatewayproxyinput.html#cfn-refactorspaces-application-apigatewayproxyinput-endpointtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointType { get; set; }
        }
    }
}