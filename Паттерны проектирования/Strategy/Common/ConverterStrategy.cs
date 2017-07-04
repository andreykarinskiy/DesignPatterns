namespace Strategy.Common
{
    public abstract class ConverterStrategy<TFrom, TTo> : IConverterStrategy<TFrom, TTo>
    {
        public bool CanConvert<TSource, TDestination>()
        {
            return typeof(TSource) == typeof(TFrom) && typeof(TDestination) == typeof(TTo);
        }

        public abstract TTo Convert(TFrom source);
    }
}