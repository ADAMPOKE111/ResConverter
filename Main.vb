'' Made by Adam Macdonald on 15th August 2015

Public Class Main

    Public Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btConvTo43_Click(sender As Object, e As EventArgs) Handles btConvTo43.Click
        '' Declare Variables
        Dim WidthTo43 As Integer
        Dim HeightTo43 As Integer
        Dim NewWidth43 As Double
        Dim NewWidthMod43 As Double
        Dim NewHeight43 As Double
        Dim NewHeightMod43 As Double

        '' If The "Keep Width Constant" Radio Button is Checked - run the below section
        If radWidth.Checked Then
            If tbWidthTo43.Text = "" Then
                tbWidthTo43.Text = "0"
            End If
            If tbHeightTo43.Text = "" Then
                tbHeightTo43.Text = "0"
            End If

            WidthTo43 = tbWidthTo43.Text
            HeightTo43 = tbHeightTo43.Text

            If WidthTo43 / HeightTo43 < "1.777777777777777" Then '' Check if the user's input is correct
                MsgBox("The resolution you entered is not a true 16:9 resolution and will produce odd results when converting to 4:3, check you haven't entered a 16:10 resolution like 1920x1200.", MsgBoxStyle.Critical)
            End If

            NewWidth43 = WidthTo43 '' Keep Width Constant
            NewHeight43 = WidthTo43 / 1.333333333333333 '' 1.33... is the multiplier for 4:3 resolutions, this can be calculated by doing 4/3 on a calculator
            NewHeightMod43 = Math.Truncate(NewHeight43) '' When calculating with non-standard resolutions (i.e. 1366x768) the 4:3 version would end up as 1366x1025 or 1024.5 which is incorrect, using 'Truncate' allows us to remove the decimal place(s).

            If NewWidth43 / NewHeightMod43 < "1.333333333333333" Then
                MsgBox("Warning! It has been detected that the calculated resolution is not true 4:3 or there has been a miscalculation, please send details of this to adampoke111@gmail.com", MsgBoxStyle.Critical)
            End If

            tbResultTo43.Text = NewWidth43 & "x" & NewHeightMod43
        End If

        '' If The "Keep Height Constant" Radio Button is Checked - run the below section
        If radHeight.Checked Then
            If tbWidthTo43.Text = "" Then
                tbWidthTo43.Text = "0"
            End If
            If tbHeightTo43.Text = "" Then
                tbHeightTo43.Text = "0"
            End If

            WidthTo43 = tbWidthTo43.Text
            HeightTo43 = tbHeightTo43.Text

            If WidthTo43 / HeightTo43 < "1.777777777777777" Then '' Check if the user's input is correct
                MsgBox("The resolution you entered is not a true 16:9 resolution and will produce odd results when converting to 4:3, check you haven't entered a 16:10 resolution like 1920x1200.", MsgBoxStyle.Critical)
            End If

            NewHeight43 = HeightTo43 '' Keep Height Constant
            NewWidth43 = WidthTo43 / 1.333333333333333 '' 1.33... is the multiplier for 4:3 resolutions, this can be calculated by doing 4/3 on a calculator
            NewWidthMod43 = Math.Truncate(NewWidth43) '' When calculating with non-standard resolutions (i.e. 1366x768) the 4:3 version would end up as 1366x1025 or 1024.5 which is incorrect, using 'Truncate' allows us to remove the decimal place(s).

            If NewWidthMod43 / NewHeight43 < "1.333333333333333" Then
                MsgBox("Warning! It has been detected that the calculated resolution is not true 4:3 or there has been a miscalculation, please send details of this to adampoke111@gmail.com", MsgBoxStyle.Critical)
            End If

            tbResultTo43.Text = NewWidthMod43 & "x" & NewHeight43
        End If
    End Sub

    Private Sub btConvTo169_Click(sender As Object, e As EventArgs) Handles btConvTo169.Click
        '' Declare Variables
        Dim WidthTo169 As Integer
        Dim HeightTo169 As Integer
        Dim NewWidth169 As Double
        Dim NewWidthMod169 As Double
        Dim NewHeight169 As Double
        Dim NewHeightMod169 As Double

        '' If The "Keep Width Constant" Radio Button is Checked - run the below section
        If radWidth.Checked Then
            If tbWidthTo169.Text = "" Then
                tbWidthTo169.Text = "0"
            End If
            If tbHeightTo169.Text = "" Then
                tbHeightTo169.Text = "0"
            End If

            WidthTo169 = tbWidthTo169.Text
            HeightTo169 = tbHeightTo169.Text

            If WidthTo169 / HeightTo169 < "1.33333333333333333333333" Then '' Check if the user's input is correct
                MsgBox("The resolution you entered is not a true 4:3 resolution and will produce odd results when converting to 16:9, check you haven't entered a 5:4 resolution like 1280x1024.", MsgBoxStyle.Critical)
            End If

            NewWidth169 = WidthTo169 '' Keep Width Constant
            NewHeight169 = HeightTo169 / 1.3333333333333 '' 1.78... is the multiplier for 16:9 resolutions, this can be calculated by doing 16/9 on a calculator - however when keeping the width constant we use the 4:3 multiplier along with the height to get a 16:9 resolution.
            NewHeightMod169 = Math.Truncate(NewHeight169) '' When calculating with non-standard resolutions (i.e. 1024x768) the 16:9 version would end up as 1365.33x768 which is incorrect, using 'Truncate' allows us to remove the decimal place(s).

            If NewWidth169 / NewHeightMod169 < "1.777777777777777777777778" Then '' Check if the calculated resolution is true 16:9 and warn the user if not
                MsgBox("Warning! It has been detected that the calculated resolution is not true 16:9 or there has been a miscalculation, please send details of this to adampoke111@gmail.com", MsgBoxStyle.Critical)
            End If

            tbResultTo169.Text = NewWidth169 & "x" & NewHeightMod169
        End If

        '' If The "Keep Height Constant" Radio Button is Checked - run the below section
        If radHeight.Checked Then
            If tbWidthTo169.Text = "" Then
                tbWidthTo169.Text = "0"
            End If
            If tbHeightTo169.Text = "" Then
                tbHeightTo169.Text = "0"
            End If

            WidthTo169 = tbWidthTo169.Text
            HeightTo169 = tbHeightTo169.Text

            If WidthTo169 / HeightTo169 < "1.33333333333333333333333" Then '' Check if the user's input is correct
                MsgBox("The resolution you entered is not a true 4:3 resolution and will produce odd results when converting to 16:9, check you haven't entered a 5:4 resolution like 1280x1024.", MsgBoxStyle.Critical)
            End If

            NewHeight169 = HeightTo169 '' Keep Height Constant
            NewWidth169 = HeightTo169 * 1.77777777777778 '' 1.78... is the multiplier for 16:9 resolutions, this can be calculated by doing 16/9 on a calculator
            NewWidthMod169 = Math.Truncate(NewWidth169) '' When calculating with non-standard resolutions (i.e. 1024x768) the 16:9 version would end up as 1365.33x768 which is incorrect, using 'Truncate' allows us to remove the decimal place(s).

            If NewWidthMod169 = "1365" Then '' Simple If Statement to catch that pesky laptop resolution that isn't perfect 16:9
                NewWidthMod169 = "1366"
            End If

            If NewWidthMod169 / NewHeight169 < "1.777777777777777777777778" Then '' Check if the calculated resolution is true 16:9 and warn the user if not
                MsgBox("Warning! It has been detected that the calculated resolution is not true 16:9 or there has been a miscalculation, please send details of this to adampoke111@gmail.com", MsgBoxStyle.Critical)
            End If

            tbResultTo169.Text = NewWidthMod169 & "x" & NewHeight169
        End If
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        tbHeightTo169.Text = ""
        tbHeightTo43.Text = ""
        tbResultTo169.Text = ""
        tbResultTo43.Text = ""
        tbWidthTo169.Text = ""
        tbWidthTo43.Text = ""
    End Sub
End Class
