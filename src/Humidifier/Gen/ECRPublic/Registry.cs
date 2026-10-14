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
        public class RegistryAlias : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecrpublic-registry-registryalias.html#cfn-ecrpublic-registry-registryalias-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// PrimaryRegistryAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecrpublic-registry-registryalias.html#cfn-ecrpublic-registry-registryalias-primaryregistryalias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PrimaryRegistryAlias { get; set; }
            /// <summary>
            /// DefaultRegistryAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecrpublic-registry-registryalias.html#cfn-ecrpublic-registry-registryalias-defaultregistryalias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DefaultRegistryAlias { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecrpublic-registry-registryalias.html#cfn-ecrpublic-registry-registryalias-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}