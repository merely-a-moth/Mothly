namespace Models
{
    public class Ball
    {
        public Guid ID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double XVel { get; set; }
        public double YVel { get; set; }
        public double Radius { get; set; }
        public string Color { get; set; }

        public Ball(double x, double y, double xVel, double yVel, double radius, string color)
        {
            (X, Y, XVel, YVel, Radius, Color) = (x, y, xVel, yVel, radius, color);
            ID = Guid.NewGuid();
        }

        public void StepForward(double width, double height)
        {
            X += XVel;
            Y += YVel;
            if (X < 0 || X > width)
                XVel *= -1;
            if (Y < 0 || Y > height)
                YVel *= -1;

            if (X < 0)
                X += 0 - X;
            else if (X > width)
                X -= X - width;

            if (Y < 0)
                Y += 0 - Y;
            if (Y > height)
                Y -= Y - height;
        }

        public Ball()
        {
            ID = Guid.NewGuid();
        }
    }
}
