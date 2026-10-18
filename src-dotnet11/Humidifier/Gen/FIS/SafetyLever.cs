namespace Humidifier.FIS
{
    using global::System.Collections.Generic;

    public class SafetyLever : Humidifier.Base.BaseResource, IHaveId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Arn =  "Arn" ;
            public static string Reason =  "Reason" ;
        }

        public override string AWSTypeName { get => AWS.FIS.SafetyLever; }
        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-safetylever.html#cfn-fis-safetylever-id
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Id { get; set; }
    }
}