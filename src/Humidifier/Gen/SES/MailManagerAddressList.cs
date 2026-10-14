namespace Humidifier.SES
{
    using global::System.Collections.Generic;

    public class MailManagerAddressList : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string AddressListArn =  "AddressListArn" ;
            public static string AddressListId =  "AddressListId" ;
        }

        public override string AWSTypeName { get => AWS.SES.MailManagerAddressList; }
        /// <summary>
        /// AddressListName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageraddresslist.html#cfn-ses-mailmanageraddresslist-addresslistname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AddressListName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageraddresslist.html#cfn-ses-mailmanageraddresslist-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}