namespace Humidifier.DAX
{
    using global::System.Collections.Generic;

    public class SubnetGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveSubnetGroupName, IHaveStringListOfSubnetIds
    {
        public override string AWSTypeName { get => AWS.DAX.SubnetGroup; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-subnetgroup.html#cfn-dax-subnetgroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        public Union<string, BaseFunction>? SubnetGroupName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-subnetgroup.html#cfn-dax-subnetgroup-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
    }
}