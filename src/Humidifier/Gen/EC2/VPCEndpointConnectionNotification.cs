namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class VPCEndpointConnectionNotification : Humidifier.Base.BaseResource, IHaveServiceId
    {
        public class Attributes
        {
            public static string VPCEndpointConnectionNotificationId =  "VPCEndpointConnectionNotificationId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCEndpointConnectionNotification; }

        /// <summary>
        /// ConnectionEvents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointconnectionnotification.html#cfn-ec2-vpcendpointconnectionnotification-connectionevents
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic ConnectionEvents { get; set; }
        /// <summary>
        /// VPCEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointconnectionnotification.html#cfn-ec2-vpcendpointconnectionnotification-vpcendpointid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VPCEndpointId { get; set; }

        /// <summary>
        /// ConnectionNotificationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointconnectionnotification.html#cfn-ec2-vpcendpointconnectionnotification-connectionnotificationarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectionNotificationArn { get; set; }
        /// <summary>
        /// ServiceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointconnectionnotification.html#cfn-ec2-vpcendpointconnectionnotification-serviceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceId { get; set; }
    }
}