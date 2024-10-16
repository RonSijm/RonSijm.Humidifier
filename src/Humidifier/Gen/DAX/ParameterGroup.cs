namespace Humidifier.DAX
{
    using System.Collections.Generic;

    public class ParameterGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveParameterGroupName
    {
        public override string AWSTypeName { get => AWS.DAX.ParameterGroup; }
        /// <summary>
        /// ParameterNameValues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html#cfn-dax-parametergroup-parameternamevalues
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic ParameterNameValues { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html#cfn-dax-parametergroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        public dynamic ParameterGroupName { get => GivenName; set => GivenName = value; }
    }
}