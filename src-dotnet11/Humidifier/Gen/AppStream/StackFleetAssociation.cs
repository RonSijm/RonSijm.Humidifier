namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;

    public class StackFleetAssociation : Humidifier.Base.BaseResource, IHaveFleetName, IHaveStackName
    {
        public override string AWSTypeName { get => AWS.AppStream.StackFleetAssociation; }

        /// <summary>
        /// FleetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackfleetassociation.html#cfn-appstream-stackfleetassociation-fleetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FleetName { get; set; }

        /// <summary>
        /// StackName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stackfleetassociation.html#cfn-appstream-stackfleetassociation-stackname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StackName { get; set; }
    }
}