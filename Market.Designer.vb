<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Market
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BD_STOCKEntities1View1 = New ProjetGestionDeStock.Views.BD_STOCKEntities1View.BD_STOCKEntities1View()
        Me.SuspendLayout()
        '
        'BD_STOCKEntities1View1
        '
        Me.BD_STOCKEntities1View1.Appearance.BackColor = System.Drawing.Color.White
        Me.BD_STOCKEntities1View1.Appearance.Options.UseBackColor = True
        Me.BD_STOCKEntities1View1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BD_STOCKEntities1View1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BD_STOCKEntities1View1.Location = New System.Drawing.Point(0, 0)
        Me.BD_STOCKEntities1View1.Name = "BD_STOCKEntities1View1"
        Me.BD_STOCKEntities1View1.Size = New System.Drawing.Size(966, 522)
        Me.BD_STOCKEntities1View1.TabIndex = 0
        '
        'Market
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 522)
        Me.Controls.Add(Me.BD_STOCKEntities1View1)
        Me.Name = "Market"
        Me.ShowIcon = False
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BD_STOCKEntities1View1 As Views.BD_STOCKEntities1View.BD_STOCKEntities1View
End Class
