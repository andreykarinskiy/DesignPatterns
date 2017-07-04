using System.Globalization;

using Strategy.Common;

namespace Strategy.Strategies
{
    [ConverterStrategy]
    public sealed class StringToFloat : ConverterStrategy<string, float>
    {
        public override float Convert(string source)
        {
            return float.Parse(source, CultureInfo.InvariantCulture);
        }
    }
}