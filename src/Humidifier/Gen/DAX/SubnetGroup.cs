namespace Humidifier.DAX
{
    using System.Collections.Generic;

    public class SubnetGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveSubnetIds, IHaveSubnetGroupName
    {
        public override string AWSTypeName { get => AWS.DAX.SubnetGroup; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-subnetgroup.html#cfn-dax-subnetgroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        public dynamic SubnetGroupName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-subnetgroup.html#cfn-dax-subnetgroup-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic SubnetIds { get; set; }
    }
}