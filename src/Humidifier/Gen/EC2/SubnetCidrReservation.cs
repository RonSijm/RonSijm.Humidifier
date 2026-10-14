namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class SubnetCidrReservation : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveSubnetId, IHaveCidr
    {
        public class Attributes
        {
            public static string OwnerId =  "OwnerId" ;
            public static string SubnetCidrReservationId =  "SubnetCidrReservationId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SubnetCidrReservation; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrreservation.html#cfn-ec2-subnetcidrreservation-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Cidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrreservation.html#cfn-ec2-subnetcidrreservation-cidr
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Cidr { get; set; }

        /// <summary>
        /// ReservationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrreservation.html#cfn-ec2-subnetcidrreservation-reservationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ReservationType { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrreservation.html#cfn-ec2-subnetcidrreservation-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SubnetId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrreservation.html#cfn-ec2-subnetcidrreservation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}