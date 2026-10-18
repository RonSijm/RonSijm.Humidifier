namespace Humidifier.WAFRegional
{
    using global::System.Collections.Generic;
    using GeoMatchSetTypes;

    public class GeoMatchSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfWAFRegionalGeoMatchSetTypesGeoMatchConstraintGeoMatchConstraints, IHaveName
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
        public Union<IReadOnlyList<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint>, IReadOnlyList<Union<Humidifier.WAFRegional.GeoMatchSetTypes.GeoMatchConstraint, BaseFunction>>, BaseFunction>? GeoMatchConstraints { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-geomatchset-geomatchconstraint.html#cfn-wafregional-geomatchset-geomatchconstraint-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }
    }
}