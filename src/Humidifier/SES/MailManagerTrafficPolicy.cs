namespace Humidifier.SES
{
    using System.Collections.Generic;
    using MailManagerTrafficPolicyTypes;

    public class MailManagerTrafficPolicy : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string TrafficPolicyId =  "TrafficPolicyId" ;
            public static string TrafficPolicyArn =  "TrafficPolicyArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SES::MailManagerTrafficPolicy";
            }
        }

        /// <summary>
        /// DefaultAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-defaultaction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultAction { get; set; }
        /// <summary>
        /// PolicyStatements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-policystatements
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PolicyStatement
        /// </summary>
        public List<PolicyStatement> PolicyStatements { get; set; }
        /// <summary>
        /// TrafficPolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-trafficpolicyname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TrafficPolicyName { get; set; }
        /// <summary>
        /// MaxMessageSizeBytes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-maxmessagesizebytes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic MaxMessageSizeBytes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace MailManagerTrafficPolicyTypes
    {
        public class IngressAnalysis
        {
            /// <summary>
            /// Analyzer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressanalysis.html#cfn-ses-mailmanagertrafficpolicy-ingressanalysis-analyzer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Analyzer { get; set; }
            /// <summary>
            /// ResultField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressanalysis.html#cfn-ses-mailmanagertrafficpolicy-ingressanalysis-resultfield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResultField { get; set; }
        }

        public class IngressBooleanExpression
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressbooleanexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressbooleanexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressbooleanexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressbooleanexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressBooleanToEvaluate
            /// </summary>
            public IngressBooleanToEvaluate Evaluate { get; set; }
        }

        public class IngressBooleanToEvaluate
        {
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressbooleantoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingressbooleantoevaluate-analysis
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressAnalysis
            /// </summary>
            public IngressAnalysis Analysis { get; set; }
        }

        public class IngressIpToEvaluate
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressiptoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingressiptoevaluate-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Attribute { get; set; }
        }

        public class IngressIpv4Expression
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv4expression.html#cfn-ses-mailmanagertrafficpolicy-ingressipv4expression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv4expression.html#cfn-ses-mailmanagertrafficpolicy-ingressipv4expression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressIpToEvaluate
            /// </summary>
            public IngressIpToEvaluate Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv4expression.html#cfn-ses-mailmanagertrafficpolicy-ingressipv4expression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class IngressStringExpression
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressstringexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressstringexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressstringexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressstringexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressStringToEvaluate
            /// </summary>
            public IngressStringToEvaluate Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressstringexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressstringexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class IngressStringToEvaluate
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressstringtoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingressstringtoevaluate-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Attribute { get; set; }
        }

        public class IngressTlsProtocolExpression
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression.html#cfn-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression.html#cfn-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressTlsProtocolToEvaluate
            /// </summary>
            public IngressTlsProtocolToEvaluate Evaluate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression.html#cfn-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class IngressTlsProtocolToEvaluate
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingresstlsprotocoltoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingresstlsprotocoltoevaluate-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Attribute { get; set; }
        }

        public class PolicyCondition
        {
            /// <summary>
            /// BooleanExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policycondition.html#cfn-ses-mailmanagertrafficpolicy-policycondition-booleanexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressBooleanExpression
            /// </summary>
            public IngressBooleanExpression BooleanExpression { get; set; }
            /// <summary>
            /// StringExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policycondition.html#cfn-ses-mailmanagertrafficpolicy-policycondition-stringexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressStringExpression
            /// </summary>
            public IngressStringExpression StringExpression { get; set; }
            /// <summary>
            /// TlsExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policycondition.html#cfn-ses-mailmanagertrafficpolicy-policycondition-tlsexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressTlsProtocolExpression
            /// </summary>
            public IngressTlsProtocolExpression TlsExpression { get; set; }
            /// <summary>
            /// IpExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policycondition.html#cfn-ses-mailmanagertrafficpolicy-policycondition-ipexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressIpv4Expression
            /// </summary>
            public IngressIpv4Expression IpExpression { get; set; }
        }

        public class PolicyStatement
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policystatement.html#cfn-ses-mailmanagertrafficpolicy-policystatement-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policystatement.html#cfn-ses-mailmanagertrafficpolicy-policystatement-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyCondition
            /// </summary>
            public List<PolicyCondition> Conditions { get; set; }
        }
    }
}