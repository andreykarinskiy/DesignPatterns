using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragAndDrop.Tests
{
    [TestClass]
    public sealed class Перетаскивание_фигур
    {
        /*
         * При щелче по фигуре бросается событие.
         * При перетаскивании бросается событие с координатами
         * При окончании перетаскивания событие.
         */

        [TestMethod]
        public void Если_мышка_над_фигурой_и_зажата_левая_кнопка_То_бросается_событие_BeginDrag()
        {
            Assert.Inconclusive();
        }
    }
}
