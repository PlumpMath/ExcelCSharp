﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelWriterCSharp
{
    public enum TableStyle
    {
        None,
        TableStyleLight1,
        TableStyleLight2,
        TableStyleLight3,
        TableStyleLight4,
        TableStyleLight5,
        TableStyleLight6,
        TableStyleLight7,
        TableStyleLight8,
        TableStyleLight9,
        TableStyleLight10,
        TableStyleLight11,
        TableStyleLight12,
        TableStyleLight13,
        TableStyleLight14,
        TableStyleLight15,
        TableStyleLight16,
        TableStyleLight17,
        TableStyleLight18,
        TableStyleLight19,
        TableStyleLight20,
        TableStyleLight21,
        TableStyleMedium1,
        TableStyleMedium2,
        TableStyleMedium3,
        TableStyleMedium4,
        TableStyleMedium5,
        TableStyleMedium6,
        TableStyleMedium7,
        TableStyleMedium8,
        TableStyleMedium9,
        TableStyleMedium10,
        TableStyleMedium11,
        TableStyleMedium12,
        TableStyleMedium13,
        TableStyleMedium14,
        TableStyleMedium15,
        TableStyleMedium16,
        TableStyleMedium17,
        TableStyleMedium18,
        TableStyleMedium19,
        TableStyleMedium20,
        TableStyleMedium21,
        TableStyleMedium22,
        TableStyleMedium23,
        TableStyleMedium24,
        TableStyleMedium25,
        TableStyleMedium26,
        TableStyleMedium27,
        TableStyleMedium28,
        TableStyleDark1,
        TableStyleDark2,
        TableStyleDark3,
        TableStyleDark4,
        TableStyleDark5,
        TableStyleDark6,
        TableStyleDark7,
        TableStyleDark8,
        TableStyleDark9,
        TableStyleDark10,
        TableStyleDark11
    }

    public enum TableHeaders
    {
        Yes = Excel.XlYesNoGuess.xlYes,
        No = Excel.XlYesNoGuess.xlNo,
    }
}