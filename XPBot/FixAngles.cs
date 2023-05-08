// fix angles when spawned

        private static void FixAngles()
        {
            if (viewangles.X > 80)
            {
                MouseMove(-30, 0);
            }
            if (viewangles.X < -80)
            {
                MouseMove(30, 0);
            }
            if (viewangles.Y < 15 && viewangles.Y > -15)
            {
                MouseMove(0, 30);
            }
            if (viewangles.Y < -165 && viewangles.Y > 165)
            {
                MouseMove(0, -30);
            }
        }
