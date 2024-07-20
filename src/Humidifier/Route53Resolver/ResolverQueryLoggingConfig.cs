namespace Humidifier.Route53Resolver
{
    using System.Collections.Generic;

    public class ResolverQueryLoggingConfig : Humidifier.Resource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string OwnerId =  "OwnerId" ;
            public static string AssociationCount =  "AssociationCount" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ShareStatus =  "ShareStatus" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string CreatorRequestId =  "CreatorRequestId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Route53Resolver::ResolverQueryLoggingConfig";
            }
        }

        /// <summary>
        /// DestinationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverqueryloggingconfig.html#cfn-route53resolver-resolverqueryloggingconfig-destinationarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationArn { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverqueryloggingconfig.html#cfn-route53resolver-resolverqueryloggingconfig-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }
}