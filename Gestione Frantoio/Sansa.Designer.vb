<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sansa
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim Riferimento_DocumentoLabel As System.Windows.Forms.Label
        Dim DenominazioneLabel As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim ComuneLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim CF_o_PivaLabel As System.Windows.Forms.Label
        Dim KgLabel As System.Windows.Forms.Label
        Dim Numero_OperazioneLabel As System.Windows.Forms.Label
        Dim CausaleLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sansa))
        Me.FattureDataSet = New Gestione_Frantoio.FattureDataSet()
        Me.SansaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SansaTableAdapter = New Gestione_Frantoio.FattureDataSetTableAdapters.SansaTableAdapter()
        Me.TableAdapterManager = New Gestione_Frantoio.FattureDataSetTableAdapters.TableAdapterManager()
        Me.SansaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SansaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Riferimento_DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.DenominazioneTextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.ComuneTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.CF_o_PivaTextBox = New System.Windows.Forms.TextBox()
        Me.KgTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StampaBolla = New System.Drawing.Printing.PrintDocument()
        Me.Numero_OperazioneTextBox = New System.Windows.Forms.TextBox()
        Me.CaricatoCheckBox = New System.Windows.Forms.CheckBox()
        Me.CausaleComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        Riferimento_DocumentoLabel = New System.Windows.Forms.Label()
        DenominazioneLabel = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        ComuneLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        CF_o_PivaLabel = New System.Windows.Forms.Label()
        KgLabel = New System.Windows.Forms.Label()
        Numero_OperazioneLabel = New System.Windows.Forms.Label()
        CausaleLabel1 = New System.Windows.Forms.Label()
        CType(Me.FattureDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SansaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SansaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SansaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(767, 458)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 18)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        IdLabel.Visible = False
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(11, 225)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(43, 18)
        DataLabel.TabIndex = 3
        DataLabel.Text = "Data:"
        '
        'Riferimento_DocumentoLabel
        '
        Riferimento_DocumentoLabel.AutoSize = True
        Riferimento_DocumentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Riferimento_DocumentoLabel.Location = New System.Drawing.Point(11, 256)
        Riferimento_DocumentoLabel.Name = "Riferimento_DocumentoLabel"
        Riferimento_DocumentoLabel.Size = New System.Drawing.Size(170, 18)
        Riferimento_DocumentoLabel.TabIndex = 5
        Riferimento_DocumentoLabel.Text = "Riferimento Documento:"
        '
        'DenominazioneLabel
        '
        DenominazioneLabel.AutoSize = True
        DenominazioneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DenominazioneLabel.Location = New System.Drawing.Point(11, 323)
        DenominazioneLabel.Name = "DenominazioneLabel"
        DenominazioneLabel.Size = New System.Drawing.Size(116, 18)
        DenominazioneLabel.TabIndex = 9
        DenominazioneLabel.Text = "Denominazione:"
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndirizzoLabel.Location = New System.Drawing.Point(11, 353)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(67, 18)
        IndirizzoLabel.TabIndex = 11
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'ComuneLabel
        '
        ComuneLabel.AutoSize = True
        ComuneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComuneLabel.Location = New System.Drawing.Point(385, 323)
        ComuneLabel.Name = "ComuneLabel"
        ComuneLabel.Size = New System.Drawing.Size(69, 18)
        ComuneLabel.TabIndex = 13
        ComuneLabel.Text = "Comune:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProvinciaLabel.Location = New System.Drawing.Point(642, 323)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(47, 18)
        ProvinciaLabel.TabIndex = 15
        ProvinciaLabel.Text = "Prov.:"
        '
        'CF_o_PivaLabel
        '
        CF_o_PivaLabel.AutoSize = True
        CF_o_PivaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CF_o_PivaLabel.Location = New System.Drawing.Point(340, 353)
        CF_o_PivaLabel.Name = "CF_o_PivaLabel"
        CF_o_PivaLabel.Size = New System.Drawing.Size(89, 18)
        CF_o_PivaLabel.TabIndex = 17
        CF_o_PivaLabel.Text = "C.F. o P.Iva:"
        '
        'KgLabel
        '
        KgLabel.AutoSize = True
        KgLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        KgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KgLabel.Location = New System.Drawing.Point(12, 293)
        KgLabel.Name = "KgLabel"
        KgLabel.Size = New System.Drawing.Size(89, 18)
        KgLabel.TabIndex = 19
        KgLabel.Text = "Kg di sansa:"
        '
        'Numero_OperazioneLabel
        '
        Numero_OperazioneLabel.AutoSize = True
        Numero_OperazioneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Numero_OperazioneLabel.Location = New System.Drawing.Point(476, 256)
        Numero_OperazioneLabel.Name = "Numero_OperazioneLabel"
        Numero_OperazioneLabel.Size = New System.Drawing.Size(147, 18)
        Numero_OperazioneLabel.TabIndex = 44
        Numero_OperazioneLabel.Text = "Numero Operazione:"
        '
        'CausaleLabel1
        '
        CausaleLabel1.AutoSize = True
        CausaleLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        CausaleLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CausaleLabel1.Location = New System.Drawing.Point(304, 256)
        CausaleLabel1.Name = "CausaleLabel1"
        CausaleLabel1.Size = New System.Drawing.Size(87, 18)
        CausaleLabel1.TabIndex = 46
        CausaleLabel1.Text = "Codice Op.:"
        '
        'FattureDataSet
        '
        Me.FattureDataSet.DataSetName = "FattureDataSet"
        Me.FattureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SansaBindingSource
        '
        Me.SansaBindingSource.DataMember = "Sansa"
        Me.SansaBindingSource.DataSource = Me.FattureDataSet
        '
        'SansaTableAdapter
        '
        Me.SansaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AcqueTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FattureTableAdapter = Nothing
        Me.TableAdapterManager.SansaTableAdapter = Me.SansaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Gestione_Frantoio.FattureDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SansaBindingNavigator
        '
        Me.SansaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SansaBindingNavigator.AutoSize = False
        Me.SansaBindingNavigator.BindingSource = Me.SansaBindingSource
        Me.SansaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SansaBindingNavigator.CountItemFormat = "di {0}"
        Me.SansaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SansaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.SansaBindingNavigatorSaveItem, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.ToolStripButton2})
        Me.SansaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SansaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SansaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SansaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SansaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SansaBindingNavigator.Name = "SansaBindingNavigator"
        Me.SansaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SansaBindingNavigator.Size = New System.Drawing.Size(963, 40)
        Me.SansaBindingNavigator.TabIndex = 0
        Me.SansaBindingNavigator.Text = "BindingNavigator1"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'SansaBindingNavigatorSaveItem
        '
        Me.SansaBindingNavigatorSaveItem.Image = CType(resources.GetObject("SansaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SansaBindingNavigatorSaveItem.Name = "SansaBindingNavigatorSaveItem"
        Me.SansaBindingNavigatorSaveItem.Size = New System.Drawing.Size(54, 37)
        Me.SansaBindingNavigatorSaveItem.Text = "Salva"
        Me.SansaBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.ToolStripButton1.Size = New System.Drawing.Size(67, 37)
        Me.ToolStripButton1.Text = "Stampa"
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
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(796, 455)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(75, 24)
        Me.IdTextBox.TabIndex = 2
        Me.IdTextBox.Visible = False
        '
        'Riferimento_DocumentoTextBox
        '
        Me.Riferimento_DocumentoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Riferimento_DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "Riferimento Documento", True))
        Me.Riferimento_DocumentoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Riferimento_DocumentoTextBox.Location = New System.Drawing.Point(187, 253)
        Me.Riferimento_DocumentoTextBox.Name = "Riferimento_DocumentoTextBox"
        Me.Riferimento_DocumentoTextBox.Size = New System.Drawing.Size(106, 24)
        Me.Riferimento_DocumentoTextBox.TabIndex = 6
        '
        'DenominazioneTextBox
        '
        Me.DenominazioneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DenominazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "Denominazione", True))
        Me.DenominazioneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DenominazioneTextBox.Location = New System.Drawing.Point(133, 320)
        Me.DenominazioneTextBox.Name = "DenominazioneTextBox"
        Me.DenominazioneTextBox.Size = New System.Drawing.Size(246, 24)
        Me.DenominazioneTextBox.TabIndex = 10
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(84, 350)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(250, 24)
        Me.IndirizzoTextBox.TabIndex = 12
        '
        'ComuneTextBox
        '
        Me.ComuneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ComuneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "Comune", True))
        Me.ComuneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComuneTextBox.Location = New System.Drawing.Point(460, 320)
        Me.ComuneTextBox.Name = "ComuneTextBox"
        Me.ComuneTextBox.Size = New System.Drawing.Size(176, 24)
        Me.ComuneTextBox.TabIndex = 14
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(695, 320)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(78, 24)
        Me.ProvinciaTextBox.TabIndex = 16
        '
        'CF_o_PivaTextBox
        '
        Me.CF_o_PivaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CF_o_PivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "CF o Piva", True))
        Me.CF_o_PivaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CF_o_PivaTextBox.Location = New System.Drawing.Point(435, 350)
        Me.CF_o_PivaTextBox.Name = "CF_o_PivaTextBox"
        Me.CF_o_PivaTextBox.Size = New System.Drawing.Size(200, 24)
        Me.CF_o_PivaTextBox.TabIndex = 18
        '
        'KgTextBox
        '
        Me.KgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "Kg", True))
        Me.KgTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KgTextBox.Location = New System.Drawing.Point(107, 290)
        Me.KgTextBox.Name = "KgTextBox"
        Me.KgTextBox.Size = New System.Drawing.Size(85, 24)
        Me.KgTextBox.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Sansa in magazzino Totale Kg."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Sansa inviata al sansificio Totale Kg."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 18)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Sansa prodotta Totale Kg."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(371, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 32)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Calcola"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(265, 128)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 24)
        Me.TextBox3.TabIndex = 34
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(265, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 24)
        Me.TextBox2.TabIndex = 33
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(265, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 32
        '
        'DataTextBox
        '
        Me.DataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "Data", True))
        Me.DataTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataTextBox.Location = New System.Drawing.Point(60, 222)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.ReadOnly = True
        Me.DataTextBox.Size = New System.Drawing.Size(132, 24)
        Me.DataTextBox.TabIndex = 39
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(203, 220)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(226, 24)
        Me.DateTimePicker1.TabIndex = 40
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(435, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Inserisci data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(339, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 24)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Registro Scarico Sansa"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(836, 10)
        Me.Panel2.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(557, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Codice Operazione: G3 Scarico/vendita di sansa a ditta italiana, G7 Superi di san" & _
    "sa."
        '
        'StampaBolla
        '
        '
        'Numero_OperazioneTextBox
        '
        Me.Numero_OperazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "Numero Operazione", True))
        Me.Numero_OperazioneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero_OperazioneTextBox.Location = New System.Drawing.Point(629, 253)
        Me.Numero_OperazioneTextBox.Name = "Numero_OperazioneTextBox"
        Me.Numero_OperazioneTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Numero_OperazioneTextBox.TabIndex = 45
        '
        'CaricatoCheckBox
        '
        Me.CaricatoCheckBox.AutoCheck = False
        Me.CaricatoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CaricatoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SansaBindingSource, "Caricato", True))
        Me.CaricatoCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaricatoCheckBox.Location = New System.Drawing.Point(435, 291)
        Me.CaricatoCheckBox.Name = "CaricatoCheckBox"
        Me.CaricatoCheckBox.Size = New System.Drawing.Size(203, 24)
        Me.CaricatoCheckBox.TabIndex = 46
        Me.CaricatoCheckBox.Text = "Caricato su file per il SIAN:"
        Me.CaricatoCheckBox.UseVisualStyleBackColor = True
        '
        'CausaleComboBox
        '
        Me.CausaleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SansaBindingSource, "Causale", True))
        Me.CausaleComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CausaleComboBox.FormattingEnabled = True
        Me.CausaleComboBox.Items.AddRange(New Object() {"G3", "G7"})
        Me.CausaleComboBox.Location = New System.Drawing.Point(394, 253)
        Me.CausaleComboBox.Name = "CausaleComboBox"
        Me.CausaleComboBox.Size = New System.Drawing.Size(69, 26)
        Me.CausaleComboBox.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 18)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Giacenza Iniziale Kg."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 18)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Superi di sansa Kg."
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(518, 99)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 24)
        Me.TextBox4.TabIndex = 49
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(518, 128)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 24)
        Me.TextBox5.TabIndex = 48
        '
        'Sansa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(963, 499)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(CausaleLabel1)
        Me.Controls.Add(Me.CausaleComboBox)
        Me.Controls.Add(Me.CaricatoCheckBox)
        Me.Controls.Add(Numero_OperazioneLabel)
        Me.Controls.Add(Me.Numero_OperazioneTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Riferimento_DocumentoLabel)
        Me.Controls.Add(Me.Riferimento_DocumentoTextBox)
        Me.Controls.Add(DenominazioneLabel)
        Me.Controls.Add(Me.DenominazioneTextBox)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(ComuneLabel)
        Me.Controls.Add(Me.ComuneTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(CF_o_PivaLabel)
        Me.Controls.Add(Me.CF_o_PivaTextBox)
        Me.Controls.Add(KgLabel)
        Me.Controls.Add(Me.KgTextBox)
        Me.Controls.Add(Me.SansaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sansa"
        Me.Text = "Sansa"
        CType(Me.FattureDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SansaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SansaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SansaBindingNavigator.ResumeLayout(False)
        Me.SansaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FattureDataSet As Gestione_Frantoio.FattureDataSet
    Friend WithEvents SansaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SansaTableAdapter As Gestione_Frantoio.FattureDataSetTableAdapters.SansaTableAdapter
    Friend WithEvents TableAdapterManager As Gestione_Frantoio.FattureDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SansaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SansaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Riferimento_DocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DenominazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComuneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CF_o_PivaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StampaBolla As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Numero_OperazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaricatoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CausaleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
End Class
