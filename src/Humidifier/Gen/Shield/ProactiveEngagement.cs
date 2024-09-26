namespace Humidifier.Shield
{
    using System.Collections.Generic;
    using ProactiveEngagementTypes;

    public class ProactiveEngagement : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.Shield.ProactiveEngagement; }

        /// <summary>
        /// ProactiveEngagementStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-proactiveengagement.html#cfn-shield-proactiveengagement-proactiveengagementstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProactiveEngagementStatus { get; set; }

        /// <summary>
        /// EmergencyContactList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-proactiveengagement.html#cfn-shield-proactiveengagement-emergencycontactlist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EmergencyContact
        /// </summary>
        [Required]
        public List<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> EmergencyContactList { get; set; }
    }

    namespace ProactiveEngagementTypes
    {
        public class EmergencyContact : Humidifier.Base.BaseSubResource, IHaveEmailAddress, IHavePhoneNumber
        {
            /// <summary>
            /// ContactNotes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-proactiveengagement-emergencycontact.html#cfn-shield-proactiveengagement-emergencycontact-contactnotes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactNotes { get; set; }
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-proactiveengagement-emergencycontact.html#cfn-shield-proactiveengagement-emergencycontact-phonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PhoneNumber { get; set; }
            /// <summary>
            /// EmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-proactiveengagement-emergencycontact.html#cfn-shield-proactiveengagement-emergencycontact-emailaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailAddress { get; set; }
        }
    }
}