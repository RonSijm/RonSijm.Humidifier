namespace Humidifier.WAF
{
    using System.Collections.Generic;
    using IPSetTypes;

    public class IPSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAF.IPSet; }
        /// <summary>
        /// IPSetDescriptors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-ipset.html#cfn-waf-ipset-ipsetdescriptors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IPSetDescriptor
        /// </summary>
        public List<Humidifier.WAF.IPSetTypes.IPSetDescriptor> IPSetDescriptors { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace IPSetTypes
    {
        public class IPSetDescriptor : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-ipset-ipsetdescriptors.html#cfn-waf-ipset-ipsetdescriptors-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-ipset-ipsetdescriptors.html#cfn-waf-ipset-ipsetdescriptors-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }
    }
}