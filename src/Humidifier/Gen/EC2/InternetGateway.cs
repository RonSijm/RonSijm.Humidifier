namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class InternetGateway : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string InternetGatewayId =  "InternetGatewayId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.InternetGateway; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-internetgateway.html#cfn-ec2-internetgateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}