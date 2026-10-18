namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using LimitsProfileTypes;

    public class LimitsProfile : Humidifier.Base.BaseResource, IHaveAccountId, IHaveDescription, IHaveMapOfQuickSightLimitsProfileTypesProfileLimitValueResourceLimits, IHaveProfileName
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
        public Union<string, BaseFunction>? AccountId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-limitsprofile.html#cfn-quicksight-limitsprofile-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ResourceLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-limitsprofile.html#cfn-quicksight-limitsprofile-resourcelimits
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ProfileLimitValue
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, Humidifier.QuickSight.LimitsProfileTypes.ProfileLimitValue>, IReadOnlyDictionary<string, Union<Humidifier.QuickSight.LimitsProfileTypes.ProfileLimitValue, BaseFunction>>, BaseFunction>? ResourceLimits { get; set; }

        /// <summary>
        /// ProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-limitsprofile.html#cfn-quicksight-limitsprofile-profilename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProfileName { get; set; }
    }

    namespace LimitsProfileTypes
    {
        public class ProfileLimitValue : Humidifier.Base.BaseSubResource, IHaveMaxValue_Double, IHaveUnit
        {
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-limitsprofile-profilelimitvalue.html#cfn-quicksight-limitsprofile-profilelimitvalue-maxvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxValue { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-limitsprofile-profilelimitvalue.html#cfn-quicksight-limitsprofile-profilelimitvalue-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }
    }
}