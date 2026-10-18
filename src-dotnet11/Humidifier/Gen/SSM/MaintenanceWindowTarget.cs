namespace Humidifier.SSM
{
    using global::System.Collections.Generic;
    using MaintenanceWindowTargetTypes;

    public class MaintenanceWindowTarget : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveOwnerInformation, IHaveDescription, IHaveWindowId, IHaveResourceType, IHaveListOfSSMMaintenanceWindowTargetTypesTargetsTargets, IHaveName
    {
        public class Attributes
        {
            public static string WindowTargetId =  "WindowTargetId" ;
        }

        public override string AWSTypeName { get => AWS.SSM.MaintenanceWindowTarget; }
        /// <summary>
        /// OwnerInformation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-ownerinformation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OwnerInformation { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// WindowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-windowid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WindowId { get; set; }

        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-resourcetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceType { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-targets
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Targets
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets>, IReadOnlyList<Union<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets, BaseFunction>>, BaseFunction>? Targets { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace MaintenanceWindowTargetTypes
    {
        public class Targets : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtarget-targets.html#cfn-ssm-maintenancewindowtarget-targets-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtarget-targets.html#cfn-ssm-maintenancewindowtarget-targets-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}