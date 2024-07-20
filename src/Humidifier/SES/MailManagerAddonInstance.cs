namespace Humidifier.SES
{
    using System.Collections.Generic;

    public class MailManagerAddonInstance : Humidifier.Resource
    {
        public class Attributes
        {
            public static string AddonInstanceId =  "AddonInstanceId" ;
            public static string AddonName =  "AddonName" ;
            public static string AddonInstanceArn =  "AddonInstanceArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SES::MailManagerAddonInstance";
            }
        }

        /// <summary>
        /// AddonSubscriptionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageraddoninstance.html#cfn-ses-mailmanageraddoninstance-addonsubscriptionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AddonSubscriptionId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageraddoninstance.html#cfn-ses-mailmanageraddoninstance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}