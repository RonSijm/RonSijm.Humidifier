namespace Humidifier.Redshift
{
    using System.Collections.Generic;

    public class EndpointAuthorization : Humidifier.Base.BaseResource, IHaveClusterIdentifier
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Grantee =  "Grantee" ;
            public static string Grantor =  "Grantor" ;
            public static string EndpointCount =  "EndpointCount" ;
            public static string AuthorizeTime =  "AuthorizeTime" ;
            public static string AllowedVPCs =  "AllowedVPCs" ;
            public static string AllowedAllVPCs =  "AllowedAllVPCs" ;
            public static string ClusterStatus =  "ClusterStatus" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.EndpointAuthorization; }

        /// <summary>
        /// Account
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-endpointauthorization.html#cfn-redshift-endpointauthorization-account
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Account { get; set; }
        /// <summary>
        /// Force
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-endpointauthorization.html#cfn-redshift-endpointauthorization-force
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Force { get; set; }
        /// <summary>
        /// VpcIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-endpointauthorization.html#cfn-redshift-endpointauthorization-vpcids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic VpcIds { get; set; }

        /// <summary>
        /// ClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-endpointauthorization.html#cfn-redshift-endpointauthorization-clusteridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterIdentifier { get; set; }
    }
}