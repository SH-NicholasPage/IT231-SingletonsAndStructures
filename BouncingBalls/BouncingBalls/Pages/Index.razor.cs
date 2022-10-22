using BouncingBalls.Client;
using BouncingBalls.Lab10TODO;
using Microsoft.AspNetCore.Components;
using System.Drawing;
using System.Numerics;
using System.Timers;
using Timer = System.Timers.Timer;

namespace BouncingBalls.Pages
{
    public partial class Index : ComponentBase
    {
        public List<Ball> balls = new List<Ball>();
        public Renderer renderer = Renderer.GetInstance();
        TimerWrapper boundaryBoxGrowth = new TimerWrapper(8000);
        private int timesBBChanged = 0;

        private readonly float callsPerSecond = 30f;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            CreateStockBalls();

            Timer timer = new Timer(1000/callsPerSecond);
            timer.Elapsed += OnTimedEvent!;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
            StateHasChanged();

            boundaryBoxGrowth.Elapsed += OnBoundaryBoxGrowthTimedEvent!;
            boundaryBoxGrowth.AutoReset = true;
            boundaryBoxGrowth.Enabled = true;
            boundaryBoxGrowth.Start();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            balls = renderer.PerformBallPhysics(balls);
            StateHasChanged();
        }

        private void OnBoundaryBoxGrowthTimedEvent(Object source, ElapsedEventArgs e)
        {
            timesBBChanged++;
            switch(timesBBChanged)
            {
                case 1:
                    renderer.ModifyBoundingBox(10, 10, 300, 400);
                    CreateStockBalls();
                    break;
                case 2:
                    renderer.ModifyBoundingBox(10, 10, 500, 400);
                    CreateStockBalls();
                    break;
                case 3:
                    renderer.ModifyBoundingBox(5, 5, 700, 700);
                    CreateStockBalls();
                    boundaryBoxGrowth.Stop();
                    break;
            }
            
            StateHasChanged();
        }

        private void CreateStockBalls()
        {
            for(int i = 0; i < 3; i++)
            {
                float size = Random.Shared.Next(12, renderer.BoundingBox.Width / 2) - Random.Shared.NextSingle();
                float px = Random.Shared.Next(1, renderer.BoundingBox.Width - (int)(size - 1));
                float py = Random.Shared.Next(1, renderer.BoundingBox.Height - (int)(size - 1));
                float vx = Random.Shared.Next(1, 21) - Random.Shared.NextSingle();
                float vy = Random.Shared.Next(1, 21) - Random.Shared.NextSingle();
                balls.Add(renderer.CreateBall(new Vector2(px, py), new Vector2(vx, vy), size, GenerateRandomColor()));
            }
        }

        private Color GenerateRandomColor()
        {
            switch(Random.Shared.Next(0, 24))
            {
                case 0:
                    return Color.Aqua;
                case 1:
                    return Color.Black;
                case 2:
                    return Color.Blue;
                case 3:
                    return Color.Fuchsia;
                case 4:
                    return Color.Gray;
                case 5:
                    return Color.Green;
                case 6:
                    return Color.Lime;
                case 7:
                    return Color.Maroon;
                case 8:
                    return Color.Navy;
                case 9:
                    return Color.Olive;
                case 10:
                    return Color.Purple;
                case 11:
                    return Color.Red;
                case 12:
                    return Color.Silver;
                case 13:
                    return Color.Teal;
                case 14:
                    return Color.Yellow;
                case 15:
                    return Color.Orange;
                case 16:
                    return Color.Brown;
                case 17:
                    return Color.Azure;
                case 18:
                    return Color.Gold;
                case 19:
                    return Color.Cyan;
                case 20:
                    return Color.DarkRed;
                case 21:
                    return Color.Gold;
                case 22:
                    return Color.Pink;
                case 23:
                    return Color.Wheat;
            }

            return Color.Black;
        }
    }
}
