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

Public Enum GPOState As Byte
    OffState = 0
    OnState = 1
End Enum

Public Enum LCDKey As Byte
    UpArrow = 1
    RightArrow = 2
    DownArrow = 3
    LeftArrow = 4
    Center = 5
    Enter = 6
    TopLeft = 7
    BottomLeft = 8
    Key0 = 10
    Key1 = 11
    Key2 = 12
    Key3 = 13
    Key4 = 14
    Key5 = 15
    Key6 = 16
    Key7 = 17
    Key8 = 18
    Key9 = 19
End Enum

Public Enum BarDirection As Byte
    Right = 1
    Left = 2
End Enum

Public Enum VerticalBarType As Byte
    Narrow = 1
    Wide = 2
End Enum


Public MustInherit Class BaseCharacterLCD

    Public Event KeyPressReceived(ByVal Key As LCDKey)

    Public MustOverride Function Initalize() As Boolean
    Public MustOverride Function CloseConnection() As Boolean
    Public MustOverride Sub SetPortName(ByVal PortName As String)
    Public MustOverride Function ClearScreen() As Boolean

    Public MustOverride Function SetBackgroundColor(ByVal Red As Byte, ByVal Green As Byte, ByVal Blue As Byte) As Boolean
    Public MustOverride Function SetBackgroundBrightness(ByVal Brightness As Byte) As Boolean
    Public MustOverride Function SetContrast(ByVal Contrast As Byte) As Boolean

    Public MustOverride Function SetRemember(ByVal Remember As Boolean) As Boolean

    Public MustOverride Function DisplayText(ByVal Text As String) As Boolean

    Public MustOverride Function SetAutoScroll(ByVal AutoScrollOn As Boolean) As Boolean
    Public MustOverride Function SetAutoLineWrap(ByVal AutoLineWrapOn As Boolean) As Boolean

    Public MustOverride Function SetCursorPosition(ByVal Row As Byte, ByVal Column As Byte) As Boolean
    Public MustOverride Function SetCursorHome() As Boolean
    Public MustOverride Function MoveCursorBack() As Boolean
    Public MustOverride Function MoveCursorForward() As Boolean

    Public MustOverride Function SetCursorUnderline(ByVal UnderlineOn As Boolean) As Boolean
    Public MustOverride Function SetCursorBlinking(ByVal BlinkingOn As Boolean) As Boolean

    Public MustOverride Function CreateCustomCharater(ByVal Id As Byte, ByVal Data() As Byte) As Boolean

    Public MustOverride Function SaveStartupCustomCharater(ByVal Id As Byte, ByVal Data() As Byte) As Boolean
    Public MustOverride Function SaveStartupMessage(ByVal Data() As Byte) As Boolean

    Public MustOverride Function PrintLargeNumber(ByVal Character As String, ByVal Column As Byte) As Boolean
    Public MustOverride Function PrintHorzBar(ByVal Column As Byte, ByVal Row As Byte, ByVal Direction As BarDirection, ByVal Length As Byte) As Boolean
    Public MustOverride Function PrintVerticalBar(ByVal Column As Byte, ByVal Length As Byte, ByVal Type As VerticalBarType) As Boolean

    Public MustOverride Function TurnScreenOn() As Boolean
    Public MustOverride Function TurnScreenOff() As Boolean

    Public MustOverride Function GetVersionNumber() As String
    Public MustOverride Function GetModuleType() As String

    Public MustOverride Function SetKeyPadBackLight(ByVal LightOn As Boolean) As Boolean
    Public MustOverride Function SetKeypadBrightness(ByVal Brightness As Byte) As Boolean
    Public MustOverride Function SetAndSaveKeypadBrightness(ByVal Brightness As Byte) As Boolean

    Public MustOverride Function SetGPO(ByVal OutputNumber As Integer, ByVal State As GPOState) As Boolean
    Public MustOverride Function SetGPOStartupState(ByVal OutputNumber As Integer, ByVal State As GPOState) As Boolean

    Protected Friend Sub RasieKeyPressed(ByVal Key As LCDKey)
        RaiseEvent KeyPressReceived(Key)
    End Sub

End Class
