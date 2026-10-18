namespace Humidifier.AccountAccess
{
    using global::System.Collections.Generic;
    using EntitlementTypes;

    public class Entitlement : Humidifier.Base.BaseResource, IHaveApplicationArn, IHaveAccountAccessEntitlementTypesEntitlementEntitlement_
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string EntitlementId =  "EntitlementId" ;
        }

        public override string AWSTypeName { get => AWS.AccountAccess.Entitlement; }

        /// <summary>
        /// ApplicationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accountaccess-entitlement.html#cfn-accountaccess-entitlement-applicationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationArn { get; set; }

        /// <summary>
        /// Entitlement_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accountaccess-entitlement.html#cfn-accountaccess-entitlement-entitlement
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Entitlement
        /// </summary>
        [Required]
        public Union<Humidifier.AccountAccess.EntitlementTypes.Entitlement, BaseFunction>? Entitlement_ { get; set; }
    }

    namespace EntitlementTypes
    {
        public class Entitlement : Humidifier.Base.BaseSubResource, IHaveAccountAccessEntitlementTypesPrincipalRoleEntitlementPrincipalRole
        {
            /// <summary>
            /// PrincipalRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-entitlement.html#cfn-accountaccess-entitlement-entitlement-principalrole
            /// Required: True
            /// UpdateType: Immutable
            /// Type: PrincipalRoleEntitlement
            /// </summary>
            public Union<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement, BaseFunction>? PrincipalRole { get; set; }
        }

        public class IdentityCenterPrincipal : Humidifier.Base.BaseSubResource, IHaveUserId, IHaveGroupId
        {
            /// <summary>
            /// UserId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-identitycenterprincipal.html#cfn-accountaccess-entitlement-identitycenterprincipal-userid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserId { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-identitycenterprincipal.html#cfn-accountaccess-entitlement-identitycenterprincipal-groupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
        }

        public class Principal : Humidifier.Base.BaseSubResource, IHaveAccountAccessEntitlementTypesIdentityCenterPrincipalIdentityCenter
        {
            /// <summary>
            /// IdentityCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-principal.html#cfn-accountaccess-entitlement-principal-identitycenter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IdentityCenterPrincipal
            /// </summary>
            public Union<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal, BaseFunction>? IdentityCenter { get; set; }
        }

        public class PrincipalRoleEntitlement : Humidifier.Base.BaseSubResource, IHaveAccount, IHaveAccountAccessEntitlementTypesPrincipalPrincipal, IHaveRoleArn
        {
            /// <summary>
            /// Account
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-principalroleentitlement.html#cfn-accountaccess-entitlement-principalroleentitlement-account
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Account { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-principalroleentitlement.html#cfn-accountaccess-entitlement-principalroleentitlement-principal
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Principal
            /// </summary>
            public Union<Humidifier.AccountAccess.EntitlementTypes.Principal, BaseFunction>? Principal { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-principalroleentitlement.html#cfn-accountaccess-entitlement-principalroleentitlement-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}