namespace Humidifier.Greengrass
{
    using System.Collections.Generic;
    using CoreDefinitionVersionTypes;

    public class CoreDefinitionVersion : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName { get => AWS.Greengrass.CoreDefinitionVersion; }

        /// <summary>
        /// Cores
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinitionversion.html#cfn-greengrass-coredefinitionversion-cores
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Core
        /// </summary>
        [Required]
        public List<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> Cores { get; set; }

        /// <summary>
        /// CoreDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinitionversion.html#cfn-greengrass-coredefinitionversion-coredefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CoreDefinitionId { get; set; }
    }

    namespace CoreDefinitionVersionTypes
    {
        public class Core : Humidifier.Base.BaseSubResource, IHaveId, IHaveCertificateArn, IHaveThingArn, IHaveSyncShadow
        {
            /// <summary>
            /// SyncShadow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinitionversion-core.html#cfn-greengrass-coredefinitionversion-core-syncshadow
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SyncShadow { get; set; }
            /// <summary>
            /// ThingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinitionversion-core.html#cfn-greengrass-coredefinitionversion-core-thingarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThingArn { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinitionversion-core.html#cfn-greengrass-coredefinitionversion-core-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinitionversion-core.html#cfn-greengrass-coredefinitionversion-core-certificatearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }
    }
}