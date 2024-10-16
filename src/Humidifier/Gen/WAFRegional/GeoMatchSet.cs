namespace Humidifier.WAFRegional
{
    using System.Collections.Generic;
    using GeoMatchSetTypes;

    public class GeoMatchSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAFRegional.GeoMatchSet; }
        /// <summary>
        /// GeoMatchConstraints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-geomatchset.html#cfn-wafregional-geomatchset-geomatchconstraints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GeoMatchConstraint
        /// </summary>
        public List<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint> GeoMatchConstraints { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace GeoMatchSetTypes
    {
        public class GeoMatchConstraint : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-geomatchset-geomatchconstraint.html#cfn-wafregional-geomatchset-geomatchconstraint-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-geomatchset-geomatchconstraint.html#cfn-wafregional-geomatchset-geomatchconstraint-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }
    }
}