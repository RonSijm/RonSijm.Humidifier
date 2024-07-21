namespace Humidifier.CleanRooms
{
    using System.Collections.Generic;
    using PrivacyBudgetTemplateTypes;

    public class PrivacyBudgetTemplate : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string MembershipArn =  "MembershipArn" ;
            public static string PrivacyBudgetTemplateIdentifier =  "PrivacyBudgetTemplateIdentifier" ;
            public static string Arn =  "Arn" ;
            public static string CollaborationArn =  "CollaborationArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CleanRooms::PrivacyBudgetTemplate";
            }
        }

        /// <summary>
        /// PrivacyBudgetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-privacybudgettemplate.html#cfn-cleanrooms-privacybudgettemplate-privacybudgettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PrivacyBudgetType { get; set; }
        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-privacybudgettemplate.html#cfn-cleanrooms-privacybudgettemplate-membershipidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MembershipIdentifier { get; set; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-privacybudgettemplate.html#cfn-cleanrooms-privacybudgettemplate-parameters
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Parameters
        /// </summary>
        public Parameters Parameters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-privacybudgettemplate.html#cfn-cleanrooms-privacybudgettemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// AutoRefresh
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-privacybudgettemplate.html#cfn-cleanrooms-privacybudgettemplate-autorefresh
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AutoRefresh { get; set; }
    }

    namespace PrivacyBudgetTemplateTypes
    {
        public class Parameters
        {
            /// <summary>
            /// Epsilon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-privacybudgettemplate-parameters.html#cfn-cleanrooms-privacybudgettemplate-parameters-epsilon
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Epsilon { get; set; }
            /// <summary>
            /// UsersNoisePerQuery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-privacybudgettemplate-parameters.html#cfn-cleanrooms-privacybudgettemplate-parameters-usersnoiseperquery
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UsersNoisePerQuery { get; set; }
        }
    }
}