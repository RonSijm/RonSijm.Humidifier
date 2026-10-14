namespace Humidifier.RAM
{
    using global::System.Collections.Generic;

    public class PermissionAssociation : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string IsDefault =  "IsDefault" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string ResourceType =  "ResourceType" ;
            public static string FeatureSet =  "FeatureSet" ;
            public static string AssociationStatus =  "AssociationStatus" ;
            public static string PermissionVersion =  "PermissionVersion" ;
        }

        public override string AWSTypeName { get => AWS.RAM.PermissionAssociation; }
        /// <summary>
        /// Replace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permissionassociation.html#cfn-ram-permissionassociation-replace
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Replace { get; set; }

        /// <summary>
        /// ResourceShareArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permissionassociation.html#cfn-ram-permissionassociation-resourcesharearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceShareArn { get; set; }

        /// <summary>
        /// PermissionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-permissionassociation.html#cfn-ram-permissionassociation-permissionarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PermissionArn { get; set; }
    }
}