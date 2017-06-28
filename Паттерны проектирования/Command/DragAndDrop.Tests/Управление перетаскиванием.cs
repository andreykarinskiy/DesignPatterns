using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NSubstitute;

namespace DragAndDrop.Tests
{
    [TestClass]
    public sealed class Управление_перетаскиванием
    {
        private readonly CanvasPresenter sut;
        private readonly ICanvasView view;

        public Управление_перетаскиванием()
        {
            view = Substitute.For<ICanvasView>();
            sut = new CanvasPresenter(view);
        }

        [TestMethod]
        public void Указание_координат_фигуре()
        {
            // arrange
            // act
            // assert
            Assert.Inconclusive();
        }
    }
}
