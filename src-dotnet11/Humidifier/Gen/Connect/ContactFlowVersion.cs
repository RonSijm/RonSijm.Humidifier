namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class ContactFlowVersion : Humidifier.Base.BaseResource, IHaveDescription, IHaveContactFlowId
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ContactFlowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowversion.html#cfn-connect-contactflowversion-contactflowid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ContactFlowId { get; set; }
    }
}