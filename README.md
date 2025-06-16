SEM8 - Tarea: Asignación No. 8 Implementación de Manejo de Excepciones y Pruebas Unitarias

Continuando con la actividad realizada en entorno Visual Studio 2022, y especificamente en lenguaje C#.
Esta asignación consiste en la Implementación de Manejo de Excepciones y Pruebas Unitarias de un sistema e-Commerce:

1) - En esta solución se implementaron excepciones personalizadas para capturar y manejar errores específicos del dominio de la plataforma e-Commerce. Estas excepciones mejoran la claridad y el control del flujo del programa, facilitando la detección de fallos previsibles.

Excepciones implementadas:
ProductoNoDisponibleException: Se lanza cuando se intenta acceder o utilizar un producto que no está disponible.

PagoFallidoException: Se utiliza para indicar que ha ocurrido un error durante el procesamiento del pago.

UsuarioNoAutenticadoException: Se lanza si un usuario intenta realizar una acción restringida sin estar autenticado correctamente.

Estas excepciones heredan de la clase base Exception y permiten centralizar el tratamiento de errores, hacer más robusta la lógica de negocio y mejorar el mantenimiento del sistema como se verá en las siguientes imágenes

ProductoNoDisponibleException
![image](https://github.com/user-attachments/assets/b107f0bf-a30d-44ec-8b76-3bd82eb53166)

PagoFallidoException
![image](https://github.com/user-attachments/assets/84e1f515-7bcd-40d1-b2c0-974d6af86c3f)

UsuarioNoAutenticadoException
![image](https://github.com/user-attachments/assets/f032e7d0-de76-4d1c-920e-007826da466d)

Y la excepción "ProductoNoDisponibleException" se implementa en la siguiente clase "GestorProductos.cs" como se aprecia en la siguiente imagen

![image](https://github.com/user-attachments/assets/5ae15c9e-ceda-4a32-926f-2b6416629d42)

Y la excepción "UsuarioNoAutenticadoException" se implementa en la siguiente clase "Carrito.cs" como se aprecia en la siguiente imagen

![image](https://github.com/user-attachments/assets/e0ff679a-85d9-4f63-8096-a83fc5027ebb)

Y la excepción "PagoFallidoException" se implementa en la siguiente clase "PagoTargeta.cs" como se aprecia en la siguiente imagen

![image](https://github.com/user-attachments/assets/ecea20bf-fd70-4fd0-bc8c-bce9ba5fecca)


2) - Pruebas Unitarias con NUnit
  
Se desarrolló un conjunto de pruebas unitarias utilizando el framework NUnit para garantizar el correcto funcionamiento de las clases principales (Producto, Usuario, y Carrito) del dominio, especialmente en lo relacionado con validaciones y el manejo de errores. 

Características de las pruebas:
Se creó un proyecto de pruebas independiente: Services.Tests.

Las pruebas cubren constructores, validaciones y lógica interna de las clases Producto, Usuario y Carrito.

Se validan casos como:

Creación válida e inválida de objetos.

Excepciones esperadas ante datos incorrectos.

Comportamiento ante usuarios no autenticados.

Se organizó cada conjunto de pruebas en archivos separados (ProductoTests.cs, UsuarioTests.cs, CarritoTests.cs, etc.), siguiendo buenas prácticas de mantenimiento.
Resultado: Se ejecutaron 14 pruebas unitarias con 100% de éxito, lo que garantiza que los componentes críticos de la lógica de negocio funcionan correctamente ante diferentes escenarios.
A continuación se evidencian las pruebas mencionadas anteriormente

Se ejecuta las pruebas utilizando el framework NUnit de la clase "ProductoTest" y se evidencia que todas fueron corretas como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/2d619d55-b9d9-4bca-addf-8f2f330d67fe)


Se ejecuta las pruebas utilizando el framework NUnit de la clase "UsuarioTest" y se evidencia que todas fueron corretas como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/6f95e7c9-6035-4dcb-a600-1798498caede)


Se ejecuta las pruebas utilizando el framework NUnit de la clase "CarritoTest" y se evidencia que todas fueron corretas como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/2ad44514-965d-4b0b-9e14-1d0545e9e593)

Con esto concluye la actividad SEM8 - Tarea: Asignación No. 8 Implementación de Manejo de Excepciones y Pruebas Unitarias cumpliendo con los requerimientos solicitados en la actividad.





----------------------------------------------------------------------------------------------------------------------------------------------------------


Asignación No. 7 Implementación de Patrones de Diseño Singleton, Factory, y Observer

Continuando con la actividad realizada en entorno Visual Studio 2022, y especificamente en lenguaje C#.
Esta asignación consiste implementar tres patrones de diseño en el contexto de un sistema e-Commerce:

Singleton → Para una clase de gestión central, como un gestor de configuración del sistema.

Factory → Para crear distintos tipos de productos o usuarios, simplificando su creación según datos de entrada.

Observer → Para manejar eventos como cambios en el estado de pedidos o actualizaciones del inventario.

A continuación Vamos a ver el detalle de cada uno de estos patrones

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

Se crea la clase "FabricaEntidades" como se aprecia en la imagen 
Responsabilidad Única: cada método se encarga de una familia de objetos (productos o usuarios).

Extensibilidad: agregar nuevos tipos solo requiere extender el enum y el switch.

![image](https://github.com/user-attachments/assets/3e6eac6e-0e9c-4a30-a43e-ffca169ddbd5)

Beneficios del patrón Fáctory
El patrón Factory centraliza la lógica de creación de objetos.
Promueve la mantenibilidad, testabilidad y extensibilidad del sistema.
Compatible con principios SOLID y la estructura de Clean Architecture aplicada en el proyecto.

3- Patrón Observer

El propósito sería implementar un mecanismo de suscripción y notificación desacoplado para que distintos componentes del sistema (como la interfaz de usuario o el módulo de inventario) puedan reaccionar automáticamente a eventos como cambios en el estado de un pedido sin acoplarse directamente entre ellos como se vera a continuación

Se crea la interfaz IObservador y la interfaz "ISujeto" como se observa en las imágenes

![image](https://github.com/user-attachments/assets/f5f24ec9-85b8-429b-874f-8ad91552b80b)

![image](https://github.com/user-attachments/assets/7333bd5c-5bc5-42df-9d8d-0c795aa87215)


Sujeto concreto: Gestor de pedidos, en esta clase se implementa la interfaz "ISujeto"

![image](https://github.com/user-attachments/assets/72e8cac7-cbe6-4301-840c-983adcf95206)

Observadores concretos

![image](https://github.com/user-attachments/assets/e3d9012f-4b7d-4d95-9ce2-23fca8bb6f96)

![image](https://github.com/user-attachments/assets/9f81584f-59ec-4115-8522-d14aabfddb9f)

Y para efectos de prueba, se realiza el ejercicio de la siguiente manera como se verá a continuación:
En la clase "program.cs" de la Capa de "Services-API" como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/ab52289d-190d-4d12-a93a-40b82578ac63)

Se ejecuta la aplicación presionando "F5" o dando "Click" al botón que se ve en la siguiente imagen, en la aprte superior 

![image](https://github.com/user-attachments/assets/9b10d11f-ff4b-4759-8fe3-3bdcc9913c8f)


Se prueba con un cliente llamado "POSMAN" conocido por todos, y se expone el EndPoint que se ve en la imagen, elcual es "https://localhost:7174/test/observer", el método que utiliza en un "GET", y al presionar el botón de "Send" que está en la parte superior derecha, vemos que se obtiene un mensaje el cual dice "Se ejecutó la prueba del patrón Observer. Revisa la salida de la consola.". Ahora para ver si realmente se ejecutó con exito la prueba hay que revisar la consola de Visual Studio 2022 como lo dice el mensaje de salida en posman

![image](https://github.com/user-attachments/assets/6cb49fa2-6e09-4525-8f5c-779fc864f6c4)

Y al revisar la consola se evidencia que se ejecuto exitosamente y significa que el patrón Observer está funcionando correctamente como se esperaba

![image](https://github.com/user-attachments/assets/fc1cc311-9595-44bc-a7a6-d74b50ea4c35)



Con esto concluye la actividad Asignación No. 7 Implementación de Patrones de Diseño Singleton, Factory, y Observer manteniendo una arquitectura limpia y desacoplada










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



