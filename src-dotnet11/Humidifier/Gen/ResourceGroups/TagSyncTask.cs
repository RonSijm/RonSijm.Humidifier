namespace Humidifier.ResourceGroups
{
    using global::System.Collections.Generic;

    public class TagSyncTask : Humidifier.Base.BaseResource, IHaveGroup, IHaveTagKey, IHaveTagValue, IHaveRoleArn
    {
        public class Attributes
        {
            public static string GroupName =  "GroupName" ;
            public static string Status =  "Status" ;
            public static string GroupArn =  "GroupArn" ;
            public static string TaskArn =  "TaskArn" ;
        }

        public override string AWSTypeName { get => AWS.ResourceGroups.TagSyncTask; }

        /// <summary>
        /// Group
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-tagsynctask.html#cfn-resourcegroups-tagsynctask-group
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Group { get; set; }

        /// <summary>
        /// TagKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-tagsynctask.html#cfn-resourcegroups-tagsynctask-tagkey
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TagKey { get; set; }

        /// <summary>
        /// TagValue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-tagsynctask.html#cfn-resourcegroups-tagsynctask-tagvalue
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TagValue { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-tagsynctask.html#cfn-resourcegroups-tagsynctask-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
    }
}