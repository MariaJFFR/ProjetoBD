Public Class clsPARI
    Private ReadOnly MyCnn As SqlClient.SqlConnection
    Private MyPI_NUM As Integer
    Private MyPI_DESCR As String
    Private MyPI_VAL As String

    Public Event Action(ByVal status As Integer)
    Public Event Errors(ByVal errMessages As Object)

    Public Property NUM() As Integer
        Get
            NUM = MyPI_NUM
        End Get
        Set(ByVal value As Integer)
            MyPI_NUM = value
        End Set
    End Property

    Public Property DESCR() As String
        Get
            DESCR = MyPI_DESCR
        End Get
        Set(ByVal value As String)
            MyPI_DESCR = value
        End Set
    End Property


    Public Property VAL() As String
        Get
            VAL = MyPI_VAL
        End Get
        Set(ByVal value As String)
            MyPI_VAL = value
        End Set
    End Property
    Public Sub New(ByVal dbConStr As String)
        MyCnn = New SqlClient.SqlConnection(dbConStr)
    End Sub

    Public Sub sql_PARI_SEL1(ByVal PNUM As Integer)
        Dim Cmd As New SqlClient.SqlCommand
        With Cmd
            .Connection = MyCnn
            .CommandType = CommandType.StoredProcedure
            .CommandText = "PARI_SEL1"
        End With

        Dim prm As SqlClient.SqlParameter

        prm = New SqlClient.SqlParameter
        With prm
            .ParameterName = "@PNUM"
            .DbType = DbType.Int16
            .Direction = ParameterDirection.Input
            .Value = PNUM
        End With
        Cmd.Parameters.Add(prm)

        Try
            If MyCnn.State = ConnectionState.Closed Then MyCnn.Open()
            Dim tbl As New DataTable
            tbl.Load(Cmd.ExecuteReader)
            If tbl.Rows.Count > 0 Then
                Me.MyPI_NUM = tbl.Rows(0)("PI_Num")
                Me.MyPI_DESCR = tbl.Rows(0)("PI_Desc")
                Me.MyPI_VAL = tbl.Rows(0)("PI_Val")
                RaiseEvent Action(-1)
            Else
                Me.MyPI_NUM = vbNull
                Me.MyPI_DESCR = vbNull
                Me.MyPI_VAL = vbNull
                RaiseEvent Action(2)
            End If
        Catch ex As Exception
            RaiseEvent Errors(ex.Message)
        End Try
    End Sub




End Class