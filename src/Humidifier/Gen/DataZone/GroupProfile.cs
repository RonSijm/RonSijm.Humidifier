namespace Humidifier.DataZone
{
    using System.Collections.Generic;

    public class GroupProfile : Humidifier.Base.BaseResource, IHaveStatus, IHaveDomainIdentifier, IHaveGroupIdentifier
    {
        public class Attributes
        {
            public static string GroupName =  "GroupName" ;
            public static string DomainId =  "DomainId" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.GroupProfile; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-groupprofile.html#cfn-datazone-groupprofile-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-groupprofile.html#cfn-datazone-groupprofile-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainIdentifier { get; set; }

        /// <summary>
        /// GroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-groupprofile.html#cfn-datazone-groupprofile-groupidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GroupIdentifier { get; set; }
    }
}