using Microsoft.Xna.Framework;

namespace VNG.Core.Scenes.Layouts
{
    internal class UILayoutConstraint
    {

        private Vector2 finalPosition = Vector2.Zero;

        public void addTopConstraintFrom(Point point, Vector2 padding)
        {
            finalPosition = new Vector2(point.X - (point.X - padding.X), point.Y - (point.Y - padding.Y));
        }

        public Vector2 getFinalPosition() => finalPosition;
    }
}
