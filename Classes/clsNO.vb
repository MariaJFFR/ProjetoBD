Public Class clsNO
    Private ReadOnly MyCnn As SqlClient.SqlConnection
    Private MyN_Cod As String
    Private MyN_TN_Cod As String
    Private MyN_CF_ID As Integer
    Private MyN_Valor As Integer

    Public Event Action(ByVal status As Integer)
    Public Event Errors(ByVal errMessages As Object)


    Public Property COD() As String
        Get
            COD = MyN_Cod
        End Get
        Set(ByVal value As String)
            MyN_Cod = value
        End Set
    End Property

    Public Property TN_Cod() As String
        Get
            TN_Cod = MyN_TN_Cod
        End Get
        Set(ByVal value As String)
            MyN_TN_Cod = value
        End Set
    End Property
    Public Property CF_ID() As Integer
        Get
            CF_ID = MyN_CF_ID
        End Get
        Set(ByVal value As Integer)
            MyN_CF_ID = value
        End Set
    End Property
    Public Property N_VAL() As Integer
        Get
            N_VAL = MyN_Valor
        End Get
        Set(ByVal value As Integer)
            MyN_Valor = value
        End Set
    End Property

    Public Sub New(ByVal dbConStr As String)
        MyCnn = New SqlClient.SqlConnection(dbConStr)
    End Sub

    Public Function sql_NO_SELLALL() As DataTable
        Dim Cmd As New SqlClient.SqlCommand
        With Cmd
            .Connection = MyCnn
            .CommandText = "NO_SELLALL"
            .CommandType = CommandType.StoredProcedure
        End With

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Dim tbl As New DataTable
            tbl.Load(Cmd.ExecuteReader)
            sql_NO_SELLALL = tbl
            MyCnn.Close()
        Catch ex As Exception
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
            sql_NO_SELLALL = Nothing
            RaiseEvent Errors(ex.Message)
        End Try
    End Function

    Public Function sql_NO_SELLCF(ByVal CFID As Integer) As DataTable
        Dim Cmd As New SqlClient.SqlCommand
        With Cmd
            .Connection = MyCnn
            .CommandText = "NO_SELCF"
            .CommandType = CommandType.StoredProcedure
        End With
        Dim prm As New SqlClient.SqlParameter
        With prm
            .ParameterName = "@CFID"
            .DbType = DbType.Int16
            .Direction = ParameterDirection.Input
            .Value = CFID
        End With
        Cmd.Parameters.Add(prm)

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Dim tbl As New DataTable
            tbl.Load(Cmd.ExecuteReader)
            sql_NO_SELLCF = tbl
            MyCnn.Close()
        Catch ex As Exception
            If MyCnn.State = ConnectionState.Open Then MyCnn.Close()
            sql_NO_SELLCF = Nothing
            RaiseEvent Errors(ex.Message)
        End Try
    End Function

    Public Sub sql_NO_INS(ByVal N_COD As String, ByVal TN_COD As String, ByVal CF_ID As Integer, ByVal N_VALOR As Integer)
        Dim Cmd As New SqlClient.SqlCommand With {
        .Connection = MyCnn,
        .CommandText = "NO_INS",
        .CommandType = CommandType.StoredProcedure
    }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@CF_ID",
        .DbType = DbType.Int32,
        .Direction = ParameterDirection.Input,
        .Value = CF_ID
    })
        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@N_Cod",
        .DbType = DbType.String,
        .Direction = ParameterDirection.Input,
        .Value = N_COD
    })
        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@N_TN_Cod",
        .DbType = DbType.String,
        .Direction = ParameterDirection.Input,
        .Value = TN_COD
    })
        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@N_Valor",
        .DbType = DbType.Int32,
        .Direction = ParameterDirection.Input,
        .Value = N_VALOR
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

    Public Sub sql_NO_DEL(ByVal N_COD As String)
        Dim Cmd As New SqlClient.SqlCommand With {
        .Connection = MyCnn,
        .CommandText = "NO_DEL",
        .CommandType = CommandType.StoredProcedure
    }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@N_Cod",
        .DbType = DbType.String,
        .Direction = ParameterDirection.Input,
        .Value = N_COD
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

    Public Sub sql_NO_UPD(ByVal N_COD As String, ByVal TN_COD As String, ByVal N_VALOR As Integer)
        Dim Cmd As New SqlClient.SqlCommand With {
        .Connection = MyCnn,
        .CommandText = "NO_UPD",
        .CommandType = CommandType.StoredProcedure
    }

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@N_Cod",
        .DbType = DbType.String,
        .Direction = ParameterDirection.Input,
        .Value = N_COD
    })

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@N_TN_Cod",
        .DbType = DbType.String,
        .Direction = ParameterDirection.Input,
        .Value = TN_COD
    })

        Cmd.Parameters.Add(New SqlClient.SqlParameter With {
        .ParameterName = "@N_Valor",
        .DbType = DbType.Int32,
        .Direction = ParameterDirection.Input,
        .Value = N_VALOR
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