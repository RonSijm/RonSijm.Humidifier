namespace Humidifier.EMR
{
    using global::System.Collections.Generic;

    public class SecurityConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveSecurityConfiguration__Json, IHaveName
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
        public Union<object, BaseFunction>? SecurityConfiguration_ { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}