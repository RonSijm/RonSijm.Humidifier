namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using HumanTaskUiTypes;

    public class HumanTaskUi : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string HumanTaskUiArn =  "HumanTaskUiArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.HumanTaskUi; }
        public dynamic HumanTaskUiName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// UiTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-humantaskui.html#cfn-sagemaker-humantaskui-uitemplate
        /// Required: False
        /// UpdateType: Immutable
        /// Type: UiTemplate
        /// </summary>
        public Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate UiTemplate { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-humantaskui.html#cfn-sagemaker-humantaskui-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
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
            public dynamic Content { get; set; }
        }
    }
}