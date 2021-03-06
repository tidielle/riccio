Imports System.Data
Imports NTSInformatica.CLN__STD

Public Class FRMORSEOR
  Public oCallParams As CLE__CLDP
  Public bOk As Boolean
  Public oCleGsor As CLEORGSOR
  Public strTiporkOrig As String = ""     'utilizzato solo in duplicadoc

  Public WithEvents edNumero As NTSInformatica.NTSTextBoxNum
  Public WithEvents edSerie As NTSInformatica.NTSTextBoxStr
  Public WithEvents cbTipo As NTSInformatica.NTSComboBox
  Public WithEvents edAnno As NTSInformatica.NTSTextBoxNum
  Public WithEvents cmdAnnulla As NTSInformatica.NTSButton
  Public WithEvents cmdOk As NTSInformatica.NTSButton
  Public WithEvents lbNumero As NTSInformatica.NTSLabel
  Public WithEvents lbSerie As NTSInformatica.NTSLabel
  Public WithEvents lbAnno As NTSInformatica.NTSLabel
  Public WithEvents lbTipo As NTSInformatica.NTSLabel
  Public WithEvents lbContoLabel As NTSInformatica.NTSLabel
  Public WithEvents edConto As NTSInformatica.NTSTextBoxNum
  Public WithEvents lbTipoBfLabel As NTSInformatica.NTSLabel
  Public WithEvents edTipoBf As NTSInformatica.NTSTextBoxNum
  Public WithEvents lbTipoBf As NTSInformatica.NTSLabel
  Public WithEvents lbConto As NTSInformatica.NTSLabel
  Public WithEvents pnOrdine As NTSInformatica.NTSPanel


  Public Overridable Sub InitializeComponent()
    Me.edNumero = New NTSInformatica.NTSTextBoxNum
    Me.edSerie = New NTSInformatica.NTSTextBoxStr
    Me.cbTipo = New NTSInformatica.NTSComboBox
    Me.edAnno = New NTSInformatica.NTSTextBoxNum
    Me.cmdAnnulla = New NTSInformatica.NTSButton
    Me.cmdOk = New NTSInformatica.NTSButton
    Me.lbNumero = New NTSInformatica.NTSLabel
    Me.lbSerie = New NTSInformatica.NTSLabel
    Me.lbAnno = New NTSInformatica.NTSLabel
    Me.lbTipo = New NTSInformatica.NTSLabel
    Me.pnOrdine = New NTSInformatica.NTSPanel
    Me.lbContoLabel = New NTSInformatica.NTSLabel
    Me.edConto = New NTSInformatica.NTSTextBoxNum
    Me.lbTipoBfLabel = New NTSInformatica.NTSLabel
    Me.edTipoBf = New NTSInformatica.NTSTextBoxNum
    Me.lbTipoBf = New NTSInformatica.NTSLabel
    Me.lbConto = New NTSInformatica.NTSLabel
    CType(Me.edNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.edSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.edAnno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pnOrdine, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnOrdine.SuspendLayout()
    CType(Me.edConto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.edTipoBf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'frmPopup
    '
    Me.frmPopup.Appearance.BackColor = System.Drawing.SystemColors.Info
    Me.frmPopup.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
    Me.frmPopup.Appearance.Options.UseBackColor = True
    Me.frmPopup.Appearance.Options.UseImage = True
    '
    'frmAuto
    '
    Me.frmAuto.Appearance.BackColor = System.Drawing.Color.Black
    Me.frmAuto.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
    Me.frmAuto.Appearance.Options.UseBackColor = True
    Me.frmAuto.Appearance.Options.UseImage = True
    '
    'edNumero
    '
    Me.edNumero.Cursor = System.Windows.Forms.Cursors.Default
    Me.edNumero.EditValue = "0"
    Me.edNumero.Location = New System.Drawing.Point(68, 63)
    Me.edNumero.Name = "edNumero"
    Me.edNumero.NTSDbField = ""
    Me.edNumero.NTSFormat = "0"
    Me.edNumero.NTSForzaVisZoom = False
    Me.edNumero.NTSOldValue = ""
    Me.edNumero.Properties.Appearance.BackColor = System.Drawing.Color.White
    Me.edNumero.Properties.Appearance.Options.UseBackColor = True
    Me.edNumero.Properties.Appearance.Options.UseTextOptions = True
    Me.edNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.edNumero.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
    Me.edNumero.Properties.AppearanceDisabled.Options.UseForeColor = True
    Me.edNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
    Me.edNumero.Properties.MaxLength = 9
    Me.edNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.edNumero.Size = New System.Drawing.Size(152, 20)
    Me.edNumero.TabIndex = 8
    '
    'edSerie
    '
    Me.edSerie.Cursor = System.Windows.Forms.Cursors.Default
    Me.edSerie.EditValue = " "
    Me.edSerie.Location = New System.Drawing.Point(175, 31)
    Me.edSerie.Name = "edSerie"
    Me.edSerie.NTSDbField = ""
    Me.edSerie.NTSForzaVisZoom = False
    Me.edSerie.NTSOldValue = " "
    Me.edSerie.Properties.Appearance.BackColor = System.Drawing.Color.White
    Me.edSerie.Properties.Appearance.Options.UseBackColor = True
    Me.edSerie.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
    Me.edSerie.Properties.AppearanceDisabled.Options.UseForeColor = True
    Me.edSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
    Me.edSerie.Properties.MaxLength = 1
    Me.edSerie.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.edSerie.Size = New System.Drawing.Size(45, 20)
    Me.edSerie.TabIndex = 0
    '
    'cbTipo
    '
    Me.cbTipo.Cursor = System.Windows.Forms.Cursors.Default
    Me.cbTipo.DataSource = Nothing
    Me.cbTipo.DisplayMember = ""
    Me.cbTipo.Location = New System.Drawing.Point(68, 1)
    Me.cbTipo.Name = "cbTipo"
    Me.cbTipo.NTSDbField = ""
    Me.cbTipo.Properties.Appearance.BackColor = System.Drawing.Color.White
    Me.cbTipo.Properties.Appearance.Options.UseBackColor = True
    Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.cbTipo.Properties.DropDownRows = 30
    Me.cbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    Me.cbTipo.SelectedValue = ""
    Me.cbTipo.Size = New System.Drawing.Size(152, 20)
    Me.cbTipo.TabIndex = 0
    Me.cbTipo.ValueMember = ""
    '
    'edAnno
    '
    Me.edAnno.Cursor = System.Windows.Forms.Cursors.Default
    Me.edAnno.EditValue = "2008"
    Me.edAnno.Location = New System.Drawing.Point(68, 31)
    Me.edAnno.Name = "edAnno"
    Me.edAnno.NTSDbField = ""
    Me.edAnno.NTSFormat = "0"
    Me.edAnno.NTSForzaVisZoom = False
    Me.edAnno.NTSOldValue = "2008"
    Me.edAnno.Properties.Appearance.BackColor = System.Drawing.Color.White
    Me.edAnno.Properties.Appearance.Options.UseBackColor = True
    Me.edAnno.Properties.Appearance.Options.UseTextOptions = True
    Me.edAnno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.edAnno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
    Me.edAnno.Properties.AppearanceDisabled.Options.UseForeColor = True
    Me.edAnno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
    Me.edAnno.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.edAnno.Size = New System.Drawing.Size(65, 20)
    Me.edAnno.TabIndex = 0
    '
    'cmdAnnulla
    '
    Me.cmdAnnulla.ImageText = ""
    Me.cmdAnnulla.Location = New System.Drawing.Point(265, 36)
    Me.cmdAnnulla.Name = "cmdAnnulla"
    Me.cmdAnnulla.Size = New System.Drawing.Size(105, 24)
    Me.cmdAnnulla.TabIndex = 1
    Me.cmdAnnulla.Text = "&Annulla"
    '
    'cmdOk
    '
    Me.cmdOk.ImageText = ""
    Me.cmdOk.Location = New System.Drawing.Point(265, 7)
    Me.cmdOk.Name = "cmdOk"
    Me.cmdOk.Size = New System.Drawing.Size(105, 24)
    Me.cmdOk.TabIndex = 2
    Me.cmdOk.Text = "&Conferma"
    '
    'lbNumero
    '
    Me.lbNumero.AutoSize = True
    Me.lbNumero.BackColor = System.Drawing.Color.Transparent
    Me.lbNumero.Location = New System.Drawing.Point(3, 66)
    Me.lbNumero.Name = "lbNumero"
    Me.lbNumero.NTSDbField = ""
    Me.lbNumero.Size = New System.Drawing.Size(44, 13)
    Me.lbNumero.TabIndex = 3
    Me.lbNumero.Text = "Numero"
    Me.lbNumero.Tooltip = ""
    Me.lbNumero.UseMnemonic = False
    '
    'lbSerie
    '
    Me.lbSerie.AutoSize = True
    Me.lbSerie.BackColor = System.Drawing.Color.Transparent
    Me.lbSerie.Location = New System.Drawing.Point(142, 34)
    Me.lbSerie.Name = "lbSerie"
    Me.lbSerie.NTSDbField = ""
    Me.lbSerie.Size = New System.Drawing.Size(31, 13)
    Me.lbSerie.TabIndex = 4
    Me.lbSerie.Text = "Serie"
    Me.lbSerie.Tooltip = ""
    Me.lbSerie.UseMnemonic = False
    '
    'lbAnno
    '
    Me.lbAnno.AutoSize = True
    Me.lbAnno.BackColor = System.Drawing.Color.Transparent
    Me.lbAnno.Location = New System.Drawing.Point(3, 34)
    Me.lbAnno.Name = "lbAnno"
    Me.lbAnno.NTSDbField = ""
    Me.lbAnno.Size = New System.Drawing.Size(32, 13)
    Me.lbAnno.TabIndex = 5
    Me.lbAnno.Text = "Anno"
    Me.lbAnno.Tooltip = ""
    Me.lbAnno.UseMnemonic = False
    '
    'lbTipo
    '
    Me.lbTipo.AutoSize = True
    Me.lbTipo.BackColor = System.Drawing.Color.Transparent
    Me.lbTipo.Location = New System.Drawing.Point(3, 1)
    Me.lbTipo.Name = "lbTipo"
    Me.lbTipo.NTSDbField = ""
    Me.lbTipo.Size = New System.Drawing.Size(27, 13)
    Me.lbTipo.TabIndex = 6
    Me.lbTipo.Text = "Tipo"
    Me.lbTipo.Tooltip = ""
    Me.lbTipo.UseMnemonic = False
    '
    'pnOrdine
    '
    Me.pnOrdine.AllowDrop = True
    Me.pnOrdine.Appearance.BackColor = System.Drawing.Color.Transparent
    Me.pnOrdine.Appearance.Options.UseBackColor = True
    Me.pnOrdine.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.pnOrdine.Controls.Add(Me.lbTipo)
    Me.pnOrdine.Controls.Add(Me.edAnno)
    Me.pnOrdine.Controls.Add(Me.lbAnno)
    Me.pnOrdine.Controls.Add(Me.edSerie)
    Me.pnOrdine.Controls.Add(Me.lbSerie)
    Me.pnOrdine.Controls.Add(Me.cbTipo)
    Me.pnOrdine.Controls.Add(Me.lbNumero)
    Me.pnOrdine.Controls.Add(Me.edNumero)
    Me.pnOrdine.Cursor = System.Windows.Forms.Cursors.Default
    Me.pnOrdine.Location = New System.Drawing.Point(2, 8)
    Me.pnOrdine.Name = "pnOrdine"
    Me.pnOrdine.NTSActiveTrasparency = True
    Me.pnOrdine.Size = New System.Drawing.Size(230, 89)
    Me.pnOrdine.TabIndex = 9
    Me.pnOrdine.Text = "NtsPanel1"
    '
    'lbContoLabel
    '
    Me.lbContoLabel.AutoSize = True
    Me.lbContoLabel.BackColor = System.Drawing.Color.Transparent
    Me.lbContoLabel.Location = New System.Drawing.Point(5, 106)
    Me.lbContoLabel.Name = "lbContoLabel"
    Me.lbContoLabel.NTSDbField = ""
    Me.lbContoLabel.Size = New System.Drawing.Size(74, 13)
    Me.lbContoLabel.TabIndex = 10
    Me.lbContoLabel.Text = "Conto Cli/forn"
    Me.lbContoLabel.Tooltip = ""
    Me.lbContoLabel.UseMnemonic = False
    '
    'edConto
    '
    Me.edConto.Cursor = System.Windows.Forms.Cursors.Default
    Me.edConto.EditValue = "0"
    Me.edConto.Location = New System.Drawing.Point(97, 103)
    Me.edConto.Name = "edConto"
    Me.edConto.NTSDbField = ""
    Me.edConto.NTSFormat = "0"
    Me.edConto.NTSForzaVisZoom = False
    Me.edConto.NTSOldValue = ""
    Me.edConto.Properties.Appearance.BackColor = System.Drawing.Color.White
    Me.edConto.Properties.Appearance.Options.UseBackColor = True
    Me.edConto.Properties.Appearance.Options.UseTextOptions = True
    Me.edConto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.edConto.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
    Me.edConto.Properties.AppearanceDisabled.Options.UseForeColor = True
    Me.edConto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
    Me.edConto.Properties.MaxLength = 9
    Me.edConto.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.edConto.Size = New System.Drawing.Size(105, 20)
    Me.edConto.TabIndex = 11
    '
    'lbTipoBfLabel
    '
    Me.lbTipoBfLabel.AutoSize = True
    Me.lbTipoBfLabel.BackColor = System.Drawing.Color.Transparent
    Me.lbTipoBfLabel.Location = New System.Drawing.Point(5, 132)
    Me.lbTipoBfLabel.Name = "lbTipoBfLabel"
    Me.lbTipoBfLabel.NTSDbField = ""
    Me.lbTipoBfLabel.Size = New System.Drawing.Size(78, 13)
    Me.lbTipoBfLabel.TabIndex = 12
    Me.lbTipoBfLabel.Text = "Tipo bolla/fatt."
    Me.lbTipoBfLabel.Tooltip = ""
    Me.lbTipoBfLabel.UseMnemonic = False
    '
    'edTipoBf
    '
    Me.edTipoBf.Cursor = System.Windows.Forms.Cursors.Default
    Me.edTipoBf.EditValue = "0"
    Me.edTipoBf.Location = New System.Drawing.Point(97, 129)
    Me.edTipoBf.Name = "edTipoBf"
    Me.edTipoBf.NTSDbField = ""
    Me.edTipoBf.NTSFormat = "0"
    Me.edTipoBf.NTSForzaVisZoom = False
    Me.edTipoBf.NTSOldValue = ""
    Me.edTipoBf.Properties.Appearance.BackColor = System.Drawing.Color.White
    Me.edTipoBf.Properties.Appearance.Options.UseBackColor = True
    Me.edTipoBf.Properties.Appearance.Options.UseTextOptions = True
    Me.edTipoBf.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.edTipoBf.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
    Me.edTipoBf.Properties.AppearanceDisabled.Options.UseForeColor = True
    Me.edTipoBf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
    Me.edTipoBf.Properties.MaxLength = 9
    Me.edTipoBf.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.edTipoBf.Size = New System.Drawing.Size(105, 20)
    Me.edTipoBf.TabIndex = 13
    '
    'lbTipoBf
    '
    Me.lbTipoBf.BackColor = System.Drawing.Color.Transparent
    Me.lbTipoBf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lbTipoBf.Location = New System.Drawing.Point(208, 129)
    Me.lbTipoBf.Name = "lbTipoBf"
    Me.lbTipoBf.NTSDbField = ""
    Me.lbTipoBf.Size = New System.Drawing.Size(162, 20)
    Me.lbTipoBf.TabIndex = 50
    Me.lbTipoBf.Tooltip = ""
    Me.lbTipoBf.UseMnemonic = False
    '
    'lbConto
    '
    Me.lbConto.BackColor = System.Drawing.Color.Transparent
    Me.lbConto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lbConto.Location = New System.Drawing.Point(208, 103)
    Me.lbConto.Name = "lbConto"
    Me.lbConto.NTSDbField = ""
    Me.lbConto.Size = New System.Drawing.Size(162, 20)
    Me.lbConto.TabIndex = 51
    Me.lbConto.Tooltip = ""
    Me.lbConto.UseMnemonic = False
    '
    'FRMORSEOR
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(382, 156)
    Me.Controls.Add(Me.lbConto)
    Me.Controls.Add(Me.lbTipoBf)
    Me.Controls.Add(Me.lbTipoBfLabel)
    Me.Controls.Add(Me.edTipoBf)
    Me.Controls.Add(Me.lbContoLabel)
    Me.Controls.Add(Me.edConto)
    Me.Controls.Add(Me.pnOrdine)
    Me.Controls.Add(Me.cmdAnnulla)
    Me.Controls.Add(Me.cmdOk)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FRMORSEOR"
    Me.Text = "NUOVO/APRI ORDINE"
    CType(Me.edNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.edSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.edAnno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pnOrdine, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnOrdine.ResumeLayout(False)
    Me.pnOrdine.PerformLayout()
    CType(Me.edConto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.edTipoBf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

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

  Public Overridable Sub InitControls()
    InitControlsBeginEndInit(Me, False)
    Try

      edAnno.NTSSetParam(oMenu, oApp.Tr(Me, 128230023057311727, "Anno"), "0", 4, 1900, 2099)
      edSerie.NTSSetParam(oMenu, oApp.Tr(Me, 128230023057467900, "Serie"), CLN__STD.SerieMaxLen, False)
      cbTipo.NTSSetParam(oApp.Tr(Me, 128230023057624073, "Tipo documento"))
      edNumero.NTSSetParam(oMenu, oApp.Tr(Me, 128230023057780246, "Numero"), "0", 9, 0, 999999999)
      edConto.NTSSetParamTabe(oMenu, oApp.Tr(Me, 128602577224531250, "Conto cliente/fornitore"), tabanagrac)
      edTipoBf.NTSSetParamTabe(oMenu, oApp.Tr(Me, 128602577538750000, "Tipo bolla/fattura"), tabtpbf)

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

  Public Overridable Sub FRMORSEOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      '-------------------------------------------------
      'predispongo i controlli
      InitControls()

      '--------------------------------------------
      'sempre alla fine di questa funzione: applico le regole della gctl

      GctlSetRoules()
      GctlApplicaDefaultValue()

      cbTipo_SelectedValueChanged(cbTipo, Nothing)
    Catch ex As Exception
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
    End Try
  End Sub

  Public Overridable Sub FRMORSEOR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    Dim ctrlTmp As Control = Nothing
    Try
      '--------------------------------------------
      'gestione dello zoom:
      'eseguo la Zoom, tanto se per il controllo non deve venir eseguito uno zoom particolare, la routine non fa nulla e viene processato lo zoom standard del controllo, settato con la NTSSetParamZoom
      If e.KeyCode = Keys.F5 And e.Control = False And e.Alt = False And e.Shift = False Then
        Zoom()
        e.Handled = True    'altrimenti anche il controllo riceve l'F5 e la routine ZOOM viene eseguita 2 volte!!!
      End If

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub Zoom()
    Dim ctlLastControl As Control
    Dim ctrlTmp As Control = Nothing
    Dim oParam As New CLE__PATB

    Try
      'entro qui perch� nella FRM__HLAN_KeyDown ho inserito il seguente codice:
      'If e.KeyCode = Keys.F5 And e.Control = False And e.Alt = False And e.Shift = False Then
      '  Zoom()
      '  e.Handled = True
      'End If

      ctlLastControl = NTSFindControlFocused(Me)
      If ctlLastControl Is Nothing Then Return

      If edConto.Focused Then
        '----------------------------------------------
        'zoom cliente/fornitore
        SetFastZoom(edConto.Text, oParam)    'abilito la gestione dello zoom veloce
        NTSZOOM.strIn = edConto.Text
        oParam.bVisGriglia = True
        oParam.bTipoProposto = True
        oParam.nMastro = 0
        Select Case cbTipo.SelectedValue
          Case "R", "Q", "V"
            oParam.strTipo = "C"
          Case Else
            oParam.strTipo = "F"
        End Select
        NTSZOOM.ZoomStrIn("ZOOMANAGRA", DittaCorrente, oParam)
        If NTSZOOM.strIn <> edConto.Text Then edConto.NTSTextDB = NTSZOOM.strIn
      ElseIf edSerie.Focused Then
        '------------------------------------
        'zoom serie
        If NTSCInt(edAnno.Text) = 0 Then
          oApp.MsgBoxInfo(oApp.Tr(Me, 130512728416683717, "Indicare prima l'anno"))
          Return
        End If
        SetFastZoom(edSerie.Text, oParam)    'abilito la gestione dello zoom veloce
        oParam.strDescr = NTSCStr(cbTipo.SelectedValue)
        oParam.lContoCF = NTSCInt(edAnno.Text)
        NTSZOOM.strIn = ""
        NTSZOOM.ZoomStrIn("ZOOMSERIE", DittaCorrente, oParam)
        If oParam.strOut <> "" Then edSerie.NTSTextDB = oParam.strOut
      Else
        '------------------------------------
        'zoom standard di textbox e griglia
        'SendKeys.SendWait("{F5}") 'se faccio questa riga va in un loop infinito....
        NTSCallStandardZoom()
      End If
      '------------------------------------
      'riporto il focus sul controllo che ha chiamato lo zoom
      ctlLastControl.Focus()

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------
    End Try
  End Sub



  Public Overridable Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
    Try
      '--------------------------------------------------------------------------------------------------------------
      If (edConto.Visible = True) And (edConto.Enabled = True) Then
        If NTSCInt(edConto.Text) = 0 Then
          oApp.MsgBoxErr(oApp.Tr(Me, 129676580977513233, "Attenzione!" & vbCrLf & _
            "Indicare un conto Cliente/Fornitore valido."))
          Return
        End If
      End If
      If (edTipoBf.Visible = True) And (edTipoBf.Enabled = True) Then
        If NTSCInt(edTipoBf.Text) = 0 Then
          oApp.MsgBoxErr(oApp.Tr(Me, 129676581849635148, "Attenzione!" & vbCrLf & _
            "Indicare un tipo Bolla/Fattura valido."))
          Return
        End If
      End If
      If Not oCleGsor.CheckSoloSerieInTRKTPBF(DittaCorrente, cbTipo.SelectedValue, _
                         edSerie.Text) Then
        Return
      End If
      '--------------------------------------------------------------------------------------------------------------
      bOk = True
      Me.Close()
    Catch ex As Exception
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
    End Try
  End Sub

  Public Overridable Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
    Try
      bOk = False
      Me.Close()
    Catch ex As Exception
      Dim strErr As String = GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
    End Try
  End Sub


  Public Overridable Sub cbTipo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedValueChanged
    Dim strSoloSerie As String = ""
    Try
      strSoloSerie = oMenu.GetSettingBusDitt(DittaCorrente, "Bsorgsor", "OpzioniDocUt", ".", "SoloSerie", "?", cbTipo.SelectedValue.ToString(), "?")
      If strSoloSerie = "" Then strSoloSerie = " "
      If strSoloSerie <> "?" Then
        edSerie.Text = strSoloSerie
        edSerie.Enabled = False
      Else
        GctlSetVisEnab(edSerie, False)
      End If

      ProponiNumdoc()

      '-----------------------
      'nel caso di duplica documento abilito/disabilito la possibilit� di cembiare conto/tipobf
      If strTiporkOrig <> "" Then
        If ((strTiporkOrig = "R" Or strTiporkOrig = "#") And (cbTipo.SelectedValue = "O" Or cbTipo.SelectedValue = "H")) Or _
            (strTiporkOrig = "Q" And cbTipo.SelectedValue = "O") Then
          GctlSetVisEnab(edConto, False)
          GctlSetVisEnab(edTipoBf, False)
        Else
          edConto.Enabled = False
          edConto.Text = "0"
          lbConto.Text = ""
          edTipoBf.Enabled = False
          edTipoBf.Text = "0"
          lbTipoBf.Text = ""
        End If
      End If
      NTSGetDataAutocompletamentoTipork = cbTipo.SelectedValue 'per filtrare solo i tipibf utilizzabili per questo tipork

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------	
    End Try
  End Sub

  Public Overridable Sub edAnno_ValidatedAndChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edAnno.ValidatedAndChanged
    Try
      ProponiNumdoc()
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------	
    End Try
  End Sub

  Public Overridable Sub edSerie_ValidatedAndChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edSerie.ValidatedAndChanged
    Dim strTmp As String = ""
    Try
      strTmp = TestSerieMaxLen(edSerie.Text, False)
      If strTmp <> edSerie.Text Then edSerie.Text = strTmp

      ProponiNumdoc()
    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------	
    End Try
  End Sub

  Public Overridable Sub edConto_ValidatedAndChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edConto.ValidatedAndChanged
    Dim strTmp As String = ""
    Try
      If oCleGsor Is Nothing Then Return
      If Not oCleGsor.Bnorseor_edConto_Validated(NTSCInt(edConto.Text), strTmp) Then
        edConto.Text = NTSCStr(edConto.OldEditValue)
      Else
        lbConto.Text = strTmp
      End If

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------	
    End Try
  End Sub

  Public Overridable Sub edTipoBf_ValidatedAndChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edTipoBf.ValidatedAndChanged
    Dim strTmp As String = ""
    Try
      If oCleGsor Is Nothing Then Return
      If Not oCleGsor.Bnorseor_edTipoBf_Validated(NTSCInt(edTipoBf.Text), strTmp) Then
        edTipoBf.Text = NTSCStr(edTipoBf.OldEditValue)
      Else
        lbTipoBf.Text = strTmp
      End If

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------	
    End Try
  End Sub

  Public Overridable Function ProponiNumdoc() As Boolean
    'al cambio di tipo, anno, serie documento propongo il num documento
    Dim lNewProgr As Integer = 0
    Try
      If cbTipo.SelectedValue <> "" Then
        lNewProgr = oCleGsor.LegNuma(IIf(cbTipo.SelectedValue.ToString() = "V", "VV", cbTipo.SelectedValue.ToString()).ToString, edSerie.Text, NTSCInt(edAnno.Text))
      End If
      edNumero.Text = lNewProgr.ToString

      Return True

    Catch ex As Exception
      '-------------------------------------------------
      Dim strErr As String = CLN__STD.GestError(ex, Me, "", oApp.InfoError, oApp.ErrorLogFile, True)
      '-------------------------------------------------	
    End Try
  End Function

End Class
