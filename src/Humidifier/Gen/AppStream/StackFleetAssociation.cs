namespace Humidifier.AppStream
{
    using System.Collections.Generic;

    public class StackFleetAssociation : Humidifier.Base.BaseResource, IHaveStackName
    {
        public override string AWSTypeName { get => AWS.AppStream.StackFleetAssociation; }

        /// <summary>
        /// FleetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackfleetassociation.html#cfn-appstream-stackfleetassociation-fleetname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FleetName { get; set; }

        /// <summary>
        /// StackName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackfleetassociation.html#cfn-appstream-stackfleetassociation-stackname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StackName { get; set; }
    }
}