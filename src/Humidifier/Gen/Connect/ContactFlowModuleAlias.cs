namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class ContactFlowModuleAlias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
    {
        public class Attributes
        {
            public static string ContactFlowModuleAliasARN =  "ContactFlowModuleAliasARN" ;
            public static string AliasId =  "AliasId" ;
        }

        public override string AWSTypeName { get => AWS.Connect.ContactFlowModuleAlias; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowmodulealias.html#cfn-connect-contactflowmodulealias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ContactFlowModuleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowmodulealias.html#cfn-connect-contactflowmodulealias-contactflowmoduleid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ContactFlowModuleId { get; set; }

        /// <summary>
        /// ContactFlowModuleVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowmodulealias.html#cfn-connect-contactflowmodulealias-contactflowmoduleversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic ContactFlowModuleVersion { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}