namespace Humidifier.CodeGen.Lib.Features.Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendLineCRLF(this StringBuilder sb, string value)
        {
            return sb.Append(value).Append("\r\n");
        }
    }
}