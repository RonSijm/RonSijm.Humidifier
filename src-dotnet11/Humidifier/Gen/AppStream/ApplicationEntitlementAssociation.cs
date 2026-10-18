namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;

    public class ApplicationEntitlementAssociation : Humidifier.Base.BaseResource, IHaveEntitlementName, IHaveApplicationIdentifier, IHaveStackName
    {
        public override string AWSTypeName { get => AWS.AppStream.ApplicationEntitlementAssociation; }

        /// <summary>
        /// EntitlementName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-applicationentitlementassociation.html#cfn-appstream-applicationentitlementassociation-entitlementname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EntitlementName { get; set; }

        /// <summary>
        /// ApplicationIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-applicationentitlementassociation.html#cfn-appstream-applicationentitlementassociation-applicationidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationIdentifier { get; set; }

        /// <summary>
        /// StackName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-applicationentitlementassociation.html#cfn-appstream-applicationentitlementassociation-stackname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StackName { get; set; }
    }
}