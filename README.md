SEM5 - Tarea: Asignación No. 5 Aplicación de Encapsulamiento y Abstracción

Continuando con la actividad realizada en entorno Visual Studio 2022, y especificamente en lenguaje C#.
Esta asignación consiste en aplicar los principios de encapsulamiento y abstracción en un sistema de compras simplificado, compuesto por las clases Producto, Usuario y Carrito. Además, se introduce una jerarquía abstracta mediante la clase base Item, de la cual derivan ProductoFisico y ProductoDigital, representando distintos tipos de productos.

Encapsulamiento Aplicado
Clases modificadas:
Producto
Atributos privados: id, nombre, descripcion, precio, stock. Accesores públicos con validaciones: precio y stock no pueden ser negativos. Nombre no puede estar vacío. como se aprecia en las imágenes
![image](https://github.com/user-attachments/assets/a5fc8355-76b0-4ce1-bd8a-8b1be8041c4d)









Usuario
Atributos privados: id, nombre, correo, contrasena.

Validaciones:

correo validado mediante expresión regular.

contrasena debe tener al menos 6 caracteres.

Carrito
Atributo Productos encapsulado con propiedad private set.

Métodos públicos para agregar productos (por objeto, por ID simulado, por nombre y precio).

Cálculo del Total encapsulado a través de una propiedad readonly.

🧱 Abstracción Aplicada
🔸 Clase base abstracta: Item
Define propiedades comunes: Id, Nombre, Precio.

Constructor protegido con validaciones.

Método abstracto: MostrarDetalle().

🔹 Clases derivadas:
ProductoFisico
Propiedades adicionales: Descripcion, Stock.

Implementa MostrarDetalle() con detalles de stock.

ProductoDigital
Propiedad adicional: UrlDescarga.

Implementa MostrarDetalle() con detalles de descarga.


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



