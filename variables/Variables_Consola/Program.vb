Imports System

Module Program
    Sub Main(args As String())
        'Declaraciones
        Dim nombre As String
        Dim apellido As String
        Dim nacimiento As Date
        Dim datospersonales As String

        'Asignaci�n por teclado
        Console.Write("Ingrese su Nombre:")
        nombre = Console.ReadLine()

        Console.Write("Ingrese su Apellido:")
        apellido = Console.ReadLine

        Console.Write("Ingrese su Fecha de Nacimiento (ej: DD/MM/AAAA):")
        nacimiento = Console.ReadLine
        Console.WriteLine(vbCrLf)
        datospersonales = nombre & " " & apellido & " naci� el " & nacimiento & "."

        'Muestro en pantalla los datos
        Console.WriteLine(">>>>>>>Datos Personales<<<<<<<" & vbCrLf)
        Console.WriteLine(datospersonales)
    End Sub
End Module
