namespace Humidifier.RDS
{
    using global::System.Collections.Generic;

    public class DBSubnetGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSubnetIds, IHaveDBSubnetGroupName, IHaveDBSubnetGroupDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string DBSubnetGroupArn =  "DBSubnetGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.RDS.DBSubnetGroup; }
        public dynamic DBSubnetGroupName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DBSubnetGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnetgroup.html#cfn-rds-dbsubnetgroup-dbsubnetgroupdescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DBSubnetGroupDescription { get; set; }

        [Ignore]
        public dynamic Description { get => DBSubnetGroupDescription; set => DBSubnetGroupDescription = value; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnetgroup.html#cfn-rds-dbsubnetgroup-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic SubnetIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsubnetgroup.html#cfn-rds-dbsubnetgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}