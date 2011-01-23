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

Public Class LCDEmulatorFrm
    Private m_RawText As String = ""

    Public Sub SetText(ByVal Text As String)
        m_RawText &= Text
        If m_RawText.Length > 80 Then
            m_RawText = m_RawText.Substring(m_RawText.Length - 80)
        End If

        If m_RawText.Length > 20 Then
            Label1.Text = m_RawText.Substring(0, 20)
            If m_RawText.Length > 40 Then
                Label1.Text &= ControlChars.NewLine & m_RawText.Substring(20, 20)
                If m_RawText.Length > 60 Then
                    Label1.Text &= ControlChars.NewLine & m_RawText.Substring(40, 20)
                    If m_RawText.Length > 59 Then
                        Label1.Text &= ControlChars.NewLine & m_RawText.Substring(60)
                    End If
                Else
                    Label1.Text &= ControlChars.NewLine & m_RawText.Substring(40)
                End If
            Else
                Label1.Text &= ControlChars.NewLine & m_RawText.Substring(20)
            End If
        Else
            Label1.Text = m_RawText
        End If
    End Sub

    Public Sub SetTextColor(ByVal Red As Byte, ByVal Green As Byte, ByVal Blue As Byte)
        Label1.ForeColor = Drawing.Color.FromArgb(CInt(Red), CInt(Green), CInt(Blue))
    End Sub

    Public Sub SetLED(ByVal Clr As Drawing.Color, ByVal LED As Integer)
        Select Case LED
            Case Is = 1
                led1.BackColor = Clr
            Case Is = 2
                led2.BackColor = Clr
            Case Is = 3
                led3.BackColor = Clr
        End Select
    End Sub

End Class