namespace Humidifier.DMS
{
    using global::System.Collections.Generic;

    public class InstanceProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSubnetGroupIdentifier, IHaveDescription, IHaveInstanceProfileName, IHaveKmsKeyArn, IHaveNetworkType, IHaveAvailabilityZone, IHavePubliclyAccessible_Boolean, IHaveStringListOfVpcSecurityGroups, IHaveInstanceProfileIdentifier
    {
        public class Attributes
        {
            public static string InstanceProfileCreationTime =  "InstanceProfileCreationTime" ;
            public static string InstanceProfileArn =  "InstanceProfileArn" ;
        }

        public override string AWSTypeName { get => AWS.DMS.InstanceProfile; }
        /// <summary>
        /// SubnetGroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-instanceprofile.html#cfn-dms-instanceprofile-subnetgroupidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubnetGroupIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-instanceprofile.html#cfn-dms-instanceprofile-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        public Union<string, BaseFunction>? InstanceProfileName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-instanceprofile.html#cfn-dms-instanceprofile-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-instanceprofile.html#cfn-dms-instanceprofile-networktype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-instanceprofile.html#cfn-dms-instanceprofile-availabilityzone
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// PubliclyAccessible
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-instanceprofile.html#cfn-dms-instanceprofile-publiclyaccessible
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PubliclyAccessible { get; set; }
        /// <summary>
        /// VpcSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-instanceprofile.html#cfn-dms-instanceprofile-vpcsecuritygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSecurityGroups { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-instanceprofile.html#cfn-dms-instanceprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// InstanceProfileIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-instanceprofile.html#cfn-dms-instanceprofile-instanceprofileidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceProfileIdentifier { get; set; }
    }
}