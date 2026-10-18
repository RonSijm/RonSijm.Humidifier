namespace Humidifier.WorkspacesInstances
{
    using global::System.Collections.Generic;

    public class VolumeAssociation : Humidifier.Base.BaseResource, IHaveVolumeId, IHaveWorkspaceInstanceId, IHaveDevice, IHaveDisassociateMode
    {
        public override string AWSTypeName { get => AWS.WorkspacesInstances.VolumeAssociation; }

        /// <summary>
        /// VolumeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volumeassociation.html#cfn-workspacesinstances-volumeassociation-volumeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VolumeId { get; set; }

        /// <summary>
        /// WorkspaceInstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volumeassociation.html#cfn-workspacesinstances-volumeassociation-workspaceinstanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkspaceInstanceId { get; set; }

        /// <summary>
        /// Device
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volumeassociation.html#cfn-workspacesinstances-volumeassociation-device
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Device { get; set; }
        /// <summary>
        /// DisassociateMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-volumeassociation.html#cfn-workspacesinstances-volumeassociation-disassociatemode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisassociateMode { get; set; }
    }
}