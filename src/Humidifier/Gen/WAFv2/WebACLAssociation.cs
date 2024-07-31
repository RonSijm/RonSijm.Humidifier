namespace Humidifier.WAFv2
{
    using System.Collections.Generic;

    public class WebACLAssociation : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::WAFv2::WebACLAssociation";
            }
        }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webaclassociation.html#cfn-wafv2-webaclassociation-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceArn { get; set; }

        /// <summary>
        /// WebACLArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webaclassociation.html#cfn-wafv2-webaclassociation-webaclarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic WebACLArn { get; set; }
    }
}