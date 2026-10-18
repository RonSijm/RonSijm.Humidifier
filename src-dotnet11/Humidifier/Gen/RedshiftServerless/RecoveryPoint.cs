namespace Humidifier.RedshiftServerless
{
    using global::System.Collections.Generic;

    public class RecoveryPoint : Humidifier.Base.BaseResource, IHaveNamespaceName
    {
        public class Attributes
        {
            public static string RecoveryPointCreateTime =  "RecoveryPointCreateTime" ;
            public static string NamespaceArn =  "NamespaceArn" ;
            public static string RecoveryPointId =  "RecoveryPointId" ;
            public static string Arn =  "Arn" ;
            public static string TotalSizeInMegaBytes =  "TotalSizeInMegaBytes" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.RedshiftServerless.RecoveryPoint; }
        /// <summary>
        /// NamespaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-recoverypoint.html#cfn-redshiftserverless-recoverypoint-namespacename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NamespaceName { get; set; }
    }
}