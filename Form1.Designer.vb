<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuTextBoxUserName = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuTextBoxPassword = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.SuspendLayout()
        '
        'BunifuTextBoxUserName
        '
        Me.BunifuTextBoxUserName.AcceptsReturn = False
        Me.BunifuTextBoxUserName.AcceptsTab = False
        Me.BunifuTextBoxUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBoxUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBoxUserName.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BunifuTextBoxUserName, "BunifuTextBoxUserName")
        Me.BunifuTextBoxUserName.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BunifuTextBoxUserName.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuTextBoxUserName.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BunifuTextBoxUserName.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBoxUserName.BorderRadius = 30
        Me.BunifuTextBoxUserName.BorderThickness = 1
        Me.BunifuTextBoxUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBoxUserName.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBoxUserName.DefaultText = ""
        Me.BunifuTextBoxUserName.FillColor = System.Drawing.Color.White
        Me.BunifuTextBoxUserName.HideSelection = True
        Me.BunifuTextBoxUserName.IconLeft = Nothing
        Me.BunifuTextBoxUserName.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBoxUserName.IconPadding = 10
        Me.BunifuTextBoxUserName.IconRight = Nothing
        Me.BunifuTextBoxUserName.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBoxUserName.MaxLength = 32767
        Me.BunifuTextBoxUserName.Modified = False
        Me.BunifuTextBoxUserName.Name = "BunifuTextBoxUserName"
        Me.BunifuTextBoxUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBoxUserName.ReadOnly = False
        Me.BunifuTextBoxUserName.SelectedText = ""
        Me.BunifuTextBoxUserName.SelectionLength = 0
        Me.BunifuTextBoxUserName.SelectionStart = 0
        Me.BunifuTextBoxUserName.ShortcutsEnabled = True
        Me.BunifuTextBoxUserName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBoxUserName.TextMarginLeft = 5
        Me.BunifuTextBoxUserName.TextPlaceholder = ""
        Me.BunifuTextBoxUserName.UseSystemPasswordChar = False
        '
        'BunifuTextBoxPassword
        '
        Me.BunifuTextBoxPassword.AcceptsReturn = False
        Me.BunifuTextBoxPassword.AcceptsTab = False
        Me.BunifuTextBoxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBoxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBoxPassword.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BunifuTextBoxPassword, "BunifuTextBoxPassword")
        Me.BunifuTextBoxPassword.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BunifuTextBoxPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuTextBoxPassword.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BunifuTextBoxPassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBoxPassword.BorderRadius = 30
        Me.BunifuTextBoxPassword.BorderThickness = 1
        Me.BunifuTextBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBoxPassword.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBoxPassword.DefaultText = ""
        Me.BunifuTextBoxPassword.FillColor = System.Drawing.Color.White
        Me.BunifuTextBoxPassword.HideSelection = True
        Me.BunifuTextBoxPassword.IconLeft = Nothing
        Me.BunifuTextBoxPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBoxPassword.IconPadding = 10
        Me.BunifuTextBoxPassword.IconRight = Nothing
        Me.BunifuTextBoxPassword.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBoxPassword.MaxLength = 32767
        Me.BunifuTextBoxPassword.Modified = False
        Me.BunifuTextBoxPassword.Name = "BunifuTextBoxPassword"
        Me.BunifuTextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.BunifuTextBoxPassword.ReadOnly = False
        Me.BunifuTextBoxPassword.SelectedText = ""
        Me.BunifuTextBoxPassword.SelectionLength = 0
        Me.BunifuTextBoxPassword.SelectionStart = 0
        Me.BunifuTextBoxPassword.ShortcutsEnabled = True
        Me.BunifuTextBoxPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBoxPassword.TextMarginLeft = 5
        Me.BunifuTextBoxPassword.TextPlaceholder = ""
        Me.BunifuTextBoxPassword.UseSystemPasswordChar = False
        '
        'BunifuButton1
        '
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BunifuButton1, "BunifuButton1")
        Me.BunifuButton1.ButtonText = "Sign In"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuButton1.IdleBorderRadius = 30
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(251, Byte), Integer))
        StateProperties1.BorderRadius = 30
        StateProperties1.BorderThickness = 2
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(207, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties1
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        resources.ApplyResources(Me.BunifuLabel1, "BunifuLabel1")
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        resources.ApplyResources(Me.BunifuLabel2, "BunifuLabel2")
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        resources.ApplyResources(Me.BunifuLabel3, "BunifuLabel3")
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.BunifuTextBoxPassword)
        Me.Controls.Add(Me.BunifuTextBoxUserName)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuTextBoxUserName As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuTextBoxPassword As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
End Class
