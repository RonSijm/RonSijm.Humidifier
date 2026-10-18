namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;

    public class GroupProfile : Humidifier.Base.BaseResource, IHaveStatus, IHaveGroupType, IHaveRolePrincipalArn, IHaveDomainIdentifier, IHaveGroupIdentifier
    {
        public class Attributes
        {
            public static string GroupName =  "GroupName" ;
            public static string DomainId =  "DomainId" ;
            public static string Id =  "Id" ;
            public static string RolePrincipalId =  "RolePrincipalId" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.GroupProfile; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-groupprofile.html#cfn-datazone-groupprofile-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// GroupType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-groupprofile.html#cfn-datazone-groupprofile-grouptype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupType { get; set; }
        /// <summary>
        /// RolePrincipalArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-groupprofile.html#cfn-datazone-groupprofile-roleprincipalarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RolePrincipalArn { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-groupprofile.html#cfn-datazone-groupprofile-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
        /// <summary>
        /// GroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-groupprofile.html#cfn-datazone-groupprofile-groupidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupIdentifier { get; set; }
    }
}