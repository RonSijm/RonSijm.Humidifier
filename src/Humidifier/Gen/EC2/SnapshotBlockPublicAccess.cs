namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class SnapshotBlockPublicAccess : Humidifier.Base.BaseResource, IHaveState
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SnapshotBlockPublicAccess; }

        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-snapshotblockpublicaccess.html#cfn-ec2-snapshotblockpublicaccess-state
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic State { get; set; }
    }
}