# Divide y Venceras
# Algoritmos de Busqueda y Ordenacion

## Descripción

Este repositorio contiene implementaciones de dos algoritmos fundamentales: **Búsqueda Binaria** y **Merge Sort**. Ambos algoritmos son ejemplos de técnicas de **divide y venceras**, donde un problema se resuelve dividiendolo en subproblemas más pequeños.

### Algoritmos Incluidos

1. **Búsqueda Binaria**: Un algoritmo eficiente para encontrar un elemento en un array ordenado.
   - **Archivo**: `BinarySearcher.cs`
   - **Descripción**: Este algoritmo divide repetidamente el array en mitades, reduciendo el espacio de búsqueda hasta encontrar el elemento objetivo o determinar que no está presente.

2. **Merge Sort**: Un algoritmo de ordenación eficiente que utiliza el enfoque de divide y vencerás.
   - **Archivo**: `MergeSort.cs`
   - **Descripción**: Este algoritmo divide un array en dos mitades, ordena cada mitad y luego combina las dos mitades ordenadas en un solo array ordenado.

## Búsqueda Binaria

### Cómo Funciona

- Se recibe un array ordenado y un elemento objetivo (`target`).
- Se utiliza un bucle para ajustar los índices `left` y `right` hasta encontrar el elemento o determinar que no está presente.
- Se devuelve el índice del elemento encontrado o -1 si no se encuentra.

### Ejemplo de Uso

```csharp
int[] array = { 1, 3, 4, 5, 7, 20, 38, 47, 59, 210 };
int result = BinarySearch(array, 4);
