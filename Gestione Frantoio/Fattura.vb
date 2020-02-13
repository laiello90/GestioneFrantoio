Public Class Fattura


    'totale
    Private Sub f_totale()


        Dim kg As Double
        Dim prezzo As Double
        Dim totale As Double
        Dim iva As Double
        Dim importoiva As Double
        Dim totale_con_iva As Double

        If Kg_di_oliveTextBox.Text = "" Then
        Else
            If Prezzo_al_KGTextBox.Text = "" Then
            Else
                If IvaTextBox.Text = "" Then
                Else
                        kg = Kg_di_oliveTextBox.Text
                        prezzo = Prezzo_al_KGTextBox.Text
                        totale = kg * prezzo
                        iva = IvaTextBox.Text
                        importoiva = (totale / 100) * iva
                        totale_con_iva = totale + importoiva
                        TotaleTextBox.Text = totale.ToString("0.00")
                        TotaleIvaTextBox.Text = importoiva.ToString("0.00")
                        TotaleTotTextBox.Text = totale_con_iva.ToString("0.00")
                End If
            End If
        End If

    End Sub

    'totale sansa
    Private Sub f_totale_sansa()

        Dim kg As Double
        Dim sansa As Double
        Dim percentuale As Double
        Dim IvaSansa As Double
        Dim totale As Double
        Dim importoIva As Double
        Dim totaleConIva As Double
        Dim prezzoSansa As Double

        If Prezzo_al_KG_SansaTextBox.Text = "" Then
        Else
            If Kg_di_oliveTextBox.Text = "" Then
            Else
                If Iva_SansaTextBox.Text = "" Then
                Else
                    kg = Kg_di_oliveTextBox.Text
                    percentuale = Impostazioni.Sansa.Text
                    sansa = (kg / 100) * percentuale
                    IvaSansa = Iva_SansaTextBox.Text
                    prezzoSansa = Prezzo_al_KG_SansaTextBox.Text

                    totale = sansa * prezzoSansa
                    importoIva = (totale / 100) * IvaSansa
                    totaleConIva = totale + importoIva

                    KgSansaTextBox.Text = sansa.ToString("0.00")
                    TotaleSansaTextBox.Text = totaleConIva.ToString("0.000")
                    TotSansaTextBox.Text = totale.ToString("0.00")
                    TotIvaSansaTextBox.Text = importoIva.ToString("0.00")
                End If
            End If
        End If

    End Sub

    'totale olio
    Private Sub f_olio()

        Dim kg As Double
        Dim olio As Double
        Dim percentuale As Double

        If Olio_SfusoTextBox.Text = "" Then
        Else
            If Kg_di_oliveTextBox.Text = "" Then
            Else
                kg = Kg_di_oliveTextBox.Text
                olio = Olio_SfusoTextBox.Text
                percentuale = (olio / kg) * 100
                Percentuale_MolituraTextBox.Text = percentuale.ToString("0.0")
            End If
        End If
    End Sub

    'salvataggio dati.
    Private Sub FattureBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FattureBindingNavigatorSaveItem.Click

        Try
            Dim id As Integer = IdTextBox.Text
            If id < 0 = True Then
                id = id * (-1)
                IdTextBox.Text = id
            End If

            Me.Validate()
            Me.FattureBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FattureDataSet)
            FattureBindingNavigator.AddNewItem = BindingNavigatorAddNewItem
            FattureBindingNavigator.AddNewItem = BindingNavigatorAddNewItem
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'caricamento form
    Private Sub Fattura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FattureDataSet.Fatture' table. You can move, or remove it, as needed.
        Me.FattureTableAdapter.Fill(Me.FattureDataSet.Fatture)
        Me.FattureBindingSource.MoveLast()
        lettura_scrittura()
        Label2.Text = "Numero ultima fattura: " & Impostazioni.PrecedenteFatturaTextBox.Text & " Numero ultima operazione giornaliera: " & Impostazioni.PrecedenteOpTextBox.Text
    End Sub

    'conto e caricamento prezzo e inserimento numero operazione e fattura nella form
    Private Sub Kg_di_oliveTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kg_di_oliveTextBox.TextChanged
        Try
            If Prezzo_al_KGTextBox.Text = "" Then
                Prezzo_al_KGTextBox.Text = Impostazioni.PrezzoTextBox.Text
            End If

            If IvaTextBox.Text = "" Then
                IvaTextBox.Text = Impostazioni.IvaTextBox.Text
            End If

            If Percentuale_MolituraTextBox.Text = "" Then
                Percentuale_MolituraTextBox.Text = Impostazioni.PercentualeTextBox.Text
            End If

            If Numero_FatturaTextBox.Text = "" Then
                Numero_FatturaTextBox.Text = Impostazioni.NFatturaTextBox.Text
            End If

            If Numero_OperazioneTextBox.Text = "" Then
                Numero_OperazioneTextBox.Text = Impostazioni.NOperazioneGiornaliera.Text
            End If

            If Prezzo_al_KG_SansaTextBox.Text = "" Then
                Prezzo_al_KG_SansaTextBox.Text = Impostazioni.PrezzoSansaTextBox.Text
            End If

            If Iva_SansaTextBox.Text = "" Then
                Iva_SansaTextBox.Text = Impostazioni.IvaSansaTextBox.Text
            End If

            If IdTextBox.Text = -1 Then
                IdTextBox.Text = Numero_FatturaTextBox.Text
            End If
            IdTextBox.Text = Numero_FatturaTextBox.Text
            'autoinserimento della data se non è gia stata impostata
            If Data_OperazioneTextBox.Text = "" Then
                DateTimePicker1.Value = Today
                Dim data As String = DateTimePicker1.Value.Day.ToString("00") & "/" & _
                                   DateTimePicker1.Value.Month.ToString("00") & "/" & _
                                 DateTimePicker1.Value.Year.ToString("0000")
                Data_OperazioneTextBox.Text = data
            End If
            ' If Kg_di_oliveTextBox.Text = "" Then
            'Else
            'Dim kg As Double = Kg_di_oliveTextBox.Text
            'Dim olio As Double
            'Dim percentuale As Double = Percentuale_MolituraTextBox.Text
            'olio = (kg / 100) * percentuale
            'Olio_SfusoTextBox.Text = olio
            'End If

            f_olio()
            f_totale_sansa()
            f_totale()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Prezzo_al_KGTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prezzo_al_KGTextBox.TextChanged
        f_totale()
    End Sub

    Private Sub IvaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IvaTextBox.TextChanged
        f_totale()
    End Sub

    Private Sub Prezzo_al_KG_SansaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prezzo_al_KG_SansaTextBox.TextChanged
        f_totale_sansa()
    End Sub

    Private Sub Iva_SansaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Iva_SansaTextBox.TextChanged
        f_totale_sansa()
    End Sub

    'olio
    Private Sub Olio_SfusoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Olio_SfusoTextBox.TextChanged
        f_olio()
    End Sub

    'ricerca per cognome 
    Private Sub PulsanteCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PulsanteCerca.Click
        Try
            Me.FattureTableAdapter.FillByCognome(Me.FattureDataSet.Fatture, CercaClientiTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CercaClientiTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CercaClientiTextBox.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Try
                Me.FattureTableAdapter.FillByCognome(Me.FattureDataSet.Fatture, CercaClientiTextBox.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'funzione di controllo
    Private Function controllo_dati_fattura()
        Try
            If CUAA_ClienteTextBox.Text.Length = 11 Then
            Else
                If CUAA_ClienteTextBox.Text.Length = 16 Then
                Else
                    MsgBox("La dimensione P.Iva o C.F. non valida.", MsgBoxStyle.Critical, "Errore")
                    Return 0
                End If
            End If

            If Denominazione_ClienteTextBox.Text.Length = 0 Then
                MsgBox("Inserire il nome.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            If CittàTextBox.Text.Length = 0 Then
                MsgBox("Inserire il comune di residenza.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            If ProvinciaTextBox.Text.Length = 0 Then
                MsgBox("Inserire la provincia.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            If IndirizzoTextBox.Text.Length = 0 Then
                MsgBox("Inserire l'indirizzo.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            If Kg_di_oliveTextBox.Text = "" Then
                MsgBox("Inserire la quantità in kg di olive molite.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            If Olio_SfusoTextBox.Text = "" Then
                MsgBox("Inserire la quantità di olio in kg.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If


            Return 1
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Return 0
        End Try


    End Function

    'scrittura sul file di upload
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ScritturaFileUpload()
        CreaFatturaElettronica()
    End Sub

    Private Sub ScritturaFileUpload()
        If (Numero_FatturaTextBox.Text = Impostazioni.PrecedenteFatturaTextBox.Text + 1) And (Numero_OperazioneTextBox.Text = Impostazioni.PrecedenteOpTextBox.Text + 1) Then
        Else
            Dim result As MsgBoxResult = MsgBox("I numeri fattura e operazione giornaliera sono esatti?", MsgBoxStyle.YesNo, "Info")
            Select Case result
                Case MsgBoxResult.No
                    Return
            End Select
        End If

        'controllo dati fattura.
        If controllo_dati_fattura() = 0 Then
            MsgBox("Errore. Ricontrollare i dati della fattura.", MsgBoxStyle.Critical, "Errore")
            Return
        End If

        'controllo che la fattura non sia già stata caricata
        If Caricato_CheckBox.CheckState = CheckState.Checked Then
            MsgBox("La molitura è gia stata caricata su file", MsgBoxStyle.Critical, "Errore")
        Else
            Dim checked As Integer = 0
            Try
                Caricato_CheckBox.CheckState = CheckState.Checked

                Dim id As Integer = IdTextBox.Text
                If id < 0 = True Then
                    id = id * (-1)
                    IdTextBox.Text = id
                End If

                Me.Validate()
                Me.FattureBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FattureDataSet)


                Try
                    'carico

                    Dim carico As New String(" ", 877)


                    'cuaa azienda
                    Dim CUAA As New String(" ", 16)
                    CUAA = CUAA.Insert(0, Ditta.PIVATextBox.Text)
                    carico = carico.Insert(0, CUAA)
                    carico = carico.Insert(16, ";")



                    'id stabilimento
                    Dim IDstabilimento As New String(" ", 10)
                    IDstabilimento = IDstabilimento.Insert(0, Impostazioni.StabilimentoTextBox.Text.ToString)
                    carico = carico.Insert(17, IDstabilimento)
                    carico = carico.Insert(27, ";")



                    'numero operazione giornaliera
                    Dim OpGiornaliera As Integer = Numero_OperazioneTextBox.Text
                    OpGiornaliera = (OpGiornaliera)
                    carico = carico.Insert(28, OpGiornaliera.ToString("0000000000"))
                    carico = carico.Insert(38, ";")


                    'data
                    carico = carico.Insert(39, Data_OperazioneTextBox.Text.Replace("/", ""))
                    carico = carico.Insert(47, ";")



                    'numero doc giustificativo e data (niente in caso di carico e scarico)


                    Dim numerofattura As New String(" ", 10)
                    numerofattura = numerofattura.Insert(0, ImpostazioniFattura.SezionaleTextBox.Text & "/" & Numero_FatturaTextBox.Text.ToString)
                    If numerofattura.Length > 10 Then
                        numerofattura = numerofattura.Remove(10)
                    End If
                    carico = carico.Insert(48, numerofattura & ";" & Data_OperazioneTextBox.Text.Replace("/", ""))
                    carico = carico.Insert(67, ";")





                    'codice operazione & cuaa cliente/committente ()

                    Dim cuaaOlivicoltore As Integer
                    'modifiche
                    cuaaOlivicoltore = CodiceTextBox.Text

                    carico = carico.Insert(68, "T0A       ;" & cuaaOlivicoltore.ToString("0000000000") & ";0000000000;")

                    'quantitativo giornaliero olive (campo n. 10)
                    Dim kgolive As Double = Kg_di_oliveTextBox.Text
                    carico = carico.Insert(101, kgolive.ToString("0000000000.000").Remove(10, 1) & ";")
                    carico = carico.Insert(115, kgolive.ToString("0000000000.000").Remove(10, 1))
                    carico = carico.Insert(128, ";")



                    'campi n. 12,13,14,15,16
                    carico = carico.Insert(129, "          ;          ;0000000000;00;02;")

                    'campo n. 17
                    carico = carico.Insert(168, "01;")

                    'campo 18 descr origine specifica,19 fine op, 20 fine op,21,22,23,24,25,26,27
                    Dim DescrOrigineOliveSpecifica As New String(" ", 80)

                    Dim oliosfuso As Double = Olio_SfusoTextBox.Text
                    carico = carico.Insert(171, DescrOrigineOliveSpecifica & ";01;" & DescrOrigineOliveSpecifica & ";0000000000000;0000000000000;" & oliosfuso.ToString("0000000000.000").Remove(10, 1) & ";" & oliosfuso.ToString("0000000000.000").Remove(10, 1) & ";0000000000000;0000000000000;0000000000000;")


                    'campo 28
                    carico = carico.Insert(434, "                    ;")

                    'note
                    Dim note As New String(" ", 300)
                    carico = carico.Insert(455, note)
                    carico = carico.Insert(755, ";")


                    'flag
                    carico = carico.Insert(756, "X; ; ; ; ; ; ; ; ; ; ;")


                    'data invio e tipo record
                    carico = carico.Insert(778, "                 ;                 ;0000;          ;          ;0000000000000;        ;          ;I;")
                    carico = carico.Remove(877)

                    'lettura da impostazioni del numero file registro
                    Dim NRegistroUpload As Integer = Impostazioni.NURegistro.Text

                    Dim nomefileupload As String = Ditta.PIVATextBox.Text & "_" & My.Computer.Clock.LocalTime.Year.ToString("0000") & _
                                                                My.Computer.Clock.LocalTime.Month.ToString("00") & _
                                                                My.Computer.Clock.LocalTime.Day.ToString("00") & "_" & _
                                                                NRegistroUpload.ToString("00000") & "_OPERREGI.txt"

                    'scrittura su file
                    My.Computer.FileSystem.WriteAllText(nomefileupload, carico & vbCrLf, True, System.Text.Encoding.ASCII)
                    checked = 1
                    MsgBox("Operazione T0A carico olive e molitura caricata correttamente sul file." & vbCrLf & "Si ricorda che è necessario caricare il file al SIAN entro oggi.", MsgBoxStyle.Information, "Info")
                    FattureBindingNavigator.AddNewItem = BindingNavigatorAddNewItem
                    Impostazioni.PrecedenteFatturaTextBox.Text = Numero_FatturaTextBox.Text
                    Impostazioni.PrecedenteOpTextBox.Text = Numero_OperazioneTextBox.Text
                    Label2.Text = "Numero ultima fattura: " & Impostazioni.PrecedenteFatturaTextBox.Text & " Numero ultima operazione giornaliera: " & Impostazioni.PrecedenteOpTextBox.Text
                    Impostazioni.NOperazioneGiornaliera.Text = Impostazioni.NOperazioneGiornaliera.Text + 1
                    Impostazioni.NFatturaTextBox.Text = Impostazioni.NFatturaTextBox.Text + 1
                    lettura_scrittura()
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                    If checked = 0 Then
                        Caricato_CheckBox.CheckState = CheckState.Unchecked
                    Else
                        MsgBox("Carico e molitura sono stati comunque caricati su file. Controllare il file di upload. Controllare il file.")
                        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\log.txt", "Registro " & BindingNavigatorPositionItem.Text & " " & My.Computer.Clock.LocalTime.ToString & " " & ex.Message.ToString & vbCrLf, False)
                    End If

                End Try

            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
                Caricato_CheckBox.CheckState = CheckState.Unchecked
            End Try

        End If
    End Sub


    'incremento numero operazione e numero fattura ad ogni nuova fattura
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        FattureBindingNavigator.AddNewItem = Nothing      ' Try
        Label2.Text = "Numero ultima fattura: " & Impostazioni.PrecedenteFatturaTextBox.Text & " Numero ultima operazione giornaliera: " & Impostazioni.PrecedenteOpTextBox.Text

        Clienti.Show()
        'Impostazioni.NOperazioneGiornaliera.Text = Impostazioni.NOperazioneGiornaliera.Text + 1
        'Impostazioni.NFatturaTextBox.Text = Impostazioni.NFatturaTextBox.Text + 1
        'Catch ex As System.Exception
        'System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    'inserimento data
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim data As String = DateTimePicker1.Value.Day.ToString("00") & "/" & _
                            DateTimePicker1.Value.Month.ToString("00") & "/" & _
                            DateTimePicker1.Value.Year.ToString("0000")

        Data_OperazioneTextBox.Text = data
    End Sub

    'chiusura pulsante cancellazione

    'fattura solo lettura oppure no
    Private Sub FattureBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FattureBindingSource.PositionChanged
        lettura_scrittura()
    End Sub

    Private Sub lettura_scrittura()
        If FattureBindingSource.Count = 0 Then
            CUAA_ClienteTextBox.ReadOnly = True
            Denominazione_ClienteTextBox.ReadOnly = True
            CittàTextBox.ReadOnly = True
            ProvinciaTextBox.ReadOnly = True
            IndirizzoTextBox.ReadOnly = True
            CAPTextBox.ReadOnly = True
            Numero_FatturaTextBox.ReadOnly = True
            Numero_OperazioneTextBox.ReadOnly = True
            Kg_di_oliveTextBox.ReadOnly = True
            Prezzo_al_KGTextBox.ReadOnly = True
            Percentuale_MolituraTextBox.ReadOnly = True
            Olio_SfusoTextBox.ReadOnly = True
            IvaTextBox.ReadOnly = True
            Button1.Enabled = False
            Prezzo_al_KG_SansaTextBox.ReadOnly = True
            KgSansaTextBox.ReadOnly = True
            Iva_SansaTextBox.ReadOnly = True
            CodiceTextBox.ReadOnly = True
            PECTextBox.ReadOnly = True
            NomeTextBox.ReadOnly = True
            CognomeTextBox.ReadOnly = True
            CodiceFattTextBox.ReadOnly = True
            BindingNavigatorDeleteItem.Enabled = False
        Else
            If Caricato_CheckBox.CheckState = CheckState.Checked Then
                Label7.Text = "L'operazione è gia stata caricata sul file di upload per il SIAN, non sarà possibile modificarla."
                CUAA_ClienteTextBox.ReadOnly = True
                Denominazione_ClienteTextBox.ReadOnly = True
                CittàTextBox.ReadOnly = True
                ProvinciaTextBox.ReadOnly = True
                IndirizzoTextBox.ReadOnly = True
                CAPTextBox.ReadOnly = True
                Numero_FatturaTextBox.ReadOnly = True
                Numero_OperazioneTextBox.ReadOnly = True
                Kg_di_oliveTextBox.ReadOnly = True
                Prezzo_al_KGTextBox.ReadOnly = True
                Percentuale_MolituraTextBox.ReadOnly = True
                Olio_SfusoTextBox.ReadOnly = True
                IvaTextBox.ReadOnly = True
                Button1.Enabled = False
                Prezzo_al_KG_SansaTextBox.ReadOnly = True
                KgSansaTextBox.ReadOnly = True
                Iva_SansaTextBox.ReadOnly = True
                BindingNavigatorDeleteItem.Enabled = False
                CodiceTextBox.ReadOnly = True
                PECTextBox.ReadOnly = True
                NomeTextBox.ReadOnly = True
                CognomeTextBox.ReadOnly = True
                CodiceFattTextBox.ReadOnly = True
            Else
                Label7.Text = ""
                CUAA_ClienteTextBox.ReadOnly = False
                Denominazione_ClienteTextBox.ReadOnly = False
                CittàTextBox.ReadOnly = False
                ProvinciaTextBox.ReadOnly = False
                IndirizzoTextBox.ReadOnly = False
                CAPTextBox.ReadOnly = False
                Numero_FatturaTextBox.ReadOnly = False
                Numero_OperazioneTextBox.ReadOnly = False
                Kg_di_oliveTextBox.ReadOnly = False
                Prezzo_al_KGTextBox.ReadOnly = False
                Percentuale_MolituraTextBox.ReadOnly = False
                Olio_SfusoTextBox.ReadOnly = False
                IvaTextBox.ReadOnly = False
                Button1.Enabled = True
                Prezzo_al_KG_SansaTextBox.ReadOnly = False
                KgSansaTextBox.ReadOnly = False
                Iva_SansaTextBox.ReadOnly = False
                BindingNavigatorDeleteItem.Enabled = True
                CodiceTextBox.ReadOnly = False
                PECTextBox.ReadOnly = False
                NomeTextBox.ReadOnly = False
                CognomeTextBox.ReadOnly = False
                CodiceFattTextBox.ReadOnly = False
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel1.Visible = False
    End Sub

    Private Sub CreaFatturaElettronica()
        Dim aziendale As Integer = 0

        Try
            FatturaElettronicaTextBox.Text = ""
            FatturaElettronicaTextBox.AppendText("<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<q1:FatturaElettronica xmlns:q1=""http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2"" versione=""FPR12"">" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<FatturaElettronicaHeader>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<DatiTrasmissione>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<IdTrasmittente>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<IdPaese>" & ImpostazioniFattura.IdPaeseTrasmittente.Text & "</IdPaese>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<IdCodice>" & ImpostazioniFattura.CodiceTrasmittenteTextBox.Text & "</IdCodice>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("</IdTrasmittente>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<ProgressivoInvio>" & Numero_FatturaTextBox.Text & "</ProgressivoInvio>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<FormatoTrasmissione>FPR12</FormatoTrasmissione>" & vbCrLf)

            If CUAA_ClienteTextBox.Text.Replace(" ", "").Length < 14 Then
                aziendale = 1
            End If

            If CodiceFattTextBox.Text.Replace(" ", "").Length = 7 Then
                FatturaElettronicaTextBox.AppendText("<CodiceDestinatario>" & CodiceFattTextBox.Text.Replace(" ", "") & "</CodiceDestinatario>" & vbCrLf)
            Else
                FatturaElettronicaTextBox.AppendText("<CodiceDestinatario>0000000</CodiceDestinatario>" & vbCrLf)
            End If
            If PECTextBox.Text.Replace(" ", "").Length > 0 And CodiceFattTextBox.Text.Replace(" ", "").Length <> 7 And CodiceFattTextBox.Text.Replace(" ", "") <> "0000000" Then
                FatturaElettronicaTextBox.AppendText("<PECDestinatario>" & PECTextBox.Text.Replace(" ", "") & "</PECDestinatario>" & vbCrLf)
            End If

            FatturaElettronicaTextBox.AppendText("</DatiTrasmissione>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<CedentePrestatore>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<DatiAnagrafici>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<IdFiscaleIVA>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<IdPaese>" & ImpostazioniFattura.IdPaeseDittaTextBox.Text & "</IdPaese>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<IdCodice>" & ImpostazioniFattura.IdCodiceDittaTextbox.Text & "</IdCodice>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</IdFiscaleIVA>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<CodiceFiscale>" & ImpostazioniFattura.CodiceFiscaleDittaTextbox.Text & "</CodiceFiscale>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Anagrafica>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Denominazione>" & ImpostazioniFattura.DenominazioneDittaTextBox.Text & "</Denominazione>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</Anagrafica>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<RegimeFiscale>" & ImpostazioniFattura.RegimeFiscaleTextBox.Text & "</RegimeFiscale>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</DatiAnagrafici>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Sede>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Indirizzo>" & ImpostazioniFattura.IndirizzoTextBox.Text & "</Indirizzo>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<CAP>" & ImpostazioniFattura.CAPTextBox.Text & "</CAP>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Comune>" & ImpostazioniFattura.ComuneTextBox.Text & "</Comune>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Provincia>" & ImpostazioniFattura.ProvinciaTextBox.Text & "</Provincia>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Nazione>" & ImpostazioniFattura.NazioneDittaTextBox.Text & "</Nazione>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</Sede>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<IscrizioneREA>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Ufficio>" & ImpostazioniFattura.UfficioREATextBox.Text & "</Ufficio>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<NumeroREA>" & ImpostazioniFattura.NumeroREATextBox.Text & "</NumeroREA>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<StatoLiquidazione>" & ImpostazioniFattura.LiquidazioneTextBox.Text & "</StatoLiquidazione>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</IscrizioneREA>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Contatti>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Telefono>" & ImpostazioniFattura.TelefonoTextBox.Text & "</Telefono>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Email>" & ImpostazioniFattura.EmailTextBox.Text & "</Email>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</Contatti>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</CedentePrestatore>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<CessionarioCommittente>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<DatiAnagrafici>" & vbCrLf)

            If aziendale = 1 Then
                FatturaElettronicaTextBox.AppendText("<IdFiscaleIVA>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<IdPaese>IT</IdPaese>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<IdCodice>" & CUAA_ClienteTextBox.Text.Replace(" ", "") & "</IdCodice>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</IdFiscaleIVA>" & vbCrLf)
            Else

                FatturaElettronicaTextBox.AppendText("<CodiceFiscale>" & CUAA_ClienteTextBox.Text.Replace(" ", "") & "</CodiceFiscale>" & vbCrLf)

            End If





            'If CF.Text.Replace(" ", "") <> "" And PartitaIvaTextBox.Text.Replace(" ", "") <> "" Then
            'MsgBox("Sono presenti sia codice fiscale che partita iva del cliente. Modificare")
            'Return
            'End If

            FatturaElettronicaTextBox.AppendText("<Anagrafica>" & vbCrLf)

            If aziendale = 1 Then
                FatturaElettronicaTextBox.AppendText("<Denominazione>" & Denominazione_ClienteTextBox.Text.Replace("&", "&amp;") & "</Denominazione>" & vbCrLf)
            Else
                FatturaElettronicaTextBox.AppendText("<Nome>" & NomeTextBox.Text & "</Nome>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Cognome>" & CognomeTextBox.Text & "</Cognome>" & vbCrLf)
            End If


            FatturaElettronicaTextBox.AppendText("</Anagrafica>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</DatiAnagrafici>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Sede>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Indirizzo>" & IndirizzoTextBox.Text & "</Indirizzo>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<CAP>" & CAPTextBox.Text & "</CAP>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Comune>" & CittàTextBox.Text & "</Comune>" & vbCrLf)
            Select Case ProvinciaTextBox.Text
                Case "SIRACUSA", "Siracusa"
                    FatturaElettronicaTextBox.AppendText("<Provincia>SR</Provincia>" & vbCrLf)
                Case "PALERMO", "Palermo"
                    FatturaElettronicaTextBox.AppendText("<Provincia>PA</Provincia>" & vbCrLf)
                Case "AGRIGENTO", "Agrigento"
                    FatturaElettronicaTextBox.AppendText("<Provincia>AG</Provincia>" & vbCrLf)
                Case "RAGUSA", "Ragusa"
                    FatturaElettronicaTextBox.AppendText("<Provincia>RG</Provincia>" & vbCrLf)
                Case "CATANIA", "Catania"
                    FatturaElettronicaTextBox.AppendText("<Provincia>CT</Provincia>" & vbCrLf)
                Case "TRAPANI", "Trapani"
                    FatturaElettronicaTextBox.AppendText("<Provincia>TP</Provincia>" & vbCrLf)
                Case "CALTANISSETTA", "Caltanissetta"
                    FatturaElettronicaTextBox.AppendText("<Provincia>CL</Provincia>" & vbCrLf)
                Case "ENNA", "Enna"
                    FatturaElettronicaTextBox.AppendText("<Provincia>EN</Provincia>" & vbCrLf)
                Case "MESSINA", "Messina"
                    FatturaElettronicaTextBox.AppendText("<Provincia>ME</Provincia>" & vbCrLf)
                Case Else
                    FatturaElettronicaTextBox.AppendText("<Provincia>" & ProvinciaTextBox.Text.Substring(ProvinciaTextBox.Text.Length - 2) & "</Provincia>" & vbCrLf)
            End Select

            FatturaElettronicaTextBox.AppendText("<Nazione>IT</Nazione>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("</Sede>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</CessionarioCommittente>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</FatturaElettronicaHeader>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<FatturaElettronicaBody>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<DatiGenerali>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<DatiGeneraliDocumento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<TipoDocumento>TD01</TipoDocumento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Divisa>EUR</Divisa>" & vbCrLf)

                Dim datafattura As Date = Data_OperazioneTextBox.Text
                FatturaElettronicaTextBox.AppendText("<Data>" & datafattura.ToString("yyyy-MM-dd") & "</Data>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<Numero>" & ImpostazioniFattura.SezionaleTextBox.Text & "/" & Numero_FatturaTextBox.Text & "</Numero>" & vbCrLf)

            Dim tot As Double = TotaleTotTextBox.Text
                FatturaElettronicaTextBox.AppendText("<ImportoTotaleDocumento>" & tot.ToString("#0.00").Replace(",", ".") & "</ImportoTotaleDocumento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</DatiGeneraliDocumento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</DatiGenerali>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<DatiBeniServizi>" & vbCrLf)


                FatturaElettronicaTextBox.AppendText("<DettaglioLinee>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<NumeroLinea>1</NumeroLinea>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<Descrizione>Molitura di olive al Kg. conto terzi</Descrizione>" & vbCrLf)
                Dim quantita As Double = Kg_di_oliveTextBox.Text
                FatturaElettronicaTextBox.AppendText("<Quantita>" & quantita.ToString("#0.00").Replace(",", ".") & "</Quantita>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<UnitaMisura>Kg.</UnitaMisura>" & vbCrLf)
                Dim prezzounitario As Double = Prezzo_al_KGTextBox.Text
                FatturaElettronicaTextBox.AppendText("<PrezzoUnitario>" & prezzounitario.ToString("#0.00").Replace(",", ".") & "</PrezzoUnitario>" & vbCrLf)
                Dim prezzotot As Double = TotaleTextBox.Text
                FatturaElettronicaTextBox.AppendText("<PrezzoTotale>" & prezzotot.ToString("#0.00").Replace(",", ".") & "</PrezzoTotale>" & vbCrLf)
                Dim iva As Double = IvaTextBox.Text
                FatturaElettronicaTextBox.AppendText("<AliquotaIVA>" & iva.ToString("#0.00").Replace(",", ".") & "</AliquotaIVA>" & vbCrLf)

            'riferimenti
            FatturaElettronicaTextBox.AppendText("<AltriDatiGestionali>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<TipoDato>DDT</TipoDato>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("<RiferimentoTesto>" & Numero_FatturaTextBox.Text & " del " & datafattura.ToString("yyyy-MM-dd") & "</RiferimentoTesto>" & vbCrLf)
            FatturaElettronicaTextBox.AppendText("</AltriDatiGestionali>" & vbCrLf)


            FatturaElettronicaTextBox.AppendText("</DettaglioLinee>" & vbCrLf)



                'iva   If iiva1.Text <> "0" Then
                FatturaElettronicaTextBox.AppendText("<DatiRiepilogo>" & vbCrLf)
                Dim ivaft As Double = IvaTextBox.Text
                FatturaElettronicaTextBox.AppendText("<AliquotaIVA>" & ivaft.ToString("#0.00").Replace(",", ".") & "</AliquotaIVA>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<ImponibileImporto>" & prezzotot.ToString("#0.00").Replace(",", ".") & "</ImponibileImporto>" & vbCrLf)
                Dim imposta As Double = TotaleIvaTextBox.Text
                FatturaElettronicaTextBox.AppendText("<Imposta>" & imposta.ToString("#0.00").Replace(",", ".") & "</Imposta>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<EsigibilitaIVA>I</EsigibilitaIVA>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</DatiRiepilogo>" & vbCrLf)


                FatturaElettronicaTextBox.AppendText("</DatiBeniServizi>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<DatiPagamento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<CondizioniPagamento>TP02</CondizioniPagamento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<DettaglioPagamento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<ModalitaPagamento>" & Pagamento.Text.Substring(0, 4) & "</ModalitaPagamento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("<ImportoPagamento>" & tot.ToString("#0.00").Replace(",", ".") & "</ImportoPagamento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</DettaglioPagamento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</DatiPagamento>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</FatturaElettronicaBody>" & vbCrLf)
                FatturaElettronicaTextBox.AppendText("</q1:FatturaElettronica>" & vbCrLf)

            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\" & ImpostazioniFattura.IdPaeseDittaTextBox.Text & ImpostazioniFattura.CodiceFiscaleDittaTextbox.Text & "_" & ImpostazioniFattura.SezionaleTextBox.Text & Numero_FatturaTextBox.Text.Replace(" ", "") & ".xml", FatturaElettronicaTextBox.Text, False)

            If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\Archivio Fatture Elettroniche") = False Then
                    My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\Archivio Fatture Elettroniche")
                End If
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\Archivio Fatture Elettroniche\" & ImpostazioniFattura.IdPaeseDittaTextBox.Text & ImpostazioniFattura.CodiceFiscaleDittaTextbox.Text & "_" & ImpostazioniFattura.SezionaleTextBox.Text & Numero_FatturaTextBox.Text.Replace(" ", "") & ".xml", FatturaElettronicaTextBox.Text, False)

            MsgBox("Fattura Elettronica creata", MsgBoxStyle.Information, "Conferma")

        Catch e As Exception
            MsgBox(e.Message.ToString, MsgBoxStyle.Critical, "Errore fattura elettronica")

        End Try


    End Sub

End Class