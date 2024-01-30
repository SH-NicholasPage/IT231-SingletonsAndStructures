/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/

using System.Drawing;
using System.Numerics;

namespace BouncingBalls.Lab12TODO
{
    //The Renderer is a singleton.
    //Sealed classes cannot be inherited.
    public sealed class Renderer
    {
        //                X    Y    width   height
        //Initial values: 10   10   200     200
        public Rectangle BoundingBox { get; private set; } = new Rectangle(10, 10, 200, 200);

        private Renderer() { } //Private constructor so it can't be constructed outside of this class

        public static Renderer GetInstance()
        {
            //TODO: Your code here
            throw new NotImplementedException();
        }

        public List<Ball> PerformBallPhysics(List<Ball> balls)
        {
            //TODO: Your code here
            //If a ball is outside of the X bounds, flip the X velocity.
            //If a ball is outside of the Y bounds, flip the Y velocity.
            //Ensure no ball is outside of the boundary.
            return balls;
        }

        public Ball CreateBall(Vector2 pposition, Vector2 pvelocity, float psize, Color pcolor)
        {
            //TODO: Your code here
            throw new NotImplementedException();
        }

        public void ModifyBoundingBox(int x, int y, int width, int height)
        {
            //TODO: Your code here
            throw new NotImplementedException();
        }

        private bool IsBallOutsideXBoundary(Ball ball) => ball.Position.X > BoundingBox.Width - ball.Size || ball.Position.X + BoundingBox.X < BoundingBox.X;

        private bool IsBallOutsideYBoundary(Ball ball) => ball.Position.Y > BoundingBox.Height - ball.Size || ball.Position.Y + BoundingBox.Y < BoundingBox.Y;
    }
}
