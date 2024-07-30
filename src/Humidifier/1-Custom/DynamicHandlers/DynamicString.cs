//using Humidifier.Core;

//namespace Humidifier
//{
//    public class DynamicString
//    {
//        public string Value { get; set; }

//        public static implicit operator DynamicString(string value)
//        {
//            var dynamicString = new DynamicString()
//            {
//                Value = value
//            };

//            return dynamicString;
//        }

//        public static implicit operator DynamicString(int value)
//        {
//            var dynamicString = new DynamicString()
//            {
//                Value = value.ToString()
//            };

//            return dynamicString;
//        }

//        public static implicit operator DynamicString(BaseFunction value)
//        {
//            var dynamicString = new DynamicString()
//            {
//                Value = "test"
//            };

//            return dynamicString;
//        }
//    }
//}