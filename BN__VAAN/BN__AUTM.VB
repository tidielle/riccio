Imports System.Data
Imports NTSInformatica.CLN__STD

Public Class FRM__AUTM
#Region "Variabili"
  Public oCleVaan As CLE__VAAN
  Public oCallParams As CLE__CLDP
  Public dsAutm As New DataSet
  Public dcAutm As New BindingSource()
  Public dttAutm As DataTable = Nothing
  Public dtrAutm() As DataRow = Nothing
  Private components As System.ComponentModel.IContainer

  Public strTabella As String = "" 'tabella per effettuare lo zoom

  Public WithEvents NtsBarManager1 As NTSInformatica.NTSBarManager
  Public WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Public WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Public WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Public WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Public WithEvents tlbMain As NTSInformatica.NTSBar
  Public WithEvents tlbRecordSalva As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbRecordRipristina As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbZoom As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbGuida As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbEsci As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbElabora As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbRipristina As NTSInformatica.NTSBarButtonItem
  Public WithEvents grAutm As NTSInformatica.NTSGrid
  Public WithEvents grvAutm As NTSInformatica.NTSGridView
  Public WithEvents xx_cod As NTSInformatica.NTSGridColumn
  Public WithEvents xx_descr As NTSInformatica.NTSGridColumn
  Public WithEvents xx_campoold As NTSInformatica.NTSGridColumn
  Public WithEvents xx_valorenew As NTSInformatica.NTSGridColumn
  Public WithEvents pnTop As NTSInformatica.NTSPanel
  Public WithEvents lbInfo As NTSInformatica.NTSLabel
  Public WithEvents tlbRecordCancella As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbStrumenti As NTSInformatica.NTSBarSubItem
#End Region

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
  Public Overridable Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM__AUTM))
    Me.NtsBarManager1 = New NTSInformatica.NTSBarManager
    Me.tlbMain = New NTSInformatica.NTSBar
    Me.tlbElabora = New NTSInformatica.NTSBarButtonItem
    Me.tlbRipristina = New NTSInformatica.NTSBarButtonItem
    Me.tlbRecordSalva = New NTSInformatica.NTSBarButtonItem
    Me.tlbRecordRipristina = New NTSInformatica.NTSBarButtonItem
    Me.tlbZoom = New NTSInformatica.NTSBarButtonItem
    Me.tlbStrumenti = New NTSInformatica.NTSBarSubItem
    Me.tlbGuida = New NTSInformatica.NTSBarButtonItem
    Me.tlbEsci = New NTSInformatica.NTSBarButtonItem
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
    Me.pnTop = New NTSInformatica.NTSPanel
    Me.lbInfo = New NTSInformatica.NTSLabel
    Me.grAutm = New NTSInformatica.NTSGrid
    Me.grvAutm = New NTSInformatica.NTSGridView
    Me.xx_cod = New NTSInformatica.NTSGridColumn
    Me.xx_descr = New NTSInformatica.NTSGridColumn
    Me.xx_campoold = New NTSInformatica.NTSGridColumn
    Me.xx_valorenew = New NTSInformatica.NTSGridColumn
    Me.tlbRecordCancella = New NTSInformatica.NTSBarButtonItem
    CType(Me.NtsBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pnTop, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnTop.SuspendLayout()
    CType(Me.grAutm, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grvAutm, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'frmPopup
    '
    Me.frmPopup.Appearance.BackColor = System.Drawing.Color.Red
    Me.frmPopup.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
    Me.frmPopup.Appearance.Image = CType(resources.GetObject("frmPopup.Appearance.Image"), System.Drawing.Image)
    Me.frmPopup.Appearance.Options.UseBackColor = True
    Me.frmPopup.Appearance.Options.UseImage = True
    Me.frmPopup.ClientSize = New System.Drawing.Size(77, 21)
    '
    'frmAuto
    '
    Me.frmAuto.Appearance.BackColor = System.Drawing.Color.Black
    Me.frmAuto.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
    Me.frmAuto.Appearance.Options.UseBackColor = True
    Me.frmAuto.Appearance.Options.UseImage = True
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
    Me.NtsBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.tlbRecordSalva, Me.tlbRecordRipristina, Me.tlbZoom, Me.tlbGuida, Me.tlbEsci, Me.tlbStrumenti, Me.tlbElabora, Me.tlbRipristina, Me.tlbRecordCancella})
    Me.NtsBarManager1.MaxItemId = 19
    '
    'tlbMain
    '
    Me.tlbMain.BarName = "tlbMain"
    Me.tlbMain.DockCol = 0
    Me.tlbMain.DockRow = 0
    Me.tlbMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
    Me.tlbMain.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tlbElabora), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbRipristina), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbRecordSalva, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbRecordCancella), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbRecordRipristina), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbZoom), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbStrumenti, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbGuida, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbEsci)})
    Me.tlbMain.OptionsBar.AllowQuickCustomization = False
    Me.tlbMain.OptionsBar.DisableClose = True
    Me.tlbMain.OptionsBar.DrawDragBorder = False
    Me.tlbMain.OptionsBar.UseWholeRow = True
    Me.tlbMain.Text = "tlbMain"
    '
    'tlbElabora
    '
    Me.tlbElabora.Caption = "Elabora"
    Me.tlbElabora.Glyph = CType(resources.GetObject("tlbElabora.Glyph"), System.Drawing.Image)
    Me.tlbElabora.Id = 16
    Me.tlbElabora.Name = "tlbElabora"
    Me.tlbElabora.Visible = True
    '
    'tlbRipristina
    '
    Me.tlbRipristina.Caption = "Ripristina"
    Me.tlbRipristina.Glyph = CType(resources.GetObject("tlbRipristina.Glyph"), System.Drawing.Image)
    Me.tlbRipristina.Id = 17
    Me.tlbRipristina.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
    Me.tlbRipristina.Name = "tlbRipristina"
    Me.tlbRipristina.Visible = True
    '
    'tlbRecordSalva
    '
    Me.tlbRecordSalva.Caption = "Salva"
    Me.tlbRecordSalva.Glyph = CType(resources.GetObject("tlbRecordSalva.Glyph"), System.Drawing.Image)
    Me.tlbRecordSalva.Id = 1
    Me.tlbRecordSalva.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F9))
    Me.tlbRecordSalva.Name = "tlbRecordSalva"
    Me.tlbRecordSalva.Visible = True
    '
    'tlbRecordRipristina
    '
    Me.tlbRecordRipristina.Caption = "Ripristina"
    Me.tlbRecordRipristina.Glyph = CType(resources.GetObject("tlbRecordRipristina.Glyph"), System.Drawing.Image)
    Me.tlbRecordRipristina.Id = 3
    Me.tlbRecordRipristina.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F8))
    Me.tlbRecordRipristina.Name = "tlbRecordRipristina"
    Me.tlbRecordRipristina.Visible = True
    '
    'tlbZoom
    '
    Me.tlbZoom.Caption = "Zoom"
    Me.tlbZoom.Glyph = CType(resources.GetObject("tlbZoom.Glyph"), System.Drawing.Image)
    Me.tlbZoom.Id = 4
    Me.tlbZoom.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
    Me.tlbZoom.Name = "tlbZoom"
    Me.tlbZoom.Visible = True
    '
    'tlbStrumenti
    '
    Me.tlbStrumenti.Caption = "Strumenti"
    Me.tlbStrumenti.Glyph = CType(resources.GetObject("tlbStrumenti.Glyph"), System.Drawing.Image)
    Me.tlbStrumenti.Id = 14
    Me.tlbStrumenti.Name = "tlbStrumenti"
    Me.tlbStrumenti.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
    Me.tlbStrumenti.Visible = True
    '
    'tlbGuida
    '
    Me.tlbGuida.Caption = "Guida"
    Me.tlbGuida.Glyph = CType(resources.GetObject("tlbGuida.Glyph"), System.Drawing.Image)
    Me.tlbGuida.Id = 9
    Me.tlbGuida.Name = "tlbGuida"
    Me.tlbGuida.Visible = True
    '
    'tlbEsci
    '
    Me.tlbEsci.Caption = "Esci"
    Me.tlbEsci.Glyph = CType(resources.GetObject("tlbEsci.Glyph"), System.Drawing.Image)
    Me.tlbEsci.Id = 10
    Me.tlbEsci.Name = "tlbEsci"
    Me.tlbEsci.Visible = True
    '
    'pnTop
    '
    Me.pnTop.AllowDrop = True
    Me.pnTop.Appearance.BackColor = System.Drawing.Color.Transparent
    Me.pnTop.Appearance.Options.UseBackColor = True
    Me.pnTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.pnTop.Controls.Add(Me.lbInfo)
    Me.pnTop.Cursor = System.Windows.Forms.Cursors.Default
    Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnTop.Location = New System.Drawing.Point(0, 30)
    Me.pnTop.Name = "pnTop"
    Me.pnTop.Size = New System.Drawing.Size(667, 32)
    Me.pnTop.TabIndex = 4
    Me.pnTop.Text = "NtsPanel1"
    '
    'lbInfo
    '
    Me.lbInfo.AutoSize = True
    Me.lbInfo.BackColor = System.Drawing.Color.Transparent
    Me.lbInfo.Location = New System.Drawing.Point(16, 11)
    Me.lbInfo.Name = "lbInfo"
    Me.lbInfo.NTSDbField = ""
    Me.lbInfo.Size = New System.Drawing.Size(369, 13)
    Me.lbInfo.TabIndex = 0
    Me.lbInfo.Text = "Verranno elaborati solo i conti con il nuovo valore diverso dal vecchio valore"
    Me.lbInfo.Tooltip = ""
    Me.lbInfo.UseMnemonic = False
    '
    'grAutm
    '
    Me.grAutm.Dock = System.Windows.Forms.DockStyle.Fill
    '
    '
    '
    Me.grAutm.EmbeddedNavigator.Name = ""
    Me.grAutm.Location = New System.Drawing.Point(0, 62)
    Me.grAutm.MainView = Me.grvAutm
    Me.grAutm.Name = "grAutm"
    Me.grAutm.Size = New System.Drawing.Size(667, 304)
    Me.grAutm.TabIndex = 5
    Me.grAutm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvAutm})
    '
    'grvAutm
    '
    Me.grvAutm.ActiveFilterEnabled = False
    Me.grvAutm.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.xx_cod, Me.xx_descr, Me.xx_campoold, Me.xx_valorenew})
    Me.grvAutm.CustomizationFormBounds = New System.Drawing.Rectangle(680, 326, 208, 170)
    Me.grvAutm.Enabled = True
    Me.grvAutm.GridControl = Me.grAutm
    Me.grvAutm.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
    Me.grvAutm.Name = "grvAutm"
    Me.grvAutm.NTSAllowDelete = True
    Me.grvAutm.NTSAllowInsert = True
    Me.grvAutm.NTSAllowUpdate = True
    Me.grvAutm.NTSMenuContext = Nothing
    Me.grvAutm.OptionsCustomization.AllowRowSizing = True
    Me.grvAutm.OptionsFilter.AllowFilterEditor = False
    Me.grvAutm.OptionsNavigation.EnterMoveNextColumn = True
    Me.grvAutm.OptionsNavigation.UseTabKey = False
    Me.grvAutm.OptionsSelection.EnableAppearanceFocusedRow = False
    Me.grvAutm.OptionsView.ColumnAutoWidth = False
    Me.grvAutm.OptionsView.EnableAppearanceEvenRow = True
    Me.grvAutm.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
    Me.grvAutm.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
    Me.grvAutm.OptionsView.ShowGroupPanel = False
    Me.grvAutm.RowHeight = 16
    '
    'xx_cod
    '
    Me.xx_cod.AppearanceCell.Options.UseBackColor = True
    Me.xx_cod.AppearanceCell.Options.UseTextOptions = True
    Me.xx_cod.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xx_cod.Caption = "Conto"
    Me.xx_cod.Enabled = True
    Me.xx_cod.FieldName = "xx_cod"
    Me.xx_cod.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
    Me.xx_cod.Name = "xx_cod"
    Me.xx_cod.NTSRepositoryComboBox = Nothing
    Me.xx_cod.NTSRepositoryItemCheck = Nothing
    Me.xx_cod.NTSRepositoryItemMemo = Nothing
    Me.xx_cod.NTSRepositoryItemText = Nothing
    Me.xx_cod.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
    Me.xx_cod.OptionsFilter.AllowFilter = False
    Me.xx_cod.Visible = True
    Me.xx_cod.VisibleIndex = 0
    '
    'xx_descr
    '
    Me.xx_descr.AppearanceCell.Options.UseBackColor = True
    Me.xx_descr.AppearanceCell.Options.UseTextOptions = True
    Me.xx_descr.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xx_descr.Caption = "Descr"
    Me.xx_descr.Enabled = True
    Me.xx_descr.FieldName = "xx_descr"
    Me.xx_descr.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
    Me.xx_descr.Name = "xx_descr"
    Me.xx_descr.NTSRepositoryComboBox = Nothing
    Me.xx_descr.NTSRepositoryItemCheck = Nothing
    Me.xx_descr.NTSRepositoryItemMemo = Nothing
    Me.xx_descr.NTSRepositoryItemText = Nothing
    Me.xx_descr.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
    Me.xx_descr.OptionsFilter.AllowFilter = False
    Me.xx_descr.Visible = True
    Me.xx_descr.VisibleIndex = 1
    '
    'xx_campoold
    '
    Me.xx_campoold.AppearanceCell.Options.UseBackColor = True
    Me.xx_campoold.AppearanceCell.Options.UseTextOptions = True
    Me.xx_campoold.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xx_campoold.Caption = "Valore campo"
    Me.xx_campoold.Enabled = True
    Me.xx_campoold.FieldName = "xx_campoold"
    Me.xx_campoold.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
    Me.xx_campoold.Name = "xx_campoold"
    Me.xx_campoold.NTSRepositoryComboBox = Nothing
    Me.xx_campoold.NTSRepositoryItemCheck = Nothing
    Me.xx_campoold.NTSRepositoryItemMemo = Nothing
    Me.xx_campoold.NTSRepositoryItemText = Nothing
    Me.xx_campoold.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
    Me.xx_campoold.OptionsFilter.AllowFilter = False
    Me.xx_campoold.Visible = True
    Me.xx_campoold.VisibleIndex = 2
    '
    'xx_valorenew
    '
    Me.xx_valorenew.AppearanceCell.Options.UseBackColor = True
    Me.xx_valorenew.AppearanceCell.Options.UseTextOptions = True
    Me.xx_valorenew.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xx_valorenew.Caption = "Nuovo valore"
    Me.xx_valorenew.Enabled = True
    Me.xx_valorenew.FieldName = "xx_valorenew"
    Me.xx_valorenew.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
    Me.xx_valorenew.Name = "xx_valorenew"
    Me.xx_valorenew.NTSRepositoryComboBox = Nothing
    Me.xx_valorenew.NTSRepositoryItemCheck = Nothing
    Me.xx_valorenew.NTSRepositoryItemMemo = Nothing
    Me.xx_valorenew.NTSRepositoryItemText = Nothing
    Me.xx_valorenew.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
    Me.xx_valorenew.OptionsFilter.AllowFilter = False
    Me.xx_valorenew.Visible = True
    Me.xx_valorenew.VisibleIndex = 3
    '
    'tlbRecordCancella
    '
    Me.tlbRecordCancella.Caption = "Cancella"
    Me.tlbRecordCancella.Glyph = CType(resources.GetObject("tlbRecordCancella.Glyph"), System.Drawing.Image)
    Me.tlbRecordCancella.Id = 18
    Me.tlbRecordCancella.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F4))
    Me.tlbRecordCancella.Name = "tlbRecordCancella"
    Me.tlbRecordCancella.Visible = True
    '
    'FRM__AUTM
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(667, 366)
    Me.Controls.Add(Me.grAutm)
    Me.Controls.Add(Me.pnTop)
    Me.Controls.Add(Me.barDockControlLeft)
    Me.Controls.Add(Me.barDockControlRight)
    Me.Controls.Add(Me.barDockControlBottom)
    Me.Controls.Add(Me.barDockControlTop)
    Me.Name = "FRM__AUTM"
    Me.Text = "ELABORAZIONE IN GRIGLIA"
    CType(Me.NtsBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pnTop, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnTop.ResumeLayout(False)
    Me.pnTop.PerformLayout()
    CType(Me.grAutm, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grvAutm, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Public Overridable Sub InitControls()
    InitControlsBeginEndInit(Me, False)
    Try
      '-------------------------------------------------
      'carico le immagini della toolbar
      Try
        tlbElabora.GlyphPath = (oApp.ChildImageDir & "\elabora.gif")
        tlbRipristina.GlyphPath = (oApp.ChildImageDir & "\restore.gif")
        tlbRecordSalva.GlyphPath = (oApp.ChildImageDir & "\recagg.gif")
        tlbRecordCancella.GlyphPath = (oApp.ChildImageDir & "\recdelete.gif")
        tlbRecordRipristina.GlyphPath = (oApp.ChildImageDir & "\recrestore.gif")
        tlbZoom.GlyphPath = (oApp.ChildImageDir & "\zoom.gif")
        tlbStrumenti.GlyphPath = (oApp.ChildImageDir & "\options.gif")
        tlbGuida.GlyphPath = (oApp.ChildImageDir & "\help.gif")
        tlbEsci.GlyphPath = (oApp.ChildImageDir & "\exit.gif")
      Catch ex As Exception
        '  'non gestisco l'errore: se non c'� una immagine prendo quella standard
      End Try
      tlbMain.NTSSetToolTip()

      grvAutm.NTSSetParam(oMenu, oApp.Tr(Me, 128788387058196329, "Griglia elaborazione"))

      xx_cod.Enabled = False
      xx_descr.Enabled = False
      xx_campoold.Enabled = False

      grvAutm.NTSAllowInsert = False

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
  Public Overridable Sub InitEntity(ByRef cleVaan As CLE__VAAN)
    oCleVaan = cleVaan
    AddHandler oCleVaan.RemoteEvent, AddressOf GestisciEventiEntity
  End Sub

  Public Overridable Function Salva() As Boolean
    Try
      Me.ValidaLastControl()      'valido l'ultimo controllo che ha il focus

      Dim dRes As DialogResult
      dRes = grvAutm.NTSSalvaRigaCorrente(dcAutm, oCleVaan.AutmRecordIsChanged, False)
      Select Case dRes
        Case System.Windows.Forms.DialogResult.Yes
          'salvo
          '-------------------------------------------------
          'controllo che i campi abbiano un valore diverso da quello impostato in GCTL.OutNotEqual
          If GctlControllaOutNotEqual() = False Then Return False

          If Not oCleVaan.AutmSalva(False) Then
            Return False
          End If
        Case System.Windows.Forms.DialogResult.No
          'ripristino
          oCleVaan.AutmRipristina(dcAutm.Position, dcAutm.Filter)
        Case System.Windows.Forms.DialogResult.Cancel
          'non posso fare nulla
          Return False
        Case System.Windows.Forms.DialogResult.Abort
          'la riga non ha subito modifiche
      End Select
      Return True
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Function

#Region "EventiForm"

  Public Overridable Sub FRM__AUTM_ActivatedFirst(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ActivatedFirst
    Try
      '-------------------------------------------------
      'leggo dal database i dati e collego il NTSBindingNavigator
      If Not oCleVaan.AutmApri(DittaCorrente, dsAutm) Then Me.Close()

      dcAutm.DataSource = dsAutm.Tables("ANAGRA")
      grAutm.DataSource = dcAutm

      '-------------------------------------------------
      'sempre alla fine di questa funzione: applico le regole della gctl
      GctlSetRoules()
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub
  Public Overridable Sub FRM__AUTM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      '-------------------------------------------------
      'predispongo i controlli
      InitControls()

      InizializzaControlli()

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub
  Public Overridable Sub FRM__AUTM_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    Try
      dcAutm.Dispose()
      dsAutm.Dispose()
    Catch
    End Try
  End Sub
  Public Overridable Sub FRM__AUTM_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    If Not Salva() Then e.Cancel = True
  End Sub
#End Region

#Region "Eventi Toolbar"
  Public Overridable Sub tlbElabora_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbElabora.ItemClick
    Try
      Salva()

      If Not oCleVaan.ElaboraGriglia() Then Return

      Me.Close()

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub
  Public Overridable Sub tlbRipristina_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbRipristina.ItemClick
    Try
      Me.Close()
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub
  Public Overridable Sub tlbRecordSalva_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbRecordSalva.ItemClick
    Try
      Salva()
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub
  Public Overridable Sub tlbRecordCancella_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbRecordCancella.ItemClick
    Try
      If Not grvAutm.NTSDeleteRigaCorrente(dcAutm, True) Then Return
      oCleVaan.AutmSalva(True)
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub
  Public Overridable Sub tlbRecordRipristina_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbRecordRipristina.ItemClick
    Try
      If Not grvAutm.NTSRipristinaRigaCorrenteBefore(dcAutm, True) Then Return
      oCleVaan.AutmRipristina(dcAutm.Position, dcAutm.Filter)
      grvAutm.NTSRipristinaRigaCorrenteAfter()
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub
  Public Overridable Sub tlbZoom_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbZoom.ItemClick
    Dim ctrlTmp As Control = Nothing
    Dim oParam As New CLE__PATB
    Dim dttTmp As New DataTable

    Try
      '------------------------------------
      'zoom standard
      ctrlTmp = NTSFindControlForZoom()
      If ctrlTmp Is Nothing Then Return
      If ctrlTmp.GetType.ToString.IndexOf("NTSGrid") > -1 Then
        If grvAutm.FocusedColumn.Name = "xx_valorenew" Then
          Select Case strTabella.ToUpper
            Case "COMUNI"
              '--------------------------------------------
              'zoom anagra
              SetFastZoom(NTSCStr(grvAutm.EditingValue), oParam)    'abilito la gestione dello zoom veloce
              NTSZOOM.strIn = ""
              NTSZOOM.ZoomStrIn("ZOOMCOMUNI", DittaCorrente, oParam)
              If NTSZOOM.strIn <> "" Then
                If oMenu.ValCodiceDb(NTSZOOM.strIn, DittaCorrente, "COMUNI", "S", "", dttTmp) = True Then
                  grvAutm.SetFocusedValue(NTSCStr(dttTmp.Rows(0)!co_cap))
                End If
              End If
            Case Else
              '------------------------------------
              'zoom standard di textbox e griglia
              NTSCallStandardZoom()
          End Select
        End If
      Else
        '------------------------------------
        'zoom standard di textbox e griglia
        NTSCallStandardZoom()
      End If

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub tlbGuida_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbGuida.ItemClick
    SendKeys.Send("{F1}")
  End Sub
  Public Overridable Sub tlbEsci_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbEsci.ItemClick
    If Not Salva() Then Return
    Me.Close()
  End Sub
#End Region

#Region "EventiGriglia"
  Public Overridable Sub grvAutm_NTSBeforeRowUpdate(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs)
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
#End Region

  Public Overridable Sub InizializzaControlli()
    Dim dttTmp As New DataTable
    Try
      '--------------------------------------------------------------------------
      Select Case oCleVaan.strCampo
        '--- String
        Case "an_prov"
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 2)
        Case "an_porto"
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 1)
        Case "an_rating"
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 1)
        Case "an_codvfde"
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 4)
        Case "an_numdic", "an_numdicp"
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 7)
        Case "an_kpccee", "an_kpccee2", "an_rifricd", "an_rifrica"
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 8)
        Case "an_datdic", "an_datdicp", "an_scaddic"
          xx_valorenew.NTSSetParamDATA(oMenu, oCleVaan.strDescr, True)
        Case "an_cap"
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 9)
        Case "an_coddicv", "an_coddica"
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 12)
        Case "an_privato"
          xx_valorenew.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 1)
          '--- Integer
        Case "an_zona", "an_categ", "an_codese", "an_codpag", "an_agente", _
            "an_valuta", "an_claprov", "an_clascon", "an_vett", "an_agente2", _
            "an_codling", "an_codbanc", "an_agcontrop", "an_codntra", "an_codcana", _
            "an_codtpbf", "an_vett2", "an_codtcdc"
          xx_valorenew.NTSSetParamNUM(oMenu, oCleVaan.strDescr, "0", 4, 0, 9999)
        Case "an_listino"
          xx_valorenew.NTSSetParamNUM(oMenu, oCleVaan.strDescr, "0", 4, -2, 9999)
          '--- Altri Integer
        Case "an_mesees1", "an_mesees2"
          xx_valorenew.NTSSetParamNUM(oMenu, oCleVaan.strDescr, "0", 2, 0, 12)
        Case "an_giofiss"
          xx_valorenew.NTSSetParamNUM(oMenu, oCleVaan.strDescr, "0", 2, 0, 31)
          '--- Long
        Case "an_controp"
          xx_valorenew.NTSSetParamNUM(oMenu, oCleVaan.strDescr, "0", 9, 0, 999999999)
          '--- Valuta
        Case "an_maxdic"
          xx_valorenew.NTSSetParamNUM(oMenu, oCleVaan.strDescr, "0", 12, 0, 999999999999)
          '--- Combo (con valori S�-No)
        Case "an_spinc", "an_bolli"
          dttTmp.Columns.Add("cod", GetType(String))
          dttTmp.Columns.Add("val", GetType(String))
          dttTmp.Rows.Add(New Object() {"S", "S�"})
          dttTmp.Rows.Add(New Object() {"N", "No"})
          dttTmp.AcceptChanges()
          xx_valorenew.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
          xx_campoold.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
          '--- Altri Combo...
        Case "an_fatt"
          dttTmp.Columns.Add("cod", GetType(String))
          dttTmp.Columns.Add("val", GetType(String))
          dttTmp.Rows.Add(New Object() {"A", "Accompagnatoria"})
          dttTmp.Rows.Add(New Object() {"B", "Per bolla"})
          dttTmp.Rows.Add(New Object() {"D", "Riep. per Destin."})
          dttTmp.Rows.Add(New Object() {"R", "Riepilogativa"})
          dttTmp.AcceptChanges()
          xx_valorenew.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
          xx_campoold.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
        Case "an_gcons"
          dttTmp.Columns.Add("cod", GetType(String))
          dttTmp.Columns.Add("val", GetType(String))
          dttTmp.Rows.Add(New Object() {"8", "(Qualsiasi)"})
          dttTmp.Rows.Add(New Object() {"1", "Luned�"})
          dttTmp.Rows.Add(New Object() {"2", "Marted�"})
          dttTmp.Rows.Add(New Object() {"3", "Mercoled�"})
          dttTmp.Rows.Add(New Object() {"4", "Gioved�"})
          dttTmp.Rows.Add(New Object() {"5", "Venerd�"})
          dttTmp.Rows.Add(New Object() {"6", "Sabato"})
          dttTmp.Rows.Add(New Object() {"7", "Domenica"})
          dttTmp.AcceptChanges()
          xx_valorenew.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
          xx_campoold.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
        Case "an_usaem"
          dttTmp.Columns.Add("cod", GetType(String))
          dttTmp.Columns.Add("val", GetType(String))
          dttTmp.Rows.Add(New Object() {"N", "Microsoft Fax"})
          dttTmp.Rows.Add(New Object() {"S", "E-mail Internet"})
          dttTmp.Rows.Add(New Object() {"N", "WinFax PRO Symantec"})
          dttTmp.AcceptChanges()
          xx_valorenew.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
          xx_campoold.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
        Case "an_status"
          dttTmp.Columns.Add("cod", GetType(String))
          dttTmp.Columns.Add("val", GetType(String))
          dttTmp.Rows.Add(New Object() {"A", "Attivo"})
          dttTmp.Rows.Add(New Object() {"I", "Inattivo"})
          dttTmp.Rows.Add(New Object() {"P", "Potenziale"})
          dttTmp.AcceptChanges()
          xx_valorenew.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
          xx_campoold.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
        Case "an_perfatt"
          dttTmp.Columns.Add("cod", GetType(String))
          dttTmp.Columns.Add("val", GetType(String))
          dttTmp.Rows.Add(New Object() {" ", "(Qualsiasi)"})
          dttTmp.Rows.Add(New Object() {"G", "Giornaliera"})
          dttTmp.Rows.Add(New Object() {"M", "Mensile"})
          dttTmp.Rows.Add(New Object() {"Q", "Quattordicinale"})
          dttTmp.Rows.Add(New Object() {"S", "Settimanale"})
          dttTmp.AcceptChanges()
          xx_valorenew.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
          xx_campoold.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
        Case "an_tpsogiva"
          dttTmp.Columns.Add("cod", GetType(String))
          dttTmp.Columns.Add("val", GetType(String))
          dttTmp.Rows.Add(New Object() {"N", "Normale"})
          dttTmp.Rows.Add(New Object() {"L", "Escluso da Iva 11"})
          dttTmp.Rows.Add(New Object() {"I", "Intracee"})
          dttTmp.Rows.Add(New Object() {"E", "Extracee"})
          dttTmp.Rows.Add(New Object() {"R", "R.S.M."})
          dttTmp.Rows.Add(New Object() {"D", "Dogana"})
          dttTmp.AcceptChanges()
          xx_valorenew.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
          xx_campoold.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
        Case "an_trating"
          dttTmp.Columns.Add("cod", GetType(String))
          dttTmp.Columns.Add("val", GetType(String))
          dttTmp.Rows.Add(New Object() {"1", "Inderogabile"})
          dttTmp.Rows.Add(New Object() {"2", "Certo"})
          dttTmp.Rows.Add(New Object() {"3", "Incerto"})
          dttTmp.Rows.Add(New Object() {"4", "Inattendibile"})
          dttTmp.Rows.Add(New Object() {" ", "Non gestito"})
          dttTmp.AcceptChanges()
          xx_valorenew.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
          xx_campoold.NTSSetParamCMB(oMenu, oCleVaan.strDescr, dttTmp, "val", "cod")
        Case Else
          xx_valorenew.NTSSetParamSTR(oMenu, oCleVaan.strDescr, 0)
      End Select

      SettaTabellaZoom()

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Function SettaTabellaZoom() As Boolean
    Try
      xx_valorenew.NTSForzaVisZoom = False

      Select Case oCleVaan.strCampo
        Case "an_cap"
          strTabella = "COMUNI"
          xx_valorenew.NTSForzaVisZoom = True
        Case "an_controp"
          strTabella = "ANAGRA"
          xx_valorenew.NTSForzaVisZoom = True
        Case "an_zona"
          strTabella = "Zone"
          xx_valorenew.NTSSetParamZoom("ZOOMTABZONE")
        Case "an_categ"
          strTabella = "Cate"
          xx_valorenew.NTSSetParamZoom("ZOOMTABCATE")
        Case "an_codese"
          strTabella = "Civa"
          xx_valorenew.NTSSetParamZoom("ZOOMTABCIVA")
        Case "an_codpag"
          strTabella = "Paga"
          xx_valorenew.NTSSetParamZoom("ZOOMTABPAGA")
        Case "an_agente", "an_agente2"
          strTabella = "Cage"
          xx_valorenew.NTSSetParamZoom("ZOOMTABCAGE")
        Case "an_valuta"
          strTabella = "Valu"
          xx_valorenew.NTSSetParamZoom("ZOOMTABVALU")
        Case "an_claprov"
          strTabella = "Cpcl"
          xx_valorenew.NTSSetParamZoom("ZOOMTABCPCL")
        Case "an_clascon"
          strTabella = "Cscl"
          xx_valorenew.NTSSetParamZoom("ZOOMTABCSCL")
        Case "an_porto"
          strTabella = "Port"
          xx_valorenew.NTSSetParamZoom("ZOOMTABPORT")
        Case "an_vett", "an_vett2"
          strTabella = "Vett"
          xx_valorenew.NTSSetParamZoom("ZOOMTABVETT")
        Case "an_codling"
          strTabella = "Ling"
          xx_valorenew.NTSSetParamZoom("ZOOMTABLING")
        Case "an_codbanc"
          strTabella = "Banc"
          xx_valorenew.NTSSetParamZoom("ZOOMTABBANC")
        Case "an_codntra"
          strTabella = "Ntra"
          xx_valorenew.NTSSetParamZoom("ZOOMTABNTRA")
        Case "an_codcana"
          strTabella = "Cana"
          xx_valorenew.NTSSetParamZoom("ZOOMTABCANA")
        Case "an_codtpbf"
          strTabella = "Tpbf"
          xx_valorenew.NTSSetParamZoom("ZOOMTABTPBF")
        Case "an_codtcdc"
          strTabella = "Tcdc"
          xx_valorenew.NTSSetParamZoom("ZOOMTABTCDC")
        Case "an_coddica"
          strTabella = "Dica"
          xx_valorenew.NTSSetParamZoom("ZOOMTABDICA")
        Case "an_codvfde"
          strTabella = "Vfde"
          xx_valorenew.NTSSetParamZoom("ZOOMTABVFDE")
        Case Else
          strTabella = ""
          xx_valorenew.NTSSetParamZoom("")
          Exit Function
      End Select

      Return True

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Function

End Class