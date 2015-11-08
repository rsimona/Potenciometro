Imports System.ComponentModel

Public Class Potenciometro
    Private _max As Double = 100
    Private _min As Double = 0
    Private _valor As Double = 0

    Private _porcentaje As Double = 0
    Public Event CambioValor(ByVal Porcentaje As Double)

    <DefaultValue(100), Description("Valor máximo del potenciómetro")>
    Public Property Max() As Double
        Get
            Return _max
        End Get
        Set(value As Double)
            _max = value
            recalcular()
        End Set
    End Property

    <DefaultValue(0), Description("Valor mínimo del potenciómetro")>
    Public Property Min() As Double
        Get
            Return _min
        End Get
        Set(value As Double)
            _min = value
            recalcular()
        End Set
    End Property

    <DefaultValue(0), Description("Valor del potenciómetro")>
    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            If value >= _min And value <= _max Then
                _valor = value - _min
            Else
                _valor = 0
            End If
            recalcular()
        End Set
    End Property

    Private Sub recalcular()
        Dim luces() As Label = {Percent0, Percent10, Percent20, Percent30, Percent40, Percent50, Percent60, Percent70, Percent80, Percent90}

        _porcentaje = (_valor * 100) / (_max - _min)

        If _porcentaje = 0 Then
            For i = 0 To 9
                luces(i).BackColor = Color.DarkGray
            Next
        ElseIf (_porcentaje > 0 And _porcentaje <= 10)
            luces(0).BackColor = Color.Chartreuse
            For i = 1 To 9
                luces(i).BackColor = Color.DarkGray
            Next
        ElseIf (_porcentaje > 10 And _porcentaje <= 20)
            For i = 0 To 1
                luces(i).BackColor = Color.Chartreuse
            Next
            For i = 2 To 9
                luces(i).BackColor = Color.DarkGray
            Next
        ElseIf (_porcentaje > 20 And _porcentaje <= 30)
            For i = 0 To 2
                luces(i).BackColor = Color.Chartreuse
            Next
            For i = 3 To 9
                luces(i).BackColor = Color.DarkGray
            Next
        ElseIf (_porcentaje > 30 And _porcentaje <= 40)
            For i = 0 To 3
                luces(i).BackColor = Color.Chartreuse
            Next
            For i = 4 To 9
                luces(i).BackColor = Color.DarkGray
            Next
        ElseIf (_porcentaje > 40 And _porcentaje <= 50)
            For i = 0 To 4
                luces(i).BackColor = Color.Chartreuse
            Next
            For i = 5 To 9
                luces(i).BackColor = Color.DarkGray
            Next
        ElseIf (_porcentaje > 50 And _porcentaje <= 60)
            For i = 0 To 5
                luces(i).BackColor = Color.Chartreuse
            Next
            For i = 6 To 9
                luces(i).BackColor = Color.DarkGray
            Next
        ElseIf (_porcentaje > 60 And _porcentaje <= 70)
            For i = 0 To 5
                luces(i).BackColor = Color.Chartreuse
            Next
            luces(6).BackColor = Color.Yellow
            For i = 7 To 9
                luces(i).BackColor = Color.DarkGray
            Next
        ElseIf (_porcentaje > 70 And _porcentaje <= 80)
            For i = 0 To 5
                luces(i).BackColor = Color.Chartreuse
            Next
            For i = 6 To 7
                luces(i).BackColor = Color.Yellow
            Next
            For i = 8 To 9
                luces(i).BackColor = Color.DarkGray
            Next
        ElseIf (_porcentaje > 80 And _porcentaje <= 90)
            For i = 0 To 5
                luces(i).BackColor = Color.Chartreuse
            Next
            For i = 6 To 8
                luces(i).BackColor = Color.Yellow
            Next
            luces(9).BackColor = Color.DarkGray
        ElseIf (_porcentaje > 90 And _porcentaje <= 100)
            For i = 0 To 5
                luces(i).BackColor = Color.Chartreuse
            Next
            For i = 6 To 8
                luces(i).BackColor = Color.Yellow
            Next
            luces(9).BackColor = Color.Red
        End If

        RaiseEvent CambioValor(_porcentaje)

    End Sub

    Private Sub Potenciometro_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout
        Select Case e.AffectedProperty
            Case "Bounds"
                Me.Height = CInt(Me.Width * 0.1)


        End Select
    End Sub

    Private Sub Potenciometro_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub
End Class
