Imports System

Module Variables_Tipos
    Sub Main(args As String())
        Dim NombrePersona, LugarNacimiento, Nacionalidad, NombreCalle As String
        Dim DNI, NroHabitantesNacionales As UInteger
        Dim FechaNacimiento As Date
        Dim TemperaturaAmbiente, DistanciaEntre2Ciudades, ProfundidadMar, PesoProducto, PrecioProducto As Single
        Dim AlturaCalle, AlturaCorporal As UShort

        NombrePersona = "Lucas"
        DNI = 43096189
        LugarNacimiento = "Corrientes"
        FechaNacimiento = "8-12-99"
        AlturaCorporal = 270
        Nacionalidad = "Argentino"
        TemperaturaAmbiente = 12
        NombreCalle = "Bolivar"
        AlturaCalle = 1235
        DistanciaEntre2Ciudades = 12000
        ProfundidadMar = 11000
        NroHabitantesNacionales = 42000000
        PesoProducto = 60.4
        PrecioProducto = 15.5

        Console.WriteLine("Nombre de una Persona: " & NombrePersona)
        Console.WriteLine("Número de Documento: " & DNI)
        Console.WriteLine("Lugar de Nacimiento: " & LugarNacimiento)
        Console.WriteLine("Fecha de Nacimiento: " & FechaNacimiento)
        Console.WriteLine("Altura Corporal: " & AlturaCorporal & "cms")
        Console.WriteLine("Nacionalidad: " & Nacionalidad)
        Console.WriteLine("Temperatura Ambiente: " & TemperaturaAmbiente & "°")
        Console.WriteLine("Nombre de la Calle: " & NombreCalle)
        Console.WriteLine("Altura de la Calle: " & AlturaCalle)
        Console.WriteLine("Distancia entre 2 Ciudades Cualquiera: " & DistanciaEntre2Ciudades & "kms")
        Console.WriteLine("Profundidad del Mar: " & ProfundidadMar & "ms")
        Console.WriteLine("Cantidad de Habitantes del Territorio Nacional: " & NroHabitantesNacionales)
        Console.WriteLine("Peso de un Producto de Supermercado: " & PesoProducto & "kg")
        Console.WriteLine("Monto de un Artículo de Supermercado: " & PrecioProducto)
    End Sub
End Module
