using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NSubstitute;

namespace DragAndDrop.Tests
{
    [TestClass]
    public sealed class Журнал_операций
    {
        private readonly CanvasPresenter sut;
        private readonly ICanvasView view;

        public Журнал_операций()
        {
            view = Substitute.For<ICanvasView>();
            sut = new CanvasPresenter(view);
        }

        [TestMethod]
        public void Отмена_последней_операции()
        {
            // arrange
            view
                .CreateShape(Arg.Any<int>(), Arg.Any<int>())
                .Returns(new ShapeMock());

            var shape = sut.AddRandomShape();
            shape.MoveTo(100, 300);
            shape.MoveTo(200, 50);

            // act
            sut.Undo();

            // assert
            shape.X.Should().Be(100);
            shape.Y.Should().Be(300);
        }

        private sealed class ShapeMock : IDraggable
        {
            public int X { get; private set; }

            public int Y { get; private set; }

            public void MoveTo(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
