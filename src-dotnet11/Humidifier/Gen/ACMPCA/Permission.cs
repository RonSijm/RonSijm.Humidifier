namespace Humidifier.ACMPCA
{
    using global::System.Collections.Generic;

    public class Permission : Humidifier.Base.BaseResource, IHaveCertificateAuthorityArn, IHaveStringListOfActions, IHaveSourceAccount, IHavePrincipal
    {
        public override string AWSTypeName { get => AWS.ACMPCA.Permission; }

        /// <summary>
        /// CertificateAuthorityArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-permission.html#cfn-acmpca-permission-certificateauthorityarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-permission.html#cfn-acmpca-permission-actions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
        /// <summary>
        /// SourceAccount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-permission.html#cfn-acmpca-permission-sourceaccount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceAccount { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-permission.html#cfn-acmpca-permission-principal
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Principal { get; set; }
    }
}