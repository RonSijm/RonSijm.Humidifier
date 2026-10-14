namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;

    public class ResourceEndpointAssociation : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ResourceConfigurationId =  "ResourceConfigurationId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string ResourceConfigurationArn =  "ResourceConfigurationArn" ;
            public static string VpcEndpointId =  "VpcEndpointId" ;
            public static string VpcEndpointOwner =  "VpcEndpointOwner" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.ResourceEndpointAssociation; }
    }
}