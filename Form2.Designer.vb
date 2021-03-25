<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me._Microsoft_Office_Access_2007_База_данных__2_DataSet = New Банк_Свобода._Microsoft_Office_Access_2007_База_данных__2_DataSet
        Me.Таблица1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Таблица1TableAdapter = New Банк_Свобода._Microsoft_Office_Access_2007_База_данных__2_DataSetTableAdapters.Таблица1TableAdapter
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.СуммаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПрибыльDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Microsoft_Office_Access_2007_База_данных__2_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Таблица1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.СуммаDataGridViewTextBoxColumn, Me.ПрибыльDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Таблица1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(341, 373)
        Me.DataGridView1.TabIndex = 0
        '
        '_Microsoft_Office_Access_2007_База_данных__2_DataSet
        '
        Me._Microsoft_Office_Access_2007_База_данных__2_DataSet.DataSetName = "_Microsoft_Office_Access_2007_База_данных__2_DataSet"
        Me._Microsoft_Office_Access_2007_База_данных__2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Таблица1BindingSource
        '
        Me.Таблица1BindingSource.DataMember = "Таблица1"
        Me.Таблица1BindingSource.DataSource = Me._Microsoft_Office_Access_2007_База_данных__2_DataSet
        '
        'Таблица1TableAdapter
        '
        Me.Таблица1TableAdapter.ClearBeforeFill = True
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        '
        'СуммаDataGridViewTextBoxColumn
        '
        Me.СуммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма"
        Me.СуммаDataGridViewTextBoxColumn.HeaderText = "Сумма"
        Me.СуммаDataGridViewTextBoxColumn.Name = "СуммаDataGridViewTextBoxColumn"
        '
        'ПрибыльDataGridViewTextBoxColumn
        '
        Me.ПрибыльDataGridViewTextBoxColumn.DataPropertyName = "Прибыль"
        Me.ПрибыльDataGridViewTextBoxColumn.HeaderText = "Прибыль"
        Me.ПрибыльDataGridViewTextBoxColumn.Name = "ПрибыльDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 408)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "База данных"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Microsoft_Office_Access_2007_База_данных__2_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Таблица1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents _Microsoft_Office_Access_2007_База_данных__2_DataSet As Банк_Свобода._Microsoft_Office_Access_2007_База_данных__2_DataSet
    Friend WithEvents Таблица1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Таблица1TableAdapter As Банк_Свобода._Microsoft_Office_Access_2007_База_данных__2_DataSetTableAdapters.Таблица1TableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СуммаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПрибыльDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
