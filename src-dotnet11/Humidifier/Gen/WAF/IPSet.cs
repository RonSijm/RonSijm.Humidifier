namespace Humidifier.WAF
{
    using global::System.Collections.Generic;
    using IPSetTypes;

    public class IPSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfWAFIPSetTypesIPSetDescriptorIPSetDescriptors, IHaveName
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
        public Union<IReadOnlyList<Humidifier.WAF.IPSetTypes.IPSetDescriptor>, IReadOnlyList<Union<Humidifier.WAF.IPSetTypes.IPSetDescriptor, BaseFunction>>, BaseFunction>? IPSetDescriptors { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-ipset-ipsetdescriptors.html#cfn-waf-ipset-ipsetdescriptors-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }
    }
}