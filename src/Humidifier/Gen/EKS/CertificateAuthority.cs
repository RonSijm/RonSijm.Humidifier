namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using CertificateAuthorityTypes;

    public class CertificateAuthority : Humidifier.Base.BaseResource, IHaveClusterName
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string ActivatedBy =  "ActivatedBy" ;
            public static string SigningStatus =  "SigningStatus" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ActivatedAt =  "ActivatedAt" ;
            public static string Data =  "Data" ;
            public static string Validity =  "Validity" ;
            public static string DistributionStatus =  "DistributionStatus" ;
            public static string ScheduledEvents =  "ScheduledEvents" ;
            public static string Id =  "Id" ;
            public static string RollbackAvailable =  "RollbackAvailable" ;
        }

        public override string AWSTypeName { get => AWS.EKS.CertificateAuthority; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-certificateauthority.html#cfn-eks-certificateauthority-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterName { get; set; }
    }

    namespace CertificateAuthorityTypes
    {
        public class ScheduledEvents : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FinalAutoActivation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-certificateauthority-scheduledevents.html#cfn-eks-certificateauthority-scheduledevents-finalautoactivation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FinalAutoActivation { get; set; }
            /// <summary>
            /// FirstAutoActivation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-certificateauthority-scheduledevents.html#cfn-eks-certificateauthority-scheduledevents-firstautoactivation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FirstAutoActivation { get; set; }
        }

        public class Validity : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NotBefore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-certificateauthority-validity.html#cfn-eks-certificateauthority-validity-notbefore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotBefore { get; set; }
            /// <summary>
            /// NotAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-certificateauthority-validity.html#cfn-eks-certificateauthority-validity-notafter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotAfter { get; set; }
        }
    }
}