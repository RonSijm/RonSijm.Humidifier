namespace Humidifier.Route53Resolver
{
    using System.Collections.Generic;

    public class ResolverQueryLoggingConfigAssociation : Humidifier.Base.BaseResource, IHaveResourceId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Error =  "Error" ;
            public static string Id =  "Id" ;
            public static string ErrorMessage =  "ErrorMessage" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.ResolverQueryLoggingConfigAssociation; }
        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverqueryloggingconfigassociation.html#cfn-route53resolver-resolverqueryloggingconfigassociation-resourceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceId { get; set; }
        /// <summary>
        /// ResolverQueryLogConfigId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverqueryloggingconfigassociation.html#cfn-route53resolver-resolverqueryloggingconfigassociation-resolverquerylogconfigid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResolverQueryLogConfigId { get; set; }
    }
}