namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;

    public class ModuleDefaultVersion : Humidifier.Base.BaseResource, IHaveVersionId, IHaveModuleName, IHaveArn
    {
        public override string AWSTypeName { get => AWS.CloudFormation.ModuleDefaultVersion; }
        /// <summary>
        /// VersionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduledefaultversion.html#cfn-cloudformation-moduledefaultversion-versionid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionId { get; set; }
        /// <summary>
        /// ModuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduledefaultversion.html#cfn-cloudformation-moduledefaultversion-modulename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ModuleName { get; set; }
        /// <summary>
        /// Arn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduledefaultversion.html#cfn-cloudformation-moduledefaultversion-arn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Arn { get; set; }
    }
}