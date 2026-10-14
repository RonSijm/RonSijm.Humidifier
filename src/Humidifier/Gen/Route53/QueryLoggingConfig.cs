namespace Humidifier.Route53
{
    using global::System.Collections.Generic;

    public class QueryLoggingConfig : Humidifier.Base.BaseResource, IHaveHostedZoneId, IHaveCloudWatchLogsLogGroupArn
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Route53.QueryLoggingConfig; }

        /// <summary>
        /// CloudWatchLogsLogGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-queryloggingconfig.html#cfn-route53-queryloggingconfig-cloudwatchlogsloggrouparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CloudWatchLogsLogGroupArn { get; set; }

        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-queryloggingconfig.html#cfn-route53-queryloggingconfig-hostedzoneid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HostedZoneId { get; set; }
    }
}