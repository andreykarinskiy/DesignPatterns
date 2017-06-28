using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
// ReSharper disable InconsistentNaming

namespace DragAndDrop.Tests
{
    [TestClass]
    public sealed class CanvasPresenterTests
    {
        private readonly CanvasPresenter sut;
        private readonly ICanvasView view;

        public CanvasPresenterTests()
        {
            view = Substitute.For<ICanvasView>();
            sut = new CanvasPresenter(view);
        }

        [TestMethod]
        public void Если_нажать_кнопку_Add_То_на_холст_добавится_фигура()
        {
            // arrange, act
            view.Adding += Raise.Event();

            // assert
            sut.IsCanvasEmpty
                .Should().BeFalse();
        }

        [TestMethod]
        public void Если_холст_пустой_То_конопки_Undo_и_Redo_неактивны()
        {
            // arrange, act
            sut.Clear();

            // assert
            view.IsCanUndo
                .Should().BeFalse();

            view.IsCanRedo
                .Should().BeFalse();
        }

        [TestMethod]
        public void Если_на_холст_добавить_первую_фигуру_То_кнопка_Undo_будет_активна_А_кнопка_Redo_неактивна()
        {
            // arrange, act
            sut.AddRandomShape();

            // assert
            view.IsCanUndo
                .Should().BeTrue();

            view.IsCanRedo
                .Should().BeFalse();
        }

        [TestMethod]
        public void Если_на_холст_добавить_две_фигуры_То_кнопки_Undo_и_Redo_будут_активны()
        {
            // arrange, act
            sut.AddRandomShape();
            sut.AddRandomShape();

            // assert
            view.IsCanUndo
                .Should().BeTrue();

            view.IsCanRedo
                .Should().BeTrue();
        }
    }
}
