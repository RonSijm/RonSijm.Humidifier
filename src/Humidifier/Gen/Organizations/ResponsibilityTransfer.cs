namespace Humidifier.Organizations
{
    using global::System.Collections.Generic;
    using ResponsibilityTransferTypes;

    public class ResponsibilityTransfer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Target =  "Target" ;
            public static string EndTimestamp =  "EndTimestamp" ;
            public static string Id =  "Id" ;
            public static string OrganizationId =  "OrganizationId" ;
            public static string Arn =  "Arn" ;
            public static string Source =  "Source" ;
        }

        public override string AWSTypeName { get => AWS.Organizations.ResponsibilityTransfer; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-responsibilitytransfer.html#cfn-organizations-responsibilitytransfer-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// StartTimestamp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-responsibilitytransfer.html#cfn-organizations-responsibilitytransfer-starttimestamp
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StartTimestamp { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-responsibilitytransfer.html#cfn-organizations-responsibilitytransfer-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ResponsibilityTransferTypes
    {
        public class TransferParticipant : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ManagementAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-organizations-responsibilitytransfer-transferparticipant.html#cfn-organizations-responsibilitytransfer-transferparticipant-managementaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManagementAccountId { get; set; }
            /// <summary>
            /// ManagementAccountEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-organizations-responsibilitytransfer-transferparticipant.html#cfn-organizations-responsibilitytransfer-transferparticipant-managementaccountemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManagementAccountEmail { get; set; }
        }
    }
}