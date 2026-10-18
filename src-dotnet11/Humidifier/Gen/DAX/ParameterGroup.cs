namespace Humidifier.DAX
{
    using global::System.Collections.Generic;

    public class ParameterGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveParameterNameValues_Json, IHaveDescription, IHaveParameterGroupName
    {
        public override string AWSTypeName { get => AWS.DAX.ParameterGroup; }
        /// <summary>
        /// ParameterNameValues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html#cfn-dax-parametergroup-parameternamevalues
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? ParameterNameValues { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html#cfn-dax-parametergroup-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        public Union<string, BaseFunction>? ParameterGroupName { get => GivenName; set => GivenName = value; }
    }
}