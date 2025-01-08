namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;

    public class HookDefaultVersion : Humidifier.Base.BaseResource, IHaveTypeName, IHaveVersionId, IHaveTypeVersionArn
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.HookDefaultVersion; }
        /// <summary>
        /// VersionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookdefaultversion.html#cfn-cloudformation-hookdefaultversion-versionid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VersionId { get; set; }
        /// <summary>
        /// TypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookdefaultversion.html#cfn-cloudformation-hookdefaultversion-typename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TypeName { get; set; }
        /// <summary>
        /// TypeVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hookdefaultversion.html#cfn-cloudformation-hookdefaultversion-typeversionarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TypeVersionArn { get; set; }
    }
}