namespace Humidifier.Inspector
{
    using global::System.Collections.Generic;

    public class AssessmentTarget : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAssessmentTargetName, IHaveResourceGroupArn
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Inspector.AssessmentTarget; }
        public Union<string, BaseFunction>? AssessmentTargetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ResourceGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttarget.html#cfn-inspector-assessmenttarget-resourcegrouparn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceGroupArn { get; set; }
    }
}