namespace Humidifier.Cognito
{
    using System.Collections.Generic;
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
        public class CustomDomainConfigType : Humidifier.Base.BaseSubResource, IHaveCertificateArn
        {
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-customdomainconfigtype.html#cfn-cognito-userpooldomain-customdomainconfigtype-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }
    }
}