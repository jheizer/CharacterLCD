#Region "GPL"
'    This file is part of CharacterLCD.

'    CharacterLCD is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.

'    CharacterLCD is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.

'    You should have received a copy of the GNU General Public License
'    along with OpenMobile.  If not, see <http://www.gnu.org/licenses/>.

'    Copyright 2010-2011 Jonathan Heizer jheizer@gmail.com
#End Region

Public Class Form1
    Dim WithEvents LCD As CharacterLCD.BaseCharacterLCD

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            comport.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames)
            If comport.Items.Count > 0 Then
                comport.SelectedIndex = 0
                connect_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connect.Click
        LCD = New CharacterLCD.MatrixObrital
        LCD.SetPortName(comport.SelectedItem)
        LCD.Initalize()

        LCD.SaveStartupCustomCharater(0, New Byte() {0, 1, 6, 8, 9, 18, 28, 28})
        LCD.SaveStartupCustomCharater(1, New Byte() {15, 16, 7, 24, 0, 0, 24, 12})
        LCD.SaveStartupCustomCharater(2, New Byte() {30, 1, 28, 3, 0, 0, 6, 12})
        LCD.SaveStartupCustomCharater(3, New Byte() {0, 16, 12, 2, 18, 9, 5, 7})
        LCD.SaveStartupCustomCharater(4, New Byte() {28, 4, 2, 1, 0, 0, 0, 0})
        LCD.SaveStartupCustomCharater(5, New Byte() {0, 0, 0, 3, 24, 7, 0, 0})
        LCD.SaveStartupCustomCharater(6, New Byte() {0, 0, 24, 0, 3, 28, 0, 0})
        LCD.SaveStartupCustomCharater(7, New Byte() {7, 4, 8, 48, 0, 0, 0, 0})

        LCD.SaveStartupMessage(New Byte() {32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, _
                                           32, 32, 32, 0, 1, 2, 3, 32, 32, 79, 80, 69, 78, 32, 32, 32, 32, 32, 32, 32, _
                                           32, 32, 32, 4, 5, 6, 7, 32, 32, 32, 32, 77, 79, 66, 73, 76, 69, 32, 32, 32, _
                                           32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32})

        LCD.SetGPOStartupState(0, CharacterLCD.GPOState.OffState)
        LCD.SetGPOStartupState(1, CharacterLCD.GPOState.OffState)
        LCD.SetGPOStartupState(2, CharacterLCD.GPOState.OffState)
        LCD.SetGPOStartupState(3, CharacterLCD.GPOState.OffState)
        LCD.SetGPOStartupState(4, CharacterLCD.GPOState.OffState)
        LCD.SetGPOStartupState(5, CharacterLCD.GPOState.OffState)
        LCD.SetGPOStartupState(6, CharacterLCD.GPOState.OffState)
        LCD.SetGPOStartupState(7, CharacterLCD.GPOState.OffState)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LCD = New CharacterLCD.LCDEmulator
        LCD.Initalize()
    End Sub

    Private Sub turnon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turnon.Click
        LCD.TurnScreenOn()
    End Sub


    Private Sub turnoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turnoff.Click
        LCD.TurnScreenOff()
    End Sub

    Private Sub led1red_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led1red.CheckedChanged
        LCD.SetGPO(1, CharacterLCD.GPOState.OnState)
        LCD.SetGPO(2, CharacterLCD.GPOState.OffState)
    End Sub

    Private Sub led1green_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led1green.CheckedChanged
        LCD.SetGPO(1, CharacterLCD.GPOState.OffState)
        LCD.SetGPO(2, CharacterLCD.GPOState.OnState)
    End Sub

    Private Sub led1yellow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led1yellow.CheckedChanged
        LCD.SetGPO(1, CharacterLCD.GPOState.OnState)
        LCD.SetGPO(2, CharacterLCD.GPOState.OnState)
    End Sub

    Private Sub led1off_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led1off.CheckedChanged
        LCD.SetGPO(1, CharacterLCD.GPOState.OffState)
        LCD.SetGPO(2, CharacterLCD.GPOState.OffState)
    End Sub

    Private Sub led2red_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led2red.CheckedChanged
        LCD.SetGPO(3, CharacterLCD.GPOState.OnState)
        LCD.SetGPO(4, CharacterLCD.GPOState.OffState)
    End Sub

    Private Sub led2green_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led2green.CheckedChanged
        LCD.SetGPO(3, CharacterLCD.GPOState.OffState)
        LCD.SetGPO(4, CharacterLCD.GPOState.OnState)
    End Sub

    Private Sub led2yellow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led2yellow.CheckedChanged
        LCD.SetGPO(3, CharacterLCD.GPOState.OnState)
        LCD.SetGPO(4, CharacterLCD.GPOState.OnState)
    End Sub

    Private Sub led2off_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led2off.CheckedChanged
        LCD.SetGPO(3, CharacterLCD.GPOState.OffState)
        LCD.SetGPO(4, CharacterLCD.GPOState.OffState)
    End Sub

    Private Sub led3red_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led3red.CheckedChanged
        LCD.SetGPO(5, CharacterLCD.GPOState.OnState)
        LCD.SetGPO(6, CharacterLCD.GPOState.OffState)
    End Sub

    Private Sub led3green_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led3green.CheckedChanged
        LCD.SetGPO(5, CharacterLCD.GPOState.OffState)
        LCD.SetGPO(6, CharacterLCD.GPOState.OnState)
    End Sub

    Private Sub led3yellow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led3yellow.CheckedChanged
        LCD.SetGPO(5, CharacterLCD.GPOState.OnState)
        LCD.SetGPO(6, CharacterLCD.GPOState.OnState)
    End Sub

    Private Sub led3off_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles led3off.CheckedChanged
        LCD.SetGPO(5, CharacterLCD.GPOState.OffState)
        LCD.SetGPO(6, CharacterLCD.GPOState.OffState)
    End Sub

    Private Sub brightness_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brightness.Scroll
        LCD.SetBackgroundBrightness(brightness.Value)
    End Sub

    Private Sub contrast_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contrast.Scroll
        LCD.SetContrast(contrast.Value)
    End Sub

    Private Sub red_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles red.Scroll
        LCD.SetBackgroundColor(red.Value, green.Value, blue.Value)
    End Sub

    Private Sub green_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles green.Scroll
        LCD.SetBackgroundColor(red.Value, green.Value, blue.Value)
    End Sub

    Private Sub blue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blue.Scroll
        LCD.SetBackgroundColor(red.Value, green.Value, blue.Value)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LCD.DisplayText(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LCD.ClearScreen()
    End Sub

    Private Sub KeypadBrightness_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeypadBrightness.Scroll
        LCD.SetKeypadBrightness(KeypadBrightness.Value)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ary As New Generic.List(Of Sen)
        For i As Integer = 0 To 31
            ary.Add(New Sen("CPU", i * 12))
        Next

        Dim index As Integer = 0
        Dim todisplay As String = ""

        While 1 = 1
            todisplay = ""
            For i As Integer = 0 To 7
                todisplay &= formatsen(ary(index + i))
            Next

            LCD.DisplayText(todisplay)

            index += 8
            index = index Mod 32

            Threading.Thread.Sleep(3000)
        End While
    End Sub

    Private Function formatsen(ByVal s As Sen) As String
        Dim len As Integer = 10 - (s.name.Length + s.val.Length)
        Return s.name & "          ".Substring(0, len) & s.val
    End Function

    Private Class Sen
        Public name As String
        Public val As String

        Public Sub New(ByVal Nm As String, ByVal v As String)
            name = Nm
            val = v
        End Sub
    End Class

    Delegate Sub UpdateKey(ByVal key As String)

    Private Sub LCD_KeyPressReceived(ByVal Key As CharacterLCD.LCDKey) Handles LCD.KeyPressReceived
        Dim fun As New UpdateKey(AddressOf UpdateKeys)
        Keys.BeginInvoke(fun, New Object() {Key.ToString})
    End Sub

    Private Sub UpdateKeys(ByVal Key As String)
        Keys.Text = Key & ControlChars.NewLine & Keys.Text
    End Sub
End Class
