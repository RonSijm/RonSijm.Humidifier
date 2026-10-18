namespace Humidifier.HealthAgent
{
    using global::System.Collections.Generic;

    public class Subscription : Humidifier.Base.BaseResource, IHaveDomainId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SubscriptionId =  "SubscriptionId" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.HealthAgent.Subscription; }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthagent-subscription.html#cfn-healthagent-subscription-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainId { get; set; }
    }
}