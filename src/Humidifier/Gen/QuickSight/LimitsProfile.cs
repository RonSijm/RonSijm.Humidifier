namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using LimitsProfileTypes;

    public class LimitsProfile : Humidifier.Base.BaseResource, IHaveDescription, IHaveAccountId, IHaveProfileName
    {
        public class Attributes
        {
            public static string ProfileId =  "ProfileId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.LimitsProfile; }

        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-limitsprofile.html#cfn-quicksight-limitsprofile-accountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AccountId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-limitsprofile.html#cfn-quicksight-limitsprofile-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ResourceLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-limitsprofile.html#cfn-quicksight-limitsprofile-resourcelimits
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ProfileLimitValue
        /// </summary>
        [Required]
        public Dictionary<string, Humidifier.QuickSight.LimitsProfileTypes.ProfileLimitValue> ResourceLimits { get; set; }

        /// <summary>
        /// ProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-limitsprofile.html#cfn-quicksight-limitsprofile-profilename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProfileName { get; set; }
    }

    namespace LimitsProfileTypes
    {
        public class ProfileLimitValue : Humidifier.Base.BaseSubResource, IHaveUnit, IHaveMaxValue
        {
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-limitsprofile-profilelimitvalue.html#cfn-quicksight-limitsprofile-profilelimitvalue-maxvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxValue { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-limitsprofile-profilelimitvalue.html#cfn-quicksight-limitsprofile-profilelimitvalue-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }
    }
}