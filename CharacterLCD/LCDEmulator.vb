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

Public Class LCDEmulator
    Inherits BaseCharacterLCD

    Private m_Frm As LCDEmulatorFrm
    Private GPOs As New Hashtable

    Public Overrides Function Initalize() As Boolean
        m_Frm = New LCDEmulatorFrm
        m_Frm.Show()
        m_Frm.SetText("")
    End Function

    Public Overrides Function ClearScreen() As Boolean
        m_Frm.SetText("")
    End Function

    Public Overrides Function CloseConnection() As Boolean
        m_Frm.Close()
    End Function

    Public Overrides Sub SetPortName(ByVal PortName As String)
    End Sub

    Public Overrides Function CreateCustomCharater(ByVal Id As Byte, ByVal Data() As Byte) As Boolean

    End Function

    Public Overrides Function GetModuleType() As String
        Return "Test LCD"
    End Function

    Public Overrides Function GetVersionNumber() As String
        Return "1"
    End Function

    Public Overrides Function MoveCursorBack() As Boolean

    End Function

    Public Overrides Function MoveCursorForward() As Boolean

    End Function

    Public Overrides Function PrintHorzBar(ByVal Column As Byte, ByVal Row As Byte, ByVal Direction As BarDirection, ByVal Length As Byte) As Boolean

    End Function

    Public Overrides Function PrintLargeNumber(ByVal Character As String, ByVal Column As Byte) As Boolean

    End Function

    Public Overrides Function PrintVerticalBar(ByVal Column As Byte, ByVal Length As Byte, ByVal Type As VerticalBarType) As Boolean

    End Function

    Public Overrides Function SetAutoLineWrap(ByVal AutoLineWrapOn As Boolean) As Boolean

    End Function

    Public Overrides Function SetAutoScroll(ByVal AutoScrollOn As Boolean) As Boolean

    End Function

    Public Overrides Function SetBackgroundBrightness(ByVal Brightness As Byte) As Boolean

    End Function

    Public Overrides Function SetBackgroundColor(ByVal Red As Byte, ByVal Green As Byte, ByVal Blue As Byte) As Boolean
        m_Frm.SetTextColor(Red, Green, Blue)
    End Function

    Public Overrides Function SetContrast(ByVal Contrast As Byte) As Boolean

    End Function

    Public Overrides Function SetCursorBlinking(ByVal BlinkingOn As Boolean) As Boolean

    End Function

    Public Overrides Function SetCursorHome() As Boolean

    End Function

    Public Overrides Function SetCursorPosition(ByVal Row As Byte, ByVal Column As Byte) As Boolean

    End Function

    Public Overrides Function SetCursorUnderline(ByVal UnderlineOn As Boolean) As Boolean

    End Function

    Public Overrides Function SetGPO(ByVal OutputNumber As Integer, ByVal State As GPOState) As Boolean
        SetGPOHash(OutputNumber, State)

        Select Case OutputNumber
            Case Is = 1, 2
                m_Frm.SetLED(GetColor(GPOs(1), GPOs(2)), 1)

            Case Is = 3, 4
                m_Frm.SetLED(GetColor(GPOs(3), GPOs(4)), 2)

            Case Is = 5, 6
                m_Frm.SetLED(GetColor(GPOs(5), GPOs(6)), 3)

        End Select
    End Function

    Private Sub SetGPOHash(ByVal Output As Integer, ByVal State As GPOState)
        If Not GPOs.ContainsKey(Output) Then
            GPOs.Add(Output, State)
        Else
            GPOs(Output) = State
        End If
    End Sub

    Private Function GetColor(ByVal Out1, ByVal Out2) As Drawing.Color
        If Out1 = 0 AndAlso Out2 = 0 Then
            Return Drawing.Color.Transparent
        ElseIf Out1 = 1 AndAlso Out2 = 0 Then
            Return Drawing.Color.Red
        ElseIf Out1 = 0 AndAlso Out2 = 1 Then
            Return Drawing.Color.Green
        End If

        Return Drawing.Color.Yellow
    End Function


    Public Overrides Function SetKeyPadBackLight(ByVal LightOn As Boolean) As Boolean

    End Function

    Public Overrides Function SetKeypadBrightness(ByVal Brightness As Byte) As Boolean

    End Function

    Public Overrides Function TurnScreenOff() As Boolean

    End Function

    Public Overrides Function TurnScreenOn() As Boolean

    End Function

    Public Overrides Function DisplayText(ByVal Text As String) As Boolean
        m_Frm.SetText(Text)
    End Function

    Public Overrides Function SaveStartupCustomCharater(ByVal Id As Byte, ByVal Data() As Byte) As Boolean

    End Function

    Public Overrides Function SaveStartupMessage(ByVal Data() As Byte) As Boolean

    End Function

    Public Overrides Function SetGPOStartupState(ByVal OutputNumber As Integer, ByVal State As GPOState) As Boolean

    End Function

    Public Overrides Function SetAndSaveKeypadBrightness(ByVal Brightness As Byte) As Boolean

    End Function
End Class
