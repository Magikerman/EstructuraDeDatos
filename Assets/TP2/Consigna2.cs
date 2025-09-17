
public class Consigna2
{
    /*
    Ejercicio 02: MyLinkedList<T>
• Crear una implementación propia del TDA List llamada MyLinkedList<T>.Para el resto
de las entregas, queda prohibido usar List<T> o LinkedList<T> incluidas en C#.
• MyLinkedList<T> será similar funcionamiento interno a LinkedList<T>.
• Deberá ser doblemente enlazada.
• Deberá tener un nodo (clase propia MyNode<T>) root y otro tail.
• Cada MyNode<T> contendrá un dato, el siguiente nodo y el anterior nodo.
• Está prohibido (esta clase y las clases que la componen) conozcan cualquier
dato o objeto de UnityEngine.
• MyLinkedList<T> debe tener por lo menos los siguientes elementos:
• Campos:
o private MyNode<T> root;
    o private MyNode<T> tail;
• Funciones
o public void Add(T value)
o public void AddRange(MyLinkedList<T> values)
o public void AddRange(T[] values)
o public bool Remove(T value)
o public void RemoveAt(int index)
o public void Insert(int index, T value)
o public bool IsEmpty()
o public void Clear()
o public override string ToString()
• Propiedades:
o public int Count { get; private set; }
    o public T this[int index]
● MyNode<T> debe tener por lo menos:
o El dato
    o Conocer el anterior y próximo nodo.
o Su constructor.
o public override string ToString() y public bool IsEquals(T value)
Ejercicio 03: Tienda:
• Contenido:
o Desarrolla una tienda de un juego utilizando la UI de Unity.
o El jugador debe poder comprar y vender diferentes ítems haciendo click en
ellos o de la manera que el grupo decida.
o Debe ser útil e intuitivo.
o El jugador debe tener dinero disponible para poder comprar, la cual se debe
indicar en la pantalla.
o Cada botón del panel debe indicar el nombre, precio y sprite de su item.
o Los objetos de la tienda se deben poder ordenar por las variables que
componen al ítem: ID, nombre, precio, rareza, tipo, etc.
• Detalles:
o Item es nuestra clase para los objetos del juego. La cual posee ID, nombre,
precio (se pueden agregar más).
o La tienda(“Store”) debe tener los ítems en un diccionario en donde la Key
sea el ID del objeto, y el Valor el Item.
o Cuando el jugador compra un Item, éste los almacena también en un
diccionario propio del jugador (El cual debe también poseer cantidad).
o Deberá justificar oralmente cada integrante los KeyValuePair del Store y del
inventario del jugador.*/
}
