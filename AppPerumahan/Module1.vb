Imports MySql.Data.MySqlClient

Module Module1
    Public Conn, ConnUpdate As New MySqlConnection
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public Dt As DataTable
    Public Rd As MySqlDataReader
    Public Cmd As MySqlCommand

    Public Function cek_koneksi(ByVal Server As String, ByVal Port As String, ByVal User As String, ByVal Password As String, ByVal DBName As String)
        Conn.Close()
        Conn.ConnectionString = "datasource=" & Server & ";" _
                                & "port=" & Port & ";" _
                                & "username=" & User & ";" _
                                & "password=" & Password & ";" _
                                & "database=" & DBName & ";" _
                                & "Persist Security Info=True;Convert Zero Datetime=True"
        Try
            Conn.Open()
            cek_koneksi = True

            ConnUpdate.Close()
            ConnUpdate.ConnectionString = "datasource=" & Server & ";" _
                                        & "port=" & Port & ";" _
                                        & "username=" & User & ";" _
                                        & "password=" & Password & ";" _
                                        & "database=" & DBName & ";" _
                                        & "Persist Security Info=True;Convert Zero Datetime=True"
            ConnUpdate.Open()
        Catch ex As MySqlException
            cek_koneksi = False
        End Try
    End Function

    'fungsi untuk write file .ini
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpSection As String, ByVal lpParamName As String, _
    ByVal lpParamVal As String, ByVal lpFileName As String) As Int32

    'procedure untuk write .ini
    Public Sub WriteIni(ByVal iniFilename As String, ByVal section As String, ByVal ParamName As String, ByVal ParamVal As String)
        'menanggil fungsi WritePrivateProfilString untuk write file .ini
        Dim result As Integer = WritePrivateProfileString(section, ParamName, ParamVal, iniFilename)
    End Sub

    'function untuk read file .ini
    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpSection As String, ByVal lpParamName As String, _
    ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFilename As String) As Int32

    'function untuk read file .ini
    Public Function ReadIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), iniFileName)
        'mengembalikan nilai yang sudah didapatkan
        ReadIni = Strings.Left(ParamVal, LenParamVal)
    End Function


End Module
