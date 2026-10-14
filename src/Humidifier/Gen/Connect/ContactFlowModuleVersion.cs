namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class ContactFlowModuleVersion : Humidifier.Base.BaseResource, IHaveDescription
    {
        public class Attributes
        {
            public static string Version =  "Version" ;
            public static string ContactFlowModuleVersionARN =  "ContactFlowModuleVersionARN" ;
            public static string FlowModuleContentSha256 =  "FlowModuleContentSha256" ;
        }

        public override string AWSTypeName { get => AWS.Connect.ContactFlowModuleVersion; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowmoduleversion.html#cfn-connect-contactflowmoduleversion-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ContactFlowModuleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowmoduleversion.html#cfn-connect-contactflowmoduleversion-contactflowmoduleid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ContactFlowModuleId { get; set; }
    }
}