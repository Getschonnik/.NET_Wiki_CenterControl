#Region "Center to Control"
    Private pCtr As Control
    Private cCtr As Control
    Friend Sub Center_control(ByVal parentControl As Control, ByVal currentControl As Control)
        pCtr = parentControl
        cCtr = currentControl
        Dim pCtr_xPos = pCtr.Location.X
        Dim pCtr_yPos = pCtr.Location.Y
        Dim pCtr_xMid = Math.Ceiling(pCtr.Width / 2)
        Dim pCtr_yMid = Math.Ceiling(pCtr.Height / 2)
        Dim cCtr_xHalf = Math.Ceiling(cCtr.Width / 2)
        Dim cCtr_yHalf = Math.Ceiling(cCtr.Height / 2)
        Dim cCtr_newPointX = Math.Ceiling((pCtr_xPos + pCtr_xMid) - cCtr_xHalf)
        Dim cCtr_newPointY = Math.Ceiling((pCtr_yPos + pCtr_yMid) - cCtr_yHalf)
        cCtr.Location = New Point(cCtr_newPointX, cCtr_newPointY)
    End Sub
#End Region
