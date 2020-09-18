# Refactoring Serie - Fizz Buzz

# Links
[Refactoring Origen](https://github.com/SoftwareDojo/Refactorings)
[Kata Description](https://codingdojo.org/kata/FizzBuzz/)

# Descripción del problema

Imagínate la escena. Tienes once años, y en los cinco minutos antes del final de la lección, tu profesor de Matemáticas decide que debe hacer su clase más "divertida" al introducir un "juego". Explica que va a apuntar a cada alumno a su vez y pedirles que digan el siguiente número en secuencia, empezando por uno. La parte "divertida" es que si el número es divisible por tres, en su lugar se dice "Fizz" y si es divisible por cinco se dice "Buzz". Así que ahora su profesor de matemáticas está apuntando a todos sus compañeros de clase a su vez, y felizmente gritan "uno!", "¡dos!", "¡Fizz!", "¡cuatro!", "¡Buzz!" ... hasta que él deliberadamente te señala, arregléndote con una mirada acerda... el tiempo se detiene, tu boca se seca, tus palmas se vuelven más sudorosas y sudorosas hasta que finalmente logras croak "Fizz!". Se evita la perdición, y el dedo señalador se mueve.

Así que, por supuesto, con el fin de evitar la verguenza en frente de toda su clase, usted tiene que obtener la lista completa impresa para que sepa qué decir. Su clase tiene alrededor de 33 alumnos y podría dar la vuelta tres veces antes de que suene la campana para el descanso. La próxima lección de matemáticas es el jueves. ¡Consigan codificación!

Escriba un programa que imprima los números del 1 al 100. Pero para múltiplos de tres imprimir "Fizz" en lugar del número y para los múltiplos de cinco imprimir "Buzz". Para los números que son múltiplos de tres y cinco imprimir "FizzBuzz".

```sh
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
16
17
Fizz
19
Buzz
... etc up to 100
```

# Etapa 2 - nuevos requisitos

```sh
 * A number is fizz if it is divisible by 3 or if it has a 3 in it
 * A number is buzz if it is divisible by 5 or if it has a 5 in it
```

