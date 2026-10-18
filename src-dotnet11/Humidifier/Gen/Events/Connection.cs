namespace Humidifier.Events
{
    using global::System.Collections.Generic;
    using ConnectionTypes;

    public class Connection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveEventsConnectionTypesAuthParametersAuthParameters, IHaveKmsKeyIdentifier, IHaveDescription, IHaveEventsConnectionTypesInvocationConnectivityParametersInvocationConnectivityParameters, IHaveAuthorizationType, IHaveName
    {
        public class Attributes
        {
            public static string SecretArn =  "SecretArn" ;
            public static string Arn =  "Arn" ;
            public static string ArnForPolicy =  "ArnForPolicy" ;
        }

        public override string AWSTypeName { get => AWS.Events.Connection; }
        /// <summary>
        /// AuthParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-connection.html#cfn-events-connection-authparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthParameters
        /// </summary>
        public Union<Humidifier.Events.ConnectionTypes.AuthParameters, BaseFunction>? AuthParameters { get; set; }
        /// <summary>
        /// KmsKeyIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-connection.html#cfn-events-connection-kmskeyidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-connection.html#cfn-events-connection-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// InvocationConnectivityParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-connection.html#cfn-events-connection-invocationconnectivityparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InvocationConnectivityParameters
        /// </summary>
        public Union<Humidifier.Events.ConnectionTypes.InvocationConnectivityParameters, BaseFunction>? InvocationConnectivityParameters { get; set; }
        /// <summary>
        /// AuthorizationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-connection.html#cfn-events-connection-authorizationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthorizationType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConnectionTypes
    {
        public class ApiKeyAuthParameters : Humidifier.Base.BaseSubResource, IHaveApiKeyValue, IHaveApiKeyName
        {
            /// <summary>
            /// ApiKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-apikeyauthparameters.html#cfn-events-connection-apikeyauthparameters-apikeyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyValue { get; set; }
            /// <summary>
            /// ApiKeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-apikeyauthparameters.html#cfn-events-connection-apikeyauthparameters-apikeyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyName { get; set; }
        }

        public class AuthParameters : Humidifier.Base.BaseSubResource, IHaveEventsConnectionTypesConnectionHttpParametersInvocationHttpParameters, IHaveEventsConnectionTypesConnectivityParametersConnectivityParameters, IHaveEventsConnectionTypesBasicAuthParametersBasicAuthParameters, IHaveEventsConnectionTypesApiKeyAuthParametersApiKeyAuthParameters, IHaveEventsConnectionTypesOAuthParametersOAuthParameters
        {
            /// <summary>
            /// InvocationHttpParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-authparameters.html#cfn-events-connection-authparameters-invocationhttpparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionHttpParameters
            /// </summary>
            public Union<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters, BaseFunction>? InvocationHttpParameters { get; set; }
            /// <summary>
            /// ConnectivityParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-authparameters.html#cfn-events-connection-authparameters-connectivityparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectivityParameters
            /// </summary>
            public Union<Humidifier.Events.ConnectionTypes.ConnectivityParameters, BaseFunction>? ConnectivityParameters { get; set; }
            /// <summary>
            /// BasicAuthParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-authparameters.html#cfn-events-connection-authparameters-basicauthparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthParameters
            /// </summary>
            public Union<Humidifier.Events.ConnectionTypes.BasicAuthParameters, BaseFunction>? BasicAuthParameters { get; set; }
            /// <summary>
            /// ApiKeyAuthParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-authparameters.html#cfn-events-connection-authparameters-apikeyauthparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiKeyAuthParameters
            /// </summary>
            public Union<Humidifier.Events.ConnectionTypes.ApiKeyAuthParameters, BaseFunction>? ApiKeyAuthParameters { get; set; }
            /// <summary>
            /// OAuthParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-authparameters.html#cfn-events-connection-authparameters-oauthparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthParameters
            /// </summary>
            public Union<Humidifier.Events.ConnectionTypes.OAuthParameters, BaseFunction>? OAuthParameters { get; set; }
        }

        public class BasicAuthParameters : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-basicauthparameters.html#cfn-events-connection-basicauthparameters-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-basicauthparameters.html#cfn-events-connection-basicauthparameters-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class ClientParameters : Humidifier.Base.BaseSubResource, IHaveClientSecret, IHaveClientID
        {
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-clientparameters.html#cfn-events-connection-clientparameters-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-clientparameters.html#cfn-events-connection-clientparameters-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientID { get; set; }
        }

        public class ConnectionHttpParameters : Humidifier.Base.BaseSubResource, IHaveListOfEventsConnectionTypesParameterBodyParameters, IHaveListOfEventsConnectionTypesParameterHeaderParameters, IHaveListOfEventsConnectionTypesParameterQueryStringParameters
        {
            /// <summary>
            /// BodyParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-connectionhttpparameters.html#cfn-events-connection-connectionhttpparameters-bodyparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Parameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Events.ConnectionTypes.Parameter>, IReadOnlyList<Union<Humidifier.Events.ConnectionTypes.Parameter, BaseFunction>>, BaseFunction>? BodyParameters { get; set; }
            /// <summary>
            /// HeaderParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-connectionhttpparameters.html#cfn-events-connection-connectionhttpparameters-headerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Parameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Events.ConnectionTypes.Parameter>, IReadOnlyList<Union<Humidifier.Events.ConnectionTypes.Parameter, BaseFunction>>, BaseFunction>? HeaderParameters { get; set; }
            /// <summary>
            /// QueryStringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-connectionhttpparameters.html#cfn-events-connection-connectionhttpparameters-querystringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Parameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Events.ConnectionTypes.Parameter>, IReadOnlyList<Union<Humidifier.Events.ConnectionTypes.Parameter, BaseFunction>>, BaseFunction>? QueryStringParameters { get; set; }
        }

        public class ConnectivityParameters : Humidifier.Base.BaseSubResource, IHaveEventsConnectionTypesResourceParametersResourceParameters
        {
            /// <summary>
            /// ResourceParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-connectivityparameters.html#cfn-events-connection-connectivityparameters-resourceparameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResourceParameters
            /// </summary>
            public Union<Humidifier.Events.ConnectionTypes.ResourceParameters, BaseFunction>? ResourceParameters { get; set; }
        }

        public class InvocationConnectivityParameters : Humidifier.Base.BaseSubResource, IHaveEventsConnectionTypesResourceParametersResourceParameters
        {
            /// <summary>
            /// ResourceParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-invocationconnectivityparameters.html#cfn-events-connection-invocationconnectivityparameters-resourceparameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResourceParameters
            /// </summary>
            public Union<Humidifier.Events.ConnectionTypes.ResourceParameters, BaseFunction>? ResourceParameters { get; set; }
        }

        public class OAuthParameters : Humidifier.Base.BaseSubResource, IHaveEventsConnectionTypesClientParametersClientParameters, IHaveEventsConnectionTypesConnectionHttpParametersOAuthHttpParameters, IHaveAuthorizationEndpoint, IHaveHttpMethod
        {
            /// <summary>
            /// ClientParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-oauthparameters.html#cfn-events-connection-oauthparameters-clientparameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClientParameters
            /// </summary>
            public Union<Humidifier.Events.ConnectionTypes.ClientParameters, BaseFunction>? ClientParameters { get; set; }
            /// <summary>
            /// OAuthHttpParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-oauthparameters.html#cfn-events-connection-oauthparameters-oauthhttpparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionHttpParameters
            /// </summary>
            public Union<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters, BaseFunction>? OAuthHttpParameters { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-oauthparameters.html#cfn-events-connection-oauthparameters-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationEndpoint { get; set; }
            /// <summary>
            /// HttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-oauthparameters.html#cfn-events-connection-oauthparameters-httpmethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpMethod { get; set; }
        }

        public class Parameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveIsValueSecret_Boolean, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-parameter.html#cfn-events-connection-parameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// IsValueSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-parameter.html#cfn-events-connection-parameter-isvaluesecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsValueSecret { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-parameter.html#cfn-events-connection-parameter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ResourceParameters : Humidifier.Base.BaseSubResource, IHaveResourceConfigurationArn, IHaveResourceAssociationArn
        {
            /// <summary>
            /// ResourceConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-resourceparameters.html#cfn-events-connection-resourceparameters-resourceconfigurationarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceConfigurationArn { get; set; }
            /// <summary>
            /// ResourceAssociationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-resourceparameters.html#cfn-events-connection-resourceparameters-resourceassociationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceAssociationArn { get; set; }
        }
    }
}