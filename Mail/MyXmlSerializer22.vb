Imports System.Xml

Public Class MyXmlSerializer22

    Public Sub Serialize(ByVal path As String, ByVal obj As Object)
        Dim serializer As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(obj.[GetType]())
        Dim writer As XmlWriter = XmlWriter.Create(path)
        serializer.Serialize(writer, obj)
        writer.Close()
    End Sub

    Public Function Deserialize(ByVal path As String, ByVal type As Type) As Object
        Dim serializer As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(type)
        Dim reader As XmlReader = XmlReader.Create(path)
        Dim obj As Object = serializer.Deserialize(reader)
        reader.Close()
        Return obj
    End Function

    Public Sub Serialize(Of T)(ByVal path As String, ByVal obj As T)
        Dim serializer As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(GetType(T))
        Dim writer As XmlWriter = XmlWriter.Create(path)
        serializer.Serialize(writer, obj)
        writer.Close()
    End Sub

    Public Function Deserialize(Of T)(ByVal path As String) As T
        Dim serializer As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(GetType(T))
        Dim reader As XmlReader = XmlReader.Create(path)
        Dim obj = serializer.Deserialize(reader)
        reader.Close()
        Return CType(obj, T)
    End Function

End Class
