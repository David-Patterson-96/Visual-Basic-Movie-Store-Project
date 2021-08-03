' Project name:             Film Project
' Project purpose:          Display total of movies ordered and total cost
' Created/revised by:       <David Patterson> on <12/8/16>
' Final project

Option Explicit On
Option Infer Off
Option Strict Off

Public Class Form1

    Private businessday() As Integer = {"3",
                                      "6",
                                      "9",
                                      "12"}

    ' fill list boxes with the price ranges of shipping
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        shippingListBox.Items.Add("$50")
        shippingListBox.Items.Add("$100")
        shippingListBox.Items.Add("$150")
        shippingListBox.Items.Add("+$200")
        shippingListBox.SelectedIndex = 0
    End Sub

    Private Sub shippingListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles shippingListBox.SelectedIndexChanged
        ' display associated amount of business days from bussinessday array

        Dim subscript As Integer = shippingListBox.SelectedIndex
        businessdayLabel.Text = businessday(subscript)
    End Sub

    Private Function Gettax(ByVal total As Double) As Double
        Dim pricewithtax As Double
        Dim statetax As Double
        statetax = 0.1
        pricewithtax = total * statetax
        Return pricewithtax
    End Function

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates total order and total price
        Const discountrate As Double = 0.1
        Dim tax As Integer
        Dim numberdvd As Integer
        Dim numberbluray As Integer
        Dim totalordered As Integer
        Dim dvd As Double
        Dim bluray As Double
        Dim discount As Double
        Dim totalprice As Double

        ' store user input in variables
        Integer.TryParse(numberdvdTextBox.Text, numberdvd)
        Integer.TryParse(numberblurayTextBox.Text, numberbluray)

        ' determine the price of dvd and blu-ray ordered
        If onediscdvdRadioButton.Checked Then
            dvd = 9.99
        End If
        If twodiscdvdRadioButton.Checked Then
            dvd = 19.99
        End If
        If blurayRadioButton.Checked Then
            bluray = 29.99
        End If
        If bluray3dRadioButton.Checked Then
            bluray = 34.99
        End If

        ' perform calulation
        totalordered = numberdvd + numberbluray
        totalprice = dvd * numberdvd + bluray * numberbluray
        If totalprice > 50 Then
            discount = totalprice * discountrate
            totalprice = totalprice - discount
        End If

        ' add tax
        tax = Gettax(totalprice)
        totalprice = totalprice + tax

        ' display calulation
        numbertotalorderedLabel.Text = totalordered.ToString
        numbertotalpriceLabel.Text = totalprice.ToString("C2")

        ' display "Thank You" message
        MessageBox.Show("Thank you for shopping at Jeff's Movie Store.", "Order sent",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles zipTextBox.KeyPress,
    numberdvdTextBox.KeyPress, numberblurayTextBox.KeyPress
        ' allow only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub ClearOrderMenuItem_Click(sender As Object, e As EventArgs) Handles ClearOrderMenuItem.Click
        nameTextBox.Text = String.Empty
        addressTextBox.Text = String.Empty
        cityTextBox.Text = String.Empty
        stateComboBox.Text = String.Empty
        zipTextBox.Text = String.Empty
        numberdvdTextBox.Text = String.Empty
        numberblurayTextBox.Text = String.Empty
        numbertotalorderedLabel.Text = String.Empty
        numbertotalpriceLabel.Text = String.Empty
        nameTextBox.Focus()
    End Sub

    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        ' saves the check information to a sequential access file

        Const Message As String =
            "Please enter name, address, city and zip"
        Const CoName As String = "Jeff's Movie Store"

        Dim CheckInfo As New Checkinfo
        Static firstTime As String = "Y"

        ' assign input to checkInfo, but only if each textbox contains data
        If nameTextBox.Text <> String.Empty AndAlso
        addressTextBox.Text <> String.Empty AndAlso
        cityTextBox.Text <> String.Empty AndAlso
        zipTextBox.Text <> String.Empty Then
            CheckInfo.Name = nameTextBox.Text
            CheckInfo.Address = addressTextBox.Text
            CheckInfo.City = cityTextBox.Text
            CheckInfo.Zip = zipTextBox.Text


            If firstTime = "Y" Then
                Dim button As DialogResult
                button = MessageBox.Show("Create a new file?", CoName, MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                If button = DialogResult.Yes Then CheckInfo.SaveCheckInfo("Movie.txt", True)
            Else
                CheckInfo.SaveCheckInfo("Movie.txt", False)
            End If
            firstTime = "N"
        Else
            MessageBox.Show(Message, CoName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        nameTextBox.Focus()
    End Sub
End Class
