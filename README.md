# Instrucciones de la Kata
# Paso 1: Calculadora sencilla
Cree una calculadora de cadenas simple con un solo método:

class StringCalculator {
    int Add(string numbers);
}

El método puede tomar 1 o 2 números separados por comas y devolverá su suma.
El método devuelve 0 cuando se pasa la cadena vacía.

Ejemplo:

Add("") // 0
Add("4") // 4
Add("1,2") // 3
Comience con el caso de prueba más simple de una cadena vacía y pase a 1 y dos números.

# Paso 2: tamaño de número arbitrario
Permita que el método Agregar maneje una cantidad desconocida de números.

Ejemplo:

Add("1,2,3,4,5,6,7,8,9") // 45

# Paso 3: separador de nueva línea
Permita que el método Agregar reconozca nuevas líneas y comas como separadores. Los dos tipos de separadores se pueden utilizar indistintamente.

Concéntrese en el camino feliz: dado que este no es un código de producción, está bien si el código falla si se le proporciona una entrada no válida (por ejemplo ). "1,\n2"

Ejemplo:

Add("1\n2,3") // 6

# Paso 4: Separadores personalizados
Opcionalmente admite separadores personalizados. Para cambiar el separador, el comienzo de la cadena contendrá una línea separada similar a esta: “//<separator>\n<numbers>”

Ejemplo:

Add("//;\n1;2") // 3
Tenga en cuenta que todos los escenarios existentes aún deberían ser compatibles.

# Paso 5: no permitir negativos
Llamar a Add con un número negativo generará una excepción y el negativo que se pasó. negatives not allowed

Si hay varios negativos, muéstrelos todos en el mensaje de excepción.

Ejemplo:

Add("1,-2,-3") // error: negatives not allowed: -2 -3
Paso 6: ignora los números mayores que 1000
Se deben ignorar los números mayores que 1000.

Ejemplo:

Add("1001, 2") // 2

# Paso 7: Separadores de longitud arbitraria
Los separadores pueden tener cualquier longitud si están entre corchetes.

Ejemplo:

Add("//[***]\n1***2***3") // 6

# Paso 8: múltiples separadores de una sola longitud
Permita múltiples separadores de un solo carácter como este: “//[delim1][delim2]\n”

Ejemplo:

Add("//[*][%]\n1*2%3") // 6

# Paso 9: múltiples separadores de mayor longitud
Maneja múltiples separadores con cualquier longitud de carácter.

Ejemplo:

Add("//[foo][bar]\n1foo2bar3") // 6

link de la kata: https://www.codurance.com/katas/string-calculator

# Base para hacer tests

Configuración básica para empezar a hacer una kata o aprender a hacer tests en los siguientes lenguajes:

- PHP con PHPUnit
- Javascript con Jest
- Typescript con Node
- Typescript con Deno
- Java con Junit y Mockito
- Scala con Munit y Scalacheck
- Kotlin con JUnit5 y MockK
- C# con xUnit (FluentAsertion) y NSubstitute (para mock)
- Go con testing (standard library)

# Configuración específica por lenguaje

## PHP con PHPUnit

1. Instalar [composer](https://getcomposer.org/) `curl -sS https://getcomposer.org/installer | php`
2. `composer install` (estando en la carpeta php)
3. `vendor/bin/phpunit` o `composer test`

### 📚 Documentación
- [PHPUnit](https://phpunit.readthedocs.io/)

## Javascript con Jest

1. Instalar [Node](http://nodejs.org/)
2. `npm install` (Estando en la carpeta javascript)
3. `npm test`

### 📚 Documentación
- [Jest](https://jestjs.io)

## [Typescript con Node](/typescript/README.md)

## Typescript con Deno

1. Instalar [Deno](https://deno.land/#installation)
2. `deno test` (Estando en la carpeta typescript)

### 📚 Documentación
- [Deno](https://deno.land/manual)
- [BDD module](https://deno.land/manual/testing/behavior_driven_development)
- [Expect module](https://deno.land/x/expect)

## Java con Junit y Mockito

1. Instalar las dependencias y tests con Maven [mvn test]
2. Ejecutar los tests con el IDE

### 📚 Documentación
- [JUnit](https://github.com/junit-team/junit/wiki)
- [Mockito](http://site.mockito.org/mockito/docs/current/org/mockito/Mockito.html)

## Scala con Munit y Scalacheck

1. `sbt` (en la carpeta scala)
2. `~test` para ejecutar los test en hot reload

### 📚 Documentación
- [Munit](https://scalameta.org/munit/docs/tests.html)
- [Scalacheck](https://github.com/typelevel/scalacheck/blob/main/doc/UserGuide.md) para testing basado en propiedades

### Linux/Mac
1. Instalar [SDKMan](https://sdkman.io/)
2. `sdk install java 11.0.12-open` instala OpenJDK
3. `sdk install sbt` una vez instalado SDKMan

### Windows
1. Instalar [OpenJDK](https://docs.microsoft.com/es-es/java/openjdk/download#openjdk-110141-lts--see-previous-releases)
2. Instalar [SBT](https://www.scala-sbt.org/download.html)

### Visual Studio Code
1. Descargar [Visual Studio Code](https://code.visualstudio.com/)
2. Instalar para VS Code [Metals](https://scalameta.org/metals/docs/editors/vscode)

## Kotlin con JUnit5 y MockK

1. Por consola: Puedes instalar dependencias y lanzar los tests con `gradlew test`
2. Usando IDE: Simplemente abre el proyecto desde el raiz de la plantilla Kotlin

### 📚 Documentación
- [JUnit5](https://junit.org/junit5/)
- [MockK](https://mockk.io/)

## C# con xUnit (con FluentAsertion) y NSubstitute (para mock)

1. Instalar Microsoft Visual Studio Community 2022
2. Abre el proyecto y se descargaran automáticamente los paquetes Nuguet necesarios

### 📚 Documentación
- [xUnit](https://xunit.net/)
- [NSubstitute](https://nsubstitute.github.io/help.html)
- [FluentAssertions](https://fluentassertions.com/introduction)

## Python

1. Instalar python 3.x
2. Una vez descargado el código fuente dentro de la carpeta */python/ creamos un virtual enviroment:
3. `python3 -m venv env`
4. Activamos en virtual environment:
- windows: `.\env\Scripts\activate.bat`
- linux/mac: `source env/bin/activate`
5. `pytest` para ejecutar los tests.

## Go (Golang) con testing (standard library)

1. Instalar [Go](https://go.dev/dl/)
2. `go test -v` (en la carpeta con el archivo xxx_test.go)
  
### 📚 Documentación
- [Go](https://go.dev/doc/)
- [Testing Package](https://pkg.go.dev/testing)
