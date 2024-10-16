namespace Humidifier.Events
{
    using System.Collections.Generic;
    using ConnectionTypes;

    public class Connection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveAuthorizationType
    {
        public class Attributes
        {
            public static string SecretArn =  "SecretArn" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Events.Connection; }
        /// <summary>
        /// AuthParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-connection.html#cfn-events-connection-authparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthParameters
        /// </summary>
        public Humidifier.Events.ConnectionTypes.AuthParameters AuthParameters { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-connection.html#cfn-events-connection-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// AuthorizationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-connection.html#cfn-events-connection-authorizationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizationType { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConnectionTypes
    {
        public class ApiKeyAuthParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApiKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-apikeyauthparameters.html#cfn-events-connection-apikeyauthparameters-apikeyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyValue { get; set; }
            /// <summary>
            /// ApiKeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-apikeyauthparameters.html#cfn-events-connection-apikeyauthparameters-apikeyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyName { get; set; }
        }

        public class AuthParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InvocationHttpParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-authparameters.html#cfn-events-connection-authparameters-invocationhttpparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionHttpParameters
            /// </summary>
            public Humidifier.Events.ConnectionTypes.ConnectionHttpParameters InvocationHttpParameters { get; set; }
            /// <summary>
            /// BasicAuthParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-authparameters.html#cfn-events-connection-authparameters-basicauthparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthParameters
            /// </summary>
            public Humidifier.Events.ConnectionTypes.BasicAuthParameters BasicAuthParameters { get; set; }
            /// <summary>
            /// ApiKeyAuthParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-authparameters.html#cfn-events-connection-authparameters-apikeyauthparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiKeyAuthParameters
            /// </summary>
            public Humidifier.Events.ConnectionTypes.ApiKeyAuthParameters ApiKeyAuthParameters { get; set; }
            /// <summary>
            /// OAuthParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-authparameters.html#cfn-events-connection-authparameters-oauthparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthParameters
            /// </summary>
            public Humidifier.Events.ConnectionTypes.OAuthParameters OAuthParameters { get; set; }
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
            public dynamic Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-basicauthparameters.html#cfn-events-connection-basicauthparameters-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Password { get; set; }
        }

        public class ClientParameters : Humidifier.Base.BaseSubResource, IHaveClientSecret
        {
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-clientparameters.html#cfn-events-connection-clientparameters-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-clientparameters.html#cfn-events-connection-clientparameters-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientID { get; set; }
        }

        public class ConnectionHttpParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeaderParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-connectionhttpparameters.html#cfn-events-connection-connectionhttpparameters-headerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Parameter
            /// </summary>
            public List<Humidifier.Events.ConnectionTypes.Parameter> HeaderParameters { get; set; }
            /// <summary>
            /// QueryStringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-connectionhttpparameters.html#cfn-events-connection-connectionhttpparameters-querystringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Parameter
            /// </summary>
            public List<Humidifier.Events.ConnectionTypes.Parameter> QueryStringParameters { get; set; }
            /// <summary>
            /// BodyParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-connectionhttpparameters.html#cfn-events-connection-connectionhttpparameters-bodyparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Parameter
            /// </summary>
            public List<Humidifier.Events.ConnectionTypes.Parameter> BodyParameters { get; set; }
        }

        public class OAuthParameters : Humidifier.Base.BaseSubResource, IHaveHttpMethod, IHaveAuthorizationEndpoint
        {
            /// <summary>
            /// ClientParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-oauthparameters.html#cfn-events-connection-oauthparameters-clientparameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClientParameters
            /// </summary>
            public Humidifier.Events.ConnectionTypes.ClientParameters ClientParameters { get; set; }
            /// <summary>
            /// OAuthHttpParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-oauthparameters.html#cfn-events-connection-oauthparameters-oauthhttpparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionHttpParameters
            /// </summary>
            public Humidifier.Events.ConnectionTypes.ConnectionHttpParameters OAuthHttpParameters { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-oauthparameters.html#cfn-events-connection-oauthparameters-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationEndpoint { get; set; }
            /// <summary>
            /// HttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-oauthparameters.html#cfn-events-connection-oauthparameters-httpmethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpMethod { get; set; }
        }

        public class Parameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-parameter.html#cfn-events-connection-parameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// IsValueSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-parameter.html#cfn-events-connection-parameter-isvaluesecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsValueSecret { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-connection-parameter.html#cfn-events-connection-parameter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}