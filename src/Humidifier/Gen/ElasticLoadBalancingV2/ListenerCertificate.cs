namespace Humidifier.ElasticLoadBalancingV2
{
    using System.Collections.Generic;
    using ListenerCertificateTypes;

    public class ListenerCertificate : Humidifier.Base.BaseResource, IHaveListenerArn
    {
        public override string AWSTypeName { get => AWS.ElasticLoadBalancingV2.ListenerCertificate; }

        /// <summary>
        /// Certificates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenercertificate.html#cfn-elasticloadbalancingv2-listenercertificate-certificates
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Certificate
        /// </summary>
        [Required]
        public List<Humidifier.ElasticLoadBalancingV2.ListenerCertificateTypes.Certificate> Certificates { get; set; }

        /// <summary>
        /// ListenerArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenercertificate.html#cfn-elasticloadbalancingv2-listenercertificate-listenerarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ListenerArn { get; set; }
    }

    namespace ListenerCertificateTypes
    {
        public class Certificate : Humidifier.Base.BaseSubResource, IHaveCertificateArn
        {
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-certificates.html#cfn-elasticloadbalancingv2-listener-certificates-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }
    }
}