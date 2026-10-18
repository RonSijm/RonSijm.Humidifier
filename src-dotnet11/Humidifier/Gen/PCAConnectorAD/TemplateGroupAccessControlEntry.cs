namespace Humidifier.PCAConnectorAD
{
    using global::System.Collections.Generic;
    using TemplateGroupAccessControlEntryTypes;

    public class TemplateGroupAccessControlEntry : Humidifier.Base.BaseResource, IHavePCAConnectorADTemplateGroupAccessControlEntryTypesAccessRightsAccessRights, IHaveTemplateArn, IHaveGroupDisplayName, IHaveGroupSecurityIdentifier
    {
        public override string AWSTypeName { get => AWS.PCAConnectorAD.TemplateGroupAccessControlEntry; }

        /// <summary>
        /// AccessRights
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-templategroupaccesscontrolentry.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-accessrights
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AccessRights
        /// </summary>
        [Required]
        public Union<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights, BaseFunction>? AccessRights { get; set; }

        /// <summary>
        /// TemplateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-templategroupaccesscontrolentry.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-templatearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TemplateArn { get; set; }

        /// <summary>
        /// GroupDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-templategroupaccesscontrolentry.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-groupdisplayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GroupDisplayName { get; set; }

        /// <summary>
        /// GroupSecurityIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-templategroupaccesscontrolentry.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-groupsecurityidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GroupSecurityIdentifier { get; set; }
    }

    namespace TemplateGroupAccessControlEntryTypes
    {
        public class AccessRights : Humidifier.Base.BaseSubResource, IHaveEnroll, IHaveAutoEnroll
        {
            /// <summary>
            /// Enroll
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-templategroupaccesscontrolentry-accessrights.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-accessrights-enroll
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Enroll { get; set; }
            /// <summary>
            /// AutoEnroll
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-templategroupaccesscontrolentry-accessrights.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-accessrights-autoenroll
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoEnroll { get; set; }
        }
    }
}