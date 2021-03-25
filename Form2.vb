Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "_Microsoft_Office_Access_2007_База_данных__2_DataSet.Таблица1". При необходимости она может быть перемещена или удалена.
        Me.Таблица1TableAdapter.Fill(Me._Microsoft_Office_Access_2007_База_данных__2_DataSet.Таблица1)

        Dim connection As New OleDb.OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=Microsoft Office Access 2007 База данных (2).mdb")
        connection.Open()
        'создание объекта и передача ему SQL-командымии
        Dim command As New System.Data.OleDb.OleDbCommand("Select [Сумма],[Прибыль] From [Таблица1]", connection)
        'Выполнение SQL-команды
        Dim datareader As OleDb.OleDbDataReader = command.ExecuteReader
        Dim datatable As New DataTable
        'Заполняем шапку таблицы
        datatable.Columns.Add(datareader.GetName(0))
        datatable.Columns.Add(datareader.GetName(1))


        While datareader.Read() = True
            'Заполняем ячейки таблицы
            datatable.Rows.Add(New String() {datareader.GetValue(0), datareader.GetValue(1)})
        End While
        datareader.Close() : connection.Close()
        DataGridView1.DataSource = datatable


    End Sub
End Class