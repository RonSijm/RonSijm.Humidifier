namespace Humidifier.ResilienceHubV2
{
    using global::System.Collections.Generic;

    public class UserJourney : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHavePolicyArn, IHaveSystemIdentifier, IHaveName
    {
        public class Attributes
        {
            public static string UserJourneyId =  "UserJourneyId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.ResilienceHubV2.UserJourney; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-userjourney.html#cfn-resiliencehubv2-userjourney-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PolicyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-userjourney.html#cfn-resiliencehubv2-userjourney-policyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PolicyArn { get; set; }

        /// <summary>
        /// SystemIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-userjourney.html#cfn-resiliencehubv2-userjourney-systemidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SystemIdentifier { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}