namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class UserHierarchyGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveInstanceArn, IHaveParentGroupArn, IHaveName
    {
        public class Attributes
        {
            public static string UserHierarchyGroupArn =  "UserHierarchyGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.UserHierarchyGroup; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-userhierarchygroup.html#cfn-connect-userhierarchygroup-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// ParentGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-userhierarchygroup.html#cfn-connect-userhierarchygroup-parentgrouparn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ParentGroupArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-userhierarchygroup.html#cfn-connect-userhierarchygroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}