namespace Humidifier.FIS
{
    using global::System.Collections.Generic;

    public class TargetAccountConfiguration : Humidifier.Base.BaseResource, IHaveAccountId, IHaveDescription, IHaveExperimentTemplateId, IHaveRoleArn
    {
        public override string AWSTypeName { get => AWS.FIS.TargetAccountConfiguration; }

        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-targetaccountconfiguration.html#cfn-fis-targetaccountconfiguration-accountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccountId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-targetaccountconfiguration.html#cfn-fis-targetaccountconfiguration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ExperimentTemplateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-targetaccountconfiguration.html#cfn-fis-targetaccountconfiguration-experimenttemplateid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExperimentTemplateId { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-targetaccountconfiguration.html#cfn-fis-targetaccountconfiguration-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
    }
}