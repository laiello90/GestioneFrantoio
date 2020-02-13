<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acque
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
        Dim BollaLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim KgAcqueLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim Stato_FisicoLabel As System.Windows.Forms.Label
        Dim DestinazioneLabel As System.Windows.Forms.Label
        Dim DenominazioneLabel As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim CittàLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim Targa_MezzoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acque))
        Me.FattureDataSet = New Gestione_Frantoio.FattureDataSet()
        Me.AcqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcqueTableAdapter = New Gestione_Frantoio.FattureDataSetTableAdapters.AcqueTableAdapter()
        Me.TableAdapterManager = New Gestione_Frantoio.FattureDataSetTableAdapters.TableAdapterManager()
        Me.AcqueBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AcqueBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.BollaTextBox = New System.Windows.Forms.TextBox()
        Me.KgAcqueTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.Stato_FisicoTextBox = New System.Windows.Forms.TextBox()
        Me.DestinazioneTextBox = New System.Windows.Forms.TextBox()
        Me.DenominazioneTextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.CittàTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.Targa_MezzoTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.StampaBolla = New System.Drawing.Printing.PrintDocument()
        IdLabel = New System.Windows.Forms.Label()
        BollaLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        KgAcqueLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        Stato_FisicoLabel = New System.Windows.Forms.Label()
        DestinazioneLabel = New System.Windows.Forms.Label()
        DenominazioneLabel = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        CittàLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        Targa_MezzoLabel = New System.Windows.Forms.Label()
        CType(Me.FattureDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcqueBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AcqueBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(14, 512)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 18)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        IdLabel.Visible = False
        '
        'BollaLabel
        '
        BollaLabel.AutoSize = True
        BollaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BollaLabel.Location = New System.Drawing.Point(12, 239)
        BollaLabel.Name = "BollaLabel"
        BollaLabel.Size = New System.Drawing.Size(103, 18)
        BollaLabel.TabIndex = 3
        BollaLabel.Text = "Numero Bolla:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.Location = New System.Drawing.Point(259, 239)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(43, 18)
        DataLabel.TabIndex = 5
        DataLabel.Text = "Data:"
        '
        'KgAcqueLabel
        '
        KgAcqueLabel.AutoSize = True
        KgAcqueLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        KgAcqueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KgAcqueLabel.Location = New System.Drawing.Point(12, 278)
        KgAcqueLabel.Name = "KgAcqueLabel"
        KgAcqueLabel.Size = New System.Drawing.Size(79, 18)
        KgAcqueLabel.TabIndex = 7
        KgAcqueLabel.Text = "Acque Kg.:"
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DescrizioneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescrizioneLabel.Location = New System.Drawing.Point(37, 396)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(91, 18)
        DescrizioneLabel.TabIndex = 9
        DescrizioneLabel.Text = "Descrizione:"
        '
        'Stato_FisicoLabel
        '
        Stato_FisicoLabel.AutoSize = True
        Stato_FisicoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Stato_FisicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stato_FisicoLabel.Location = New System.Drawing.Point(37, 422)
        Stato_FisicoLabel.Name = "Stato_FisicoLabel"
        Stato_FisicoLabel.Size = New System.Drawing.Size(91, 18)
        Stato_FisicoLabel.TabIndex = 11
        Stato_FisicoLabel.Text = "Stato Fisico:"
        '
        'DestinazioneLabel
        '
        DestinazioneLabel.AutoSize = True
        DestinazioneLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DestinazioneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinazioneLabel.Location = New System.Drawing.Point(12, 473)
        DestinazioneLabel.Name = "DestinazioneLabel"
        DestinazioneLabel.Size = New System.Drawing.Size(98, 18)
        DestinazioneLabel.TabIndex = 13
        DestinazioneLabel.Text = "Destinazione:"
        '
        'DenominazioneLabel
        '
        DenominazioneLabel.AutoSize = True
        DenominazioneLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DenominazioneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DenominazioneLabel.Location = New System.Drawing.Point(466, 394)
        DenominazioneLabel.Name = "DenominazioneLabel"
        DenominazioneLabel.Size = New System.Drawing.Size(116, 18)
        DenominazioneLabel.TabIndex = 15
        DenominazioneLabel.Text = "Denominazione:"
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        IndirizzoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndirizzoLabel.Location = New System.Drawing.Point(468, 420)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(67, 18)
        IndirizzoLabel.TabIndex = 17
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'CittàLabel
        '
        CittàLabel.AutoSize = True
        CittàLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CittàLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CittàLabel.Location = New System.Drawing.Point(468, 446)
        CittàLabel.Name = "CittàLabel"
        CittàLabel.Size = New System.Drawing.Size(42, 18)
        CittàLabel.TabIndex = 19
        CittàLabel.Text = "Città:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProvinciaLabel.Location = New System.Drawing.Point(705, 446)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(47, 18)
        ProvinciaLabel.TabIndex = 21
        ProvinciaLabel.Text = "Prov.:"
        '
        'Targa_MezzoLabel
        '
        Targa_MezzoLabel.AutoSize = True
        Targa_MezzoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Targa_MezzoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Targa_MezzoLabel.Location = New System.Drawing.Point(468, 476)
        Targa_MezzoLabel.Name = "Targa_MezzoLabel"
        Targa_MezzoLabel.Size = New System.Drawing.Size(100, 18)
        Targa_MezzoLabel.TabIndex = 23
        Targa_MezzoLabel.Text = "Targa Mezzo:"
        '
        'FattureDataSet
        '
        Me.FattureDataSet.DataSetName = "FattureDataSet"
        Me.FattureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AcqueBindingSource
        '
        Me.AcqueBindingSource.DataMember = "Acque"
        Me.AcqueBindingSource.DataSource = Me.FattureDataSet
        '
        'AcqueTableAdapter
        '
        Me.AcqueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AcqueTableAdapter = Me.AcqueTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FattureTableAdapter = Nothing
        Me.TableAdapterManager.SansaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gestione_Frantoio.FattureDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AcqueBindingNavigator
        '
        Me.AcqueBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AcqueBindingNavigator.AutoSize = False
        Me.AcqueBindingNavigator.BindingSource = Me.AcqueBindingSource
        Me.AcqueBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AcqueBindingNavigator.CountItemFormat = "di {0}"
        Me.AcqueBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AcqueBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.AcqueBindingNavigatorSaveItem, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.AcqueBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AcqueBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AcqueBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AcqueBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AcqueBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AcqueBindingNavigator.Name = "AcqueBindingNavigator"
        Me.AcqueBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AcqueBindingNavigator.Size = New System.Drawing.Size(883, 40)
        Me.AcqueBindingNavigator.TabIndex = 0
        Me.AcqueBindingNavigator.Text = "BindingNavigator1"
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
        'AcqueBindingNavigatorSaveItem
        '
        Me.AcqueBindingNavigatorSaveItem.Image = CType(resources.GetObject("AcqueBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AcqueBindingNavigatorSaveItem.Name = "AcqueBindingNavigatorSaveItem"
        Me.AcqueBindingNavigatorSaveItem.Size = New System.Drawing.Size(54, 37)
        Me.AcqueBindingNavigatorSaveItem.Text = "Salva"
        Me.AcqueBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(55, 509)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 24)
        Me.IdTextBox.TabIndex = 2
        Me.IdTextBox.Visible = False
        '
        'BollaTextBox
        '
        Me.BollaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Bolla", True))
        Me.BollaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BollaTextBox.Location = New System.Drawing.Point(121, 236)
        Me.BollaTextBox.Name = "BollaTextBox"
        Me.BollaTextBox.Size = New System.Drawing.Size(108, 24)
        Me.BollaTextBox.TabIndex = 4
        '
        'KgAcqueTextBox
        '
        Me.KgAcqueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "KgAcque", True))
        Me.KgAcqueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KgAcqueTextBox.Location = New System.Drawing.Point(102, 275)
        Me.KgAcqueTextBox.Name = "KgAcqueTextBox"
        Me.KgAcqueTextBox.Size = New System.Drawing.Size(138, 24)
        Me.KgAcqueTextBox.TabIndex = 8
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Descrizione", True))
        Me.DescrizioneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(134, 393)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(223, 24)
        Me.DescrizioneTextBox.TabIndex = 10
        '
        'Stato_FisicoTextBox
        '
        Me.Stato_FisicoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Stato_FisicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Stato Fisico", True))
        Me.Stato_FisicoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stato_FisicoTextBox.Location = New System.Drawing.Point(134, 419)
        Me.Stato_FisicoTextBox.Name = "Stato_FisicoTextBox"
        Me.Stato_FisicoTextBox.Size = New System.Drawing.Size(223, 24)
        Me.Stato_FisicoTextBox.TabIndex = 12
        '
        'DestinazioneTextBox
        '
        Me.DestinazioneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DestinazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Destinazione", True))
        Me.DestinazioneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinazioneTextBox.Location = New System.Drawing.Point(116, 470)
        Me.DestinazioneTextBox.Name = "DestinazioneTextBox"
        Me.DestinazioneTextBox.Size = New System.Drawing.Size(280, 24)
        Me.DestinazioneTextBox.TabIndex = 14
        '
        'DenominazioneTextBox
        '
        Me.DenominazioneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DenominazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Denominazione", True))
        Me.DenominazioneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DenominazioneTextBox.Location = New System.Drawing.Point(588, 391)
        Me.DenominazioneTextBox.Name = "DenominazioneTextBox"
        Me.DenominazioneTextBox.Size = New System.Drawing.Size(248, 24)
        Me.DenominazioneTextBox.TabIndex = 16
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Indirizzo", True))
        Me.IndirizzoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(545, 417)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(262, 24)
        Me.IndirizzoTextBox.TabIndex = 18
        '
        'CittàTextBox
        '
        Me.CittàTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CittàTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Città", True))
        Me.CittàTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CittàTextBox.Location = New System.Drawing.Point(523, 443)
        Me.CittàTextBox.Name = "CittàTextBox"
        Me.CittàTextBox.Size = New System.Drawing.Size(176, 24)
        Me.CittàTextBox.TabIndex = 20
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(758, 443)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(78, 24)
        Me.ProvinciaTextBox.TabIndex = 22
        '
        'Targa_MezzoTextBox
        '
        Me.Targa_MezzoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Targa_MezzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Targa Mezzo", True))
        Me.Targa_MezzoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Targa_MezzoTextBox.Location = New System.Drawing.Point(574, 473)
        Me.Targa_MezzoTextBox.Name = "Targa_MezzoTextBox"
        Me.Targa_MezzoTextBox.Size = New System.Drawing.Size(185, 24)
        Me.Targa_MezzoTextBox.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(232, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(232, 108)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 24)
        Me.TextBox2.TabIndex = 26
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(232, 140)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 24)
        Me.TextBox3.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(338, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 32)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Calcola"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 18)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Acque prodotte Totale Kg."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Acque scaricate Totale Kg."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Acque in magazzino Totale Kg."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 24)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Caratteristiche Rifiuti"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(519, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 24)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Destinazione"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(362, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 24)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Bolla Acque"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Location = New System.Drawing.Point(0, 322)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 10)
        Me.Panel1.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Location = New System.Drawing.Point(0, 175)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(836, 10)
        Me.Panel2.TabIndex = 36
        '
        'DataTextBox
        '
        Me.DataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AcqueBindingSource, "Data", True))
        Me.DataTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataTextBox.Location = New System.Drawing.Point(308, 236)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.ReadOnly = True
        Me.DataTextBox.Size = New System.Drawing.Size(133, 24)
        Me.DataTextBox.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(541, 279)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Inserisci data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(309, 278)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(226, 24)
        Me.DateTimePicker1.TabIndex = 42
        '
        'StampaBolla
        '
        '
        'Acque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(883, 551)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(BollaLabel)
        Me.Controls.Add(Me.BollaTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(KgAcqueLabel)
        Me.Controls.Add(Me.KgAcqueTextBox)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(Stato_FisicoLabel)
        Me.Controls.Add(Me.Stato_FisicoTextBox)
        Me.Controls.Add(DestinazioneLabel)
        Me.Controls.Add(Me.DestinazioneTextBox)
        Me.Controls.Add(DenominazioneLabel)
        Me.Controls.Add(Me.DenominazioneTextBox)
        Me.Controls.Add(IndirizzoLabel)
        Me.Controls.Add(Me.IndirizzoTextBox)
        Me.Controls.Add(CittàLabel)
        Me.Controls.Add(Me.CittàTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(Targa_MezzoLabel)
        Me.Controls.Add(Me.Targa_MezzoTextBox)
        Me.Controls.Add(Me.AcqueBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Acque"
        Me.Text = "Acque"
        CType(Me.FattureDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcqueBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AcqueBindingNavigator.ResumeLayout(False)
        Me.AcqueBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FattureDataSet As Gestione_Frantoio.FattureDataSet
    Friend WithEvents AcqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcqueTableAdapter As Gestione_Frantoio.FattureDataSetTableAdapters.AcqueTableAdapter
    Friend WithEvents TableAdapterManager As Gestione_Frantoio.FattureDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AcqueBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AcqueBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BollaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KgAcqueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrizioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stato_FisicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DestinazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DenominazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CittàTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Targa_MezzoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StampaBolla As System.Drawing.Printing.PrintDocument
End Class
