namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;

    public class Recipe : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Description =  "Description" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string RecipeType =  "RecipeType" ;
            public static string FeatureTransformationArn =  "FeatureTransformationArn" ;
            public static string RecipeArn =  "RecipeArn" ;
            public static string AlgorithmArn =  "AlgorithmArn" ;
            public static string LastUpdatedDateTime =  "LastUpdatedDateTime" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.Recipe; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}