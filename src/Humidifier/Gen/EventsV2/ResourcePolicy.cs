namespace Humidifier.EventsV2
{
    using global::System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHavePolicyDocument, IHaveEventBusArn
    {
        public class Attributes
        {
            public static string RevisionId =  "RevisionId" ;
        }

        public override string AWSTypeName { get => AWS.EventsV2.ResourcePolicy; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-resourcepolicy.html#cfn-eventsv2-resourcepolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic PolicyDocument { get; set; }

        /// <summary>
        /// EventBusArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-resourcepolicy.html#cfn-eventsv2-resourcepolicy-eventbusarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EventBusArn { get; set; }
    }
}