namespace Humidifier.WAFRegional
{
    using global::System.Collections.Generic;
    using IPSetTypes;

    public class IPSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfWAFRegionalIPSetTypesIPSetDescriptorIPSetDescriptors, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAFRegional.IPSet; }
        /// <summary>
        /// IPSetDescriptors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ipset.html#cfn-wafregional-ipset-ipsetdescriptors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IPSetDescriptor
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor>, IReadOnlyList<Union<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor, BaseFunction>>, BaseFunction>? IPSetDescriptors { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace IPSetTypes
    {
        public class IPSetDescriptor : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ipset-ipsetdescriptor.html#cfn-wafregional-ipset-ipsetdescriptor-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ipset-ipsetdescriptor.html#cfn-wafregional-ipset-ipsetdescriptor-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }
    }
}