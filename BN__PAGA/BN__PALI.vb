Imports System.Data
Imports NTSInformatica.CLN__STD

Public Class FRM__PALI
  Public oClePaga As CLE__PAGA
  Public oCallParams As CLE__CLDP
  Public dsPali As DataSet
  Public dcPali As BindingSource = New BindingSource()

  Private components As System.ComponentModel.IContainer
  Public WithEvents NtsBarManager1 As NTSInformatica.NTSBarManager
  Public WithEvents tlbMain As NTSInformatica.NTSBar
  Public WithEvents tlbNuovo As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbSalva As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbCancella As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbRipristina As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbZoom As NTSInformatica.NTSBarButtonItem
  Public WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Public WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Public WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Public WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Public WithEvents tlbGuida As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbEsci As NTSInformatica.NTSBarButtonItem
  Public WithEvents grPali As NTSInformatica.NTSGrid
  Public WithEvents grvPali As NTSInformatica.NTSGridView
  Public WithEvents tl_codling As NTSInformatica.NTSGridColumn
  Public WithEvents xx_codling As NTSInformatica.NTSGridColumn
  Public WithEvents tl_despaga As NTSInformatica.NTSGridColumn

  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM__PALI))
    Me.NtsBarManager1 = New NTSInformatica.NTSBarManager
    Me.tlbMain = New NTSInformatica.NTSBar
    Me.tlbNuovo = New NTSInformatica.NTSBarButtonItem
    Me.tlbSalva = New NTSInformatica.NTSBarButtonItem
    Me.tlbRipristina = New NTSInformatica.NTSBarButtonItem
    Me.tlbCancella = New NTSInformatica.NTSBarButtonItem
    Me.tlbZoom = New NTSInformatica.NTSBarButtonItem
    Me.tlbGuida = New NTSInformatica.NTSBarButtonItem
    Me.tlbEsci = New NTSInformatica.NTSBarButtonItem
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
    Me.grPali = New NTSInformatica.NTSGrid
    Me.grvPali = New NTSInformatica.NTSGridView
    Me.tl_codling = New NTSInformatica.NTSGridColumn
    Me.xx_codling = New NTSInformatica.NTSGridColumn
    Me.tl_despaga = New NTSInformatica.NTSGridColumn
    CType(Me.NtsBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grPali, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grvPali, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'frmPopup
    '
    Me.frmPopup.Appearance.BackColor = System.Drawing.SystemColors.Info
    Me.frmPopup.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
    Me.frmPopup.Appearance.Options.UseBackColor = True
    Me.frmPopup.Appearance.Options.UseImage = True
    '
    'NtsBarManager1
    '
    Me.NtsBarManager1.AllowCustomization = False
    Me.NtsBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.tlbMain})
    Me.NtsBarManager1.DockControls.Add(Me.barDockControlTop)
    Me.NtsBarManager1.DockControls.Add(Me.barDockControlBottom)
    Me.NtsBarManager1.DockControls.Add(Me.barDockControlLeft)
    Me.NtsBarManager1.DockControls.Add(Me.barDockControlRight)
    Me.NtsBarManager1.Form = Me
    Me.NtsBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.tlbNuovo, Me.tlbSalva, Me.tlbCancella, Me.tlbRipristina, Me.tlbGuida, Me.tlbEsci, Me.tlbZoom})
    Me.NtsBarManager1.MaxItemId = 17
    '
    'tlbMain
    '
    Me.tlbMain.BarName = "tlbMain"
    Me.tlbMain.DockCol = 0
    Me.tlbMain.DockRow = 0
    Me.tlbMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.tlbMain.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tlbNuovo), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbSalva), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbRipristina), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbCancella), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbZoom, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbGuida, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbEsci)})
    Me.tlbMain.OptionsBar.AllowQuickCustomization = False
    Me.tlbMain.OptionsBar.DisableClose = True
    Me.tlbMain.OptionsBar.DrawDragBorder = False
    Me.tlbMain.OptionsBar.UseWholeRow = True
    Me.tlbMain.Text = "tlbMain"
    '
    'tlbNuovo
    '
    Me.tlbNuovo.Caption = "Nuovo"
    Me.tlbNuovo.Glyph = CType(resources.GetObject("tlbNuovo.Glyph"), System.Drawing.Image)
    Me.tlbNuovo.Id = 0
    Me.tlbNuovo.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
    Me.tlbNuovo.Name = "tlbNuovo"
    Me.tlbNuovo.Visible = True
    '
    'tlbSalva
    '
    Me.tlbSalva.Caption = "Salva"
    Me.tlbSalva.Glyph = CType(resources.GetObject("tlbSalva.Glyph"), System.Drawing.Image)
    Me.tlbSalva.Id = 1
    Me.tlbSalva.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
    Me.tlbSalva.Name = "tlbSalva"
    Me.tlbSalva.Visible = True
    '
    'tlbRipristina
    '
    Me.tlbRipristina.Caption = "Ripristina"
    Me.tlbRipristina.Glyph = CType(resources.GetObject("tlbRipristina.Glyph"), System.Drawing.Image)
    Me.tlbRipristina.Id = 2
    Me.tlbRipristina.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
    Me.tlbRipristina.Name = "tlbRipristina"
    Me.tlbRipristina.Visible = True
    '
    'tlbCancella
    '
    Me.tlbCancella.Caption = "Cancella"
    Me.tlbCancella.Glyph = CType(resources.GetObject("tlbCancella.Glyph"), System.Drawing.Image)
    Me.tlbCancella.Id = 3
    Me.tlbCancella.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
    Me.tlbCancella.Name = "tlbCancella"
    Me.tlbCancella.Visible = True
    '
    'tlbZoom
    '
    Me.tlbZoom.Caption = "Zoom"
    Me.tlbZoom.Glyph = CType(resources.GetObject("tlbZoom.Glyph"), System.Drawing.Image)
    Me.tlbZoom.Id = 13
    Me.tlbZoom.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
    Me.tlbZoom.Name = "tlbZoom"
    Me.tlbZoom.Visible = True
    '
    'tlbGuida
    '
    Me.tlbGuida.Caption = "Guida"
    Me.tlbGuida.Glyph = CType(resources.GetObject("tlbGuida.Glyph"), System.Drawing.Image)
    Me.tlbGuida.Id = 11
    Me.tlbGuida.Name = "tlbGuida"
    Me.tlbGuida.Visible = True
    '
    'tlbEsci
    '
    Me.tlbEsci.Caption = "Esci"
    Me.tlbEsci.Glyph = CType(resources.GetObject("tlbEsci.Glyph"), System.Drawing.Image)
    Me.tlbEsci.Id = 12
    Me.tlbEsci.Name = "tlbEsci"
    Me.tlbEsci.Visible = True
    '
    'grPali
    '
    Me.grPali.Dock = System.Windows.Forms.DockStyle.Fill
    '
    '
    '
    Me.grPali.EmbeddedNavigator.Name = ""
    Me.grPali.Location = New System.Drawing.Point(0, 26)
    Me.grPali.MainView = Me.grvPali
    Me.grPali.Name = "grPali"
    Me.grPali.Size = New System.Drawing.Size(648, 416)
    Me.grPali.TabIndex = 5
    Me.grPali.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPali})
    '
    'grvPali
    '
    Me.grvPali.ActiveFilterEnabled = False
    Me.grvPali.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tl_codling, Me.xx_codling, Me.tl_despaga})
    Me.grvPali.CustomizationFormBounds = New System.Drawing.Rectangle(680, 326, 208, 170)
    Me.grvPali.Enabled = True
    Me.grvPali.GridControl = Me.grPali
    Me.grvPali.Name = "grvPali"
    Me.grvPali.NTSAllowDelete = True
    Me.grvPali.NTSAllowInsert = True
    Me.grvPali.NTSAllowUpdate = True
    Me.grvPali.NTSMenuContext = Nothing
    Me.grvPali.OptionsCustomization.AllowRowSizing = True
    Me.grvPali.OptionsNavigation.EnterMoveNextColumn = True
    Me.grvPali.OptionsNavigation.UseTabKey = False
    Me.grvPali.OptionsSelection.EnableAppearanceFocusedRow = False
    Me.grvPali.OptionsView.ColumnAutoWidth = False
    Me.grvPali.OptionsView.EnableAppearanceEvenRow = True
    Me.grvPali.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
    Me.grvPali.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
    Me.grvPali.OptionsView.ShowGroupPanel = False
    Me.grvPali.RowHeight = 16
    '
    'tl_codling
    '
    Me.tl_codling.AppearanceCell.Options.UseBackColor = True
    Me.tl_codling.AppearanceCell.Options.UseTextOptions = True
    Me.tl_codling.Caption = "Cod. lingua"
    Me.tl_codling.Enabled = True
    Me.tl_codling.FieldName = "tl_codling"
    Me.tl_codling.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
    Me.tl_codling.Name = "tl_codling"
    Me.tl_codling.NTSRepositoryComboBox = Nothing
    Me.tl_codling.NTSRepositoryItemCheck = Nothing
    Me.tl_codling.NTSRepositoryItemText = Nothing
    Me.tl_codling.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
    Me.tl_codling.OptionsFilter.AllowFilter = False
    Me.tl_codling.Visible = True
    Me.tl_codling.VisibleIndex = 0
    Me.tl_codling.Width = 70
    '
    'xx_codling
    '
    Me.xx_codling.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
    Me.xx_codling.AppearanceCell.Options.UseBackColor = True
    Me.xx_codling.AppearanceCell.Options.UseTextOptions = True
    Me.xx_codling.Caption = "Desc. lingua"
    Me.xx_codling.Enabled = False
    Me.xx_codling.FieldName = "xx_codling"
    Me.xx_codling.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
    Me.xx_codling.Name = "xx_codling"
    Me.xx_codling.NTSRepositoryComboBox = Nothing
    Me.xx_codling.NTSRepositoryItemCheck = Nothing
    Me.xx_codling.NTSRepositoryItemText = Nothing
    Me.xx_codling.OptionsColumn.AllowEdit = False
    Me.xx_codling.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
    Me.xx_codling.OptionsColumn.ReadOnly = True
    Me.xx_codling.OptionsFilter.AllowFilter = False
    Me.xx_codling.Visible = True
    Me.xx_codling.VisibleIndex = 1
    Me.xx_codling.Width = 70
    '
    'tl_despaga
    '
    Me.tl_despaga.AppearanceCell.Options.UseBackColor = True
    Me.tl_despaga.AppearanceCell.Options.UseTextOptions = True
    Me.tl_despaga.Caption = "Descr. pagamento"
    Me.tl_despaga.Enabled = True
    Me.tl_despaga.FieldName = "tl_despaga"
    Me.tl_despaga.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
    Me.tl_despaga.Name = "tl_despaga"
    Me.tl_despaga.NTSRepositoryComboBox = Nothing
    Me.tl_despaga.NTSRepositoryItemCheck = Nothing
    Me.tl_despaga.NTSRepositoryItemText = Nothing
    Me.tl_despaga.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
    Me.tl_despaga.OptionsFilter.AllowFilter = False
    Me.tl_despaga.Visible = True
    Me.tl_despaga.VisibleIndex = 2
    Me.tl_despaga.Width = 70
    '
    'FRM__PALI
    '
    Me.ClientSize = New System.Drawing.Size(648, 442)
    Me.Controls.Add(Me.grPali)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "FRM__PALI"
    Me.NTSLastControlFocussed = Me.grPali
    Me.Text = "DESCRIZIONI IN LINGUA"
    CType(Me.NtsBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grPali, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grvPali, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Public Overloads Function Init(ByRef Menu As CLE__MENU, ByRef Param As CLE__CLDP, Optional ByVal Ditta As String = "", Optional ByRef SharedControls As CLE__EVNT = Nothing) As Boolean
    oMenu = Menu
    oApp = oMenu.App
    oCallParams = Param
    If Ditta <> "" Then
      DittaCorrente = Ditta
    Else
      DittaCorrente = oApp.Ditta
    End If
    Me.GctlTipoDoc = ""

    InitializeComponent()
    Me.MinimumSize = Me.Size

    Return True
  End Function

  Public Overridable Sub InitEntity(ByRef clePaga As CLE__PAGA)
    oClePaga = clePaga
    AddHandler oClePaga.RemoteEvent, AddressOf GestisciEventiEntity
  End Sub

  Public Overridable Sub InitControls()
    InitControlsBeginEndInit(Me, False)
    Try
      '-------------------------------------------------
      'carico le immagini della toolbar
      Try
        tlbNuovo.GlyphPath = (oApp.ChildImageDir & "\new.gif")
        tlbSalva.GlyphPath = (oApp.ChildImageDir & "\save.gif")
        tlbCancella.GlyphPath = (oApp.ChildImageDir & "\delete.gif")
        tlbRipristina.GlyphPath = (oApp.ChildImageDir & "\restore.gif")
        tlbZoom.GlyphPath = (oApp.ChildImageDir & "\zoom.gif")
        tlbGuida.GlyphPath = (oApp.ChildImageDir & "\help.gif")
        tlbEsci.GlyphPath = (oApp.ChildImageDir & "\exit.gif")
      Catch ex As Exception
        'non gestisco l'errore: se non c'è una immagine prendo quella standard
      End Try
      tlbMain.NTSSetToolTip()

      grvPali.NTSSetParam(oMenu, "DESCRIZIONI IN LINGUA")

      tl_codling.NTSSetParamNUMTabe(oMenu, oApp.Tr(Me, 128399361441014000, "Cod. lingua"), tabling)
      xx_codling.NTSSetParamSTR(oMenu, oApp.Tr(Me, 128399366052182000, "Descrizione lingua"), 0)
      tl_despaga.NTSSetParamSTR(oMenu, oApp.Tr(Me, 128399366425646000, "Descrizione pagamento in lingua"), 50, False)

      '-------------------------------------------------
      'chiamo lo script per inizializzare i controlli caricati con source ext
      NTSScriptExec("InitControls", Me, Nothing)
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
    InitControlsBeginEndInit(Me, True)
  End Sub

#Region "Eventi di Form"
  Public Overridable Sub FRM__PALI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      '-------------------------------------------------
      'predispongo i controlli
      InitControls()

      '-------------------------------------------------
      'leggo dal database i dati e collego il NTSBindingNavigator
      If Not oClePaga.PaliApri(dsPali) Then Me.Close()
      dcPali.DataSource = dsPali.Tables("PAGALIN")
      dsPali.AcceptChanges()

      grPali.DataSource = dcPali

      '-------------------------------------------------
      'sempre alla fine di questa funzione: applico le regole della gctl
      GctlSetRoules()

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub FRM__PALI_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    If Not Salva() Then e.Cancel = True
  End Sub

  Public Overridable Sub FRM__PALI_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    Try
      dcPali.Dispose()
      dsPali.Dispose()
    Catch
    End Try
  End Sub
#End Region

#Region "Eventi Toolbar"
  Public Overridable Sub tlbNuovo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbNuovo.ItemClick
    Try
      grvPali.NTSNuovo()

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub tlbSalva_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbSalva.ItemClick
    Try
      Salva()
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub tlbCancella_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbCancella.ItemClick
    Try
      If Not grvPali.NTSDeleteRigaCorrente(dcPali, True) Then Return
      oClePaga.PaliSalva(True)

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub tlbRipristina_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbRipristina.ItemClick
    Try
      If Not grvPali.NTSRipristinaRigaCorrenteBefore(dcPali, True) Then Return
      oClePaga.PaliRipristina(dcPali.Position, dcPali.Filter)
      grvPali.NTSRipristinaRigaCorrenteAfter()
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub tlbZoom_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbZoom.ItemClick
    Try
      'zoom standard
      Dim ctrlTmp As Control = NTSFindControlForZoom()
      If ctrlTmp Is Nothing Then Return
      Dim oParam As New CLE__PATB

      '------------------------------------
      'zoom standard di textbox e griglia
      NTSCallStandardZoom()
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub tlbGuida_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbGuida.ItemClick
    SendKeys.Send("{F1}")
  End Sub

  Public Overridable Sub tlbEsci_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbEsci.ItemClick
    Me.Close()
  End Sub
#End Region

  Public Overridable Sub grvPali_NTSBeforeRowUpdate(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles grvPali.NTSBeforeRowUpdate
    Try
      If Not Salva() Then
        'rimango sulla riga su cui sono
        e.Allow = False
      End If

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub


  Public Overridable Function Salva() As Boolean
    Try
      Me.ValidaLastControl()      'valido l'ultimo controllo che ha il focus

      Dim dRes As DialogResult
      dRes = grvPali.NTSSalvaRigaCorrente(dcPali, oClePaga.PaliRecordIsChanged, False)
      Select Case dRes
        Case System.Windows.Forms.DialogResult.Yes
          'salvo
          '-------------------------------------------------
          'controllo che i campi abbiano un valore diverso da quello impostato in GCTL.OutNotEqual
          If GctlControllaOutNotEqual() = False Then Return False

          If Not oClePaga.PaliSalva(False) Then
            Return False
          End If
        Case System.Windows.Forms.DialogResult.No
          'ripristino
          oClePaga.Ripristina(dcPali.Position, dcPali.Filter)
        Case System.Windows.Forms.DialogResult.Cancel
          'non posso fare nulla
          Return False
        Case System.Windows.Forms.DialogResult.Abort
          'la riga non ha subito modifiche
      End Select
      Return True
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Function

End Class
