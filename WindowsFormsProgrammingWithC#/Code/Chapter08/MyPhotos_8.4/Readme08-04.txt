
The existing code has a slight defect when the PixelDlg is displayed for an ActualSize image.  The correct code for this case in the UpdatePixelData method should be as follows:


        case DisplayMode.ActualSize:
            // Panel coords equal image coords
            if (xPos >= bmp.Width || yPos >= bmp.Height)
                return;    // mouse outside image

            x = xPos;
            y = yPos;
            break;


This change is reflected in the example code.