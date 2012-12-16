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

Imports System.IO.Ports

Public Class MatrixObrital
    Inherits BaseCharacterLCD

    Private WithEvents m_Port As SerialPort
    Private m_ComPort As String

    Public Overrides Function Initalize() As Boolean
        If Not String.isnullorempty(m_comport) Then
            m_Port = New SerialPort(m_ComPort, 19200, Parity.None, 8, StopBits.One)
            m_Port.Open()
        End If
    End Function

    Public Overrides Function CloseConnection() As Boolean
        m_Port.Close()
    End Function

    Public Overrides Function ClearScreen() As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.ClearScreen)
    End Function

    Public Overrides Function DisplayText(ByVal Text As String) As Boolean
        Dim Txt() As Byte = System.Text.Encoding.ASCII.GetBytes(Text)
        If Text.Contains("°") Then  'Convert this to a MatrixOrbital Character
            For i As Integer = 0 To Txt.Length - 1
                If Txt(i) = 63 Then
                    Txt(i) = 223
                End If
            Next
        End If
        Return WriteData(Txt)
    End Function

    Public Overrides Function CreateCustomCharater(ByVal Id As Byte, ByVal Data() As Byte) As Boolean

    End Function

    Public Overrides Function GetModuleType() As String

    End Function

    Public Overrides Function GetVersionNumber() As String

    End Function

    Public Overrides Function MoveCursorBack() As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.MoveCursorBack)
    End Function

    Public Overrides Function MoveCursorForward() As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.MoveCursorForward)
    End Function

    Public Overrides Function PrintHorzBar(ByVal Column As Byte, ByVal Row As Byte, ByVal Direction As BarDirection, ByVal Length As Byte) As Boolean

    End Function

    Public Overrides Function PrintLargeNumber(ByVal Character As String, ByVal Column As Byte) As Boolean

    End Function

    Public Overrides Function PrintVerticalBar(ByVal Column As Byte, ByVal Length As Byte, ByVal Type As VerticalBarType) As Boolean

    End Function

    Public Overrides Function SetAutoLineWrap(ByVal AutoLineWrapOn As Boolean) As Boolean
        If AutoLineWrapOn Then
            Return WriteData(Cmd.CommandStart, Cmd.LineWrapOn)
        Else
            Return WriteData(Cmd.CommandStart, Cmd.LineWrapOff)
        End If
    End Function

    Public Overrides Function SetAutoScroll(ByVal AutoScrollOn As Boolean) As Boolean
        If AutoScrollOn Then
            Return WriteData(Cmd.CommandStart, Cmd.AutoScrollOn)
        Else
            Return WriteData(Cmd.CommandStart, Cmd.AutoScrollOff)
        End If
    End Function

    Public Overrides Function SetBackgroundBrightness(ByVal Brightness As Byte) As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.SetAndSaveBrightness, Brightness)
    End Function

    Public Overrides Function SetBackgroundColor(ByVal Red As Byte, ByVal Green As Byte, ByVal Blue As Byte) As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.SetBacklightBaseColor, Red, Green, Blue)
    End Function

    Public Overrides Function SetContrast(ByVal Contrast As Byte) As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.SetContrast, Contrast)
    End Function

    Public Overrides Function SetCursorBlinking(ByVal BlinkingOn As Boolean) As Boolean
        If BlinkingOn Then
            Return WriteData(Cmd.CommandStart, Cmd.BlinkCursorOn)
        Else
            Return WriteData(Cmd.CommandStart, Cmd.BlinkCursorOff)
        End If
    End Function

    Public Overrides Function SetCursorHome() As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.GoHome)
    End Function

    Public Overrides Function SetCursorPosition(ByVal Row As Byte, ByVal Column As Byte) As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.SetCursorPosition, Column, Row)
    End Function

    Public Overrides Function SetCursorUnderline(ByVal UnderlineOn As Boolean) As Boolean
        If UnderlineOn Then
            Return WriteData(Cmd.CommandStart, Cmd.UnderLineCursosOn)
        Else
            Return WriteData(Cmd.CommandStart, Cmd.UnderLineCursosOff)
        End If
    End Function

    Public Overrides Function SetGPO(ByVal OutputNumber As Integer, ByVal State As GPOState) As Boolean
        If State = GPOState.OnState Then
            Return WriteData(Cmd.CommandStart, Cmd.GPOOn, OutputNumber)
        Else
            Return WriteData(Cmd.CommandStart, Cmd.GPOOff, OutputNumber)
        End If
    End Function

    Public Overrides Function SetGPOStartupState(ByVal OutputNumber As Integer, ByVal State As GPOState) As Boolean
        If State = GPOState.OnState Then
            Return WriteData(Cmd.CommandStart, Cmd.GPOSetStartupState, OutputNumber, 1)
        Else
            Return WriteData(Cmd.CommandStart, Cmd.GPOSetStartupState, OutputNumber, 0)
        End If
    End Function

    Public Overrides Function SetKeyPadBackLight(ByVal LightOn As Boolean) As Boolean
        If LightOn Then
            Return WriteData(Cmd.CommandStart, Cmd.SetAndSaveBrightness, 255)
        End If
        Return WriteData(Cmd.CommandStart, Cmd.KeypadBacklightOff)
    End Function

    Public Overrides Function SetKeypadBrightness(ByVal Brightness As Byte) As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.SetKeypadBrightness, Brightness)
    End Function

    Public Overrides Function SetAndSaveKeypadBrightness(ByVal Brightness As Byte) As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.SetAndSaveKeypadBrightness, Brightness)
    End Function

    Public Overrides Function TurnScreenOff() As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.DisplayOff)
    End Function

    Public Overrides Function TurnScreenOn() As Boolean
        Return WriteData(Cmd.CommandStart, Cmd.DisplayOn, 0)
    End Function

    Public Overrides Function SaveStartupCustomCharater(ByVal Id As Byte, ByVal Data() As Byte) As Boolean
        WriteData(Cmd.CommandStart, Cmd.SaveCustomStartupChar, Id)
        For Each bt As Byte In Data
            WriteData(bt)
        Next
    End Function

    Public Overrides Function SaveStartupMessage(ByVal Data() As Byte) As Boolean
        WriteData(Cmd.CommandStart, Cmd.SaveStartupText)
        For Each bt As Byte In Data
            WriteData(bt)
        Next
    End Function

    Public Overrides Function SetRemember(ByVal Remember As Boolean) As Boolean
        If Remember Then
            Return WriteData(Cmd.CommandStart, Cmd.Remember, 1)
        End If
        Return WriteData(Cmd.CommandStart, Cmd.Remember, 0)
    End Function

    Public Function WriteData(ByVal ParamArray Cmd As Byte()) As Boolean
        If m_Port Is Nothing OrElse (Not m_Port.IsOpen) Then
            Return False
        End If
        m_Port.Write(Cmd, 0, Cmd.Length)
        Return True
    End Function

    Public Overrides Sub SetPortName(ByVal PortName As String)
        m_ComPort = PortName
    End Sub

    Enum Cmd As Byte
        CommandStart = 254


        AutoScrollOn = 81
        AutoScrollOff = 82
        ClearScreen = 88
        ChangeStartUpScreen = 64
        LineWrapOn = 67
        LineWrapOff = 68
        SetCursorPosition = 71
        GoHome = 72
        MoveCursorBack = 76
        MoveCursorForward = 77
        UnderLineCursosOn = 74
        UnderLineCursosOff = 75
        BlinkCursorOn = 83
        BlinkCursorOff = 84


        InitHorzBar = 104
        PlaceHorzBar = 124
        InitNarrowVertBar = 115
        InitWideVertBar = 118
        PlaceVertBar = 61

        GPOOff = 86
        GPOOn = 87
        GPOSetStartupState = 195


        DisplayOn = 66
        DisplayOff = 70
        SetBrightness = 153
        SetAndSaveBrightness = 152
        SetBacklightBaseColor = 130
        SetContrast = 80
        SetAndSaveContrast = 145

        SaveCustomStartupChar = 194
        SaveStartupText = 64


        ReadVersionNumber = 54
        ReadModuleType = 55

        PlaceLargeNumber = 35
        PollKeyPress = 38
        SetAndSaveKeypadBrightness = 157
        SetKeypadBrightness = 156
        KeypadBacklightOff = 155

        Remember = 147
    End Enum

    Enum Button As Byte
        TopLeft = &H41
        UpArrow = &H42
        RightArrow = &H43
        LeftArrow = &H44
        Center = &H45
        BottomLeft = &H47
        DownArrow = &H48
    End Enum

    Private Sub m_Port_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles m_Port.DataReceived
        Dim Data As Byte = m_Port.ReadByte()

        Select Case Data
            Case Is = Button.TopLeft
                RasieKeyPressed(LCDKey.TopLeft)
            Case Is = Button.UpArrow
                RasieKeyPressed(LCDKey.UpArrow)
            Case Is = Button.RightArrow
                RasieKeyPressed(LCDKey.RightArrow)
            Case Is = Button.LeftArrow
                RasieKeyPressed(LCDKey.LeftArrow)
            Case Is = Button.Center
                RasieKeyPressed(LCDKey.Center)
            Case Is = Button.BottomLeft
                RasieKeyPressed(LCDKey.BottomLeft)
            Case Is = Button.DownArrow
                RasieKeyPressed(LCDKey.DownArrow)
        End Select

    End Sub

End Class