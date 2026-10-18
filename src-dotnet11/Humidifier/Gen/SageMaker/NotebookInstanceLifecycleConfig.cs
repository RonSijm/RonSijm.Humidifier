namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using NotebookInstanceLifecycleConfigTypes;

    public class NotebookInstanceLifecycleConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfSageMakerNotebookInstanceLifecycleConfigTypesNotebookInstanceLifecycleHookOnStart, IHaveNotebookInstanceLifecycleConfigName, IHaveListOfSageMakerNotebookInstanceLifecycleConfigTypesNotebookInstanceLifecycleHookOnCreate
    {
        public class Attributes
        {
            public static string NotebookInstanceLifecycleConfigName =  "NotebookInstanceLifecycleConfigName" ;
            public static string NotebookInstanceLifecycleConfigArn =  "NotebookInstanceLifecycleConfigArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.NotebookInstanceLifecycleConfig; }
        /// <summary>
        /// OnStart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-onstart
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotebookInstanceLifecycleHook
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook>, IReadOnlyList<Union<Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook, BaseFunction>>, BaseFunction>? OnStart { get; set; }
        public Union<string, BaseFunction>? NotebookInstanceLifecycleConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// OnCreate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-oncreate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotebookInstanceLifecycleHook
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook>, IReadOnlyList<Union<Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook, BaseFunction>>, BaseFunction>? OnCreate { get; set; }
    }

    namespace NotebookInstanceLifecycleConfigTypes
    {
        public class NotebookInstanceLifecycleHook : Humidifier.Base.BaseSubResource, IHaveContent
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-notebookinstancelifecycleconfig-notebookinstancelifecyclehook.html#cfn-sagemaker-notebookinstancelifecycleconfig-notebookinstancelifecyclehook-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Content { get; set; }
        }
    }
}