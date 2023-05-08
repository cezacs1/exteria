// walk

        private static void SetWalk(int dir, Vector2 a, Vector2 b)
        {
            if (dir == 1)
            {
                if (a.X > b.X)
                {
                    WALK.LEFT();
                }
                else if (a.X < b.X)
                {
                    WALK.RIGHT();
                }
                if (a.Y > b.Y)
                {
                    WALK.BACK();
                }
                else if (a.Y < b.Y)
                {
                    WALK.FORWARD();
                }
            }
            else if (dir == 2)
            {
                if (a.X > b.X)
                {
                    WALK.BACK();
                }
                else if (a.X < b.X)
                {
                    WALK.FORWARD();
                }
                if (a.Y > b.Y)
                {
                    WALK.RIGHT();
                }
                else if (a.Y < b.Y)
                {
                    WALK.LEFT();
                }
            }
            else if (dir == 3)
            {
                if (a.X > b.X)
                {
                    WALK.RIGHT();
                }
                else if (a.X < b.X)
                {
                    WALK.LEFT();
                }
                if (a.Y > b.Y)
                {
                    WALK.FORWARD();
                }
                else if (a.Y < b.Y)
                {
                    WALK.BACK();
                }
            }
            else if (dir == 4)
            {
                if (a.X > b.X)
                {
                    WALK.FORWARD();
                }
                else if (a.X < b.X)
                {
                    WALK.BACK();
                }
                if (a.Y > b.Y)
                {
                    WALK.LEFT();
                }
                else if (a.Y < b.Y)
                {
                    WALK.RIGHT();
                }
            }
        }
