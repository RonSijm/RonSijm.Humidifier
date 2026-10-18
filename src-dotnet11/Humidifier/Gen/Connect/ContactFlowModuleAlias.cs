namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class ContactFlowModuleAlias : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveContactFlowModuleId, IHaveContactFlowModuleVersion_Integer, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ContactFlowModuleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowmodulealias.html#cfn-connect-contactflowmodulealias-contactflowmoduleid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ContactFlowModuleId { get; set; }

        /// <summary>
        /// ContactFlowModuleVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-contactflowmodulealias.html#cfn-connect-contactflowmodulealias-contactflowmoduleversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? ContactFlowModuleVersion { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}