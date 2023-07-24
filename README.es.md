

# Tutorial detallado de XAF WinForms & Web Forms (demostración principal)


Siga este tutorial para crear una aplicación simple utilizada para almacenar contactos y otros objetos relacionados a medida que aprende sobre los fundamentos de  **eXpressApp Framework**.

## Dependencias y requisitos previos

Antes de comenzar el tutorial, lea esta sección y asegúrese de que se cumplen las siguientes condiciones:

1.  Cualquier  [versión  de](https://www.devexpress.com/support/versions.xml)  [Visual Studio](https://visualstudio.microsoft.com/) que no sea compatible con Express se instala en el equipo. Tiene experiencia básica en el desarrollo de .NET Framework en este IDE.
2.  Una versión de  [prueba  gratuita de 30 días](https://www.devexpress.com/products/try/)  o una versión con licencia de  [DevExpress Universal Subscription](https://www.devexpress.com/Subscriptions/Universal.xml) está instalada en su equipo.
3.  Tiene conocimientos básicos de los conceptos de  [asignación relacional de objetos (ORM)](https://en.wikipedia.org/wiki/Object-relational_mapping) y  [DevExpress XPO](https://www.devexpress.com/products/net/orm/).
4.  Cualquier  [RDBMS](https://en.wikipedia.org/wiki/Relational_database_management_system) compatible con la herramienta ORM XPO (consulte  [Sistemas de bases de datos compatibles con XPO)](https://docs.devexpress.com/XPO/2114/product-information/database-systems-supported-by-xpo?v=22.1)  se instala y se puede acceder a ella desde el equipo para almacenar los datos de la aplicación (se recomienda una instancia de LocalDB o SQL Server Express).
5.  Está familiarizado con la  [arquitectura de aplicaciones XAF](https://docs.devexpress.com/eXpressAppFramework/112559/overview/architecture?v=22.1).

## Estructura del tutorial

El tutorial consta de las siguientes secciones.

-   [Diseño de Modelo de Negocio](https://docs.devexpress.com/eXpressAppFramework/112730/getting-started/in-depth-tutorial-winforms-webforms/business-model-design?v=22.1)
    
    En esta sección se describe el uso de la herramienta de mapeo relacional de objetos (ORM) de  [objetos eXpress Persistent Objects (XPO](https://www.devexpress.com/Products/NET/ORM/) [](https://en.wikipedia.org/wiki/Object-relational_mapping)). Implementará clases que formarán el modelo de negocio (que define las tablas de base de datos) de la aplicación. Como resultado de completar esta sección, terminará con dos interfaces generadas automáticamente basadas en el mismo modelo de negocio: una aplicación WinForms y un sitio web. Además, estas aplicaciones contendrán un conjunto de características que forman la funcionalidad de la aplicación base.
    
    ![Main_Demo_BMD](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_bmd117570.png?v=22.1)
    
-   [Amplíe la funcionalidad](https://docs.devexpress.com/eXpressAppFramework/112740/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality?v=22.1)
    
    En esta sección, agregará características personalizadas a la aplicación creada en la sección anterior.
    
    ![Main_Demo_Extend](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_extend117574.png?v=22.1)
    
-   [Personalización de la interfaz de usuario](https://docs.devexpress.com/eXpressAppFramework/112748/getting-started/in-depth-tutorial-winforms-webforms/ui-customization?v=22.1)
    
    Esta sección le enseñará cómo personalizar fácilmente la interfaz de usuario generada automáticamente de una aplicación.
    
    ![Main_Demo_UI](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_ui117575.png?v=22.1)
    
-   [Módulos adicionales](https://docs.devexpress.com/eXpressAppFramework/112770/getting-started/in-depth-tutorial-winforms-webforms/extra-modules?v=22.1)
    
    En esta sección, agregará características adicionales suministradas con XAF (archivo adjunto, análisis de datos, generación de informes, etc.).
    
    ![Main_Demo_Modules](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_modules117572.png?v=22.1)
    
-   [Sistema de seguridad](https://docs.devexpress.com/eXpressAppFramework/112771/getting-started/in-depth-tutorial-winforms-webforms/security-system?v=22.1)
    
    Utilice esta sección para aprender a proteger la aplicación añadiéndole el sistema de seguridad XAF.
    
    ![Main_Demo_Sec](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_sec117573.png?v=22.1)
    

Cada sección consta de una serie de lecciones. Cada lección proporciona los pasos necesarios para implementar la funcionalidad mencionada en el título de la lección. Estos pasos incluyen las instrucciones exactas y también pueden incluir fragmentos de código (en C# y VB) e imágenes.

La aplicación final creada como resultado de este tutorial se incluye en la instalación de XAF. Esta aplicación está diseñada para demostrar una amplia variedad de características para implementar tareas en aplicaciones XAF.

## Cadena de conexión

Comience por asegurarse de que tiene instalado un sistema de administración de bases de datos (DBMS) de  **Microsoft SQL Server**. Si utiliza un DBMS diferente, deberá proporcionar las cadenas de conexión adecuadas.

Use el  [Asistente para soluciones](https://docs.devexpress.com/eXpressAppFramework/113624/installation-upgrade-version-history/visual-studio-integration/solution-wizard?v=22.1)  para crear una solución. El asistente intenta detectar el servidor SQL Server instalado y cambia la cadena de conexión en consecuencia. Los servidores compatibles son  **Microsoft SQL Server**  (incluidas las ediciones  **Express**  y  **LocalDB**). Para utilizar otro sistema de base de datos (PostgreSQL, MySQL, Oracle, SQLite, Firebird, etc.), cambie el argumento  **ConnectionString**  en los archivos  _App.config y Web.config_  de los proyectos de aplicación de formularios Web Forms WinForms/ASP.NET_._  Consulte el tema  [Conectar una aplicación XAF a un proveedor de](https://docs.devexpress.com/eXpressAppFramework/113155/business-model-design-orm/connect-an-xaf-application-to-a-database-provider?v=22.1)  bases de datos para obtener más información sobre cómo conectarse a diferentes sistemas de bases de datos. Se creará una base de datos en el servidor con el nombre de la solución que ha creado. Si desea cambiar alguno de estos detalles, deberá realizar los cambios necesarios en la cadena de conexión mediante el archivo de configuración de la aplicación (_App.config_  o  _Web.config_) o mediante el  [Diseñador de aplicaciones](https://docs.devexpress.com/eXpressAppFramework/112827/installation-upgrade-version-history/visual-studio-integration/application-designer?v=22.1). Consulte el tema  [Conectar una aplicación XAF a un proveedor de base de datos](https://docs.devexpress.com/eXpressAppFramework/113155/business-model-design-orm/connect-an-xaf-application-to-a-database-provider?v=22.1)  para obtener información adicional sobre las cadenas de conexión.

Si alguna vez necesita volver a crear su base de datos, simplemente suéltela del servidor de bases de datos o elimine el archivo, y se volverá a crear automáticamente la próxima vez que se ejecute la aplicación.

