Partial Public Class FRM__FLDO
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
  Public WithEvents fmFiltri As NTSInformatica.NTSGroupBox
  Public WithEvents fmfiltriGlobali As NTSInformatica.NTSGroupBox
  Public WithEvents fmAnalisi As NTSInformatica.NTSGroupBox
  Public WithEvents ckScad As NTSInformatica.NTSCheckBox
  Public WithEvents ckContab As NTSInformatica.NTSCheckBox
  Public WithEvents ckFatture As NTSInformatica.NTSCheckBox
  Public WithEvents ckMagaz As NTSInformatica.NTSCheckBox
  Public WithEvents ckNote As NTSInformatica.NTSCheckBox
  Public WithEvents ckOrdini As NTSInformatica.NTSCheckBox
  Public WithEvents ckOfferte As NTSInformatica.NTSCheckBox
  Public WithEvents lbScenario As NTSInformatica.NTSLabel
  Public WithEvents cbScenario As NTSInformatica.NTSComboBox
  Public WithEvents edCommessa As NTSInformatica.NTSTextBoxNum
  Public WithEvents edEscomp As NTSInformatica.NTSTextBoxNum
  Public WithEvents edAnno As NTSInformatica.NTSTextBoxNum
  Public WithEvents edLead As NTSInformatica.NTSTextBoxNum
  Public WithEvents edClifor As NTSInformatica.NTSTextBoxNum
  Public WithEvents edOperatore As NTSInformatica.NTSTextBoxStr
  Public WithEvents edArticolo As NTSInformatica.NTSTextBoxStr
  Public WithEvents lbOperatore As NTSInformatica.NTSLabel
  Public WithEvents lbCommessa As NTSInformatica.NTSLabel
  Public WithEvents lbEscomp As NTSInformatica.NTSLabel
  Public WithEvents lbAnno As NTSInformatica.NTSLabel
  Public WithEvents lbDataA As NTSInformatica.NTSLabel
  Public WithEvents lbDataDa As NTSInformatica.NTSLabel
  Public WithEvents lbArticolo As NTSInformatica.NTSLabel
  Public WithEvents lbLead As NTSInformatica.NTSLabel
  Public WithEvents lbClifor As NTSInformatica.NTSLabel
  Public WithEvents edDataA As NTSInformatica.NTSTextBoxData
  Public WithEvents edDataDa As NTSInformatica.NTSTextBoxData
  Public WithEvents ckGriSoloUnDoc As NTSInformatica.NTSCheckBox
  Public WithEvents ckGriSoloArtFiltri As NTSInformatica.NTSCheckBox
  Public WithEvents tsFldo As NTSInformatica.NTSTabControl
  Public WithEvents NtsTabPage1 As NTSInformatica.NTSTabPage
  Public WithEvents pnFiltri As NTSInformatica.NTSPanel
  Public WithEvents NtsTabPage2 As NTSInformatica.NTSTabPage
  Public WithEvents pnGriglie As NTSInformatica.NTSPanel
  Public WithEvents NtsTabPage3 As NTSInformatica.NTSTabPage
  Public WithEvents pnFlusso As NTSInformatica.NTSPanel
  Public WithEvents pnFiltriSx As NTSInformatica.NTSPanel
  Public WithEvents grFiltri As NTSInformatica.NTSGrid
  Public WithEvents grvFiltri As NTSInformatica.NTSGridView
  Public WithEvents xx_nome As NTSInformatica.NTSGridColumn
  Public WithEvents xx_valoreda As NTSInformatica.NTSGridColumn
  Public WithEvents xx_valorea As NTSInformatica.NTSGridColumn
  Public WithEvents cmdLock As NTSInformatica.NTSButton
  Public WithEvents NtsSplitter3 As NTSInformatica.NTSSplitter
  Public WithEvents NtsSplitter2 As NTSInformatica.NTSSplitter
  Public WithEvents NtsSplitter1 As NTSInformatica.NTSSplitter
  Public WithEvents grTesta As NTSInformatica.NTSGrid
  Public WithEvents grvTesta As NTSInformatica.NTSGridView
  Public WithEvents et_tipork As NTSInformatica.NTSGridColumn
  Public WithEvents et_anno As NTSInformatica.NTSGridColumn
  Public WithEvents grCorpo As NTSInformatica.NTSGrid
  Public WithEvents grvCorpo As NTSInformatica.NTSGridView
  Public WithEvents ec_tipork As NTSInformatica.NTSGridColumn
  Public WithEvents ec_anno As NTSInformatica.NTSGridColumn
  Public WithEvents grPrin As NTSInformatica.NTSGrid
  Public WithEvents grvPrin As NTSInformatica.NTSGridView
  Public WithEvents pn_datreg As NTSInformatica.NTSGridColumn
  Public WithEvents pn_numreg As NTSInformatica.NTSGridColumn
  Public WithEvents grScad As NTSInformatica.NTSGrid
  Public WithEvents grvScad As NTSInformatica.NTSGridView
  Public WithEvents sc_conto As NTSInformatica.NTSGridColumn
  Public WithEvents xxc_conto As NTSInformatica.NTSGridColumn
  Public WithEvents et_serie As NTSInformatica.NTSGridColumn
  Public WithEvents et_numdoc As NTSInformatica.NTSGridColumn
  Public WithEvents et_datdoc As NTSInformatica.NTSGridColumn
  Public WithEvents et_riferim As NTSInformatica.NTSGridColumn
  Public WithEvents et_conto As NTSInformatica.NTSGridColumn
  Public WithEvents xx_conto As NTSInformatica.NTSGridColumn
  Public WithEvents et_coddest As NTSInformatica.NTSGridColumn
  Public WithEvents xx_coddest As NTSInformatica.NTSGridColumn
  Public WithEvents et_totdoc As NTSInformatica.NTSGridColumn
  Public WithEvents et_totdocv As NTSInformatica.NTSGridColumn
  Public WithEvents et_valuta As NTSInformatica.NTSGridColumn
  Public WithEvents xx_valuta As NTSInformatica.NTSGridColumn
  Public WithEvents et_cambio As NTSInformatica.NTSGridColumn
  Public WithEvents et_flevas As NTSInformatica.NTSGridColumn
  Public WithEvents et_rilasciato As NTSInformatica.NTSGridColumn
  Public WithEvents et_confermato As NTSInformatica.NTSGridColumn
  Public WithEvents et_tipobf As NTSInformatica.NTSGridColumn
  Public WithEvents xx_tipobf As NTSInformatica.NTSGridColumn
  Public WithEvents et_causale As NTSInformatica.NTSGridColumn
  Public WithEvents xx_causale As NTSInformatica.NTSGridColumn
  Public WithEvents et_magaz As NTSInformatica.NTSGridColumn
  Public WithEvents xx_magaz As NTSInformatica.NTSGridColumn
  Public WithEvents et_magaz2 As NTSInformatica.NTSGridColumn
  Public WithEvents xx_magaz2 As NTSInformatica.NTSGridColumn
  Public WithEvents et_magimp As NTSInformatica.NTSGridColumn
  Public WithEvents et_datcons As NTSInformatica.NTSGridColumn
  Public WithEvents et_codagen As NTSInformatica.NTSGridColumn
  Public WithEvents xx_codagen As NTSInformatica.NTSGridColumn
  Public WithEvents et_listino As NTSInformatica.NTSGridColumn
  Public WithEvents et_codese As NTSInformatica.NTSGridColumn
  Public WithEvents xx_codese As NTSInformatica.NTSGridColumn
  Public WithEvents et_controp As NTSInformatica.NTSGridColumn
  Public WithEvents xx_controp As NTSInformatica.NTSGridColumn
  Public WithEvents et_contfatt As NTSInformatica.NTSGridColumn
  Public WithEvents et_scont1 As NTSInformatica.NTSGridColumn
  Public WithEvents et_scont2 As NTSInformatica.NTSGridColumn
  Public WithEvents et_scopag As NTSInformatica.NTSGridColumn
  Public WithEvents et_codpaga As NTSInformatica.NTSGridColumn
  Public WithEvents xx_codpaga As NTSInformatica.NTSGridColumn
  Public WithEvents et_abi As NTSInformatica.NTSGridColumn
  Public WithEvents et_cab As NTSInformatica.NTSGridColumn
  Public WithEvents et_banc1 As NTSInformatica.NTSGridColumn
  Public WithEvents et_banc2 As NTSInformatica.NTSGridColumn
  Public WithEvents et_numpar As NTSInformatica.NTSGridColumn
  Public WithEvents et_datpar As NTSInformatica.NTSGridColumn
  Public WithEvents et_opnome As NTSInformatica.NTSGridColumn
  Public WithEvents et_note As NTSInformatica.NTSGridColumn
  Public WithEvents et_opinc As NTSInformatica.NTSGridColumn
  Public WithEvents et_coddest2 As NTSInformatica.NTSGridColumn
  Public WithEvents et_oggetto As NTSInformatica.NTSGridColumn
  Public WithEvents et_vers As NTSInformatica.NTSGridColumn
  Public WithEvents et_codlead As NTSInformatica.NTSGridColumn
  Public WithEvents xx_codlead As NTSInformatica.NTSGridColumn
  Public WithEvents tlbStrumenti As NTSInformatica.NTSBarSubItem
  Public WithEvents tlbGriTesta As NTSInformatica.NTSBarMenuItem
  Public WithEvents tlbGriCorpo As NTSInformatica.NTSBarMenuItem
  Public WithEvents tlbGriPrin As NTSInformatica.NTSBarMenuItem
  Public WithEvents tlbGriScad As NTSInformatica.NTSBarMenuItem
  Public WithEvents tlbGriReset As NTSInformatica.NTSBarMenuItem
  Public WithEvents ec_serie As NTSInformatica.NTSGridColumn
  Public WithEvents ec_numdoc As NTSInformatica.NTSGridColumn
  Public WithEvents ec_codart As NTSInformatica.NTSGridColumn
  Public WithEvents ec_descr As NTSInformatica.NTSGridColumn
  Public WithEvents ec_desint As NTSInformatica.NTSGridColumn
  Public WithEvents ec_unmis As NTSInformatica.NTSGridColumn
  Public WithEvents ec_colli As NTSInformatica.NTSGridColumn
  Public WithEvents ec_ump As NTSInformatica.NTSGridColumn
  Public WithEvents ec_quant As NTSInformatica.NTSGridColumn
  Public WithEvents ec_prezzo As NTSInformatica.NTSGridColumn
  Public WithEvents ec_prezvalc As NTSInformatica.NTSGridColumn
  Public WithEvents ec_preziva As NTSInformatica.NTSGridColumn
  Public WithEvents ec_valore As NTSInformatica.NTSGridColumn
  Public WithEvents ec_scont1 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_scont2 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_scont3 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_scont4 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_scont5 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_scont6 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_note As NTSInformatica.NTSGridColumn
  Public WithEvents ec_datcons As NTSInformatica.NTSGridColumn
  Public WithEvents ec_magaz As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_magaz As NTSInformatica.NTSGridColumn
  Public WithEvents ec_magaz2 As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_magaz2 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_quaeva As NTSInformatica.NTSGridColumn
  Public WithEvents ec_quapre As NTSInformatica.NTSGridColumn
  Public WithEvents ec_flevas As NTSInformatica.NTSGridColumn
  Public WithEvents ec_flevapre As NTSInformatica.NTSGridColumn
  Public WithEvents ec_provv As NTSInformatica.NTSGridColumn
  Public WithEvents ec_vprovv As NTSInformatica.NTSGridColumn
  Public WithEvents ec_controp As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_controp As NTSInformatica.NTSGridColumn
  Public WithEvents ec_codiva As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_codiva As NTSInformatica.NTSGridColumn
  Public WithEvents ec_stasino As NTSInformatica.NTSGridColumn
  Public WithEvents ec_prelist As NTSInformatica.NTSGridColumn
  Public WithEvents ec_codcfam As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_codcfam As NTSInformatica.NTSGridColumn
  Public WithEvents ec_commeca As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_commeca As NTSInformatica.NTSGridColumn
  Public WithEvents ec_subcommeca As NTSInformatica.NTSGridColumn
  Public WithEvents ec_codcena As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_codcena As NTSInformatica.NTSGridColumn
  Public WithEvents ec_confermato As NTSInformatica.NTSGridColumn
  Public WithEvents ec_rilasciato As NTSInformatica.NTSGridColumn
  Public WithEvents ec_aperto As NTSInformatica.NTSGridColumn
  Public WithEvents xx_lottox As NTSInformatica.NTSGridColumn
  Public WithEvents ec_ubicaz As NTSInformatica.NTSGridColumn
  Public WithEvents ec_causale As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_causale As NTSInformatica.NTSGridColumn
  Public WithEvents ec_causale2 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_fase As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_fase As NTSInformatica.NTSGridColumn
  Public WithEvents ec_misura1 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_misura2 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_misura3 As NTSInformatica.NTSGridColumn
  Public WithEvents ec_datini As NTSInformatica.NTSGridColumn
  Public WithEvents ec_datfin As NTSInformatica.NTSGridColumn
  Public WithEvents ec_ortipo As NTSInformatica.NTSGridColumn
  Public WithEvents ec_oranno As NTSInformatica.NTSGridColumn
  Public WithEvents ec_orserie As NTSInformatica.NTSGridColumn
  Public WithEvents ec_ornum As NTSInformatica.NTSGridColumn
  Public WithEvents ec_orriga As NTSInformatica.NTSGridColumn
  Public WithEvents ec_salcon As NTSInformatica.NTSGridColumn
  Public WithEvents ec_nptipo As NTSInformatica.NTSGridColumn
  Public WithEvents ec_npanno As NTSInformatica.NTSGridColumn
  Public WithEvents ec_npserie As NTSInformatica.NTSGridColumn
  Public WithEvents ec_npnum As NTSInformatica.NTSGridColumn
  Public WithEvents ec_npvers As NTSInformatica.NTSGridColumn
  Public WithEvents ec_npriga As NTSInformatica.NTSGridColumn
  Public WithEvents ec_pnsalcon As NTSInformatica.NTSGridColumn
  Public WithEvents ec_vers As NTSInformatica.NTSGridColumn
  Public WithEvents pn_riga As NTSInformatica.NTSGridColumn
  Public WithEvents pn_causale As NTSInformatica.NTSGridColumn
  Public WithEvents pn_descauc As NTSInformatica.NTSGridColumn
  Public WithEvents pn_conto As NTSInformatica.NTSGridColumn
  Public WithEvents xxp_conto As NTSInformatica.NTSGridColumn
  Public WithEvents pn_descr As NTSInformatica.NTSGridColumn
  Public WithEvents pn_darave As NTSInformatica.NTSGridColumn
  Public WithEvents pn_importo As NTSInformatica.NTSGridColumn
  Public WithEvents pn_dare As NTSInformatica.NTSGridColumn
  Public WithEvents pn_avere As NTSInformatica.NTSGridColumn
  Public WithEvents pn_datdoc As NTSInformatica.NTSGridColumn
  Public WithEvents pn_numdoc As NTSInformatica.NTSGridColumn
  Public WithEvents pn_alfdoc As NTSInformatica.NTSGridColumn
  Public WithEvents pn_controp As NTSInformatica.NTSGridColumn
  Public WithEvents xxp_controp As NTSInformatica.NTSGridColumn
  Public WithEvents pn_annpar As NTSInformatica.NTSGridColumn
  Public WithEvents pn_alfpar As NTSInformatica.NTSGridColumn
  Public WithEvents pn_numpar As NTSInformatica.NTSGridColumn
  Public WithEvents pn_codvalu As NTSInformatica.NTSGridColumn
  Public WithEvents xxp_codvalu As NTSInformatica.NTSGridColumn
  Public WithEvents pn_cambio As NTSInformatica.NTSGridColumn
  Public WithEvents pn_impval As NTSInformatica.NTSGridColumn
  Public WithEvents pn_dareval As NTSInformatica.NTSGridColumn
  Public WithEvents pn_avereval As NTSInformatica.NTSGridColumn
  Public WithEvents pn_tregiva As NTSInformatica.NTSGridColumn
  Public WithEvents pn_nregiva As NTSInformatica.NTSGridColumn
  Public WithEvents pn_codiva As NTSInformatica.NTSGridColumn
  Public WithEvents xxp_codiva As NTSInformatica.NTSGridColumn
  Public WithEvents pn_aliqiva As NTSInformatica.NTSGridColumn
  Public WithEvents pn_indetr As NTSInformatica.NTSGridColumn
  Public WithEvents pn_contocf As NTSInformatica.NTSGridColumn
  Public WithEvents xxp_contocf As NTSInformatica.NTSGridColumn
  Public WithEvents pn_imponib As NTSInformatica.NTSGridColumn
  Public WithEvents pn_imponibval As NTSInformatica.NTSGridColumn
  Public WithEvents pn_tipacq As NTSInformatica.NTSGridColumn
  Public WithEvents pn_numpro As NTSInformatica.NTSGridColumn
  Public WithEvents pn_alfpro As NTSInformatica.NTSGridColumn
  Public WithEvents pn_integr As NTSInformatica.NTSGridColumn
  Public WithEvents pn_fllg As NTSInformatica.NTSGridColumn
  Public WithEvents pn_dtcomiva As NTSInformatica.NTSGridColumn
  Public WithEvents pn_dtvaluta As NTSInformatica.NTSGridColumn
  Public WithEvents pn_dtcomplaf As NTSInformatica.NTSGridColumn
  Public WithEvents pn_datini As NTSInformatica.NTSGridColumn
  Public WithEvents pn_datfin As NTSInformatica.NTSGridColumn
  Public WithEvents pn_ultagg As NTSInformatica.NTSGridColumn
  Public WithEvents pn_opnome As NTSInformatica.NTSGridColumn
  Public WithEvents pn_escomp As NTSInformatica.NTSGridColumn
  Public WithEvents xxo_conto As NTSInformatica.NTSGridColumn
  Public WithEvents sc_darave As NTSInformatica.NTSGridColumn
  Public WithEvents sc_flsaldato As NTSInformatica.NTSGridColumn
  Public WithEvents sc_datdoc As NTSInformatica.NTSGridColumn
  Public WithEvents sc_alfdoc As NTSInformatica.NTSGridColumn
  Public WithEvents sc_numdoc As NTSInformatica.NTSGridColumn
  Public WithEvents sc_codpaga As NTSInformatica.NTSGridColumn
  Public WithEvents xxc_codpaga As NTSInformatica.NTSGridColumn
  Public WithEvents sc_tippaga As NTSInformatica.NTSGridColumn
  Public WithEvents sc_descr As NTSInformatica.NTSGridColumn
  Public WithEvents sc_causale As NTSInformatica.NTSGridColumn
  Public WithEvents xxc_causale As NTSInformatica.NTSGridColumn
  Public WithEvents sc_codvalu As NTSInformatica.NTSGridColumn
  Public WithEvents xxc_codvalu As NTSInformatica.NTSGridColumn
  Public WithEvents sc_cambio As NTSInformatica.NTSGridColumn
  Public WithEvents sc_insolu As NTSInformatica.NTSGridColumn
  Public WithEvents sc_codbanc As NTSInformatica.NTSGridColumn
  Public WithEvents xxc_codbanc As NTSInformatica.NTSGridColumn
  Public WithEvents sc_abi As NTSInformatica.NTSGridColumn
  Public WithEvents sc_cab As NTSInformatica.NTSGridColumn
  Public WithEvents sc_banc1 As NTSInformatica.NTSGridColumn
  Public WithEvents sc_banc2 As NTSInformatica.NTSGridColumn
  Public WithEvents sc_numcc As NTSInformatica.NTSGridColumn
  Public WithEvents sc_cin As NTSInformatica.NTSGridColumn
  Public WithEvents sc_prefiban As NTSInformatica.NTSGridColumn
  Public WithEvents sc_iban As NTSInformatica.NTSGridColumn
  Public WithEvents sc_alfpro As NTSInformatica.NTSGridColumn
  Public WithEvents sc_numprot As NTSInformatica.NTSGridColumn
  Public WithEvents sc_codcage As NTSInformatica.NTSGridColumn
  Public WithEvents xxc_codcage As NTSInformatica.NTSGridColumn
  Public WithEvents sc_controp As NTSInformatica.NTSGridColumn
  Public WithEvents xxc_controp As NTSInformatica.NTSGridColumn
  Public WithEvents sc_commeca As NTSInformatica.NTSGridColumn
  Public WithEvents xxc_commeca As NTSInformatica.NTSGridColumn
  Public WithEvents sc_subcommeca As NTSInformatica.NTSGridColumn
  Public WithEvents sc_fldis As NTSInformatica.NTSGridColumn
  Public WithEvents sc_dtdist As NTSInformatica.NTSGridColumn
  Public WithEvents sc_numdist As NTSInformatica.NTSGridColumn
  Public WithEvents sc_opdist As NTSInformatica.NTSGridColumn
  Public WithEvents sc_datreg As NTSInformatica.NTSGridColumn
  Public WithEvents sc_numreg As NTSInformatica.NTSGridColumn
  Public WithEvents sc_dtsaldato As NTSInformatica.NTSGridColumn
  Public WithEvents sc_rgsaldato As NTSInformatica.NTSGridColumn
  Public WithEvents sc_integr As NTSInformatica.NTSGridColumn
  Public WithEvents sc_datsca As NTSInformatica.NTSGridColumn
  Public WithEvents sc_importoda As NTSInformatica.NTSGridColumn
  Public WithEvents sc_impvalda As NTSInformatica.NTSGridColumn
  Public WithEvents sc_annpar As NTSInformatica.NTSGridColumn
  Public WithEvents sc_alfpar As NTSInformatica.NTSGridColumn
  Public WithEvents sc_numpar As NTSInformatica.NTSGridColumn
  Public WithEvents sc_numrata As NTSInformatica.NTSGridColumn
  Public WithEvents tlbApridoc As NTSInformatica.NTSBarMenuItem
  Public WithEvents tlbApriStampe As NTSInformatica.NTSBarMenuItem
  Public WithEvents ceFldo As NTSInformatica.NTSXXFLDO
  Public WithEvents tlbNoModal As NTSInformatica.NTSBarMenuItem
  Public WithEvents tlbCreaNewDoc As NTSInformatica.NTSBarMenuItem
  Public WithEvents tlbLocalizzaGoogle As NTSInformatica.NTSBarMenuItem
End Class
