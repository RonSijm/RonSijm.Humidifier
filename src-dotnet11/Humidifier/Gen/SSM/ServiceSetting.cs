namespace Humidifier.SSM
{
    using global::System.Collections.Generic;

    public class ServiceSetting : Humidifier.Base.BaseResource, IHaveSettingValue, IHaveSettingId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastModifiedDate =  "LastModifiedDate" ;
            public static string Arn =  "Arn" ;
            public static string LastModifiedUser =  "LastModifiedUser" ;
        }

        public override string AWSTypeName { get => AWS.SSM.ServiceSetting; }

        /// <summary>
        /// SettingValue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-servicesetting.html#cfn-ssm-servicesetting-settingvalue
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SettingValue { get; set; }

        /// <summary>
        /// SettingId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-servicesetting.html#cfn-ssm-servicesetting-settingid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SettingId { get; set; }
    }
}