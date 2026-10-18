namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using HumanTaskUiTypes;

    public class HumanTaskUi : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveHumanTaskUiName, IHaveSageMakerHumanTaskUiTypesUiTemplateUiTemplate
    {
        public class Attributes
        {
            public static string HumanTaskUiArn =  "HumanTaskUiArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.HumanTaskUi; }
        public Union<string, BaseFunction>? HumanTaskUiName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// UiTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-humantaskui.html#cfn-sagemaker-humantaskui-uitemplate
        /// Required: False
        /// UpdateType: Immutable
        /// Type: UiTemplate
        /// </summary>
        public Union<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate, BaseFunction>? UiTemplate { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-humantaskui.html#cfn-sagemaker-humantaskui-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace HumanTaskUiTypes
    {
        public class UiTemplate : Humidifier.Base.BaseSubResource, IHaveContent
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-humantaskui-uitemplate.html#cfn-sagemaker-humantaskui-uitemplate-content
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Content { get; set; }
        }
    }
}