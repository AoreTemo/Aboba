using librarian.Positions;

namespace librarian
{
    internal static class Positioning
    {
        public static int currentRow    = 0;
        public static int currentColumn = 0;
        public static int panelsPerRow  = 5;    

        public const  int PANEL_WIDTH   = 300;
        public const  int PANEL_HEIGHT  = 420;
        public const  int PANEL_MARGIN_LEFT_TOP = 37;

        public static int CalculatePanelsPerRow(int width)
        {
            return (width - PANEL_MARGIN_LEFT_TOP) / (PANEL_WIDTH + PANEL_MARGIN_LEFT_TOP);
        }
        public static int GetCoordinateForBook(Coordinates coordinate)
        {
            return coordinate switch
            {
                Coordinates.X => PANEL_MARGIN_LEFT_TOP + currentColumn * (PANEL_WIDTH + PANEL_MARGIN_LEFT_TOP),
                Coordinates.Y => PANEL_MARGIN_LEFT_TOP + currentRow * (PANEL_HEIGHT + PANEL_MARGIN_LEFT_TOP),
                _ => 0,
            };
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
