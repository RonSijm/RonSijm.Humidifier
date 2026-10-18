namespace Humidifier.ECRPublic
{
    using global::System.Collections.Generic;
    using RegistryTypes;

    public class Registry : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Verified =  "Verified" ;
            public static string RegistryUri =  "RegistryUri" ;
            public static string DisplayName =  "DisplayName" ;
            public static string RegistryId =  "RegistryId" ;
            public static string Aliases =  "Aliases" ;
            public static string RegistryArn =  "RegistryArn" ;
        }

        public override string AWSTypeName { get => AWS.ECRPublic.Registry; }
    }

    namespace RegistryTypes
    {
        public class RegistryAlias : Humidifier.Base.BaseSubResource, IHaveStatus, IHavePrimaryRegistryAlias_Boolean, IHaveDefaultRegistryAlias_Boolean, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecrpublic-registry-registryalias.html#cfn-ecrpublic-registry-registryalias-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// PrimaryRegistryAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecrpublic-registry-registryalias.html#cfn-ecrpublic-registry-registryalias-primaryregistryalias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PrimaryRegistryAlias { get; set; }
            /// <summary>
            /// DefaultRegistryAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecrpublic-registry-registryalias.html#cfn-ecrpublic-registry-registryalias-defaultregistryalias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DefaultRegistryAlias { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecrpublic-registry-registryalias.html#cfn-ecrpublic-registry-registryalias-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}