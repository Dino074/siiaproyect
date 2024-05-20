Imports System.Data.SqlClient
Module conexionBD
    'La variable conexion es la que permite conectarnos a nuestro SQL
    'data source= donde esta conectada nuestra base de datos
    Public conexion As New SqlConnection("data source= DESKTOP-1145PHU\SQLEXPRESS; initial catalog= siia_uadec; integrated security= SSPI; persist security info= false; trusted_connection = yes;")
    'Nos permite ejecutar los comandos que  tienen que ver con los procedimientos
    'almacenados de sql
    Public cmd As SqlCommand
    'permite leer los datos
    Public sqlread As SqlDataReader
    Public Query As String
    Public i As Integer
End Module
