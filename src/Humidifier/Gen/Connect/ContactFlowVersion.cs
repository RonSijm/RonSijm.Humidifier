namespace Humidifier.Connect
{
    using System.Collections.Generic;

    public class ContactFlowVersion : Humidifier.Base.BaseResource, IHaveDescription
    {
        public class Attributes
        {
            public static string FlowContentSha256 =  "FlowContentSha256" ;
            public static string ContactFlowVersionARN =  "ContactFlowVersionARN" ;
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName { get => AWS.Connect.ContactFlowVersion; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowversion.html#cfn-connect-contactflowversion-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ContactFlowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowversion.html#cfn-connect-contactflowversion-contactflowid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ContactFlowId { get; set; }
    }
}