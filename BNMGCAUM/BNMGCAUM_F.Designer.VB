Partial Class FRMMGCAUM_F
  Inherits FRM__CHIL

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New()

    ''This call is required by the Windows Form Designer.
    'InitializeComponent()

  End Sub

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub
  Public WithEvents pnControlli As NTSInformatica.NTSGroupBox
  Public WithEvents pn2 As NTSInformatica.NTSGroupBox
  Public WithEvents pn1 As NTSInformatica.NTSGroupBox
  Public WithEvents tlbDuplica As NTSInformatica.NTSBarButtonItem

  'Required by the Windows Form Designer
  'Private components As System.ComponentModel.IContainer

End Class