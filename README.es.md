[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/blob/master/README.md)

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
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/095ad99a-5cdf-4255-b268-fad818a6b984)

    
-   [Amplíe la funcionalidad](https://docs.devexpress.com/eXpressAppFramework/112740/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality?v=22.1)
    
    En esta sección, agregará características personalizadas a la aplicación creada en la sección anterior.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c05579e5-b0e6-4724-83d8-6d2c95db87d3)

    
-   [Personalización de la interfaz de usuario](https://docs.devexpress.com/eXpressAppFramework/112748/getting-started/in-depth-tutorial-winforms-webforms/ui-customization?v=22.1)
    
    Esta sección le enseñará cómo personalizar fácilmente la interfaz de usuario generada automáticamente de una aplicación.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c7f98a7c-9ff3-4e85-9be4-c7d20942da7a)

    
-   [Módulos adicionales](https://docs.devexpress.com/eXpressAppFramework/112770/getting-started/in-depth-tutorial-winforms-webforms/extra-modules?v=22.1)
    
    En esta sección, agregará características adicionales suministradas con XAF (archivo adjunto, análisis de datos, generación de informes, etc.).
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6499eacc-7fb3-4c50-99d6-6b4a145b3db7)

    
-   [Sistema de seguridad](https://docs.devexpress.com/eXpressAppFramework/112771/getting-started/in-depth-tutorial-winforms-webforms/security-system?v=22.1)
    
    Utilice esta sección para aprender a proteger la aplicación añadiéndole el sistema de seguridad XAF.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a0d16a52-aa66-40cf-8eea-09dfef278e28)

    

Cada sección consta de una serie de lecciones. Cada lección proporciona los pasos necesarios para implementar la funcionalidad mencionada en el título de la lección. Estos pasos incluyen las instrucciones exactas y también pueden incluir fragmentos de código (en C# y VB) e imágenes.

La aplicación final creada como resultado de este tutorial se incluye en la instalación de XAF. Esta aplicación está diseñada para demostrar una amplia variedad de características para implementar tareas en aplicaciones XAF.

## Cadena de conexión

Comience por asegurarse de que tiene instalado un sistema de administración de bases de datos (DBMS) de  **Microsoft SQL Server**. Si utiliza un DBMS diferente, deberá proporcionar las cadenas de conexión adecuadas.

Use el  [Asistente para soluciones](https://docs.devexpress.com/eXpressAppFramework/113624/installation-upgrade-version-history/visual-studio-integration/solution-wizard?v=22.1)  para crear una solución. El asistente intenta detectar el servidor SQL Server instalado y cambia la cadena de conexión en consecuencia. Los servidores compatibles son  **Microsoft SQL Server**  (incluidas las ediciones  **Express**  y  **LocalDB**). Para utilizar otro sistema de base de datos (PostgreSQL, MySQL, Oracle, SQLite, Firebird, etc.), cambie el argumento  **ConnectionString**  en los archivos  _App.config y Web.config_  de los proyectos de aplicación de formularios Web Forms WinForms/ASP.NET_._  Consulte el tema  [Conectar una aplicación XAF a un proveedor de](https://docs.devexpress.com/eXpressAppFramework/113155/business-model-design-orm/connect-an-xaf-application-to-a-database-provider?v=22.1)  bases de datos para obtener más información sobre cómo conectarse a diferentes sistemas de bases de datos. Se creará una base de datos en el servidor con el nombre de la solución que ha creado. Si desea cambiar alguno de estos detalles, deberá realizar los cambios necesarios en la cadena de conexión mediante el archivo de configuración de la aplicación (_App.config_  o  _Web.config_) o mediante el  [Diseñador de aplicaciones](https://docs.devexpress.com/eXpressAppFramework/112827/installation-upgrade-version-history/visual-studio-integration/application-designer?v=22.1). Consulte el tema  [Conectar una aplicación XAF a un proveedor de base de datos](https://docs.devexpress.com/eXpressAppFramework/113155/business-model-design-orm/connect-an-xaf-application-to-a-database-provider?v=22.1)  para obtener información adicional sobre las cadenas de conexión.

Si alguna vez necesita volver a crear su base de datos, simplemente suéltela del servidor de bases de datos o elimine el archivo, y se volverá a crear automáticamente la próxima vez que se ejecute la aplicación.


# Diseño de Modelo de Negocio

>NOTA
En esta sección se describe el uso de la herramienta de  asignación relacional de objetos  (ORM) de objetos (ORM) de  [objetos deObjetos de Xpress (XPO  ](https://www.devexpress.com/Products/NET/ORM/)[](https://en.wikipedia.org/wiki/Object-relational_mapping) ).

En esta sección, aprenderá cómo diseñar un modelo de negocio (base de datos) al crear aplicaciones empresariales a través de  **eXpressApp Framework**. Creará clases de negocio que se asignarán a tablas de base de datos. También aprenderá a establecer relaciones entre clases, implementar propiedades dependientes, validar valores de propiedad, etc.

Para diseñar un modelo de negocio, se utilizarán las siguientes técnicas.

-   **Usar la biblioteca de clase empresarial**
    
    La  [biblioteca de](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1)  clases empresariales proporciona las clases empresariales más utilizadas, como  **Persona**,  **Evento**,  **Tarea**, etc. Puede utilizar una clase de esta biblioteca tal cual, o heredar de ella para ampliarla.
    
-   **Desde cero**
    
    Si la  **biblioteca**  de clases empresariales no proporciona la clase empresarial adecuada, herede de una de las  [clases persistentes base](https://docs.devexpress.com/eXpressAppFramework/113146/business-model-design-orm/business-model-design-with-xpo/base-persistent-classes?v=22.1).
    

>PROPINA
Si necesita crear una aplicación basada en una base de datos existente, consulte el siguiente tema de ayuda:  [Cómo: Generar clases empresariales de XPO para tablas de datos existentes](https://docs.devexpress.com/eXpressAppFramework/113451/business-model-design-orm/business-model-design-with-xpo/generate-xpo-business-classes-for-existing-data-tables?v=22.1).

Después de completar el tutorial, tendrá WinForms y ASP.NET aplicaciones de formularios Web Forms.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/08330190-d018-4b1a-9f34-1e5c2e581831)


La aplicación ASP.NET Web Forms proporcionará casi la misma funcionalidad, pero a través de un conjunto ligeramente diferente de elementos visuales.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6aa63a91-9e37-4db8-a96b-1ab103332ce0)


![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/975a15e5-f408-4512-a4e1-1ca176cbb803)


# Crear una solución mediante el asistente


En esta lección, aprenderá a crear una nueva solución XAF. También podrá ejecutar las aplicaciones WinForms y ASP.NET formularios Web Forms generadas y ver el estado predeterminado de la aplicación.

-   En el menú principal de Visual Studio, seleccione  **Archivo**  |  **Nuevo**  |  **Proyecto...**  para invocar el cuadro de diálogo  **Nuevo proyecto**.
    
-   Seleccione  **DevExpress v22.1  XAF Template Gallery**  for C# o Visual Basic y haga clic en  **Siguiente**. Especifique el nombre del proyecto ("MiSolución") y haga clic en  **Crear**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/d9fd3f10-ed5a-45b5-82ab-b416a8469618)

    
-   En la Galería de plantillas invocada, seleccione  **Asistente para soluciones XAF (**.NET Framework) en la sección .**NET Framework**  y haga clic en  **Ejecutar asistente**.
    
   ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/3cdbc8de-838f-4744-a21f-0793404a2089)
(https://docs.devexpress.com/eXpressAppFramework/images/MainDemo_TemplateGallery_RunWizard_WinWeb.png?v=22.1)
    
-   Esto invocará el  **Asistente para soluciones**. En la primera pantalla del asistente, elija las plataformas de destino. Puede crear WinForms independientes, ASP.NET aplicaciones de formularios Web Forms o varias aplicaciones a la vez. Elija las plataformas  **WinForms**  y  **Web**  y haga clic en  **Siguiente**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e5a82073-b5bd-45c0-9725-470e58364223)

    
-   En la siguiente pantalla, elija  **eXpress Objetos persistentes**  y haga clic en  **Siguiente**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/73e35616-287d-4177-8902-4b0eafdc517a)

    
-   En la siguiente pantalla, puede elegir las opciones de seguridad de su aplicación. Elija  **Active Directory**  como Tipo de  **autenticación**, seleccione  **Seguridad del lado cliente: modo integrado**  como tipo de  **seguridad Base de datos**  y haga clic en  **Siguiente**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6b6b3748-b1d2-406a-a854-74061ec84561)

    
-   En la siguiente pantalla, puede elegir los módulos XAF necesarios, que se agregarán automáticamente a su aplicación. Seleccione el módulo  [Business Class Library Customization (Personalización de la biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1#business-class-library-customization-module)) y haga clic en  **Finish (Finalizar**).
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ef97eb40-3868-4f4b-b29c-4299190322d6)

    
    >NOTA
    La mayoría de los otros módulos se agregarán manualmente en la sección  [Módulos adicionales](https://docs.devexpress.com/eXpressAppFramework/112770/getting-started/in-depth-tutorial-winforms-webforms/extra-modules?v=22.1).
    

Una vez creada la solución, verá cinco proyectos en el  **Explorador de soluciones**.

-   _MySolution.Module_: el proyecto de  [módulo](https://docs.devexpress.com/eXpressAppFramework/118046/application-shell-and-base-infrastructure/application-solution-components/modules?v=22.1)  básico que contiene código común a WinForms y ASP.NET aplicaciones de formularios Web Forms.
-   _MySolution.Module.Web_: el proyecto de módulo que contiene código específico de la aplicación ASP.NET formularios Web Forms.
-   _MySolution.Module.Win_: el proyecto de módulo que contiene código específico de la aplicación WinForms.
-   _MySolution.Web_: el proyecto de aplicación de formularios Web Forms de ASP.NET es similar a la aplicación WinForms, pero genera una interfaz basada en explorador en lugar de una interfaz de WinForms. No utilice este proyecto para la implementación de características. Toda la lógica de la aplicación debe implementarse en los proyectos de módulo apropiados.
-   _MySolution.Win_: el proyecto de aplicación WinForms, que se basa en módulos básicos y WinForms, genera automáticamente la interfaz de usuario de Windows. No utilice este proyecto para la implementación de características. Toda la lógica de la aplicación debe implementarse en los proyectos de módulo apropiados.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/03c0c400-dbfb-4d88-936d-625c93103470)


Puede consultar el tema  [Estructura de soluciones de aplicación](https://docs.devexpress.com/eXpressAppFramework/118045/application-shell-and-base-infrastructure/application-solution-components/application-solution-structure?v=22.1)  para obtener información adicional sobre la estructura de la solución XAF.

>NOTA
El asistente intenta detectar el servidor SQL Server instalado y cambia la cadena de conexión en consecuencia. Los servidores compatibles son **Microsoft SQL Server** (incluidas las ediciones  **Express** y **LocalDB**). Para utilizar otro sistema de base de datos (Postgre SQL, MySQL, Oracle, SQLite, Firebird, etc.), cambie el argumento  **ConnectionString** en _App.config y Web._  _archivos de configuración_  de  los proyectos de aplicación de formularios Web Forms de WindowsForms/ASP.NET.  Consulte el tema  [Conectar una aplicación XAF a un proveedor de](https://docs.devexpress.com/eXpressAppFramework/113155/business-model-design-orm/connect-an-xaf-application-to-a-database-provider?v=22.1)  bases de datos  para obtener más información sobre cómo conectarse a diferentes sistemas de bases de datos.

Ahora puede ejecutar las aplicaciones WinForms y ASP.NET formularios Web Forms. De forma predeterminada, el proyecto WinForms se establece como el proyecto de inicio. Para ejecutar la aplicación ASP.NET formularios Web Forms, haga clic con el botón secundario en el proyecto  **MySolution.Web**  en el  **Explorador de soluciones**  y seleccione el elemento  **Establecer como proyecto de inicio**  en el menú contextual. A continuación, haga clic en  **Iniciar depuración**  o presione la tecla  **F5**.

Las siguientes imágenes muestran las aplicaciones WinForms y ASP.NET formularios Web Forms resultantes. Ya contendrán las opciones de seguridad para su cuenta  _de Active Directory_.

**WinForms**

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/20d7950e-97a8-4c9b-8a2f-4718227a83f7)

**ASP.NET formularios web**

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ef8b4e26-9425-45b1-8f57-d49b59c6a39c)

De forma predeterminada, el asistente habilita el tipo de interfaz de usuario  **MDI con fichas**  y el estilo de formulario de  **cinta de opciones**  en la aplicación WinForms. Consulte los temas  [Elegir el tipo](https://docs.devexpress.com/eXpressAppFramework/113264/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/choose-the-winforms-ui-type?v=22.1)  de interfaz de usuario de WinForms y  [alternar la interfaz de cinta de WinForms](https://docs.devexpress.com/eXpressAppFramework/113038/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/toggle-the-winforms-ribbon-interface?v=22.1)  para obtener información sobre cómo cambiar estas opciones.


# Heredar de la clase de biblioteca de clase empresarial (XPO)


>PROPINA
Para aplicaciones .NET 6,  consulte: [Heredar de la clase Business Class Library (XPO, .NET 6).](https://docs.devexpress.com/eXpressAppFramework/402166/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/inherit-from-the-business-class-library-class-xpo?v=22.1)

En esta lección, aprenderá a implementar clases de negocio para su aplicación mediante la  [Biblioteca de clases empresariales](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1). Esta biblioteca contiene las clases de negocios listas para usar más típicas. Implementará una clase  **Contact**  personalizada derivando de la clase  **Person**  disponible en esta biblioteca e implementará varias propiedades adicionales. También aprenderá los conceptos básicos de la construcción automática de la interfaz de usuario basada en datos.

-   Normalmente, las clases de negocio deben implementarse en un  [proyecto de módulo independiente de la plataforma, de](https://docs.devexpress.com/eXpressAppFramework/118045/application-shell-and-base-infrastructure/application-solution-components/application-solution-structure?v=22.1)  modo que los mismos objetos estén disponibles en las aplicaciones WinForms y ASP.NET de formularios Web Forms. Para simplificar la implementación de clases específicas de XAF, se proporcionan varias plantillas de Visual Studio. En esta lección, utilizará la plantilla  **XPO Business Object**  para implementar una clase de negocio persistente. Haga clic con el botón secundario en la carpeta  _Business Objects_  del proyecto  _MySolution.Module_  y elija  **Agregar elemento DevExpress**  |  **Nuevo artículo...**  para invocar la  [Galería de plantillas](https://docs.devexpress.com/eXpressAppFramework/113455/installation-upgrade-version-history/visual-studio-integration/template-gallery?v=22.1). A continuación, seleccione el  **objeto de negocio XAF**  |  **Plantilla XPO Business Object**, especifique  _Contacto.cs_  como nombre del nuevo elemento y pulse  **Añadir elemento**. Como resultado, obtendrá un archivo de código generado automáticamente con una sola declaración de clase.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/278690a7-7da1-4df0-943c-f23878c2ccb0)

    
    La clase  **Contact**  generada automáticamente es un descendiente de la clase  [BaseObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.BaseImpl.BaseObject?v=22.1), que es una de las  [clases persistentes base](https://docs.devexpress.com/eXpressAppFramework/113146/business-model-design-orm/business-model-design-with-xpo/base-persistent-classes?v=22.1). Debe heredar una de estas clases cuando sea necesario implementar una clase persistente desde cero o usar clases de la  [Biblioteca de clases empresariales](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1)  (que también se derivan de la clase  **BaseObject**). Para obtener información general sobre el concepto de clase empresarial, consulte el tema  [Clases empresariales frente a tablas de base de datos](https://docs.devexpress.com/eXpressAppFramework/112570/business-model-design-orm/business-model-design-with-xpo/business-classes-vs-database-tables?v=22.1).
    
-   Reemplace la declaración de clase generada automáticamente por el código siguiente.
    

    
    ```csharp
    [DefaultClassOptions]
    public class Contact : Person {
        public Contact(Session session) : base(session) { }
        private string webPageAddress;
        public string WebPageAddress {
            get { return webPageAddress; }
            set { SetPropertyValue(nameof(WebPageAddress), ref webPageAddress, value); }
        }
        private string nickName;
        public string NickName {
            get { return nickName; }
            set { SetPropertyValue(nameof(NickName), ref nickName, value); }
        }
        private string spouseName;
        public string SpouseName {
            get { return spouseName; }
            set { SetPropertyValue(nameof(SpouseName), ref spouseName, value); }
        }
        private TitleOfCourtesy titleOfCourtesy;
        public TitleOfCourtesy TitleOfCourtesy {
            get { return titleOfCourtesy; }
            set { SetPropertyValue(nameof(TitleOfCourtesy), ref titleOfCourtesy, value); }
        }
        private DateTime anniversary;
        public DateTime Anniversary {
            get { return anniversary; }
            set { SetPropertyValue(nameof(Anniversary), ref anniversary, value); }
        }
        private string notes;
        [Size(4096)]
        public string Notes {
            get { return notes; }
            set { SetPropertyValue(nameof(Notes), ref notes, value); }
        }
    }
    public enum TitleOfCourtesy { Dr, Miss, Mr, Mrs, Ms };
    
    ```
    
    Como puede ver, el antecesor de la clase  **Contact**  se cambia de  **BaseObject**  a  **Person**  y se implementan varias propiedades personalizadas. Tenga en cuenta que el constructor  **Contact**  y el método  **SetPropertyValue**  se utilizan en los establecedores de propiedades. Estos son detalles del mapeador relacional de  [objetos eXpress Persistent Objects (XPO)](https://www.devexpress.com/Products/NET/ORM/index.xml) utilizado por XAF. Puede consultar el artículo de la base de conocimientos XPO Best Practices y el tema  [Creación de un objeto persistente](https://docs.devexpress.com/XPO/2077/create-a-data-model/create-a-persistent-object?v=22.1)  en la documentación de  [XPO](https://docs.devexpress.com/XPO/403711/best-practices/xpo-best-practices?v=22.1)  para obtener más información.
    
    Tenga en cuenta el uso del atributo  [DefaultClassOptionsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DefaultClassOptionsAttribute?v=22.1). En este tutorial, este atributo significa que las siguientes capacidades estarán disponibles para la clase empresarial  **Contact**.
    
    -   El elemento  **Contacto**  se agregará al control de navegación del formulario principal. Al hacer clic en este elemento, se mostrará una  [vista de lista](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1). Esta vista de lista representa una lista de objetos del tipo  **Contacto**.
    -   El elemento  **Contacto**  se agregará al submenú del botón  **Nuevo**  (![new_dropdown_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_new_dropdown117415.png?v=22.1)) cuando se muestren objetos de otro tipo en la Vista de lista. Haga clic en este elemento para invocar un formulario de detalles  **de**  contacto y crear un nuevo objeto  **de contacto**.
    -   Los objetos  **Contact**  se proporcionarán como origen de datos para generar informes (vea  [Crear un informe en Visual Studio](https://docs.devexpress.com/eXpressAppFramework/112734/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/create-a-report-in-visual-studio?v=22.1)).
    
    Para aplicar cada una de estas opciones por separado, use los atributos NavigationItemAttribute,  [CreatableItemAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.CreatableItemAttribute?v=22.1)  y  [VisibleInReportsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.VisibleInReportsAttribute?v=22.1).[](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.NavigationItemAttribute?v=22.1)
    
    >NOTA
    [CodeRush  ](https://www.devexpress.com/products/coderush/)incluye una serie de plantillas de código que ayudan a generar clases empresariales o sus partes con unas pocas pulsaciones de teclas. Para obtener información sobre las plantillas de código para **objetos persistentes de e Xpress, consulte el siguiente tema de**  ayuda: [Plantillas XPO y XAF](https://docs.devexpress.com/CodeRushForRoslyn/118557/coding-assistance/code-templates/xpo-templates?v=22.1).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Verá cómo la interfaz de usuario se genera automáticamente utilizando las estructuras de datos especificadas. Habrá un control de navegación que le permitirá mostrar la lista de  **contactos**. Podrás personalizar esta colección utilizando los editores correspondientes. Si hace clic en el botón  **Nuevo**  o hace doble clic en un registro existente, la aplicación mostrará un formulario de detalles ([Vista detallada](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1)) lleno de editores para cada campo de datos.
    
    En la imagen siguiente se muestran las vistas Detalle y Lista de la aplicación WinForms.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/36b8e6fd-fe17-4580-a3cd-2559298e2a78)

    
    Tenga en cuenta que muchos elementos se han generado de manera intuitiva en muy poco tiempo. Se crean los editores adecuados para los campos de datos y se utilizan los editores adecuados en los controles de cuadrícula para mostrar los datos. Tenga en cuenta que se ha creado un editor de cuadros combinados para  **Título de cortesía**  (un enumerador). También tenga en cuenta que los subtítulos se han transformado automáticamente de camel-case a cadenas separadas por espacios, los títulos de los formularios se actualizan automáticamente, etc.
    
    Puede utilizar las características de cuadrícula para mostrar, ocultar y reorganizar columnas, y aplicar agrupación, filtrado y ordenación a una vista de lista en tiempo de ejecución. En la aplicación WinForms, puede personalizar el diseño del editor en el formulario de detalles como desee en tiempo de ejecución. Para ello, haga clic con el botón derecho en un espacio vacío y seleccione  **Personalizar diseño**. Ahora puede mover a los editores a los puestos requeridos. Para obtener información sobre cómo personalizar el diseño del editor en tiempo de diseño, consulte el tema  [Personalizar el diseño de elementos de vista](https://docs.devexpress.com/eXpressAppFramework/112833/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/customize-the-view-items-layout?v=22.1). Además, puede consultar los temas Personalización del diseño de  [elementos de vista](https://docs.devexpress.com/eXpressAppFramework/112817/ui-construction/views/layout/view-items-layout-customization?v=22.1)  y Generación de columnas de vista de lista para ver cómo se generan el diseño predeterminado de Vista detallada y el conjunto de columnas Vista de  [lista](https://docs.devexpress.com/eXpressAppFramework/113285/ui-construction/views/layout/list-view-column-generation?v=22.1)  predeterminado.
    

Puede ver el código que se muestra aquí en  _MySolution.Module_  |  _Objetos de negocio_  | Contacto_.cs_  archivo (_Contacto.vb_) de la demostración principal instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Suministro de datos iniciales (XPO)


>PROPINA
Para aplicaciones .NET 6,  consulte: [Proporcionar datos iniciales (XPO, .NET 6).](https://docs.devexpress.com/eXpressAppFramework/402170/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/supply-initial-data-xpo?v=22.1)

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1).

-   Abra el archivo Updater.cs (_Updater.vb_), ubicado en la carpeta  _Actualización de base de datos_  del proyecto  _MySolution.Module._  Agregue el código siguiente al método  [ModuleUpdater.UpdateDatabaseAfterUpdateSchema.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater.UpdateDatabaseAfterUpdateSchema?v=22.1)
    

    ```csharp
    using MySolution.Module.BusinessObjects;
    //...
    
    public class Updater : DevExpress.ExpressApp.Updating.ModuleUpdater {
        //...
            public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
    
            Contact contactMary = ObjectSpace.FirstOrDefault<Contact>(c => c.FirstName == "Mary" && c.LastName == "Tellitson");
            if (contactMary == null) {
                contactMary = ObjectSpace.CreateObject<Contact>();
                contactMary.FirstName = "Mary";
                contactMary.LastName = "Tellitson";
                contactMary.Email = "tellitson@example.com";
                contactMary.Birthday = new DateTime(1980, 11, 27);
            }
            //...
            ObjectSpace.CommitChanges();
        }
    }
    
    ```
    
    Después de agregar el código anterior, el objeto  **Contact**  se creará en la base de datos de la aplicación, si aún no existe.
    
    Cada vez que ejecuta la aplicación, compara la versión de la aplicación con la versión de la base de datos y encuentra cambios en la aplicación o base de datos. Si la versión de la base de datos es inferior a la versión de la aplicación, la aplicación provoca el evento  [XafApplication.DatabaseVersionMismatch.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.DatabaseVersionMismatch?v=22.1)  Las aplicaciones WinForms y ASP.NET formularios Web Forms controlan este evento en una plantilla de solución. Cuando la aplicación se ejecuta en modo de depuración, este controlador de eventos utiliza el actualizador de base de datos integrado para actualizar la  **base de datos de**  la aplicación. Después de actualizar el esquema de base de datos, se llama al método  [ModuleUpdater.UpdateDatabaseAfterUpdateSchema.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater.UpdateDatabaseAfterUpdateSchema?v=22.1)  En este método, puede guardar los objetos de negocio necesarios en la base de datos.
    
    Como puede ver en el código anterior, eXpressApp Framework (XAF) utiliza un objeto  [Object Space](https://docs.devexpress.com/eXpressAppFramework/113707/data-manipulation-and-business-logic/object-space?v=22.1)  para manipular objetos persistentes (consulte  [Crear, leer, actualizar y eliminar datos](https://docs.devexpress.com/eXpressAppFramework/113711/data-manipulation-and-business-logic/create-read-update-and-delete-data?v=22.1)).
    
    Para especificar los criterios pasados como parámetro en la llamada al método  [BaseObjectSpace.FindObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.BaseObjectSpace.FindObject.overloads?v=22.1), se utiliza CriteriaOperator. Su método CriteriaOperator.Parse convierte una cadena, especificando una expresión criteria a su equivalente  [CriteriaOperator.](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.CriteriaOperator.Parse.overloads?v=22.1)  Para obtener más información sobre cómo especificar criterios, consulte el tema  [Formas de crear criterios](https://docs.devexpress.com/eXpressAppFramework/113052/filtering/in-list-view/ways-to-build-criteria?v=22.1).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Seleccione el elemento  **Contacto**  en el control de navegación. Observe que el nuevo contacto, "Mary Tellitson", aparece en la lista de la derecha.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/70d28613-e622-4464-a487-169baab47f5c)

    

Puede ver el código de este tutorial en  _MySolution.Module_  |  _Actualización de la base de datos_  | Updater.cs archivo (_Updater.vb_) de la demo principal instalada con XAF.  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Implementar clases empresariales personalizadas y propiedades de referencia (XPO)

>PROPINA
Para aplicaciones .NET 6,  consulte: [Implementar clases empresariales personalizadas y propiedades de referencia (XPO, .NET 6).](https://docs.devexpress.com/eXpressAppFramework/402163/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)

En esta lección, aprenderá cómo implementar clases de negocios desde cero. Para este propósito, se implementarán las clases de negocios  **de Departamento**  y  **Posición**. Estas clases se utilizarán en la clase  **Contact**, implementada anteriormente. También aprenderá los conceptos básicos de la construcción automática de la interfaz de usuario para objetos a los que se hace referencia.

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1).

-   Agregue las siguientes clases persistentes  **Department**  y  **Position**  al archivo Contact_.cs_  (_Contact.vb_).
    

    
    ```csharp
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
    public class Department : BaseObject {
        public Department(Session session) : base(session) { }
        private string title;
        public string Title {
            get { return title; }
            set { SetPropertyValue(nameof(Title), ref title, value); }
        }
        private string office;
        public string Office {
            get { return office; }
            set { SetPropertyValue(nameof(Office), ref office, value); }
        }
    }
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
    public class Position : BaseObject {
        public Position(Session session) : base(session) { }
        private string title;
        public string Title {
            get { return title; }
            set { SetPropertyValue(nameof(Title), ref title, value); }
        }
    }
    
    ```
    
    Estas nuevas clases son persistentes, ya que son descendientes de la clase  [BaseObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.BaseImpl.BaseObject?v=22.1).
    
    >NOTA
    El atributo  **DefaultProperty** se utiliza en el código anterior. Este atributo se utiliza para especificar la  [propiedad predeterminada](https://docs.devexpress.com/eXpressAppFramework/113525/business-model-design-orm/how-to-specify-a-display-member-for-a-lookup-editor-detail-form-caption?v=22.1) de la clase. Puede especificar la propiedad más descriptiva de la clase en el atributo  **Propiedad predeterminada** y sus valores se mostrarán a continuación.
    
    -   Leyendas de formulario de detalle
    -   La columna situada más a la izquierda de una vista de lista
    -   Las vistas de lista de búsqueda (estas vistas se explicarán en el último paso de esta lección).
    
    Consulte el tema  [Anotaciones de datos en el modelo de datos](https://docs.devexpress.com/eXpressAppFramework/112701/business-model-design-orm/data-annotations-in-data-model?v=22.1) para obtener información adicional.
    
-   Agregue las propiedades  **Department**  y  **Position**  a la clase  **Contact**. El código siguiente muestra esto.
    
 
    
    ```csharp
    [DefaultClassOptions]
    public class Contact : Person {
        //...
        private Department department;
        public Department Department {
            get {return department;}
            set {SetPropertyValue(nameof(Department), ref department, value);}
        }
        private Position position;
        public Position Position {
            get {return position;}
            set {SetPropertyValue(nameof(Position), ref position, value);}
        }
        //...
    }
    
    ```
    
    La clase  **Contact**  ahora expone las propiedades de referencia  **Position**  y  **Department**.
    
    >NOTA
    [CodeRush  ](https://www.devexpress.com/products/coderush/)incluye una serie de plantillas de código que ayudan a generar clases empresariales o sus partes con unas pocas pulsaciones de teclas. Para obtener información sobre las plantillas de código para **objetos persistentes de e Xpress, consulte el siguiente tema de**  ayuda: [Plantillas XPO y XAF](https://docs.devexpress.com/CodeRushForRoslyn/118557/coding-assistance/code-templates/xpo-templates?v=22.1).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Verá cómo la interfaz de usuario se genera automáticamente utilizando las estructuras de datos especificadas. El control de navegación contendrá nuevos elementos  **Departamento**  y Posición, que le permitirán acceder a los objetos  **Departamento**  y  **Posición**.  Tenga en cuenta que en la vista de detalles de  **contacto**, se ha creado un editor de búsqueda para  **Departamento**  y  **Posición**. En este editor, se utiliza un tipo especial de  [vista](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1), Vista de lista de búsqueda. Normalmente, esta vista tiene una sola columna correspondiente a la propiedad predeterminada de la clase. Con el editor de búsquedas, puede seleccionar el Departamento (Posición) requerido para el  **Contacto**  actual y agregar nuevos objetos  **de Departamento**  (**Posición**) mediante el botón  **Nuevo**. Además, también podrá editar objetos de  **departamento**  (**posición**) existentes manteniendo pulsada la tecla  **Mayús**  +  **CTRL**  y haciendo clic en el objeto seleccionado.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/556eda7f-2908-4676-88b5-95d7ca01bf44)

    

You can see the code demonstrated in this lesson in the  _MySolution.Module_  |  _Business Objects_  |  _Contact.cs_  (_Contact.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Agregar una clase desde la biblioteca de clases empresariales (XPO)

>PROPINA
Para aplicaciones .NET 6,  consulte: [Heredar de la clase Business Class Library (XPO, .NET 6).](https://docs.devexpress.com/eXpressAppFramework/402166/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/inherit-from-the-business-class-library-class-xpo?v=22.1)

En esta lección, aprenderá a usar las clases de negocios de la  [biblioteca de clases empresariales](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1)  tal cual. Para ello, agregará la clase de negocio  **Event**  a la aplicación.

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1).

-   En el Explorador de soluciones, busque el archivo Module.cs (Module_.vb_) dentro del proyecto  _MySolution.Module._  Haga doble clic en él para invocar el  [Diseñador de módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1).
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/483d10f9-2ddd-4f2e-9d90-31c2344fad34)

    
-   En la sección  **Tipos exportados**, busque los  **ensamblados a los que se hace referencia**  |  **DevExpress.Persistent.BaseImpl.Xpo.v22.1**  |  **Nodo de evento**. Selecciónelo y presione la  **barra ESPACIADORA**, o haga clic con el botón derecho y elija  **Usar tipo en la aplicación en**  el menú contextual invocado. El nodo se marcará en negrita. Esto significa que la clase de negocio  **Event**  se agregará al  [modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1)  y esta clase participará en el proceso de construcción de la interfaz de usuario. El uso de módulos adicionales se detalla en la sección  [Módulos adicionales](https://docs.devexpress.com/eXpressAppFramework/112770/getting-started/in-depth-tutorial-winforms-webforms/extra-modules?v=22.1)  de este tutorial.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/eb2864cf-a268-4fcf-b5da-d597e7c00a0f)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms y observe que se crea el elemento de navegación  **Evento del programador**, ya que la clase  **Event**  tiene aplicado el atributo  [NavigationItemAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.NavigationItemAttribute?v=22.1). Tenga en cuenta que puede ser necesario agregar manualmente otras clases de la  **Biblioteca de clases profesionales**  a la navegación (consulte el tema  [Agregar un elemento al control de navegación](https://docs.devexpress.com/eXpressAppFramework/112749/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-navigation-control?v=22.1)).
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/198e3dc7-4986-4766-9d98-7aef98b2a19d)

    

>PROPINA
XAF tiene un **módulo especial del Programador**  que contiene el  [Editor de listas](https://docs.devexpress.com/eXpressAppFramework/113189/ui-construction/list-editors?v=22.1) que utiliza el **Control Programador** ([Win](https://docs.devexpress.com/WindowsForms/1971/controls-and-libraries/scheduler?v=22.1)/[Web](https://docs.devexpress.com/AspNet/3685/components/scheduler?v=22.1)) para mostrar y administrar objetos de  negocio  **de eventos** en aplicaciones XAF. Consulte la lección  [Agregar el módulo Programador](https://docs.devexpress.com/eXpressAppFramework/113040/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/add-the-scheduler-module?v=22.1) para aprender a usarlo en su aplicación.

Puede ver los cambios realizados en la demostración principal instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Establecer una relación de varios a varios (XPO)


>PROPINA
Para aplicaciones .NET 6,  consulte: [Establecer una relación entre varios y varios (XPO, .NET 6).](https://docs.devexpress.com/eXpressAppFramework/402168/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/set-a-many-to-many-relationship-xpo?v=22.1)

En esta lección, aprenderá a establecer relaciones entre objetos de negocio. Para ello, se implementará la clase de negocio Task y se establecerá una relación  _Many-to-Many_  entre los objetos  **Contact**  y  **Task**.  También aprenderá los conceptos básicos de la construcción automática de la interfaz de usuario para los objetos a los que se hace referencia.

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1).

-   Para agregar la clase  de negocio Task a la aplicación, puede utilizar la clase  **Task**  de la biblioteca de Business Class. Dado que necesita establecer una relación entre los objetos  **Contact**  y  Task, debe personalizar la implementación de la clase  **Task**.  [Herede de esta clase](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)  y agregue la propiedad de colección  **Contacts**, como se muestra en el código siguiente.
    

    ```csharp
    using DevExpress.ExpressApp.Model;
    // ...
    [DefaultClassOptions]
    [ModelDefault("Caption", "Task")]
    public class DemoTask : Task {
        public DemoTask(Session session): base(session) { }
        [Association("Contact-DemoTask")]
        public XPCollection<Contact> Contacts {
            get {
                return GetCollection<Contact>(nameof(Contacts));
            }
        }
    }
    
    ```
    
    >IMPORTANTE
    No modifique la declaración  **de propiedad XPCollection** demostrada anteriormente. La manipulación de la recopilación o la introducción de cualquier configuración adicional dentro de la declaración puede causar un comportamiento impredecible.
    
    En este código,  [AssociationAttribute](https://docs.devexpress.com/XPO/DevExpress.Xpo.AssociationAttribute?v=22.1)  se aplica a la propiedad  **Contacts**  de tipo  [XPCollection](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPCollection?v=22.1), que representa la colección de contactos asociados. El atributo  **Association**  es necesario al establecer una relación entre objetos. Tenga en cuenta que la implementación del getter de propiedades  **Contacts**  (el método  **GetCollection**) se utiliza para devolver una colección.
    
    >NOTA
    [El atributo Model DefaultAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.ModelDefaultAttribute?v=22.1),  que se aplica a la clase  **Demo**  Task  , especifica el valor "Task" para la propiedad  **Caption** de **BOModel**  |**Nodo Tarea de demostración**. Generalmente, puede especificar cualquier propiedad de **BOModel** del modelo de aplicación |**_<Class>_** o **BOModel** | **_<Clase>_** | **Miembros propios** | **_<Miembro>_** nodo aplicando el **atributo Modelo predeterminado**  a  una clase de negocio o a su miembro.
    
-   Modifique la implementación de la clase Contact: agregue la propiedad  **Tasks**  como la segunda parte de la relación  **Contact-DemoTask**.  Tenga en cuenta que el atributo  **Association**  también debe aplicarse a esta propiedad. En el código siguiente se muestra un fragmento de código de la implementación de la clase  **Contact**.
    

    
    ```csharp
    [DefaultClassOptions]
    public class Contact : Person {
        //...
        [Association("Contact-DemoTask")]
        public XPCollection<DemoTask> Tasks {
            get {
                return GetCollection<DemoTask>(nameof(Tasks));
            }
        }
    }
    
    ```
    
    El código anterior generará automáticamente las tablas y relaciones intermedias necesarias.
    
    >NOTA
    [CodeRush  ](https://www.devexpress.com/products/coderush/)incluye una serie de plantillas de código que ayudan a generar clases empresariales o sus partes con unas pocas pulsaciones de teclas. Para obtener información sobre las plantillas de código para **objetos persistentes de e Xpress, consulte el siguiente tema de**  ayuda: [Plantillas XPO y XAF](https://docs.devexpress.com/CodeRushForRoslyn/118557/coding-assistance/code-templates/xpo-templates?v=22.1).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Invoque la  **vista Detalles de contacto**  o la  **Vista de detalles de**  tareas. Agregar tareas a la colección  **Tasks**  de un objeto  **Contact**  o contactos a la colección  **Contacts**  de un objeto  **Task**. Para aplicar la asignación, utilice el botón  **Vínculo**  que acompaña a estas colecciones.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/67c94110-5071-4a0a-9947-efe1c305bc6e)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2ea6d20d-50d0-42f7-a99a-429e0b660fbe)

Puede ver el código mostrado en esta lección en los archivos Contact.cs (_Contact_.vb) y DemoTask_.cs (DemoTask__.vb_) de la  demostración principal instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Establecer una relación de uno a varios (XPO)


>PROPINA
Para aplicaciones .NET 6,  consulte: [Establecer una relación de uno a varios (XPO, .NET 6).](https://docs.devexpress.com/eXpressAppFramework/402169/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/set-a-one-to-many-relationship-xpo?v=22.1)

En esta lección, aprenderá a establecer una relación de uno a varios entre objetos de negocio. Los objetos de negocio  **de Contacto**  y  **Departamento**  estarán relacionados por una relación de uno a varios. Para ello, la propiedad  **Contacts**  se agregará a la clase  **Department**  que representa la parte "Muchas" de la relación. A continuación, aprenderá los conceptos básicos de la construcción automática de la interfaz de usuario para objetos a los que se hace referencia.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implementar clases empresariales personalizadas y propiedades de referencia](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Establecer una relación de muchos a muchos](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)

-   Para implementar la parte "One" de la relación Departamento-Contactos, decore la propiedad  **Department**  de la clase  **Contact**  con  [AssociationAttribute](https://docs.devexpress.com/XPO/DevExpress.Xpo.AssociationAttribute?v=22.1).
    

    
    ```csharp
    [DefaultClassOptions]
    public class Contact : Person {
        //...
        private Department department;
        [Association("Department-Contacts")]
        public Department Department {
            get {return department;}
            set {SetPropertyValue(nameof(Department), ref department, value);}
        }
        //...
    }
    
    ```
    
    Para obtener información sobre el atributo  **Asociación**, consulte la lección  [Establecer una relación de varios a varios](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1).
    
-   Para implementar la parte "Muchos" de la relación Departamento-Contactos, agregue la propiedad  **Contacts**  a la clase  **Department**  y decore esta propiedad con el atributo  **Association**.
    

    
    ```csharp
    public class Department : BaseObject {
        //...
        [Association("Department-Contacts")]
        public XPCollection<Contact> Contacts {
            get {
                return GetCollection<Contact>(nameof(Contacts));
            }
        }
    }
    
    ```
    
    >NOTA    
    [CodeRush](https://www.devexpress.com/products/coderush/) includes a number of Code Templates that help generate business classes or their parts with a few keystrokes. To learn about the Code Templates for **eXpress Persistent Objects**, refer to the following help topic: [XPO and XAF Templates](https://docs.devexpress.com/CodeRushForRoslyn/118557/coding-assistance/code-templates/xpo-templates?v=22.1).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Invocar una vista detallada para un objeto  **Departamento**  (vea la lección anterior "[Establecer una relación de varios a varios](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)"). Puede ver el grupo  **Contactos**. Para agregar objetos a la colección  **Contactos**, utilice los botones  **Nuevo**  () o  **Vínculo**  (![link_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_link117412.png?v=22.1)![button_new](https://docs.devexpress.com/eXpressAppFramework/images/btn_new117411.png?v=22.1)) de esta ficha. El botón  **Vincular**  permite agregar referencias a objetos  **de contacto**  existentes.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/5633f43d-ab91-4c13-8378-5ba8a6b5e74d)

    
    Para quitar una referencia a un objeto de esta colección, utilice el botón  **Desvincular**  (![unlink_img](https://docs.devexpress.com/eXpressAppFramework/images/btn_unlink117413.png?v=22.1)).
    

>PROPINA
Si crea un nuevo departamento y, a  continuación, crea un nuevo contacto en  la colección  **Contactos**, el **departamento**  asociado  no es visible inmediatamente en la [vista detallada](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1)  del  **contacto** recién creado. El vínculo entre estos objetos se agrega más adelante al guardar el **contacto**. Para cambiar este comportamiento, utilice la [aplicación Xaf.Vincularnuevoobjetoala propiedad ParentInmediatamente](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.LinkNewObjectToParentImmediately?v=22.1). Cuando el valor de la propiedad es , la aplicación crea un vínculo y lo guarda inmediatamente después de hacer clic en **Nuevo**.`true`

Puede ver el código mostrado en esta lección en  _MySolution.Module_  |  _Objetos de negocio_  | Contacto_.cs_  archivo (_Contacto.vb_) de la demostración principal instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Inicializar una propiedad después de crear un objeto (XPO)


>PROPINA
Para aplicaciones .NET 6,  consulte: [Inicializar propiedades de objeto de negocio (XPO, .NET 6).](https://docs.devexpress.com/eXpressAppFramework/402167/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/initialize-a-property-after-creating-an-object-xpo?v=22.1)

En esta lección, aprenderá a establecer el valor predeterminado para una propiedad determinada de una clase empresarial. Para ello, la propiedad  **Priority**  se agregará a la clase  **DemoTask**  creada en la lección  [Establecer una relación entre muchos](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1). Para inicializarlo, se reemplazará el método  **AfterConstruction**  en esta clase.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Establecer una relación de muchos a muchos](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)

-   Agregue la  propiedad Priority a la clase  **DemoTask**  y declare la enumeración  **Priority**, como se muestra a continuación:
    

    ```csharp
    public class DemoTask : Task {
        // ...
        private Priority priority;
        public Priority Priority {
            get { return priority; }
            set {
                SetPropertyValue(nameof(Priority), ref priority, value);
            }
        }
        //...
    }
    public enum Priority {
        Low = 0,
        Normal = 1,
        High = 2
    }
    
    ```
    
-   Para inicializar la propiedad  **Priority**  recién agregada cuando se crea un objeto  **DemoTask**, invalide el método  **AfterConstruction**, como se muestra a continuación:
    

    ```csharp
    [DefaultClassOptions]
    [Custom("Caption", "Task")]
    public class DemoTask : Task {
        //...
        public override void AfterConstruction() {
            base.AfterConstruction();
            Priority = Priority.Normal;
        }
        //...
    }
    
    ```
    
    Este método se ejecutará cuando se cree el nuevo objeto  **DemoTask**. Como resultado, la propiedad  **Priority**  se inicializará con el valor especificado. Para obtener más información sobre el método  **AfterConstruction**, consulte el tema  [PersistentBase.AfterConstruction](https://docs.devexpress.com/XPO/DevExpress.Xpo.PersistentBase.AfterConstruction?v=22.1)  (método) en la documentación de XPO.
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Cree un nuevo objeto DemoTask seleccionando  **DemoTask**  en la lista desplegable del botón Nuevo ().![new_dropdown_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_new_dropdown117415.png?v=22.1)  (En la vista de detalle que representa el objeto  **DemoTask**  recién creado, observe que la propiedad  **Priority**  se establece en  **Normal**, como se declara en el código anterior). Observe que el editor de cuadros combinados muestra automáticamente la propiedad de enumeración.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a001dde7-c436-409d-9ae4-e33752fbeaea)

    

Puede ver el código mostrado en esta lección en  _MySolution.Module_  |  _Objetos de negocio_  |  _Archivo_  DemoTask.cs (_DemoTask.vb_) de la demo principal instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Implementar propiedades de referencia dependientes (XPO)

>PROPINA
Para aplicaciones .NET 6,  consulte: [Implementar propiedades de referencia dependientes (XPO, .NET 6).](https://docs.devexpress.com/eXpressAppFramework/402164/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/implement-dependent-reference-properties-xpo?v=22.1)

En esta lección, aprenderá a implementar propiedades cuyos valores pueden depender de otras propiedades. La propiedad  **Manager**  se agregará a la clase  **Contact**. De forma predeterminada, se representará mediante un editor de búsqueda que contiene todos los  **contactos**que existen en la base de datos. Sin embargo, es posible que necesite que este editor contenga  **contactos**del mismo  **departamento**. Además, es posible que necesite que la  **posición**  de estos  **contactos**sea "Gerente". Para ello, utilice los atributos  [DataSourcePropertyAttribute y DataSourceCriteriaAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DataSourcePropertyAttribute?v=22.1)  para  [](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DataSourceCriteriaAttribute?v=22.1)la propiedad  **Manager**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implementar clases empresariales personalizadas y propiedades de referencia](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Establecer una relación de uno a muchos](https://docs.devexpress.com/eXpressAppFramework/112733/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-one-to-many-relationship-xpo?v=22.1)

-   Agregue una nueva propiedad  **Manager**  del tipo Contact a la clase  **Contact**.  Aplique el atributo  **DataSourceProperty**  a esta propiedad, como se muestra a continuación.
    

    
    ```csharp
    [DefaultClassOptions]
    public class Contact : Person {
        //...
        private Contact manager;
        [DataSourceProperty("Department.Contacts")]   
        public Contact Manager {
           get { return manager; }
           set { SetPropertyValue(nameof(Manager), ref manager, value); }
        }
        //...
    }
    
    ```
    
    Con el atributo  **DataSourceProperty**  aplicado, el editor de búsquedas  **Manager**  contendrá objetos  **Contact**  especificados por la propiedad  **Contacts**  del objeto  **Department**.
    
-   Ejecute la aplicación y seleccione  **Contacto**  en la lista desplegable del cuadro combinado  **Nuevo**. Se invocará la vista de detalles  **de contacto**. Especifique la propiedad  **Department**  y expanda el editor de búsquedas  **del administrador**. Asegúrese de que la propiedad  **Department**  de los objetos enumerados es la misma que la especificada anteriormente.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/72430a81-fdbb-4d4c-abff-32f0618a5c42)

    
-   Aplique el atributo  **DataSourceCriteria**  a la propiedad  **Manager**  de la clase  **Contact**  como se muestra a continuación.
    

    
    ```csharp
    public class Contact : Person {
        //...
        [DataSourceProperty("Department.Contacts")]
        [DataSourceCriteria("Position.Title = 'Manager' AND Oid != '@This.Oid'")]
        public Contact Manager {
            // ...
        }
        // ...
    }
    
    ```
    
    Con el atributo  **DataSourceCriteria**  aplicado, el editor de búsquedas  **del Administrador**  contendrá objetos  **Contact**  que satisfagan los criterios especificados en el parámetro de atributo.
    
-   Ejecute la aplicación. Establezca la propiedad  **Position**  en "Manager" para varios objetos  **de contacto**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ea96f6d1-b9d9-4324-be71-46ef01b1b162)

-   Seleccione  **Contacto**  en la lista desplegable del botón  **Nuevo**  (![new_dropdown_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_new_dropdown117415.png?v=22.1)). Se invocará la vista de detalles  **de contacto**. Especifique la propiedad  **Department**  y expanda el editor de búsquedas  **del administrador**. Asegúrese de que la propiedad  **Position**  está establecida en "Manager" para cada uno de los objetos enumerados.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/1b195a82-1924-47da-b23b-ec68ebc11141)

    
-   Si no se especifica la propiedad  **Department**  para un  **contacto**, puede proporcionar otro origen de datos para el editor de búsquedas  **del administrador**. Para ello, especifique el segundo parámetro para el atributo  **DataSourceProperty**. En el código siguiente, este parámetro se establece en el valor  **DataSourcePropertyIsNullMode.SelectAll.**  También puede establecer los valores DataSourcePropertyIsNullMode.SelectNothing o  **DataSourcePropertyIsNullMode.CustomCriteria.**  En este último caso, se requiere un tercer parámetro para especificar un criterio.
    

    ```csharp
    [DefaultClassOptions]
    public class Contact : Person {
        //...
        [DataSourceProperty("Department.Contacts",DataSourcePropertyIsNullMode.SelectAll)]
        [DataSourceCriteria("Position.Title = 'Manager' AND Oid != '@This.Oid'")]
        public Contact Manager {
            // ...
        }
        // ...
    }
    
    ```
    
    El código anterior mostrará todos los contactos en el editor de búsqueda  **del administrador**, si no se especifica la propiedad  **Department**.
    
-   Ejecute la aplicación y compruebe los resultados.

>NOTA
Puede implementar el mismo comportamiento en tiempo de diseño. Para obtener más información, consulte la lección  [Fuente de datos del Editor de búsqueda de filtros](https://docs.devexpress.com/eXpressAppFramework/112755/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/filter-lookup-editor-data-source?v=22.1).

Puede ver el código que se muestra aquí en  _MySolution.Module_  |  _Objetos de negocio_  | Contacto_.cs_  archivo (_Contacto.vb_) de la demostración principal instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Implementar la validación del valor de la propiedad en el código (XPO)


>PROPINA
Para aplicaciones .NET 6,  consulte: [Implementar propiedades de referencia dependientes (XPO, .NET 6).](https://docs.devexpress.com/eXpressAppFramework/402165/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/implement-property-value-validation-in-code-xpo?v=22.1)

En esta lección se explica cómo establecer reglas para las clases de negocio y sus propiedades. Estas reglas se validan cuando un usuario final ejecuta una operación especificada. Esta lección le guiará a través de la implementación de una regla que requiere que la propiedad  **Position.Title**  no esté vacía. Esta regla se comprobará al guardar un objeto  **Position**. También podrá ver los elementos de la interfaz de usuario que informan de una regla rota.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implementar clases empresariales personalizadas y propiedades de referencia](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)

-   La funcionalidad de validación es proporcionada por el  [módulo de validación](https://docs.devexpress.com/eXpressAppFramework/113684/validation-module?v=22.1). Agregue este módulo al proyecto  _MySolution.Module._  Para ello, busque el archivo Module_.cs_  (Module.vb) en el proyecto  _MySolution.Module_  que se muestra en el  **Explorador de soluciones**.  Haga doble clic en este archivo para invocar el  [Diseñador de módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: Sección Módulos XAF**. Arrastre el elemento  **ValidationModule**  de esta sección al panel  **Módulos requeridos**  del diseñador. Vuelva a generar la solución.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/97efbf21-2b1c-4b05-8d7e-58fcb9082ad5)

    
    En una aplicación WinForms, agregue  **ValidationWindowsFormsModule**. Este módulo crea mensajes de error de validación que son más informativos y fáciles de usar que los mensajes de excepción predeterminados. Además, este módulo proporciona compatibilidad con la validación en contexto (consulte  [IModelValidationContext.AllowInplaceValidation](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Validation.IModelValidationContext.AllowInplaceValidation?v=22.1)). Para agregar este módulo, busque el archivo WinApplication.cs (_WinApplication.vb_) en el proyecto  _MySolution.Win_  que se muestra en el  **Explorador de soluciones**, haga doble clic en este archivo para invocar al  [Diseñador de aplicaciones](https://docs.devexpress.com/eXpressAppFramework/112827/installation-upgrade-version-history/visual-studio-integration/application-designer?v=22.1)  y arrastre  **ValidationWindowsFormsModule**  desde el  **Cuadro de herramientas**  al panel  **Módulos necesarios**.
    
    En una aplicación de formularios Web Forms ASP.NET, también puede agregar  **ValidationAspNetModule**. Este módulo proporciona compatibilidad con la validación en contexto (consulte  [IModelValidationContext.AllowInplaceValidation](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Validation.IModelValidationContext.AllowInplaceValidation?v=22.1)). Para agregar este módulo, busque el archivo WebApplication.cs (_WebApplication.vb_) en el proyecto  _MySolution.Web_  que se muestra en el  **Explorador de soluciones**, haga doble clic en este archivo para invocar al  **Diseñador de aplicaciones**  y arrastre  **ValidationAspNetModule**  desde el  **Cuadro de herramientas**  hasta el panel  **Módulos necesarios**.
    
-   Aplique el atributo  [RuleRequiredFieldAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Validation.RuleRequiredFieldAttribute?v=22.1)  a la propiedad  **Title**  de la clase  **Position**. Como parámetro, especifique el contexto para comprobar la regla (por ejemplo, DefaultContexts.Save). El código siguiente muestra este atributo.
    

    
    ```csharp
    using DevExpress.Persistent.Validation;
    //...
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
    public class Position : BaseObject {
       //...
       private string title;
       [RuleRequiredField(DefaultContexts.Save)]
       public string Title {
          get { return title; }
          set { SetPropertyValue(nameof(Title), ref title, value); }
       }
    }
    
    ```
    
-   El atributo  **RuleRequiredField**  define una regla de validación que garantiza que la propiedad Position.Title tiene un valor cuando se guarda el objeto  **Position.**
    
    Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Haga clic en el botón  **Nuevo**  (![button_new](https://docs.devexpress.com/eXpressAppFramework/images/btn_new117411.png?v=22.1)) para crear una nueva posición. Deje vacía la propiedad  **Título**  y haga clic en el botón  **Guardar**. Se mostrará el siguiente mensaje de error, dependiendo del tipo de aplicación.
    
    **Aplicación WinForms**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b5244732-206b-4773-b6f3-a5e67c4e96ca)

    
    **ASP.NET Aplicación de formularios Web Forms**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/564b7084-23ed-4bf4-a54d-209d379eb38c)

    
    Este mensaje de advertencia también se invocará si hace clic en el botón  **Guardar y cerrar**  o realiza otra acción que guarda el objeto en la base de datos.
    
    >NOTA
    Puede utilizar el botón  **Validar** barra de herramientas para comprobar si hay reglas rotas sin guardar el objeto actual.
    
-   En la aplicación WinForms, cierre la ventana con el mensaje de advertencia, establezca un valor para la propiedad  **Title**  y haga clic en el botón  **Guardar**. En la aplicación ASP.NET formularios Web Forms, establezca un valor para la propiedad  **Title**  y haga clic en el botón  **Guardar**. El objeto se guardará correctamente.

>NOTA
El sistema de validación proporciona una serie de reglas y contextos. Para obtener más información, consulte el tema  [Reglas de validación](https://docs.devexpress.com/eXpressAppFramework/113008/validation/validation-rules?v=22.1). La información sobre las reglas aplicadas en el código se carga en el modelo de aplicación (consulte el tema Implementar validación de  [valor de propiedad en el modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112750/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/implement-property-value-validation-in-the-application-model?v=22.1)). Esto permite a un administrador de aplicaciones empresariales agregar y editar reglas y contextos a través del [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1).

Puede ver el código que se muestra aquí en  _MySolution.Module_  |  _Objetos de negocio_  | Contacto_.cs_  archivo (_Contacto.vb_) de la demostración principal instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Amplíe la funcionalidad

En esta sección del tutorial, aprenderá a agregar características personalizadas a su aplicación. Para ello, debe familiarizarse con los siguientes conceptos básicos de  **eXpressApp Framework**.

-   **Acción**
    
    Visualmente, Action es un elemento de la barra de herramientas u otro control que realiza el código asociado cuando un usuario final lo manipula. XAF proporciona varios tipos de acción predefinidos. Puede elegir el tipo adecuado, en función de cómo desee que se represente la acción dentro de la interfaz de usuario. Independientemente del tipo elegido, todas las acciones exponen el evento  **Execute**, cuyo controlador se ejecuta cuando los usuarios finales manipulan el elemento correspondiente. Para obtener más información, consulte el tema  [Acciones](https://docs.devexpress.com/eXpressAppFramework/112622/ui-construction/controllers-and-actions/actions?v=22.1).
    
-   **Controlador**
    
    Los controladores son clases heredadas de los descendientes del  [controlador](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Controller?v=22.1): ViewController (incluidas sus versiones genéricas: ViewController<ViewType> y ObjectViewController[<ViewType, ObjectType>](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ObjectViewController-2?v=22.1)) o  [WindowController](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController?v=22.1).  [](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController-1?v=22.1)[](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.WindowController?v=22.1)Se utilizan para  [implementar la lógica empresarial en la](https://docs.devexpress.com/eXpressAppFramework/113711/data-manipulation-and-business-logic/create-read-update-and-delete-data?v=22.1)  aplicación. Esta lógica puede ejecutarse automáticamente (por ejemplo, cuando se activa una vista) o activarse cuando un usuario ejecuta una acción declarada dentro del controlador. Los controladores implementados dentro de los módulos son recopilados automáticamente por XAF mediante  [reflexión](https://docs.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/reflection). Es por eso que las clases de Controller deben ser  _públicas_. Cuando se crea una ventana, se activan los controladores necesarios. Esto resulta en activar (hacer visibles) sus Acciones. Para obtener más información, consulte el tema  [Controladores](https://docs.devexpress.com/eXpressAppFramework/112621/ui-construction/controllers-and-actions/controllers?v=22.1).
    

Los controladores y las acciones son instrumentos que proporcionan características personalizadas en una aplicación XAF. En esta sección del tutorial, aprenderá cómo agregar acciones de diferentes tipos, implementar controladores sin acciones y modificar el comportamiento de controladores y acciones existentes, etc. Se recomienda que complete las lecciones que se enumeran a continuación, en orden.

-   [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)
-   [Agregar una acción parametrizada](https://docs.devexpress.com/eXpressAppFramework/112724/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-parametrized-action?v=22.1)
-   [Agregar una acción que muestre una ventana emergente](https://docs.devexpress.com/eXpressAppFramework/112723/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-that-displays-a-pop-up-window?v=22.1)
-   [Agregar una acción con selección de opción](https://docs.devexpress.com/eXpressAppFramework/112738/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-with-option-selection?v=22.1)
-   [Agregar una acción simple mediante un atributo](https://docs.devexpress.com/eXpressAppFramework/112731/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action-using-an-attribute?v=22.1)
-   [Configuración del editor de acceso](https://docs.devexpress.com/eXpressAppFramework/112729/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-editor-settings?v=22.1)
-   [Propiedades del control de cuadrícula de acceso](https://docs.devexpress.com/eXpressAppFramework/113165/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-grid-control-properties?v=22.1)



# Agregue una acción simple (.NET Framework)

>PROPINA
Para aplicaciones .**NET 6**, vea: [Agregar una acción simple (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402157/getting-started/in-depth-tutorial-blazor/extend-functionality/add-a-simple-action?v=22.1).

En esta lección, aprenderá a crear una acción simple. Para ello, se implementará un nuevo controlador de vistas y se le añadirá una nueva acción simple. Esta acción borrará todas las  **tareas rastreadas**  de un  **contacto**  específico.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implementar clases empresariales personalizadas y propiedades de referencia](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Establecer una relación de muchos a muchos](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)

View Controller es un descendiente de la clase  [ViewController](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController?v=22.1). Para agregar un controlador de vista que proporcione una acción simple, siga los pasos que se describen a continuación.

1.  Los  **controladores XAF**  |  **Controlador de vista**  La plantilla de Visual Studio facilita la adición de un controlador de vistas a la aplicación. En el  **Explorador de soluciones**, haga clic con el botón secundario en la carpeta  _Controllers_  del proyecto  _MySolution.Module_  y elija  **Agregar elemento DevExpress**  |  **Nuevo artículo...**  para invocar la  [Galería de plantillas](https://docs.devexpress.com/eXpressAppFramework/113455/installation-upgrade-version-history/visual-studio-integration/template-gallery?v=22.1). A continuación, seleccione  **View**  Controller, especifique  _ClearContactTasksController_  como nombre del nuevo elemento y haga clic en  **Agregar elemento**. Como resultado, obtendrá un archivo ClearContactTasksController_.cs (ClearContactTasksController.vb_) generado automáticamente con una sola declaración de View  _Controller_.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c60e169a-3964-425e-a9ed-0ec67e1d9398)

    
2.  El nuevo controlador se activará dentro de cualquier tipo de vista por defecto. Dado que la tarea de esta lección es borrar  **Tareas controladas**  en la vista de detalles de  **contacto**, se debe cambiar el comportamiento predeterminado. Haga clic con el botón secundario en  _MySolution.Module_  |  _Controladores_  | ClearContactTasksController_.cs (ClearContactTasksController__.vb_) y elija  **View Designer**  para invocar al diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6da9ab67-d843-4aa4-8b0e-be0d607565c7)

    
3.  En la ventana  **Propiedades**  del Controller, establezca la propiedad  **TargetViewType**  en  **DetailView**  y la propiedad  **TargetObjectType**  en  **MySolution.Module.BusinessObjects.Contact.**  Como resultado, el controlador solo se activará en los formularios de detalles de  **contacto**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/266a86f4-5a8d-4e86-90b0-69260010b0bf)

    
    >NOTA
    La misma personalización se puede hacer en el código, configurando la propiedad [`ViewController.TargetViewType`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewType?v=22.1) a [`ViewType.DetailView`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewType?v=22.1) y [`ViewController.TargetObjectType`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType?v=22.1) a **MySolution.Module.BusinessObjects.Contact** en el constructor del Controller. Si el valor de la propiedad se establece después de invocar el método  **InitializeComponent**, se reemplazará la configuración Designer.
    >Como alternativa, puede implementar el controlador genérico de vista de  [`ObjectViewController<ViewType, ObjectType>`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ObjectViewController-2?v=22.1) en lugar del `ViewController` y especificar el tipo de vista y objeto, para el que se debe activar este controlador,(https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ObjectViewController-2?v=22.1) en los parámetros genéricos.[](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController?v=22.1)
    
4.  A continuación, agregue  **SimpleAction**  a  **ClearContactTasksController**. En el  **DX.22.1: Sección Acciones XAF**  del  **Cuadro de herramientas**, arrastre  **SimpleAction**  al Diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/999e174a-d905-447b-bf81-cceb2088e5f1)

    
5.  En la ventana Propiedades de  **SimpleAction**, establezca las propiedades  **Name**  e  **ID**  en "ClearTasksAction", la propiedad  **Category**  en "View", la propiedad  **ImageName**  en "Action_Clear" y la propiedad  **Caption**  en "Clear Tasks". Establezca la propiedad  **ConfirmationMessage**  en "¿Está seguro de que desea borrar la lista de tareas?".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/503f8eaf-bf06-4d20-946c-d34d788a7a59)

    
    >NOTA
    La propiedad  **Category** especifica el grupo Acción al que pertenece la acción actual. Todas las acciones de un grupo se muestran secuencialmente en una interfaz de usuario.
    
    La propiedad  **Nombre de imagen** especifica el icono del botón Acción en la interfaz. Puede [utilizar una de las imágenes estándar](https://docs.devexpress.com/eXpressAppFramework/112745/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-standard-image?v=22.1) o [importar la suya propia](https://docs.devexpress.com/eXpressAppFramework/112744/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-custom-image?v=22.1)
    
6.  **Una acción simple**  está diseñada para ejecutar código específico cuando un usuario final hace clic en él. Para borrar la colección  **Tasks**  de la  **persona**  actual y actualizar la vista, implemente el controlador de eventos  **Execute**  de la acción. Cambie a la vista  **Eventos**  en la ventana  **Propiedades**, haga doble clic en el evento  **Ejecutar**  y agregue el código siguiente al controlador de eventos generado automáticamente.
    

    ```csharp
    using MySolution.Module.BusinessObjects;
    //...
    private void ClearTasksAction_Execute(Object sender, SimpleActionExecuteEventArgs e) {
        while(((Contact)View.CurrentObject).Tasks.Count > 0) {
            ((Contact)View.CurrentObject).Tasks.Remove(((Contact)View.CurrentObject).Tasks[0]);
        }
        ObjectSpace.SetModified(View.CurrentObject);
    }
    
    ```
    
7.  En ASP.NET aplicaciones de formularios Web Forms, hay dos modos para mostrar vistas detalladas: modo de vista y modo de edición. La acción  **ClearTasks**  solo debería estar disponible cuando se muestre una vista detallada en modo de edición, así que compruebe si el modo de edición de la vista detallada actual ha cambiado. Si ha cambiado al modo de visualización, la acción debe estar desactivada. Para implementar esto, debe revisar los siguientes conceptos.
    
    -   La vista detallada expone el evento  [DetailView.ViewEditModeChanged](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.DetailView.ViewEditModeChanged?v=22.1), que se desencadena cuando se cambia el modo de edición.
    -   La acción expone la propiedad  [ActionBase.Enabled](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.Enabled?v=22.1), que no es una simple propiedad booleana, sino una colección de pares clave/valor utilizada para determinar el estado habilitado de la acción. Este tipo de recopilación se utiliza porque puede haber muchos factores que influyen en el estado de la acción, y una aplicación XAF debe tenerlos todos en cuenta.
    
    Por lo tanto, controle el evento  **ViewEditModeChanged**  y modifique la colección  **Enabled**  de la acción en función del modo de edición actual. Para ello, vuelva al Diseñador del controlador y haga doble clic en el evento  **Activated**  en la vista Eventos de la ventana Propiedades. Reemplace el controlador de eventos generado automáticamente por el código siguiente.
    

    ```csharp
    private void ClearContactTasksController_Activated(object sender, EventArgs e) {
        // Enables the ClearTasks Action if the current Detail View's ViewEditMode property
        // is set to ViewEditMode.Edit.
        ClearTasksAction.Enabled.SetItemValue("EditMode", 
            ((DetailView)View).ViewEditMode == ViewEditMode.Edit);
        ((DetailView)View).ViewEditModeChanged += 
            new EventHandler<EventArgs>(ClearContactTasksController_ViewEditModeChanged);
    }
    // Manages the ClearTasks Action enabled state.
    void ClearContactTasksController_ViewEditModeChanged(object sender, EventArgs e) {
        ClearTasksAction.Enabled.SetItemValue("EditMode", 
            ((DetailView)View).ViewEditMode == ViewEditMode.Edit);
    }
    
    ```
    

Para ver el resultado, ejecute la aplicación WinForms o ASP.NET formularios Web Forms y haga lo siguiente.

1.  Abra un formulario de detalle para cualquier objeto.
2.  Haga clic en el botón  **Borrar tareas**, que representa la acción que ha implementado. Aparecerá un mensaje de confirmación como se muestra en la imagen a continuación.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/3548daf7-27e5-40e4-a505-847eba1bbb94)

    
3.  Haga clic en  **Sí**  (en una aplicación de WinForms) o en  **Aceptar**  (en una aplicación de formularios Web Forms ASP.NET). Se vaciarán todas las  **tareas rastreadas**  del  **contacto**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c9f5bb6c-d66a-4bfd-8a96-4cb54bb9182f)

    

>NOTA
Aunque en este tema se explica cómo crear un controlador mediante el diseñador, un controlador  es una clase que también se puede escribir manualmente, como se muestra en el tema Agregar un [controlador en](https://docs.devexpress.com/eXpressAppFramework/112621/ui-construction/controllers-and-actions/controllers?v=22.1#add-a-controller-in-code)  código  .

­

Si necesita colocar una acción dentro de la Vista detallada, consulte el tema  [Cómo: Incluir una acción en un diseño de vista de detalle](https://docs.devexpress.com/eXpressAppFramework/112816/ui-construction/view-items-and-property-editors/include-an-action-to-a-detail-view-layout?v=22.1).

Puede ver el código utilizado en esta lección en  _MySolution.Module_  |  _Controladores_  | ClearContactTasksController.cs archivo (_ClearContactTasksController.vb_) de la demostración principal instalada con XAF.  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Agregue una acción parametrizada (.NET Framework)


>PROPINA
Para aplicaciones .**NET 6**, vea: [Agregar una acción parametrizada (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402155/getting-started/in-depth-tutorial-blazor/extend-functionality/add-a-parametrized-action?v=22.1).

En esta lección, aprenderá a agregar una acción parametrizada. Estos tipos de acciones son ligeramente más complejas que las acciones simples que aprendió en la lección anterior. La acción parametrizada proporciona un editor, de modo que un usuario final puede introducir un valor antes de la ejecución. En esta lección, se implementará un nuevo controlador de vista y se le agregará una nueva acción parametrizada. Esta acción buscará un objeto  **DemoTask**  por su valor de propiedad  **Subject**  y mostrará el objeto encontrado en un formulario de detalle.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Inicializar una propiedad después de crear un objeto](https://docs.devexpress.com/eXpressAppFramework/112834/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/initialize-a-property-after-creating-an-object-xpo?v=22.1)
>-   [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)

-   Agregue un nuevo controlador de View al proyecto  _MySolution.Module_, como se describe en la lección  [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1). Asígnele  _el nombre FindBySubjectController_.
-   Haga clic con el botón derecho en el recién creado  _MySolution.Module_  |  _Controladores_  | FindBySubjectController.cs (_FindBySubjectController.vb_) y elija  **Diseñador de vistas**  para invocar al diseñador.  Arrastre  **ParametrizedAction**  desde DX**.22.1: ficha Caja de herramientas de acciones XAF**  al diseñador. En la ventana  **Propiedades de ParametrizedAction**, establezca las propiedades  **Name**  e  **ID**  en "FindBySubjectAction" y establezca la propiedad  **Caption**  en "Buscar tarea por tema".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/08763199-80df-471b-a6f5-031dceb423c1)

    
-   Para activar  **FindBySubjectController**  con su  **FindBySubjectAction**  solo para vistas de lista de DemoTask, establezca la propiedad ViewController.TargetViewType en "ListView" y establezca  [ViewController.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewType?v=22.1)  en  **MySolution.Module.DemoTask**  a través de la ventana Propiedades del controlador[.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType?v=22.1)  Para activar el Controller solo para vistas raíz, establezca la propiedad  [ViewController.TargetViewNesting](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewNesting?v=22.1)  en  **Root**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/4415ba1c-08b8-4d2e-acd9-88e9e3344274)

    
-   A continuación, debe controlar el evento  [ParametrizedAction.Execute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ParametrizedAction.Execute?v=22.1)  de la acción para implementar la funcionalidad de búsqueda. Enfoque la acción  **FindBySubject**  en el diseñador del controlador. Cambie a la vista Eventos en la ventana  **Propiedades**. Haga doble clic en el evento  **Execute**, reemplace el código del controlador de eventos generado automáticamente por el siguiente.
    

    ```csharp
    private void FindBySubjectAction_Execute(object sender, ParametrizedActionExecuteEventArgs e) {
        IObjectSpace objectSpace = Application.CreateObjectSpace(((ListView)View).ObjectTypeInfo.Type);
        string paramValue = e.ParameterCurrentValue as string;
        object obj = objectSpace.FindObject(((ListView)View).ObjectTypeInfo.Type,
            CriteriaOperator.Parse(string.Format("Contains([Subject], '{0}')", paramValue)));
        if(obj != null) {
            DetailView detailView = Application.CreateDetailView(objectSpace, obj);
            detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
            e.ShowViewParameters.CreatedView = detailView;
        }
    }
    
    ```
    
    El evento  **Execute**  se genera después de escribir un parámetro en el editor de la acción. El controlador anterior busca el objeto  **DemoTask**, cuyo asunto contiene el texto especificado como parámetro, e invoca el formulario de detalle para este objeto.
    
    >NOTA
    >-   Para buscar un objeto, necesitará un [espacio de objetos](https://docs.devexpress.com/eXpressAppFramework/113707/data-manipulation-and-business-logic/object-space?v=22.1). El espacio de objetos siempre se utiliza cuando se manipulan objetos persistentes. Para utilizar el espacio de objetos en esta tarea, créelo con la [aplicación Xaf.Método Crearespacio de objetos](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.CreateObjectSpace.overloads?v=22.1). Dado que una aplicación es accesible en casi cualquier lugar del código, su método  **Crearespacio de objetos** siempre es útil.
    >-   Para utilizar [IObjectSpace.Método FindObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.IObjectSpace.FindObject.overloads?v=22.1),  pase el tipo del objeto buscado, junto con sus criterios. Para obtener el tipo de objetos representados en la vista de lista actual, utilice la información de tipo de objeto de la vista (consulte [Ver.Información del tipode objeto](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.View.ObjectTypeInfo?v=22.1)). Para generar un criterio, cree un objeto BinaryOperator pasando componentes criteria como parámetros del constructor. Para obtener información adicional, consulte la sección  [Consulta de un almacén de datos](https://docs.devexpress.com/XPO/2034/query-and-shape-data?v=22.1) en la documentación de XPO.
    >-   Para obtener el valor especificado por un usuario final en el editor que representa la acción Buscarporasunto, use el parámetro  [ParametrizedActionExecuteEventArgs.ParameterCurrentValue del controlador de eventos.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventArgs.ParameterCurrentValue?v=22.1)
    >-   Para mostrar el objeto encontrado en una vista detallada independiente, cree la vista a través de la [aplicación Xaf.Creeel método Detail](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.CreateDetailView.overloads?v=22.1)  View  y asígnelo a Show [ViewParameters.Se creó](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ShowViewParameters.CreatedView?v=22.1)  la propiedad View del parámetro  [ActionBaseEventArgs.ShowViewParameters del controlador de eventos.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBaseEventArgs.ShowViewParameters?v=22.1)  Mostrar parámetros de vista se puede inicializar en el controlador de eventos  **Ejecutar**  de una acción  de cualquier tipo, por lo que siempre puede mostrar una vista después de la ejecución de la acción. Para obtener información adicional sobre cómo mostrar una vista en una ventana independiente, consulte el tema  [Formas de mostrar una vista](https://docs.devexpress.com/eXpressAppFramework/112803/ui-construction/views/ways-to-show-a-view/ways-to-show-a-view?v=22.1).
    >-   Como ya habrás notado, el objeto  [Xaf Application](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication?v=22.1) es útil cuando necesitas crear una vista de lista, una vista de detalle, un espacio de objetos, etc. El objeto  **XAFApplication** es accesible desde muchas ubicaciones de una aplicación XAF. En Controllers, se puede acceder a través del [Controller.Propiedad de aplicación](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Controller.Application?v=22.1).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Seleccione el elemento  **Tarea**  en el control de navegación. Busque el editor  **Buscar tarea por tema**  que representa la acción que ha implementado. Escriba una palabra de la propiedad  **Subject**  de un objeto DemoTask existente en este editor. Presione la tecla  **Intro**  o haga clic en  **Buscar tarea por asunto**. Se mostrará un formulario detallado con este objeto.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2ad560d7-91df-48c8-847d-ee953adf15bd)

    

Puede ver el código que se muestra aquí en  _MySolution.Module_  |  _Controladores_  | FindBySubjectController_.cs (FindBySubjectController__.vb_) de la demostración principal instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Agregar una acción que muestre una ventana emergente (.NET Framework)

>PROPINA
Para aplicaciones .**NET 6**, vea: [Agregar una acción que muestre una ventana emergente (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402158/getting-started/in-depth-tutorial-blazor/extend-functionality/add-an-action-that-displays-a-pop-up-window?v=22.1).

En esta lección, aprenderá a crear una acción que muestre una ventana emergente. Este tipo de acción es útil cuando desea que un usuario introduzca varios parámetros en un cuadro de diálogo emergente antes de ejecutar una acción.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Establecer una relación de muchos a muchos](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)
>-   [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)

## Crear un controlador y una ventana emergente "Mostrar Acción"

-   Agregue un nuevo controlador de View al proyecto  **MySolution.Module**, como se describe en la lección  [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1). Asígnele  _el nombre PopupNotesController_.
-   Haga clic con el botón secundario en  _MySolution.Module_  |  _Controladores_  | PopupNotesController.cs (_PopupNotesController.vb_) y elija  **Diseñador de vistas**  para invocar al diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b2b3e0e3-30d0-4490-b731-278c92df6238)

    
-   Arrastre el componente  **PopupWindowShowAction**  desde DX**.22.1: ficha Acciones XAF**  al Diseñador. En la ventana  **emergente WindowShowAction1**  "Propiedades", establezca las propiedades  **Name**  e  **Id**  en "ShowNotesAction" y establezca la propiedad  **Caption**  en "Show Notes". Establezca la propiedad  **Category**  en "Editar". Esta propiedad especifica el grupo Acción al que pertenece la Acción actual. Todas las acciones dentro de un solo grupo se muestran juntas secuencialmente en una interfaz de usuario.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/75f1b4dd-7baa-442f-a413-7e029cd288cc)

    
-   Para activar  **PopupNotesController**  solo para vistas detalladas de DemoTask, establezca la propiedad ViewController.TargetObjectType del controlador en  **MySolution.Module.DemoTask**  y establezca  [ViewController.TargetViewType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewType?v=22.1)  en  [DetailView.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType?v=22.1)
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/f43c8c06-f43b-4ba9-a8f3-c4f17a9b0cdb)

    

## Especificar la vista de lista emergente

Enfoque el componente  **ShowNotesAction**. En la ventana Propiedades, cambie a la vista  _Eventos_. Haga doble clic en el evento  **CustomizePopupWindowParams**, agregue la directiva "**using**" ("**Imports**" en VB) según su ORM y reemplace el código del controlador de eventos generado automáticamente por el código siguiente.



```csharp
using DevExpress.Persistent.BaseImpl; //For XPO
// ...
private void ShowNotesAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
    IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Note));
    string noteListViewId = Application.FindLookupListViewId(typeof(Note));
    CollectionSourceBase collectionSource = Application.CreateCollectionSource(objectSpace, typeof(Note), noteListViewId);
    e.View = Application.CreateListView(noteListViewId, collectionSource, true);
    //Optionally customize the window display settings.
    //e.Size = new System.Drawing.Size(600, 400);
    //e.Maximized = true;
    //e.IsSizeable = false;
}

```


Para obtener más información sobre este evento, consulte el tema  [`PopupWindowShowAction.CustomizePopupWindowParams`.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.PopupWindowShowAction.CustomizePopupWindowParams?v=22.1)  El código anterior creará la vista de lista de  **notas**  al generar la ventana emergente.

Para crear una vista de lista, vuelva a utilizar el objeto  [`XafApplication`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication?v=22.1)  (como hizo en la lección  [anterior](https://docs.devexpress.com/eXpressAppFramework/112724/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-parametrized-action?v=22.1)). En el código anterior, XafApplication le ayuda a encontrar el ID de la vista de lista requerida en el  [modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112579/ui-construction/application-model-ui-settings-storage?v=22.1). Tenga en cuenta que un origen de colección para la vista de lista se crea en un  [espacio de objetos](https://docs.devexpress.com/eXpressAppFramework/113707/data-manipulation-and-business-logic/object-space?v=22.1)  independiente. Para crear el espacio de objetos, utilice XafApplication de nuevo.

## Manejar el evento Execute

En el Diseñador del Controller, cambie a la vista  _Eventos_  en la ventana  **Propiedades**  con las propiedades de la acción. Haga doble clic en el evento  **Execute**, agregue la directiva "**using**" ("**Imports**" en VB) y reemplace el código del controlador de eventos generado automáticamente por el código siguiente.



```csharp
using MySolution.Module.BusinessObjects;
// ...
private void ShowNotesAction_Execute(object sender, PopupWindowShowActionExecuteEventArgs e) {
    DemoTask task = (DemoTask)View.CurrentObject;
    foreach(Note note in e.PopupWindowViewSelectedObjects) {
        if(!string.IsNullOrEmpty(task.Description)) {
            task.Description += Environment.NewLine;
        }
        task.Description += note.Text;
    }
    if(((DetailView)View).ViewEditMode == ViewEditMode.View) {
        View.ObjectSpace.CommitChanges();
    }
}

```

El evento  **Execute**  se genera al hacer clic en el botón  **Aceptar**  de la ventana emergente. Cuando se ejecuta el controlador anterior, el valor de la propiedad  **Text**  del objeto  **Note**  seleccionado se anexará al valor de la propiedad  **Task.Description.**

En este código, obtenga acceso al objeto seleccionado en la ventana emergente mediante el parámetro  [PopupWindowShowActionExecuteEventArgs.PopupWindowViewSelectedObjects](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventArgs.PopupWindowViewSelectedObjects?v=22.1)  del controlador de eventos.

Para actualizar el editor que representa la propiedad  **Description**  modificada, busque primero su  **PropertyEditor**  en la colección CompositeView.Items de la vista actual mediante el método  [CompositeView.FindItem.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.CompositeView.FindItem(System.String)?v=22.1)  [](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.CompositeView.Items?v=22.1)Para actualizar el valor mostrado por el editor del Editor de propiedades, llame al método  [PropertyEditor.ReadValue.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.PropertyEditor.ReadValue?v=22.1)

En ASP.NET aplicaciones de formularios Web Forms, las vistas detalladas se muestran en los modos  **Ver**  y  **Editar**. Cuando se activa la acción  **ShowNotes**  para una vista detallada de DemoTask que está en modo de vista, los cambios realizados en la propiedad  **DemoTask.Description**  deben guardarse en la base  **de**  datos. Para ello, se llama al método  **CommitChanges**  del  **ObjectSpace**  de la vista actual. Cuando se utiliza la acción  **ShowNotes**  en una vista de detalles de DemoTask que está en modo  **de edición**, los cambios se pueden guardar o revertir a través de las acciones integradas correspondientes.

## Agregar notas a la interfaz de usuario

-   Para agregar la clase empresarial  **Note**  al proceso de construcción de la interfaz de usuario, agréguela al modelo de aplicación.
-   Para agregar la clase de negocio  **Note**  desde la  [biblioteca de clases empresariales](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1), utilice el  [Diseñador de módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). Haga doble clic en el archivo Module.cs (Module_.vb_) dentro del proyecto  _MySolution.Module._  La sección  **Tipos exportados**  del diseñador enumera las clases de negocio que se pueden agregar.  **Buscar los ensamblados a los que se hace referencia**  |  **DevExpress.Persistent.BaseImpl.Xpo.v22.1**  |  **Nodo Nota**. Seleccione este nodo y pulse la  **barra espaciadora**, o haga clic con el botón derecho en él y elija  **Usar tipo en aplicación en**  el menú contextual invocado.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/9b28fd78-5470-47c3-8199-b07bffd7904e)

    
-   **Compile**  el proyecto.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/487187c9-9314-45d2-a374-4bd521df6ab6)

    
    >NOTA
    Para crear objetos Note, debe agregar el elemento  **Note** a los elementos de la  **nueva** acción. Para ello, realice los pasos que se muestran en la lección  [Agregar un elemento a la nueva acción](https://docs.devexpress.com/eXpressAppFramework/112751/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-new-action?v=22.1).
    
    Para acceder a los objetos Note existentes  , agregue el elemento  **Note**  a los elementos de  la acción  **Mostrarelemento de navegación (mostrados por el control de navegación**). Para ello, realice los pasos que se muestran en la lección  [Agregar un elemento al control de navegación](https://docs.devexpress.com/eXpressAppFramework/112749/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-navigation-control?v=22.1).
    

## Resultado

Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Cree varios objetos  **Note**  mediante la acción  **Nueva**. Seleccione el elemento  **Tarea**  en el control de navegación. Haga doble clic en uno de los objetos  **Task**  enumerados. En el formulario de detalles invocado, busque el botón de la barra de herramientas  **Mostrar notas**  que representa la acción implementada. Haga clic en este botón, que invocará una ventana emergente. Seleccione un objeto  **Note**  de la lista y haga clic en  **Aceptar**. Compruebe que se ha cambiado el valor de la propiedad  **Task.Description.**

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/20570157-e992-41e8-9505-8678c36ab871)


>PROPINA
Para obtener un ejemplo de cómo crear y mostrar una vista detallada, consulte el tema  [Cómo: Crear y mostrar una vista detallada del objeto seleccionado en una ventana emergente](https://docs.devexpress.com/eXpressAppFramework/118760/ui-construction/ways-to-access-ui-elements-and-their-controls/how-to-create-and-show-a-detail-view-of-the-selected-object-in-a-popup-window?v=22.1).

Puede ver el código mostrado en este tutorial en  _MySolution.Module_  |  _Controladores_  | PopupNotesController.cs archivo (_PopupNotesController.vb_) de la demo principal instalada con XAF.  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Agregar una acción con selección de opción (.NET Framework)

>PROPINA
Para aplicaciones .**NET 6**, vea: [Agregar una acción con selección de opción (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402159/getting-started/in-depth-tutorial-blazor/extend-functionality/add-an-action-with-option-selection?v=22.1).

En esta lección, aprenderá a crear una acción con soporte para la selección de opciones. Se implementará un nuevo controlador de vistas y se le agregará una  **acción SingleChoiceAction**. A través de esta acción, las propiedades  **Task.Priority**  y  **Task.Status**  se establecerán en el valor seleccionado por un usuario final.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)
>-   [Agregar una acción que muestre una ventana emergente](https://docs.devexpress.com/eXpressAppFramework/112723/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-that-displays-a-pop-up-window?v=22.1)

-   Agregue un nuevo controlador de View al proyecto  _MySolution.Module_, como se describe en la lección  [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1). Asígnele  _el nombre TaskActionsController_.
-   Haga clic con el botón secundario en  _MySolution.Module_  |  _Controladores_  | TaskActionsController.cs (_TaskActionsController.vb_) y elija  **Diseñador de vistas**  para invocar al diseñador.  Dentro del  **DX.22.1: Pestaña Caja de herramientas de acciones XAF**, navegue hasta  **SingleChoiceAction**  y arrástrela al diseñador. En la ventana  **Propiedades de SingleChoiceAction**, establezca las propiedades  **Name**  e  **ID**  en "**SetTaskAction**", la propiedad  **Caption**  en "Set Task" y la propiedad  **Category**  en "Edit". Establezca la propiedad  **ItemType**  en "ItemIsOperation".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/4613f1db-86b1-4d5e-92ce-549359415eac)

    
    NOTA
    
    -   La [`ActionBase.Category`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.Category?v=22.1) especifica el grupo Acción al que pertenece la acción actual. Todas las acciones de un solo grupo se muestran juntas en una interfaz de usuario.
    -   La propiedad  [`SingleChoiseAction.ItemType` ](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.SingleChoiceAction.ItemType?v=22.1) especifica un modo de presentación para los elementos de la acción. Con el valor "El elemento es operación" establecido en esta propiedad, los elementos de la acción no se mostrarán mediante elementos de casilla de verificación, como lo serían si establece el valor "ItemIsMode".
    
-   Para activar  **TaskActionsController**  sólo para objetos DemoTask, establezca la propiedad  [ViewController.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType?v=22.1)  del controlador en  **MySolution.Module.BusinessObjects.DemoTask.**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/3e278b63-919b-4428-a19b-92000e58ace0)

    
-   Para rellenar la acción con elementos, rellene la colección  [ChoiceActionBase.Items](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ChoiceActionBase.Items?v=22.1)  de la acción en el constructor del controlador.

    ```csharp
    using DevExpress.ExpressApp;
    using DevExpress.ExpressApp.Actions;
    using DevExpress.ExpressApp.Utils;
    using DevExpress.Persistent.Base.General;
    using MySolution.Module.BusinessObjects;
    using System;
    
    namespace MySolution.Module.Controllers {
        public partial class TaskActionsController : ViewController {
            private ChoiceActionItem setPriorityItem;
            private ChoiceActionItem setStatusItem;
            public TaskActionsController() {
                InitializeComponent();
                setPriorityItem =
                new ChoiceActionItem(CaptionHelper.GetMemberCaption(typeof(DemoTask), "Priority"), null);
                SetTaskAction.Items.Add(setPriorityItem);
                FillItemWithEnumValues(setPriorityItem, typeof(Priority));
                setStatusItem =
                new ChoiceActionItem(CaptionHelper.GetMemberCaption(typeof(DemoTask), "Status"), null);
                SetTaskAction.Items.Add(setStatusItem);
                FillItemWithEnumValues(setStatusItem, typeof(TaskStatus));
            }
            private void FillItemWithEnumValues(ChoiceActionItem parentItem, Type enumType) {
                foreach(object current in Enum.GetValues(enumType)) {
                    EnumDescriptor ed = new EnumDescriptor(enumType);
                    ChoiceActionItem item = new ChoiceActionItem(ed.GetCaption(current), current);
                    item.ImageName = ImageLoader.Instance.GetEnumValueImageName(current);
                    parentItem.Items.Add(item);
                }
            }
        }
    }
    
    ```
    
    El código anterior organiza los elementos de la colección Elementos de la acción como un árbol. El primer nivel se forma a partir de los elementos cuyos títulos corresponden a los nombres de propiedad DemoTask.Priority y  **DemoTask.Status.**  El segundo nivel se forma a partir de los valores de enumeración  **Priority**  y  **Status**. El objeto  [CaptionHelper](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Utils.CaptionHelper?v=22.1)  devuelve los títulos de elemento de primer nivel; y los títulos de elemento de segundo nivel son devueltos por un objeto  [EnumDescriptor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Utils.EnumDescriptor?v=22.1). Esto resulta útil cuando las propiedades  **Priority**  y  **Status**  y los valores de enumeración correspondientes se localizan mediante el modelo de aplicación.
    
    >NOTA
    Si crea los elementos de una acción en el constructor del controlador, se crearán una vez para cada ventana. Esto puede ser ventajoso, por ejemplo, si la vista de la ventana se cambia a menudo (por  ejemplo, si esta es la ventana principal y el modo de interfaz de documentos múltiples (MDI) no está activado). Como alternativa, puede agregar elementos en el método reemplazado **Alactivar**. En este caso, los elementos no se crearán hasta que se muestre la vista necesaria, pero se crearán cada vez que se muestre esta vista.
    
    El fragmento de código siguiente establece las imágenes asociadas con los valores de enumeración  **Priority**  y  **TaskStatus**  para los elementos de la  **acción SetTask**. Tenga en cuenta que la enumeración  **TaskStatus**  se declara en la biblioteca de clase empresarial y ya tiene imágenes asignadas a sus valores. Para asignar imágenes a los valores de enumeración  **Priority**  que declaró en el archivo DemoTask_.cs (DemoTask__.vb_), decórelas con el atributo  [ImageNameAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ImageNameAttribute?v=22.1).
    

    
    ```csharp
    public enum Priority {
        [ImageName("State_Priority_Low")]
        Low = 0,
        [ImageName("State_Priority_Normal")]
        Normal = 1,
        [ImageName("State_Priority_High")]
        High = 2
    }
    
    ```
    
    >NOTA
    Las imágenes **State_Priority_Low**, **State_Priority_Normal** y **State_Priority_High** se incluyen en la biblioteca de imágenes estándar suministrada con XAF. Para aprender a usar imágenes personalizadas, consulte la lección  [Asignar una imagen personalizada](https://docs.devexpress.com/eXpressAppFramework/112744/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-custom-image?v=22.1).
    
    Al rellenar la [Base de acciónde elección.Colección](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ChoiceActionBase.Items?v=22.1)  de elementos en el constructor de un  Controller Como se muestra en el código anterior, puede establecer un nombre de imagen, un acceso directo y un título localizado para los elementos agregados mediante el diseño  de **acciones**  del  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112830/installation-upgrade-version-history/visual-studio-integration/model-editor?v=22.1) | **Acciones** | **_<Acción>_** | **Nodo Elementos de acciónde elección**. Para obtener información sobre cómo invocar y usar el Editor de modelos, consulte la  [primera lección de la sección Personalización de la interfaz de usuario](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1). Sin embargo, es posible que tenga que rellenar la colección  **Items** en un Controller de [Controller.Controlador de eventos activado](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Controller.Activated?v=22.1),  donde puede acceder a la aplicación actual, vista, etc. En este caso, los elementos agregados a la colección no se cargarán en el Editor de modelos.
    
-   Para implementar el código que se debe ejecutar cuando un usuario final elige el elemento de la acción, controle el evento  [SingleChoiceAction.Execute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.SingleChoiceAction.Execute?v=22.1)  como se muestra a continuación.
    

    
    ```csharp
    using DevExpress.ExpressApp;
    using DevExpress.ExpressApp.Actions;
    using DevExpress.ExpressApp.Editors;
    using DevExpress.ExpressApp.Utils;
    using DevExpress.Persistent.Base.General;
    using MySolution.Module.BusinessObjects;
    using System;
    using System.Collections;
    
    namespace MySolution.Module.Controllers {
        public partial class TaskActionsController : ViewController {
            //... 
            public TaskActionsController() {
                //...
                SetTaskAction.Execute += SetTaskAction_Execute;
            }
            private void SetTaskAction_Execute(object sender, SingleChoiceActionExecuteEventArgs e) {
                IObjectSpace objectSpace = View is ListView ?
                    Application.CreateObjectSpace(typeof(DemoTask)) : View.ObjectSpace;
                ArrayList objectsToProcess = new ArrayList(e.SelectedObjects);
                if(e.SelectedChoiceActionItem.ParentItem == setPriorityItem) {
                    foreach(Object obj in objectsToProcess) {
                        DemoTask objInNewObjectSpace = (DemoTask)objectSpace.GetObject(obj);
                        objInNewObjectSpace.Priority = (Priority)e.SelectedChoiceActionItem.Data;
                    }
                } else
                    if(e.SelectedChoiceActionItem.ParentItem == setStatusItem) {
                    foreach(Object obj in objectsToProcess) {
                        DemoTask objInNewObjectSpace = (DemoTask)objectSpace.GetObject(obj);
                        objInNewObjectSpace.Status = (TaskStatus)e.SelectedChoiceActionItem.Data;
                    }
                }
                if(View is DetailView && ((DetailView)View).ViewEditMode == ViewEditMode.View) {
                    objectSpace.CommitChanges();
                }
                if(View is ListView) {
                    objectSpace.CommitChanges();
                    View.ObjectSpace.Refresh();
                }
            }
        }
    }   
    
    ```
    
    Como puede ver en el código anterior, se obtiene acceso al elemento seleccionado actualmente en la lista desplegable de  **SetTaskAction**  a través del parámetro  [SingleChoiceActionExecuteEventArgs.SelectedChoiceActionItem](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventArgs.SelectedChoiceActionItem?v=22.1)  del controlador de eventos. Para asignar un valor elegido a una propiedad de un objeto seleccionado en la vista actual, puede utilizar un  [espacio de objetos](https://docs.devexpress.com/eXpressAppFramework/113707/data-manipulation-and-business-logic/object-space?v=22.1). Cuando se utiliza  **SetTaskAction**  en una vista detallada, el  **espacio de objetos**  de la vista se utiliza para manipular el objeto actual. Cuando se utiliza la acción en una vista de lista, se crea un nuevo  **ObjectSpace**  mediante el método  [XafApplication.CreateObjectSpace.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.CreateObjectSpace.overloads?v=22.1)  Este  **ObjectSpace**  ayuda a manipular los objetos seleccionados de la vista.
    
    >NOTA
    Cree un **espacio de**  objetos independiente  cuando vaya a modificar varios objetos que se muestran actualmente. Este enfoque mejora el rendimiento, ya que los eventos del control de cuadrícula no se activan en cada cambio de objeto. En el código anterior, se crea un nuevo **espacio de objetos**  cuando la vista  actual es la vista de lista.
    
    En ASP.NET aplicaciones de formularios Web Forms, las vistas detalladas se muestran en los modos Ver y Editar. Cuando  **se activa SetTaskAction**  para una vista detallada de DemoTask en modo de vista, los cambios realizados en la propiedad  **DemoTask.Priority**  deben guardarse en la base de datos.  Para ello, se llama al método  [BaseObjectSpace.CommitChanges](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.BaseObjectSpace.CommitChanges?v=22.1)  del  [View.ObjectSpace](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.View.ObjectSpace?v=22.1)  de la vista actual. La misma técnica se utiliza cuando  **se activa SetTaskAction**  para una vista de lista  **DemoTask**. Sin embargo, cuando se utiliza  **SetTaskAction**  en una vista de detalles de  **DemoTask**  en modo de edición, los cambios se pueden guardar o revertir mediante las acciones integradas correspondientes.
    
-   La propiedad  **Priority**  o  **Status**  se cambiará para los objetos seleccionados actualmente. Sin embargo, el editor de cuadrícula utilizado en ASP.NET aplicaciones de formularios Web Forms no tiene objetos seleccionados hasta que un usuario final selecciona un objeto manualmente. Por lo tanto, deshabilite la acción cuando no haya objetos seleccionados. Para ello, establezca la propiedad  [ActionBase.SelectionDependencyType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.SelectionDependencyType?v=22.1)  de la acción en  **RequireMultipleObjects**. La acción sólo estará disponible cuando se seleccionen uno o más objetos. Para especificar esta propiedad, utilice la ventana  **Propiedades**.
-   Ejecute la aplicación de formularios Windows Forms o ASP.NET formularios Web Forms. Seleccione el elemento  **Tarea**  en el control de navegación. Se mostrará la acción  **Establecer tarea**. Seleccione uno o más objetos  **Tarea**  en la Vista Lista de tareas y seleccione un elemento en la lista desplegable Acción. Se modificará la propiedad  **Priority**  o  **Status**  de los objetos Task seleccionados.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/347efad7-0b37-4d50-892e-03de0ec220d4)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b1401605-2b24-4ffd-88ae-df9c031470c0)

    

Puede ver el código que se muestra aquí en  _MySolution.Module_  |  _Controladores_  | Archivo TaskActionsController_.cs (TaskActionsController__.vb_) de la demo principal instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .

