<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clienti
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CognomeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim ViaLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim CapLabel As System.Windows.Forms.Label
        Dim CittàLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim PartitaIvaLabel As System.Windows.Forms.Label
        Dim IstatProvinciaLabel As System.Windows.Forms.Label
        Dim IstatComuneLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim CodiceLabel As System.Windows.Forms.Label
        Dim CodiceFatturazioneLabel As System.Windows.Forms.Label
        Dim PECLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clienti))
        Me.ClientiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientiDataSet = New Gestione_Frantoio.ClientiDataSet()
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
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.CognomeTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ViaTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.CapTextBox = New System.Windows.Forms.TextBox()
        Me.PartitaIvaTextBox = New System.Windows.Forms.TextBox()
        Me.IstatProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.IstatComuneTextBox = New System.Windows.Forms.TextBox()
        Me.CaricatoCheckBox = New System.Windows.Forms.CheckBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.FillByCognomeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CognomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CognomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByCognomeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProvinciaComboBox = New System.Windows.Forms.ComboBox()
        Me.CittàComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CodiceTextBox = New System.Windows.Forms.TextBox()
        Me.PrivacyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CodiceFatturazioneTextBox = New System.Windows.Forms.TextBox()
        Me.PECTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientiTableAdapter = New Gestione_Frantoio.ClientiDataSetTableAdapters.ClientiTableAdapter()
        Me.TableAdapterManager = New Gestione_Frantoio.ClientiDataSetTableAdapters.TableAdapterManager()
        CognomeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        ViaLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        CapLabel = New System.Windows.Forms.Label()
        CittàLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        PartitaIvaLabel = New System.Windows.Forms.Label()
        IstatProvinciaLabel = New System.Windows.Forms.Label()
        IstatComuneLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        CodiceLabel = New System.Windows.Forms.Label()
        CodiceFatturazioneLabel = New System.Windows.Forms.Label()
        PECLabel = New System.Windows.Forms.Label()
        CType(Me.ClientiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientiBindingNavigator.SuspendLayout()
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByCognomeToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CognomeLabel
        '
        CognomeLabel.AutoSize = True
        CognomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CognomeLabel.Location = New System.Drawing.Point(34, 83)
        CognomeLabel.Name = "CognomeLabel"
        CognomeLabel.Size = New System.Drawing.Size(78, 18)
        CognomeLabel.TabIndex = 1
        CognomeLabel.Text = "Cognome:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(278, 83)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(53, 18)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'ViaLabel
        '
        ViaLabel.AutoSize = True
        ViaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ViaLabel.Location = New System.Drawing.Point(34, 123)
        ViaLabel.Name = "ViaLabel"
        ViaLabel.Size = New System.Drawing.Size(67, 18)
        ViaLabel.TabIndex = 5
        ViaLabel.Text = "Indirizzo:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroLabel.Location = New System.Drawing.Point(353, 123)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(66, 18)
        NumeroLabel.TabIndex = 7
        NumeroLabel.Text = "Numero:"
        '
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CapLabel.Location = New System.Drawing.Point(504, 123)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(54, 18)
        CapLabel.TabIndex = 9
        CapLabel.Text = "C.A.P.:"
        '
        'CittàLabel
        '
        CittàLabel.AutoSize = True
        CittàLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CittàLabel.Location = New System.Drawing.Point(305, 164)
        CittàLabel.Name = "CittàLabel"
        CittàLabel.Size = New System.Drawing.Size(42, 18)
        CittàLabel.TabIndex = 11
        CittàLabel.Text = "Città:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProvinciaLabel.Location = New System.Drawing.Point(34, 164)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(73, 18)
        ProvinciaLabel.TabIndex = 13
        ProvinciaLabel.Text = "Provincia:"
        '
        'PartitaIvaLabel
        '
        PartitaIvaLabel.AutoSize = True
        PartitaIvaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PartitaIvaLabel.Location = New System.Drawing.Point(34, 213)
        PartitaIvaLabel.Name = "PartitaIvaLabel"
        PartitaIvaLabel.Size = New System.Drawing.Size(116, 18)
        PartitaIvaLabel.TabIndex = 15
        PartitaIvaLabel.Text = "Partita Iva / C.F.:"
        '
        'IstatProvinciaLabel
        '
        IstatProvinciaLabel.AutoSize = True
        IstatProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IstatProvinciaLabel.Location = New System.Drawing.Point(34, 258)
        IstatProvinciaLabel.Name = "IstatProvinciaLabel"
        IstatProvinciaLabel.Size = New System.Drawing.Size(104, 18)
        IstatProvinciaLabel.TabIndex = 17
        IstatProvinciaLabel.Text = "Istat Provincia:"
        '
        'IstatComuneLabel
        '
        IstatComuneLabel.AutoSize = True
        IstatComuneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IstatComuneLabel.Location = New System.Drawing.Point(231, 258)
        IstatComuneLabel.Name = "IstatComuneLabel"
        IstatComuneLabel.Size = New System.Drawing.Size(100, 18)
        IstatComuneLabel.TabIndex = 19
        IstatComuneLabel.Text = "Istat Comune:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(475, 392)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 23
        IdLabel.Text = "id:"
        IdLabel.Visible = False
        '
        'CodiceLabel
        '
        CodiceLabel.AutoSize = True
        CodiceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodiceLabel.Location = New System.Drawing.Point(492, 217)
        CodiceLabel.Name = "CodiceLabel"
        CodiceLabel.Size = New System.Drawing.Size(59, 18)
        CodiceLabel.TabIndex = 32
        CodiceLabel.Text = "Codice:"
        '
        'CodiceFatturazioneLabel
        '
        CodiceFatturazioneLabel.AutoSize = True
        CodiceFatturazioneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodiceFatturazioneLabel.Location = New System.Drawing.Point(18, 22)
        CodiceFatturazioneLabel.Name = "CodiceFatturazioneLabel"
        CodiceFatturazioneLabel.Size = New System.Drawing.Size(145, 18)
        CodiceFatturazioneLabel.TabIndex = 35
        CodiceFatturazioneLabel.Text = "Codice Fatturazione:"
        '
        'PECLabel
        '
        PECLabel.AutoSize = True
        PECLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PECLabel.Location = New System.Drawing.Point(18, 65)
        PECLabel.Name = "PECLabel"
        PECLabel.Size = New System.Drawing.Size(43, 18)
        PECLabel.TabIndex = 36
        PECLabel.Text = "PEC:"
        '
        'ClientiBindingNavigator
        '
        Me.ClientiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientiBindingNavigator.AutoSize = False
        Me.ClientiBindingNavigator.BindingSource = Me.ClientiBindingSource
        Me.ClientiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.ClientiBindingNavigatorSaveItem, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.ToolStripButton2})
        Me.ClientiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientiBindingNavigator.Name = "ClientiBindingNavigator"
        Me.ClientiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientiBindingNavigator.Size = New System.Drawing.Size(683, 40)
        Me.ClientiBindingNavigator.TabIndex = 0
        Me.ClientiBindingNavigator.Text = "BindingNavigator1"
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
        'ClientiBindingSource
        '
        Me.ClientiBindingSource.DataMember = "Clienti"
        Me.ClientiBindingSource.DataSource = Me.ClientiDataSet
        '
        'ClientiDataSet
        '
        Me.ClientiDataSet.DataSetName = "ClientiDataSet"
        Me.ClientiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(72, 37)
        Me.BindingNavigatorDeleteItem.Text = "Cancella"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'ClientiBindingNavigatorSaveItem
        '
        Me.ClientiBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientiBindingNavigatorSaveItem.Name = "ClientiBindingNavigatorSaveItem"
        Me.ClientiBindingNavigatorSaveItem.Size = New System.Drawing.Size(54, 37)
        Me.ClientiBindingNavigatorSaveItem.Text = "Salva"
        Me.ClientiBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 37)
        Me.ToolStripButton1.Text = "Inserisci"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(152, 37)
        Me.ToolStripButton2.Text = "Carica su file per il SIAN"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'CognomeTextBox
        '
        Me.CognomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CognomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "Cognome", True))
        Me.CognomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CognomeTextBox.Location = New System.Drawing.Point(118, 80)
        Me.CognomeTextBox.Name = "CognomeTextBox"
        Me.CognomeTextBox.Size = New System.Drawing.Size(154, 24)
        Me.CognomeTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "Nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(346, 80)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(145, 24)
        Me.NomeTextBox.TabIndex = 4
        '
        'ViaTextBox
        '
        Me.ViaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ViaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "Via", True))
        Me.ViaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViaTextBox.Location = New System.Drawing.Point(112, 120)
        Me.ViaTextBox.Name = "ViaTextBox"
        Me.ViaTextBox.Size = New System.Drawing.Size(235, 24)
        Me.ViaTextBox.TabIndex = 6
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "Numero", True))
        Me.NumeroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroTextBox.Location = New System.Drawing.Point(429, 120)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(71, 24)
        Me.NumeroTextBox.TabIndex = 8
        '
        'CapTextBox
        '
        Me.CapTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "Cap", True))
        Me.CapTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapTextBox.Location = New System.Drawing.Point(564, 120)
        Me.CapTextBox.Name = "CapTextBox"
        Me.CapTextBox.Size = New System.Drawing.Size(93, 24)
        Me.CapTextBox.TabIndex = 10
        '
        'PartitaIvaTextBox
        '
        Me.PartitaIvaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PartitaIvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "PartitaIva", True))
        Me.PartitaIvaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartitaIvaTextBox.Location = New System.Drawing.Point(156, 210)
        Me.PartitaIvaTextBox.Name = "PartitaIvaTextBox"
        Me.PartitaIvaTextBox.Size = New System.Drawing.Size(235, 24)
        Me.PartitaIvaTextBox.TabIndex = 16
        '
        'IstatProvinciaTextBox
        '
        Me.IstatProvinciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IstatProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "IstatProvincia", True))
        Me.IstatProvinciaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IstatProvinciaTextBox.Location = New System.Drawing.Point(144, 255)
        Me.IstatProvinciaTextBox.Name = "IstatProvinciaTextBox"
        Me.IstatProvinciaTextBox.Size = New System.Drawing.Size(67, 24)
        Me.IstatProvinciaTextBox.TabIndex = 20
        '
        'IstatComuneTextBox
        '
        Me.IstatComuneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IstatComuneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "IstatComune", True))
        Me.IstatComuneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IstatComuneTextBox.Location = New System.Drawing.Point(337, 255)
        Me.IstatComuneTextBox.Name = "IstatComuneTextBox"
        Me.IstatComuneTextBox.Size = New System.Drawing.Size(67, 24)
        Me.IstatComuneTextBox.TabIndex = 18
        '
        'CaricatoCheckBox
        '
        Me.CaricatoCheckBox.AutoCheck = False
        Me.CaricatoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CaricatoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClientiBindingSource, "Caricato", True))
        Me.CaricatoCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaricatoCheckBox.Location = New System.Drawing.Point(429, 256)
        Me.CaricatoCheckBox.Name = "CaricatoCheckBox"
        Me.CaricatoCheckBox.Size = New System.Drawing.Size(216, 24)
        Me.CaricatoCheckBox.TabIndex = 22
        Me.CaricatoCheckBox.Text = "Caricato su file per il SIAN?"
        Me.CaricatoCheckBox.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(499, 389)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 24
        '
        'FillByCognomeToolStrip
        '
        Me.FillByCognomeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CognomeToolStripLabel, Me.CognomeToolStripTextBox, Me.FillByCognomeToolStripButton})
        Me.FillByCognomeToolStrip.Location = New System.Drawing.Point(0, 40)
        Me.FillByCognomeToolStrip.Name = "FillByCognomeToolStrip"
        Me.FillByCognomeToolStrip.Size = New System.Drawing.Size(683, 25)
        Me.FillByCognomeToolStrip.TabIndex = 25
        Me.FillByCognomeToolStrip.Text = "FillByCognomeToolStrip"
        '
        'CognomeToolStripLabel
        '
        Me.CognomeToolStripLabel.Name = "CognomeToolStripLabel"
        Me.CognomeToolStripLabel.Size = New System.Drawing.Size(63, 22)
        Me.CognomeToolStripLabel.Text = "Cognome:"
        '
        'CognomeToolStripTextBox
        '
        Me.CognomeToolStripTextBox.Name = "CognomeToolStripTextBox"
        Me.CognomeToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByCognomeToolStripButton
        '
        Me.FillByCognomeToolStripButton.Image = CType(resources.GetObject("FillByCognomeToolStripButton.Image"), System.Drawing.Image)
        Me.FillByCognomeToolStripButton.Name = "FillByCognomeToolStripButton"
        Me.FillByCognomeToolStripButton.Size = New System.Drawing.Size(57, 22)
        Me.FillByCognomeToolStripButton.Text = "Cerca"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(411, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Controlla"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProvinciaComboBox
        '
        Me.ProvinciaComboBox.AutoCompleteCustomSource.AddRange(New String() {"Agrigento", "Alessandria", "Ancona", "Aosta", "Arezzo", "Ascoli Piceno", "Asti", "Avellino", "Bari", "Barletta-Andria-Trani", "Belluno", "Benevento", "Bergamo", "Biella", "Bologna", "Bolzano", "Brescia", "Brindisi", "Cagliari", "Caltanissetta", "Campobasso", "Carbonia-Iglesias", "Caserta", "Catania", "Catanzaro", "Chieti", "Como", "Cosenza", "Cremona", "Crotone", "Cuneo", "Enna", "Fermo", "Ferrara", "Firenze", "Foggia", "Forlì", "Frosinone", "Genova", "Gorizia", "Grosseto", "Imperia", "Isernia", "La Spezia", "Lanusei-Tortolì", "L'Aquila", "Latina", "Lecce", "Lecco", "Livorno", "Lodi", "Lucca", "Macerata", "Mantova", "Massa", "Matera", "Messina", "Milano", "Modena", "Monza", "Napoli", "Novara", "Nuoro", "Olbia-Tempio", "Oristano", "Padova", "Palermo", "Parma", "Pavia", "Perugia", "Pesaro", "Pescara", "Piacenza", "Pisa", "Pistoia", "Pordenone", "Potenza", "Prato", "Ragusa", "Ravenna", "Reggio di Calabria", "Reggio nell'Emilia", "Rieti", "Rimini", "Roma", "Rovigo", "Salerno", "Sanluri-Villacidro", "Sassari", "Savona", "Siena", "Siracusa", "Sondrio", "Taranto", "Teramo", "Terni", "Torino", "Trapani", "Trento", "Treviso", "Trieste", "Udine", "Varese", "Venezia", "Verbania", "Vercelli", "Verona", "Vibo Valentia", "Vicenza", "Viterbo"})
        Me.ProvinciaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ProvinciaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ProvinciaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "Provincia", True))
        Me.ProvinciaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinciaComboBox.FormattingEnabled = True
        Me.ProvinciaComboBox.Items.AddRange(New Object() {"Agrigento-AG", "Alessandria-AL", "Ancona-AN", "Arezzo-AR", "Ascoli Piceno-AP", "Asti-AT", "Avellino-AV", "Bari-BA", "Barletta Andria Trani-BT", "Belluno-BL", "Benevento-BN", "Bergamo-BG", "Biella-BI", "Bologna-BO", "Bolzano-BZ", "Brescia-BS", "Brindisi-BR", "Cagliari-CA", "Caltanissetta-CL", "Campobasso-CB", "Caserta-CE", "Catania-CT", "Catanzaro-CZ", "Chieti-CH", "Como-CO", "Cosenza-CS", "Cremona-CR", "Crotone-KR", "Cuneo-CN", "Enna-EN", "Fermo-FM", "Ferrara-FE", "Firenze-FI", "Foggia-FG", "Forli Cesena-FC", "Frosinone-FR", "Genova-GE", "Gorizia-GO", "Grosseto-GR", "Imperia-IM", "Isernia-IS", "La Spezia-SP", "L'Aquila-AQ", "Latina-LT", "Lecce-LE", "Lecco-LC", "Livorno-LI", "Lodi-LO", "Lucca-LU", "Macerata-MC", "Mantova-MN", "Massa-Carrara-MS", "Matera-MT", "Messina-ME", "Milano-MI", "Modena-MO", "Monza-Brianza-MB", "Napoli-NA", "Novara-NO", "Nuoro-NU", "Oristano-OR", "Padova-PD", "Palermo-PA", "Parma-PR", "Pavia-PV", "Perugia-PG", "Pesaro-Urbino-PU", "Pescara-PE", "Piacenza-PC", "Pisa-PI", "Pistoia-PT", "Pordenone-PN", "Potenza-PZ", "Prato-PO", "Ragusa-RG", "Ravenna-RA", "Reggio-Calabria-RC", "Reggio-Emilia-RE", "Rieti-RI", "Rimini-RN", "Roma-Roma", "Rovigo-RO", "Salerno-SA", "Sassari-SS", "Savona-SV", "Siena-SI", "Siracusa-SR", "Sondrio-SO", "Taranto-TA", "Teramo-TE", "Terni-TR", "Torino-TO", "Trapani-TP", "Trento-TN", "Treviso-TV", "Trieste-TS", "Udine-UD", "Varese-VA", "Venezia-VE", "Verbania-VB", "Vercelli-VC", "Verona-VR", "Vibo-Valentia-VV", "Vicenza-VI", "Viterbo-VT"})
        Me.ProvinciaComboBox.Location = New System.Drawing.Point(112, 161)
        Me.ProvinciaComboBox.Name = "ProvinciaComboBox"
        Me.ProvinciaComboBox.Size = New System.Drawing.Size(177, 26)
        Me.ProvinciaComboBox.TabIndex = 29
        '
        'CittàComboBox
        '
        Me.CittàComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "Città", True))
        Me.CittàComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CittàComboBox.FormattingEnabled = True
        Me.CittàComboBox.Location = New System.Drawing.Point(354, 161)
        Me.CittàComboBox.Name = "CittàComboBox"
        Me.CittàComboBox.Size = New System.Drawing.Size(189, 26)
        Me.CittàComboBox.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(429, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 31
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(549, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Comune"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CodiceTextBox
        '
        Me.CodiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "Codice", True))
        Me.CodiceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceTextBox.Location = New System.Drawing.Point(557, 214)
        Me.CodiceTextBox.Name = "CodiceTextBox"
        Me.CodiceTextBox.Size = New System.Drawing.Size(100, 24)
        Me.CodiceTextBox.TabIndex = 33
        '
        'PrivacyCheckBox
        '
        Me.PrivacyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrivacyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClientiBindingSource, "Privacy", True))
        Me.PrivacyCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrivacyCheckBox.Location = New System.Drawing.Point(557, 277)
        Me.PrivacyCheckBox.Name = "PrivacyCheckBox"
        Me.PrivacyCheckBox.Size = New System.Drawing.Size(88, 24)
        Me.PrivacyCheckBox.TabIndex = 34
        Me.PrivacyCheckBox.Text = "Privacy:"
        Me.PrivacyCheckBox.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(429, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Stampa Modulo Privacy"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CodiceFatturazioneTextBox
        '
        Me.CodiceFatturazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "CodiceFatturazione", True))
        Me.CodiceFatturazioneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceFatturazioneTextBox.Location = New System.Drawing.Point(169, 19)
        Me.CodiceFatturazioneTextBox.Name = "CodiceFatturazioneTextBox"
        Me.CodiceFatturazioneTextBox.Size = New System.Drawing.Size(124, 24)
        Me.CodiceFatturazioneTextBox.TabIndex = 36
        '
        'PECTextBox
        '
        Me.PECTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientiBindingSource, "PEC", True))
        Me.PECTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PECTextBox.Location = New System.Drawing.Point(67, 62)
        Me.PECTextBox.Name = "PECTextBox"
        Me.PECTextBox.Size = New System.Drawing.Size(312, 24)
        Me.PECTextBox.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CodiceFatturazioneTextBox)
        Me.GroupBox1.Controls.Add(CodiceFatturazioneLabel)
        Me.GroupBox1.Controls.Add(PECLabel)
        Me.GroupBox1.Controls.Add(Me.PECTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 323)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 100)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solo per aziende"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 40
        '
        'ClientiTableAdapter
        '
        Me.ClientiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientiTableAdapter = Me.ClientiTableAdapter
        Me.TableAdapterManager.UpdateOrder = Gestione_Frantoio.ClientiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Clienti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(683, 435)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PrivacyCheckBox)
        Me.Controls.Add(CodiceLabel)
        Me.Controls.Add(Me.CodiceTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CittàComboBox)
        Me.Controls.Add(Me.ProvinciaComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FillByCognomeToolStrip)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(CognomeLabel)
        Me.Controls.Add(Me.CognomeTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(ViaLabel)
        Me.Controls.Add(Me.ViaTextBox)
        Me.Controls.Add(NumeroLabel)
        Me.Controls.Add(Me.NumeroTextBox)
        Me.Controls.Add(CapLabel)
        Me.Controls.Add(Me.CapTextBox)
        Me.Controls.Add(CittàLabel)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(PartitaIvaLabel)
        Me.Controls.Add(Me.PartitaIvaTextBox)
        Me.Controls.Add(IstatProvinciaLabel)
        Me.Controls.Add(Me.IstatProvinciaTextBox)
        Me.Controls.Add(IstatComuneLabel)
        Me.Controls.Add(Me.IstatComuneTextBox)
        Me.Controls.Add(Me.CaricatoCheckBox)
        Me.Controls.Add(Me.ClientiBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Clienti"
        Me.Text = "Clienti"
        Me.TopMost = True
        CType(Me.ClientiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientiBindingNavigator.ResumeLayout(False)
        Me.ClientiBindingNavigator.PerformLayout()
        CType(Me.ClientiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByCognomeToolStrip.ResumeLayout(False)
        Me.FillByCognomeToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientiDataSet As Gestione_Frantoio.ClientiDataSet
    Friend WithEvents ClientiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientiTableAdapter As Gestione_Frantoio.ClientiDataSetTableAdapters.ClientiTableAdapter
    Friend WithEvents TableAdapterManager As Gestione_Frantoio.ClientiDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClientiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CognomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartitaIvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IstatProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IstatComuneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaricatoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByCognomeToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CognomeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CognomeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByCognomeToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProvinciaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CittàComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CodiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrivacyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CodiceFatturazioneTextBox As TextBox
    Friend WithEvents PECTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
