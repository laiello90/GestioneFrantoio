<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fattura
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim Numero_OperazioneLabel As System.Windows.Forms.Label
        Dim Data_OperazioneLabel As System.Windows.Forms.Label
        Dim Numero_FatturaLabel As System.Windows.Forms.Label
        Dim CUAA_ClienteLabel As System.Windows.Forms.Label
        Dim Denominazione_ClienteLabel As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim CittàLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim CAPLabel As System.Windows.Forms.Label
        Dim Kg_di_oliveLabel As System.Windows.Forms.Label
        Dim Percentuale_MolituraLabel As System.Windows.Forms.Label
        Dim Olio_SfusoLabel As System.Windows.Forms.Label
        Dim Prezzo_al_KGLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim Iva_SansaLabel As System.Windows.Forms.Label
        Dim Prezzo_al_KG_SansaLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim CodiceLabel As System.Windows.Forms.Label
        Dim PECLabel As System.Windows.Forms.Label
        Dim CodiceFattLabel As System.Windows.Forms.Label
        Dim CognomeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fattura))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotaleTotTextBox = New System.Windows.Forms.TextBox()
        Me.TotaleIvaTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotaleTextBox = New System.Windows.Forms.TextBox()
        Me.FattureDataSet = New Gestione_Frantoio.FattureDataSet()
        Me.FattureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FattureTableAdapter = New Gestione_Frantoio.FattureDataSetTableAdapters.FattureTableAdapter()
        Me.TableAdapterManager = New Gestione_Frantoio.FattureDataSetTableAdapters.TableAdapterManager()
        Me.FattureBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FattureBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CercaClientiTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.PulsanteCerca = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_OperazioneTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_FatturaTextBox = New System.Windows.Forms.TextBox()
        Me.CUAA_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Denominazione_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.CittàTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.CAPTextBox = New System.Windows.Forms.TextBox()
        Me.Kg_di_oliveTextBox = New System.Windows.Forms.TextBox()
        Me.Percentuale_MolituraTextBox = New System.Windows.Forms.TextBox()
        Me.Olio_SfusoTextBox = New System.Windows.Forms.TextBox()
        Me.Prezzo_al_KGTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.Caricato_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Data_OperazioneTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Iva_SansaTextBox = New System.Windows.Forms.TextBox()
        Me.Prezzo_al_KG_SansaTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TotaleSansaTextBox = New System.Windows.Forms.TextBox()
        Me.KgSansaTextBox = New System.Windows.Forms.TextBox()
        Me.TotSansaTextBox = New System.Windows.Forms.TextBox()
        Me.TotIvaSansaTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CodiceTextBox = New System.Windows.Forms.TextBox()
        Me.FatturaElettronicaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Pagamento = New System.Windows.Forms.ComboBox()
        Me.PECTextBox = New System.Windows.Forms.TextBox()
        Me.CodiceFattTextBox = New System.Windows.Forms.TextBox()
        Me.CognomeTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        Numero_OperazioneLabel = New System.Windows.Forms.Label()
        Data_OperazioneLabel = New System.Windows.Forms.Label()
        Numero_FatturaLabel = New System.Windows.Forms.Label()
        CUAA_ClienteLabel = New System.Windows.Forms.Label()
        Denominazione_ClienteLabel = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        CittàLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        CAPLabel = New System.Windows.Forms.Label()
        Kg_di_oliveLabel = New System.Windows.Forms.Label()
        Percentuale_MolituraLabel = New System.Windows.Forms.Label()
        Olio_SfusoLabel = New System.Windows.Forms.Label()
        Prezzo_al_KGLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        Iva_SansaLabel = New System.Windows.Forms.Label()
        Prezzo_al_KG_SansaLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CodiceLabel = New System.Windows.Forms.Label()
        PECLabel = New System.Windows.Forms.Label()
        CodiceFattLabel = New System.Windows.Forms.Label()
        CognomeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.FattureDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FattureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FattureBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FattureBindingNavigator.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(330, 485)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 18)
        IdLabel.TabIndex = 45
        IdLabel.Text = "id:"
        '
        'Numero_OperazioneLabel
        '
        Numero_OperazioneLabel.AutoSize = True
        Numero_OperazioneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Numero_OperazioneLabel.Location = New System.Drawing.Point(45, 324)
        Numero_OperazioneLabel.Name = "Numero_OperazioneLabel"
        Numero_OperazioneLabel.Size = New System.Drawing.Size(223, 18)
        Numero_OperazioneLabel.TabIndex = 47
        Numero_OperazioneLabel.Text = "Numero Operazione Giornaliera:"
        '
        'Data_OperazioneLabel
        '
        Data_OperazioneLabel.AutoSize = True
        Data_OperazioneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_OperazioneLabel.Location = New System.Drawing.Point(330, 287)
        Data_OperazioneLabel.Name = "Data_OperazioneLabel"
        Data_OperazioneLabel.Size = New System.Drawing.Size(124, 18)
        Data_OperazioneLabel.TabIndex = 49
        Data_OperazioneLabel.Text = "Data Operazione:"
        '
        'Numero_FatturaLabel
        '
        Numero_FatturaLabel.AutoSize = True
        Numero_FatturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Numero_FatturaLabel.Location = New System.Drawing.Point(45, 287)
        Numero_FatturaLabel.Name = "Numero_FatturaLabel"
        Numero_FatturaLabel.Size = New System.Drawing.Size(147, 18)
        Numero_FatturaLabel.TabIndex = 51
        Numero_FatturaLabel.Text = "Numero Fattura: FTF"
        '
        'CUAA_ClienteLabel
        '
        CUAA_ClienteLabel.AutoSize = True
        CUAA_ClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CUAA_ClienteLabel.Location = New System.Drawing.Point(457, 84)
        CUAA_ClienteLabel.Name = "CUAA_ClienteLabel"
        CUAA_ClienteLabel.Size = New System.Drawing.Size(138, 18)
        CUAA_ClienteLabel.TabIndex = 53
        CUAA_ClienteLabel.Text = "C.F. o P.Iva Cliente:"
        '
        'Denominazione_ClienteLabel
        '
        Denominazione_ClienteLabel.AutoSize = True
        Denominazione_ClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Denominazione_ClienteLabel.Location = New System.Drawing.Point(9, 84)
        Denominazione_ClienteLabel.Name = "Denominazione_ClienteLabel"
        Denominazione_ClienteLabel.Size = New System.Drawing.Size(116, 18)
        Denominazione_ClienteLabel.TabIndex = 55
        Denominazione_ClienteLabel.Text = "Denominazione:"
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndirizzoLabel.Location = New System.Drawing.Point(457, 150)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(67, 18)
        IndirizzoLabel.TabIndex = 57
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'CittàLabel
        '
        CittàLabel.AutoSize = True
        CittàLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CittàLabel.Location = New System.Drawing.Point(9, 150)
        CittàLabel.Name = "CittàLabel"
        CittàLabel.Size = New System.Drawing.Size(69, 18)
        CittàLabel.TabIndex = 59
        CittàLabel.Text = "Comune:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProvinciaLabel.Location = New System.Drawing.Point(235, 150)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(73, 18)
        ProvinciaLabel.TabIndex = 61
        ProvinciaLabel.Text = "Provincia:"
        '
        'CAPLabel
        '
        CAPLabel.AutoSize = True
        CAPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CAPLabel.Location = New System.Drawing.Point(12, 185)
        CAPLabel.Name = "CAPLabel"
        CAPLabel.Size = New System.Drawing.Size(54, 18)
        CAPLabel.TabIndex = 63
        CAPLabel.Text = "C.A.P.:"
        '
        'Kg_di_oliveLabel
        '
        Kg_di_oliveLabel.AutoSize = True
        Kg_di_oliveLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Kg_di_oliveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Kg_di_oliveLabel.Location = New System.Drawing.Point(45, 372)
        Kg_di_oliveLabel.Name = "Kg_di_oliveLabel"
        Kg_di_oliveLabel.Size = New System.Drawing.Size(123, 18)
        Kg_di_oliveLabel.TabIndex = 65
        Kg_di_oliveLabel.Text = "Kg di olive molite:"
        '
        'Percentuale_MolituraLabel
        '
        Percentuale_MolituraLabel.AutoSize = True
        Percentuale_MolituraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Percentuale_MolituraLabel.Location = New System.Drawing.Point(330, 372)
        Percentuale_MolituraLabel.Name = "Percentuale_MolituraLabel"
        Percentuale_MolituraLabel.Size = New System.Drawing.Size(64, 18)
        Percentuale_MolituraLabel.TabIndex = 67
        Percentuale_MolituraLabel.Text = "Resa %:"
        '
        'Olio_SfusoLabel
        '
        Olio_SfusoLabel.AutoSize = True
        Olio_SfusoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Olio_SfusoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Olio_SfusoLabel.Location = New System.Drawing.Point(330, 407)
        Olio_SfusoLabel.Name = "Olio_SfusoLabel"
        Olio_SfusoLabel.Size = New System.Drawing.Size(114, 18)
        Olio_SfusoLabel.TabIndex = 69
        Olio_SfusoLabel.Text = "Olio Sfuso (Kg):"
        '
        'Prezzo_al_KGLabel
        '
        Prezzo_al_KGLabel.AutoSize = True
        Prezzo_al_KGLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prezzo_al_KGLabel.Location = New System.Drawing.Point(45, 407)
        Prezzo_al_KGLabel.Name = "Prezzo_al_KGLabel"
        Prezzo_al_KGLabel.Size = New System.Drawing.Size(166, 18)
        Prezzo_al_KGLabel.TabIndex = 71
        Prezzo_al_KGLabel.Text = "Prezzo molitura al Kg €:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IvaLabel.Location = New System.Drawing.Point(582, 407)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(47, 18)
        IvaLabel.TabIndex = 73
        IvaLabel.Text = "Iva %:"
        '
        'Iva_SansaLabel
        '
        Iva_SansaLabel.AutoSize = True
        Iva_SansaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Iva_SansaLabel.Location = New System.Drawing.Point(491, 442)
        Iva_SansaLabel.Name = "Iva_SansaLabel"
        Iva_SansaLabel.Size = New System.Drawing.Size(93, 18)
        Iva_SansaLabel.TabIndex = 82
        Iva_SansaLabel.Text = "Iva Sansa %:"
        '
        'Prezzo_al_KG_SansaLabel
        '
        Prezzo_al_KG_SansaLabel.AutoSize = True
        Prezzo_al_KG_SansaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prezzo_al_KG_SansaLabel.Location = New System.Drawing.Point(45, 442)
        Prezzo_al_KG_SansaLabel.Name = "Prezzo_al_KG_SansaLabel"
        Prezzo_al_KG_SansaLabel.Size = New System.Drawing.Size(153, 18)
        Prezzo_al_KG_SansaLabel.TabIndex = 83
        Prezzo_al_KG_SansaLabel.Text = "Prezzo sansa al Kg €:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(330, 442)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(86, 18)
        Label9.TabIndex = 87
        Label9.Text = "Sansa (Kg):"
        '
        'CodiceLabel
        '
        CodiceLabel.AutoSize = True
        CodiceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodiceLabel.Location = New System.Drawing.Point(179, 185)
        CodiceLabel.Name = "CodiceLabel"
        CodiceLabel.Size = New System.Drawing.Size(96, 18)
        CodiceLabel.TabIndex = 92
        CodiceLabel.Text = "Codice SIAN:"
        '
        'PECLabel
        '
        PECLabel.AutoSize = True
        PECLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PECLabel.Location = New System.Drawing.Point(481, 117)
        PECLabel.Name = "PECLabel"
        PECLabel.Size = New System.Drawing.Size(43, 18)
        PECLabel.TabIndex = 95
        PECLabel.Text = "PEC:"
        '
        'CodiceFattLabel
        '
        CodiceFattLabel.AutoSize = True
        CodiceFattLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodiceFattLabel.Location = New System.Drawing.Point(472, 185)
        CodiceFattLabel.Name = "CodiceFattLabel"
        CodiceFattLabel.Size = New System.Drawing.Size(149, 18)
        CodiceFattLabel.TabIndex = 96
        CodiceFattLabel.Text = "Codice Destinazione:"
        '
        'CognomeLabel
        '
        CognomeLabel.AutoSize = True
        CognomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CognomeLabel.Location = New System.Drawing.Point(9, 117)
        CognomeLabel.Name = "CognomeLabel"
        CognomeLabel.Size = New System.Drawing.Size(78, 18)
        CognomeLabel.TabIndex = 97
        CognomeLabel.Text = "Cognome:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(246, 117)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(53, 18)
        NomeLabel.TabIndex = 98
        NomeLabel.Text = "Nome:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 24)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Dettagli Molitura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 24)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Dettagli Cliente"
        '
        'TotaleTotTextBox
        '
        Me.TotaleTotTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotaleTotTextBox.Location = New System.Drawing.Point(771, 485)
        Me.TotaleTotTextBox.Name = "TotaleTotTextBox"
        Me.TotaleTotTextBox.Size = New System.Drawing.Size(73, 24)
        Me.TotaleTotTextBox.TabIndex = 42
        Me.TotaleTotTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotaleIvaTextBox
        '
        Me.TotaleIvaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotaleIvaTextBox.Location = New System.Drawing.Point(771, 404)
        Me.TotaleIvaTextBox.Name = "TotaleIvaTextBox"
        Me.TotaleIvaTextBox.Size = New System.Drawing.Size(73, 24)
        Me.TotaleIvaTextBox.TabIndex = 41
        Me.TotaleIvaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(619, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 18)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Totale Molitura Euro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(676, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Totale Euro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(676, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Totale Euro:"
        '
        'TotaleTextBox
        '
        Me.TotaleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotaleTextBox.Location = New System.Drawing.Point(771, 363)
        Me.TotaleTextBox.Name = "TotaleTextBox"
        Me.TotaleTextBox.Size = New System.Drawing.Size(73, 24)
        Me.TotaleTextBox.TabIndex = 37
        Me.TotaleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FattureDataSet
        '
        Me.FattureDataSet.DataSetName = "FattureDataSet"
        Me.FattureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FattureBindingSource
        '
        Me.FattureBindingSource.DataMember = "Fatture"
        Me.FattureBindingSource.DataSource = Me.FattureDataSet
        '
        'FattureTableAdapter
        '
        Me.FattureTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AcqueTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FattureTableAdapter = Me.FattureTableAdapter
        Me.TableAdapterManager.SansaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gestione_Frantoio.FattureDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FattureBindingNavigator
        '
        Me.FattureBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FattureBindingNavigator.AutoSize = False
        Me.FattureBindingNavigator.BindingSource = Me.FattureBindingSource
        Me.FattureBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FattureBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FattureBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.FattureBindingNavigatorSaveItem, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.ToolStripLabel1, Me.CercaClientiTextBox, Me.PulsanteCerca, Me.ToolStripSeparator2, Me.BindingNavigatorDeleteItem})
        Me.FattureBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FattureBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FattureBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FattureBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FattureBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FattureBindingNavigator.Name = "FattureBindingNavigator"
        Me.FattureBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FattureBindingNavigator.Size = New System.Drawing.Size(885, 40)
        Me.FattureBindingNavigator.TabIndex = 45
        Me.FattureBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(63, 37)
        Me.BindingNavigatorAddNewItem.Text = "Nuovo"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 37)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(66, 37)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMoveFirstItem.Text = "Primo"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMovePreviousItem.Text = "Precedente"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 40)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMoveNextItem.Text = "Successivo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMoveLastItem.Text = "Ultimo"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'FattureBindingNavigatorSaveItem
        '
        Me.FattureBindingNavigatorSaveItem.Image = CType(resources.GetObject("FattureBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FattureBindingNavigatorSaveItem.Name = "FattureBindingNavigatorSaveItem"
        Me.FattureBindingNavigatorSaveItem.Size = New System.Drawing.Size(54, 37)
        Me.FattureBindingNavigatorSaveItem.Text = "Salva"
        Me.FattureBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(152, 37)
        Me.ToolStripButton1.Text = "Carica su file per il SIAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Crea fattura elettronica"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 37)
        Me.ToolStripLabel1.Text = "Cliente:"
        '
        'CercaClientiTextBox
        '
        Me.CercaClientiTextBox.Name = "CercaClientiTextBox"
        Me.CercaClientiTextBox.Size = New System.Drawing.Size(100, 40)
        '
        'PulsanteCerca
        '
        Me.PulsanteCerca.Image = CType(resources.GetObject("PulsanteCerca.Image"), System.Drawing.Image)
        Me.PulsanteCerca.Name = "PulsanteCerca"
        Me.PulsanteCerca.Size = New System.Drawing.Size(57, 37)
        Me.PulsanteCerca.Text = "Cerca"
        Me.PulsanteCerca.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(363, 482)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(35, 24)
        Me.IdTextBox.TabIndex = 46
        '
        'Numero_OperazioneTextBox
        '
        Me.Numero_OperazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Numero Operazione", True))
        Me.Numero_OperazioneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero_OperazioneTextBox.Location = New System.Drawing.Point(274, 321)
        Me.Numero_OperazioneTextBox.Name = "Numero_OperazioneTextBox"
        Me.Numero_OperazioneTextBox.Size = New System.Drawing.Size(108, 24)
        Me.Numero_OperazioneTextBox.TabIndex = 48
        '
        'Numero_FatturaTextBox
        '
        Me.Numero_FatturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Numero Fattura", True))
        Me.Numero_FatturaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero_FatturaTextBox.Location = New System.Drawing.Point(198, 284)
        Me.Numero_FatturaTextBox.Name = "Numero_FatturaTextBox"
        Me.Numero_FatturaTextBox.Size = New System.Drawing.Size(108, 24)
        Me.Numero_FatturaTextBox.TabIndex = 52
        '
        'CUAA_ClienteTextBox
        '
        Me.CUAA_ClienteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CUAA_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "CUAA Cliente", True))
        Me.CUAA_ClienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUAA_ClienteTextBox.Location = New System.Drawing.Point(601, 81)
        Me.CUAA_ClienteTextBox.Name = "CUAA_ClienteTextBox"
        Me.CUAA_ClienteTextBox.Size = New System.Drawing.Size(216, 24)
        Me.CUAA_ClienteTextBox.TabIndex = 54
        '
        'Denominazione_ClienteTextBox
        '
        Me.Denominazione_ClienteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Denominazione_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Denominazione Cliente", True))
        Me.Denominazione_ClienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Denominazione_ClienteTextBox.Location = New System.Drawing.Point(131, 81)
        Me.Denominazione_ClienteTextBox.Name = "Denominazione_ClienteTextBox"
        Me.Denominazione_ClienteTextBox.Size = New System.Drawing.Size(261, 24)
        Me.Denominazione_ClienteTextBox.TabIndex = 56
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(530, 147)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(287, 24)
        Me.IndirizzoTextBox.TabIndex = 58
        '
        'CittàTextBox
        '
        Me.CittàTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CittàTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Città", True))
        Me.CittàTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CittàTextBox.Location = New System.Drawing.Point(76, 147)
        Me.CittàTextBox.Name = "CittàTextBox"
        Me.CittàTextBox.Size = New System.Drawing.Size(153, 24)
        Me.CittàTextBox.TabIndex = 60
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(309, 147)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(142, 24)
        Me.ProvinciaTextBox.TabIndex = 62
        '
        'CAPTextBox
        '
        Me.CAPTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CAPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "CAP", True))
        Me.CAPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAPTextBox.Location = New System.Drawing.Point(72, 182)
        Me.CAPTextBox.Name = "CAPTextBox"
        Me.CAPTextBox.Size = New System.Drawing.Size(101, 24)
        Me.CAPTextBox.TabIndex = 64
        '
        'Kg_di_oliveTextBox
        '
        Me.Kg_di_oliveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Kg di olive", True))
        Me.Kg_di_oliveTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kg_di_oliveTextBox.Location = New System.Drawing.Point(212, 369)
        Me.Kg_di_oliveTextBox.Name = "Kg_di_oliveTextBox"
        Me.Kg_di_oliveTextBox.Size = New System.Drawing.Size(94, 24)
        Me.Kg_di_oliveTextBox.TabIndex = 66
        '
        'Percentuale_MolituraTextBox
        '
        Me.Percentuale_MolituraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Percentuale Molitura", True))
        Me.Percentuale_MolituraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percentuale_MolituraTextBox.Location = New System.Drawing.Point(400, 369)
        Me.Percentuale_MolituraTextBox.Name = "Percentuale_MolituraTextBox"
        Me.Percentuale_MolituraTextBox.Size = New System.Drawing.Size(39, 24)
        Me.Percentuale_MolituraTextBox.TabIndex = 68
        '
        'Olio_SfusoTextBox
        '
        Me.Olio_SfusoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Olio Sfuso", True))
        Me.Olio_SfusoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Olio_SfusoTextBox.Location = New System.Drawing.Point(450, 404)
        Me.Olio_SfusoTextBox.Name = "Olio_SfusoTextBox"
        Me.Olio_SfusoTextBox.Size = New System.Drawing.Size(94, 24)
        Me.Olio_SfusoTextBox.TabIndex = 70
        '
        'Prezzo_al_KGTextBox
        '
        Me.Prezzo_al_KGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Prezzo al KG", True))
        Me.Prezzo_al_KGTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prezzo_al_KGTextBox.Location = New System.Drawing.Point(212, 404)
        Me.Prezzo_al_KGTextBox.Name = "Prezzo_al_KGTextBox"
        Me.Prezzo_al_KGTextBox.Size = New System.Drawing.Size(94, 24)
        Me.Prezzo_al_KGTextBox.TabIndex = 72
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Iva", True))
        Me.IvaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IvaTextBox.Location = New System.Drawing.Point(631, 404)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(39, 24)
        Me.IvaTextBox.TabIndex = 74
        '
        'Caricato_CheckBox
        '
        Me.Caricato_CheckBox.AutoCheck = False
        Me.Caricato_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Caricato_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FattureBindingSource, "Caricato?", True))
        Me.Caricato_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caricato_CheckBox.Location = New System.Drawing.Point(48, 486)
        Me.Caricato_CheckBox.Name = "Caricato_CheckBox"
        Me.Caricato_CheckBox.Size = New System.Drawing.Size(208, 24)
        Me.Caricato_CheckBox.TabIndex = 76
        Me.Caricato_CheckBox.Text = "Caricato su file per il SIAN?"
        Me.Caricato_CheckBox.UseVisualStyleBackColor = True
        '
        'Data_OperazioneTextBox
        '
        Me.Data_OperazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Data Operazione", True))
        Me.Data_OperazioneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_OperazioneTextBox.Location = New System.Drawing.Point(460, 284)
        Me.Data_OperazioneTextBox.Name = "Data_OperazioneTextBox"
        Me.Data_OperazioneTextBox.ReadOnly = True
        Me.Data_OperazioneTextBox.Size = New System.Drawing.Size(157, 24)
        Me.Data_OperazioneTextBox.TabIndex = 77
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(460, 258)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 78
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(666, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Inserisci data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 525)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 18)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Numero ultima fattura e numero ultima operazione giornaliera:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 525)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 18)
        Me.Label7.TabIndex = 81
        '
        'Iva_SansaTextBox
        '
        Me.Iva_SansaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Iva Sansa", True))
        Me.Iva_SansaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iva_SansaTextBox.Location = New System.Drawing.Point(587, 439)
        Me.Iva_SansaTextBox.Name = "Iva_SansaTextBox"
        Me.Iva_SansaTextBox.Size = New System.Drawing.Size(39, 24)
        Me.Iva_SansaTextBox.TabIndex = 83
        '
        'Prezzo_al_KG_SansaTextBox
        '
        Me.Prezzo_al_KG_SansaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Prezzo al KG Sansa", True))
        Me.Prezzo_al_KG_SansaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prezzo_al_KG_SansaTextBox.Location = New System.Drawing.Point(212, 439)
        Me.Prezzo_al_KG_SansaTextBox.Name = "Prezzo_al_KG_SansaTextBox"
        Me.Prezzo_al_KG_SansaTextBox.Size = New System.Drawing.Size(94, 24)
        Me.Prezzo_al_KG_SansaTextBox.TabIndex = 84
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(632, 442)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 18)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Totale sansa Euro:"
        '
        'TotaleSansaTextBox
        '
        Me.TotaleSansaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotaleSansaTextBox.Location = New System.Drawing.Point(771, 439)
        Me.TotaleSansaTextBox.Name = "TotaleSansaTextBox"
        Me.TotaleSansaTextBox.Size = New System.Drawing.Size(73, 24)
        Me.TotaleSansaTextBox.TabIndex = 86
        Me.TotaleSansaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KgSansaTextBox
        '
        Me.KgSansaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KgSansaTextBox.Location = New System.Drawing.Point(422, 439)
        Me.KgSansaTextBox.Name = "KgSansaTextBox"
        Me.KgSansaTextBox.Size = New System.Drawing.Size(63, 24)
        Me.KgSansaTextBox.TabIndex = 88
        '
        'TotSansaTextBox
        '
        Me.TotSansaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotSansaTextBox.Location = New System.Drawing.Point(156, 574)
        Me.TotSansaTextBox.Name = "TotSansaTextBox"
        Me.TotSansaTextBox.Size = New System.Drawing.Size(73, 24)
        Me.TotSansaTextBox.TabIndex = 89
        Me.TotSansaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotSansaTextBox.Visible = False
        '
        'TotIvaSansaTextBox
        '
        Me.TotIvaSansaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotIvaSansaTextBox.Location = New System.Drawing.Point(235, 574)
        Me.TotIvaSansaTextBox.Name = "TotIvaSansaTextBox"
        Me.TotIvaSansaTextBox.Size = New System.Drawing.Size(73, 24)
        Me.TotIvaSansaTextBox.TabIndex = 90
        Me.TotIvaSansaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotIvaSansaTextBox.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(331, 470)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(85, 40)
        Me.Panel1.TabIndex = 91
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(20, 524)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 23)
        Me.Button2.TabIndex = 92
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CodiceTextBox
        '
        Me.CodiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Codice", True))
        Me.CodiceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceTextBox.Location = New System.Drawing.Point(280, 182)
        Me.CodiceTextBox.Name = "CodiceTextBox"
        Me.CodiceTextBox.Size = New System.Drawing.Size(171, 24)
        Me.CodiceTextBox.TabIndex = 93
        '
        'FatturaElettronicaTextBox
        '
        Me.FatturaElettronicaTextBox.Location = New System.Drawing.Point(771, 303)
        Me.FatturaElettronicaTextBox.Multiline = True
        Me.FatturaElettronicaTextBox.Name = "FatturaElettronicaTextBox"
        Me.FatturaElettronicaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FatturaElettronicaTextBox.TabIndex = 94
        Me.FatturaElettronicaTextBox.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Pagamento)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(475, 560)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(369, 75)
        Me.GroupBox3.TabIndex = 95
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Modalità di pagamento"
        '
        'Pagamento
        '
        Me.Pagamento.FormattingEnabled = True
        Me.Pagamento.Items.AddRange(New Object() {"MP01 - contanti", "MP02 - assegno", "MP03 - assegno circolare", "MP04 - contanti presso Tesoreria", "MP05 - bonifico", "MP06 - vaglia cambiario", "MP07 - bollettino bancario", "MP08 - carta di pagamento", "MP09 - RID", "MP10 - RID utenze", "MP11 - RID veloce", "MP12 - RIBA", "MP13 - MAV", "MP14 - quietanza erario", "MP15 - giroconto su conti di contabilità speciale", "MP16 - domiciliazione bancaria", "MP17 - domiciliazione postale", "MP18 - bollettino di c/c postale", "MP19 - SEPA Direct Debit", "MP20 - SEPA Direct Debit CORE", "MP21 - SEPA Direct Debit B2B", "MP22 - Trattenuta su somme già riscosse"})
        Me.Pagamento.Location = New System.Drawing.Point(7, 32)
        Me.Pagamento.Name = "Pagamento"
        Me.Pagamento.Size = New System.Drawing.Size(356, 26)
        Me.Pagamento.TabIndex = 11
        Me.Pagamento.Text = "MP01 Contanti"
        '
        'PECTextBox
        '
        Me.PECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "PEC", True))
        Me.PECTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PECTextBox.Location = New System.Drawing.Point(530, 114)
        Me.PECTextBox.Name = "PECTextBox"
        Me.PECTextBox.Size = New System.Drawing.Size(311, 24)
        Me.PECTextBox.TabIndex = 96
        '
        'CodiceFattTextBox
        '
        Me.CodiceFattTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "CodiceFatt", True))
        Me.CodiceFattTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceFattTextBox.Location = New System.Drawing.Point(631, 182)
        Me.CodiceFattTextBox.Name = "CodiceFattTextBox"
        Me.CodiceFattTextBox.Size = New System.Drawing.Size(106, 24)
        Me.CodiceFattTextBox.TabIndex = 97
        '
        'CognomeTextBox
        '
        Me.CognomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Cognome", True))
        Me.CognomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CognomeTextBox.Location = New System.Drawing.Point(89, 114)
        Me.CognomeTextBox.Name = "CognomeTextBox"
        Me.CognomeTextBox.Size = New System.Drawing.Size(151, 24)
        Me.CognomeTextBox.TabIndex = 98
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FattureBindingSource, "Nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(305, 114)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(169, 24)
        Me.NomeTextBox.TabIndex = 99
        '
        'Fattura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(885, 663)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CognomeLabel)
        Me.Controls.Add(Me.CognomeTextBox)
        Me.Controls.Add(CodiceFattLabel)
        Me.Controls.Add(Me.CodiceFattTextBox)
        Me.Controls.Add(PECLabel)
        Me.Controls.Add(Me.PECTextBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.FatturaElettronicaTextBox)
        Me.Controls.Add(CodiceLabel)
        Me.Controls.Add(Me.CodiceTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TotIvaSansaTextBox)
        Me.Controls.Add(Me.TotSansaTextBox)
        Me.Controls.Add(Me.KgSansaTextBox)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.TotaleSansaTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Prezzo_al_KG_SansaLabel)
        Me.Controls.Add(Me.Prezzo_al_KG_SansaTextBox)
        Me.Controls.Add(Iva_SansaLabel)
        Me.Controls.Add(Me.Iva_SansaTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Data_OperazioneTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Numero_OperazioneLabel)
        Me.Controls.Add(Me.Numero_OperazioneTextBox)
        Me.Controls.Add(Data_OperazioneLabel)
        Me.Controls.Add(Numero_FatturaLabel)
        Me.Controls.Add(Me.Numero_FatturaTextBox)
        Me.Controls.Add(CUAA_ClienteLabel)
        Me.Controls.Add(Me.CUAA_ClienteTextBox)
        Me.Controls.Add(Denominazione_ClienteLabel)
        Me.Controls.Add(Me.Denominazione_ClienteTextBox)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(CittàLabel)
        Me.Controls.Add(Me.CittàTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(CAPLabel)
        Me.Controls.Add(Me.CAPTextBox)
        Me.Controls.Add(Kg_di_oliveLabel)
        Me.Controls.Add(Me.Kg_di_oliveTextBox)
        Me.Controls.Add(Percentuale_MolituraLabel)
        Me.Controls.Add(Me.Percentuale_MolituraTextBox)
        Me.Controls.Add(Olio_SfusoLabel)
        Me.Controls.Add(Me.Olio_SfusoTextBox)
        Me.Controls.Add(Prezzo_al_KGLabel)
        Me.Controls.Add(Me.Prezzo_al_KGTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(Me.Caricato_CheckBox)
        Me.Controls.Add(Me.FattureBindingNavigator)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TotaleTotTextBox)
        Me.Controls.Add(Me.TotaleIvaTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotaleTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fattura"
        Me.Text = "Fattura"
        CType(Me.FattureDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FattureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FattureBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FattureBindingNavigator.ResumeLayout(False)
        Me.FattureBindingNavigator.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotaleTotTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotaleIvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TotaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FattureDataSet As Gestione_Frantoio.FattureDataSet
    Friend WithEvents FattureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FattureTableAdapter As Gestione_Frantoio.FattureDataSetTableAdapters.FattureTableAdapter
    Friend WithEvents TableAdapterManager As Gestione_Frantoio.FattureDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FattureBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FattureBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Numero_OperazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Numero_FatturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUAA_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Denominazione_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CittàTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CAPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kg_di_oliveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Percentuale_MolituraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Olio_SfusoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Prezzo_al_KGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Caricato_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CercaClientiTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PulsanteCerca As System.Windows.Forms.ToolStripButton
    Friend WithEvents Data_OperazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Iva_SansaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Prezzo_al_KG_SansaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TotaleSansaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KgSansaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotSansaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotIvaSansaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CodiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatturaElettronicaTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Pagamento As ComboBox
    Friend WithEvents PECTextBox As TextBox
    Friend WithEvents CodiceFattTextBox As TextBox
    Friend WithEvents CognomeTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
End Class
