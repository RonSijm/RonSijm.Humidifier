namespace Humidifier.FIS
{
    using global::System.Collections.Generic;

    public class Action : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.FIS.Action; }
    }
}