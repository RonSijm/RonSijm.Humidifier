namespace Humidifier.PCAConnectorAD
{
    using System.Collections.Generic;
    using TemplateGroupAccessControlEntryTypes;

    public class TemplateGroupAccessControlEntry : Humidifier.Base.BaseResource
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
        public Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights AccessRights { get; set; }
        /// <summary>
        /// TemplateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-templategroupaccesscontrolentry.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-templatearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TemplateArn { get; set; }

        /// <summary>
        /// GroupDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-templategroupaccesscontrolentry.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-groupdisplayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GroupDisplayName { get; set; }
        /// <summary>
        /// GroupSecurityIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-templategroupaccesscontrolentry.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-groupsecurityidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GroupSecurityIdentifier { get; set; }
    }

    namespace TemplateGroupAccessControlEntryTypes
    {
        public class AccessRights : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Enroll
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-templategroupaccesscontrolentry-accessrights.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-accessrights-enroll
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Enroll { get; set; }
            /// <summary>
            /// AutoEnroll
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-templategroupaccesscontrolentry-accessrights.html#cfn-pcaconnectorad-templategroupaccesscontrolentry-accessrights-autoenroll
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AutoEnroll { get; set; }
        }
    }
}