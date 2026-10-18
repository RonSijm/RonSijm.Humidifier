namespace Humidifier.WellArchitected
{
    using global::System.Collections.Generic;
    using ProfileTypes;

    public class Profile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfWellArchitectedProfileTypesProfileQuestionUpdateProfileQuestions, IHaveProfileDescription, IHaveProfileName, IHaveDescription
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
        public Union<IReadOnlyList<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate>, IReadOnlyList<Union<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate, BaseFunction>>, BaseFunction>? ProfileQuestions { get; set; }

        /// <summary>
        /// ProfileDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-profile.html#cfn-wellarchitected-profile-profiledescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProfileDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ProfileDescription; set => ProfileDescription = value; }
        public Union<string, BaseFunction>? ProfileName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-profile.html#cfn-wellarchitected-profile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ProfileTypes
    {
        public class ProfileQuestionUpdate : Humidifier.Base.BaseSubResource, IHaveQuestionId, IHaveStringListOfSelectedChoiceIds
        {
            /// <summary>
            /// QuestionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-profile-profilequestionupdate.html#cfn-wellarchitected-profile-profilequestionupdate-questionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QuestionId { get; set; }
            /// <summary>
            /// SelectedChoiceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-profile-profilequestionupdate.html#cfn-wellarchitected-profile-profilequestionupdate-selectedchoiceids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SelectedChoiceIds { get; set; }
        }
    }
}