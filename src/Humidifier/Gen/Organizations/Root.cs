namespace Humidifier.Organizations
{
    using global::System.Collections.Generic;
    using RootTypes;

    public class Root : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string PolicyTypes =  "PolicyTypes" ;
            public static string Id =  "Id" ;
            public static string OrganizationId =  "OrganizationId" ;
            public static string Arn =  "Arn" ;
            public static string Tags =  "Tags" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Organizations.Root; }
    }

    namespace RootTypes
    {
        public class PolicyTypeSummary : Humidifier.Base.BaseSubResource, IHaveType, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-organizations-root-policytypesummary.html#cfn-organizations-root-policytypesummary-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-organizations-root-policytypesummary.html#cfn-organizations-root-policytypesummary-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }
    }
}