Module Variables
    Sub Main()
        'Declaraciones
        Dim nombre As String
        Dim apellido As String
        Dim nacimiento As Date


        'Asignación por teclado
        Console.Write("Ingrese su Nombre:")
        nombre = Console.ReadLine()

        Console.Write("Ingrese su Apellido:")
        apellido = Console.ReadLine

        Console.Write("Ingrese su Fecha de Nacimiento(ej: DD/MM/AAAA):")
        nacimiento = Console.ReadLine


        'Muestro en pantalla los datos
        Console.Write("")
        Console.Write(">>>>>>>Datos<<<<<<<")
        Console.Write(nombre)
        Console.Write(apellido)
        Console.Write(nacimiento)
    End Sub

End Module