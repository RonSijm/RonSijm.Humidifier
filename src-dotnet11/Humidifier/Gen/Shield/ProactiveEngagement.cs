namespace Humidifier.Shield
{
    using global::System.Collections.Generic;
    using ProactiveEngagementTypes;

    public class ProactiveEngagement : Humidifier.Base.BaseResource, IHaveProactiveEngagementStatus, IHaveListOfShieldProactiveEngagementTypesEmergencyContactEmergencyContactList
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
        public Union<string, BaseFunction>? ProactiveEngagementStatus { get; set; }

        /// <summary>
        /// EmergencyContactList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-proactiveengagement.html#cfn-shield-proactiveengagement-emergencycontactlist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EmergencyContact
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact>, IReadOnlyList<Union<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact, BaseFunction>>, BaseFunction>? EmergencyContactList { get; set; }
    }

    namespace ProactiveEngagementTypes
    {
        public class EmergencyContact : Humidifier.Base.BaseSubResource, IHaveContactNotes, IHavePhoneNumber, IHaveEmailAddress
        {
            /// <summary>
            /// ContactNotes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-proactiveengagement-emergencycontact.html#cfn-shield-proactiveengagement-emergencycontact-contactnotes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactNotes { get; set; }
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-proactiveengagement-emergencycontact.html#cfn-shield-proactiveengagement-emergencycontact-phonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PhoneNumber { get; set; }
            /// <summary>
            /// EmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-proactiveengagement-emergencycontact.html#cfn-shield-proactiveengagement-emergencycontact-emailaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailAddress { get; set; }
        }
    }
}