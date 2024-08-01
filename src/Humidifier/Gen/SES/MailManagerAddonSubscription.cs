namespace Humidifier.SES
{
    using System.Collections.Generic;

    public class MailManagerAddonSubscription : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string AddonSubscriptionId =  "AddonSubscriptionId" ;
            public static string AddonSubscriptionArn =  "AddonSubscriptionArn" ;
        }

        public override string AWSTypeName { get => AWS.SES.MailManagerAddonSubscription; }

        /// <summary>
        /// AddonName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageraddonsubscription.html#cfn-ses-mailmanageraddonsubscription-addonname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AddonName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageraddonsubscription.html#cfn-ses-mailmanageraddonsubscription-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}