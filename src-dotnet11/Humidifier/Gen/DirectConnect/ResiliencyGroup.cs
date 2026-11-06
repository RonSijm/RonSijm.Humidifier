namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;

    public class ResiliencyGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveResiliencyGroupName, IHaveStringListOfConnectionArns, IHaveIntendedResiliencyModel
    {
        public class Attributes
        {
            public static string ResiliencyGroupId =  "ResiliencyGroupId" ;
            public static string ResiliencyGroupArn =  "ResiliencyGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.DirectConnect.ResiliencyGroup; }
        public Union<string, BaseFunction>? ResiliencyGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ConnectionArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-resiliencygroup.html#cfn-directconnect-resiliencygroup-connectionarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ConnectionArns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-resiliencygroup.html#cfn-directconnect-resiliencygroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// IntendedResiliencyModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-resiliencygroup.html#cfn-directconnect-resiliencygroup-intendedresiliencymodel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IntendedResiliencyModel { get; set; }
    }
}