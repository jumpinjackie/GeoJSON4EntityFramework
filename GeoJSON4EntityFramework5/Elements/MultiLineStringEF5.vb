﻿Partial Class MultiLineString
    Public Overrides Sub CreateFromDbGeometry(inp As Spatial.DbGeometry)
        If inp.SpatialTypeName <> MyBase.TypeName Then Throw New ArgumentException
        LineStrings.Clear()

        For i As Integer = 1 To inp.ElementCount
            Dim element = inp.ElementAt(i)
            If element.SpatialTypeName <> "LineString" Then Throw New ArgumentException
            LineStrings.Add(LineString.FromDbGeometry(element))
        Next
    End Sub
End Class
