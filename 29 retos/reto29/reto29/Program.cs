// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string rutcuento = "cuento.txt";

if (!File.Exists(rutcuento))
{
    Console.WriteLine("el txt no existe");
    return;
}

string cuento = File.ReadAllText(rutcuento);

using ( StreamWriter leer = new StreamWriter("resultado.txt"))
{
    //reto 1 string.concat (): une el nombre del psj botin y explorador
    String psj = "Bitín", rol = "Explorador";
    string res1 = string.Concat(psj," ", rol);
    Console.WriteLine("Reto 1 string.Concat(): " + res1);
    leer.WriteLine("reto 1 string.Concat(): " + res1);
    leer.WriteLine();

    // reto 2 separa el cuento en oraciones por "." y unelas con el separador "|"
    string[] oraciones = cuento.Split('.', StringSplitOptions.RemoveEmptyEntries);
    string res2 = string.Join(" | ", oraciones);

    Console.WriteLine("Reto 2 string.Join(): " + res2);
    leer.WriteLine("Reto 2 string.Join(): " + res2);
    leer.WriteLine();

    // reto 3 String.format() muestra en consola: "el cuento tiene x caracteres y Y palabras"
    int carac = cuento.Length;
    int palabras = cuento.Split(new[] { ' ', '\n', '\r', '\t' },
        StringSplitOptions.RemoveEmptyEntries).Length;

    String res3 = String.Format("el cuento tiene {0} caracteres y {1} palabras", carac, palabras);
    Console.WriteLine("reto 3 String.format " + res3);
    leer.WriteLine("reto 3 String.format " + res3);
    leer.WriteLine();

    //reto 4 String.interpolation ($"...") usa interpolacion para mostrar: "el protagonista es {n} y busca {m}
    String protagonista = "Bitín";
    string meta = "una meta misteriosa";

    string res4 = $"El protagonista es {protagonista} y busca {meta}";

    Console.WriteLine("Reto 4 Interpolación: " + res4);
    leer.WriteLine("Reto 4 Interpolación: " + res4);
    leer.WriteLine();

    // reto 5 convert.to string() convierte un numero a cadena y muestralo concatenado con un msj
    string resultado5 = Convert.ToString(cuento.Length);

    Console.WriteLine("Reto 5 Convert.ToString(): " + resultado5);
    leer.WriteLine("Reto 5 Convert.ToString(): " + resultado5);
    leer.WriteLine();

    // reto 6 IndexOf() encuentra la primera posición donde aparece la palabra "mundo"
    int idxMundo = cuento.IndexOf("mundo", StringComparison.CurrentCulture);
    string res6 = (idxMundo >= 0) ? idxMundo.ToString() : "no encontrado";
    Console.WriteLine("Reto 6 IndexOf('mundo'): " + res6);
    leer.WriteLine("Reto 6 IndexOf('mundo'): " + res6);
    leer.WriteLine();

    // reto 7 LastIndexOf("ceros"):encuentra la ultima vez que aparece la palabra ceros
    int lastCeros = cuento.LastIndexOf("ceros", StringComparison.CurrentCulture);
    string res7 = (lastCeros >= 0) ? lastCeros.ToString() : "no encontrado";
    Console.WriteLine("Reto 7 LastIndexOf('ceros'): " + res7);
    leer.WriteLine("Reto 7 LastIndexOf('ceros'): " + res7);
    leer.WriteLine();

    // reto 8 Contains("Nube"): verifica si el cuento menciona la palabra nube y muestra un msj de confirmacion
    bool res8 = cuento.Contains("Nube");
    Console.WriteLine("Reto 8 Contains('Nube'): " + (res8 ? "Sí" : "No"));
    leer.WriteLine("Reto 8 Contains('Nube'): " + (res8 ? "Sí" : "No"));
    leer.WriteLine();

    // reto 9 StartsWith comprueba si el texto comienza con "En el vasto universo"
    bool res9 = cuento.StartsWith("En el vasto universo");
    Console.WriteLine("Reto 9 StartsWith('En el vasto universo'): " + (res9 ? "Sí" : "No"));
    leer.WriteLine("Reto 9 StartsWith('En el vasto universo'): " + (res9 ? "Sí" : "No"));
    leer.WriteLine();

    // reto 10 EndsWith: comprueba si el cuento termina con "ceros y unos."
    bool res10 = cuento.EndsWith("ceros y unos.");
    Console.WriteLine("Reto 10 EndsWith('ceros y unos.'): " + (res10 ? "Sí" : "No"));
    leer.WriteLine("Reto 10 EndsWith('ceros y unos.'): " + (res10 ? "Sí" : "No"));
    leer.WriteLine();

    // reto 11 Substring: extrae la palabra "ciudades luminosas" del texto original
    string a = "ciudades luminosas";
    int b = cuento.IndexOf(a, StringComparison.CurrentCulture);
    string res11 = (b >= 0) ? cuento.Substring(b , a.Length) : "no encontrado";
    Console.WriteLine("Reto 11 Substring('ciudades luminosas'): " + res11);
    leer.WriteLine("Reto 11 Substring('ciudades luminosas'): " + res11);
    leer.WriteLine();

    // reto 12 Remove(): elimina los primeros 15 caracteres si se puede
    string res12 = (cuento.Length > 15) ? cuento.Remove(0, 15) : cuento;
    Console.WriteLine("Reto 12 Remove(0, 15): " + res12);
    leer.WriteLine("Reto 12 Remove(0, 15): " + res12);
    leer.WriteLine();

    // reto 13 Replace(): reemplaza "Bitín" por "ProgramaX"
    string res13 = cuento.Replace("Bitín", "ProgramaX");
    Console.WriteLine("Reto 13 Replace('Bitín'->'ProgramaX'): " + res13);
    leer.WriteLine("Reto 13 Replace('Bitín'->'ProgramaX'): " + res13);
    leer.WriteLine();

    // reto 14 Insert(): inserta la palabra" (IMPORTANTE)" justo después de "firewall"
    string buscar = "firewall";
    int pFirewall = cuento.IndexOf(buscar, StringComparison.CurrentCulture);
    string res14 = (pFirewall >= 0)
        ? cuento.Insert(pFirewall + buscar.Length, " (IMPORTANTE)")
        : "No se encontró 'firewall'";
    Console.WriteLine("Reto 14 Insert() después de 'firewall': " + res14);
    leer.WriteLine("Reto 14 Insert() después de 'firewall': " + res14);
    leer.WriteLine();

    // reto 15 PadLeft(): rellena la palabra "Bitín" a la izquierda con '+' hasta tener 10 caracteres
    string res15 = "Bitín".PadLeft(10, '+');
    Console.WriteLine("Reto 15 PadLeft(10, '+'): " + res15);
    leer.WriteLine("Reto 15 PadLeft(10, '+'): " + res15);
    leer.WriteLine();

    // reto 16 PadRight(): rellena la palabra "Nube" a la derecha con '-' hasta tener 12 caracteres
    string res16 = "Nube".PadRight(12, '-');
    Console.WriteLine("Reto 16 PadRight(12, '-'): " + res16);
    leer.WriteLine("Reto 16 PadRight(12, '-'): " + res16);
    leer.WriteLine();

    // reto 17 Trim(): toma un fragmento con espacios extras y elimina los espacios " firewall "
    string res17 = "  firewall  ".Trim();
    Console.WriteLine("Reto 17 Trim(): '" + res17 + "'");
    leer.WriteLine("Reto 17 Trim(): '" + res17 + "'");
    leer.WriteLine();

    // reto 18 TrimStart(): elimina solo los espacios iniciales  de la frase " Mundo binario"
    string res18 = "   Mundo binario".TrimStart();
    Console.WriteLine("Reto 18 TrimStart(): '" + res18 + "'");
    leer.WriteLine("Reto 18 TrimStart(): '" + res18 + "'");
    leer.WriteLine();

    // reto 19 TrimEnd(): quitar espacios al final de "Bitín explorador "
    string res19 = "Bitín explorador      ".TrimEnd();
    Console.WriteLine("Reto 19 TrimEnd(): '" + res19 + "'");
    leer.WriteLine("Reto 19 TrimEnd(): '" + res19 + "'");
    leer.WriteLine();

    // reto 20 Split(): divide el cuento en palabras indiviudales y muestra las 10 primeras
    string[] palabrasArr = cuento.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    string[] primeras10 = palabrasArr.Take(10).ToArray();
    string res20 = string.Join(", ", primeras10);
    Console.WriteLine("Reto 20 Split() (primeras 10 palabras): " + res20);
    leer.WriteLine("Reto 20 Split() (primeras 10 palabras): " + res20);
    leer.WriteLine();

    // reto 21 Equals(): compara si "Nube" vs "nube" son iguales 
    bool res21 = "Nube".Equals("nube", StringComparison.Ordinal);
    Console.WriteLine("Reto 21 Equals('Nube','nube') : " + (res21 ? "Iguales" : "Distintas"));
    leer.WriteLine("Reto 21 Equals('Nube','nube') : " + (res21 ? "Iguales" : "Distintas"));
    leer.WriteLine();

    // reto 22 Compare(): compara alfabeticamente bitin y firewall e indica cual va primero
    int cmp = string.Compare("Bitín", "Firewall", StringComparison.CurrentCulture);
    string res22 = (cmp < 0) ? "'Bitín' va primero" : (cmp > 0) ? "'Firewall' va primero" : "Son iguales";
    Console.WriteLine("Reto 22 Compare('Bitín','Firewall'): " + res22);
    leer.WriteLine("Reto 22 Compare('Bitín','Firewall'): " + res22);
    leer.WriteLine();
    

    // reto 23 CompareTo(): aplica compareto entre nube y cielo y explica el resultado numerico
    int cmpTo = "Nube".CompareTo("Cielo");
    string exp23 = (cmpTo < 0) ? "‘Nube’ viene antes que ‘Cielo’"
                 : (cmpTo > 0) ? "‘Nube’ viene después de ‘Cielo’"
                               : "Son iguales";
    Console.WriteLine("Reto 23 CompareTo('Nube','Cielo'): " + cmpTo + ": " + exp23);
    leer.WriteLine("Reto 23 CompareTo('Nube','Cielo'): " + cmpTo + ": " + exp23);
    leer.WriteLine();

    // reto 24 IsNullOrEmpty(): declara una cadena vacia y verifica
    string res24 = string.Empty;
    Console.WriteLine("Reto 24 IsNullOrEmpty(\"\"): " + (string.IsNullOrEmpty(res24) ? "Es nula o vacía" : "No"));
    leer.WriteLine("Reto 24 IsNullOrEmpty(\"\"): " + (string.IsNullOrEmpty(res24) ? "Es nula o vacía" : "No"));
    leer.WriteLine();

    // reto 25 IsNullOrWhiteSpace(): declara una cadena con espacios y valida
    string res25 = "    ";
    Console.WriteLine("Reto 25 IsNullOrWhiteSpace(\"    \"): " + (string.IsNullOrWhiteSpace(res25) ? "Solo espacios" : "No"));
    leer.WriteLine("Reto 25 IsNullOrWhiteSpace(\"    \"): " + (string.IsNullOrWhiteSpace(res25) ? "Solo espacios" : "No"));
    leer.WriteLine();

    // reto 26 ToLower() convierte el cuento en minúsculas 
    string res26 = cuento.ToLower();
    Console.WriteLine("Reto 26 ToLower(): " + res26);
    leer.WriteLine("Reto 26 ToLower(): " + res26);
    leer.WriteLine();

    // reto 27 ToUpper() convierte el cuento en mayúsculas 
    string res27 = cuento.ToUpper();
    Console.WriteLine("Reto 27 ToUpper(): " + res27);
    leer.WriteLine("Reto 27 ToUpper(): " + res27);
    leer.WriteLine();

    // reto 28  convierte la palabra nube a minuscula ToLowerInvariant()
    string res28 = "NUBE".ToLowerInvariant();
    Console.WriteLine("Reto 28 ToLowerInvariant('NUBE'): " + res28);
    leer.WriteLine("Reto 28 ToLowerInvariant('NUBE'): " + res28);
    leer.WriteLine();

    // reto 29 convierte la palabra bitin en mayusculas  ToUpperInvariant()
    string res29 = "bitín".ToUpperInvariant();
    Console.WriteLine("Reto 29 ToUpperInvariant('bitín'): " + res29);
    leer.WriteLine("Reto 29 ToUpperInvariant('bitín'): " + res29);
    leer.WriteLine();


}



