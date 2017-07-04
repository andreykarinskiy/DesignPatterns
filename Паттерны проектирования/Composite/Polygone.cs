using System.Collections.Generic;

namespace Composite
{
    public sealed class Polygone : IShape
    {
        private readonly IList<IShape> children = new List<IShape>();

        public void MoveBy(int dx, int dy)
        {
            // 1. Логика смещения
            // ...

            // 2. Смещение для вложенных элементов
            foreach (var shape in children)
            {
                shape.MoveBy(dx, dy);
            }
        }
    }
}