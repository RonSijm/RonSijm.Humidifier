namespace Humidifier.WellArchitected
{
    using global::System.Collections.Generic;
    using ProfileTypes;

    public class Profile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProfileName, IHaveDescription
    {
        public class Attributes
        {
            public static string Owner =  "Owner" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ProfileArn =  "ProfileArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string ProfileVersion =  "ProfileVersion" ;
        }

        public override string AWSTypeName { get => AWS.WellArchitected.Profile; }

        /// <summary>
        /// ProfileQuestions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-profile.html#cfn-wellarchitected-profile-profilequestions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ProfileQuestionUpdate
        /// </summary>
        [Required]
        public List<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> ProfileQuestions { get; set; }

        /// <summary>
        /// ProfileDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-profile.html#cfn-wellarchitected-profile-profiledescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProfileDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ProfileDescription; set => ProfileDescription = value; }
        public dynamic ProfileName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-profile.html#cfn-wellarchitected-profile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ProfileTypes
    {
        public class ProfileQuestionUpdate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QuestionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-profile-profilequestionupdate.html#cfn-wellarchitected-profile-profilequestionupdate-questionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QuestionId { get; set; }
            /// <summary>
            /// SelectedChoiceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-profile-profilequestionupdate.html#cfn-wellarchitected-profile-profilequestionupdate-selectedchoiceids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SelectedChoiceIds { get; set; }
        }
    }
}