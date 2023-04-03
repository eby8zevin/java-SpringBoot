Imports System.Linq
Imports System.Collections.Generic

Class Pelanggan
  'properti
  Public Property NamaDepan As String
  Public Property NamaBelakang As String
  Public Property NoTelepon As String
  Public Property Kota As String
  
  'konstruktor
  Public Sub New(ByVal nd As String, _
                 ByVal nb As String, _
                 ByVal nt As String, _
                 ByVal k As String)
    NamaDepan = nd
    NamaBelakang = nb
    NoTelepon = nt
    Kota = k
  End Sub  
End Class

Module Program
  Sub Main()
    'sumber data berupa List(Of T)
    Dim list As List(Of Pelanggan) = New List(Of Pelanggan)()
    
    'menambah data ke dalam list
    list.Add( _
      New Pelanggan("Adi", "Wardhana", _
                    "022-25166555", "Bandung"))
    list.Add( _
      New Pelanggan("Kartika", "Dewi", _
                    "022-72011222", "Bandung"))
    list.Add( _
      New Pelanggan("Akhmad", "Maulana", _
                    "022-20099888", "Bandung"))
    list.Add( _
      New Pelanggan("Cindy", "Melani", _
                    "021-80822111", "Jakarta"))
    list.Add( _
      New Pelanggan("Dewi", "Ayuandira", _ 
                    "022-25177555", "Bandung"))
    list.Add( _
      New Pelanggan("Akhmad", "Kosyim", _
                    "021-77700111", "Jakarta"))
    list.Add( _
      New Pelanggan("Alex", "Hendrawan", _ 
                    "021-77711222", "Jakarta"))
    list.Add( _
      New Pelanggan("Bambang", "Suwiryo", _
                    "024-83144555", "Semarang"))
    list.Add( _
      New Pelanggan("Joko", "Santoso", _ 
                    "024-83144999", "Semarang"))
    
    'membuat query
    Dim hasil = _
          from e in list
          group by NamaKota = e.Kota
          into TEMP = Group
          where TEMP.Count() > 2
          select TEMP
    
    'mengakses grup di dalam hasil query
    For Each grup As IEnumerable(Of Pelanggan) In hasil
      Console.WriteLine(grup.ToArray()(0).Kota)
      'mengakses elemen di dalam grup
      For Each elemen As Pelanggan In grup
        Console.WriteLine("{0}{1} {2} {3}{4}",
          vbTab, _
          elemen.NamaDepan, _
          elemen.NamaBelakang, _
          vbTab, _
          elemen.NoTelepon)
      Next
      'membuat baris di setiap grup
      Console.WriteLine()
    Next

    Console.ReadLine()
  End Sub
End Module
