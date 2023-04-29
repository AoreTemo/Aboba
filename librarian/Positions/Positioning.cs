using librarian.Positions;

namespace librarian
{
    internal static class Positioning
    {
        public static int currentRow    = 0;
        public static int currentColumn = 0;
        public static int panelsPerRow  = 5;    

        public const  int PANEL_WIDTH   = 200;
        public const  int PANEL_HEIGHT  = 280;
        public const  int PANEL_MARGIN_LEFT_TOP = 10;

        public static int CalculatePanelsPerRow(int width)
        {
            return (width - PANEL_MARGIN_LEFT_TOP) / (PANEL_WIDTH + PANEL_MARGIN_LEFT_TOP);
        }
        public static int GetCoordinateForBook(Coordinates coordinate)
        {
            switch(coordinate)
            {
                case Coordinates.X:
                    return PANEL_MARGIN_LEFT_TOP + currentColumn * (PANEL_WIDTH + PANEL_MARGIN_LEFT_TOP);

                case Coordinates.Y:
                    return PANEL_MARGIN_LEFT_TOP + currentRow * (PANEL_HEIGHT + PANEL_MARGIN_LEFT_TOP);

                default:
                    return 0;
            }
        }
        public static void CheckColumnAndRow()
        {
            if (currentColumn >= panelsPerRow)
            {
                currentColumn = 0;
                currentRow++;
            }
        }
    }
}
