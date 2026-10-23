namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;

    public class ActionTarget : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveId, IHaveName
    {
        public class Attributes
        {
            public static string ActionTargetArn =  "ActionTargetArn" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.ActionTarget; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-actiontarget.html#cfn-securityhub-actiontarget-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-actiontarget.html#cfn-securityhub-actiontarget-id
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Id { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}