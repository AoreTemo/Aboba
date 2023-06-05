using librarian.Positions;

namespace librarian;

internal static class Positioning
{        
    public static int currentRow = 0;
    public static int currentColumn = 0;
    public static int panelsPerRow = 5;    

    public const int PANEL_WIDTH = 300;
    public const int PANEL_HEIGHT = 420;
    public const int PANEL_MARGIN_LEFT_TOP = 35;

    private static bool _isLocatingBooks = false;

    public static int PanelWidthArea => PANEL_WIDTH + PANEL_MARGIN_LEFT_TOP;

    public static int PanelHeightArea => PANEL_HEIGHT + PANEL_MARGIN_LEFT_TOP;

    public static int CalculatePanelsPerRow(int width)
    {
        int generalWidth = (width - PANEL_MARGIN_LEFT_TOP);

        return generalWidth / PanelWidthArea;
    }

    public static int GetCoordinateForBook(Coordinates coordinate)
    {
        int coordinateValue = 0;

        switch (coordinate)
        {
            case Coordinates.X:
                coordinateValue = GetXCoordinate();
                break;
            case Coordinates.Y:
                coordinateValue = GetYCoordinate();
                break;
        }

        return coordinateValue;
    }


    public static void CheckColumnAndRow()
    {
        if (currentColumn < panelsPerRow)
            return;

        currentColumn = 0;
        currentRow++;
    }

    public static void LocateBook(Panel control, IEnumerable<Control> Books)
    {
        if (_isLocatingBooks) return;
        _isLocatingBooks = true;

        panelsPerRow = CalculatePanelsPerRow(control!.Width);

        currentRow = 0;
        currentColumn = 0;

        control.AutoScrollPosition = new Point(0, 0);

        foreach (BookPanel Book in Books.Where(Book => Book is BookPanel).Cast<BookPanel>())
        {
            int x = GetCoordinateForBook(Coordinates.X) - control.AutoScrollPosition.X;
            int y = GetCoordinateForBook(Coordinates.Y) - control.AutoScrollPosition.Y;

            Book.Location = new Point(x, y);

            currentColumn++;

            CheckColumnAndRow();
        }

        _isLocatingBooks = false;
    }
    private static int GetXCoordinate()
    {
        return PANEL_MARGIN_LEFT_TOP + currentColumn * PanelWidthArea;
    }

    private static int GetYCoordinate()
    {
        return PANEL_MARGIN_LEFT_TOP + currentRow * PanelHeightArea;
    }
}
