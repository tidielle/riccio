Partial Public Class FRMMGGRNP
  Inherits FRM__CHIL

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New()
  End Sub

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub
  Public WithEvents tlbTaglie As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbDocumenti As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbNavigazioneDoc As NTSInformatica.NTSBarButtonItem
  Public WithEvents km_anno As NTSInformatica.NTSGridColumn
  Public WithEvents km_riga As NTSInformatica.NTSGridColumn
  Public WithEvents tlbStampaVideo As NTSInformatica.NTSBarButtonItem

End Class
