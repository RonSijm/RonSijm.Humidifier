namespace Humidifier.SSM
{
    using global::System.Collections.Generic;

    public class Session : Humidifier.Base.BaseResource, IHaveTarget, IHaveReason
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StartDate =  "StartDate" ;
            public static string Owner =  "Owner" ;
            public static string Arn =  "Arn" ;
            public static string SessionId =  "SessionId" ;
            public static string AccessType =  "AccessType" ;
        }

        public override string AWSTypeName { get => AWS.SSM.Session; }
        /// <summary>
        /// Target
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-session.html#cfn-ssm-session-target
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Target { get; set; }
        /// <summary>
        /// Reason
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-session.html#cfn-ssm-session-reason
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Reason { get; set; }
    }
}