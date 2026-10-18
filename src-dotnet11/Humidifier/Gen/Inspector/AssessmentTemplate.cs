namespace Humidifier.Inspector
{
    using global::System.Collections.Generic;

    public class AssessmentTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAssessmentTargetArn, IHaveDurationInSeconds_Integer, IHaveAssessmentTemplateName, IHaveStringListOfRulesPackageArns, IHaveTagListOfUserAttributesForFindings
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Inspector.AssessmentTemplate; }

        /// <summary>
        /// AssessmentTargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-assessmenttargetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssessmentTargetArn { get; set; }

        /// <summary>
        /// DurationInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-durationinseconds
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? DurationInSeconds { get; set; }
        public Union<string, BaseFunction>? AssessmentTemplateName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RulesPackageArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-rulespackagearns
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RulesPackageArns { get; set; }
        /// <summary>
        /// UserAttributesForFindings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-userattributesforfindings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? UserAttributesForFindings { get; set; }
    }
}