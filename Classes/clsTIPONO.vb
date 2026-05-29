Public Class clsTIPONO
    Private ReadOnly MyCnn As SqlClient.SqlConnection
    Private MyTN_COD As String
    Private MyTN_Nome As String

    Public Event Action(ByVal status As Integer)
    Public Event Errors(ByVal errMessages As Object)

    Public Property COD() As String
        Get
            Return MyTN_COD
        End Get
        Set(ByVal value As String)
            MyTN_COD = value
        End Set
    End Property

    Public Property NOME() As String
        Get
            Return MyTN_Nome
        End Get
        Set(ByVal value As String)
            MyTN_Nome = value
        End Set
    End Property

    Public Sub New(ByVal dbConStr As String)
        MyCnn = New SqlClient.SqlConnection(dbConStr)
    End Sub

    Public Function sql_TIPONO_SELALL() As DataTable
        Dim Cmd As New SqlClient.SqlCommand With {
            .Connection = MyCnn,
            .CommandText = "TIPONO_SELALL",
            .CommandType = CommandType.StoredProcedure
        }

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Dim tbl As New DataTable
            tbl.Load(Cmd.ExecuteReader)
            Return tbl
        Catch ex As Exception
            RaiseEvent Errors(ex.Message)
            Return Nothing
        Finally
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
        End Try
    End Function

    Public Sub sql_TIPONO_INS(ByVal TNCOD As String, ByVal TNNOME As String)
        Dim Cmd As New SqlClient.SqlCommand With {
            .Connection = MyCnn,
            .CommandText = "TIPONO_INS",
            .CommandType = CommandType.StoredProcedure
        }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
            .ParameterName = "@TNCOD",
            .DbType = DbType.String,
            .Direction = ParameterDirection.Input,
            .Value = TNCOD
        })

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
            .ParameterName = "@TNNOME",
            .DbType = DbType.String,
            .Direction = ParameterDirection.Input,
            .Value = TNNOME
        })

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Cmd.ExecuteNonQuery()
            RaiseEvent Action(8)
        Catch ex As SqlClient.SqlException
            If ex.Message.StartsWith("Violation of PRIMARY KEY constraint") Then
                RaiseEvent Action(5)
            Else
                RaiseEvent Errors(ex.Message)
            End If
        Catch ex As Exception
            RaiseEvent Errors(ex.Message)
        Finally
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
        End Try
    End Sub

    Public Sub sql_TIPONO_DEL(ByVal TNCOD As String)
        Dim Cmd As New SqlClient.SqlCommand With {
            .Connection = MyCnn,
            .CommandText = "TIPONO_DEL",
            .CommandType = CommandType.StoredProcedure
        }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
            .ParameterName = "@TNCOD",
            .DbType = DbType.String,
            .Direction = ParameterDirection.Input,
            .Value = TNCOD
        })

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Cmd.ExecuteNonQuery()
            RaiseEvent Action(6)
        Catch ex As Exception
            RaiseEvent Errors(ex.Message)
        Finally
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
        End Try
    End Sub

    Public Sub sql_TIPONO_UPD(ByVal TNCOD As String, ByVal TNNOME As String)
        Dim Cmd As New SqlClient.SqlCommand With {
            .Connection = MyCnn,
            .CommandText = "TIPONO_UPD",
            .CommandType = CommandType.StoredProcedure
        }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
            .ParameterName = "@TNCOD",
            .DbType = DbType.String,
            .Direction = ParameterDirection.Input,
            .Value = TNCOD
        })

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
            .ParameterName = "@TNNOME",
            .DbType = DbType.String,
            .Direction = ParameterDirection.Input,
            .Value = TNNOME
        })

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Cmd.ExecuteNonQuery()
            RaiseEvent Action(7)
        Catch ex As Exception
            RaiseEvent Errors(ex.Message)
        Finally
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
        End Try
    End Sub

    Public Sub sql_TIPONO_SEL1(ByVal TNCOD As String)
        Dim Cmd As New SqlClient.SqlCommand With {
            .Connection = MyCnn,
            .CommandText = "TIPONO_SEL1",
            .CommandType = CommandType.StoredProcedure
        }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
            .ParameterName = "@TNCOD",
            .DbType = DbType.String,
            .Direction = ParameterDirection.Input,
            .Value = TNCOD
        })

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Dim tbl As New DataTable
            tbl.Load(Cmd.ExecuteReader)
            If tbl.Rows.Count > 0 Then
                MyTN_COD = tbl.Rows(0)("TN_COD").ToString()
                MyTN_Nome = tbl.Rows(0)("TN_DESCR").ToString()
                RaiseEvent Action(-1)
            Else
                MyTN_COD = Nothing
                MyTN_Nome = Nothing
                RaiseEvent Action(2)
            End If
        Catch ex As Exception
            RaiseEvent Errors(ex.Message)
        Finally
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
        End Try
    End Sub
End Class
