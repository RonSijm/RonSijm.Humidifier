namespace Humidifier.SecurityAgent
{
    using global::System.Collections.Generic;
    using TargetDomainTypes;

    public class TargetDomain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVerificationMethod, IHaveTargetDomainName
    {
        public class Attributes
        {
            public static string VerificationStatus =  "VerificationStatus" ;
            public static string TargetDomainId =  "TargetDomainId" ;
            public static string VerificationDetails =  "VerificationDetails" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string VerificationStatusReason =  "VerificationStatusReason" ;
            public static string VerifiedAt =  "VerifiedAt" ;
        }

        public override string AWSTypeName { get => AWS.SecurityAgent.TargetDomain; }

        /// <summary>
        /// VerificationMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-targetdomain.html#cfn-securityagent-targetdomain-verificationmethod
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VerificationMethod { get; set; }
        public Union<string, BaseFunction>? TargetDomainName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-targetdomain.html#cfn-securityagent-targetdomain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TargetDomainTypes
    {
        public class DnsVerification : Humidifier.Base.BaseSubResource, IHaveToken, IHaveDnsRecordType, IHaveDnsRecordName
        {
            /// <summary>
            /// Token
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-targetdomain-dnsverification.html#cfn-securityagent-targetdomain-dnsverification-token
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Token { get; set; }
            /// <summary>
            /// DnsRecordType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-targetdomain-dnsverification.html#cfn-securityagent-targetdomain-dnsverification-dnsrecordtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsRecordType { get; set; }
            /// <summary>
            /// DnsRecordName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-targetdomain-dnsverification.html#cfn-securityagent-targetdomain-dnsverification-dnsrecordname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsRecordName { get; set; }
        }

        public class HttpVerification : Humidifier.Base.BaseSubResource, IHaveRoutePath, IHaveToken
        {
            /// <summary>
            /// RoutePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-targetdomain-httpverification.html#cfn-securityagent-targetdomain-httpverification-routepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoutePath { get; set; }
            /// <summary>
            /// Token
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-targetdomain-httpverification.html#cfn-securityagent-targetdomain-httpverification-token
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Token { get; set; }
        }

        public class VerificationDetails : Humidifier.Base.BaseSubResource, IHaveSecurityAgentTargetDomainTypesHttpVerificationHttpRoute, IHaveSecurityAgentTargetDomainTypesDnsVerificationDnsTxt, IHaveMethod
        {
            /// <summary>
            /// HttpRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-targetdomain-verificationdetails.html#cfn-securityagent-targetdomain-verificationdetails-httproute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpVerification
            /// </summary>
            public Union<Humidifier.SecurityAgent.TargetDomainTypes.HttpVerification, BaseFunction>? HttpRoute { get; set; }
            /// <summary>
            /// DnsTxt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-targetdomain-verificationdetails.html#cfn-securityagent-targetdomain-verificationdetails-dnstxt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DnsVerification
            /// </summary>
            public Union<Humidifier.SecurityAgent.TargetDomainTypes.DnsVerification, BaseFunction>? DnsTxt { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-targetdomain-verificationdetails.html#cfn-securityagent-targetdomain-verificationdetails-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Method { get; set; }
        }
    }
}