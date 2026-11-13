namespace Humidifier.SSM
{
    using global::System.Collections.Generic;

    public class DefaultHostManagementConfiguration : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastModifiedDate =  "LastModifiedDate" ;
            public static string SettingArn =  "SettingArn" ;
            public static string SettingId =  "SettingId" ;
            public static string RoleArn =  "RoleArn" ;
            public static string LastModifiedUser =  "LastModifiedUser" ;
        }

        public override string AWSTypeName { get => AWS.SSM.DefaultHostManagementConfiguration; }

        /// <summary>
        /// PermissionModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-defaulthostmanagementconfiguration.html#cfn-ssm-defaulthostmanagementconfiguration-permissionmodel
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PermissionModel { get; set; }
        /// <summary>
        /// CustomerManagedRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-defaulthostmanagementconfiguration.html#cfn-ssm-defaulthostmanagementconfiguration-customermanagedrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomerManagedRoleArn { get; set; }
    }
}