namespace Humidifier.ControlTower
{
    using global::System.Collections.Generic;

    public class Baseline : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ControlTower.Baseline; }
    }
}