[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/blob/master/README.en.md)

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


# Configuración del editor de acceso

En este tema se muestra cómo acceder a los editores en una vista detallada mediante un controlador de  [vista](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1). Este controlador busca en la vista de detalles  **de contacto**  un editor de propiedades de cumpleaños que enlace datos a un control y especifica que el control debe mostrar el calendario de interfaz  **de**  usuario táctil en su menú desplegable.

>NOTA
Recomendamos revisar los siguientes temas antes de continuar:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)

## Acceder a la configuración del editor en una aplicación de formularios de Windows

-   Agregue un controlador de vista denominado "WinDateEditCalendarController" al proyecto  _MySolution.Module.Win_  como se describe en la lección  [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  (pasos 1-3). Cambie a la vista de código. Derive el nuevo controlador de  [ObjectViewController<ViewType, ObjectType>](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ObjectViewController-2?v=22.1):
    

    
    ```csharp
    using DevExpress.ExpressApp;
    using MySolution.Module.BusinessObjects;
    
    namespace MySolution.Module.Win.Controllers {
        public partial class WinDateEditCalendarController : ObjectViewController<DetailView, Contact> {
            public WinDateEditCalendarController() {
                InitializeComponent();
            }
            // ...
        }
    }
    
    ```
    
-   Reemplace el método  **OnActivated**. Utilice el método  [DetailViewExtensions.CustomizeViewItemControl(DetailView, Controller, Action<ViewItem>, String[])](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.DetailViewExtensions.CustomizeViewItemControl(DetailView--Controller--Action-ViewItem---String--)?v=22.1)  para personalizar el control del  [elemento](https://docs.devexpress.com/eXpressAppFramework/112612/ui-construction/view-items-and-property-editors?v=22.1)  Vista  **de cumpleaños**.
    

El código siguiente muestra  **WinDateEditCalendarController**:


```csharp
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.XtraEditors;
using MySolution.Module.BusinessObjects;

namespace MySolution.Module.Win.Controllers {
    public partial class WinDateEditCalendarController : ObjectViewController<DetailView, Contact> {
        public WinDateEditCalendarController() {
            InitializeComponent();
        }
        protected override void OnActivated() {
            base.OnActivated();
            View.CustomizeViewItemControl(this, SetCalendarView, nameof(Contact.Birthday));
        }
        private void SetCalendarView(ViewItem viewItem) {
            DateEdit dateEdit = (DateEdit)viewItem.Control;
            dateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
        }
    }
}

```

Ejecute la aplicación WinForms y abra la Vista de detalles de  **contacto**. El editor de  **cumpleaños**  muestra un menú desplegable de calendario táctil.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c94a3b87-ae23-4885-af4a-8a6c961a5101)


>PROPINA
Este enfoque no es aplicable a los [editores locales](https://docs.devexpress.com/eXpressAppFramework/113249/ui-construction/views/list-view-edit-modes?v=22.1)  de la vista de lista. Para personalizar estos editores, siga uno de estos procedimientos:

-   Utilice un editor de propiedades  personalizado como se muestra en el tema  [Cómo: Personalizar un editor de propiedades integrado (formularios de Windows](https://docs.devexpress.com/eXpressAppFramework/113104/ui-construction/view-items-and-property-editors/property-editors/customize-a-built-in-property-editor-winforms?v=22.1)).
-   Obtener acceso a los eventos y propiedades del control Editor de listas como se describe en el artículo  [Propiedades del control de cuadrícula de acceso](https://docs.devexpress.com/eXpressAppFramework/113165/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-grid-control-properties?v=22.1).

## Configuración del editor de acceso en una aplicación ASP.NET  Web Forms

-   Agregue un controlador de vistas denominado "_WebDateEditCalendarController_" al proyecto  _MySolution.Module.Web_  como se describe en el tema  [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  (pasos 1-3). Cambie a la vista de código. Derive el nuevo controlador de  [ObjectViewController<ViewType, ObjectType>](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ObjectViewController-2?v=22.1):
    

    
    ```csharp
    using DevExpress.ExpressApp;
    using MySolution.Module.BusinessObjects;
    
    namespace MySolution.Module.Web.Controllers {
        public partial class WebDateEditCalendarController : ObjectViewController<DetailView, Contact> {
            public WebDateEditCalendarController() {
                InitializeComponent();
            }
            // ...
        }
    }
    
    ```
    
-   Reemplace el método  **OnActivated**. Utilice el método  [DetailViewExtensions.CustomizeViewItemControl(DetailView, Controller, Action<ViewItem>, String[])](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.DetailViewExtensions.CustomizeViewItemControl(DetailView--Controller--Action-ViewItem---String--)?v=22.1)  para personalizar el control del  [elemento](https://docs.devexpress.com/eXpressAppFramework/112612/ui-construction/view-items-and-property-editors?v=22.1)  Vista  **de cumpleaños**.

El código siguiente muestra  **WebDateEditCalendarController**:



```csharp
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.Web;
using MySolution.Module.BusinessObjects;

namespace MySolution.Module.Web.Controllers {
    public partial class WebDateEditCalendarController : ObjectViewController<DetailView, Contact> {
        public WebDateEditCalendarController() {
            InitializeComponent();
        }
        protected override void OnActivated() {
            base.OnActivated();
            View.CustomizeViewItemControl(this, SetCalendarView, nameof(Contact.Birthday));
        }
        private void SetCalendarView(ViewItem viewItem) {
            var propertyEditor = viewItem as ASPxDateTimePropertyEditor;

            if(propertyEditor != null && propertyEditor.ViewEditMode == ViewEditMode.Edit) {
                ASPxDateEdit dateEdit = propertyEditor.Editor;
                dateEdit.PickerDisplayMode = DatePickerDisplayMode.ScrollPicker;
            }
        }
    }
}

```

Ejecute la aplicación ASP.NET formularios Web Forms y abra la Vista de detalles de  **contacto**. El editor de  **cumpleaños**  muestra un menú desplegable de calendario táctil.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c1668e68-6d52-4503-af8f-376206ba56cc)


>PROPINA
Este enfoque no afecta a los [editores locales](https://docs.devexpress.com/eXpressAppFramework/113249/ui-construction/views/list-view-edit-modes?v=22.1)  de la vista de lista. Para personalizar también estos editores, utilice la solución descrita en el tema  [Cómo: Personalizar un editor de propiedades integrado (formularios Web Forms ASP.NET).](https://docs.devexpress.com/eXpressAppFramework/113114/ui-construction/view-items-and-property-editors/property-editors/customize-a-built-in-property-editor-asp-net?v=22.1) Como alternativa, acceda al Editor de listas web local necesario como se indica en la descripción del método [`ComplexWebListEditor.FindPropertyEditor`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ComplexWebListEditor.FindPropertyEditor.overloads?v=22.1). Para aplicar una configuración personalizada a la columna de un [`ASPxGridListEditor`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor?v=22.1), controle los eventos [`ASPxGridListEditor.CreateCustomGridViewDataColumn`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.CreateCustomGridViewDataColumn?v=22.1) y  [`ASPxGridListEditor.CustomizeGridViewDataColumn`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.CustomizeGridViewDataColumn?v=22.1). Si necesita acceder a una plantilla para mostrar celdas dentro de la columna actual, utilice los eventos [`ASPxGridListEditor.CreateCustomDataItemTemplate`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.CreateCustomDataItemTemplate?v=22.1) y [`ASPxGridListEditor.CreateCustomEditItemTemplate`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.CreateCustomEditItemTemplate?v=22.1).


# Propiedades de control de cuadrícula de acceso (.NET Framework)


>PROPINA
Para aplicaciones Blazor, consulte: [Configuración de componentes de cuadrícula de vista de lista de acceso mediante un controlador (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402154/getting-started/in-depth-tutorial-blazor/extend-functionality/access-data-grid-settings?v=22.1).

En esta lección, aprenderá a tener acceso a las propiedades del control de cuadrícula de un formulario de lista en WinForms y ASP.NET aplicaciones de formularios Web Forms. Para ello, se implementarán nuevos View Controllers. Establecerán colores de fila alternativos en todas las vistas de lista representadas por GridListEditor y  **ASPxGridListEditor integrados**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)

## Acceder a la configuración del editor en una aplicación de formularios de Windows

-   Dado que la funcionalidad que se implementará es específica de la plataforma WinForms, se realizarán cambios en el proyecto  _MySolution.Module.Win._  Agregue un controlador de View a la carpeta  _Controllers_  del proyecto  _MySolution.Module.Win_, como se describe en la lección  [Agregar una acción sencilla](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1). Asígnele el nombre "_WinAlternatingRowsController_".
-   Invoque al diseñador del controlador. En la ventana  **Propiedades**, establezca la propiedad  **TargetViewType**  en el valor "ListView". Esto es necesario porque el controlador solo debe aparecer en vistas de lista.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2c3b035f-5877-4b80-b0b0-09792d260348)

    
-   Dado que va a acceder a la configuración del control de cuadrícula de la vista de lista, debe asegurarse de que ya se haya creado. Por este motivo, debe suscribirse al evento  **ViewControlsCreated**  del Controller. En la ventana Propiedades, cambie a la vista Eventos y haga doble clic en el evento  **ViewControlsCreated**. Maneje el evento como se muestra a continuación.
    

    
    ```csharp
    using System.Drawing;
    using DevExpress.ExpressApp.Win.Editors;
    using DevExpress.XtraGrid.Views.Grid;
    //... 
    private void WinAlternatingRowsController_ViewControlsCreated(object sender, EventArgs e) {
        GridListEditor listEditor = ((ListView)View).Editor as GridListEditor;
        if (listEditor != null) {
            GridView gridView = listEditor.GridView;
            gridView.OptionsView.EnableAppearanceOddRow = true;
            gridView.Appearance.OddRow.BackColor = Color.FromArgb(244, 244, 244);
        }
    }
    
    ```
    
    Como puede ver en el código anterior, para acceder a la cuadrícula de un formulario de lista, primero debe obtener el  [ListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.ListEditor?v=22.1), que es el objeto que enlaza los datos a una cuadrícula. Para obtener  **ListEditor**, utilice la propiedad  [ListView.Editor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ListView.Editor?v=22.1)  de la vista de lista necesaria. Hay  [varios tipos de ListEditors de WinForms integrados](https://docs.devexpress.com/eXpressAppFramework/113189/ui-construction/list-editors?v=22.1). El código anterior se implementa cuando la vista de lista actual está representada por un  [GridListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.Editors.GridListEditor?v=22.1). Este  **ListEditor**  representa datos a través del control  **XtraGrid**. Utilice la propiedad  [GridListEditor.GridView](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.Editors.GridListEditor.GridView?v=22.1)  para tener acceso a este control.
    
-   Ejecute la aplicación WinForms y seleccione un elemento en el control de navegación. Las filas de datos ahora tienen colores alternos.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/fd9e650e-982f-424b-ad91-216a2f0452c1)

    

## Configuración del editor de acceso en una aplicación ASP.NET  Web Forms

-   Como la funcionalidad que se va a implementar es específica de la plataforma ASP.NET formularios Web Forms, en esta lección se realizarán cambios en  _MySolution.Module.Web._  Agregue un controlador de View a la carpeta  _Controllers_  del proyecto  _MySolution.Module.Web_, como se describe en la lección  [Agregar una acción sencilla](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1). Asígnele el nombre "_WebAlternatingRowsController_".
-   **Invoque al diseñador**  del controlador. En la ventana  **Propiedades**, establezca la propiedad  **TargetViewType**  en el valor "ListView". Esto es necesario porque el controlador solo debe aparecer en vistas de lista.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/da5d1be7-19fa-46b4-93f1-8b5b119fd4cd)

    
-   Dado que va a acceder a la configuración del control de cuadrícula de la vista de lista, debe asegurarse de que ya se haya creado. Por este motivo, debe suscribirse al evento  **ViewControlsCreated**  del Controller. En la ventana Propiedades, cambie a la vista Eventos y haga doble clic en el evento  **ViewControlsCreated**. Maneje el evento como se muestra a continuación.
    

    
    ```csharp
    using System.Drawing;
    using DevExpress.ExpressApp.Web.Editors.ASPx;
    //... 
    private void WebAlternatingRowsController_ViewControlsCreated(object sender, EventArgs e) {
        ASPxGridListEditor listEditor = ((ListView)View).Editor as ASPxGridListEditor;
        if (listEditor != null)
            listEditor.Grid.Styles.AlternatingRow.BackColor = Color.FromArgb(244, 244, 244);
    }
    
    ```
    
    Como puede ver en el código anterior, para acceder a la cuadrícula de un formulario de lista, primero debe obtener el  [ListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.ListEditor?v=22.1), que es el objeto que enlaza los datos a una cuadrícula. Para obtener  **ListEditor**, utilice la propiedad  [ListView.Editor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ListView.Editor?v=22.1)  de la vista de lista necesaria. Existen  [varios tipos de editores de listas integrados ASP.NET formularios Web Forms](https://docs.devexpress.com/eXpressAppFramework/113189/ui-construction/list-editors?v=22.1). El código anterior se implementa cuando la vista de lista actual está representada por un  [ASPxGridListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor?v=22.1). Este  **ListEditor**  representa datos mediante el control  **ASPxGridView**. Para tener acceso a este control, se utiliza la propiedad  [ASPxGridListEditor.Grid.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.Grid?v=22.1)
    
-   Ejecute la aplicación ASP.NET formularios Web Forms. Seleccione un elemento en el control de navegación y asegúrese de que se cambia el fondo de las filas.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6e41c79a-e27a-4bd5-bbd5-0ab4503b1ae3)

    

>NOTA
Debido a las características específicas de la plataforma de formularios Windows Forms y ASP.NET Web Forms, es posible que los controles Ver elementos y Editor de listas no estén listos inmediatamente para lapersonalización después de crear el control.  Considere la posibilidad de controlar eventos adicionales dependientes de la plataforma o usar enfoques alternativos si las personalizaciones anteriores no tienen ningún efecto.

-   **Win Forms:**
    
    Manejar los eventos de [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control): [HandleCreated](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.handlecreated), [VisibleChanged](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.visiblechanged) o [ParentChanged](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.parentchanged). También puede controlar el evento  **Load** (o similar) si el tipo de control actual lo expone.
    
-   **Formularios Web Forms  ASP.NET:**
    
    Manejar los eventos [Load](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.load) or [Init](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.init) de [System.Web.UI.Control](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control). En algunos casos, es posible que deba controlar la [WebWindow.PagePreRender](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.WebWindow.PagePreRender?v=22.1). Utilice la propiedad estática [WebWindow.CurrentRequestWindow](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.WebWindow.CurrentRequestWindow?v=22.1)  para obtener el objeto  **Web Window  actual** . También puede realizar ciertas personalizaciones en el  lado del cliente utilizando Java  Script (consulte [Información general sobre la funcionalidad del lado cliente](https://docs.devexpress.com/AspNet/4222/common-concepts/client-side-functionality?v=22.1)).
    

Estos eventos adicionales dependientes de la plataforma indican el estado "listo" de los controles: se ha agregado un control a la jerarquía de controles de formulario o se ha enlazado a datos. Póngase en contacto con nosotros a través del [Centro  de soporte](https://supportcenter.devexpress.com/) si necesita ayuda adicional para realizar personalizaciones.


# Personalización de la interfaz de usuario

-   Junio 11, 2021
-   2 minutos para leer

En esta sección del tutorial, personalizará la interfaz de usuario generada automáticamente. Los elementos visuales de la aplicación XAF se basan en las clases de datos declaradas y en la información de los ensamblados a los que se hace referencia en la aplicación. Toda la información recibida se representa como metadatos: datos que definen la estructura de la base de datos y las características de la aplicación a través de un formato neutral, que se puede adoptar en cualquier plataforma de destino. Estos metadatos se denominan  [modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1). Es una poderosa herramienta que le permite personalizar su aplicación. Para ello, utilice el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1), un instrumento para personalizar el  **modelo de aplicación**  en tiempo de diseño. Las siguientes lecciones demostrarán lo que puede personalizar a través del  **Editor de modelos y cómo**:

-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)
-   [Especificar la configuración de la acción](https://docs.devexpress.com/eXpressAppFramework/112742/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/specify-action-settings?v=22.1)
-   [Dar formato a un título de objeto de negocio](https://docs.devexpress.com/eXpressAppFramework/112752/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/format-a-business-object-caption?v=22.1)
-   [Asignar una imagen estándar](https://docs.devexpress.com/eXpressAppFramework/112745/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-standard-image?v=22.1)
-   [Asignar una imagen personalizada](https://docs.devexpress.com/eXpressAppFramework/112744/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-custom-image?v=22.1)
-   [Hacer que una propiedad sea calculable](https://docs.devexpress.com/eXpressAppFramework/112759/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/make-a-property-calculable?v=22.1)
-   [Origen de datos del editor de búsqueda de filtros](https://docs.devexpress.com/eXpressAppFramework/112755/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/filter-lookup-editor-data-source?v=22.1)
-   [Dar formato a un valor de propiedad](https://docs.devexpress.com/eXpressAppFramework/112754/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/format-a-property-value?v=22.1)
-   [Usar un editor multilínea para las propiedades de cadena](https://docs.devexpress.com/eXpressAppFramework/112753/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/use-a-multiline-editor-for-string-properties?v=22.1)
-   [Localizar elementos de la interfaz de usuario](https://docs.devexpress.com/eXpressAppFramework/112747/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/localize-ui-elements?v=22.1)
-   [Agregar un elemento a la nueva acción](https://docs.devexpress.com/eXpressAppFramework/112751/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-new-action?v=22.1)
-   [Agregar un elemento al control de navegación](https://docs.devexpress.com/eXpressAppFramework/112749/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-navigation-control?v=22.1)
-   [Implementar la validación del valor de la propiedad en el modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112750/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/implement-property-value-validation-in-the-application-model?v=22.1)
-   [Personalizar el diseño Ver elementos](https://docs.devexpress.com/eXpressAppFramework/112833/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/customize-the-view-items-layout?v=22.1)
-   [Agregar un editor a una vista de detalles](https://docs.devexpress.com/eXpressAppFramework/112758/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-editor-to-a-detail-view?v=22.1)
-   [Cambiar el diseño y la visibilidad del campo en una vista de lista](https://docs.devexpress.com/eXpressAppFramework/112746/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/change-field-layout-and-visibility-in-a-list-view?v=22.1)
-   [Mostrar una vista detallada con una vista de lista](https://docs.devexpress.com/eXpressAppFramework/112756/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/display-a-detail-view-with-a-list-view?v=22.1)
-   [Hacer editable una vista de lista](https://docs.devexpress.com/eXpressAppFramework/112757/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/make-a-list-view-editable?v=22.1)
-   [Agregar una vista previa a una vista de lista](https://docs.devexpress.com/eXpressAppFramework/113378/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-a-preview-to-a-list-view?v=22.1)
-   [Filtrar vistas de lista](https://docs.devexpress.com/eXpressAppFramework/112722/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/filter-list-views?v=22.1)
-   [Aplicar agrupación a datos de vista de lista](https://docs.devexpress.com/eXpressAppFramework/112826/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/apply-grouping-to-list-view-data?v=22.1)
-   [Elija el tipo de interfaz de usuario de WinForms](https://docs.devexpress.com/eXpressAppFramework/113264/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/choose-the-winforms-ui-type?v=22.1)
-   [Alternar la interfaz de la cinta de opciones de WinForms](https://docs.devexpress.com/eXpressAppFramework/113038/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/toggle-the-winforms-ribbon-interface?v=22.1)
-   [Cambiar el estilo de los elementos de navegación](https://docs.devexpress.com/eXpressAppFramework/113474/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/change-style-of-navigation-items?v=22.1)

En realidad, el Editor de modelos proporciona muchas más formas de personalizar el modelo de aplicación (y, en consecuencia, la aplicación). Puede consultar la sección de documentación del modelo de aplicación para obtener más información sobre el  [modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112579/ui-construction/application-model-ui-settings-storage?v=22.1).

Si la opción requerida no está disponible en el Editor de modelos, puede acceder directamente a las opciones de los controles utilizados. Revise las lecciones  [Configuración del editor](https://docs.devexpress.com/eXpressAppFramework/112729/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-editor-settings?v=22.1)  de acceso y Propiedades del control de  [cuadrícula de acceso](https://docs.devexpress.com/eXpressAppFramework/113165/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-grid-control-properties?v=22.1)  para obtener más información sobre este enfoque.


# Colocar una acción en una ubicación diferente


En esta lección, aprenderá cómo colocar una  [acción](https://docs.devexpress.com/eXpressAppFramework/112622/ui-construction/controllers-and-actions/actions?v=22.1)  en el lugar requerido. Para ello, se utilizará la  **acción ClearTasksAction**  definida en la lección  [Agregar una acción sencilla](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1). Se encuentra junto con las acciones  **SaveTo**,  **ExecuteReport**  y  **Refresh**. Este grupo Acciones se denomina  **Ver**  [contenedores de acciones](https://docs.devexpress.com/eXpressAppFramework/112610/ui-construction/action-containers?v=22.1)  (la propiedad  [ActionBase.Category](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.Category?v=22.1)  se establece en "Ver" al implementar  **ClearTasksAction**). Las acciones restantes se distribuyen entre otros contenedores de acciones. En esta lección, moverá  **ClearTasksAction**  al contenedor de acciones  **RecordEdit**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)
>-   [Agregar una acción que muestre una ventana emergente](https://docs.devexpress.com/eXpressAppFramework/112723/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-that-displays-a-pop-up-window?v=22.1)

>PROPINA
También puede cambiar una ubicación de acción en el código controlando el [controlador de sitiode controlesde acciones.Evento Personalizaracciones de contenedor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ActionControlsSiteController.CustomizeContainerActions?v=22.1).

-   Dado que  **ClearTasksAction**  se implementa en el módulo de aplicación común, puede especificar su ubicación directamente en este módulo. Para ello, invoque el Editor de  [modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  haciendo doble clic en el archivo  _Model.DesignedDiffs.xafml_  desde el proyecto  _MySolution.Module._
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/62490d22-a027-4c79-8d5e-c3993b2cbc7e)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c09dbdf0-3734-45a6-b6d4-1f98e81c83a0)

    
    La interfaz de la aplicación XAF se basa en el  [modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1). El  **Editor de modelos**  es una herramienta para examinar y editar el modelo de aplicación. Esta herramienta está integrada en Visual Studio y se muestra como un panel de ventana. Los comandos específicos del Editor de modelos están disponibles en la barra de herramientas del  **Editor**  de  **modelos XAF**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/293ea619-ac6e-42ca-a143-a34b568b9763)

    
    Si la barra de herramientas del Editor de modelos XAF está oculta, puede hacerla visible marcando el elemento  **Editor de modelos XAF**  en  **VISTA**  |  **Menú Barras de herramientas**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2f28aef6-72ec-47bf-85cb-25c43b73a92e)

    
    >NOTA
    Para obtener más información sobre las capacidades del Editor de modelos  , consulte el tema Editor de [](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)**modelos**.
    
-   En el  **Editor de modelos**, vaya a  **ActionDesign**  |  **Nodo ActionToContainerMapping**. Sus nodos secundarios representan los contenedores de acciones a los que se asignan las acciones según sus valores de propiedad  **Category**. Expanda el nodo Vista que representa el  contenedor de acciones de  **Vista**. Arrastre el nodo secundario  **ClearTasksAction**  al nodo  **RecordEdit**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/85e23d81-5717-493d-b98c-ed36bab79b54)

    
    >NOTA
    Como alternativa, puede utilizar los comandos  **Copiar**, **Pegar**, **Eliminar** y **Clonar**  del menú contextual  para modificar la estructura del modelo de aplicación. Las partes modificadas del modelo de aplicación se muestran con una fuente en negrita. Puede revertir cualquier nodo con todos sus nodos secundarios a su estado original a través del comando  **Restablecer diferencias**  del menú contextual  .
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Invoque un formulario de detalles, ya que  **ClearTasksAction**  solo se activa para  **las vistas de detalle**. La siguiente imagen muestra que esta acción se encuentra con acciones que pertenecen al contenedor de acciones  **RecordEdit**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/02fef166-37a0-4334-8cdc-65652bf87cbf)

    

Puede ver los cambios realizados en la lección en el  **Editor de modelos**  invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Especificar la configuración de la acción


En esta lección, aprenderá a modificar las propiedades de Action. Se utilizará la acción  **ClearTasks**. Para ver cómo se implementó la acción, consulte la lección  [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1). En esta lección, le agregará información sobre herramientas, un mensaje de confirmación y un acceso directo.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

-   Dado que  **ClearTasksAction**  se implementa en el módulo de aplicación común, puede especificar sus propiedades directamente en este módulo. Para ello, invoque el Editor de  [modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  haciendo doble clic en el archivo  _Model.DesignedDiffs.xafml_  en el proyecto  _MySolution.Module_:
-   En el Editor de modelos, vaya a  **ActionDesign**  |  **Nodo Acciones**. Busque el nodo  **ClearTasksAction**. A la derecha, la configuración de la acción está representada por propiedades. Estas propiedades se separan en categorías contraíbles.
-   Vaya a la categoría  **Misc**. De forma predeterminada, la propiedad  **Tooltip**  se establece en  **Caption**. Configúrelo en "Borrar las tareas del contacto actual" en su lugar. Establezca la propiedad de acceso directo en "Control+Mayús+C" para especificar un acceso directo para la acción. Tenga en cuenta que el  **acceso directo**  especificado se mostrará junto con el valor de la propiedad Información sobre herramientas en la información sobre  **herramientas**  de la acción. De forma predeterminada, la propiedad ConfirmationMessage se establece en el valor de la propiedad  [ActionBase.ConfirmationMessage](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.ConfirmationMessage?v=22.1)  de la acción, que se especifica en el código.  Reemplace este valor por "¿Está seguro de que desea borrar la lista de tareas del {0}?". El elemento de formato "{0}" se sustituirá por el valor de propiedad predeterminado del objeto. Una propiedad se puede especificar como predeterminada mediante la propiedad  **DefaultProperty**  de  **BOModel**  |  **_<Clase>_**  nodo en el Editor de modelos. Como alternativa, el atributo  **DefaultProperty**  se puede aplicar a la declaración de clase de negocio de la propiedad.
    
    >NOTA
    Los accesos directos se definen mediante cadenas simples que debe escribir manualmente. La propiedad  [IModelAction.Shortcut se utiliza para analizar las cadenas.](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelAction.Shortcut?v=22.1) Tenga en cuenta que los accesos directos solo funcionarán en una aplicación de formularios de Windows.
    
    El identificador de objeto actual se insertará en el mensaje de confirmación si la propiedad  **SelectionDependencyType**  de la acción no está establecida en "Independent". Por lo tanto, asigne el valor "RequireSingleObject" a la propiedad  **SelectionDependencyType**. Esta propiedad pertenece a la categoría  **Comportamiento**. También puede establecer esta propiedad en "RequireMultipleObjects". En este caso, el recuento de objetos seleccionados se sustituirá por el mensaje de confirmación.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/39319f37-a78a-46dd-9862-e6bc94a2489a)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms e invoque la  **vista detallada**  de cualquier objeto, haciendo doble clic en uno existente o creando uno nuevo. Compruebe si el botón  **Borrar tareas**  tiene la información sobre herramientas necesaria, se puede ejecutar a través del acceso directo especificado y se invoca un mensaje de confirmación con el texto especificado.

**Aplicación WinForms**

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/7f6dda7e-0272-4d26-bf32-627cf20c4c44)


**ASP.NET Aplicación de formularios Web Forms**

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/877525c2-6b62-4f29-be00-64f3f5d5f89c)


>NOTA
También puede establecer una imagen para una acción. Para obtener más información, consulte el tema  [Asignar una imagen personalizada](https://docs.devexpress.com/eXpressAppFramework/112744/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-custom-image?v=22.1).

Puede ver los cambios realizados en esta lección en el Editor de modelos invocado para el archivo  _Model.DesignedDiffs.xafml_, ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Dar formato a un título de objeto de negocio


En esta lección, aprenderá a dar formato al título de un formulario de detalle que muestra un objeto de negocio. Para ello, el título del formulario de detalles de un objeto de  **contacto**  se especificará a través de  **BOModel**  | Propiedad  **ObjectCaptionFormat**  del nodo  **de contacto**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

De forma predeterminada, el valor  [de propiedad predeterminado](https://docs.devexpress.com/eXpressAppFramework/113525/business-model-design-orm/how-to-specify-a-display-member-for-a-lookup-editor-detail-form-caption?v=22.1)  de la clase se utiliza en el título del formulario de detalle. La propiedad  **FullName**  es la propiedad predeterminada de la clase  **Person**  (especificada mediante el atributo  **DefaultProperty**). Como la clase Contact se hereda de  **Person**  (vea  [Heredar](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)  de la clase de la biblioteca de clases Business), la propiedad  **FullName**  también es la propiedad predeterminada de la clase  **Contact**.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ccd3aa78-8a90-4d31-b107-ab795b194f72)


Realice los pasos siguientes para especificar el formato de título personalizado.

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  haciendo doble clic en el archivo  _Model.DesignedDiffs.xafml_  en el proyecto  _MySolution.Module._
-   En el Editor de modelos, desplácese hasta  **BOModel**  |  **Nodo MySolution.Module.BusinessObjects.**  Seleccione el nodo  **Contacto**, que define la clase empresarial  **Contacto**. A la derecha, la configuración de clase está representada por propiedades.
-   Reemplace el valor predeterminado de la propiedad  **ObjectCaptionFormat**  por "{0:FullName} de {0:Department}".
    
    >NOTA
    Al establecer el formato de título de objeto, puede especificar explícitamente la cadena de formato. Por ejemplo, {0:**ArtículoNo:0000,00#**}  o **{0:Valor de fecha deperíodo:MM.aa}.** Para obtener más información acerca del formato, consulte el tema  [Especificadores de formato](https://docs.devexpress.com/WindowsForms/2141/common-features/formatting-values/format-specifiers?v=22.1).
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/d3bd4489-97b4-4a35-a799-6e69829efbe9)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Invoque un formulario de detalles para un objeto  **Contact**. El título debe establecerse en un valor, como se muestra en la siguiente imagen.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/3d6aa384-431a-4338-883d-d385c063017a)

    

Puede ver los cambios realizados en esta lección en el Editor de modelos invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .

>NOTA
Puede utilizar el  [atributo ObjectCaptionFormatpara](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ObjectCaptionFormatAttribute?v=22.1) especificar el título del objeto en el código.


# Asignar una imagen estándar

**eXpressApp Framework (XAF)**  incluye imágenes estándar incrustadas en el ensamblado  _DevExpress.Images._  En esta lección, aprenderá a asociar una clase empresarial con una imagen estándar. Esta imagen representará la clase en el control de navegación, incluidos los encabezados de formulario de detalle y lista. Para ello, se utilizarán las clases  **Department**  y  **Position**, ya que su antecesor (clase  [BaseObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.BaseImpl.BaseObject?v=22.1)) no está asociado a una imagen.

Para ver las imágenes disponibles, examine la siguiente carpeta: %_PROGRAMFILES%\DevExpress  22.1\Components\Sources\DevExpress.Images\Images._

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1).

Siga los pasos que se indican a continuación para asignar imágenes a las clases  **Department**  y  **Position**.

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112830/installation-upgrade-version-history/visual-studio-integration/model-editor?v=22.1)  para su proyecto de aplicación de formularios WinForms o ASP.NET  [Web](https://docs.devexpress.com/eXpressAppFramework/118045/application-shell-and-base-infrastructure/application-solution-components/application-solution-structure?v=22.1)  Forms.
    
-   Desplácese hasta el nodo  **NavigationItems**  y establezca  [ShowImages](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.IModelRootNavigationItems.ShowImages?v=22.1)  en  **true**.
    
-   Para las aplicaciones WinForms, establezca también la propiedad  [ShowTabImage](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.SystemModule.IModelOptionsWin.ShowTabImage?v=22.1)  en  **true**  en el nodo  **Options**.
    
-   Ahora se muestran imágenes para clases empresariales. La imagen "BO_Unknown" se muestra para las clases que no tienen una imagen preasignada.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/d606dd7f-9ce9-41dc-a0dc-04ef117c0713)

    
-   Invoque el  [editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112830/installation-upgrade-version-history/visual-studio-integration/model-editor?v=22.1). Vaya a la  **lista de materiales**  |  **MySolution.Module.BusinessObjects**  |  **Departamento**  y cambie el valor de la propiedad  **ImageName**  a "BO_Department". Éste es el nombre de la imagen en la carpeta %_PROGRAMFILES%\DevExpress  22.1\Components\Sources\DevExpress.Images\Images._  Esta carpeta representa una  _biblioteca de imágenes estándar_.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/3070f2b8-daec-46f5-92a2-2cf5effe6338)

    
    >NOTA
    >-   Cuando la propiedad  **Nombre de imagen** está enfocada, el botón de puntos suspensivos (![EllipsisButton](https://docs.devexpress.com/eXpressAppFramework/images/ellipsisbutton116182.png?v=22.1)) se muestra a la derecha del valor de la propiedad. Puede hacer clic en este botón para invocar el cuadro de diálogo  **Selector**  de imágenes  y examinar las imágenes disponibles.
    
-   Vaya a la  **lista de materiales**  |  **MySolution.Module.BusinessObjects**  |  **Coloque**  el nodo y cambie el valor de la propiedad  **ImageName**  a "BO_Position".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/171ca64d-4759-4d86-a5e4-121c6672a72f)

    
-   Ejecute la aplicación. Verá que  **Departamento**  y  **Posición**  ahora tienen las imágenes correspondientes que se muestran dentro de la barra de navegación y el panel de pestañas. Si ejecuta la aplicación ASP.NET formularios Web Forms, verá imágenes similares dentro del encabezado de página cuando la vista de lista  **Departamento**  (o  **posición**) o la vista de detalle estén activas.
    
    **Aplicación WinForms**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/02ae5a97-b9d6-4421-b663-60050620dfff)

    
    **ASP.NET Aplicación de formularios Web Forms**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b8bb29c7-76ac-421f-9e4c-971d9ad746f5)

    

Puedes ver los resultados en la  **Demo Principal**  | Editor de modelos del proyecto  **MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Asignar una imagen personalizada


En esta lección, aprenderá a asociar una clase empresarial con una imagen personalizada. Esta imagen representará la clase en el control de navegación, incluidos los encabezados de formulario de detalle y lista. Para ello, se utilizará la clase  **Contact**. De forma predeterminada, se asocia con la imagen de su antepasado (la clase  **Person**). Proporcionará una imagen personalizada para la clase  **Contact**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)
>-   [Asignar una imagen estándar](https://docs.devexpress.com/eXpressAppFramework/112745/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-standard-image?v=22.1)

-   En el  **Explorador de soluciones**, vaya a la carpeta  _Imágenes_  del proyecto  _MySolution.Module._  XAF carga imágenes de esta carpeta.
    
    Para este tutorial, puede usar archivos de imagen personalizados o cargarlos desde la carpeta %_PROGRAMFILES%\DevExpress  22.1\Components\Sources\DevExpress.Images\Images._
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/3ea86bf1-5c79-4876-a9a4-f1a3032e59d5)

    Para usar una imagen SVG en un proyecto de C#, guárdela como \_MySolution.Module\Images\Employee.svg._
    
    Para utilizar una imagen SVG en un proyecto de Visual Basic, guárdela como \_MySolution.Module\Images\MySolution.Module.Images.Contact.svg_  y asegúrese de que "Imágenes" está en mayúsculas en el nombre de archivo.
    
    Para ASP.NET aplicaciones de formularios Web Forms, utilice archivos adicionales para los  [estados activo y deshabilitado](https://docs.devexpress.com/eXpressAppFramework/112792/application-shell-and-base-infrastructure/icons/add-and-replace-icons?v=22.1#naming-images)  de un icono. Estos elementos deben tener el mismo nombre que el primer archivo agregado y el sufijo de un estado, por ejemplo,  _Employee_Active.svg_  y  _Employee_Disabled.svg_.
    
    >NOTA
    Consulte el artículo  [Agregar y reemplazar iconos](https://docs.devexpress.com/eXpressAppFramework/112792/application-shell-and-base-infrastructure/icons/add-and-replace-icons?v=22.1) para obtener más información sobre cómo usar imágenes SVG y PNG en aplicaciones XAF.
    
-   En el  **Explorador de soluciones**, seleccione el proyecto de  [módulo](https://docs.devexpress.com/eXpressAppFramework/118045/application-shell-and-base-infrastructure/application-solution-components/application-solution-structure?v=22.1)  y haga clic en el botón de la barra de herramientas  **Mostrar todos los archivos**  (![showall_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_vs_showall117418.png?v=22.1)). Seleccione las imágenes en la subcarpeta  **Imágenes**, haga clic con el botón secundario en la selección y elija  **Incluir en proyecto**.
    
    **C#**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/7edf6e91-8b33-4a05-9a0a-1bc80aa07742)

    
    **Visual Basic**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e0c44354-6933-4aca-90fc-4a558cb3e75d)

    
-   Seleccione las imágenes y cambie a la ventana  **Propiedades**. Establezca la opción  **Acción de compilación**  en  **Recurso incrustado**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/86d889c1-b129-4cc8-a266-523fa6800001)

    
-   Invoque el  [editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1). Vaya a la  **lista de materiales**  |  **MySolution.Module.BusinessObjects**  |  **Póngase en contacto**  y establezca su propiedad  **ImageName**  en "Employee".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/8ef9f177-5450-4789-86e7-7120e8c38036)

    
    >NOTA
    >-   Cuando la propiedad  **Nombre de imagen** está enfocada, el botón de puntos suspensivos (![EllipsisButton](https://docs.devexpress.com/eXpressAppFramework/images/ellipsisbutton116182.png?v=22.1)) se muestra a la derecha del valor de la propiedad. Puede hacer clic en este botón para invocar el cuadro de diálogo  **Selector**  de imágenes  y examinar las imágenes disponibles.
    >-   Puede utilizar el [atributo ImageNamepara](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ImageNameAttribute?v=22.1) especificar una imagen en el código.
    
-   Ejecute la aplicación. Observe que el elemento de navegación  **Contacto**  ahora tiene asignada una imagen personalizada.
    
    **Aplicación WinForms**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/0f778474-129e-4542-b55b-c6a0e87f3699)

    
    **ASP.NET Aplicación de formularios Web Forms**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/9cd2e54b-0fb8-41ad-9ab3-b57306c48617)

    

Puede ver los cambios realizados en esta lección en la  **Demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Hacer que una propiedad sea calculable


En esta lección, aprenderá a administrar propiedades calculadas. Para ello, se implementará la clase  **Payment**. El valor de la propiedad  **Importe**  se calculará utilizando las propiedades  **Tarifa**  y  **Horas**. El valor se actualizará inmediatamente después de cambiar la propiedad  **Rate**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

-   Para implementar la clase  **Payment**, haga clic con el botón secundario en la carpeta  _Business Objects_  del proyecto  _MySolution.Module_  y elija  **Agregar elemento DevExpress**  |  **Nuevo artículo...**. En la  [Galería de plantillas](https://docs.devexpress.com/eXpressAppFramework/113455/installation-upgrade-version-history/visual-studio-integration/template-gallery?v=22.1)  invocada, seleccione el  **objeto de negocio XAF**  |  **Plantilla XPO Business Object**, introduzca "Pago" como nombre de archivo y haga clic en  **Añadir**. Reemplace la declaración de clase generada automáticamente por el código siguiente.
    

    
    ```csharp
    [DefaultClassOptions, ImageName("BO_SaleItem")]
    public class Payment : BaseObject {
        public Payment(Session session) : base(session) { }
        private double rate;
        public double Rate {
            get {
                return rate;
            }
            set {
                if(SetPropertyValue(nameof(Rate), ref rate, value))
                    OnChanged(nameof(Amount));
            }
        }
        private double hours;
        public double Hours {
            get {
                return hours;
            }
            set {
                if(SetPropertyValue(nameof(Hours), ref hours, value))
                    OnChanged(nameof(Amount));
            }
        }
        [PersistentAlias("Rate * Hours")]
        public double Amount {
            get {
                object tempObject = EvaluateAlias(nameof(Amount));
                if(tempObject != null) {
                    return (double)tempObject;
                }
                else {
                    return 0;
                }
            }
        }
    }
    
    ```
    
    Se calcula la propiedad  **Amount**, ya que no tiene ningún descriptor de acceso  **establecido**, y la lógica de su cálculo de valor se implementa en el descriptor de acceso  **get**.
    
    >NOTA
    En el código anterior, la propiedad  calculada no persistente Amount está decorada con el  [atributo PersistentAlias](https://docs.devexpress.com/XPO/DevExpress.Xpo.PersistentAliasAttribute?v=22.1), para permitir que el filtrado y la ordenación por esta propiedad se realicen en el nivel de base de datos. El atributo  **Alias persistente** toma un único parámetro que especifica la expresión utilizada para calcular el valor de la propiedad en el servidor de bases de datos. Se debe especificar un alias persistente en el código como parámetro del atributo. Sin embargo, en determinados escenarios, la propiedad puede requerir un alias persistente configurable y debe poder configurarla un administrador en una aplicación implementada. En este caso, se debe utilizar  el  [atributo de aliaspersistentecalculado](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Xpo.CalculatedPersistentAliasAttribute?v=22.1).
    
-   Vuelva a generar el proyecto  _MySolution.Module_  e invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para ello. Vaya a la  **lista de materiales**  |  **Pago**  |  **Miembros Propios**  |  **Nodo de tasa**. Establezca la propiedad  **ImmediatePostData**  de  **Rate**  en  **True**. La propiedad  **ImmediatePostData**  especifica si el valor de la propiedad se actualiza inmediatamente después de que se produzcan cambios en el control enlazado del Editor de propiedades actual. Como el valor de la propiedad  **Amount**  calculado depende de  **Rate**, estos valores se actualizarán simultáneamente en la interfaz de usuario.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/564112f2-b785-4272-9605-2ba8fbc32d8c)

    
    >NOTA
    Como alternativa, puede utilizar el  [atributo ImmediatePostDataen](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ImmediatePostDataAttribute?v=22.1)  el  código.
    
-   Ejecute la aplicación WinForms. Seleccione el elemento de pago en el control  **de**  navegación. Haga clic en el botón  **Nuevo**. Se invocará el formulario de detalles para el nuevo objeto  **de pago**. Especifique las propiedades  **Tarifa**  y  **Horas**  y guarde los cambios. A continuación, cambie las propiedades  **Rate**  y  **Hours**  y vea cómo afecta esto a la propiedad  **Amount**. El valor de la propiedad  **Importe**  se actualiza inmediatamente al cambiar el valor de la propiedad  **Tasar**  y también después de que el campo de propiedad  **Horas**  pierda el foco.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a3129c13-5450-4069-b22c-03b7449e5e48)

    
-   Ejecute la aplicación ASP.NET formularios Web Forms. Seleccione el elemento de pago en el control  **de**  navegación. Invoque la vista Detalles de  **pago**  en modo de edición. A continuación, cambie las propiedades  **Rate**  y  **Hours**  para ver cómo afecta esto a la propiedad  **Amount**. La página se actualiza inmediatamente después de que el campo  **de propiedad Calificar**  pierda el foco. Si cambia el valor de la propiedad  **Horas**, el valor  **Importe**  se actualiza después de guardar los cambios.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/bc2c39e8-aba5-43d8-a2e5-a0cfa69b0c33)


Puede ver los cambios realizados en esta lección en la  **Demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) . Tenga en cuenta que en  **MainDemo**, la propiedad  **ImmediatePostData**  de  **Hours**  también se establece en "**True**", por lo que el comportamiento es diferente del comportamiento descrito en este tutorial.


# Origen de datos del editor de búsqueda de filtros


En esta lección, aprenderá a filtrar los datos mostrados por un editor de búsquedas. Este editor se muestra en las vistas de detalle para las propiedades de referencia. Contiene una lista de objetos de otra clase relacionada. En esta lección, se filtrará el editor de búsqueda  **Contact.Position.**  Para ello, se establecerá una relación  **de varios a muchos**  entre la clase  **Position**  y la clase  **Department**. A continuación, se filtrarán los objetos de la clase  **Position**  en la vista detallada del objeto  **Contact**, mostrando sólo aquellos  **Positions**s que estén relacionados con un  **departamento**  correspondiente.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implementar clases empresariales personalizadas y propiedades de referencia](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Implementar propiedades de referencia dependientes](https://docs.devexpress.com/eXpressAppFramework/112720/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-dependent-reference-properties-xpo?v=22.1)
>-   [Establecer una relación de muchos a muchos](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

-   Establezca una relación de muchos a muchos entre las clases  **Posición**  y  **Departamento**. Para obtener más información, consulte la lección  [Establecer una relación entre muchos](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1).
    

    
    ```csharp
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
     public class Department : BaseObject {
       //...
       [Association("Departments-Positions")]
       public XPCollection<Position> Positions {
          get { return GetCollection<Position>(nameof(Positions)); }
       }
    }
    
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
    public class Position : BaseObject {
          //...
       [Association("Departments-Positions")]
       public XPCollection<Department> Departments {
          get { return GetCollection<Department>(nameof(Departments)); }
       }
    }
    
    ```
    
-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Vaya a la  **lista de materiales**  |  **Nodo MySolution.Module.BusinessObjects.**  Expanda el nodo secundario  **Contactar**  y seleccione el nodo secundario  **Posición**. Las propiedades de la derecha definen la propiedad  **Contact.Position.**  Establezca la propiedad  **DataSourceProperty**  en "Department.Positions". Como resultado, el editor de búsqueda  **de posiciones**  mostrará la colección  **Department.Positions.**
    
-   Establezca la propiedad  **DataSourcePropertyIsNullMode**  en "SelectAll" para mostrar todos los objetos existentes en el editor  **Contact.Position**  cuando no se especifique la propiedad  **Department.Positions.**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/66f709cc-a2a2-42b9-9574-cafa73d5e740)

    
    >NOTA
    Puede realizar la tarea definida anteriormente en el código. Consulte el tema  [Implementar propiedades de referencia dependientes (XPO).](https://docs.devexpress.com/eXpressAppFramework/112720/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-dependent-reference-properties-xpo?v=22.1)
    
-   El origen de datos de la propiedad  **Position**  cambia cada vez que se cambia la propiedad  **Department**. Por lo tanto, el valor de la propiedad  **Position**  debe establecerse en "null" ("Nothing" en VB) después de que su origen de datos haya cambiado. Para establecer un nuevo valor a partir del origen de datos recreado, reemplace la declaración de propiedad  **Departamento**  por el código siguiente.
    

    ```csharp
    public class Contact : Person {
        // ...
        [Association("Department-Contacts", typeof(Department)), ImmediatePostData]
        public Department Department {
            get { return department; }
            set {
                SetPropertyValue(nameof(Department), ref department, value);
                if(!IsLoading) {
                    Position = null;
                    if(Manager != null && Manager.Department != value) {
                        Manager = null;
                    }
                }
            }
        }
        // ...
    }
    
    ```
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Especifique la propiedad  **Positions**  para los objetos  **Department**. Invocar una vista de detalles de contacto. La lista desplegable del editor de búsqueda de posiciones contiene las  **posiciones**  asignadas al objeto  **Department**  especificado por el editor de  **departamento**:
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/53a14388-2225-46b4-8be5-574572c1727f)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a6dc8286-0da9-4ff7-8a8a-41861018ed8f)

    

Puede ver los cambios realizados en esta lección en la  **Demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Dar formato al valor de una propiedad (formularios de Windowsy formularios web)

En esta lección, aprenderá a establecer un formato de presentación y una máscara de edición en una propiedad de clase empresarial. Para ello, el formato de visualización de las propiedades  **Task.StartDate**,  **Task.DueDate**,  **Task.PercentCompleted**  y  **PhoneNumber.Number**  se personalizará mediante el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1).

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

## Aplicar una máscara de edición y un formato de visualización a un valor de propiedad de fechay hora

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Vaya a la  **lista de materiales**  |  **DevExpress.Persistent.BaseImpl**  |  **Tarea**  |  **OwnMembers**  y seleccione el nodo secundario  **DueDate**. A la derecha, verá propiedades que representan la configuración de la propiedad  **DueDate**.
-   Busque la propiedad  [DisplayFormat](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.PropertyEditor.DisplayFormat?v=22.1)  ubicada en la categoría  **Formato**. Su valor predeterminado es "{0:d}". Esta máscara corresponde al patrón de fecha corta (por ejemplo, "3/21/2014"). Para usar el patrón de fecha larga (por ejemplo, "viernes, 21 de marzo de 2014"), establezca la propiedad  **DisplayFormat**  en "{0:D}". Sin embargo, el patrón de fecha larga es inconveniente cuando se escribe la fecha manualmente. Por lo tanto, establezca el valor de la propiedad  [EditMask](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.PropertyEditor.EditMask?v=22.1)  en "d". Esta máscara se utilizará cuando el editor de propiedades  **DueDate**  esté enfocado.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/20b3a2c2-bed3-4e7e-ad1d-0737914f7c1b)

    
    >NOTA
    Puede establecer la propiedad  **Formato de visualización**  en "D"  en lugar de "{0:D}". Estos valores establecen el mismo formato en una aplicación de formularios de Windows. Sin embargo, tenga en cuenta que el valor "D" no es válido en una aplicación de formularios Web Forms ASP.NET.  En su lugar, use la sintaxis "{0:<Format_Specifiers>}".
    
-   Seleccione el nodo secundario  **StartDate**. Establezca la propiedad  **DisplayFormat**  en "{0:D}" y  **EditMask**  en "d".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/226baaa8-70aa-48e1-b785-4e1f41163f04)

    
-   Ejecute la aplicación WinForms. Invoque un formulario de detalle para la clase DemoTask. Verá que el formato de las propiedades  **StartDate**  y  **DueDate**  depende del foco. Cuando el Editor de propiedades está enfocado, se aplica  **EditMask**  y el valor de la propiedad se formatea según el patrón de fecha corta (la máscara de edición "d"). Cuando el Editor de propiedades no está enfocado, se aplica  **DisplayFormat**  y el valor de la propiedad se formatea según el patrón de fecha larga (el especificador de formato "D").
    
-   Ejecute la aplicación ASP.NET formularios Web Forms. Invoque un formulario de detalle para la clase DemoTask. Verá que se aplica  **DisplayFormat**  y que los valores de las propiedades  **StartDate**  y  **DueDate**  tienen el formato según el patrón de fecha larga (el especificador de formato "D").
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/37add1df-4fa7-416f-8206-58e3409cc840)

    
-   Haga clic en el botón  **Editar**  para mostrar el objeto  **DemoTask**  en modo de edición. Verá que se aplica  **EditMask**  y que los valores de las propiedades  **StartDate**  y  **DueDate**  tienen el formato según el patrón de fecha corta (la máscara de edición "d").
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/508865ba-3478-4f0f-bc19-5beb08b64e67)

    

>NOTA
Consulte los temas  [Tipo de máscara: fecha y hora](https://docs.devexpress.com/WindowsForms/1497/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/masks/mask-type-date-time?v=22.1), [especificadores](https://docs.devexpress.com/WindowsForms/2141/common-features/formatting-values/format-specifiers?v=22.1)  de formato y formato  [compuesto](https://docs.devexpress.com/WindowsForms/2143/common-features/formatting-values/composite-formatting?v=22.1) para obtener más información sobre el formato con máscaras en formularios Windows y el tema Tipos de máscara para dar formato en formularios [](https://docs.devexpress.com/AspNet/5744/components/data-editors/common-concepts/mask-editing/mask-types?v=22.1)Web Forms ASP.NET.  Tenga en cuenta las diferencias en el uso de corchetes angulares.

## Aplicar el formato de visualización a un valor de propiedad entero

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  **MySolution.Module.**  Vaya a la  **lista de materiales**  |  **DevExpress.Persistent.BaseImpl**  |  **Tarea**  |  **OwnMembers**  y seleccione el nodo secundario  **PercentCompleted**. A la derecha, verá propiedades que representan la configuración de la propiedad  **PercentCompleted**.
-   Establezca la propiedad  **DisplayFormat**  en "{0:N0}%".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/58077a5e-a181-46a2-8431-d2a8dcced159)

-   Ejecute la aplicación. Invoque un formulario de detalle para la clase  **DemoTask**. Verá que el valor de la propiedad  **PercentCompleted**  se muestra con el signo '%' adjunto.
    
    En una aplicación WinForms:
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/25cb1444-5c9f-4442-b4e5-fc1eafaea006)

    
    En una aplicación ASP.NET formularios Web Forms:
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/066e6ac1-dff6-4ed8-a6d3-9ef32d180567)

    
    Dado que no se especificó  **EditMask**, el signo '%' no se anexa cuando el editor está enfocado en una aplicación WinForms. En una aplicación ASP.NET de formularios Web Forms, el signo '%' no se anexa cuando la vista detallada está en modo de edición.
    

## Aplicar el valor de la propiedad Edit Mask a String

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Vaya a la  **lista de materiales**  |  **DevExpress.Persistent.BaseImpl**  |  **Número de teléfono**  |  **OwnMembers**  y seleccione el nodo secundario  **Número**. A la derecha, verá propiedades que representan la configuración de la propiedad  **Number**.
-   Establezca la propiedad  **EditMask**  en "(000)000-0000".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b9d80fd2-a2fa-4af0-84ab-1b94945424d5)

    
    >NOTA
    >-   La propiedad  **EditMaskType** se establece en **Simple** de forma predeterminada. Sin embargo, puede utilizar la máscara de [expresión regular simplificada](https://docs.devexpress.com/WindowsForms/1499/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/masks/mask-type-simplified-regular-expressions?v=22.1) estableciendo esta propiedad en **RegEx**. En este caso, una expresión regular apropiada para un número de teléfono es "((\d\d\d))\d\d\d\d-\d\d\d". Sin embargo, tenga en cuenta que el tipo de máscara de edición  **RegEx** solo se admite actualmente en aplicaciones de formularios Win.
    >-   Utilice la propiedad  [MaskSettings](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.SystemModule.IModelMaskSettings.MaskSettings?v=22.1)  en  lugar de la propiedad **EditMask** en los proyectos de aplicación  **de formularios de Windows**.
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Invoque un formulario de detalles para la clase Contact. Agregue un objeto  **PhoneNumber**  mediante la acción New que acompaña a la colección  **PhoneNumbers**. En la  vista de detalles PhoneNumber, verá que la propiedad  **Number**  admite la máscara especificada.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a0bd815a-6ca3-41b9-b06b-db548e26bc77)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ed5d0e5d-7c1a-4873-a9be-ba6c1f53d9d6)

    
    El Editor de propiedades  **PhoneNumber**  le permite introducir dígitos en las posiciones especificadas por los metacaracteres '0'. Los caracteres '(', ')' y '-' no se pueden quitar y sus posiciones son fijas. Como resultado, los usuarios finales no podrán escribir un número de teléfono con formato incorrecto.
    
    Los caracteres '(', ')' y '-' se guardan dentro del valor de la propiedad, por lo que no es necesario especificar  **DisplayFormat**  para mostrar los paréntesis y el guión cuando el Editor de propiedades no está enfocado o el valor de la propiedad no es editable.
    

Consulte el tema  [MaskType: Simple](https://docs.devexpress.com/WindowsForms/1500/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/masks/mask-type-simple?v=22.1)  para obtener más información.

>NOTA
Las propiedades  **EditMask**  y [`MaskSettings`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.SystemModule.IModelMaskSettings.MaskSettings?v=22.1)  no  prohíben a los usuarios guardar un valor incorrecto en una base de datos (por ejemplo, cuando no rellenan todos los dígitos necesarios en un número de teléfono). Configure las opciones de  [validación](https://docs.devexpress.com/eXpressAppFramework/113684/validation-module?v=22.1) para evitar errores de datos.

Se proporciona un ejemplo de formato personalizado en  **PropertyEditors**  |  **Sección Propiedades de formato personalizado**  de la demostración de  **FeatureCenter**. De forma predeterminada, la aplicación FeatureCenter se instala en %PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\FeatureCenter.NETFramework.XPO.

>PROPINA
Puede especificar el formato predeterminado para todas las propiedades de un tipo determinado. En un proyecto específico de la plataforma, utilice [IModelRegisteredPropertyEditor.DefaultDisplayFormat](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.IModelRegisteredPropertyEditor.DefaultDisplayFormat?v=22.1) y [IModelRegisteredPropertyEditor.DefaultEditMask](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.IModelRegisteredPropertyEditor.DefaultEditMask?v=22.1) de una **ViewItems** | **PropertyEditors** | **RegisteredPropertyEditors**.


# Usar un editor multilínea para las propiedades de cadena

En esta lección, aprenderá a mostrar un editor multilínea para las propiedades de cadena. Para ello, se utilizará la propiedad  **Task.Subject.**  De forma predeterminada, se muestra a través de un cuadro de texto de una sola línea.

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1).

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Vaya a la  **lista de materiales**  |  **DevExpress.Persistent.BaseImpl**  |  **Tarea**  |  **OwnMembers**  y seleccione el nodo secundario  **Subject**. A la derecha, verá propiedades que representan la configuración de la propiedad  **Asunto**.
-   Establezca la propiedad  **RowCount**  en "2". Esto significa que se creará un editor de dos líneas para la propiedad  **Subject**.
-   Establezca la propiedad  **Size**  en "200". Esto significa que se permitirá una entrada de 200 símbolos en el editor de dos líneas. Como alternativa, puede aplicar el atributo  **Size**  en el código.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/d18edbd2-409c-4e38-b059-782b03dfefa8)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Invoque un formulario de detalles para una clase  **DemoTask**. La propiedad  **Subject**  se mostrará a través de un editor de notas que contiene dos líneas.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/bb07862b-9d7e-4bbf-bb27-4ec35c413d80)

    

Puede ver los cambios realizados en esta lección en el Editor de modelos invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx)


# Localizar elementos de la interfaz de usuario

En esta lección, aprenderá los conceptos básicos de la localización de elementos visibles de la interfaz de usuario. De forma predeterminada, la aplicación utiliza el idioma invariante (inglés). Traducirá su aplicación al alemán y creará una aplicación multilingüe. Para ilustrar diferentes escenarios de localización, la lección se divide en dos secciones. Deben realizarse en orden. Traducirá varios subtítulos con fines de capacitación. Para obtener información sobre cómo localizar completamente una aplicación XAF, primero revise la sección  [Localización](https://docs.devexpress.com/eXpressAppFramework/113298/localization?v=22.1)  y, a continuación, siga el tema  [Cómo: Localizar una aplicación XAF](https://docs.devexpress.com/eXpressAppFramework/113250/localization/localize-an-xaf-application-net-framework?v=22.1).

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1).

## Traducir la aplicación a un idioma adicional

Siga los pasos a continuación para estudiar los conceptos básicos de la traducción de su aplicación.

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Busque la barra de herramientas del Editor de modelos. Si está oculto, compruebe la  **casilla Ver**  |  **Barras de herramientas**  | Elemento de menú  **Editor de modelos XAF**. En el cuadro combinado  **Idioma**  de la barra de herramientas (ubicado en la barra de herramientas del Editor de modelos), seleccione  **de**. Si no está allí, haga clic en el elemento  **Administrador de idiomas....**  En el cuadro de diálogo invocado, haga clic en el botón  **Agregar**  y seleccione  **de (alemán - alemán).**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/8e098f9b-0b33-46c6-9718-b9f4fba3934b)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6c8b9cdf-6b2b-44b1-8e4b-e3d13d8d9a60)

    
-   Después de agregar el idioma, debe reiniciar Visual Studio.
-   Seleccione el idioma recién agregado en el cuadro combinado  **Idioma**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/fc8b4abc-5475-4898-a119-13f470b4cbc2)

    
-   Para localizar completamente la aplicación, debe examinar todos los nodos y sus nodos secundarios para establecer valores alemanes para las propiedades indicadas por el glifo "globo". La  [herramienta de localización](https://docs.devexpress.com/eXpressAppFramework/113297/localization/localization-tool?v=22.1)  simplifica esta tarea. Para fines de capacitación, traduzca algunos valores para ver cómo afecta esto a su aplicación. Esencialmente, las propiedades  **Caption**  se pueden localizar.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/8e9ca1cd-9234-4a55-a78c-1bf378326ed2)

    
    >NOTA
    En el tema Cómo: Localizar una aplicación XAF  se explica cómo localizar [una aplicación XAF](https://docs.devexpress.com/eXpressAppFramework/113250/localization/localize-an-xaf-application-net-framework?v=22.1).
    
-   En el Editor de modelos invocado para un proyecto de WinForms y/o un proyecto de aplicación de formularios Web Forms ASP.NET, navegue hasta el nodo  **Aplicación**. En la lista desplegable de la propiedad  **PreferredLanguage**, seleccione "de". Si necesita utilizar el idioma alemán en las aplicaciones WinForms y ASP.NET formularios Web Forms, puede especificar el valor de la propiedad  **PreferredLanguage**  en el Editor de modelos invocado para el módulo de aplicación.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/1d802785-3b79-4136-a089-db6eb04af72c)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Compruebe que las propiedades que ha traducido a través del Editor de modelos se muestran en alemán.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6ba2972c-1916-4d25-95ff-ebc8117865a9)


## Crear una aplicación de idioma de usuario

Realice los pasos siguientes si la aplicación debe estar en el idioma del usuario (el idioma del sistema operativo del usuario o el idioma pasado por el explorador de Internet del usuario).

-   Traduzca su aplicación a los idiomas requeridos. Para ello, invoque el Editor de modelos, establezca el idioma requerido en el elemento de la barra de herramientas  **Idioma**  del editor de modelos y traduzca todos los valores de propiedad localizables (como se detalla en la sección anterior). Haga esto para cada idioma requerido.
-   En el Editor de modelos invocado para el proyecto de aplicación de formularios WinForms y/o ASP.NET Web Forms, navegue hasta el nodo  **Aplicación**. En la lista desplegable de la propiedad  **PreferredLanguage**, seleccione el elemento (**Idioma del usuario**).
    
    Como alternativa, puede especificar el valor de la propiedad  **PreferredLanguage**  en el Editor de modelos invocado para el módulo de aplicación. En este caso, el idioma del usuario se utilizará en las aplicaciones WinForms y ASP.NET formularios Web Forms.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/34cc1eac-8f2d-42c6-9fd4-5aa81a52b153)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Compruebe si el idioma corresponde al idioma actual de su sistema.
    
    Si no ha localizado la aplicación al idioma actual del sistema, se utilizará el idioma predeterminado (inglés).
    

Puede ver una aplicación de ejemplo localizada al alemán en la  **demostración principal**. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Agregar un elemento a la nueva acción


En esta lección, aprenderá a agregar un elemento a la  **acción Nueva**  (NewObjectViewController.NewObjectAction).[](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.NewObjectViewController.NewObjectAction?v=22.1)  Se usará la clase Business  **Event**  de la Biblioteca de Business Class.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)
>-   [Agregar una clase de la biblioteca de clases empresariales y usar el módulo Programador](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1)

Los elementos de  **la nueva**  acción se definen en el  [modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1)  mediante nodos secundarios del nodo  **CreatableItems**. Por lo tanto, para agregar un elemento a la  **nueva**  acción, es necesario agregar un elemento secundario al nodo  **CreatableItems**. De forma predeterminada, los objetos de negocio cuyas declaraciones están decoradas por  [CreatableItemAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.CreatableItemAttribute?v=22.1)  o  [DefaultClassOptionsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DefaultClassOptionsAttribute?v=22.1)  se pueden crear mediante la  **nueva**  acción desde cualquier vista. Sin embargo, la clase  **Event**  (agregada en el tema  [Agregar una clase desde la Biblioteca de clases empresariales (XPO](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1))) no tiene ninguno de estos atributos aplicados. Esta clase se declara en la  [biblioteca de clases empresariales](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1). Aunque es posible modificar los orígenes de la biblioteca y volver a compilar la biblioteca, es más conveniente realizar personalizaciones en el modelo de aplicación.

-   Para invocar el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1), haga doble clic en el archivo  _Model.DesignedDiffs.xafml_  del proyecto  _MySolution.Module._  En la vista de árbol, navegue hasta el nodo  **CreatableItems**. Si expande este nodo, verá los elementos que corresponden a las clases de negocio utilizadas en la aplicación. Estos elementos se generaron porque el atributo  **DefaultClassOptions**  se aplica a las clases correspondientes. Para agregar otro elemento, haga clic con el botón secundario en el nodo  **CreatableItems**  y elija  **Agregar...**  |  **CreatableItem**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/9b21125a-2f19-4e46-b348-976b1a10acdb)

    
-   Para el nodo recién creado, seleccione "Evento" en la lista desplegable  **ModelClass**. La propiedad  **Caption**  se establecerá automáticamente en "Evento del programador".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/f64391aa-1edd-4389-890b-266b67fbcedb)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Observe que el elemento  **Evento del programador**  se ha agregado  **a la lista**  desplegable Nueva acción. Este elemento permite crear objetos de  **evento**  cuando se muestran objetos de otro tipo en la vista de lista. Tenga en cuenta también que ya se ha asignado una imagen a este elemento.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/dd53f8e3-4aa5-4eb3-b57e-6aa100d2aa4a)

    

Puede ver los cambios realizados en esta lección en el Editor de modelos invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Agregar un elemento al control de navegación


En esta lección, aprenderá a agregar un elemento al control de navegación. Para ello, se utilizará la clase Business Class de Note de la biblioteca de Business  **Class**.

>NOTA
Antes de continuar, le recomendamos que revise las siguientes lecciones:
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)
>-   [Agregar una clase de la biblioteca de clases empresariales y usar el módulo Programador](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1)

-   Si la clase  **Note**  no se usa como antecesor en el código, deberá agregarla al proceso de generación de la interfaz de usuario. Para ello, utilice el Diseñador de  [módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). En el panel  **Tipos exportados**, enfoque los  **ensamblados a los que se hace referencia**  |  **DevExpress.Persistent.BaseImpl.Xpo.v22.1**  |  **Anote**  el elemento y presione la barra espaciadora. Consulte la lección  [Agregar una clase desde la Biblioteca de clases empresariales (XPO)](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1)  para obtener más información.
-   La estructura de navegación de la aplicación XAF se define mediante el nodo  **NavigationItems**  en el  [modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1). Para personalizar la navegación, invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  haciendo doble clic en el archivo  _Model.DesignedDiffs.xafml_  en el proyecto  _MySolution.Module._  En la vista de árbol, navegue hasta  **NavigationItems**  |  **Artículos**  |  **Predeterminado**  |  **Nodo Elementos**. Para agregar un elemento secundario al elemento de navegación requerido, haga clic con el botón secundario en el nodo  **Elementos**  y seleccione  **Agregar...**  |  **NavigationItem**  en el menú contextual invocado.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/cd89f2b7-8f76-420d-89b0-314a73d14dda)

    
-   Para el nodo recién agregado, seleccione "Note_ListView" en la lista desplegable  **Ver**. La propiedad  **Caption**  se establecerá automáticamente en "Nota". Opcionalmente, puede establecer un valor de  **ID fácil de**  usar.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e570d5b1-6313-4cd2-8b44-a9b4a817db51)

    
    Como ha visto, hay muchas vistas listas para usar disponibles en la lista desplegable  **Ver**. Estas vistas se generan automáticamente en función de las clases de negocio cargadas en el modelo de aplicación. Una de estas clases es  **Nota**. Por lo tanto, solo necesita agregar una vista correspondiente a la colección de elementos de navegación.
    
    >NOTA
    Puede establecer accesos directos para los elementos de navegación mediante la propiedad  **Acceso directo**. En este caso, no tendrá que usar un mouse para cambiar entre Vistas, incluso si el control de navegación está oculto a través de View | **Paneles** | **Navegación** | **Elemento de menú oculto**.
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Ahora tiene un elemento de navegación adicional que le permite agregar y editar notas de texto sin formato. Tenga en cuenta también que este elemento ya tiene una imagen asignada.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/518b0208-1edf-4760-8668-b8cc8d7d77aa)

    

>NOTA
Al definir una clase de negocio en la aplicación, puede aplicar el  [`DefaultClassOptionsAttribute`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DefaultClassOptionsAttribute?v=22.1) o el atributo  [`NavigationItemAttribute`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.NavigationItemAttribute?v=22.1) en lugar de utilizar el modelo de aplicación. Consulte la  lección  [Heredar de la clase de biblioteca de clase empresarial (XPO).](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)

Puede ver los cambios realizados en esta lección en el Editor de modelos invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**


# Implementar la validación del valor de la propiedad en el modelo de aplicación

En esta lección, aprenderá a comprobar si un valor de propiedad satisface o no una regla determinada. Para ello, se utilizarán la propiedad  **DemoTask.Status**  y la acción  **MarkCompleted**. Esta acción no debe ejecutarse si el estado actual de la tarea es "NotStarted". Por lo tanto, la regla se comprobará al ejecutar la acción  **MarkCompleted**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Implementar la validación del valor de la propiedad en el código](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

La funcionalidad de validación la proporciona el  [módulo](https://docs.devexpress.com/eXpressAppFramework/113684/validation-module?v=22.1)  de validación que se agregó en la lección  [Implementar validación de valor de propiedad en código (XPO).](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)  Cuando este módulo se agrega al proyecto  _MySolution.Module_, el nodo  **Validación**  está disponible en Application  [Model](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1). Este nodo define los  **contextos**  y  **reglas**  de validación utilizados en la aplicación. Puede utilizar el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para agregar reglas y especificar  **contextos**.

-   Invoque el Editor de modelos para el proyecto  _MySolution.Module._  Vaya a la  **Validación**  |  **Nodo Reglas**. Ya contiene nodos secundarios que definen las reglas que se deben verificar. Por ejemplo, puede contener la regla "**RuleRequiredField for Position.Title**" que se implementó en la lección  [Implementar validación de valor de propiedad en código (XPO).](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)  Para agregar una nueva regla que compruebe criterios específicos, haga clic con el botón secundario en el nodo  **Reglas**  y seleccione  **Agregar...**  |  **RuleCriteria**.
    
    ![Tutorial_UIC_Lesson14_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson14_1115502.png?v=22.1)
    
    >NOTA
    Las descripciones de todos los tipos de reglas disponibles están disponibles en el tema  [Reglas de validación](https://docs.devexpress.com/eXpressAppFramework/113008/validation/validation-rules?v=22.1).
    
-   Para el nodo recién creado, establezca  **TargetType**  en "MySolution.Module.BusinessObjects.DemoTask" y establezca la propiedad  **Criteria**  en . Establezca la propiedad  **ID**  en "TaskIsNotStarted",  **TargetContextIDs**  en "MarkCompleted" y  **CustomMessageTemplate**  en "No se puede establecer la tarea como completada porque no se ha iniciado".`Status != 'NotStarted'`
    
    ![Tutorial_UIC_Lesson14_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson14_2115508.png?v=22.1)
    
    >NOTA
    El valor de la propiedad Criteria debe especificarse mediante la [sintaxis del lenguaje Criteria](https://docs.devexpress.com/CoreLibraries/4928/devexpress-data-library/criteria-language-syntax?v=22.1). Para simplificar esta tarea, puede invocar el cuadro de diálogo  **Generador de filtros** haciendo clic en el botón de puntos suspensivos (![EllipsisButton](https://docs.devexpress.com/eXpressAppFramework/images/ellipsisbutton116182.png?v=22.1)) situado a la derecha del valor  **Criterios**. Dentro de este cuadro de diálogo, puede diseñar visualmente una expresión de criterio.
    
-   La propiedad  **TargetContextIDs**  se establece en "MarkCompleted". Esto significa que la regla se comprobará al ejecutar la acción cuya propiedad  **ValidationContexts**  está establecida en "MarkCompleted". Por lo tanto, establezca la propiedad  **ValidationContexts de**  la acción  **Marcar**  completado (en  **ActionDesign**  |  **Acciones**  |  **Task.MarkCompleted**) a "MarkCompleted".
    
    ![Tutorial_UIC_Lesson14_2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson14_2_1116422.png?v=22.1)
    
    >NOTA
    También puede utilizar los contextos  **Guardar** o **Eliminar**, que están disponibles de forma predeterminada. Las reglas con estos contextos se validan cuando se guarda o elimina un objeto, respectivamente (consulte [Reglas de validación](https://docs.devexpress.com/eXpressAppFramework/113008/validation/validation-rules?v=22.1)).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Asigne el valor "Not Started" a la propiedad  **Status**  de uno de los objetos  **DemoTask**  existentes. Haga clic en el botón  **MarkCompleted**. Se mostrará el siguiente cuadro de diálogo  **Error de validación**.
    
    ![Tutorial_UIC_Lesson14_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson14_4116421.png?v=22.1)
    

>NOTA
Por lo general, puede agregar la regla necesaria a una clase o propiedad en el código (vea [Implementar la validación del valor de propiedad en el código](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)). El enfoque definido anteriormente es útil cuando las fuentes de clase son inaccesibles.

Puede ver los cambios realizados en esta lección en el Editor de modelos invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Implementar la validación del valor de la propiedad en el modelo de aplicación

En esta lección, aprenderá a comprobar si un valor de propiedad satisface o no una regla determinada. Para ello, se utilizarán la propiedad  **DemoTask.Status**  y la acción  **MarkCompleted**. Esta acción no debe ejecutarse si el estado actual de la tarea es "NotStarted". Por lo tanto, la regla se comprobará al ejecutar la acción  **MarkCompleted**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Implementar la validación del valor de la propiedad en el código](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

La funcionalidad de validación la proporciona el  [módulo](https://docs.devexpress.com/eXpressAppFramework/113684/validation-module?v=22.1)  de validación que se agregó en la lección  [Implementar validación de valor de propiedad en código (XPO).](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)  Cuando este módulo se agrega al proyecto  _MySolution.Module_, el nodo  **Validación**  está disponible en Application  [Model](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1). Este nodo define los  **contextos**  y  **reglas**  de validación utilizados en la aplicación. Puede utilizar el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para agregar reglas y especificar  **contextos**.

-   Invoque el Editor de modelos para el proyecto  _MySolution.Module._  Vaya a la  **Validación**  |  **Nodo Reglas**. Ya contiene nodos secundarios que definen las reglas que se deben verificar. Por ejemplo, puede contener la regla "**RuleRequiredField for Position.Title**" que se implementó en la lección  [Implementar validación de valor de propiedad en código (XPO).](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)  Para agregar una nueva regla que compruebe criterios específicos, haga clic con el botón secundario en el nodo  **Reglas**  y seleccione  **Agregar...**  |  **RuleCriteria**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/5eff7e0a-cb80-4df8-8e7a-945ca9a37bc1)

    
    >NOTA
    Las descripciones de todos los tipos de reglas disponibles están disponibles en el tema  [Reglas de validación](https://docs.devexpress.com/eXpressAppFramework/113008/validation/validation-rules?v=22.1).
    
-   Para el nodo recién creado, establezca  **TargetType**  en "MySolution.Module.BusinessObjects.DemoTask" y establezca la propiedad  **Criteria**  en . Establezca la propiedad  **ID**  en "TaskIsNotStarted",  **TargetContextIDs**  en "MarkCompleted" y  **CustomMessageTemplate**  en "No se puede establecer la tarea como completada porque no se ha iniciado".`Status != 'NotStarted'`
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/203f4cf3-6bac-472c-8419-ec45aa5ca6cd)

    
    >NOTA
    El valor de la propiedad Criteria debe especificarse mediante la [sintaxis del lenguaje Criteria](https://docs.devexpress.com/CoreLibraries/4928/devexpress-data-library/criteria-language-syntax?v=22.1). Para simplificar esta tarea, puede invocar el cuadro de diálogo  **Generador de filtros** haciendo clic en el botón de puntos suspensivos (![EllipsisButton](https://docs.devexpress.com/eXpressAppFramework/images/ellipsisbutton116182.png?v=22.1)) situado a la derecha del valor  **Criterios**. Dentro de este cuadro de diálogo, puede diseñar visualmente una expresión de criterio.
    
-   La propiedad  **TargetContextIDs**  se establece en "MarkCompleted". Esto significa que la regla se comprobará al ejecutar la acción cuya propiedad  **ValidationContexts**  está establecida en "MarkCompleted". Por lo tanto, establezca la propiedad  **ValidationContexts de**  la acción  **Marcar**  completado (en  **ActionDesign**  |  **Acciones**  |  **Task.MarkCompleted**) a "MarkCompleted".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b0ad2b03-f508-43dd-ab48-67311d7f2348)

    
    >NOTA
    También puede utilizar los contextos  **Guardar** o **Eliminar**, que están disponibles de forma predeterminada. Las reglas con estos contextos se validan cuando se guarda o elimina un objeto, respectivamente (consulte [Reglas de validación](https://docs.devexpress.com/eXpressAppFramework/113008/validation/validation-rules?v=22.1)).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Asigne el valor "Not Started" a la propiedad  **Status**  de uno de los objetos  **DemoTask**  existentes. Haga clic en el botón  **MarkCompleted**. Se mostrará el siguiente cuadro de diálogo  **Error de validación**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/eacf4941-ab2d-4aa0-8cbd-d7df7088d822)

    

>NOTA
Por lo general, puede agregar la regla necesaria a una clase o propiedad en el código (vea [Implementar la validación del valor de propiedad en el código](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)). El enfoque definido anteriormente es útil cuando las fuentes de clase son inaccesibles.

Puede ver los cambios realizados en esta lección en el Editor de modelos invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Personalizar el diseño Ver elementos

En esta lección, aprenderá a personalizar el diseño predeterminado del editor en una vista de detalles. Para ello, se utilizará la Vista de detalles de contacto.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Navegar a las  **vistas**  |  **Nodo MySolution.Module.BusinessObjects.**  Expanda el nodo secundario  **Contact_DetailView**. Contiene los nodos secundarios  **Items**  y  **Layout**. Para ver y modificar el diseño actual de los editores de Vista de detalles de contacto, seleccione el nodo  **Diseño**. La lista de propiedades de la derecha se reemplazará por una superficie de diseño que imita la vista de detalles de contacto. Para modificar la disposición del editor, haga clic con el botón derecho en el espacio vacío de la vista y elija  **Personalizar diseño**.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ccc1343d-3929-4aaa-a785-0f3ded1d63f2)

Se invocará el  **formulario de personalización**. En el formulario invocado, puede arrastrar editores a las posiciones requeridas.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/dfaf2338-7719-4b25-9a42-fe95b5a07aa7)

Siga las indicaciones gráficas que indican la nueva ubicación del elemento. Además, puede quitar y restaurar  **elementos de vista**. Arrastre el elemento necesario desde la Vista de detalles hasta el formulario de personalización para quitar el elemento y arrastre el elemento desde el  **Formulario**  de  **personalización**  a la  **Vista de detalles**  para agregarlo.

Para ver el árbol de diseño de Ver elementos, haga clic en la ficha  **Vista de árbol de diseño**  del  **formulario de personalización**. Puede hacer clic derecho en un elemento de árbol e invocar un menú contextual, lo que le permite ocultar el  **formulario de personalización**, restablecer el diseño, crear un grupo con pestañas, etc. (Vea la imagen a continuación).

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a7341aa4-21a4-443d-b63e-24ff00d4c9ad)


Para obtener más información sobre el formulario  **Personalización**, la pestaña  **Vista de árbol de diseño**  y su menú contextual, consulte el tema Personalización predeterminada del  [tiempo de ejecución](https://docs.devexpress.com/WindowsForms/2307/controls-and-libraries/form-layout-managers/layout-and-data-layout-controls/design-time-and-runtime-customization/default-runtime-customization?v=22.1).

Cierre el  **formulario de personalización**. Ejecute la aplicación WinForms o ASP.NET formularios Web Forms e invoque una vista de detalles  **de contacto**. Tenga en cuenta que los editores están organizados según sea necesario.

Si desea restablecer los cambios, haga clic con el botón derecho  **en Contact_DetailView**  |  **Diseño**  y elija  **Restablecer diferencias**.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c7737e45-c403-4c11-a6f2-0f3e896e5d15)

>NOTA
Como alternativa, puede personalizar el diseño de la vista de detalles de  **contacto**  en  tiempo de ejecución y, a continuación, combinar estas personalizaciones en **Misolución.Proyecto de módulo**. Consulte el tema  [Cómo: Combinar personalizaciones de usuario final en la solución XAF](https://docs.devexpress.com/eXpressAppFramework/113335/ui-construction/application-model-ui-settings-storage/application-model-storages/merge-end-user-customizations-model?v=22.1) para obtener más información.



# Agregar un editor a una vista de detalles


En esta lección se explica cómo agregar un editor a una  [vista de detalles](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1). En este ejemplo, agregamos un editor para la propiedad  **Department.Office**  a la vista de detalles de  **contacto**.

>NOTA
Antes de continuar, tómese un momento para repasar la siguiente lección:
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

## Instrucciones paso a paso

1.  Abra el archivo  _Model.DesignedDiffs.xafml_  en el Editor de  [modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1).
    
2.  Navegar a las  **vistas**  |  **MySolution.Module.BusinessObjects**  |  **Nodo de contacto**. Expanda el nodo secundario  **Contact_DetailView**  y haga clic en el nodo  **Diseño**.
    
3.  El Editor de modelos muestra una superficie de diseño que imita la vista Detalles de  **contacto**. Haga clic con el botón derecho en el espacio vacío de la vista y elija  **Personalizar diseño**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e336dbea-0e35-4887-8fbd-4372d3c068f4)

    
4.  En la ventana  **Personalización**  invocada, haga clic en el botón  **Agregar**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/5a065c8c-0c50-4dc4-b8b5-af408944ddc0)

    
5.  En el cuadro de diálogo  **Modelo de objetos**, expanda el nodo  **Departamento**, active la casilla  **Office**  y haga clic en  **Aceptar**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b757dde7-d496-43fc-b9bc-118819f5d673)

    
6.  El elemento Office: aparece en la pestaña  **Elementos ocultos**  de la ventana  **Personalización****:**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/09262827-8d24-4f72-8b2c-13883263f88a)

    
7.  Arrastre el elemento  **Office:**  a la posición requerida de la Vista de detalles de  **contacto**.
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b989c4b6-47b1-4852-b1ea-b03ee63ccdf9)


8.  Ejecute la aplicación WinForms o ASP.NET formularios Web Forms e invoque una vista de  **detalles de contacto**. El editor de  **Office**  se encuentra en la misma columna que el editor de  **departamento**, el editor de  **posición**  y otros editores.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a3092abb-01c0-4455-b41e-4946fabdd140)

    

Puede ver los cambios realizados en esta lección en el  **Editor de modelos**  invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .

## Explicación detallada

### Personalización del diseño

En el modo de personalización que activamos en el  _paso 3_  de esta lección, puede cambiar el diseño de la vista detallada. Consulte el tema siguiente para obtener más información:  [Personalizar el diseño Ver elementos](https://docs.devexpress.com/eXpressAppFramework/112833/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/customize-the-view-items-layout?v=22.1).

Los usuarios también pueden personalizar el diseño de la vista detallada. En el tema siguiente se describe cómo cambiar el diseño en tiempo de ejecución:  [Personalización predeterminada del motor en tiempo de ejecución](https://docs.devexpress.com/WindowsForms/2307/controls-and-libraries/form-layout-managers/layout-and-data-layout-controls/design-time-and-runtime-customization/default-runtime-customization?v=22.1).

Además, puede personalizar el diseño de la vista de detalles de  **contacto**  en tiempo de ejecución y combinar estos cambios en el proyecto  **MySolution.Module.**  Consulte el tema siguiente para obtener más información:  [Cómo: Combinar personalizaciones de usuario final en la solución XAF](https://docs.devexpress.com/eXpressAppFramework/113335/ui-construction/application-model-ui-settings-storage/application-model-storages/merge-end-user-customizations-model?v=22.1).


# Cambiar el diseño y la visibilidad del campo en una vista de lista


Esta lección le guiará a través de los pasos necesarios para seleccionar las columnas que se muestran en la  **vista de lista**. Para ello, se utilizará la vista Lista de  **contactos**. En tiempo de ejecución, puede hacer clic con el botón secundario en un encabezado de columna y activar el  **selector**  de columnas y, a continuación, arrastrar columnas invisibles desde la ventana  **Selector de columnas**  hasta el control de cuadrícula. Para establecer el diseño de tabla predeterminado, debe personalizarlo en tiempo de diseño.

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1).

En una aplicación WinForms, las personalizaciones realizadas mediante el  **selector de columnas en tiempo de ejecución**  se conservan en un archivo  _Model.user.xafml_, ubicado en la carpeta de la aplicación de forma predeterminada. En una aplicación de formularios Web Forms ASP.NET, es posible que deba establecer la propiedad SaveListViewStateInCookies del nodo  **Opciones**  y la propiedad  **SaveStateInCookies**  de las  **vistas**  correspondientes |  **_<ListView>_**  nodo a "true". Esto le permite guardar el estado de la vista de lista entre sesiones en las cookies del navegador de un usuario, lo que permite a cada usuario final personalizar la  **vista de lista**  individualmente. El conjunto de columnas visibles de forma predeterminada se genera en función de las reglas descritas en el artículo  [Generación de columnas de vista de lista](https://docs.devexpress.com/eXpressAppFramework/113285/ui-construction/views/layout/list-view-column-generation?v=22.1). Es posible que sea necesario personalizar el conjunto de columnas predeterminado. Para hacer que las columnas obligatorias sean visibles o invisibles dentro de la  **vista de lista**  de forma predeterminada, utilice el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1).

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module_  y navegue hasta  **Vistas**  |  **MySolution.Module.BusinessObjects**  |  **Contact_ListView**  |  **Nodo Columnas**  para invocar el Diseñador del Editor de  **listas de cuadrículas**. Mostrará la estructura predeterminada de la vista de  **lista**. Puede personalizar la apariencia predeterminada de la vista de lista arrastrando, cambiando el tamaño y agrupando las columnas. Invoque la ventana  **Personalización**  haciendo clic con el botón secundario en el encabezado de la tabla y seleccionando  **Selector de columnas**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/4024290d-905a-4db1-b343-c79fd7d6ba01)

    
-   Por ejemplo, personalice la vista de lista para mostrar las siguientes columnas.
    
    1.  **Nombre completo**
    2.  **Posición**
    3.  **Departamento**
    4.  **Correo electrónico**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/aeea5f57-3bb1-4a13-85da-fdbb6b4a3a38)

-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Vea si la vista de lista de  **contactos**  se parece a la siguiente imagen.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/8253a5c3-a55f-4ab3-ae89-fca9cec17320)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/bbc21a7a-5003-4fd8-a7e0-3d6c5398cecc)

    
    >PROPINA
    Cuando la ventana del navegador se reduce, algunas columnas se ocultan y se puede acceder a ellas mediante el botón "..." .
    
    Si anteriormente personalizó la visibilidad de las columnas Vista de lista de  **contactos**  en tiempo de ejecución, no se aplicará el nuevo conjunto de columnas visibles. Para quitar la personalización anterior en una aplicación WinForms, haga clic en el botón  **Restablecer configuración de vista**. Como alternativa, puede invocar el  **Editor de modelos en tiempo de ejecución**  (mediante  **Herramientas**  |  **Elemento de menú Editar modelo**), haga clic con el botón derecho en  **Vistas**  |  **Contact_ListView**  nodo y seleccione  **Restablecer diferencias**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/9be96930-afc7-45a3-86e2-78858e5f6767)

    

Puede ver los cambios realizados en la lección en el Editor de modelos invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .

>NOTA
Como alternativa, puede personalizar el orden y la visibilidad de las columnas cambiando el valor de la propiedad  **Index** de columnas específicas (nodos secundarios  **del nodo Columns**). Consulte el artículo  [Personalización de columnas de vista de lista](https://docs.devexpress.com/eXpressAppFramework/113679/ui-construction/views/layout/list-view-columns-customization?v=22.1) para obtener más información.

>PROPINA
Puede organizar las columnas en grupos lógicos (bandas). Para obtener más información, consulte el tema  [Diseño de bandas de vista de lista](https://docs.devexpress.com/eXpressAppFramework/113695/ui-construction/views/layout/list-view-bands-layout?v=22.1).



# Mostrar una vista detallada con una vista de lista

En esta lección, aprenderá a mostrar una vista  **detallada**  junto con una  **vista de lista**. Para ello, se utilizará la vista de lista de  **departamentos**. El objeto seleccionado en él se mostrará en la  **Vista de detalles**  correspondiente.

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1).

Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Navegar a las  **vistas**  |  **MySolution.Module.BusinessObjects**  |  **Department_ListView**  nodo. Define la  **vista de lista**  que se utiliza para los objetos  **de departamento**  mediante las propiedades de la derecha. En la lista desplegable de la propiedad  [MasterDetailMode](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelListView.MasterDetailMode?v=22.1), seleccione  **ListViewAndDetailView**.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ab6b0d73-6b6c-49be-808b-38e6dd4e0183)


Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. La vista Lista  **de departamentos**  aparecerá de la siguiente manera.

**Aplicación WinForms**

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a48cea78-1f34-432e-85d0-27ee3242b004)


**ASP.NET Aplicación de formularios Web Forms**

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/5b6d3355-7e2d-4d63-8f1c-aedcd4476d84)

En la aplicación WinForms, utilice los botones  **Guardar**  () o  **GuardarAndCerrar**  (![btn_SaveClose](https://docs.devexpress.com/eXpressAppFramework/images/btn_saveclose117425.png?v=22.1)![btn_Save](https://docs.devexpress.com/eXpressAppFramework/images/btn_save117423.png?v=22.1)) de la barra de herramientas para confirmar los cambios realizados en la  **Vista de detalles**. Para cancelar los cambios, utilice el botón  **Cancelar**  (![btn_Cancel](https://docs.devexpress.com/eXpressAppFramework/images/btn_cancel117426.png?v=22.1)).

>NOTA
>-   Puede especificar la DetailView  que debe mostrarse junto con la ListView  (consulte [ListView.DetailViewId](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ListView.DetailViewId?v=22.1)).
>-   Para especificar la ubicación de la **DetailView**, utilice el [IModelSplitLayout.Direction](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelSplitLayout.Direction?v=22.1) y [IModelListViewSplitLayout.ViewsOrder](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelListViewSplitLayout.ViewsOrder?v=22.1)  de  orden de la **ListView** | **SplitLayout**.
>-   La acción Restablecer configuración de  **vista** restablece la configuración de las vistas de lista y detalle en el modo de visualización Vista de  **ListViewAndDetailView**.

En la aplicación ASP.NET formularios Web Forms, la opción  [IModelListViewWeb.DetailRowMode](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.SystemModule.IModelListViewWeb.DetailRowMode?v=22.1)  es similar a  **MasterDetailMode**, pero permite mostrar una vista detallada en la  [fila de detalles](https://docs.devexpress.com/AspNet/3769/components/grid-view/visual-elements/detail-row?v=22.1)  de una vista de lista.

Puede ver los cambios realizados en esta lección en el  **Editor de modelos**  invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module**  y el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.Web.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Hacer editable una vista de lista


En esta lección, aprenderá a hacer que una  **vista de lista**  sea editable. Para ello, se utilizará la vista  **Lista DemoTask**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Establecer una relación de muchos a muchos](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Navegar a las  **vistas**  |  **MySolution.Module.BusinessObjects**  |  **DemoTask_ListView**  nodo. Define la  **vista de lista**  que se utiliza para los objetos  **DemoTask**  con las propiedades a la derecha. En la lista desplegable de la propiedad  **AllowEdit**, seleccione "True". Cuando esta propiedad se establece en "True", la  **vista de lista**  es editable.
    
    Cuando las  **vistas de lista**  se muestran en modo de edición, puede aplicar la funcionalidad  **NewItemRow**  de  **XtraGrid**  que muestra  **ListViews**  en aplicaciones XAF. Esta funcionalidad permite a los usuarios finales crear nuevos objetos directamente en una vista de  **lista**  sin una  **vista de detalle**. Para agregar esta funcionalidad, establezca la propiedad  **NewItemRowPosition**  en  **Top**  o  **Bottom**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c2de0462-23f6-48e0-83f0-c1c1304e116e)

    
    >PROPINA   
    En las aplicaciones de formularios Web Forms ASP.NET, hay varios modos de edición.  Para establecer el modo necesario, utilice [IModelListViewWeb.InlineEditMode](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.SystemModule.IModelListViewWeb.InlineEditMode?v=22.1) el **Editor de modelos** invocado para _MySolution.Module.Web_. Varios modos de edición se ilustran en el tema  [Modos de edición de vista de lista](https://docs.devexpress.com/eXpressAppFramework/113249/ui-construction/views/list-view-edit-modes?v=22.1) (sección  **Funcionalidad específica de formularios Web Forms de ASP.NET**).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms y edite uno de los objetos  **DemoTask**  en la  **vista de lista**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/9c5ba115-3f11-4fc7-bd17-73476f27c8c7)

    
    Para editar uno de los objetos  **DemoTask**  en una aplicación ASP.NET de formularios Web Forms, haga clic en  **Editar**() o haga clic en  **Nuevo**(![InlineEdit_NewButton](https://docs.devexpress.com/eXpressAppFramework/images/inlineedit_newbutton116547.png?v=22.1)![InlineEdit_EditButton](https://docs.devexpress.com/eXpressAppFramework/images/inlineedit_editbutton116546.png?v=22.1)) para crear una nueva  **tarea**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/60341f17-440c-4546-a54b-9ce2e0f2d582)

    
    En una aplicación WinForms, para guardar los cambios realizados en un objeto, haga clic en el botón  **Guardar**  () o  **GuardarAndCerrar**  (![btn_SaveClose](https://docs.devexpress.com/eXpressAppFramework/images/btn_saveclose117425.png?v=22.1)![btn_Save](https://docs.devexpress.com/eXpressAppFramework/images/btn_save117423.png?v=22.1)) de la barra de herramientas. Para cancelar los cambios, haga clic en el botón  **Cancelar**  (![btn_Cancel](https://docs.devexpress.com/eXpressAppFramework/images/btn_cancel117426.png?v=22.1)).
    
    En la aplicación ASP.NET formularios Web Forms, para guardar los cambios, haga clic en  **Actualizar**  (![btn_Save](https://docs.devexpress.com/eXpressAppFramework/images/btn_save117423.png?v=22.1)). Para cancelar los cambios, haga clic en  **Cancelar**  (![btn_Cancel](https://docs.devexpress.com/eXpressAppFramework/images/btn_cancel117426.png?v=22.1)).
    

>NOTA
>-   Las vistas de lista en  [los modos de acceso a](https://docs.devexpress.com/eXpressAppFramework/113683/ui-construction/views/list-view-data-access-modes?v=22.1)  datos Vista de  datos, Vista de servidor y Vista decomentariosinstantáneos no admiten esta funcionalidad.
>-   Puede establecer el modo de edición en el código. Para ello, aplique el atributo  [DefaultListViewOptionsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.DefaultListViewOptionsAttribute?v=22.1)  a la clase **DemoTask**.

Para ver los cambios realizados en esta lección, invoque el  **Editor de modelos**  para los proyectos MainDemo.Module, MainDemo.Module.Win y  **MainDemo.Module.Web**  de la  **demostración principal****.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .



# Agregar una vista previa a una vista de lista
En esta lección, aprenderá a mostrar una sección de vista previa en la cuadrícula de una  **vista de lista**. Para ello, se utilizará la vista  **Lista DemoTask**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Establecer una relación de muchos a muchos](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

[ASPxGridListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor?v=22.1)  presenta la vista de lista  **DemoTask**  en la aplicación ASP.NET formularios Web Forms y  [GridListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.Editors.GridListEditor?v=22.1)  en la aplicación WinForms. Estos  **editores de listas**admiten la característica  **de vista previa automática**  proporcionada por los controles  **ASPxGridView**  y  **XtraGrid**. Para habilitar esta característica, debe abrir el  **Editor de modelos**  y asignar el valor Vista de  **lista**  a la propiedad  **PreviewColumnName**. Cuando esta propiedad no está establecida, la característica se deshabilita. Está deshabilitado de forma predeterminada.

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto MySolution.Module. Navegar a las  **vistas**  |  **MySolution.Module.BusinessObjects**  |  **DemoTask_ListView**  nodo. Define la vista de lista que se utiliza para los objetos DemoTask a través de las propiedades de la derecha. Establezca la propiedad  **PreviewColumnName**  en "Description". Como resultado, el texto de la sección de vista previa se recuperará de la propiedad  **DemoTask.Description.**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/4bc3354e-79db-4392-8c11-ad6f4d0aaa61)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Desplácese hasta la vista  **Lista de tareas demo**. Compruebe que la sección de vista previa está habilitada y muestra la propiedad  **DemoTask.Description.**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2cfb6a31-245a-4e4d-a5f7-2ff237eda3c3)

    

Para ver los cambios realizados en esta lección, invoque el  **Editor de modelos**  para los proyectos MainDemo.Module, MainDemo.Module.Win y  **MainDemo.Module.Web**  de la  **demostración principal****.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Filtrar vistas de lista

En esta lección, aprenderá a filtrar una vista de  **lista**. Se ilustrarán tres técnicas, basadas en diferentes escenarios. Para esta lección, se aplicará un filtro a la vista Lista de  **contactos**.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implementar clases empresariales personalizadas y propiedades de referencia](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Establecer una relación de uno a muchos](https://docs.devexpress.com/eXpressAppFramework/112733/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-one-to-many-relationship-xpo?v=22.1)
>-   [Origen de datos del editor de búsqueda de filtros](https://docs.devexpress.com/eXpressAppFramework/112755/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/filter-lookup-editor-data-source?v=22.1)
>-   [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

## Activar una acción de filtrado

Utilice este enfoque para permitir que un usuario final aplique filtros predefinidos a una vista de  **lista**  determinada. Con este enfoque, la acción  **SetFilter**  (cuyos elementos representan filtros predefinidos) es visible en la interfaz de usuario. Esta acción se activa solo para  **vistas de lista**. Los filtros predefinidos se pueden agregar en el  [modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1)  y se representan mediante nodos secundarios de las  **vistas**  |  **_<ListView>_**  | Nodo  **Filtros**  (consulte  [Nodo Modelo de aplicación de filtros](https://docs.devexpress.com/eXpressAppFramework/112992/filtering/in-list-view/filters-application-model-node?v=22.1)).

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Navegar a las  **vistas**  |  **MySolution.Module.BusinessObjects**  |  **Contact_ListView**  nodo. Haga clic con el botón derecho en el nodo secundario  **Filtros**  y seleccione  **Nuevo**  |  **ListViewFilterItem**. Para el nuevo nodo, establezca la propiedad  **Id**  en "Contactos del departamento de desarrollo". Para especificar un criterio, establezca la propiedad  **Criteria**  en el valor.`[Department.Title] = 'Development Department'`
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ffaaea65-40c1-4136-9c87-8d01718a7fda)

    
    >NOTA
    El valor de la propiedad Criteria debe especificarse mediante la [sintaxis del lenguaje Criteria](https://docs.devexpress.com/CoreLibraries/4928/devexpress-data-library/criteria-language-syntax?v=22.1). Para simplificar esta tarea, puede invocar el cuadro de diálogo  **Generador de filtros** haciendo clic en el botón de puntos suspensivos (![EllipsisButton](https://docs.devexpress.com/eXpressAppFramework/images/ellipsisbutton116182.png?v=22.1)) situado a la derecha del valor  **Criterios**. En este cuadro de diálogo, puede diseñar una expresión de criterio mediante el **Generador de filtros**  visual.
    
-   Agregue un nodo  **Filter**  más al nodo  **Filters**  como se definió anteriormente. Establezca la propiedad  **Id**  en "Developers" y la propiedad  **Criteria**  en .`Position.Title = 'Developer'`
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a8fa42c9-8e4f-4485-b7f8-6eecb6665de9)

-   Para poder ver todos los objetos  **Contact**  en la  **vista de lista**, agregue un nodo  **Filter**  más al nodo  **Filters**, como se ha definido anteriormente. Establezca la propiedad  **Id**  en "Todos los contactos" y deje vacía la propiedad  **Criteria**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/8376354c-1f33-48da-ab2d-bf8b8495274a)

    
-   Para el nodo  **Filters**, establezca la propiedad  **CurrentFilter**  en "Developers". Guarde los cambios.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/26e150ba-5bcf-4a5a-a2f4-5b68feba78a2)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms y seleccione el elemento  **Contactos**  en el control de navegación. Observe que la acción  **SetFilter**  ya está disponible.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e069e6cb-d939-4d94-a903-66405a62632d)

    

## Usar la aplicación del Editor de modelos | Vistas | Nodo Vista de lista

Utilice este enfoque para filtrar una  **vista de lista**  a través del  **Editor de modelos**. Los filtros aplicados con el  **Editor de modelos**  no pueden ser modificados por los usuarios finales.

-   **Ejecute el Editor de modelos**  para el proyecto  _MySolution.Module._  Navegar a las  **vistas**  |  **MySolution.Module.BusinessObjects**  |  **Contact_ListView**  nodo. Establezca su propiedad  **Criteria**  en .`Position.Title = 'Developer'`
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/d2922076-0340-4475-8521-4ca0b622ffd4)

-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Seleccione el elemento  **Contactos**  en el control de navegación y compruebe si los objetos de  **contacto**  de la  **vista de lista**  están filtrados.

## Filtrar por nivel de origen de datos

Utilice este enfoque si necesita aplicar filtros que no se cambiarán en tiempo de ejecución o mediante el  **Editor de modelos**.

-   Cree un controlador de  **View y**  genere el controlador de eventos  **Activated**, tal como se define en el tutorial  [Agregar una acción simple](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1), así como las demás lecciones de la sección  [Ampliar funcionalidad](https://docs.devexpress.com/eXpressAppFramework/112740/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality?v=22.1).
-   Reemplace el código generado para el controlador de eventos  **Activated**  con el código siguiente.
    

    ```csharp
    using DevExpress.Data.Filtering;
    using MySolution.Module.BusinessObjects;
    // ...
    public partial class FilterListViewController : ViewController {
       // ...
       private void FilterListViewController_Activated(object sender, EventArgs e) {
          if ((View is ListView) & (View.ObjectTypeInfo.Type == typeof(Contact))) {
             ((ListView)View).CollectionSource.Criteria["Filter1"] = new BinaryOperator(
                "Position.Title", "Developer", BinaryOperatorType.Equal);
          }
       }
    }
    
    ```
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms y seleccione el elemento  **Contactos**  en el control de navegación. Compruebe si los objetos de  **contacto de**  la  **vista de lista**  están filtrados.


# Aplicar agrupación a datos de vista de lista


Esta lección le enseñará cómo aplicar la agrupación a los datos de  **la vista de lista**. Para ello, agrupará los datos de Vista de lista  **de contactos**  por la propiedad  **Departamento**.

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Colocar una acción en una ubicación diferente](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1).
-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  _MySolution.Module._  Navegar a las  **vistas**  |  **MySolution.Module.BusinessObjects**  |  **Contact_ListView**  |  **Nodo Columnas**  para invocar el Diseñador del Editor de  **listas de cuadrículas**. Mostrará la estructura predeterminada de la vista de lista. Puede personalizar la apariencia predeterminada de la vista de lista. Para invocar la ventana Personalización, haga clic con el botón secundario en el encabezado de la tabla y seleccione  **Mostrar grupo por cuadro**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/fa227d7e-707b-4a21-815e-eba6fd3e9800)

    
-   Esto establecerá la propiedad  **IsGroupPanelVisible**  de  **Contact_ListView**  en true y mostrará un área de grupo especial para las vistas de lista de  **contactos**  en las aplicaciones WinForms y ASP.NET formularios Web Forms. Para especificar la columna por la que se agrupará la vista de lista de  **contactos**  de forma predeterminada, arrastre el encabezado de la columna al área de grupo. Se puede aplicar una agrupación anidada arrastrando varias columnas al área de grupo. Agrupe la vista Lista de  **contactos**  en la columna  **Departamento**  y, a continuación, en la columna  **Posición**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/182010d7-f31b-4ff1-9634-8fb6b43e22eb)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms y seleccione el elemento  **Contactos**  en el control de navegación. El área de grupo se muestra en la vista Lista de  **contactos**. El orden de las columnas dentro de esta área representa el orden de anidamiento de los grupos de datos. La vista Lista de  **contactos**  está agrupada por las columnas  **Departamento**  y  **Puesto**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/973424b5-0bed-4e49-a7a9-760ae15b4061)

    
-   Puede especificar esta área de grupo en tiempo de ejecución de forma similar al método descrito anteriormente. Si desea restablecer los cambios, haga clic en  **el botón Restablecer configuración de vista**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/626425d2-d054-44ac-81a8-e803eedc62aa)

    

>NOTA
Existe otro enfoque para la agrupación basado en cambiar el valor de la propiedad  **Group Index de** columnas específicas (nodos secundarios  **del nodo Columns**). Consulte el artículo  [Personalización de columnas de vista de lista](https://docs.devexpress.com/eXpressAppFramework/113679/ui-construction/views/layout/list-view-columns-customization?v=22.1) para obtener más información.

Puede ver los cambios realizados en esta lección en el  **Editor de modelos**  invocado para el archivo  _Model.DesignedDiffs.xafml_  ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Elija el tipo de interfaz de usuario de formularios de Windows

En esta lección, aprenderá a cambiar el tipo de interfaz de usuario de la aplicación WinForms. De forma predeterminada, el  [Asistente para soluciones](https://docs.devexpress.com/eXpressAppFramework/113624/installation-upgrade-version-history/visual-studio-integration/solution-wizard?v=22.1)  habilita la interfaz de  [varios documentos](https://docs.devexpress.com/WindowsForms/11355/controls-and-libraries/application-ui-manager/views/tabbed-view?v=22.1)  (**MDI**). Puede cambiar esta configuración a través del  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  o en el código. Por ejemplo, puede seleccionar  **Interfaz de documento único (SDI)**  para su aplicación.

Siga los pasos siguientes para cambiar el tipo de interfaz de usuario de la aplicación WinForms mediante el Editor de modelos:

-   Invoque el  **Editor de modelos**  haciendo doble clic en el archivo  _Model.xafml_  del proyecto  **MySolution.Win.**  Desplácese hasta el nodo  **Opciones**. Este nodo le permite editar diferentes configuraciones de interfaz de usuario de la aplicación. En la lista desplegable de la propiedad  **UIType**, seleccione la opción deseada, por ejemplo,  **SingleWindowSDI.**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/f924cc3f-a3ae-4c66-b1eb-a7620d4ca85c)

    
-   Ejecute la aplicación WinForms. Asegúrese de que la  **SDI**  esté habilitada, como se ilustra en la imagen siguiente.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c9476756-6a0c-446e-a607-a077ac6f09f0)

    
    En el modo  **SDI**, cada  **vista**  invocada aparece dentro de una única ventana que sustituye a la anterior.
    
   > NOTA
    Si ha seleccionado **MDI**, puede personalizar su comportamiento en el **Editor de modelos** mediante la propiedad  **MdiDefaultNewWindowTarget** nodo **Opciones**.
    

Para obtener información sobre cómo cambiar el tipo de interfaz de usuario en el código, consulte el tema  [WinApplication.ShowViewStrategy](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.WinApplication.ShowViewStrategy?v=22.1)  Si cambia el tipo de  **interfaz**  de  **usuario**  en el código, se omitirán los cambios realizados en el valor de la propiedad  **UIType**  en el nodo  **Opciones**  del  **editor de modelos**.

En la  **demostración principal**, se crea un proyecto de WinForms independiente para demostrar el  **MDI**. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Alternar la interfaz de la cinta de opciones de formularios de Windows


En esta lección, aprenderá a habilitar o deshabilitar la  [interfaz de usuario de la cinta de opciones](https://docs.devexpress.com/WindowsForms/2500/controls-and-libraries/ribbon-bars-and-menu/ribbon?v=22.1)  en la aplicación.

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Crear una solución con el asistente](https://docs.devexpress.com/eXpressAppFramework/112717/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/create-a-solution-using-the-wizard?v=22.1).

-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  haciendo doble clic en el archivo  _Model.xafml_  del proyecto  **MySolution.Win.**  Desplácese hasta el nodo  **Opciones**. Este nodo le permite editar diferentes configuraciones de interfaz de usuario de la aplicación. En la lista desplegable de la propiedad  **FormStyle**, seleccione Cinta de  **opciones**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/284e561b-024a-4c15-80d7-22d6b42c6f9c)

    >NOTA
    Hay opciones adicionales disponibles en **Options** | **RibbonOptions**.
    
-   Ejecute la aplicación WinForms para ver el resultado.
    
    **Interfaz de usuario de cinta de opciones**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6f33e454-3033-4068-8893-849d09d66393)

    
    **Interfaz de usuario estándar**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/249d7168-9013-429d-958f-067a6a078de8)

    
    NOTA
    
    La **interfaz de usuario**  de la cinta de opciones  proporciona la barra de herramientas de acceso rápido. Puede colocar acciones utilizadas con frecuencia en esta barra de herramientas para mejorar la facilidad de uso de la aplicación. Para agregar una determinada acción a esta barra de herramientas, vaya a Diseño de **acción** | **Acciones** | **_<Action>_** y establezca la propiedad  **de acceso rápido** en "**True**".
    

En la  **demostración principal**, se crea un proyecto de WinForms independiente para demostrar la  **interfaz de usuario de la cinta de opciones**.


# Cambiar el estilo de los elementos de navegación


En esta lección, aprenderá a cambiar el estilo de los elementos de navegación en una aplicación  **WinForms XAF**. De forma predeterminada, se muestra un icono de 32x32 con una etiqueta debajo para cada elemento. Este estilo es inconveniente cuando tiene muchos elementos de navegación. Para ahorrar espacio en la pantalla y evitar el desplazamiento, se puede mostrar un icono de 16x16 con una etiqueta a la derecha para cada elemento.

-   Para invocar el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1), haga doble clic en el archivo  _Model.DesignedDiffs.xafml_  ubicado en el proyecto  **MySolution.Module.**  Navegar a  **NavigationItems**  |  **Artículos**  |  **Nodo predeterminado**. Este nodo especifica la configuración del grupo de navegación  **predeterminado**  que incluye los elementos de navegación creados en las lecciones anteriores (**Contacto**,  **Tarea**,  **Departamento**, etc.). En la cuadrícula de la derecha, establezca la propiedad  **ChildItemsDisplayStyle**  en  **List**  (el valor predeterminado es  **LargeIcons**).
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/94240224-24c0-42c8-ab54-4aa11550489f)

    
    Para obtener información detallada, vea la propiedad  [IModelChoiceActionItemChildItemsDisplayStyle.ChildItemsDisplayStyle](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelChoiceActionItemChildItemsDisplayStyle.ChildItemsDisplayStyle?v=22.1)  y la descripción de la enumeración  [ItemsDisplayStyle](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Templates.ActionContainers.ItemsDisplayStyle?v=22.1).
    
-   Ejecute la aplicación WinForms. Verá que ahora se utilizan iconos pequeños para los elementos de navegación en el grupo  **de navegación predeterminado**. La siguiente imagen ilustra los cambios.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/00414bc2-d034-48ab-99e0-cd1f553366ac)


# Módulos adicionales


**eXpressApp Framework**  proporciona algunas características en ensamblados separados llamados  [módulos](https://docs.devexpress.com/eXpressAppFramework/118046/application-shell-and-base-infrastructure/application-solution-components/modules?v=22.1#modules-shipped-with-xaf)  En esta sección del tutorial, aprenderá cómo agregar y usar estas características en sus aplicaciones. Se recomiendan las siguientes lecciones:

-   [Adjuntar archivos a objetos](https://docs.devexpress.com/eXpressAppFramework/112763/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/attach-files-to-objects?v=22.1)
-   [Proporcionar varias variantes de vista para los usuarios finales](https://docs.devexpress.com/eXpressAppFramework/112765/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/provide-several-view-variants-for-end-users?v=22.1)
-   [Auditar cambios en los objetos](https://docs.devexpress.com/eXpressAppFramework/112766/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/audit-object-changes?v=22.1)
-   [Resaltar objetos de vista de lista](https://docs.devexpress.com/eXpressAppFramework/112854/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/highlight-list-view-objects?v=22.1)
-   [Analizar datos](https://docs.devexpress.com/eXpressAppFramework/113023/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/analyze-data?v=22.1)
-   [Crear un informe en Visual Studio](https://docs.devexpress.com/eXpressAppFramework/112734/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/create-a-report-in-visual-studio?v=22.1)
-   [Crear un informe en tiempo de ejecución](https://docs.devexpress.com/eXpressAppFramework/113644/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/create-a-report-at-runtime?v=22.1)
-   [Agregar el módulo Programador](https://docs.devexpress.com/eXpressAppFramework/113040/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/add-the-scheduler-module?v=22.1)
-   [Agregar reglas de validación a clases empresariales](https://docs.devexpress.com/eXpressAppFramework/113041/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/add-validation-rules-to-business-classes?v=22.1)



# Adjuntar archivos a objetos (.NET Framework)


>PROPINA
Para aplicaciones .**NET 6**, vea: [Adjuntar archivos a objetos (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/403288/getting-started/in-depth-tutorial-blazor/additional-modules/attach-files-to-objects?v=22.1).

En esta lección, aprenderá a adjuntar colecciones de archivos a objetos de negocio. Para ello, se agregará el módulo  **File Attachment**  a la aplicación y se implementarán las nuevas clases de negocio  **Resume**  y  **PortfolioFileData**. La clase  **Resume**  se utilizará para almacenar y administrar la información del currículum de un contacto: una recopilación de datos de archivo y una referencia a un  **contacto**.  La clase  **PortfolioFileData**  representará el elemento de recopilación de datos de archivo. También aprenderá cómo se muestran y administran las propiedades del tipo de datos de archivo en una interfaz de usuario.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Implementar clases empresariales personalizadas y propiedades de referencia](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Establecer una relación de uno a muchos](https://docs.devexpress.com/eXpressAppFramework/112733/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-one-to-many-relationship-xpo?v=22.1)

-   Agregue el módulo  **Archivos adjuntos**  al proyecto de módulo WinForms. Para ello, busque el archivo WinModule.cs (WinModule.vb) en el proyecto  **MySolution.Module.Win**  que se muestra en el  **Explorador de soluciones**.  Haga doble clic en este archivo para invocar el  [Diseñador de módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). En el  **Cuadro de herramientas**, expanda el  **DX.22.1: ficha Módulos XAF**. Arrastre el elemento  **FileAttachmentsWindowsFormsModule**  a la sección  **Módulos necesarios**  del diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c62cca18-fdf0-4f99-97a0-53c6bfd92c7f)

-   Agregue el módulo  **Archivos adjuntos**  al proyecto del módulo ASP.NET formularios Web Forms. Para ello, busque el archivo WebModule.cs (WebModule.vb) en el proyecto  **MySolution.Module.Web**  que se muestra en el Explorador de soluciones.  Haga doble clic en este archivo para invocar el  [Diseñador de módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). En el  **Cuadro de herramientas**, expanda el  **DX.22.1: ficha Módulos XAF**. Arrastre el elemento  **FileAttachmentsAspNetModule**  a la sección  **Módulos necesarios**  del diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/98abaefe-2731-45a2-bef0-fd29c62a7351)

    
-   Después de realizar cambios en el  **Diseñador de módulos**, vuelva a generar la solución.
-   Agregue una nueva clase empresarial  **Reanudar**, como se describe en la lección  [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1).
-   Reemplace la declaración de clase  **Resume**  generada automáticamente por el código siguiente.
    

    
    ```csharp
    using DevExpress.Persistent.Base;
    using DevExpress.Persistent.BaseImpl;
    using DevExpress.Xpo;
    using MySolution.Module.BusinessObjects;
    
    [DefaultClassOptions]
    [ImageName("BO_Resume")]
    public class Resume : BaseObject {
       public Resume(Session session) : base(session) {}
       private Contact contact;
       public Contact Contact {
          get { 
             return contact;
          }
          set {
             SetPropertyValue(nameof(Contact), ref contact, value);
          }
       }
      [Aggregated, Association("Resume-PortfolioFileData")]
      public XPCollection<PortfolioFileData> Portfolio {
         get { return GetCollection<PortfolioFileData>(nameof(Portfolio)); }
      }
    }
    
    ```
    
    Declare la clase  **PortfolioFileData**, que es el descendiente de  **FileAttachmentBase**, y la enumeración  **DocumentType**  de la siguiente manera.
    

    
    ```csharp
    using DevExpress.Persistent.BaseImpl;
    using DevExpress.Xpo;
    
    public class PortfolioFileData : FileAttachmentBase {
       public PortfolioFileData(Session session) : base(session) {}
       protected Resume resume;
       [Persistent, Association("Resume-PortfolioFileData")]
       public Resume Resume {
          get { return resume; }
          set { 
             SetPropertyValue(nameof(Resume), ref resume, value); 
          }
       }
       public override void AfterConstruction() {
          base.AfterConstruction();
          documentType = DocumentType.Unknown;
       }
       private DocumentType documentType;
       public DocumentType DocumentType {
          get { return documentType; }
          set { SetPropertyValue(nameof(DocumentType), ref documentType, value); }
       }
    }
    public enum DocumentType { SourceCode = 1, Tests = 2, Documentation = 3,
       Diagrams = 4, ScreenShots = 5, Unknown = 6 };
    
    ```
    
    En el código anterior, puede ver que las clases  **Resume**  y  **PortfolioFileData**  están relacionadas con una relación de uno a muchos. Otro punto importante es que en XPO, la propiedad  **PortfolioFileData.DocumentType**  se inicializa en el método  **AfterConstruction**, al que se llama después de crear el objeto correspondiente.
    
    Consulte el tema Propiedades de datos adjuntos de archivo en XPO para obtener más información sobre la creación de propiedades de  [datos adjuntos de archivo](https://docs.devexpress.com/eXpressAppFramework/113549/business-model-design-orm/data-types-supported-by-built-in-editors/file-attachment-properties/file-attachment-properties-in-xpo?v=22.1).
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms y cree un nuevo objeto  **Resume**.
-   Para especificar la propiedad  **File**, adjunte un archivo en el cuadro de diálogo  **Abrir**, invocado mediante el botón  **Agregar desde archivo...**  (![btn_attach](https://docs.devexpress.com/eXpressAppFramework/images/btn_attach117501.png?v=22.1)).
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/630bb916-96db-42ed-8c6e-2ae058186158)

    
-   Para abrir o guardar un archivo adjunto a la colección  **Portfolio**, o agregar un archivo nuevo, utilice  **Abrir**...,  **Guardar como**... o  **Agregar desde archivo...**  Acciones suministradas con la colección.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/5d172e5c-87d1-4398-800d-7d48c0175016)

    

>PROPINA
Para guardar el archivo almacenado en el objeto  **File**  Data actual  en la secuencia especificada, utilice [IFileData.SaveToStream](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.IFileData.SaveToStream(System.IO.Stream)?v=22.1).

Puede ver el código que se muestra aquí en el archivo Resume_.cs (Resume__.vb_) de la  **demostración principal**  instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .

 
# Proporcionar varias variantes de vista para los usuarios finales (.NET Framework)

>PROPINA
Para aplicaciones .**NET 6**, vea: [Crear varias variantes de vista (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/403380/getting-started/in-depth-tutorial-blazor/additional-modules/create-multiple-view-variants?v=22.1).

En esta lección, aprenderá a proporcionar varias variantes personalizadas de la misma vista y permitir  que un usuario final elija una variante de  **vista**  deseada en tiempo de ejecución. Las variantes se pueden aplicar tanto a las vistas de lista como a  **las vistas de detalle**.  En esta lección, se usará la  **vista Lista de contactos**. Se construirán dos variantes de esta  **vista de lista**  a través del  **editor de módulos**. Para cambiar entre estas variantes  **de View**, se utilizará la acción especial  **ChangeVariant**. Para agregar esta acción, se hará referencia al módulo  **ViewVariants**  en la aplicación.

>NOTA
Antes de continuar, tómese un momento para repasar las siguientes lecciones:
>-   [Heredar de la clase de biblioteca de clase empresarial](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Cambiar el diseño y la visibilidad del campo en una vista de lista](https://docs.devexpress.com/eXpressAppFramework/112746/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/change-field-layout-and-visibility-in-a-list-view?v=22.1)

-   Agregue el módulo  **Ver variantes**  al proyecto  **MySolution.Module.**  Busque el archivo Module.cs (Module_.vb_) en el proyecto  **MySolution.Module**  que se muestra en el  **Explorador de soluciones**  y haga doble clic en este archivo.  Se invocará el  [Diseñador](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  de módulos. En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: ficha Módulos XAF**. Arrastre el elemento  **ViewVariantsModule**  de esta ficha a la sección  **Módulos necesarios**  del diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/bb062f62-3f77-4f49-a0e1-a76585d2cce2)

    
-   Vuelva a generar la solución para que los cambios realizados en el  **Diseñador de módulos**  se carguen en el  **modelo de aplicación**.
-   Invoque el  [Editor de modelos](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  para el proyecto  **MySolution.Module.**  Haga clic con el botón derecho en el nodo  **Vistas**  y seleccione  **Agregar...**  |  **ListView**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/43db4ea3-b1ce-4bee-800a-b253671666af)

    
    Para el nuevo nodo, establezca la propiedad  **Id**  en "Contact_ListView_AllColumns" y la propiedad  **ModelClass**  en "Contact".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2b7b3f51-78b8-475e-b1a5-41cdb702116b)


    
-   Haga clic con el botón derecho en el nodo recién creado y seleccione  **Generar contenido**. Las columnas se generarán utilizando información sobre la clase especificada (**BOModel**  |  **Nodo de contacto**) y sus antepasados. Deje estas columnas como están. Esta vista de lista representará la variante completa de la  **vista de lista**  de  **contactos**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/a56931f3-f16e-4b80-9280-eb07f0512c3f)


-   Haga clic con el botón derecho en el nodo  **Vistas**  y seleccione  **Agregar...**  |  **ListView**. Para el nuevo nodo, establezca la propiedad  **Id**  en "Contact_ListView_Varied" y la propiedad  **ModelClass**  en "Contact". No genere contenido para el nuevo nodo.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/92d891ba-588b-4e53-bce4-479079be203f)

    
-   Expanda el nodo  **Contact_ListView_Varied**  recién agregado, haga clic con el botón derecho en el nodo secundario  **Variantes**  y seleccione  **Agregar...**  |  **Variante**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/906935a9-3439-40cf-8a9b-4cb91a5bf86d)

    
-   Para el nuevo nodo, establezca la propiedad  **View**  en "Contact_ListView" y las propiedades  **Id**  y  **Caption**  en "Pocas columnas".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/0937e330-aac0-4b08-acfe-d8cc6ab44c58)

    
-   Haga clic con el botón derecho en el nodo  **Variantes**  y seleccione  **Agregar...**  |  **Variante**. Para el nuevo nodo, establezca la propiedad  **View**  en "Contact_ListView_AllColumns" y las propiedades  **Id**  y  **Caption**  en "Todas las columnas".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/879577c4-1668-4f64-b62d-109599a752b8)

    
-   Navegar a  **NavigationItems**  |  **Artículos**  |  **Predeterminado**  |  **Artículos**  |  **Nodo de contacto**. Su propiedad  **View**, que especifica la Vista que se muestra al elegir el elemento de navegación  **Contacto**, es "Contact_ListView" de forma predeterminada. Cámbielo a "Contact_ListView_Varied".
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2ef7c32c-6574-4706-acd2-a9c604e9ac29)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Seleccione el elemento  **Contacto**  en el control de navegación. Para la vista de lista de  **contactos**  mostrada, se activará la acción  **ChangeVariant**. Los elementos de esta acción representan las variantes de vista especificadas en el  **Editor de modelos**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/07810f1f-5e3b-417c-9cf8-048bd0c276bd)

    
    >NOTA
    Puede utilizar la propiedad  **Index** para especificar el criterio de ordenación de las variantes en la lista desplegable  **Cambiaracción de variante**. Además, puede establecer la propiedad  **Current** del nodo  **Variants** para especificar la variante predeterminada.
    
-   Opcionalmente, puede agregar variantes de vista al control de navegación. Para ello, invoque el Editor de modelos y establezca la propiedad  **GenerateRelatedViewVariantsGroup**  del nodo  **NavigationItems**  en  **true**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/0f5ce8bc-2d03-4985-adfc-30732509b4a3)

    
    Como resultado, el elemento de navegación  **Contacto**  expondrá elementos secundarios para cada variante de vista.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c1af8704-0a1a-4d2b-accd-7f2b0fc09d70)

    

Puede ver los cambios realizados en esta lección en el  **Editor de modelos**  invocado para el archivo  _Model.DesignedDiffs.xafml_, ubicado en la  **demostración principal**  |  **Proyecto MainDemo.Module.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Auditar cambios en el objeto (.NET Framework)


En esta lección, aprenderá a auditar y analizar los cambios realizados en los objetos de negocio mientras se ejecuta la aplicación. Para ello, se añadirá el módulo  **Audit Trail**  a la aplicación. Se auditarán los cambios realizados en el objeto  **Contact.**  Se utilizarán dos técnicas para analizarlos.

>NOTA
Antes de continuar, tómese un momento para revisar la lección  [Heredar de la clase de biblioteca de clase empresarial (XPO](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)).

## Auditar objetos de contacto

Agregue el módulo  **AuditTrail**  al proyecto  **MySolution.Module.**  Para ello, busque el archivo Module_.cs_  (Module.vb) en el proyecto  **MySolution.Module**  que se muestra en el  **Explorador de soluciones**.  Haga doble clic en este archivo para invocar el  [Diseñador de módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). En el  **Cuadro de herramientas**, expanda el  **DX.22.1: ficha Módulos XAF**. Arrastre el elemento  **AuditTrailModule**  a la sección  **Módulos necesarios**  del diseñador.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/1fc0bf92-13c9-404d-a33f-70443d632715)


Ahora, se auditan todos los objetos que se crean en la aplicación. El  **sistema de seguimiento de auditoría**  registra información sobre el tipo de cambio (objeto creado, cambiado, etc.), quién realizó este cambio, el objeto que se cambió, los valores de propiedad anteriores y nuevos, etc. Cuando se guarda un objeto en la base de datos, se registran los cambios entre dos eventos secuenciales.

## Analizar el registro de auditoría en la aplicación

Utilice el siguiente enfoque para ver los cambios de objeto directamente en la aplicación.

-   Agregue una propiedad de colección a la clase  **Contact**. Los elementos de la colección proporcionarán información de registro recuperada de la base de datos.

    
    ```csharp
    using DevExpress.ExpressApp;
    // ...
    [DefaultClassOptions]
    public class Contact : Person {
       //...
       private XPCollection<AuditDataItemPersistent> changeHistory;
       [CollectionOperationSet(AllowAdd = false, AllowRemove = false)]
       public XPCollection<AuditDataItemPersistent> ChangeHistory {
           get {
               if(changeHistory == null) {
                   changeHistory = AuditedObjectWeakReference.GetAuditTrail(Session, this);
               }
               return changeHistory;
           }
       }
    }
    
    ```
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms e invoque una vista de detalles  **de contacto**. Modifique el objeto  **Contact**  para probar la capacidad de auditoría, guarde los cambios y haga clic en  **Actualizar**  (![btn_refresh](https://docs.devexpress.com/eXpressAppFramework/images/btn_refresh117427.png?v=22.1)). La colección Historial de cambios contendrá información sobre los  **cambios**  anteriores del objeto  **Contact.**
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e3ee76e0-216b-4954-8af8-314c8b32f1c8)

    

>NOTA
Como recordará, la propiedad  **Office** se declara en la clase  **Department**, no en la clase **Contact**. Por lo tanto, los cambios realizados en la propiedad de  **Office** mediante la vista de detalles de contacto no se muestran en el historial de cambios del contacto. En su lugar, estos cambios aparecen en el **historial**  de cambios  del objeto de departamento correspondiente (si se auditan los  cambios realizados en los objetos  **de departamento**). Puede adquirir el registro de auditoría de forma remota mediante consultas SQL a la base de datos. Consulte el tema  [Analizar el registro de auditoría](https://docs.devexpress.com/eXpressAppFramework/113615/data-security-and-safety/audit-trail/audit-trail-xpo/analyze-the-audit-log?v=22.1).

Puede ver el código mostrado aquí en el archivo Contact_.cs_  (_Contact.vb_) de la  **demostración principal**  instalada con XAF. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Resaltar objetos de vista de lista (.NET Framework)

En esta lección, aprenderá a dar formato a los datos que satisfagan los criterios especificados. Para ello, se añadirá a la aplicación el módulo  [Apariencia condicional](https://docs.devexpress.com/eXpressAppFramework/113286/conditional-appearance?v=22.1). Resaltará los objetos  **DemoTask**  cuya propiedad  **Status**  no esté establecida en  **Completed**. Además, resaltará la propiedad  **Priority**  cuando contenga el valor  **High**.

-   Agregue el módulo  **Apariencia condicional**  al proyecto  **MySolution.Module.**  Para este fin, haga doble clic en el archivo Module.cs (Module_.vb_), ubicado en el proyecto  **MySolution.Module.**  Se invocará el  [Diseñador](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  de módulos. En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: ficha Módulos XAF**  y arrastre el elemento  **ConditionalAppearanceModule**  desde esta ficha a la sección  **Módulos necesarios**  del diseñador, como se muestra a continuación.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/98d02361-8dea-483a-ab94-e1f29cb6588f)

    
-   Vuelva a generar la solución después de haber realizado cambios en el  **Diseñador de módulos**.
-   Para declarar una regla de apariencia condicional para la clase  **DemoTask**, aplique el atributo  [AppearanceAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute?v=22.1)  a esta clase. Como primer parámetro, especifique el  **identificador de la regla de apariencia**  (por ejemplo, "FontColorRed"). A continuación, especifique los siguientes parámetros.

  ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e9368b8b-cbb0-449c-89fc-a5ef8cb00fe0)

-   En el código siguiente se muestra el atributo aplicado y sus parámetros a la clase DemoTask, que se declaró en el archivo  _BusinessObjects_\DemoTask_.cs (__DemoTask.vb_).
    

    ```csharp
    using DevExpress.ExpressApp.ConditionalAppearance;
    // ...
    [Appearance("FontColorRed", AppearanceItemType = "ViewItem", TargetItems = "*", Context = "ListView",
        Criteria = "Status!='Completed'", FontColor = "Red")]
    public class DemoTask : Task {
        // ...
    }
    
    ```
    
    >NOTA
    El valor  **Criteria** debe especificarse mediante la [sintaxis del lenguaje Criteria](https://docs.devexpress.com/CoreLibraries/4928/devexpress-data-library/criteria-language-syntax?v=22.1).
    
-   Aplique el atributo  [AppearanceAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute?v=22.1)  a la propiedad  **Priority**  de la clase  **DemoTask**. Como primer parámetro posicional, especifique el identificador de  **la regla de apariencia**  (por ejemplo, "PriorityBackColorPink"). A continuación, especifique los siguientes parámetros.
    
    -   _Especificar los elementos de la interfaz de usuario de destino que se verán afectados por la regla_
        
        Establezca el parámetro  [AppearanceAttribute.AppearanceItemType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute.AppearanceItemType?v=22.1)  en "ViewItem". Esto significa que la regla generada a partir del atributo afectará a la propiedad  **Priority**  que se muestra en la  **vista**  actual.
        
    -   _Especificar las condiciones en las que debe estar en vigor la regla_
        
        Establezca el parámetro AppearanceAttribute.Context en "Any" y el parámetro  [AppearanceAttribute.Criteria](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute.Context?v=22.1)  en "Priority=2".[](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute.Criteria?v=22.1)  En este caso, la regla generada a partir del atributo afectará a la propiedad  **Priority**  cuando se establezca en 2 (**Alto**) en cualquier vista  **DemoTask**.
        
    -   _Especificar la apariencia condicional aplicada por la regla_
        
        Establezca el parámetro  [AppearanceAttribute.BackColor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute.BackColor?v=22.1)  en "255, 240, 240".
        
    
    En el código siguiente se muestra el atributo aplicado y sus parámetros.
    

    
    ```csharp
    public class DemoTask : Task {
        // ...
        [Appearance("PriorityBackColorPink", AppearanceItemType = "ViewItem", Context = "Any", 
            Criteria = "Priority=2", BackColor = "255, 240, 240")]
        public Priority Priority {
            // ...
        }
        // ...
    }
    
    ```
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Se resaltarán los datos de la vista de lista de  **tareas de demostración**  y la vista de detalles, como se muestra en la siguiente imagen.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/829f963c-78a1-4636-90d9-50696d024d43)

    

>NOTA
**Las reglas de apariencia** que se declaran en el código están disponibles en el **Editor de modelos**. Para acceder a ellos, puede ejecutar el **Editor de modelos** para **Misolución.Proyecto de módulo**. Vaya a la **lista de materiales** | **Tarea de demostración** | **Nodo Reglas de apariencia**. Este nodo tiene dos nodos secundarios (**Colorde fuente rojo**  y  **Color de fondo de prioridadrosa) que se generan automáticamente a partir de los atributos Apariencia aplicados a la clase Tarea de**  **demostración** y la tarea de  **demostración.Propiedad prioritaria**. Puede crear nuevas **reglas**  de apariencia  directamente en el **Editor de modelos** agregando nodos secundarios al nodo  **Reglas de apariencia**.

Puede ver los cambios realizados en la lección en el archivo DemoTask.cs (_DemoTask.vb_) ubicado en el proyecto  _MainDemo.Module_  de la solución  **MainDemo.**  La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .


# Analizar datos (.NET Framework)


En esta lección, aprenderá a agregar la funcionalidad  **Análisis**  a su aplicación. Para ello, agregará la clase empresarial  **Análisis**  y el módulo de  [gráfico dinámico](https://docs.devexpress.com/eXpressAppFramework/113024/analytics/pivot-chart-module?v=22.1)  a la aplicación.

-   Agregue la clase de negocio  **Analysis**  al proyecto  **MySolution.Module**  mediante el Diseñador de  [módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). Invoque haciendo doble clic en el archivo Module_.cs_  (Module.vb) dentro del proyecto  **MySolution.Module**  que se muestra en el  **Explorador de soluciones**.  En la sección  **Tipos exportados**, busque los  **ensamblados a los que se hace referencia**  |  **DevExpress.Persistent.BaseImpl.v22.1**  |  **Nodo de análisis**. Selecciónelo y presione la  **barra espaciadora**, o haga clic derecho en él y elija  **Usar tipo en aplicación en**  el menú invocado. El nodo se marcará en negrita. Esto significa que la clase de negocio  **Análisis**  se agregará al  [modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112748/getting-started/in-depth-tutorial-winforms-webforms/ui-customization?v=22.1)  y esta clase participará en el proceso de construcción de la interfaz de usuario.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/1e0df405-a86a-4e24-8946-5a84ba73abf2)

    
-   Vuelva a generar la solución para que los cambios realizados en el  **diseñador**  se carguen en el  **modelo de aplicación**.
-   El  **marco eXpressApp**  proporciona el  [módulo de gráfico dinámico](https://docs.devexpress.com/eXpressAppFramework/113024/analytics/pivot-chart-module?v=22.1). Cuando se hace referencia a este módulo, la propiedad  **Self**  de la vista de detalle  **de análisis**  se muestra a través de un  **editor de propiedades**  especial. En las aplicaciones de WinForms, este  **editor de propiedades**  utiliza el control  **PivotGridControl**  proporcionado por la biblioteca de  [cuadrícula dinámica](https://docs.devexpress.com/WindowsForms/3409/controls-and-libraries/pivot-grid?v=22.1)  y el  **control ChartControl**  de la biblioteca de  [controles de gráficos](https://docs.devexpress.com/WindowsForms/8117/controls-and-libraries/chart-control?v=22.1). En ASP.NET aplicaciones de formularios Web Forms, este  **Editor de propiedades**  utiliza la cuadrícula dinámica de formularios Web Forms ASP.NET proporcionada por la biblioteca de  **cuadrícula dinámica**  de formularios Web  [Forms ASP.NET](https://docs.devexpress.com/AspNet/5830/components/pivot-grid?v=22.1)  y  **el control WebChartControl**  de la biblioteca de  [controles de gráficos](https://docs.devexpress.com/WindowsForms/8117/controls-and-libraries/chart-control?v=22.1). Estos controles permiten a los usuarios finales crear informes resumidos para analizar grandes cantidades de datos de forma rápida y sencilla. Características como el filtrado, la visualización del valor superior, la disposición jerárquica del valor en los ejes y los totales generales y grupales brindan a los usuarios finales una amplia gama de herramientas para controlar el nivel de datos en detalle.
    
    Para utilizar el módulo de  **gráfico dinámico**  en una aplicación de WinForms, agréguelo al proyecto de módulo de WinForms. Para ello, busque el archivo WinModule.cs (WinModule.vb) en el proyecto  **MySolution.Module.Win**  que se muestra en el Explorador de soluciones.  Haga doble clic en este archivo. Se invocará el  [Diseñador](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  de módulos. En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: Página Módulos XAF**. Arrastre el elemento  **PivotChartWindowsFormsModule**  a la sección  **Módulos necesarios**  del diseñador. Compile el proyecto.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/decad30a-4e76-4b95-9f58-668c02d97111)

    
    Para utilizar el módulo de  **gráfico dinámico**  en la aplicación ASP.NET formularios Web Forms, agréguelo al proyecto de módulo ASP.NET formularios Web Forms. Para este fin, haga doble clic en el archivo WebModule.cs (WebModule.vb), ubicado en el proyecto de aplicación  **MySolution.Module.Web.**  Se invocará el  [Diseñador](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  de módulos. En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: ficha Módulos XAF**  y arrastre el elemento  **PivotChartAspNetModule**  a la sección  **Módulos necesarios**  del diseñador. Compile el proyecto.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/37edceb1-725e-4310-9a7d-6ff67878e3f5)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. En el control de navegación, seleccione  **Informes**  |  **Ítem de análisis**. Se mostrará una lista de objetos de análisis vacía (denominada Vista  **de**  lista  **de análisis**). Cree un nuevo objeto  **Analysis**  haciendo clic en el botón  **Nuevo**. En la  **vista de detalles**  invocada, especifique un nombre para el nuevo objeto  **Analysis**  y el tipo de objetos que se van a analizar mediante una cuadrícula dinámica y un control de gráfico. Por ejemplo, asigne el valor "Tareas" a la propiedad  **Nombre**  y elija "Tarea" en el menú desplegable  **Tipo de datos**. Haga clic en  **Enlazar datos de análisis**  (![Enlazar datos de análisis](https://docs.devexpress.com/eXpressAppFramework/images/bind-analysis-data116074.png?v=22.1)).  **Los**  objetos de tarea se cargarán como origen de datos para la cuadrícula dinámica.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/547358e3-ea33-426b-939e-47760bacefc8)

    
-   Arrastre los campos obligatorios a las áreas de fila, columna y datos.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ca1da551-d30b-4336-b115-067990aa3d37)

    
    La siguiente configuración muestra cómo averiguar cuántas tareas se asignan a un contacto.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/91477ab4-fb1c-47ea-967c-9b2a60231b33)

    
-   Cambie a la pestaña  **Gráfico**. Muestra los datos configurados en la cuadrícula dinámica a través de un gráfico.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/4e5fa376-1229-483f-bfcf-dabbcf6265a1)

    
-   En las aplicaciones de WinForms, puede especificar la configuración del gráfico mediante la acción  ChartWizard invocada haciendo clic con el botón secundario en la imagen del gráfico y eligiendo  **ChartWizard**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/25655d7d-de65-42df-b176-013ef556052c)

    
    En ASP.NET aplicaciones de formularios Web Forms, sólo puede establecer el tipo de gráfico mediante el cuadro combinado  **ChartType**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/ba48bce9-759c-4dea-b48e-10cbce16ae01)

    

Las siguientes configuraciones muestran cómo se pueden reconfigurar los campos de la cuadrícula dinámica en función de lo que intenta analizar.

_Cuántas tareas de una prioridad particular se completan_.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e45d65cb-ee8a-48ee-ab4a-9702ab29842f)


_Cuántas tareas de una prioridad particular se asignan a un contacto_.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/4a8e3b15-9a57-4743-93b1-0b22c77b5dec)


_Cuántas horas estimadas y reales ha dedicado cada contacto a implementar todas las tareas asignadas a ese contacto_.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/f7163c98-4530-4f0a-88e4-c0ca1525965b)


_Cuántas horas de trabajo se planifican para un contacto y cuántas horas ya ha dedicado un contacto a las tareas completadas_.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/cf66ad3f-1640-4329-a87b-50840ca52b7d)


_El análisis anterior se amplía mostrando la distribución basada en la prioridad de la tarea_.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/589ba2e1-f129-43ce-94a6-f1f288e91ed0)


>NOTA
Las imágenes anteriores ilustran cómo generar un análisis en una aplicación de formularios Win, pero puede seguir los mismos pasos en una aplicación de formulariosWeb Forms ASP.NET.

Cuando se muestra un objeto  **Análisis**  en una vista de detalle, el botón  **Exportar**  se puede utilizar para exportar la cuadrícula dinámica o el gráfico a varios formatos.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/fc9ac919-af33-4219-a582-9d753e5e1280)


La acción  **Exportar**  está disponible en las aplicaciones WinForms y ASP.NET formularios Web Forms.

Las acciones Imprimir cuadrícula dinámica () e  **Imprimir**  gráfico (![btn_chart_print](https://docs.devexpress.com/eXpressAppFramework/images/btn_chart_print117502.png?v=22.1)![btn_pivot_print](https://docs.devexpress.com/eXpressAppFramework/images/btn_pivot_print117503.png?v=22.1)) se pueden usar para imprimir la  **cuadrícula dinámica**  y el gráfico. Estas acciones no están disponibles en una aplicación ASP.NET formularios Web Forms.

Puede ver el análisis demostrado anteriormente en la  **demostración principal**. La aplicación MainDemo se instala en %_PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  de forma predeterminada.  La versión ASP.NET de formularios Web Forms está disponible en línea en  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx) .



# Crear un informe en Visual Studio (.NET Framework)

En esta lección, aprenderá a crear informes en el sistema de informes integrado. Este sistema se basa en la biblioteca de  [informes](https://docs.devexpress.com/XtraReports/2162/reporting?v=22.1)  DevExpress para WinForms y ASP.NET formularios Web Forms. Esta lección le guiará a través de la creación de un informe que muestra una lista de objetos de  **contacto**  con sus nombres y direcciones de correo electrónico. El informe estará disponible para los usuarios finales en las aplicaciones WinForms y ASP.NET Web Forms.

## Adición de módulos XAF

-   Agregue el módulo  [Reports V2](https://docs.devexpress.com/eXpressAppFramework/113591/shape-export-print-data/reports/reports-v2-module-overview?v=22.1)  independiente de la plataforma a su proyecto. Para ello, haga doble clic en el archivo Module.cs (Module_.vb_) en el proyecto  **MySolution.Module.**  Esto invocará al Diseñador de  [módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: Grupo de módulos XAF**. Arrastre el elemento  **ReportsModuleV2**  de este grupo a la sección  **Módulos necesarios**  del diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/af175834-31b6-450a-a0af-e20f60c84e5b)

    
-   Agregue un módulo  **Reports V2**  específico de WinForms al proyecto de módulo WinForms. Haga doble clic en el archivo WinModule.cs (WinModule.vb) en el proyecto  **MySolution.Module.Win.**  Esto invocará al Diseñador de  [módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: Grupo de módulos XAF**. Arrastre el elemento  **ReportsWindowsFormsModuleV2**  de este grupo a la sección  **Módulos necesarios**  del diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c92a76b6-e947-441b-9d75-bdbd12d59b76)

    
-   Agregue el módulo  **Reports V2**  específico de ASP.NET formularios Web Forms al proyecto de aplicación de formularios Web Forms de ASP.NET. Para invocar el  [Diseñador de módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1), haga doble clic en el archivo WebModule.cs (WebModule.vb) en el proyecto  **MySolution.Module.Web.**  En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: Grupo de módulos XAF**. Arrastre el elemento  **ReportsAspNetModuleV2**  de este grupo a la sección  **Módulos necesarios**  del diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6059b031-92cb-4f53-959f-5829da82a5ec)

    
-   Vuelva a generar la solución.

## Informes en tiempo de diseño

-   Haga clic con el botón secundario en el proyecto  **MySolution.Module**  y seleccione  **Agregar**  |  **Nueva carpeta**. Establezca el nombre de la nueva carpeta en "Informes". Haga clic con el botón derecho en la carpeta  **Informes**  y seleccione  **Agregar**  |  **Nuevo artículo**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/f7783978-7e87-47a9-b09a-99fb0a5ff1e3)

    
    >NOTA
    Puede colocar informes en cualquier carpeta (incluida la carpeta raíz del proyecto), aunque se recomienda organizar los archivos de proyecto.
    
-   Seleccione el  **informe de DevExpress v22.1**, asígnele el nombre "ContactsReport" y haga clic en  **Agregar**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/794e19d0-24cb-47d5-8094-f9d5c99c88f4)

    
-   Esto invoca al  [Asistente para informes](https://docs.devexpress.com/XtraReports/4254/visual-studio-report-designer/report-wizard?v=22.1). Seleccione  **En blanco**  y haga clic en  **Finalizar**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b91a6de7-e7cb-490b-8709-103658011267)

    
    >NOTA
    No utilice tipos de informe que no sean **En blanco**. Otros tipos de informe no le permitirán seleccionar un origen de datos específico de XAF. Podrá continuar con el  **Asistente**  para informes  más adelante, una vez seleccionado el origen de datos en el **Diseñador de informes**.
    
-   Después de hacer clic en  **Finalizar**, se invoca al  [Diseñador de informes](https://docs.devexpress.com/XtraReports/4257/winforms-reporting/end-user-report-designer-for-winforms/api-and-customization?v=22.1). En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: Grupo Orígenes de datos XAF para informes**. Arrastre el elemento  **CollectionDataSource**  de este grupo a la ventana Diseñador de  **informes**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2242af2a-cf4a-4b9c-89de-6c144717105b)

    
-   En la ventana  [Explorador de informes](https://docs.devexpress.com/XtraReports/4258/visual-studio-report-designer/dock-panels/report-explorer?v=22.1), seleccione el elemento  **collectionDataSource1**. En la ventana  **Propiedades**, asigne el valor "MySolution.Module.BusinessObjects.Contact" a la propiedad  **ObjectTypeName**. Tenga en cuenta los cambios en la ventana Lista de campos: los  [campos](https://docs.devexpress.com/XtraReports/4259/visual-studio-report-designer/dock-panels/field-list?v=22.1)  de la clase  **Contact**  ahora están disponibles si expande el nodo  **collectionDataSource1**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/f55b14a1-0522-429b-927c-4a2c52d17e49)

    
-   Haga clic en la  [etiqueta inteligente](https://docs.devexpress.com/XtraReports/4260/detailed-guide-to-devexpress-reporting/use-report-controls/manipulate-report-controls?v=22.1)  del  **Diseñador**  de informes y seleccione Diseño en el  **Asistente para informes... en**  el menú invocado.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/d77e91b0-4c2f-444b-8fa8-30321486e5b8)

    
-   Esto invoca al  [Asistente para informes](https://docs.devexpress.com/XtraReports/4241/visual-studio-report-designer/data-source-wizard/connect-to-a-database?v=22.1). En el primer paso, debe seleccionar el  **informe de tabla**  y hacer clic en  **Siguiente**. Dado que el origen de datos ya está especificado, omitirá algunas pantallas del asistente y el segundo paso le permitirá elegir los datos del informe.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/525ee9f1-bb5a-4bfb-acae-dea63d245c71)

    
-   Seleccione los campos que se utilizarán en el informe. Compruebe el miembro de datos  **collectionDataSource1**  a la izquierda y los siguientes campos de datos a la derecha:
    
    -   **Nombre**
    -   **Apellido**
    -   **Correo electrónico**
    
    Haga clic en  **Siguiente**  cuando haya terminado.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2312473f-b4f4-4310-9d5e-d847c76df982)

    
-   Seleccione los campos por los que desea agrupar las filas del informe. Dado que la agrupación no es necesaria en este ejemplo, haga clic en  **Siguiente**  para continuar.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/7c3d6af1-bf53-47e0-bddc-3cd13c2421d3)

    
-   En el siguiente paso, puede personalizar la página del informe. Mantenga esta configuración sin cambios y haga clic en  **Siguiente**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c296c139-1f02-4e12-85c4-78efda75e429)

    
-   Elija una combinación de colores de informe, por ejemplo,  **Azure**, y haga clic en  **Siguiente**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/dbff9479-f4e5-4009-af3b-301434c1952d)

    
-   En el paso final, puede establecer el título del informe. Este texto se mostrará en la parte superior del informe. Establezca el título en "Contactos" y haga clic en  **Finalizar**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/0cc78765-8f83-4be0-8517-76b062469c73)

    
-   La estructura de informe que ha creado se mostrará en el  **Diseñador de informes**. Personalice y guarde el informe.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6638e50d-9285-443b-9b17-dfdc59920d09)

    
    >NOTA
    En tiempo de diseño, la ficha Vista previa del Diseñador de informes está vacía. Los componentes Origen de datos de recopilación y  [Verorigen de datos no se conectan directamente a una base de datos y requieren una instancia de IObject Space (que solo se puede crear en tiempo de ejecución) para cargar datos](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ReportsV2.ViewDataSource?v=22.1)  [](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ReportsV2.CollectionDataSource?v=22.1).[](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.IObjectSpace?v=22.1) Por lo tanto, no puede cargar datos en tiempo de diseño.
    
-   Ahora registre el informe en la aplicación XAF mediante la clase  [PredefinedReportsUpdater](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ReportsV2.PredefinedReportsUpdater?v=22.1). Para ello, en el Explorador de  **soluciones**, haga clic con el botón secundario en  _MySolution.Module_  | Module_.cs_  (_Module.vb_) y seleccione Ver código para editar su  **código**  fuente. El siguiente fragmento de código muestra los cambios necesarios.

    
    ```csharp
    using DevExpress.ExpressApp.ReportsV2;
    using MySolution.Module.Reports;
    using MySolution.Module.BusinessObjects;
    //...
    namespace MySolution.Module {
        public sealed partial class MySolutionModule : ModuleBase {
            //...
            public override IEnumerable<ModuleUpdater> GetModuleUpdaters(
                IObjectSpace objectSpace, Version versionFromDB) {
                ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
                PredefinedReportsUpdater predefinedReportsUpdater = 
                    new PredefinedReportsUpdater(Application, objectSpace, versionFromDB);
                predefinedReportsUpdater.AddPredefinedReport<ContactsReport>(
                "Contacts Report", typeof(Contact));
                return new ModuleUpdater[] { updater, predefinedReportsUpdater };
            }
            //...
        }
    }
    
    ```
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms, vaya a  **Informes**  y abra el  **Informe de contactos**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c12d7aba-8085-46a3-a12e-bb9e39b475b2)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/4fcb281e-8c71-459d-adbf-0da9e345f1b5)

    

>NOTA
>-   Los informes predefinidos no se pueden editar en tiempo de ejecución, pero puede editar una copia de un informe (consulte [Modificar un informe existente](https://docs.devexpress.com/eXpressAppFramework/113647/shape-export-print-data/reports/modify-an-existing-report?v=22.1)).
>-   Los datos del informe se pueden [ordenar](https://docs.devexpress.com/eXpressAppFramework/113595/shape-export-print-data/reports/data-sorting-in-reports-v2?v=22.1) y [filtrar](https://docs.devexpress.com/eXpressAppFramework/113594/filtering/in-reports/data-filtering-in-reports?v=22.1) de acuerdo con un parámetro definido por el usuario final.



# Crear un informe en tiempo de ejecución (.NET Framework)

En esta lección, aprenderá a crear informes en tiempo de ejecución. Se creará un informe que muestra una lista de  **tareas**  en la aplicación WinForms en tiempo de ejecución y, a continuación, estará disponible para imprimir en aplicaciones WinForms y ASP.NET formularios Web Forms.

>PROPINA
También puede crear un nuevo informe en una aplicación de formularios Web Forms ASP.NET (vea  [Crear y ver informes en una aplicación de formularios Web Forms ASP.NET](https://docs.devexpress.com/eXpressAppFramework/113648/shape-export-print-data/reports/create-and-view-reports-in-an-asp-net-application?v=22.1)).

1.  Ejecute la aplicación WinForms y vaya a la vista de lista de  **informes**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e26c0536-39a6-4835-938b-735a60e4680a)

    
2.  Cree un nuevo informe haciendo clic en el botón  **Nuevo**  (![button_new](https://docs.devexpress.com/eXpressAppFramework/images/btn_new117411.png?v=22.1)).
3.  Asigne a este informe el nombre "Informe de tareas", establezca el  **tipo de datos**  en "Tarea" y haga clic en  **Siguiente**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2746ea5e-d0c2-4584-b651-af1449db41c3)

    
    >NOTA
    La lista desplegable  **Tipo de datos** muestra sólo las clases de negocio que tienen aplicado el atributo  [`DefaultClassOptionsAttribute`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DefaultClassOptionsAttribute?v=22.1) o el  [`VisibleInReportsAttribute`](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.VisibleInReportsAttribute?v=22.1).
    
4.  Elija el tipo "Informe de tabla" y haga clic en  **Siguiente**.
    
5.  Agregue los siguientes campos.
    
    -   Asunto
    -   Prioridad
    -   Estado
    -   Porcentaje completado
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/f67c2950-0f99-49fc-89a2-f6ae810998b1)

    

-   Haga clic en  **Siguiente**  para omitir la configuración de agrupación, las funciones de resumen y la configuración de la página de informes.
-   Elija la combinación de colores del informe de  **Azure**  y haga clic en  **Siguiente**.
-   Establezca el título en "Tareas" y haga clic en  **Finalizar**.
-   Después de hacer clic en  **Finalizar**, se invocará el  [Diseñador de informes en tiempo de ejecución](https://docs.devexpress.com/XtraReports/1763/winforms-reporting/end-user-report-designer-for-winforms/gui/end-user-report-designer-with-a-standard-toolbar?v=22.1).
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/f4092b4c-44d7-432c-8959-5d2320b47f3b)

    
-   Personalice el informe, guárdelo haciendo clic en el botón  **Guardar**  (![btn_report_save](https://docs.devexpress.com/eXpressAppFramework/images/btn_report_save117463.png?v=22.1)) y ábralo desde la Vista de lista de  **informes**. Este informe también estará disponible en la versión ASP.NET de formularios Web Forms de la aplicación.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/e5358fd4-3e81-4ab7-a379-d677f63a2888)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/efdff11a-7b1e-471c-9a67-c4b7f4017c84)


# Agregue el módulo Programador (.NET Framework)


>IMPORTANTE
El Programador requiere que la clase empresarial  **Event** esté en el modelo de aplicación XAF. Siga los pasos descritos en la lección  [Agregar una clase de la Biblioteca de clases empresariales](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1) para obtener información sobre cómo agregarla.

**eXpressApp Framework (XAF)**  proporciona el  [módulo Programador](https://docs.devexpress.com/eXpressAppFramework/112811/event-planning-and-notifications/scheduler-module?v=22.1). Cuando se hace referencia a este módulo, la vista de lista de  **eventos**  se muestra a través de un control especial. En las aplicaciones WinForms, este control es proporcionado por  [XtraScheduler Suite](https://www.devexpress.com/products/net/controls/winforms/scheduler/) ; en ASP.NET aplicaciones de formularios Web Forms, se utiliza el control proporcionado por  [ASPxScheduler Suite](https://www.devexpress.com/products/net/controls/asp/scheduler/). Ambos controles proporcionan una serie de características que serán útiles si necesita cambiar entre diferentes vistas de fecha, usar un navegador de fechas y varias técnicas de cita, imprimir y exportar datos de origen o personalizar la apariencia. Para obtener más información, consulte el tema  [Demostraciones  de programación de formularios Web Forms ASP.NET](https://demos.devexpress.com/ASPxSchedulerDemos/)  y  [Características principales](https://docs.devexpress.com/WindowsForms/1971/controls-and-libraries/scheduler?v=22.1)  del programador. Se proporcionan más ejemplos del uso de módulos adicionales XAF en la sección  [Módulos adicionales](https://docs.devexpress.com/eXpressAppFramework/112770/getting-started/in-depth-tutorial-winforms-webforms/extra-modules?v=22.1)  de este tutorial.

-   Para utilizar el módulo Programador en la aplicación WinForms, agréguelo al proyecto de módulo WinForms. Para ello, busque el archivo WinModule.cs (WinModule.vb) en el proyecto de aplicación  _MySolution.Module.Win_  que se muestra en el  **Explorador de soluciones**.  Haga doble clic en este archivo para invocar el  [Diseñador de módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). En el  **Cuadro de herramientas**, desplácese hasta DX**.22.1: Sección Módulos XAF**. Arrastre el elemento  **SchedulerWindowsFormsModule**  al panel  **Módulos requeridos**  del diseñador y genere el proyecto.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/723297c9-4809-4a07-92d1-80e6d7829069)

    
    Para utilizar el módulo Programador en una aplicación ASP.NET de formularios Web Forms, agréguelo al proyecto de módulo ASP.NET formularios Web Forms. Para ello, invoque el Diseñador de  [módulos](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  haciendo doble clic en el archivo WebModule_.cs (WebModule__.vb_). A continuación, arrastre el elemento  **SchedulerAspNetModule**  desde el Cuadro de  **herramientas**  hasta el panel  **RequiredModules**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/578cf14d-4d1c-477b-b4cb-fc80a8af4538)

    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. Seleccione el elemento  **Evento del programador**  en el  **control de navegación**. La lista de objetos de evento (denominada "Vista de lista  **de**  eventos") se mostrará mediante el control  **Programador**. Puede crear nuevos objetos  **Event**  haciendo clic en el botón  **Nuevo**  (![btn_new](https://docs.devexpress.com/eXpressAppFramework/images/btn_new117411.png?v=22.1)) de la barra de herramientas. Como alternativa, puede seleccionar un área en la vista de línea de tiempo, hacer clic con el botón derecho en ella y elegir  **Nueva cita**.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6602fba0-05e6-4434-85df-8b2f08e9513f)

    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/0aaab529-21b4-481c-bde0-12fb74d9e9c5)

    


>NOTA
Las horas de inicio y finalización predeterminadas del nuevo evento corresponden al intervalo seleccionado en el control del programador. Además, puede crear eventos con el comando  **Nuevo** en el menú contextual del control.

>PROPINA
XAF tiene un módulo especial de notificaciones  que permite establecer notificaciones para eventos. Consulte el tema de ayuda  [Cómo: Usar notificaciones con el evento del programador](https://docs.devexpress.com/eXpressAppFramework/113687/event-planning-and-notifications/how-to-use-notifications-with-the-scheduler-event?v=22.1) para obtener información sobre cómo usarlo en la aplicación.



# Agregar reglas de validación a clases empresariales

Para agregar funcionalidad de validación a la aplicación XAF, siga los pasos descritos en las lecciones Implementar validación de valor de propiedad en  [código (XPO)](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)  e  [Implementar validación de valor de propiedad en el modelo de aplicación](https://docs.devexpress.com/eXpressAppFramework/112750/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/implement-property-value-validation-in-the-application-model?v=22.1).


# Sistema de seguridad

**eXpressApp Framework**  proporciona el sistema de seguridad utilizado para proteger los datos de las aplicaciones empresariales. En esta sección del tutorial, aprenderá a usar el sistema de seguridad y sus características. Ofrecemos las siguientes lecciones.

-   [Uso del sistema de seguridad](https://docs.devexpress.com/eXpressAppFramework/112768/getting-started/in-depth-tutorial-winforms-webforms/security-system/using-the-security-system?v=22.1)
-   [Acceder al sistema de seguridad en código](https://docs.devexpress.com/eXpressAppFramework/112769/getting-started/in-depth-tutorial-winforms-webforms/security-system/access-the-security-system-in-code?v=22.1)


# Uso del sistema de seguridad (.NET Framework)


En esta lección, aprenderá a utilizar un  **sistema de seguridad**  en la aplicación. Cuando se utiliza este sistema, la estrategia de seguridad  [SecurityStrategyComplex](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.SecurityStrategyComplex?v=22.1)  se aplica a la aplicación. De acuerdo con esta estrategia, los usuarios tienen roles, que a su vez se caracterizan por un conjunto de  **permisos**. Este tema le guiará a través de la creación de un administrador y un usuario común en el código. El administrador tendrá un conjunto de permisos de acceso completo y el usuario tendrá un conjunto de permisos limitado. Verá cómo el administrador puede crear usuarios y roles, especificar  **permisos**  para ellos y, a continuación, asignar  **roles**  a  **usuarios**  en tiempo  de ejecución. También utilizará el tipo de autenticación  [AuthenticationStandard](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.AuthenticationStandard?v=22.1)  para iniciar sesión en la aplicación.

>NOTA
Antes de continuar, tómese un momento para revisar los siguientes temas.
>-   [Crear una solución mediante el asistente](https://docs.devexpress.com/eXpressAppFramework/112717/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/create-a-solution-using-the-wizard?v=22.1)
>-   [Proporcionar datos iniciales](https://docs.devexpress.com/eXpressAppFramework/112788/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/supply-initial-data-xpo?v=22.1)

## Autenticación de Active Directory

Si ha seguido la lección  [Crear una solución mediante el asistente](https://docs.devexpress.com/eXpressAppFramework/112717/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/create-a-solution-using-the-wizard?v=22.1), ya ha habilitado el sistema de seguridad con la autenticación  [AuthenticationActiveDirectory](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.AuthenticationActiveDirectory?v=22.1).

Invoque el Diseñador de aplicaciones para la aplicación WinForms y eche un vistazo a la sección Seguridad.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/9e2fe8c6-8a78-457f-950e-bda8f2e69a48)


Como puede ver en la imagen anterior, se usa una estrategia de seguridad compleja y autenticación de Active Directory, y la propiedad  **CreateUserAutomatically**  se establece en  **true**. Esto significa que un objeto de usuario (**PermissionPolicyUser**) se crea automáticamente la primera vez que se ejecuta la aplicación.  **La propiedad UserName**  de este objeto se establece en su cuenta de Active Directory. Tiene todos los permisos, ya que el tipo de usuario creado automáticamente es un administrador. Para ver los detalles de este usuario en tiempo de ejecución, vaya a los elementos User y MyDetails en el control de navegación.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/12bca6ae-8e07-4965-a35c-0b071a7c58c5)


Ahora, siga el Tutorial para aprender cómo cambiar el tipo de autenticación en su aplicación.

## Autenticación estándar

-   Invoque el Diseñador de aplicaciones para la aplicación WinForms. Para utilizar una estrategia de autenticación estándar, arrastre el componente  **AuthenticationStandard**  desde el  **DX.22.1: ficha Caja de herramientas de seguridad XAF**  a la sección  _Seguridad_  del diseñador.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/2dd34856-83d7-4d70-b3d3-e8aa45c92586)

    
-   Invoque el  **Diseñador de aplicaciones**  para la aplicación ASP.NET formularios Web Forms. Arrastre el componente  **AuthenticationStandard**  desde el  **DX.22.1: ficha Caja de herramientas de seguridad XAF**  a la sección  **Seguridad**  del diseñador.

## Crear usuarios y roles predefinidos en el código

-   Antes de ejecutar una aplicación con la  **autenticación estándar**  habilitada, cree varios objetos de negocio Usuarios y Roles predefinidos  **y**  asigne los  **Roles**  a  **los Usuarios**.  Esto le permitirá iniciar sesión y crear más  **usuarios**  en tiempo de ejecución.
    
    Los objetos que deben existir en la base de datos mientras se ejecuta la aplicación se crean en el método  [ModuleUpdater.UpdateDatabaseAfterUpdateSchema](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater.UpdateDatabaseAfterUpdateSchema?v=22.1)  en  _MySolution.Module_  |  _Actualización de base de datos_  |  _Archivo Updater.cs_/_Updater.vb_  (consulte el tema  [Proporcionar datos iniciales](https://docs.devexpress.com/eXpressAppFramework/112788/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/supply-initial-data-xpo?v=22.1)).
    
    Primero, cree  **roles**. El código siguiente muestra cómo crear un  **rol**  "Administradores".
    

    
    ```csharp
    using DevExpress.ExpressApp.Security;
    // ...
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
        // ...
        PermissionPolicyRole adminRole = ObjectSpace.FirstOrDefault<PermissionPolicyRole>(role => role.Name == SecurityStrategy.AdministratorRoleName);
        if (adminRole == null) {
            adminRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
            adminRole.Name = SecurityStrategy.AdministratorRoleName;
            adminRole.IsAdministrative = true;
        }
        // ...
    }
    
    ```
    
    Aquí, el rol "Administradores" tiene acceso completo a objetos de todo tipo, porque su propiedad  [IPermissionPolicyRole.IsAdministrative](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.IPermissionPolicyRole.IsAdministrative?v=22.1)  está establecida en  **true**.
    
    Ahora cree un rol "Usuarios",  un  **rol**  muy básico que solo tendrá acceso al objeto de usuario actual. Más adelante, puede extender el conjunto de permisos de este  **rol**  en la interfaz de usuario mediante métodos de extensión de la clase  [PermissionSettingHelper](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.PermissionSettingHelper?v=22.1). Consulte el código siguiente.
    

    
    ```csharp
    public override void UpdateDatabaseAfterUpdateSchema() {
        // ...
        PermissionPolicyRole userRole = ObjectSpace.FirstOrDefault<PermissionPolicyRole>(role => role.Name == "Users");
        if(userRole == null) {
            userRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
            userRole.Name = "Users";
            userRole.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
            userRole.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, 
    SecurityPermissionState.Deny);
            userRole.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, 
    SecurityPermissionState.Deny);
            userRole.AddObjectPermissionFromLambda<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, 
    u => u.Oid == (Guid)CurrentUserIdOperator.CurrentUserId(), SecurityPermissionState.Allow);
            userRole.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, 
    "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
            userRole.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, 
    "StoredPassword", null, SecurityPermissionState.Allow);
            userRole.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
            userRole.AddTypePermission<PermissionPolicyTypePermissionObject>("Write;Delete;Navigate;Create", SecurityPermissionState.Deny);
            userRole.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Write;Delete;Navigate;Create", 
    SecurityPermissionState.Deny);
            userRole.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Write;Delete;Navigate;Create", 
    SecurityPermissionState.Deny);
        }
        //...
    }
    
    ```
    
    En el código siguiente se muestra cómo crear usuarios.
    

    
    ```csharp
    using DevExpress.ExpressApp.Security;
    // ...
    public class Updater : ModuleUpdater {
       public Updater(IObjectSpace objectSpace, Version currentDBVersion) 
          : base(objectSpace, currentDBVersion) { }   
       public override void UpdateDatabaseAfterUpdateSchema() {
          // ...
          // If a user named 'Sam' does not exist in the database, create this user.
          PermissionPolicyUser user1 = ObjectSpace.FirstOrDefault<PermissionPolicyUser>(user => user.UserName == "Sam");
          if(user1 == null) {
             user1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
             user1.UserName = "Sam";
             // Set a password if the standard authentication type is used.
             user1.SetPassword("");
          }
          // If a user named 'John' does not exist in the database, create this user.
          PermissionPolicyUser user2 = ObjectSpace.FirstOrDefault<PermissionPolicyUser>(user => user.UserName == "John");
          if(user2 == null) {
             user2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
             user2.UserName = "John";
             // Set a password if the standard authentication type is used.
             user2.SetPassword("");
          }
       }
    }
    
    ```
    
    Finalmente, asignará  **roles**  a  **los usuarios**.
    

    
    ```csharp
    public class Updater : ModuleUpdater {
        // ... 
        public override void UpdateDatabaseAfterUpdateSchema() {
          // ...
          user1.Roles.Add(adminRole);
          user2.Roles.Add(userRole);
        }
    }
    
    ```
    
    >NOTA
    Se proporcionan más ejemplos en el tema  [Seguridad del lado cliente (arquitectura de 2 niveles).](https://docs.devexpress.com/eXpressAppFramework/113436/data-security-and-safety/security-system/security-tiers/2-tier-security-integrated-mode-and-ui-level?v=22.1)
    
-   Ejecute la aplicación WinForms o ASP.NET formularios Web Forms. La siguiente ventana de inicio de sesión se mostrará en una aplicación de WinForms.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/cc511014-f597-4473-975e-985b16003955)

    
    La siguiente ventana se mostrará en la aplicación ASP.NET formularios Web Forms.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/335b9199-2e7f-4376-bb0d-2280f8fc59e2)

    
    Después de hacer clic en el botón  **Iniciar sesión**, se autentican las credenciales del usuario y se ejecutará la aplicación.
    

## Crear un rol en una interfaz de usuario

Los administradores y otros usuarios con permiso de creación de roles pueden crear roles de la siguiente manera.

Seleccione el elemento  **Rol**  en el control de navegación y haga clic  **en Nueva acción**. En la vista de detalles invocada, establezca el nombre y los permisos para el nuevo rol.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/0fa0276a-546e-46cc-a89d-a790de1a7e49)


Con la propiedad  **Directiva de permisos**, puede asignar directivas de permisos predeterminadas "denegar todo", "solo leer todo" o "permitir todo" para cada rol. Para cada operación, puede especificar explícitamente el modificador Permitir o Denegar o dejarlo en blanco. Si no se especifica el modificador, el permiso viene determinado por la directiva de permisos del rol.

## Crear un usuario en una interfaz de usuario

Los usuarios que tienen permiso para crear usuarios pueden hacer lo siguiente.

Seleccione el elemento  **Usuario**  en el control de navegación y haga clic en el botón  **Nuevo**. En la vista de detalles invocada, especifique el  **nombre de usuario**  y asigne uno o más roles.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c982cc3c-e4eb-403d-869f-67356a36636d)



>NOTA
Establezca la propiedad  **Is Active** en **false** si necesita prohibir temporalmente al usuario el uso de la aplicación.

Para asignar una contraseña a un usuario recién creado, haga clic en el botón  **Restablecer contraseña**. La contraseña asignada debe pasarse al usuario. Un usuario podrá cambiarlo al iniciar sesión por primera vez.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/eb562525-263f-4f98-a343-47fbb8540d67)


NOTA

Este botón es la acción  **Restablecercontraseña**, que está disponible para los usuarios que tienen permiso para modificar objetos de usuario. Este botón no está disponible cuando se utiliza la autenticación de Active Directory.

## Mis datos

El elemento  **de navegación Mis detalles**  está disponible para los usuarios que tienen acceso de lectura al objeto User actual. Este elemento de navegación abre los detalles del usuario actual.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/c8fb2266-620a-40ff-98f8-57716416958c)


En una aplicación ASP.NET formularios Web Forms, también se puede abrir haciendo clic en el vínculo  **Mis detalles**  en la esquina superior derecha de la página.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/7c11ee1a-2f50-4143-abb6-af36781b4949)


## Cambiar contraseña

Cuando se utiliza el tipo de autenticación estándar, el botón  **Cambiar mi contraseña**  está disponible una vez que se muestra la vista de detalles  **Mis detalles**. Este botón abre un cuadro de diálogo donde un usuario puede cambiar la contraseña.

![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/b68108a3-056b-4070-bd9f-cfff70cf4302)


>NOTA
This button is the **ChangePasswordByUser** Action that is not available if the Active Directory authentication is used. To change a password in this instance, end users can use the operating system’s standard tools (e.g., press **CTRL**+**ALT**+**DEL** and select **Change a password**).



# Acceder al sistema de seguridad en código


Esta lección le guiará a través del uso de la clase  [SecurityStrategy](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.SecurityStrategy?v=22.1)  para comprobar si un usuario tiene o no un permiso determinado. La acción  [SetTask](https://docs.devexpress.com/eXpressAppFramework/112738/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-with-option-selection?v=22.1)  será accesible para los usuarios que tengan permiso para modificar objetos  **DemoTask**.

>NOTA
>Antes de continuar, le recomendamos que revise las siguientes lecciones:
>-   [Uso del sistema de seguridad](https://docs.devexpress.com/eXpressAppFramework/112768/getting-started/in-depth-tutorial-winforms-webforms/security-system/using-the-security-system?v=22.1)
>-   [Agregar una acción con selección de opción](https://docs.devexpress.com/eXpressAppFramework/112738/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-with-option-selection?v=22.1)

-   Abra el archivo TaskActionsController_.cs (TaskActionsController__.vb_) que creó en la lección  [Agregar una acción con selección de opciones](https://docs.devexpress.com/eXpressAppFramework/112738/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-with-option-selection?v=22.1). Agregue la directiva "using" y modifique el controlador de eventos  **Activated**  como se muestra a continuación.
    

    
    ```csharp
    using DevExpress.ExpressApp.Security;
    //...
    public partial class TaskActionsController : ViewController {
        // ...
        private void TaskActionsController_Activated(object sender, EventArgs e) {
            View.SelectionChanged += View_SelectionChanged;
            UpdateSetTaskActionState();
        }
        void View_SelectionChanged(object sender, EventArgs e) {
            UpdateSetTaskActionState();
        }
        private void UpdateSetTaskActionState() {
            bool isGranted = true;
            SecurityStrategy security = Application.GetSecurityStrategy();
            foreach(object selectedObject in View.SelectedObjects) {
                bool isPriorityGranted = security.CanWrite(selectedObject, nameof(DemoTask.Priority));
                bool isStatusGranted = security.CanWrite(selectedObject, nameof(DemoTask.Status));
                if(!isPriorityGranted || !isStatusGranted) {
                    isGranted = false;
                }
            }
            SetTaskAction.Enabled.SetItemValue("SecurityAllowance", isGranted);
        }
    }
    
    ```
    
    Con el código agregado, se activará la acción  **Establecer tarea**  para los usuarios que tengan permisos de escritura para las propiedades  **Priority**  y  **Status**  de los objetos  **DemoTask**  seleccionados.
    
-   Agregue un usuario que no tenga permiso para modificar los objetos  **DemoTask**  (consulte  [Uso del sistema de seguridad](https://docs.devexpress.com/eXpressAppFramework/112768/getting-started/in-depth-tutorial-winforms-webforms/security-system/using-the-security-system?v=22.1)). Ejecute la aplicación como este nuevo usuario. La acción  **Definir tarea**  no estará visible cuando muestre la vista Lista de tareas de demostración.

Esta es la última lección del  [tutorial en profundidad](https://docs.devexpress.com/eXpressAppFramework/112560/getting-started/in-depth-tutorial-winforms-webforms?v=22.1). Para obtener información sobre cómo implementar aplicaciones XAF, revise el  [Tutorial de implementación](https://docs.devexpress.com/eXpressAppFramework/113231/deployment/deployment-tutorial?v=22.1).
