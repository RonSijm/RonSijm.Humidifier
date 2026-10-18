namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using CoreDefinitionVersionTypes;

    public class CoreDefinitionVersion : Humidifier.Base.BaseResource, IHaveListOfGreengrassCoreDefinitionVersionTypesCoreCores, IHaveCoreDefinitionId
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
        public Union<IReadOnlyList<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core>, IReadOnlyList<Union<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core, BaseFunction>>, BaseFunction>? Cores { get; set; }

        /// <summary>
        /// CoreDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinitionversion.html#cfn-greengrass-coredefinitionversion-coredefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CoreDefinitionId { get; set; }
    }

    namespace CoreDefinitionVersionTypes
    {
        public class Core : Humidifier.Base.BaseSubResource, IHaveSyncShadow_Boolean, IHaveThingArn, IHaveId, IHaveCertificateArn
        {
            /// <summary>
            /// SyncShadow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinitionversion-core.html#cfn-greengrass-coredefinitionversion-core-syncshadow
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SyncShadow { get; set; }
            /// <summary>
            /// ThingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinitionversion-core.html#cfn-greengrass-coredefinitionversion-core-thingarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingArn { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinitionversion-core.html#cfn-greengrass-coredefinitionversion-core-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinitionversion-core.html#cfn-greengrass-coredefinitionversion-core-certificatearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }
    }
}