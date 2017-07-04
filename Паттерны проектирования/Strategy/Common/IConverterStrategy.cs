namespace Strategy.Common
{
    public interface IConverterStrategy<in TFrom, out TTo> : IConverterStrategy
    {
        TTo Convert(TFrom source);
    }

    public interface IConverterStrategy
    {
        bool CanConvert<TFrom, TTo>();
    }
}