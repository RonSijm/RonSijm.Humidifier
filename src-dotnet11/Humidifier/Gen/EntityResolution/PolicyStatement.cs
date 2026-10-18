namespace Humidifier.EntityResolution
{
    using global::System.Collections.Generic;

    public class PolicyStatement : Humidifier.Base.BaseResource, IHaveCondition, IHaveStringListOfAction, IHaveStatementId, IHaveEffect, IHaveArn, IHaveStringListOfPrincipal
    {
        public override string AWSTypeName { get => AWS.EntityResolution.PolicyStatement; }
        /// <summary>
        /// Condition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-policystatement.html#cfn-entityresolution-policystatement-condition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Condition { get; set; }
        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-policystatement.html#cfn-entityresolution-policystatement-action
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Action { get; set; }

        /// <summary>
        /// StatementId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-policystatement.html#cfn-entityresolution-policystatement-statementid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StatementId { get; set; }
        /// <summary>
        /// Effect
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-policystatement.html#cfn-entityresolution-policystatement-effect
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Effect { get; set; }

        /// <summary>
        /// Arn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-policystatement.html#cfn-entityresolution-policystatement-arn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Arn { get; set; }
        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-policystatement.html#cfn-entityresolution-policystatement-principal
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Principal { get; set; }
    }
}