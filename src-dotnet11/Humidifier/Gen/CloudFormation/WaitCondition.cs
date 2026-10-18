namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;

    public class WaitCondition : Humidifier.Base.BaseResource, IHaveCount_Integer, IHaveHandle, IHaveTimeout
    {
        public class Attributes
        {
            public static string Data =  "Data" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.WaitCondition; }
        /// <summary>
        /// Count
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html#cfn-waitcondition-count
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Count { get; set; }
        /// <summary>
        /// Handle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html#cfn-waitcondition-handle
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Handle { get; set; }
        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waitcondition.html#cfn-waitcondition-timeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Timeout { get; set; }
    }
}