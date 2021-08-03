<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.totalpriceLabel = New System.Windows.Forms.Label()
        Me.totalorderedLabel = New System.Windows.Forms.Label()
        Me.numberblurayTextBox = New System.Windows.Forms.TextBox()
        Me.numberdvdTextBox = New System.Windows.Forms.TextBox()
        Me.dvdPictureBox = New System.Windows.Forms.PictureBox()
        Me.stateComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.zipLabel = New System.Windows.Forms.Label()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.blurayPictureBox = New System.Windows.Forms.PictureBox()
        Me.blurayGroupBox = New System.Windows.Forms.GroupBox()
        Me.blurayRadioButton = New System.Windows.Forms.RadioButton()
        Me.bluray3dRadioButton = New System.Windows.Forms.RadioButton()
        Me.dvdGroupBox = New System.Windows.Forms.GroupBox()
        Me.onediscdvdRadioButton = New System.Windows.Forms.RadioButton()
        Me.twodiscdvdRadioButton = New System.Windows.Forms.RadioButton()
        Me.numbertotalorderedLabel = New System.Windows.Forms.Label()
        Me.numbertotalpriceLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearOrderMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintOrderMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.shippingListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.businessdayLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.saveButton = New System.Windows.Forms.Button()
        CType(Me.dvdPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blurayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.blurayGroupBox.SuspendLayout()
        Me.dvdGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(563, 81)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 44
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(23, 31)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 29
        Me.nameLabel.Text = "&Name"
        '
        'totalpriceLabel
        '
        Me.totalpriceLabel.AutoSize = True
        Me.totalpriceLabel.Location = New System.Drawing.Point(424, 306)
        Me.totalpriceLabel.Name = "totalpriceLabel"
        Me.totalpriceLabel.Size = New System.Drawing.Size(58, 13)
        Me.totalpriceLabel.TabIndex = 43
        Me.totalpriceLabel.Text = "Total Price"
        '
        'totalorderedLabel
        '
        Me.totalorderedLabel.AutoSize = True
        Me.totalorderedLabel.Location = New System.Drawing.Point(424, 247)
        Me.totalorderedLabel.Name = "totalorderedLabel"
        Me.totalorderedLabel.Size = New System.Drawing.Size(72, 13)
        Me.totalorderedLabel.TabIndex = 42
        Me.totalorderedLabel.Text = "Total Ordered"
        '
        'numberblurayTextBox
        '
        Me.numberblurayTextBox.Location = New System.Drawing.Point(415, 193)
        Me.numberblurayTextBox.Name = "numberblurayTextBox"
        Me.numberblurayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.numberblurayTextBox.TabIndex = 41
        Me.numberblurayTextBox.Text = "Enter # of Blu-Rays"
        '
        'numberdvdTextBox
        '
        Me.numberdvdTextBox.Location = New System.Drawing.Point(415, 103)
        Me.numberdvdTextBox.Name = "numberdvdTextBox"
        Me.numberdvdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.numberdvdTextBox.TabIndex = 40
        Me.numberdvdTextBox.Text = "Enter  # of DVDs"
        '
        'dvdPictureBox
        '
        Me.dvdPictureBox.Image = Global.Film_Project.My.Resources.Resources.DVD_logo
        Me.dvdPictureBox.Location = New System.Drawing.Point(415, 47)
        Me.dvdPictureBox.Name = "dvdPictureBox"
        Me.dvdPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.dvdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dvdPictureBox.TabIndex = 33
        Me.dvdPictureBox.TabStop = False
        '
        'stateComboBox
        '
        Me.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stateComboBox.FormattingEnabled = True
        Me.stateComboBox.Items.AddRange(New Object() {"", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.stateComboBox.Location = New System.Drawing.Point(26, 192)
        Me.stateComboBox.Name = "stateComboBox"
        Me.stateComboBox.Size = New System.Drawing.Size(42, 21)
        Me.stateComboBox.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Save 10% on your total when you order over $50 of movies!"
        '
        'zipLabel
        '
        Me.zipLabel.AutoSize = True
        Me.zipLabel.Location = New System.Drawing.Point(144, 176)
        Me.zipLabel.Name = "zipLabel"
        Me.zipLabel.Size = New System.Drawing.Size(22, 13)
        Me.zipLabel.TabIndex = 38
        Me.zipLabel.Text = "&Zip"
        '
        'stateLabel
        '
        Me.stateLabel.AutoSize = True
        Me.stateLabel.Location = New System.Drawing.Point(23, 176)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(32, 13)
        Me.stateLabel.TabIndex = 37
        Me.stateLabel.Text = "&State"
        '
        'cityLabel
        '
        Me.cityLabel.AutoSize = True
        Me.cityLabel.Location = New System.Drawing.Point(23, 132)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(24, 13)
        Me.cityLabel.TabIndex = 34
        Me.cityLabel.Text = "Cit&y"
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Location = New System.Drawing.Point(23, 81)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(45, 13)
        Me.addressLabel.TabIndex = 31
        Me.addressLabel.Text = "&Address"
        '
        'zipTextBox
        '
        Me.zipTextBox.Location = New System.Drawing.Point(144, 192)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(103, 20)
        Me.zipTextBox.TabIndex = 39
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(26, 148)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(221, 20)
        Me.cityTextBox.TabIndex = 36
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(26, 97)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(221, 20)
        Me.addressTextBox.TabIndex = 32
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(26, 47)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(221, 20)
        Me.nameTextBox.TabIndex = 30
        '
        'blurayPictureBox
        '
        Me.blurayPictureBox.Image = Global.Film_Project.My.Resources.Resources.Blu_Ray_logo
        Me.blurayPictureBox.Location = New System.Drawing.Point(415, 132)
        Me.blurayPictureBox.Name = "blurayPictureBox"
        Me.blurayPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.blurayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blurayPictureBox.TabIndex = 35
        Me.blurayPictureBox.TabStop = False
        '
        'blurayGroupBox
        '
        Me.blurayGroupBox.Controls.Add(Me.blurayRadioButton)
        Me.blurayGroupBox.Controls.Add(Me.bluray3dRadioButton)
        Me.blurayGroupBox.Location = New System.Drawing.Point(281, 129)
        Me.blurayGroupBox.Name = "blurayGroupBox"
        Me.blurayGroupBox.Size = New System.Drawing.Size(128, 60)
        Me.blurayGroupBox.TabIndex = 55
        Me.blurayGroupBox.TabStop = False
        '
        'blurayRadioButton
        '
        Me.blurayRadioButton.AutoSize = True
        Me.blurayRadioButton.Location = New System.Drawing.Point(4, 12)
        Me.blurayRadioButton.Name = "blurayRadioButton"
        Me.blurayRadioButton.Size = New System.Drawing.Size(104, 17)
        Me.blurayRadioButton.TabIndex = 23
        Me.blurayRadioButton.TabStop = True
        Me.blurayRadioButton.Text = "&Blu-Ray ($29.99)"
        Me.blurayRadioButton.UseVisualStyleBackColor = True
        '
        'bluray3dRadioButton
        '
        Me.bluray3dRadioButton.AutoSize = True
        Me.bluray3dRadioButton.Location = New System.Drawing.Point(4, 37)
        Me.bluray3dRadioButton.Name = "bluray3dRadioButton"
        Me.bluray3dRadioButton.Size = New System.Drawing.Size(121, 17)
        Me.bluray3dRadioButton.TabIndex = 24
        Me.bluray3dRadioButton.TabStop = True
        Me.bluray3dRadioButton.Text = "Blu-Ray &3D ($34.99)"
        Me.bluray3dRadioButton.UseVisualStyleBackColor = True
        '
        'dvdGroupBox
        '
        Me.dvdGroupBox.Controls.Add(Me.onediscdvdRadioButton)
        Me.dvdGroupBox.Controls.Add(Me.twodiscdvdRadioButton)
        Me.dvdGroupBox.Location = New System.Drawing.Point(281, 43)
        Me.dvdGroupBox.Name = "dvdGroupBox"
        Me.dvdGroupBox.Size = New System.Drawing.Size(128, 61)
        Me.dvdGroupBox.TabIndex = 54
        Me.dvdGroupBox.TabStop = False
        '
        'onediscdvdRadioButton
        '
        Me.onediscdvdRadioButton.AutoSize = True
        Me.onediscdvdRadioButton.Location = New System.Drawing.Point(3, 15)
        Me.onediscdvdRadioButton.Name = "onediscdvdRadioButton"
        Me.onediscdvdRadioButton.Size = New System.Drawing.Size(115, 17)
        Me.onediscdvdRadioButton.TabIndex = 21
        Me.onediscdvdRadioButton.TabStop = True
        Me.onediscdvdRadioButton.Text = "&1-disc DVD ($9.99)"
        Me.onediscdvdRadioButton.UseVisualStyleBackColor = True
        '
        'twodiscdvdRadioButton
        '
        Me.twodiscdvdRadioButton.AutoSize = True
        Me.twodiscdvdRadioButton.Location = New System.Drawing.Point(3, 38)
        Me.twodiscdvdRadioButton.Name = "twodiscdvdRadioButton"
        Me.twodiscdvdRadioButton.Size = New System.Drawing.Size(121, 17)
        Me.twodiscdvdRadioButton.TabIndex = 22
        Me.twodiscdvdRadioButton.TabStop = True
        Me.twodiscdvdRadioButton.Text = "&2-disc DVD ($19.99)"
        Me.twodiscdvdRadioButton.UseVisualStyleBackColor = True
        '
        'numbertotalorderedLabel
        '
        Me.numbertotalorderedLabel.BackColor = System.Drawing.SystemColors.Info
        Me.numbertotalorderedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numbertotalorderedLabel.Location = New System.Drawing.Point(427, 269)
        Me.numbertotalorderedLabel.Name = "numbertotalorderedLabel"
        Me.numbertotalorderedLabel.Size = New System.Drawing.Size(69, 18)
        Me.numbertotalorderedLabel.TabIndex = 56
        '
        'numbertotalpriceLabel
        '
        Me.numbertotalpriceLabel.BackColor = System.Drawing.SystemColors.Info
        Me.numbertotalpriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numbertotalpriceLabel.Location = New System.Drawing.Point(427, 323)
        Me.numbertotalpriceLabel.Name = "numbertotalpriceLabel"
        Me.numbertotalpriceLabel.Size = New System.Drawing.Size(69, 19)
        Me.numbertotalpriceLabel.TabIndex = 57
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 24)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearOrderMenuItem, Me.PrintOrderMenuItem, Me.ExitMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearOrderMenuItem
        '
        Me.ClearOrderMenuItem.Name = "ClearOrderMenuItem"
        Me.ClearOrderMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ClearOrderMenuItem.Text = "C&lear Order"
        '
        'PrintOrderMenuItem
        '
        Me.PrintOrderMenuItem.Name = "PrintOrderMenuItem"
        Me.PrintOrderMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.PrintOrderMenuItem.Text = "&Print Order"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitMenuItem.Text = "E&xit"
        '
        'shippingListBox
        '
        Me.shippingListBox.FormattingEnabled = True
        Me.shippingListBox.Location = New System.Drawing.Point(9, 41)
        Me.shippingListBox.Name = "shippingListBox"
        Me.shippingListBox.Size = New System.Drawing.Size(51, 56)
        Me.shippingListBox.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Business &Days"
        '
        'businessdayLabel
        '
        Me.businessdayLabel.BackColor = System.Drawing.SystemColors.Info
        Me.businessdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.businessdayLabel.Location = New System.Drawing.Point(98, 44)
        Me.businessdayLabel.Name = "businessdayLabel"
        Me.businessdayLabel.Size = New System.Drawing.Size(61, 23)
        Me.businessdayLabel.TabIndex = 62
        Me.businessdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "&Price Range"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.businessdayLabel)
        Me.GroupBox1.Controls.Add(Me.shippingListBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 109)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shipping Details:"
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(563, 111)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 67
        Me.saveButton.Text = "Sa&ve"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 378)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.numbertotalpriceLabel)
        Me.Controls.Add(Me.numbertotalorderedLabel)
        Me.Controls.Add(Me.blurayGroupBox)
        Me.Controls.Add(Me.dvdGroupBox)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.totalpriceLabel)
        Me.Controls.Add(Me.totalorderedLabel)
        Me.Controls.Add(Me.numberblurayTextBox)
        Me.Controls.Add(Me.numberdvdTextBox)
        Me.Controls.Add(Me.dvdPictureBox)
        Me.Controls.Add(Me.stateComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.zipLabel)
        Me.Controls.Add(Me.stateLabel)
        Me.Controls.Add(Me.cityLabel)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.zipTextBox)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.blurayPictureBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Jeff's Movie Store"
        CType(Me.dvdPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blurayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.blurayGroupBox.ResumeLayout(False)
        Me.blurayGroupBox.PerformLayout()
        Me.dvdGroupBox.ResumeLayout(False)
        Me.dvdGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcButton As Button
    Friend WithEvents nameLabel As Label
    Friend WithEvents totalpriceLabel As Label
    Friend WithEvents totalorderedLabel As Label
    Friend WithEvents numberblurayTextBox As TextBox
    Friend WithEvents numberdvdTextBox As TextBox
    Friend WithEvents dvdPictureBox As PictureBox
    Friend WithEvents stateComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents zipLabel As Label
    Friend WithEvents stateLabel As Label
    Friend WithEvents cityLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents zipTextBox As TextBox
    Friend WithEvents cityTextBox As TextBox
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents blurayPictureBox As PictureBox
    Friend WithEvents blurayGroupBox As GroupBox
    Friend WithEvents blurayRadioButton As RadioButton
    Friend WithEvents bluray3dRadioButton As RadioButton
    Friend WithEvents dvdGroupBox As GroupBox
    Friend WithEvents onediscdvdRadioButton As RadioButton
    Friend WithEvents twodiscdvdRadioButton As RadioButton
    Friend WithEvents numbertotalorderedLabel As Label
    Friend WithEvents numbertotalpriceLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearOrderMenuItem As ToolStripMenuItem
    Friend WithEvents PrintOrderMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
    Friend WithEvents shippingListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents businessdayLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents saveButton As Button
End Class
