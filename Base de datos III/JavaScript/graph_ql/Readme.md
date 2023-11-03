# Proyecto GraphQL con Node.js
¡Bienvenido a mi proyecto GraphQL con Node.js!
## Descripción

Este proyecto utiliza GraphQL, un lenguaje de consulta para las APIs, y Node.js, un entorno de ejecución de JavaScript del lado del servidor. Con GraphQL, podemos crear APIs flexibles y eficientes que permiten a los clientes solicitar exactamente los datos que necesitan. Node.js nos proporciona un entorno de desarrollo versátil y de alto rendimiento para ejecutar nuestro servidor GraphQL.

## Tecnologías Utilizadas

- **Apollo Server**: Apollo Server es una plataforma de servidor GraphQL de código abierto que se integra fácilmente con cualquier stack. Ofrece una forma sencilla de crear una API GraphQL y administrar las solicitudes del cliente.

- **Bcrypt (v5.1.1) y Bcryptjs (v2.4.3)**: Estas bibliotecas se utilizan para el cifrado de contraseñas. Bcrypt y Bcryptjs son herramientas robustas y seguras para proteger las contraseñas de los usuarios.

- **Dotenv**: Dotenv carga variables de entorno desde un archivo `.env`, lo que facilita la gestión de configuraciones sensibles como las claves de API y las credenciales de base de datos.

- **Jsonwebtoken**: Jsonwebtoken se utiliza para generar y verificar tokens JWT (JSON Web Tokens). Estos tokens son esenciales para la autenticación y autorización en aplicaciones web y móviles.

- **Mongoose**: Mongoose es una biblioteca de modelado de objetos MongoDB para Node.js. Facilita la interacción con bases de datos MongoDB y simplifica la manipulación de datos.

- **Nodemon**: Nodemon es una herramienta que ayuda a desarrollar aplicaciones basadas en Node.js al reiniciar automáticamente la aplicación cuando se detectan cambios en los archivos del proyecto.

## Instalación

1. **Clona el Repositorio**: 
   ```bash
   git clone https://github.com/tu-usuario/graph_ql.git
   ```

2. **Instala las Dependencias**:
   ```bash
   cd graph_ql
   npm install
   ```

3. **Configura las Variables de Entorno**:
   Crea un archivo `.env` en el directorio raíz y configura las variables de entorno necesarias, como la cadena de conexión a la base de datos y las claves secretas.

4. **Ejecuta la Aplicación en Modo de Desarrollo**:
   ```bash
   npm run dev
   ```

¡La aplicación estará en funcionamiento en `http://localhost:3000`!

## Scripts Disponibles

- **`npm run dev`**: Inicia la aplicación en modo de desarrollo utilizando Nodemon para reiniciar automáticamente en caso de cambios.
