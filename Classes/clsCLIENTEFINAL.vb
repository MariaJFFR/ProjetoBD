Public Class clsCLIENTEFINAL
    Private ReadOnly MyCnn As SqlClient.SqlConnection
    Private MyCF_ID As Integer
    Private MyCF_Nome As String
    Private MyCF_Valor As Integer

    Public Event Action(ByVal status As Integer)
    Public Event Errors(ByVal errMessages As Object)

    Public Property ID() As Integer
        Get
            ID = MyCF_ID
        End Get
        Set(ByVal value As Integer)
            MyCF_ID = value
        End Set
    End Property

    Public Property NOME() As String
        Get
            NOME = MyCF_Nome
        End Get
        Set(ByVal value As String)
            MyCF_Nome = value
        End Set
    End Property

    Public Property VALOR() As Integer
        Get
            VALOR = MyCF_Valor
        End Get
        Set(ByVal value As Integer)
            MyCF_Valor = value
        End Set
    End Property

    Public Sub New(ByVal dbConStr As String)
        MyCnn = New SqlClient.SqlConnection(dbConStr)
    End Sub

    Public Function sql_CLIENTEFINAL_SEL1(ByVal CFID As Integer) As DataTable
        Dim Cmd As New SqlClient.SqlCommand
        With Cmd
            .Connection = MyCnn
            .CommandText = "CLIENTEFINAL_SEL1"
            .CommandType = CommandType.StoredProcedure
        End With

        Dim prm As SqlClient.SqlParameter

        prm = New SqlClient.SqlParameter
        With prm
            .ParameterName = "@CF_ID"
            .DbType = DbType.Int32
            .Direction = ParameterDirection.Input
            .Value = CFID
        End With

        Cmd.Parameters.Add(prm)

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Dim tbl As New DataTable
            tbl.Load(Cmd.ExecuteReader)
            sql_CLIENTEFINAL_SEL1 = tbl
            MyCnn.Close()
        Catch ex As Exception
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
            sql_CLIENTEFINAL_SEL1 = Nothing

            RaiseEvent Errors(ex.Message)
        End Try
    End Function


    Public Function sql_CLIENTEFINAL_SELALL() As DataTable
        Dim Cmd As New SqlClient.SqlCommand
        With Cmd
            .Connection = MyCnn
            .CommandText = "CLIENTEFINAL_SELLALL"
            .CommandType = CommandType.StoredProcedure
        End With

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Dim tbl As New DataTable
            tbl.Load(Cmd.ExecuteReader)
            sql_CLIENTEFINAL_SELALL = tbl
            MyCnn.Close()
        Catch ex As Exception
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
            sql_CLIENTEFINAL_SELALL = Nothing
            RaiseEvent Errors(ex.Message)
        End Try
    End Function

    Public Sub sql_CLIENTEFINAL_INS(ByVal CF_NOME As String, ByVal CF_VALOR As Integer)
        Dim Cmd As New SqlClient.SqlCommand With {
        .Connection = MyCnn,
        .CommandText = "CLIENTEFINAL_INS",
        .CommandType = CommandType.StoredProcedure
    }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@CF_NOME",
        .DbType = DbType.String,
        .Direction = ParameterDirection.Input,
        .Value = CF_NOME
    })

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@CF_VALOR",
        .DbType = DbType.Int32,
        .Direction = ParameterDirection.Input,
        .Value = CF_VALOR
    })

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Cmd.ExecuteNonQuery()
            RaiseEvent Action(8)
        Catch ex As Exception
            RaiseEvent Errors(ex.Message)
        Finally
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
        End Try
    End Sub

    Public Sub sql_CLIENTEFINAL_DEL(ByVal CF_ID As Integer)
        Dim Cmd As New SqlClient.SqlCommand With {
            .Connection = MyCnn,
            .CommandText = "CLIENTEFINAL_DEL",
            .CommandType = CommandType.StoredProcedure
        }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
            .ParameterName = "@CF_ID",
            .DbType = DbType.Int16,
            .Direction = ParameterDirection.Input,
            .Value = CF_ID
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

    Public Sub sql_CLIENTEFINAL_UPD(ByVal CF_ID As Integer, ByVal CF_NOME As String)
        Dim Cmd As New SqlClient.SqlCommand With {
            .Connection = MyCnn,
            .CommandText = "CLIENTEFINAL_UPD",
            .CommandType = CommandType.StoredProcedure
        }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
            .ParameterName = "@CF_ID",
            .DbType = DbType.Int32,
            .Direction = ParameterDirection.Input,
            .Value = CF_ID
        })

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
            .ParameterName = "@CF_NOME",
            .DbType = DbType.String,
            .Direction = ParameterDirection.Input,
            .Value = CF_NOME
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

End Class
