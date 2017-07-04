using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

using Strategy.Common;

namespace Strategy
{
    [Export]
    public sealed class Converter
    {
        private readonly IEnumerable<IConverterStrategy> strategies;

        [ImportingConstructor]
        public Converter([ImportMany] IEnumerable<IConverterStrategy> strategies)
        {
            this.strategies = strategies;
        }


        public TTo Convert<TTo, TFrom>(TFrom source)
        {
            var strategy = strategies.SingleOrDefault(s => s.CanConvert<TFrom, TTo>());

            if (strategy == null)
            {
                throw new ArgumentException($"Нет конвертера {typeof(TFrom)}->{typeof(TTo)}");
            }

            return ((IConverterStrategy<TFrom, TTo>)strategy).Convert(source);
        }
    }
}