namespace Humidifier.EMR
{
    using System.Collections.Generic;

    public class SecurityConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public override string AWSTypeName { get => AWS.EMR.SecurityConfiguration; }

        /// <summary>
        /// SecurityConfiguration_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-securityconfiguration.html#cfn-emr-securityconfiguration-securityconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic SecurityConfiguration_ { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}