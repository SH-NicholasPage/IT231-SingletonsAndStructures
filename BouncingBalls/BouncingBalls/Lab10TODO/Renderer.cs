/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/

using Microsoft.AspNetCore.Components.RenderTree;
using System.Drawing;
using System.Numerics;
using System.Timers;
using Timer = System.Timers.Timer;

namespace BouncingBalls.Lab10TODO
{
    public sealed class Renderer
    {
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
            throw new NotImplementedException();
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

        private bool IsBallOutsideXBoundary(Ball ball) => ball.position.X > BoundingBox.Width - ball.size || ball.position.X + BoundingBox.X < BoundingBox.X;

        private bool IsBallOutsideYBoundary(Ball ball) => ball.position.Y > BoundingBox.Height - ball.size || ball.position.Y + BoundingBox.Y < BoundingBox.Y;
    }
}
