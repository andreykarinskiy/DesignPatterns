using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class DataProcessor
    {
        public void Process()
        {
            PrepareData();

            AnalyzeData();
        }

        protected abstract void PrepareData();

        protected virtual void AnalyzeData()
        {
            // Алгоритм анализа данных.
        }
    }



    public sealed class SmartDataProcessor : DataProcessor
    {
        protected override void PrepareData()
        {
            // Реализация шаблонного метода.
        }
    }
}
