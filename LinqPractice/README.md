# LinqPractice

Pequeño proyecto de ejemplo para practicar consultas LINQ en C#.

Contenido relevante:
- `Books.json` — archivo JSON con libros. Está en la carpeta del proyecto: `LinqPractice/LinqPractice/Books.json`.

Esquema (por objeto):
- `id` (int)
- `title` (string)
- `author` (string)
- `datepublished` (string, formato dd-MM-yyyy)
- `publisher` (string)
- `year` (int)
- `page` (int)
- `isbn` (string)
- `price` (number)

Ejecutar la aplicación (PowerShell):
```powershell
cd 'c:\Users\piero\Downloads\LinqPractice\LinqPractice'
dotnet run
```

Convertir `Books.json` a CSV (PowerShell):
```powershell
Get-Content 'Books.json' -Raw | ConvertFrom-Json | Select id,title,author,datepublished,publisher,year,page,isbn,price | Export-Csv -Path 'books.csv' -NoTypeInformation -Encoding UTF8
```

Notas:
- `Books.json` actualmente contiene 50 libros de ejemplo con campos realistas.
- Si quieres que cambie el esquema (por ejemplo `datepublished` → `fecha`) o que exporte el CSV por ti, dime y lo hago.
