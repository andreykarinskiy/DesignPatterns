using System;
using System.ComponentModel.Composition;

namespace Strategy.Common
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ConverterStrategyAttribute : ExportAttribute
    {
        public ConverterStrategyAttribute() : base(typeof(IConverterStrategy))
        {
        }
    }
}