namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using NotebookInstanceLifecycleConfigTypes;

    public class NotebookInstanceLifecycleConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public class Attributes
        {
            public static string NotebookInstanceLifecycleConfigName =  "NotebookInstanceLifecycleConfigName" ;
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
        public List<Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook> OnStart { get; set; }
        public dynamic NotebookInstanceLifecycleConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OnCreate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-oncreate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotebookInstanceLifecycleHook
        /// </summary>
        public List<Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook> OnCreate { get; set; }
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
            public dynamic Content { get; set; }
        }
    }
}