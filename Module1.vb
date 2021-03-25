Imports System.Data.OleDb
Module ModuleRegAuto

    Public Function RegAuto()

        Dim summ As String
        Dim prib As String
        summ = Form1.TextBox6.Text
        prib = Form1.TextBox5.Text


        Dim SozdOb As String
        'Создание объекта и передача ему строки соединения
        Dim Connection = New OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=Microsoft Office Access 2007 База данных (2).mdb")
        Connection.Open()
        'создание объекта и присваивание ему SQL запроса
        SozdOb = "insert into [Таблица1](" & " [Сумма],[Прибыль]) values ('" & summ & "','" & prib & "')"
        'создание объекта и передача ему SQL команды
        Dim command = New OleDbCommand(SozdOb)
        command.Connection = Connection
        Try
            'Выполнение SQL команды
            command.ExecuteNonQuery()
            MessageBox.Show("Данные занесены в базу!", "Запись добавленна.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Connection.Close()

    End Function


End Module