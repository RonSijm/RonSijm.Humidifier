namespace Humidifier.UXC
{
    using global::System.Collections.Generic;

    public class AccountCustomization : Humidifier.Base.BaseResource, IHaveAccountColor, IHaveStringListOfVisibleServices, IHaveStringListOfVisibleRegions
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.UXC.AccountCustomization; }
        /// <summary>
        /// AccountColor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-uxc-accountcustomization.html#cfn-uxc-accountcustomization-accountcolor
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccountColor { get; set; }
        /// <summary>
        /// VisibleServices
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-uxc-accountcustomization.html#cfn-uxc-accountcustomization-visibleservices
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VisibleServices { get; set; }
        /// <summary>
        /// VisibleRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-uxc-accountcustomization.html#cfn-uxc-accountcustomization-visibleregions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VisibleRegions { get; set; }
    }
}