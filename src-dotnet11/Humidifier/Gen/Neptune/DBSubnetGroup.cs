namespace Humidifier.Neptune
{
    using global::System.Collections.Generic;

    public class DBSubnetGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDBSubnetGroupName, IHaveDBSubnetGroupDescription, IHaveStringListOfSubnetIds, IHaveDescription
    {
        public override string AWSTypeName { get => AWS.Neptune.DBSubnetGroup; }
        public Union<string, BaseFunction>? DBSubnetGroupName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DBSubnetGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbsubnetgroup.html#cfn-neptune-dbsubnetgroup-dbsubnetgroupdescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DBSubnetGroupDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => DBSubnetGroupDescription; set => DBSubnetGroupDescription = value; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbsubnetgroup.html#cfn-neptune-dbsubnetgroup-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbsubnetgroup.html#cfn-neptune-dbsubnetgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}