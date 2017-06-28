using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public sealed class CanvasPresenter
    {
        private readonly ICanvasView view;
        private readonly ICollection<IDraggable> shapes = new List<IDraggable>();
        private readonly Random rnd = new Random();

        private const int XArea = 500;
        private const int YArea = 300;

        public CanvasPresenter(ICanvasView view)
        {
            this.view = view;

            view.Adding += (s, e) => AddRandomShape();
        }

        public void Clear()
        {
            foreach (var shape in shapes)
            {
                view.Remove(shape);
            }

            shapes.Clear();
        }

        public bool IsCanvasEmpty => !shapes.Any();

        public IDraggable AddRandomShape()
        {
            var shape = CreateRandomShape();

            shapes.Add(shape);

            var command = new CreateShapeCommand(shape.X, shape.Y);

            CheckUndoAndRedo();

            return shape;
        }

        public void Undo()
        {
        }

        private IDraggable CreateRandomShape()
        {
            var x = rnd.Next(XArea);
            var y = rnd.Next(YArea);

            return view.CreateShape(x, y);
        }

        private void CheckUndoAndRedo()
        {
            switch (shapes.Count)
            {
                case 0:
                    view.IsCanUndo = false;
                    view.IsCanRedo = false;
                    break;

                case 1:
                    view.IsCanUndo = true;
                    view.IsCanRedo = false;
                    break;

                case var c when c > 1:
                    view.IsCanUndo = true;
                    view.IsCanRedo = true;
                    break;
            }
        }
    }
}
