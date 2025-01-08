namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;

    public class ModuleDefaultVersion : Humidifier.Base.BaseResource, IHaveArn, IHaveVersionId, IHaveModuleName
    {
        public override string AWSTypeName { get => AWS.CloudFormation.ModuleDefaultVersion; }
        /// <summary>
        /// VersionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduledefaultversion.html#cfn-cloudformation-moduledefaultversion-versionid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VersionId { get; set; }
        /// <summary>
        /// ModuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduledefaultversion.html#cfn-cloudformation-moduledefaultversion-modulename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModuleName { get; set; }
        /// <summary>
        /// Arn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduledefaultversion.html#cfn-cloudformation-moduledefaultversion-arn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Arn { get; set; }
    }
}