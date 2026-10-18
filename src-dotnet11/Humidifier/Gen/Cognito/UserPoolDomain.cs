namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using UserPoolDomainTypes;

    public class UserPoolDomain : Humidifier.Base.BaseResource, IHaveUserPoolId, IHaveCognitoUserPoolDomainTypesCustomDomainConfigTypeCustomDomainConfig, IHaveCognitoUserPoolDomainTypesRoutingTypeRouting, IHaveDomain, IHaveManagedLoginVersion_Integer
    {
        public class Attributes
        {
            public static string CloudFrontDistribution =  "CloudFrontDistribution" ;
        }

        public override string AWSTypeName { get => AWS.Cognito.UserPoolDomain; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html#cfn-cognito-userpooldomain-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserPoolId { get; set; }
        /// <summary>
        /// CustomDomainConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html#cfn-cognito-userpooldomain-customdomainconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomDomainConfigType
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType, BaseFunction>? CustomDomainConfig { get; set; }
        /// <summary>
        /// Routing
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html#cfn-cognito-userpooldomain-routing
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RoutingType
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolDomainTypes.RoutingType, BaseFunction>? Routing { get; set; }

        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html#cfn-cognito-userpooldomain-domain
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Domain { get; set; }
        /// <summary>
        /// ManagedLoginVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html#cfn-cognito-userpooldomain-managedloginversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ManagedLoginVersion { get; set; }
    }

    namespace UserPoolDomainTypes
    {
        public class CustomDomainConfigType : Humidifier.Base.BaseSubResource, IHaveSecurityPolicy, IHaveCertificateArn
        {
            /// <summary>
            /// SecurityPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-customdomainconfigtype.html#cfn-cognito-userpooldomain-customdomainconfigtype-securitypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityPolicy { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-customdomainconfigtype.html#cfn-cognito-userpooldomain-customdomainconfigtype-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class FailoverType : Humidifier.Base.BaseSubResource, IHavePrimaryRoute53HealthCheckId, IHaveSecondaryRegion
        {
            /// <summary>
            /// PrimaryRoute53HealthCheckId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-failovertype.html#cfn-cognito-userpooldomain-failovertype-primaryroute53healthcheckid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryRoute53HealthCheckId { get; set; }
            /// <summary>
            /// SecondaryRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-failovertype.html#cfn-cognito-userpooldomain-failovertype-secondaryregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecondaryRegion { get; set; }
        }

        public class RoutingType : Humidifier.Base.BaseSubResource, IHaveCognitoUserPoolDomainTypesFailoverTypeFailover
        {
            /// <summary>
            /// Failover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-routingtype.html#cfn-cognito-userpooldomain-routingtype-failover
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FailoverType
            /// </summary>
            public Union<Humidifier.Cognito.UserPoolDomainTypes.FailoverType, BaseFunction>? Failover { get; set; }
        }
    }
}