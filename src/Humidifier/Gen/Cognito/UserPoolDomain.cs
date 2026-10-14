namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using UserPoolDomainTypes;

    public class UserPoolDomain : Humidifier.Base.BaseResource, IHaveDomain, IHaveUserPoolId
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
        public dynamic UserPoolId { get; set; }
        /// <summary>
        /// CustomDomainConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html#cfn-cognito-userpooldomain-customdomainconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomDomainConfigType
        /// </summary>
        public Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType CustomDomainConfig { get; set; }
        /// <summary>
        /// Routing
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html#cfn-cognito-userpooldomain-routing
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RoutingType
        /// </summary>
        public Humidifier.Cognito.UserPoolDomainTypes.RoutingType Routing { get; set; }

        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html#cfn-cognito-userpooldomain-domain
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Domain { get; set; }
        /// <summary>
        /// ManagedLoginVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooldomain.html#cfn-cognito-userpooldomain-managedloginversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ManagedLoginVersion { get; set; }
    }

    namespace UserPoolDomainTypes
    {
        public class CustomDomainConfigType : Humidifier.Base.BaseSubResource, IHaveCertificateArn, IHaveSecurityPolicy
        {
            /// <summary>
            /// SecurityPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-customdomainconfigtype.html#cfn-cognito-userpooldomain-customdomainconfigtype-securitypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecurityPolicy { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-customdomainconfigtype.html#cfn-cognito-userpooldomain-customdomainconfigtype-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class FailoverType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrimaryRoute53HealthCheckId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-failovertype.html#cfn-cognito-userpooldomain-failovertype-primaryroute53healthcheckid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryRoute53HealthCheckId { get; set; }
            /// <summary>
            /// SecondaryRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-failovertype.html#cfn-cognito-userpooldomain-failovertype-secondaryregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecondaryRegion { get; set; }
        }

        public class RoutingType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Failover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-routingtype.html#cfn-cognito-userpooldomain-routingtype-failover
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FailoverType
            /// </summary>
            public Humidifier.Cognito.UserPoolDomainTypes.FailoverType Failover { get; set; }
        }
    }
}