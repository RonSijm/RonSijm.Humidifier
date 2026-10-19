namespace Humidifier.Organizations
{
    using global::System.Collections.Generic;
    using ResponsibilityTransferTypes;

    public class ResponsibilityTransfer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveStartTimestamp, IHaveName
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
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// StartTimestamp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-responsibilitytransfer.html#cfn-organizations-responsibilitytransfer-starttimestamp
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StartTimestamp { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-organizations-responsibilitytransfer.html#cfn-organizations-responsibilitytransfer-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ResponsibilityTransferTypes
    {
        public class TransferParticipant : Humidifier.Base.BaseSubResource, IHaveManagementAccountId, IHaveManagementAccountEmail
        {
            /// <summary>
            /// ManagementAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-organizations-responsibilitytransfer-transferparticipant.html#cfn-organizations-responsibilitytransfer-transferparticipant-managementaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagementAccountId { get; set; }
            /// <summary>
            /// ManagementAccountEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-organizations-responsibilitytransfer-transferparticipant.html#cfn-organizations-responsibilitytransfer-transferparticipant-managementaccountemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagementAccountEmail { get; set; }
        }
    }
}