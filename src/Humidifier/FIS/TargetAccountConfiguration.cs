namespace Humidifier.FIS
{
    using System.Collections.Generic;

    public class TargetAccountConfiguration : Humidifier.Resource, IHaveDescription
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::FIS::TargetAccountConfiguration";
            }
        }

        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-targetaccountconfiguration.html#cfn-fis-targetaccountconfiguration-accountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccountId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-targetaccountconfiguration.html#cfn-fis-targetaccountconfiguration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ExperimentTemplateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-targetaccountconfiguration.html#cfn-fis-targetaccountconfiguration-experimenttemplateid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExperimentTemplateId { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-targetaccountconfiguration.html#cfn-fis-targetaccountconfiguration-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
    }
}