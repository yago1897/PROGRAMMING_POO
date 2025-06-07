Asignación No. 7 Implementación de Patrones de Diseño Singleton, Factory, y Observer

Continuando con la actividad realizada en entorno Visual Studio 2022, y especificamente en lenguaje C#.
Esta asignación consiste implementar tres patrones de diseño en el contexto de un sistema e-Commerce:

Singleton → Para una clase de gestión central, como un gestor de configuración del sistema.

Factory → Para crear distintos tipos de productos o usuarios, simplificando su creación según datos de entrada.

Observer → Para manejar eventos como cambios en el estado de pedidos o actualizaciones del inventario.

1- Patrón Singleton
La primera parte consiste en implementar una clase ConfiguracionSistema con el patrón Singleton, lo que implica:

Constructor privado para evitar instanciación directa. Una propiedad estática (Instance) que controle la única instancia disponible. Una inicialización segura y perezosa (lazy) para crear la instancia solo cuando sea necesaria.

Esta clase contendrá configuraciones clave del sistema como: Cadena de conexión a la base de datos.Configuración de UI (idioma, tema).Parámetros generales del sistema e-Commerce, como se aprecia en lam siguiente imagen

![image](https://github.com/user-attachments/assets/5da32a42-c75a-4ac0-914c-30dbc881ceab)

Y en la siguiente imagen vemos un ejemplo de como se usa, se crea una clase llamada "ServicioAutenticacion" donde tiene un método llamado "IniciarSesion" donde se accede a la única instancia. La ventaja de usarlo así es que la configuración n o se pasan entre clases, simplemente se accede desde ConfiguracionSistema.Instancia. Siempre se usa la misma instancia en todo el sistema.

En conclusión la instancia es compartida globalmente, por lo que cualquier cambio se refleja en todo el sistema.

![image](https://github.com/user-attachments/assets/d2558154-3fab-4684-a427-919d6d2e7062)

2- Patrón Fáctory 
Se implementa una clase FabricaEntidades que actúa como fábrica de objetos para centralizar la creación de instancias de productos (ProductoDigital, ProductoFisico) y usuarios (Cliente, Administrador), manteniendo así el principio de abierto/cerrado (OCP) y facilitando la extensión del sistema con nuevos tipos de entidades sin modificar código existente.
Se sigue usando una arquitectura limpia.
Se mantiene el principio de dependencias unidireccionales: Services.Infrastructure depende de Services.Core, no al revés.
FabricaEntidades se ubica correctamente en la capa de Services.Infrastructure, donde tiene visibilidad directa de las implementaciones concretas.

Se crea la clase "FabricaEntidades"
Responsabilidad Única: cada método se encarga de una familia de objetos (productos o usuarios).

Extensibilidad: agregar nuevos tipos solo requiere extender el enum y el switch.

![image](https://github.com/user-attachments/assets/3e6eac6e-0e9c-4a30-a43e-ffca169ddbd5)






----------------------------------------------------------------------------------------------------------------------------------------------------------
SEM6 - Tarea: Asignación No. 6 Implementación de Interfaces y Clases Abstractas

Continuando con la actividad realizada en entorno Visual Studio 2022, y especificamente en lenguaje C#.
Esta asignación consiste en aplicar los principios de **abstracción** e **interfaces** en un sistema de gestión de inventario, donde se define una clase abstracta `GestorInventario` con operaciones generales para la administración de productos, y una interfaz `IProductoBase` que actúa como contrato base para las propiedades de un producto.



Se sigue aplicando una arquitectura limpia en capas, respetando las dependencias unidireccionales:  
`Services.Core`  `Services.Infrastructure`.

## Estructura de Capas

- **`Services.Core`**: Contiene clases abstractas e interfaces que definen los contratos generales del dominio.
- **`Services.Infrastructure`**: Implementa las clases concretas de los servicios, como la gestión física del inventario.

---

## Interfaces y Clases Abstractas

### Interfaz: `IProductoBase`
Ubicación: `Services.Core.Clases_abstractas`

Define las propiedades base de un producto:

### csharp
public interface IProductoBase
{
    int Id { get; set; }
    string Nombre { get; set; }
    string Descripcion { get; set; }
    decimal Precio { get; set; }
    int Stock { get; set; }
}

Clase abstracta: GestorInventario
Ubicación: Services.Core.Clases_abstractas

Define operaciones generales de inventario, usando la interfaz IProductoBase: como se aprecia en la siguiente imagen

![image](https://github.com/user-attachments/assets/0924c992-a54a-48f3-bbc1-5835566192d7)

Clases Implementadas
Clase: Producto
Ubicación: Services.Infrastructure.Entidades

Implementa la interfaz IProductoBase y aplica encapsulamiento y validaciones: como se ve en la siguiente imagen

![image](https://github.com/user-attachments/assets/4136991a-5aaa-4b10-8f72-645c465a4fb5)

Clase: InventarioFisico
Ubicación: Services.Infrastructure.Services

Implementa la lógica del inventario sobre la clase Producto, usando la clase abstracta GestorInventario: como se aprecia en la siguiente imagen

![image](https://github.com/user-attachments/assets/83fc7fdf-0c68-4322-82df-5d36821b1a4c)


Clase: InventarioDigital
Ubicación: Services.Infrastructure.Services

Implementa la lógica del inventario sobre la clase Producto, usando la clase abstracta GestorInventario: como se ve en la siguiente imagen

![image](https://github.com/user-attachments/assets/47546d24-d807-4f6d-8550-9f7d7288c3d3)

Uso de Interfaces para Procesos de Pago.

En esta parte del proyecto, aplicamos el principio de abstracción mediante la creación de una interfaz que representa el comportamiento común de diferentes formas de pago. Este enfoque permite una arquitectura extensible y desacoplada.

 Interfaz IProcesoPago
 Define el contrato para cualquier forma de pago en el sistema.
 Expone un único método: ProcesarPago, que acepta un monto a pagar. Como se aprecia en la imagen.
 
 ![image](https://github.com/user-attachments/assets/3d4f7c9e-9d5b-4b8e-8c5b-67947fce2765)

 Clase PagoTarjeta.
 Implementa IProcesoPago.
 Simula el procesamiento de un pago mediante tarjeta de crédito. Como se aprecia en la imagen.

 ![image](https://github.com/user-attachments/assets/2df4fe5c-47f5-428e-a3b9-93625dffaf5e)

 Clase PagoPayPal
 También implementa IProcesoPago.
 Simula el procesamiento de un pago utilizando PayPal. Como se ve en la imagen.

 ![image](https://github.com/user-attachments/assets/79ed7d68-849a-4476-830e-41917852b4aa)
 
Ventajas del diseño
Extensibilidad: Agregar nuevos métodos de pago (como PagoEfectivo o PagoCripto) solo requiere crear una nueva clase que implemente IProcesoPago.

Polimorfismo: Permite trabajar con cualquier implementación sin necesidad de conocer su tipo exacto.

Desacoplamiento: Reduce dependencias entre componentes de alto y bajo nivel (principio de inversión de dependencias, SOLID).
 

Con esto concluye la actividad SEM6 - Tarea: Asignación No. 6 Implementación de Interfaces y Clases Abstractas

---------------------------------------------------------------------------------------------------------------------------------------------------

 








SEM5 - Tarea: Asignación No. 5 Aplicación de Encapsulamiento y Abstracción

Continuando con la actividad realizada en entorno Visual Studio 2022, y especificamente en lenguaje C#.
Esta asignación consiste en aplicar los principios de encapsulamiento y abstracción en un sistema de compras simplificado, compuesto por las clases Producto, Usuario y Carrito. Además, se introduce una jerarquía abstracta mediante la clase base Item, de la cual derivan ProductoFisico y ProductoDigital, representando distintos tipos de productos.

Encapsulamiento Aplicado
Clases modificadas:
Clase Producto
Atributos privados: id, nombre, descripcion, precio, stock. Accesores públicos con validaciones: precio y stock no pueden ser negativos. Nombre no puede estar vacío. como se aprecia en las imágenes

![image](https://github.com/user-attachments/assets/a5fc8355-76b0-4ce1-bd8a-8b1be8041c4d)
![image](https://github.com/user-attachments/assets/98419e6f-5a39-4513-aa98-d0f040509072)




Clase Usuario
Atributos privados: id, nombre, correo, contrasena. Validaciones: correo validado mediante expresión regular. Contrasena debe tener al menos 6 caracteres.

![image](https://github.com/user-attachments/assets/69d72dbb-e957-48a4-9cdf-5903f5b97be3)

![image](https://github.com/user-attachments/assets/bdd68876-b182-431b-8789-87137b8fc59b)




Clase Carrito
Atributo Productos encapsulado con propiedad private set. Métodos públicos para agregar productos (por objeto, por ID simulado, por nombre y precio). Cálculo del Total encapsulado a través de una propiedad readonly.

![image](https://github.com/user-attachments/assets/86516b09-8404-4daa-b4e4-f2e62d85d7e1)

![image](https://github.com/user-attachments/assets/5118ed0a-ccf4-499e-8494-4b7b5acc5498)



Abstracción Aplicada
Clase base abstracta: Item
Define propiedades comunes: Id, Nombre, Precio. Constructor protegido con validaciones. Método abstracto: MostrarDetalle().

![image](https://github.com/user-attachments/assets/461c28d8-eb73-483d-a41b-defcac8bb7b5)



Clases derivadas:
ProductoFisico 
Propiedades adicionales: Descripcion, Stock. Implementa MostrarDetalle() con detalles de stock.

![image](https://github.com/user-attachments/assets/38f4ad57-07d4-4bc1-92ab-2b6b63888823)


ProductoDigital
Propiedad adicional: UrlDescarga. Implementa MostrarDetalle() con detalles de descarga.

![image](https://github.com/user-attachments/assets/5dfe818b-9d03-47b4-a20e-ea0622970f28)

Con esto concluye la actividad SEM5 - Tarea: Asignación No. 5 Aplicación de Encapsulamiento y Abstracción

---------------------------------------------------------------------------------------------------------------------------------------------------

SEMANA No. 4 – Pilares de la Programación Orientada a Objetos - Polimorfismo y sobrecarga

Continuando con la actividad realizada en entorno Visual Studio 2022, y especificamente en lenguaje C#.
Suguiendo con los mismos lineamientos que modela los componentes principales de una plataforma e-Commerce, aplicando los principios de la **Programación Orientada a Objetos (POO)** y más especificamente en este caso Polimorfismo, sobrecarga y sobreescritura de métodos en la Plataforma e-Commerce.

### Funcionalidades Implementadas

#### Implementación de Polimorfismo:
Se ha creado la clase `GestorProductos`, la cual permite procesar objetos derivados de la clase base `Producto`. Gracias al polimorfismo, se puede tratar a `ProductoFisico` y `ProductoDigital` como objetos del tipo base y ejecutar métodos sobrescritos de manera dinámica.

A continuación se presentan las imágenes de lo mencionado anteriormente teniendo en cuenta las especificaciones solicitadas en la actividad

Punto 1- ### Implementación de Polimorfismo: Permitir que métodos acepten cualquier objeto que herede de Producto.
Esto permite pasar tanto un Producto, ProductoDigital como ProductoFisico y se invocará la versión adecuada del método MostrarDetalle() si está sobreescrito y como se evidencia en el punto 3 siguiendo el orden de los puntos solicitados de la actividad

![image](https://github.com/user-attachments/assets/6715fb32-6afb-4e81-93c0-0eb2e1510e53)

Punto 2- Sobrecarga de Métodos: 
Permitir múltiples formas de agregar productos al carrito.En este caso por objeto, por ID y por nombre y precio como se solicita en la actividad, y como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/bd01878e-ca76-4e75-ae92-dc930007675f)

Punto 3- Sobreescritura de Métodos:
Modificar el comportamiento de un método base en las clases derivadas.

Clase base: Producto
![image](https://github.com/user-attachments/assets/236f5041-635d-4f7b-9f26-52d5ee9f3c9c)

ProductoDigital:
![image](https://github.com/user-attachments/assets/1b720c7a-0967-4e5c-b451-11348211497c)

ProductoFisico:
![image](https://github.com/user-attachments/assets/efb07a83-c4bc-4679-a53f-27712618defe)

Con esto concluye la actividad SEMANA No. 4 – Pilares de la Programación Orientada a Objetos - Polimorfismo y sobrecarga


##----------------------------------------------------------------------------------------------------------------------------##



SEM3 - Tarea: Asignación No. 3 Extensión de Funcionalidades mediante Herencia

Continuando con la actividad realizada en entorno Visual Studio 2022, y especificamente en lenguaje C#.
Suguiendo con los mismos lineamientos que modela los componentes principales de una plataforma e-Commerce, aplicando los principios de la **Programación Orientada a Objetos (POO)** y más especificamente en este caso la herencia.

Extensión de Funcionalidades (Herencia)
Se aplicó herencia para dividir los productos y usuarios en categorías más especializadas, reflejando diferencias funcionales.
### Productos Especializados

- **ProductoFísico**  
  Hereda de `Producto` e incorpora:
  - `Peso` (decimal)
  - `Dimensiones` (string)

- **ProductoDigital**  
  Hereda de `Producto` e incorpora:
  - `FormatoArchivo` (string)
  - `TamanoMB` (double)

### Usuarios Especializados

- **Cliente**  
  Hereda de `Usuario` y permite:
  - Almacenar historial de compras
  - Registrar preferencias de productos

- **Administrador**  
  Hereda de `Usuario` e incluye:
  - Funcionalidades para gestión de inventario
  - Aplicación de promociones a productos
 
    A continuación se presentan las imágenes de lo mencionado anteriormente
    Clase "ProductoDigital", heredada de la clase "Producto"
    ![image](https://github.com/user-attachments/assets/475b11cf-8dc9-4c26-b5fe-caafc09ec7cc)

    Clase "ProductoFisico", heredada de la clase "Producto"
    ![image](https://github.com/user-attachments/assets/cedd7a4c-5d21-448d-86df-c27b3a7e5979)

    Clase "Administrador", heredada de la clase "Usuario"
    ![image](https://github.com/user-attachments/assets/e197e883-c798-429b-aa72-c0171ae0707f)

    Clase "Cliente", heredada de la clase "Usuario"

    ![image](https://github.com/user-attachments/assets/7f168e55-8705-4ce2-aa71-68d23117d596)

    

    Con esto concluye la SEM3 - Tarea: Asignación No. 3 Extensión de Funcionalidades mediante Herencia

##----------------------------------------------------------------------------------------------------------------------------##

SEM2 - Tarea: Asignación No. 2 Implementación de Clases Básicas para una Plataforma e-Commerce

Este repositorio contiene una implementación de las clases "Producto" "Usuario" y "Carrito" con sus atributos, métodos y contructores solicitados en el requerimiento. Se incluyen las capturas de las clases como se aprecia en las siguientes imágenes.

La tecnología empleada para efectos de práctica es el lenguaje C# de la plataforma .Net-Core versión 8, está realizada en arquitectura de N-Capas, donde las clases mencionadas están en la capa de datos llamada "Services.Infraestructure"

Clase Producto
![image](https://github.com/user-attachments/assets/eaffe95f-7484-4392-a781-afbe29022681)

Clase Usuario
![image](https://github.com/user-attachments/assets/becd3b94-884c-4e22-ad57-fc74b9f51d98)

Clase Carrito
![image](https://github.com/user-attachments/assets/80330eb5-d2f3-400e-8442-ee693ee4ab4f)



