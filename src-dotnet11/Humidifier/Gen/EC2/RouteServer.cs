namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class RouteServer : Humidifier.Base.BaseResource, IHaveTags, IHavePersistRoutes, IHaveSnsNotificationsEnabled_Boolean, IHavePersistRoutesDuration_Long, IHaveAmazonSideAsn_Long
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.RouteServer; }
        /// <summary>
        /// PersistRoutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserver.html#cfn-ec2-routeserver-persistroutes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PersistRoutes { get; set; }
        /// <summary>
        /// SnsNotificationsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserver.html#cfn-ec2-routeserver-snsnotificationsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SnsNotificationsEnabled { get; set; }
        /// <summary>
        /// PersistRoutesDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserver.html#cfn-ec2-routeserver-persistroutesduration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Long
        /// </summary>
        public Union<long, BaseFunction>? PersistRoutesDuration { get; set; }

        /// <summary>
        /// AmazonSideAsn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserver.html#cfn-ec2-routeserver-amazonsideasn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Long
        /// </summary>
        [Required]
        public Union<long, BaseFunction>? AmazonSideAsn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserver.html#cfn-ec2-routeserver-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}