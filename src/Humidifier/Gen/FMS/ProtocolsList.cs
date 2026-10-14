namespace Humidifier.FMS
{
    using global::System.Collections.Generic;

    public class ProtocolsList : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string ListId =  "ListId" ;
            public static string LastUpdateTime =  "LastUpdateTime" ;
            public static string CreateTime =  "CreateTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.FMS.ProtocolsList; }

        /// <summary>
        /// ListName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-protocolslist.html#cfn-fms-protocolslist-listname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ListName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-protocolslist.html#cfn-fms-protocolslist-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// ProtocolsList_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-protocolslist.html#cfn-fms-protocolslist-protocolslist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic ProtocolsList_ { get; set; }
    }
}