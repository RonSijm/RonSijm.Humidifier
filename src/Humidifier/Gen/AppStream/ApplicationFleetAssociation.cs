namespace Humidifier.AppStream
{
    using System.Collections.Generic;

    public class ApplicationFleetAssociation : Humidifier.Base.BaseResource, IHaveApplicationArn, IHaveFleetName
    {
        public override string AWSTypeName { get => AWS.AppStream.ApplicationFleetAssociation; }

        /// <summary>
        /// FleetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-applicationfleetassociation.html#cfn-appstream-applicationfleetassociation-fleetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FleetName { get; set; }

        /// <summary>
        /// ApplicationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-applicationfleetassociation.html#cfn-appstream-applicationfleetassociation-applicationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationArn { get; set; }
    }
}