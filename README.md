[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/jjcolumb/SimpleProjectManager#readme)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](https://github.com/jjcolumb/SimpleProjectManager/blob/master/README.es.md)
# In-Depth XAF WinForms & Web Forms Tutorial (Main Demo)

Follow this tutorial to create a simple application used to store contacts and other related objects as you learn about the fundamentals of the  **eXpressApp Framework**.

## Dependencies and Prerequisites

Before you start the tutorial, read this section and ensure that the following conditions are met:

1.  Any non-Express  [supported version](https://www.devexpress.com/support/versions.xml)  of  [Visual Studio](https://visualstudio.microsoft.com/)  is installed on your machine. You have basic experience of .NET framework development in this IDE.
2.  A  [free 30-day trial](https://www.devexpress.com/products/try/)  version or a licensed version of  [DevExpress Universal Subscription](https://www.devexpress.com/Subscriptions/Universal.xml)  is installed on your machine.
3.  You have basic knowledge of  [Object-relational mapping (ORM)](https://en.wikipedia.org/wiki/Object-relational_mapping)  concepts and  [DevExpress XPO](https://www.devexpress.com/products/net/orm/).
4.  Any  [RDBMS](https://en.wikipedia.org/wiki/Relational_database_management_system)  supported by the XPO (see  [Database Systems Supported by XPO](https://docs.devexpress.com/XPO/2114/product-information/database-systems-supported-by-xpo?v=22.1)) ORM tool is installed and accessible from your machine to store the application data (a LocalDB or SQL Server Express instance is recommended).
5.  You are familiar with  [XAF application architecture](https://docs.devexpress.com/eXpressAppFramework/112559/overview/architecture?v=22.1).

## Tutorial Structure

The tutorial consists of the following sections.

-   [Business Model Design](https://docs.devexpress.com/eXpressAppFramework/112730/getting-started/in-depth-tutorial-winforms-webforms/business-model-design?v=22.1)
    
    This section describes the use of the  [eXpress Persistent Objects (XPO)](https://www.devexpress.com/Products/NET/ORM/)  object-relational mapping ([ORM](https://en.wikipedia.org/wiki/Object-relational_mapping)) tool. You will implement classes that will form the business model (which defines the database tables) of your application. As a result of completing this section, you will end up with two automatically generated interfaces based on the same business model - a WinForms application and a website. In addition, these applications will contain a set of features that form the base application functionality.
    
    ![Main_Demo_BMD](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_bmd117570.png?v=22.1)
    
-   [Extend Functionality](https://docs.devexpress.com/eXpressAppFramework/112740/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality?v=22.1)
    
    In this section, you will add custom features to the application built in the previous section.
    
    ![Main_Demo_Extend](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_extend117574.png?v=22.1)
    
-   [UI Customization](https://docs.devexpress.com/eXpressAppFramework/112748/getting-started/in-depth-tutorial-winforms-webforms/ui-customization?v=22.1)
    
    This section will teach you how to easily customize the automatically generated UI of an application.
    
    ![Main_Demo_UI](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_ui117575.png?v=22.1)
    
-   [Extra Modules](https://docs.devexpress.com/eXpressAppFramework/112770/getting-started/in-depth-tutorial-winforms-webforms/extra-modules?v=22.1)
    
    In this section, you will add extra features supplied with XAF (file attachment, data analysis, report generation, etc.).
    
    ![Main_Demo_Modules](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_modules117572.png?v=22.1)
    
-   [Security System](https://docs.devexpress.com/eXpressAppFramework/112771/getting-started/in-depth-tutorial-winforms-webforms/security-system?v=22.1)
    
    Use this section to learn how to make the application secure by adding the XAF Security System to it.
    
    ![Main_Demo_Sec](https://docs.devexpress.com/eXpressAppFramework/images/main_demo_sec117573.png?v=22.1)
    

Each section consists of a number of lessons. Each lesson provides the steps required for implementing the functionality mentioned in the lesson title. These steps include the exact instructions , and may also include code snippets (in C# and VB) and images.

The final application created as a result of this tutorial is included in the XAF installation. This application is intended to demonstrate a wide variety of features for implementing tasks in XAF applications.

## Connection String

Begin by ensuring that you have a  **Microsoft SQL Server**  database management system (DBMS) installed. If you use a different DBMS, you will need to provide the proper connection strings.

Use the  [Solution Wizard](https://docs.devexpress.com/eXpressAppFramework/113624/installation-upgrade-version-history/visual-studio-integration/solution-wizard?v=22.1)  to create a solution. The wizard attempts to detect your installed SQL server and changes the connection string accordingly. Supported servers are  **Microsoft SQL Server**  (including the  **Express**  and  **LocalDB**  editions). To use another database system (PostgreSQL, MySQL, Oracle, SQLite, Firebird, etc.), change the  **ConnectionString**  argument in the  _App.config_  and  _Web.config_  files of the WinForms/ASP.NET Web Forms application projects. Refer to the  [Connect an XAF Application to a Database Provider](https://docs.devexpress.com/eXpressAppFramework/113155/business-model-design-orm/connect-an-xaf-application-to-a-database-provider?v=22.1)  topic for details about connecting to different database systems. A database will be created on the server under the name of the solution you created. If you wish to change any of these details, you will need to make the necessary changes to the connection string by using the application configuration file (_App.config_  or  _Web.config_) or using the  [Application Designer](https://docs.devexpress.com/eXpressAppFramework/112827/installation-upgrade-version-history/visual-studio-integration/application-designer?v=22.1). Refer to the  [Connect an XAF Application to a Database Provider](https://docs.devexpress.com/eXpressAppFramework/113155/business-model-design-orm/connect-an-xaf-application-to-a-database-provider?v=22.1)  topic for additional information on connection strings.

If you ever need to recreate your database, just drop it from the database server or remove the file, and it will be recreated automatically the next time the application runs.

# Business Model Design

>NOTE
This section describes the use of the [eXpress Persistent Objects (XPO)](https://www.devexpress.com/Products/NET/ORM/) object-relational mapping ([ORM](https://en.wikipedia.org/wiki/Object-relational_mapping)) tool.

In this section, you will learn how to design a business model (database) when building business applications via the  **eXpressApp Framework**. You will create business classes that will be mapped to database tables. You will also learn how to set relationships between classes, implement dependent properties, validate property values, and so on.

To design a business model, the following techniques will be used.

-   **Use the Business Class Library**
    
    The  [Business Class Library](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1)  provides the most commonly used business classes, such as  **Person**,  **Event**,  **Task**, etc. You can use a class from this library as is, or inherit from it to extend it.
    
-   **From Scratch**
    
    If the  **Business Class Library**  does not provide the appropriate business class, inherit from one of the  [Base Persistent Classes](https://docs.devexpress.com/eXpressAppFramework/113146/business-model-design-orm/business-model-design-with-xpo/base-persistent-classes?v=22.1).
    

>TIP
If you need to build an application based on an existing database, refer to the following help topic: [How to: Generate XPO Business Classes for Existing Data Tables](https://docs.devexpress.com/eXpressAppFramework/113451/business-model-design-orm/business-model-design-with-xpo/generate-xpo-business-classes-for-existing-data-tables?v=22.1).

After completing the tutorial, you will have WinForms and ASP.NET Web Forms applications.

![Tutorial_BMD_Lesson0_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson0_1115540.png?v=22.1)

The ASP.NET Web Forms application will provide almost the same functionality, but via a slightly different set of visual elements.

![Tutorial_BMD_Lesson0_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson0_2115541.png?v=22.1)

![Tutorial_BMD_Lesson0_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson0_3117477.png?v=22.1)

# Create a Solution using the Wizard

In this lesson, you will learn how to create a new XAF solution. You will also be able to run the generated WinForms and ASP.NET Web Forms applications, and see the default application state.

-   From the Visual Studio main menu, select  **File**  |  **New**  |  **Project…**  to invoke the  **New Project**  dialog.
    
-   Select  **DevExpress v22.1  XAF Template Gallery**  for C# or Visual Basic and click  **Next**. Specify the project name (“MySolution”) and click  **Create**.
    
    ![Create a new XAF project](https://docs.devexpress.com/eXpressAppFramework/images/spm_newproject_blazor.png?v=22.1)
    
-   In the invoked Template Gallery, select  **XAF Solution Wizard (.NET Framework)**  in the  **.NET Framework**  section and click  **Run Wizard**.
    
    ![Select "XAF Solution Wizard (.NET Framework)" in the Template Gallery](https://docs.devexpress.com/eXpressAppFramework/images/MainDemo_TemplateGallery_RunWizard_WinWeb.png?v=22.1)
    
-   This will invoke the  **Solution Wizard**. In the first screen of the wizard, choose the target platform(s). You can create separate WinForms, ASP.NET Web Forms applications, or multiple applications at once. Choose the  **WinForms**  and  **Web**  platforms and click  **Next**.
    
    ![Choose Target Platforms](https://docs.devexpress.com/eXpressAppFramework/images/ctutor_solution_wizard_1117478_large.png?v=22.1)
    
-   In the next screen, choose  **eXpress Persistent Objects**  and click  **Next**.
    
    ![Choose ORM](https://docs.devexpress.com/eXpressAppFramework/images/ctutor_solution_wizard_2117479.png?v=22.1)
    
-   In the next screen, you can choose the security options of your application. Choose  **Active Directory**  as the  **Authentication**  type, select  **Client-Side Security - Integrated Mode**  as the  **Database security**  type, and click  **Next**.
    
    ![Choose Security](https://docs.devexpress.com/eXpressAppFramework/images/ctutor_solution_wizard_3_xpo117484.png?v=22.1)
    
-   On the next screen, you can choose the required XAF modules, which will automatically be added to your application. Select the  [Business Class Library Customization](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1#business-class-library-customization-module)  module and click  **Finish**.
    
    ![Choose Extra Modules](https://docs.devexpress.com/eXpressAppFramework/images/ctutor_solution_wizard_4117481.png?v=22.1)
    
    >NOTE
    Most of the other modules will be added manually in the [Extra Modules](https://docs.devexpress.com/eXpressAppFramework/112770/getting-started/in-depth-tutorial-winforms-webforms/extra-modules?v=22.1) section.
    

Once the solution has been created, you will see five projects in the  **Solution Explorer**.

-   _MySolution.Module_  - the basic  [module](https://docs.devexpress.com/eXpressAppFramework/118046/application-shell-and-base-infrastructure/application-solution-components/modules?v=22.1)  project that contains code common to WinForms and ASP.NET Web Forms applications.
-   _MySolution.Module.Web_  - the module project that contains code specific to the ASP.NET Web Forms application.
-   _MySolution.Module.Win_  - the module project that contains code specific to the WinForms application.
-   _MySolution.Web_  - the ASP.NET Web Forms application project is similar to the WinForms application, but generates a browser-based interface instead of a WinForms interface. Do not use this project for feature implementation. All application logic should be implemented in the appropriate Module projects.
-   _MySolution.Win_  - the WinForms application project, which relies on basic and WinForms modules, automatically generates the Windows user interface. Do not use this project for feature implementation. All application logic should be implemented in the appropriate Module projects.

![Tutorial_BMD_Lesson1_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson1_2115423.png?v=22.1)

You can refer to the  [Application Solution Structure](https://docs.devexpress.com/eXpressAppFramework/118045/application-shell-and-base-infrastructure/application-solution-components/application-solution-structure?v=22.1)  topic for additional information on the XAF solution structure.

>NOTE
The wizard attempts to detect your installed SQL server and changes the connection string accordingly. Supported servers are **Microsoft SQL Server** (including the **Express** and **LocalDB** editions). To use another database system (PostgreSQL, MySQL, Oracle, SQLite, Firebird, etc.), change the **ConnectionString** argument in the _App.config_ and _Web.config_ files of the WinForms/ASP.NET Web Forms application projects. Refer to the [Connect an XAF Application to a Database Provider](https://docs.devexpress.com/eXpressAppFramework/113155/business-model-design-orm/connect-an-xaf-application-to-a-database-provider?v=22.1) topic for details about connecting to different database systems.

You can now run the WinForms and ASP.NET Web Forms applications. By default, the WinForms project is set as the startup project. To run the ASP.NET Web Forms application, right-click the  **MySolution.Web**  project in the  **Solution Explorer**, and select the  **Set as StartUp Project**  item from the context menu. Then, click  **Start Debugging**  or press the  **F5**  key.

The following images show the resulting WinForms and ASP.NET Web Forms applications. They will already contain the security options for your  _Active Directory_  account.

**WinForms**

![Tutorial_BMD_Lesson1_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson1_3115424.png?v=22.1)

**ASP.NET Web Forms**

![Tutorial_BMD_Lesson1_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson1_4117402.png?v=22.1)

By default, the wizard enables the  **Tabbed MDI**  UI type and the  **Ribbon**  Form Style in the WinForms application. Refer to the  [Choose the WinForms UI Type](https://docs.devexpress.com/eXpressAppFramework/113264/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/choose-the-winforms-ui-type?v=22.1)  and  [Toggle the WinForms Ribbon Interface](https://docs.devexpress.com/eXpressAppFramework/113038/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/toggle-the-winforms-ribbon-interface?v=22.1)  topics to learn how to change these options.

# Inherit from the Business Class Library Class (XPO)

>TIP
For **.NET 6** applications, see: [Inherit from the Business Class Library Class (XPO, .NET 6)](https://docs.devexpress.com/eXpressAppFramework/402166/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/inherit-from-the-business-class-library-class-xpo?v=22.1).

In this lesson, you will learn how to implement business classes for your application using the  [Business Class Library](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1). This library contains the most typical ready-to-use business classes. You will implement a custom  **Contact**  class by deriving from the  **Person**  class available in this library, and implement several additional properties. You will also learn the basics of automatic user interface construction based on data.

-   Typically, business classes should be implemented in a  [platform-independent module project](https://docs.devexpress.com/eXpressAppFramework/118045/application-shell-and-base-infrastructure/application-solution-components/application-solution-structure?v=22.1), so that the same objects will be available in both WinForms and ASP.NET Web Forms applications. To simplify the implementation of XAF-specific classes, several Visual Studio templates are supplied. In this lesson, you will use the  **XPO Business Object**  template to implement a persistent business class. Right-click the  _Business Objects_  folder in the  _MySolution.Module_  project, and choose  **Add DevExpress Item**  |  **New Item…**  to invoke  [Template Gallery](https://docs.devexpress.com/eXpressAppFramework/113455/installation-upgrade-version-history/visual-studio-integration/template-gallery?v=22.1).Then select the  **XAF Business Object** | **XPO Business Object**  template, specify  _Contact.cs_  as the new item’s name and press  **Add Item**. As a result, you will get an automatically generated code file with a single class declaration.
    
    ![TemplateGalery_XPO](https://docs.devexpress.com/eXpressAppFramework/images/templategalery_xpo123144.png?v=22.1)
    
    The auto-generated  **Contact**  class is a  [BaseObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.BaseImpl.BaseObject?v=22.1)  class descendant, which is one of the  [base persistent classes](https://docs.devexpress.com/eXpressAppFramework/113146/business-model-design-orm/business-model-design-with-xpo/base-persistent-classes?v=22.1). You should inherit one of these classes when implementing a persistent class from scratch is required, or use  [Business Class Library](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1)  classes (which are derived from the  **BaseObject**  class as well). For a general overview of the business class concept, refer to the  [Business Classes vs Database Tables](https://docs.devexpress.com/eXpressAppFramework/112570/business-model-design-orm/business-model-design-with-xpo/business-classes-vs-database-tables?v=22.1)  topic.
    
-   Replace the automatically generated class declaration with the following code.

    
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
    
    As you can see, the  **Contact**  class ancestor is changed from  **BaseObject**  to  **Person**, and several custom properties are implemented. Note that the  **Contact**  constructor and the  **SetPropertyValue**  method is used in property setters. These are specifics of the  [eXpress Persistent Objects (XPO)](https://www.devexpress.com/Products/NET/ORM/index.xml)  object-relational mapper utilized by XAF. You can refer to the  [XPO Best Practices](https://docs.devexpress.com/XPO/403711/best-practices/xpo-best-practices?v=22.1)  knowledge base article and the  [Creating a Persistent Object](https://docs.devexpress.com/XPO/2077/create-a-data-model/create-a-persistent-object?v=22.1)  topic in the XPO documentation for details.
    
    Note the use of the  [DefaultClassOptionsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DefaultClassOptionsAttribute?v=22.1)  attribute. In this tutorial, this attribute means that the following capabilities will be available for the  **Contact**  business class.
    
    -   The  **Contact**  item will be added to the main form’s navigation control. When clicking this item, a  [List View](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1)  will be displayed. This List View represents a list of objects of the  **Contact**  type.
    -   The  **Contact**  item will be added to the submenu of the  **New**  (![new_dropdown_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_new_dropdown117415.png?v=22.1)) button when objects of another type are displayed in the List View. Click this item to invoke a  **Contact**  detail form and create a new  **Contact**  object.
    -   The  **Contact**  objects will be provided as a data source to generate reports (see  [Create a Report in Visual Studio](https://docs.devexpress.com/eXpressAppFramework/112734/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/create-a-report-in-visual-studio?v=22.1)).
    
    To apply each of these options separately, use the  [NavigationItemAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.NavigationItemAttribute?v=22.1),  [CreatableItemAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.CreatableItemAttribute?v=22.1)  and  [VisibleInReportsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.VisibleInReportsAttribute?v=22.1)  attributes.
    
   > NOTE
    [CodeRush](https://www.devexpress.com/products/coderush/) includes a number of Code Templates that help generate business classes or their parts with a few keystrokes. To learn about the Code Templates for **eXpress Persistent Objects**, refer to the following help topic: [XPO and XAF Templates](https://docs.devexpress.com/CodeRushForRoslyn/118557/coding-assistance/code-templates/xpo-templates?v=22.1).
    
-   Run the WinForms or ASP.NET Web Forms application. You will see how the user interface is automatically generated using the specified data structures. There will be a navigation control allowing you to display the  **Contact**  list. You will be able to customize this collection using the corresponding editors. If you click the  **New**  button or double-click an existing record, the application will show a detail form ([Detail View](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1)) filled with editors for each data field.
    
    The following image demonstrates the Detail and List Views in the WinForms application.
    
    ![Tutorial_BMD_Lesson2_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson2_2116011.png?v=22.1)
    
    Notice that many elements have been generated in an intuitive manner in very little time. The proper editors are created for data fields, and appropriate editors are used in the grid controls to display data. Note that a combo box editor has been created for  **Title Of Courtesy**  (an enumerator). Also note that captions have automatically been transformed from camel-case to space-separated strings, form titles are automatically updated, etc.
    
    You can use the grid features to show, hide and rearrange columns, and apply grouping, filtering and sorting to a List View at runtime. In the WinForms application, you can customize the editor layout on the detail form as you like at runtime. For this purpose, right-click an empty space and select  **Customize Layout**. You can now move editors to the required positions. To learn how to customize the editor layout at design time, refer to the  [Customize the View Items Layout](https://docs.devexpress.com/eXpressAppFramework/112833/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/customize-the-view-items-layout?v=22.1)  topic. Additionally, you can refer to the  [View Items Layout Customization](https://docs.devexpress.com/eXpressAppFramework/112817/ui-construction/views/layout/view-items-layout-customization?v=22.1)  and  [List View Column Generation](https://docs.devexpress.com/eXpressAppFramework/113285/ui-construction/views/layout/list-view-column-generation?v=22.1)  topics to see how the default Detail View layout and default List View column set are generated.
    

You can see the code demonstrated here in the  _MySolution.Module_  |  _Business Objects_  |  _Contact.cs_  (_Contact.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).

# Supply Initial Data (XPO)

>TIP
For **.NET 6** applications, see: [Supply Initial Data (XPO, .NET 6)](https://docs.devexpress.com/eXpressAppFramework/402170/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/supply-initial-data-xpo?v=22.1).

>NOTE
Before proceeding, take a moment to review the [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1) lesson.

-   Open the  _Updater.cs_  (_Updater.vb_) file, located in the  _MySolution.Module_  project’s  _Database Update_  folder. Add the following code to the  [ModuleUpdater.UpdateDatabaseAfterUpdateSchema](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater.UpdateDatabaseAfterUpdateSchema?v=22.1)  method.
    
 
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
    
    After adding the code above, the  **Contact**  object will be created in the application database, if it does not already exist.
    
    Each time you run the application, it compares the application version with the database version and finds changes in the application or database. If the database version is lower than the application version, the application raises the  [XafApplication.DatabaseVersionMismatch](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.DatabaseVersionMismatch?v=22.1)  event. This event is handled by the WinForms and ASP.NET Web Forms applications in a solution template. When the application runs in debug mode, this event handler uses the built-in  **Database Updater**  to update the application’s database. After the database schema is updated, the  [ModuleUpdater.UpdateDatabaseAfterUpdateSchema](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater.UpdateDatabaseAfterUpdateSchema?v=22.1)  method is called. In this method, you can save the required business objects to the database.
    
    As you can see in the code above, eXpressApp Framework (XAF) uses an  [Object Space](https://docs.devexpress.com/eXpressAppFramework/113707/data-manipulation-and-business-logic/object-space?v=22.1)  object to manipulate persistent objects (see  [Create, Read, Update and Delete Data](https://docs.devexpress.com/eXpressAppFramework/113711/data-manipulation-and-business-logic/create-read-update-and-delete-data?v=22.1)).
    
    To specify the criteria passed as a parameter in the  [BaseObjectSpace.FindObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.BaseObjectSpace.FindObject.overloads?v=22.1)  method call, the CriteriaOperator is used. Its  [CriteriaOperator.Parse](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.CriteriaOperator.Parse.overloads?v=22.1)  method converts a string, specifying a criteria expression to its CriteriaOperator equivalent. To learn more on how to specify criteria, refer to the  [Ways to Build Criteria](https://docs.devexpress.com/eXpressAppFramework/113052/filtering/in-list-view/ways-to-build-criteria?v=22.1)  topic.
    
-   Run the WinForms or ASP.NET Web Forms application. Select the  **Contact**  item in the navigation control. Notice that the new contact, “Mary Tellitson”, appears in the list to the right.
    
    ![Tutorial_BMD_Lesson2_5_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson2_5_1115542.png?v=22.1)
    

You can see the code for this tutorial in the  _MySolution.Module_  |  _Database Update_  |  _Updater.cs_  (_Updater.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).

# Implement Custom Business Classes and Reference Properties (XPO)
>TIP
For **.NET 6** applications, see: [Implement Custom Business Classes and Reference Properties (XPO, .NET 6)](https://docs.devexpress.com/eXpressAppFramework/402163/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/implement-custom-business-classes-and-reference-properties-xpo?v=22.1).

In this lesson, you will learn how to implement business classes from scratch. For this purpose, the  **Department**  and  **Position**  business classes will be implemented. These classes will be used in the  **Contact**  class, implemented previously. You will also learn the basics of automatic user interface construction for referenced objects.

>NOTE
Before proceeding, take a moment to review the [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1) lesson.

-   Add the following  **Department**  and  **Position**  persistent classes to the  _Contact.cs_  (_Contact.vb_) file.
    

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
    
    These new classes are persistent, as they are  [BaseObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.BaseImpl.BaseObject?v=22.1)  class descendants.
    
   > NOTE
    The **DefaultProperty** attribute is used in the code above. This attribute is used to specify the [default property](https://docs.devexpress.com/eXpressAppFramework/113525/business-model-design-orm/how-to-specify-a-display-member-for-a-lookup-editor-detail-form-caption?v=22.1) of the class. You can specify the most descriptive property of your class in the **DefaultProperty** attribute, and its values will be displayed in the following.

    
   -   Detail form captions
   -   The leftmost column of a List View
   -   The Lookup List Views (These Views will be explained in the last step of this lesson.)
    
   Refer to the [Data Annotations in Data Model](https://docs.devexpress.com/eXpressAppFramework/112701/business-model-design-orm/data-annotations-in-data-model?v=22.1) topic for additional information.
    
-   Add the  **Department**  and  **Position**  properties to the  **Contact**  class. The following code demonstrates this.
    

    
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
    
    The  **Contact**  class now exposes the  **Position**  and  **Department**  reference properties.
    
   > NOTE
    [CodeRush](https://www.devexpress.com/products/coderush/) includes a number of Code Templates that help generate business classes or their parts with a few keystrokes. To learn about the Code Templates for **eXpress Persistent Objects**, refer to the following help topic: [XPO and XAF Templates](https://docs.devexpress.com/CodeRushForRoslyn/118557/coding-assistance/code-templates/xpo-templates?v=22.1).
    
-   Run the WinForms or ASP.NET Web Forms application. You will see how the user interface is automatically generated using the specified data structures. The navigation control will contain new  **Department**  and  **Position**  items, which will allow you to access  **Department**  and  **Position**  objects. Note that in the  **Contact**  Detail View, a lookup editor has been created for  **Department**  and  **Position**. In this editor, a special type of  [View](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1), Lookup List View, is used. Typically, this View has a single column corresponding to the class’ default property. Using the lookup editor, you can select the required  **Department**  (**Position**) for the current  **Contact**, and add new  **Department**  (**Position**) objects using the  **New**  button. In addition, you will also be able to edit existing  **Department**  (**Position**) objects by holding down  **SHIFT**+**CTRL**  and clicking the selected object.
    
    ![Tutorial_BMD_Lesson3_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson3_1115427.png?v=22.1)
    

You can see the code demonstrated in this lesson in the  _MySolution.Module_  |  _Business Objects_  |  _Contact.cs_  (_Contact.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).

# Add a Class from the Business Class Library (XPO)

>TIP
For **.NET 6** applications, see: [Inherit from the Business Class Library Class (XPO, .NET 6)](https://docs.devexpress.com/eXpressAppFramework/402166/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/inherit-from-the-business-class-library-class-xpo?v=22.1).

In this lesson, you will learn how to use business classes from the  [Business Class Library](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1)  as is. For this purpose, you will add the  **Event**  business class to the application.

>NOTE
Before proceeding, take a moment to review the [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1) lesson.

-   In the Solution Explorer, find the  _Module.cs_  (_Module.vb_) file within the  _MySolution.Module_  project. Double-click it to invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1).
    
    ![Tutorial_BMD_Lesson4_0_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson4_0_0116698.png?v=22.1)
    
-   In the  **Exported Types**  section, locate the  **Referenced Assemblies**  |  **DevExpress.Persistent.BaseImpl.Xpo.v22.1**  |  **Event**  node. Select it and press the  **SPACEBAR**, or right-click it and choose  **Use Type in Application**  in the invoked context menu. The node will be marked in bold. This means that the  **Event**  business class will be added to the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1), and this class will take part in the UI construction process. The use of extra modules is detailed in the  [Extra Modules](https://docs.devexpress.com/eXpressAppFramework/112770/getting-started/in-depth-tutorial-winforms-webforms/extra-modules?v=22.1)  section of this tutorial.
    
    ![Tutorial_BMD_Lesson4_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson4_0115669.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application and note that the  **Scheduler Event**  navigation item is created, as the  **Event**  class has the  [NavigationItemAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.NavigationItemAttribute?v=22.1)  applied. Note that it may be necessary to add other classes from the  **Business Class Library**  to the navigation manually (see the  [Add an Item to the Navigation Control](https://docs.devexpress.com/eXpressAppFramework/112749/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-navigation-control?v=22.1)  topic).
    
    ![Tutorial_BMD_Lesson4_10](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson4_10117559.png?v=22.1)
    

>TIP
XAF has a special **Scheduler module** contains [List Editor](https://docs.devexpress.com/eXpressAppFramework/113189/ui-construction/list-editors?v=22.1) that uses the **Scheduler Control** ([Win](https://docs.devexpress.com/WindowsForms/1971/controls-and-libraries/scheduler?v=22.1)/[Web](https://docs.devexpress.com/AspNet/3685/components/scheduler?v=22.1)) to display and manage **Event** business objects in XAF applications. Refer to the [Add the Scheduler Module](https://docs.devexpress.com/eXpressAppFramework/113040/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/add-the-scheduler-module?v=22.1) lesson to learn how to use it in your application.

You can see the changes made in the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).

# Set a Many-to-Many Relationship (XPO)

>TIP
For **.NET 6** applications, see: [Set a Many-to-Many Relationship (XPO, .NET 6)](https://docs.devexpress.com/eXpressAppFramework/402168/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/set-a-many-to-many-relationship-xpo?v=22.1).

In this lesson, you will learn how to set relationships between business objects. For this purpose, the  **Task**  business class will be implemented and a  _Many-to-Many_  relationship will be set between the  **Contact**  and  **Task**  objects. You will also learn the basics of automatic user interface construction for the referenced objects.

>NOTE
Before proceeding, take a moment to review the [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1) lesson.

-   To add the  **Task**  business class to the application, you can use the  **Task**  class from the Business Class Library. Since you need to set a relationship between the  **Contact**  and  **Task**  objects, you need to customize the  **Task**  class implementation.  [Inherit from this class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)  and add the  **Contacts**  collection property, as shown in the following code.
    

    
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
    
   > IMPORTANT
    Do not modify the **XPCollection** property declaration demonstrated above. Manipulating the collection or introducing any additional settings within the declaration may cause unpredictable behavior.
    
   In this code, the  [AssociationAttribute](https://docs.devexpress.com/XPO/DevExpress.Xpo.AssociationAttribute?v=22.1)  is applied to the  [XPCollection](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPCollection?v=22.1)  type  **Contacts**  property, representing the collection of associated Contacts. The  **Association**  attribute is required when setting a relationship between objects. Note that the  **Contacts**  property getter implementation - the  **GetCollection**  method - is used to return a collection.
    
   >NOTE
   The [ModelDefaultAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.ModelDefaultAttribute?v=22.1) attribute, which is applied to the **DemoTask** class, specifies the “Task” value for the **Caption** property of the Application Model’s **BOModel** | **DemoTask** node. Generally, you can specify any property of the Application Model’s **BOModel** | **_<Class>_** or **BOModel** | **_<Class>_** | **OwnMembers** | **_<Member>_** node, by applying the **ModelDefault** attribute to a business class or its member.
    
-   Modify the  **Contact**  class implementation: add the  **Tasks**  property as the second part of the  **Contact-DemoTask**  relationship. Note that the  **Association**  attribute must be applied to this property as well. The following code demonstrates a code snippet from the  **Contact**  class implementation.

    
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
    
    The code above will automatically generate the required intermediate tables and relationships.
    
   > NOTE   
    [CodeRush](https://www.devexpress.com/products/coderush/) includes a number of Code Templates that help generate business classes or their parts with a few keystrokes. To learn about the Code Templates for **eXpress Persistent Objects**, refer to the following help topic: [XPO and XAF Templates](https://docs.devexpress.com/CodeRushForRoslyn/118557/coding-assistance/code-templates/xpo-templates?v=22.1).
    
-   Run the WinForms or ASP.NET Web Forms application. Invoke the  **Contact Detail View**  or  **Task Detail View**. Add tasks to a  **Contact**  object’s  **Tasks**  collection, or contacts to a  **Task**  object’s  **Contacts**  collection. To apply the assignment, use the  **Link**  button that accompanies these collections.
    
    ![Tutorial_BMD_Lesson5_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson5_1115432.png?v=22.1)
    
    ![Tutorial_BMD_Lesson5_1_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson5_1_0115580.png?v=22.1)
    

You can see the code demonstrated in this lesson in the  _Contact.cs_  (_Contact.vb_) and  _DemoTask.cs_  (_DemoTask.vb_) files of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).

# Set a One-to-Many Relationship (XPO)

>TIP
For **.NET 6** applications, see: [Set a One-to-Many Relationship (XPO, .NET 6)](https://docs.devexpress.com/eXpressAppFramework/402169/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/set-a-one-to-many-relationship-xpo?v=22.1).

In this lesson, you will learn how to set a one-to-many relationship between business objects. The  **Contact**  and  **Department**  business objects will be related by a one-to-many relationship. For this purpose, the  **Contacts**  property will be added to the  **Department**  class representing the “Many” part of the relationship. You will then learn the basics of automatic user interface construction for referenced objects.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implement Custom Business Classes and Reference Properties](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)

-   To implement the “One” part of the Department-Contacts relationship, decorate the  **Contact**  class’  **Department**  property with the  [AssociationAttribute](https://docs.devexpress.com/XPO/DevExpress.Xpo.AssociationAttribute?v=22.1).
    

    
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
    
    For information on the  **Association**  attribute, refer to the  [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)  lesson.
    
-   To implement the “Many” part of the Department-Contacts relationship, add the  **Contacts**  property to the  **Department**  class and decorate this property with the  **Association**  attribute.
    

    
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
    
   > NOTE
    [CodeRush](https://www.devexpress.com/products/coderush/) includes a number of Code Templates that help generate business classes or their parts with a few keystrokes. To learn about the Code Templates for **eXpress Persistent Objects**, refer to the following help topic: [XPO and XAF Templates](https://docs.devexpress.com/CodeRushForRoslyn/118557/coding-assistance/code-templates/xpo-templates?v=22.1).
    
-   Run the WinForms or ASP.NET Web Forms application. Invoke a Detail View for a  **Department**  object (see the previous lesson “[Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)”). You can see the  **Contacts**  group. To add objects to the  **Contacts**  collection, use the  **New**  (![button_new](https://docs.devexpress.com/eXpressAppFramework/images/btn_new117411.png?v=22.1)) or  **Link**  (![link_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_link117412.png?v=22.1)) buttons in this tab. The  **Link**  button allows for the adding of references to existing  **Contact**  objects.
    
    ![Tutorial_BMD_Lesson6_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson6_1115433.png?v=22.1)
    
    To remove a reference to an object from this collection, use the  **Unlink**  (![unlink_img](https://docs.devexpress.com/eXpressAppFramework/images/btn_unlink117413.png?v=22.1)) button.
    

>TIP
If you create a new **Department** and then create a new **Contact** in the **Contacts** collection, the associated **Department** is not immediately visible in the [Detail View](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1) of the newly created **Contact**. The link between these objects is added later when you save the **Contact**. To change this behavior, use the [XafApplication.LinkNewObjectToParentImmediately](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.LinkNewObjectToParentImmediately?v=22.1) property. When the property value is `true`, the application creates a link and saves it immediately after you click **New**.

You can see the code demonstrated in this lesson in the  _MySolution.Module_  |  _Business Objects_  |  _Contact.cs_  (_Contact.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).

# Initialize a Property After Creating an Object (XPO)

>TIP
For **.NET 6** applications, see: [Initialize Business Object Properties (XPO, .NET 6)](https://docs.devexpress.com/eXpressAppFramework/402167/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/initialize-a-property-after-creating-an-object-xpo?v=22.1).

In this lesson, you will learn how to set the default value for a particular property of a business class. For this purpose, the  **Priority**  property will be added to the  **DemoTask**  class created in the  [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)  lesson. To initialize it, the  **AfterConstruction**  method will be overridden in this class.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)

-   Add the  **Priority**  property to the  **DemoTask**  class and declare the  **Priority**  enumeration, as shown below:
    

    
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
    
-   To initialize the newly added  **Priority**  property when a  **DemoTask**  object is created, override the  **AfterConstruction**  method, as shown below:
    

    
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
    
    This method will be executed when the new  **DemoTask**  object is created. As a result, the  **Priority**  property will be initialized with the specified value. For details on the  **AfterConstruction**  method, refer to the  [PersistentBase.AfterConstruction](https://docs.devexpress.com/XPO/DevExpress.Xpo.PersistentBase.AfterConstruction?v=22.1)  Method topic in the XPO documentation.
    
-   Run the WinForms or ASP.NET Web Forms application. Create a new  **DemoTask**  object by selecting  **DemoTask**  in the drop-down list of the  **New**  (![new_dropdown_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_new_dropdown117415.png?v=22.1)) button. (In the Detail View that represents the newly created  **DemoTask**  object, note that the  **Priority**  property is set to  **Normal**, as declared in the code above.) Notice that the enumeration property is automatically displayed by the combo box editor.
    
    ![Tutorial_BMD_Lesson12_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson12_1115626.png?v=22.1)
    

You can see the code demonstrated in this lesson in the  _MySolution.Module_  |  _Business Objects_  |  _DemoTask.cs_  (_DemoTask.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Implement Dependent Reference Properties (XPO)

>TIP
For **.NET 6** applications, see: [Implement Dependent Reference Properties (XPO, .NET 6)](https://docs.devexpress.com/eXpressAppFramework/402164/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/implement-dependent-reference-properties-xpo?v=22.1).

In this lesson, you will learn how to implement properties whose values can depend on other properties. The  **Manager**  property will be added to the  **Contact**  class. By default, it will be represented by a lookup editor containing all  **Contact**s that exist in the database. However, you may need this editor to contain  **Contact**s from the same  **Department**. In addition, you may need the  **Position**  of these  **Contact**s to be “Manager”. To do this, use the  [DataSourcePropertyAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DataSourcePropertyAttribute?v=22.1)  and  [DataSourceCriteriaAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DataSourceCriteriaAttribute?v=22.1)  attributes for the  **Manager**  property.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implement Custom Business Classes and Reference Properties](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Set a One-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112733/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-one-to-many-relationship-xpo?v=22.1)

-   Add a new  **Manager**  property of the  **Contact**  type to the  **Contact**  class. Apply the  **DataSourceProperty**  attribute to this property, as shown below.
    

    
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
    
    With the  **DataSourceProperty**  attribute applied, the  **Manager**  lookup editor will contain  **Contact**  objects that are specified by the  **Department**  object’s  **Contacts**  property.
    
-   Run the application and select  **Contact**  in the drop-down list of the  **New**  combo box. The  **Contact**  Detail View will be invoked. Specify the  **Department**  property and expand the  **Manager**  lookup editor. Make sure that the  **Department**  property of the listed objects is the same as those you specified above.
    
    ![Tutorial_BMD_Lesson7_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson7_1115434.png?v=22.1)
    
-   Apply the  **DataSourceCriteria**  attribute to the  **Contact**  class’  **Manager**  property as shown below.
    

    
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
    
    With the  **DataSourceCriteria**  attribute applied, the  **Manager**  lookup editor will contain  **Contact**  objects that satisfy the criteria specified in the attribute parameter.
    
-   Run the application. Set the  **Position**  property to “Manager” for several  **Contact**  objects.
    
    ![Managers_XAF](https://docs.devexpress.com/eXpressAppFramework/images/managers_xaf117414.png?v=22.1)
    
-   Select  **Contact**  in the  **New**  (![new_dropdown_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_new_dropdown117415.png?v=22.1)) button’s drop-down list. The  **Contact**  Detail View will be invoked. Specify the  **Department**  property and expand the  **Manager**  lookup editor. Check to make sure that the  **Position**  property is set to “Manager” for each of the listed objects.
    
    ![Tutorial_BMD_Lesson7_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson7_2115435.png?v=22.1)
    
-   If the  **Department**  property is not specified for a  **Contact**, you can provide another data source for the  **Manager**  lookup editor. To do this, specify the second parameter for the  **DataSourceProperty**  attribute. In the code below, this parameter is set to the  **DataSourcePropertyIsNullMode.SelectAll**  value. You can also set the  **DataSourcePropertyIsNullMode.SelectNothing**  or  **DataSourcePropertyIsNullMode.CustomCriteria**  values. In the latter case, a third parameter is required to specify a criterion.
    

    
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
    
    The code above will show all contacts in the  **Manager**  lookup editor, if the  **Department**  property is not specified.
    
-   Run the application and check the results.

>NOTE
You can implement the same behavior at design time. For details, refer to the [Filter Lookup Editor Data Source](https://docs.devexpress.com/eXpressAppFramework/112755/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/filter-lookup-editor-data-source?v=22.1) lesson.

You can see the code demonstrated here in the  _MySolution.Module_  |  _Business Objects_  |  _Contact.cs_  (_Contact.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Implement Property Value Validation in Code (XPO)

>TIP
For **.NET 6** applications, see: [Implement Dependent Reference Properties (XPO, .NET 6)](https://docs.devexpress.com/eXpressAppFramework/402165/getting-started/in-depth-tutorial-blazor/business-model-design/business-model-design-with-xpo/implement-property-value-validation-in-code-xpo?v=22.1).

This lesson explains how to set rules for business classes and their properties. These rules are validated when an end-user executes a specified operation. This lesson will guide you through implementation of a rule that requires that the  **Position.Title**  property must not be empty. This rule will be checked when saving a  **Position**  object. You will also be able to see the user interface elements that report a broken rule.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implement Custom Business Classes and Reference Properties](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)

-   The validation functionality is provided by the  [Validation Module](https://docs.devexpress.com/eXpressAppFramework/113684/validation-module?v=22.1). Add this module to your  _MySolution.Module_  project. For this purpose, find the  _Module.cs_  (_Module.vb_) file in the  _MySolution.Module_  project displayed in the  **Solution Explorer**. Double-click this file to invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). In the  **Toolbox**, navigate to the  **DX.22.1: XAF Modules**  section. Drag the  **ValidationModule**  item from this section to the Designer’s  **Required Modules**  panel. Rebuild your solution.
    
    ![Tutorial_BMD_Lesson11_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson11_0119446.png?v=22.1)
    
    In a WinForms application, add the  **ValidationWindowsFormsModule**. This module creates validation error messages that are more informative and user friendly than the default exception messages. Additionally, this module provides in-place validation support (see  [IModelValidationContext.AllowInplaceValidation](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Validation.IModelValidationContext.AllowInplaceValidation?v=22.1)). To add this module, find the  _WinApplication.cs_  (_WinApplication.vb_) file in the  _MySolution.Win_  project displayed in the  **Solution Explorer**, double-click this file to invoke the  [Application Designer](https://docs.devexpress.com/eXpressAppFramework/112827/installation-upgrade-version-history/visual-studio-integration/application-designer?v=22.1)  and drag the  **ValidationWindowsFormsModule**  from the  **Toolbox**  to the  **Required Modules**  panel.
    
    In an ASP.NET Web Forms application, you can also add the  **ValidationAspNetModule**. This module provides in-place validation support (see  [IModelValidationContext.AllowInplaceValidation](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Validation.IModelValidationContext.AllowInplaceValidation?v=22.1)). To add this module, find the  _WebApplication.cs_  (_WebApplication.vb_) file in the  _MySolution.Web_  project displayed in the  **Solution Explorer**, double-click this file to invoke the  **Application Designer**  and drag the  **ValidationAspNetModule**  from the  **Toolbox**  to the  **Required Modules**  panel.
    
-   Apply the  [RuleRequiredFieldAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Validation.RuleRequiredFieldAttribute?v=22.1)  attribute to the  **Position**  class’  **Title**  property. As a parameter, specify the context for checking the rule (e.g., DefaultContexts.Save). The following code demonstrates this attribute.
    

    
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
    
-   The  **RuleRequiredField**  attribute defines a validation rule that ensures that the  **Position.Title**  property has a value when the  **Position**  object is saved.
    
    Run the WinForms or ASP.NET Web Forms application. Click the  **New**  (![button_new](https://docs.devexpress.com/eXpressAppFramework/images/btn_new117411.png?v=22.1)) button to create a new Position. Leave the  **Title**  property empty and click the  **Save**  button. The following error message will be displayed, depending on the application type.
    
    **WinForms Application**
    
    ![Tutorial_BMD_Lesson11_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson11_1115452.png?v=22.1)
    
    **ASP.NET Web Forms Application**
    
    ![Tutorial_BMD_Lesson11_2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson11_2_1116071.png?v=22.1)
    
    This warning message will also be invoked if you click the  **Save and Close**  button, or perform another action that saves the object to the database.
    
    >NOTE
    You can use the **Validate** toolbar button to check to see if there are broken rules without saving the current object.
    
-   In the WinForms application, close the window with the warning message, set a value for the  **Title**  property and click the  **Save**  button. In the ASP.NET Web Forms application, set a value for the  **Title**  property and click the  **Save**  button. The object will be saved successfully.

>NOTE
The Validation System provides a number of Rules and Contexts. For details, refer to the [Validation Rules](https://docs.devexpress.com/eXpressAppFramework/113008/validation/validation-rules?v=22.1) topic. Information on Rules applied in code is loaded into the Application Model (see the [Implement Property Value Validation in the Application Model](https://docs.devexpress.com/eXpressAppFramework/112750/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/implement-property-value-validation-in-the-application-model?v=22.1) topic). This allows a business application administrator to add and edit Rules and Contexts via the [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1).

You can see the code demonstrated here in the  _MySolution.Module_  |  _Business Objects_  |  _Contact.cs_  (_Contact.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Extend Functionality

In this tutorial section, you will learn how to add custom features to your application. For this purpose, you should familiarize yourself with the following basic concepts of the  **eXpressApp Framework**.

-   **Action**
    
    Visually, Action is a toolbar item or another control that performs the associated code when an end-user manipulates it. XAF provides several predefined Action types. You can choose the appropriate type, depending on how you want your Action to be represented within the UI. Regardless of the chosen type, all Actions expose the  **Execute**  event, whose handler is executed when end-users manipulate the corresponding element. For more details, refer to the  [Actions](https://docs.devexpress.com/eXpressAppFramework/112622/ui-construction/controllers-and-actions/actions?v=22.1)  topic.
    
-   **Controller**
    
    Controllers are classes inherited from the  [Controller](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Controller?v=22.1)‘s descendants:  [ViewController](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController?v=22.1)  (including its generic versions:  [ViewController<ViewType>](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController-1?v=22.1)  and  [ObjectViewController<ViewType, ObjectType>](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ObjectViewController-2?v=22.1)) or  [WindowController](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.WindowController?v=22.1). They are used to  [implement business logic](https://docs.devexpress.com/eXpressAppFramework/113711/data-manipulation-and-business-logic/create-read-update-and-delete-data?v=22.1)  in your application. This logic can be executed either automatically (e.g, when a View is activated) or triggered when an Action declared within the Controller is executed by a user. Controllers implemented within modules are collected automatically by XAF using  [reflection](https://docs.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/reflection). That is why Controller classes should be  _public_. When a Window is created, required Controllers are activated. This results in activating (making visible) their Actions. For more details, refer to the  [Controllers](https://docs.devexpress.com/eXpressAppFramework/112621/ui-construction/controllers-and-actions/controllers?v=22.1)  topic.
    

Controllers and Actions are instruments that provide custom features in an XAF application. In this tutorial section, you will learn how to add Actions of different types, implement Controllers without Actions, and modify the behavior of existing Controllers and Actions, etc. It is recommended that you complete the lessons listed below, in order.

-   [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)
-   [Add a Parametrized Action](https://docs.devexpress.com/eXpressAppFramework/112724/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-parametrized-action?v=22.1)
-   [Add an Action that Displays a Pop-up Window](https://docs.devexpress.com/eXpressAppFramework/112723/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-that-displays-a-pop-up-window?v=22.1)
-   [Add an Action with Option Selection](https://docs.devexpress.com/eXpressAppFramework/112738/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-with-option-selection?v=22.1)
-   [Add a Simple Action using an Attribute](https://docs.devexpress.com/eXpressAppFramework/112731/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action-using-an-attribute?v=22.1)
-   [Access Editor Settings](https://docs.devexpress.com/eXpressAppFramework/112729/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-editor-settings?v=22.1)
-   [Access Grid Control Properties](https://docs.devexpress.com/eXpressAppFramework/113165/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-grid-control-properties?v=22.1)


# Add a Simple Action (.NET Framework)

>TIP
For **.NET 6** applications, see: [Add a Simple Action (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402157/getting-started/in-depth-tutorial-blazor/extend-functionality/add-a-simple-action?v=22.1).

In this lesson, you will learn how to create a Simple Action. For this purpose, a new View Controller will be implemented and a new Simple Action will be added to it. This Action will clear all  **Tracked Tasks**  of a specific  **Contact**.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implement Custom Business Classes and Reference Properties](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)

The View Controller is a descendant of the  [ViewController](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController?v=22.1)  class. To add a View Controller that provides a Simple Action, follow the steps described below.

1.  The  **XAF Controllers** | **View Controller**  Visual Studio template makes it easier to add a View Controller to your application. In the  **Solution Explorer**, right-click the  _Controllers_  folder in the  _MySolution.Module_  project, and choose  **Add DevExpress Item**  |  **New Item…**  to invoke  [Template Gallery](https://docs.devexpress.com/eXpressAppFramework/113455/installation-upgrade-version-history/visual-studio-integration/template-gallery?v=22.1). Then select  **View Controller**, specify  _ClearContactTasksController_  as the new item’s name and click  **Add Item**. As a result, you will get an automatically generated  _ClearContactTasksController.cs_  (_ClearContactTasksController.vb_) file with a single View Controller declaration.
    
    ![Tutorial_EF_Lesson1_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson1_1115454.png?v=22.1)
    
2.  The new Controller will be activated within any type of View by default. Because the task of this lesson is to clear  **Tracked Tasks**  in the  **Contact**  Detail View, the default behavior should be changed. Right-click the  _MySolution.Module_  |  _Controllers_  |  _ClearContactTasksController.cs_  (_ClearContactTasksController.vb_) file, and choose  **View Designer**  to invoke the Designer.
    
    ![Controller_Designer](https://docs.devexpress.com/eXpressAppFramework/images/controller_designer117404.png?v=22.1)
    
3.  In the  **Properties**  window for the Controller, set the  **TargetViewType**  property to  **DetailView**  and the  **TargetObjectType**  property to  **MySolution.Module.BusinessObjects.Contact**. As a result, the controller will only be activated in  **Contact**  detail forms.
    
    ![Tutorial_EF_Lesson1_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson1_2115455.png?v=22.1)
    
    >NOTE
    The same customization can be done in code, by setting the [ViewController.TargetViewType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewType?v=22.1) property to [ViewType.DetailView](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewType?v=22.1) and [ViewController.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType?v=22.1) property to **MySolution.Module.BusinessObjects.Contact** in the Controller’s constructor. If the property value is set after invoking the **InitializeComponent** method, the Designer setting will be overridden.
    
    Alternatively, you can implement the generic [ObjectViewController<ViewType, ObjectType>](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ObjectViewController-2?v=22.1) Controller instead of the [ViewController](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController?v=22.1) and specify the View’s and object’s type, for which this Controller should be activated, in the generic parameters.
    
4.  Next, add  **SimpleAction**  to the  **ClearContactTasksController**. In the  **DX.22.1: XAF Actions**  section in the  **Toolbox**, drag  **SimpleAction**  to the Designer.
    
    ![Tutorial_EF_Lesson1_2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson1_2_1116402.png?v=22.1)
    
5.  In the Properties window for  **SimpleAction**, set the  **Name**  and  **ID**  properties to “ClearTasksAction”, the  **Category**  property to “View”, the  **ImageName**  property to “Action_Clear” and the  **Caption**  property to “Clear Tasks”. Set the  **ConfirmationMessage**  property to “Are you sure you want to clear the Tasks list?”.
    
    ![Tutorial_EF_Lesson1_1_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson1_1_0115627.png?v=22.1)
    
    >NOTE
    The **Category** property specifies the Action group to which the current Action belongs. All Actions within one group are displayed sequentially in a UI.
    
    The **ImageName** property specifies the icon of the Action’s button in the interface. You can [use one of the standard images](https://docs.devexpress.com/eXpressAppFramework/112745/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-standard-image?v=22.1) or [import your own](https://docs.devexpress.com/eXpressAppFramework/112744/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-custom-image?v=22.1)
    
6.  A  **SimpleAction**  is designed to execute specific code when an end-user clicks it. To clear the  **Tasks**  collection of the current  **Person**  and refresh the view, implement the action’s  **Execute**  event handler. Switch to the  **Events**  view in the  **Properties**  window, double-click the  **Execute**  event and add the following code to the auto-generated event handler.
    

    
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
    
7.  In ASP.NET Web Forms applications, there are two modes for displaying Detail Views - View mode and Edit mode. The  **ClearTasks**  Action should only be available when a Detail View is displayed in Edit mode, so check to see if the edit mode for the current Detail View has changed. If it has changed to View mode, the Action should be disabled. To implement this, you should review the following concepts.
    
    -   The Detail View exposes the  [DetailView.ViewEditModeChanged](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.DetailView.ViewEditModeChanged?v=22.1)  event, which is fired when the edit mode is changed.
    -   The Action exposes the  [ActionBase.Enabled](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.Enabled?v=22.1)  property, which is not a simple Boolean property, but a key/value pair collection used to determine the Action’s enabled state. This kind of collection is used because there can be many factors that influence the Action’s state, and an XAF application should take them all into account.
    
    Thus, handle the  **ViewEditModeChanged**  event and modify the Action’s  **Enabled**  collection based on the current edit mode. To do this, return to the Controller’s Designer and double-click the  **Activated**  event in the Events view of the Properties window. Replace the automatically generated event handler with the following code.
    

    
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
    

To see the result, run the WinForms or ASP.NET Web Forms application and do the following.

1.  Open a detail form for any object.
2.  Click the  **Clear Tasks**  button, which represents the Action you have implemented. A confirmation message will appear as shown in the image below.
    
    ![Tutorial_EF_Lesson1_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson1_3115456.png?v=22.1)
    
3.  Click  **Yes**  (in a WinForms application) or  **OK**  (in an ASP.NET Web Forms application). All  **Tracked Tasks**  of the  **Contact**  will be emptied.
    
    ![Tutorial_EF_Lesson1_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson1_4117500.png?v=22.1)
    

>NOTE
Although this topic explains how to create a controller using the Designer, a controller is a class that can also be written manually, as shown in the [Add a Controller in Code](https://docs.devexpress.com/eXpressAppFramework/112621/ui-construction/controllers-and-actions/controllers?v=22.1#add-a-controller-in-code) topic.

­

If you need to place an action inside the Detail View, refer to the [How to: Include an Action to a Detail View Layout](https://docs.devexpress.com/eXpressAppFramework/112816/ui-construction/view-items-and-property-editors/include-an-action-to-a-detail-view-layout?v=22.1) topic.

You can view the code used in this lesson in the  _MySolution.Module_  |  _Controllers_  |  _ClearContactTasksController.cs_  (_ClearContactTasksController.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Add a Parametrized Action (.NET Framework)

>TIP
For **.NET 6** applications, see: [Add a Parametrized Action (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402155/getting-started/in-depth-tutorial-blazor/extend-functionality/add-a-parametrized-action?v=22.1).

In this lesson, you will learn how to add a Parametrized Action. These types of Actions are slightly more complex than the Simple Actions you learned about in the previous lesson. The Parametrized Action provides an editor, so that an end-user can input a value before execution. In this lesson, a new View Controller will be implemented and a new Parametrized Action will be added to it. This Action will search for a  **DemoTask**  object by its  **Subject**  property value, and display the found object on a detail form.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Initialize a Property After Creating an Object](https://docs.devexpress.com/eXpressAppFramework/112834/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/initialize-a-property-after-creating-an-object-xpo?v=22.1)
>-   [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)

-   Add a new View Controller to the  _MySolution.Module_  project, as described in the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  lesson. Name it  _FindBySubjectController_.
-   Right-click the newly created  _MySolution.Module_  |  _Controllers_  |  _FindBySubjectController.cs_  (_FindBySubjectController.vb_) file, and choose  **View Designer**  to invoke the Designer. Drag  **ParametrizedAction**  from the  **DX.22.1: XAF Actions**  Toolbox tab to the Designer. In the  **ParametrizedAction**  Properties window, set the  **Name**  and  **ID**  properties to “FindBySubjectAction”, and set the  **Caption**  property to “Find Task by Subject”.
    
    ![Tutorial_EF_Lesson3_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson3_2115459.png?v=22.1)
    
-   To activate the  **FindBySubjectController**  with its  **FindBySubjectAction**  for  **DemoTask**  List Views only, set the  [ViewController.TargetViewType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewType?v=22.1)  property to “ListView”, and set  [ViewController.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType?v=22.1)  to  **MySolution.Module.DemoTask**  via the Controller’s Properties window. To activate the Controller for root Views only, set the  [ViewController.TargetViewNesting](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewNesting?v=22.1)  property to  **Root**.
    
    ![Tutorial_EF_Lesson3_2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson3_2_1116405.png?v=22.1)
    
-   Next, you need to handle the Action’s  [ParametrizedAction.Execute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ParametrizedAction.Execute?v=22.1)  event to implement the search functionality. Focus the  **FindBySubject**  Action in the Controller’s Designer. Switch to the Events view in the  **Properties**  window. Double-click the  **Execute**  event, replace the auto-generated event handler code with the following.
    

    
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
    
    The  **Execute**  event is raised after a parameter has been typed in the Action’s editor. The handler above looks for the  **DemoTask**  object, whose subject contains the text specified as a parameter, and invokes the detail form for this object.
    
   > NOTE   
>    -   To search for an object, you will need an [Object Space](https://docs.devexpress.com/eXpressAppFramework/113707/data-manipulation-and-business-logic/object-space?v=22.1). The Object Space is always used when manipulating persistent objects. To use the Object Space in this task, create it using the [XafApplication.CreateObjectSpace](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.CreateObjectSpace.overloads?v=22.1) method. Since an application is accessible nearly everywhere in code, its **CreateObjectSpace** method is always helpful.
>    -   To use the [IObjectSpace.FindObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.IObjectSpace.FindObject.overloads?v=22.1) method, pass the type of the searched object, along with its criteria. To get the type of the objects represented in the current List View, use the View’s object type info (see [View.ObjectTypeInfo](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.View.ObjectTypeInfo?v=22.1)). To generate a criterion, create a BinaryOperator object by passing criteria components as the constructor’s parameters. For additional information, refer to the [Querying a Data Store](https://docs.devexpress.com/XPO/2034/query-and-shape-data?v=22.1) section in the XPO documentation.
>    -   To get the value entered by an end-user in the editor that represents the FindBySubjectAction, use the event handler’s [ParametrizedActionExecuteEventArgs.ParameterCurrentValue](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventArgs.ParameterCurrentValue?v=22.1) parameter.
>    -   To show the found object in a separate Detail View, create the View via the [XafApplication.CreateDetailView](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.CreateDetailView.overloads?v=22.1) method and assign it to the [ShowViewParameters.CreatedView](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ShowViewParameters.CreatedView?v=22.1) property of the event handler’s [ActionBaseEventArgs.ShowViewParameters](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBaseEventArgs.ShowViewParameters?v=22.1) parameter. Show View Parameters can be initialized in the **Execute** event handler of an Action of any type, so you can always show a View after Action execution. For additional information on how to show a View in a separate window, refer to the [Ways to Show a View](https://docs.devexpress.com/eXpressAppFramework/112803/ui-construction/views/ways-to-show-a-view/ways-to-show-a-view?v=22.1) topic.
    -   As you may have already noticed, the [XafApplication](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication?v=22.1) object is useful when you need to create a List View, Detail View, Object Space, etc. The **XAFApplication** object is accessible from many locations in an XAF application. In Controllers, it can be accessed via the [Controller.Application](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Controller.Application?v=22.1) property.
    
-   Run the WinForms or ASP.NET Web Forms application. Select the  **Task**  item in the navigation control. Find the  **Find Task by Subject**  editor that represents the Action you have implemented. Type a word from an existing DemoTask object’s  **Subject**  property into this editor. Press the  **Enter**  key or click  **Find Task by Subject**. A detail form with this object will be displayed.
    
    ![Tutorial_EF_Lesson3_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson3_3115460.png?v=22.1)
    

You can see the code demonstrated here in the  _MySolution.Module_  |  _Controllers_  |  _FindBySubjectController.cs_  (_FindBySubjectController.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Add an Action that Displays a Pop-up Window (.NET Framework)

>TIP
For **.NET 6** applications, see: [Add an Action that Displays a Pop-Up Window (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402158/getting-started/in-depth-tutorial-blazor/extend-functionality/add-an-action-that-displays-a-pop-up-window?v=22.1).

In this lesson, you will learn how to create an Action that shows a pop-up window. This type of Action is useful when you want a user to input several parameters in a pop-up dialog before an Action is executed.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)
>-   [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)

## Create a Controller and a PopupWindowShowAction

-   Add a new View Controller to the  **MySolution.Module**  project, as described in the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  lesson. Name it  _PopupNotesController_.
-   Right-click the  _MySolution.Module_  |  _Controllers_  |  _PopupNotesController.cs_  (_PopupNotesController.vb_) file, and choose  **View Designer**  to invoke the Designer.
    
    ![popup_notes_designer](https://docs.devexpress.com/eXpressAppFramework/images/popup_notes_designer117416.png?v=22.1)
    
-   Drag the  **PopupWindowShowAction**  component from the  **DX.22.1: XAF Actions**  tab to the Designer. In the  **popupWindowShowAction1**  “Properties” window, set the  **Name**  and  **Id**  properties to “ShowNotesAction”, and set the  **Caption**  property to “Show Notes”. Set the  **Category**  property to “Edit”. This property specifies the Action group to which the current Action belongs. All Actions within a single group are displayed together sequentially in a UI.
    
    ![Tutorial_EF_Lesson4_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson4_2115462.png?v=22.1)
    
-   To activate the  **PopupNotesController**  for  **DemoTask**  Detail Views only, set the Controller’s  [ViewController.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType?v=22.1)  property to  **MySolution.Module.DemoTask**, and set the  [ViewController.TargetViewType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetViewType?v=22.1)  to  **DetailView**.
    
    ![Tutorial_EF_Lesson4_2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson4_2_1116884.png?v=22.1)
    

## Specify the Popup List View

Focus the  **ShowNotesAction**  component. In the Properties window, switch to the  _Events_  view. Double-click the  **CustomizePopupWindowParams**  event, add the “**using**“ (“**Imports**“ in VB) directive according to your ORM, and replace the auto-generated event handler code with the following code.



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

For details on this event, refer to the  [PopupWindowShowAction.CustomizePopupWindowParams](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.PopupWindowShowAction.CustomizePopupWindowParams?v=22.1)  topic. The code above will create the  **Notes**  List View when generating the pop-up window.

To create a List View, use the  [XafApplication](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication?v=22.1)  object again (as you did in the  [previous](https://docs.devexpress.com/eXpressAppFramework/112724/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-parametrized-action?v=22.1)  lesson). In the code above, the XafApplication helps you find the ID of the required List View in the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112579/ui-construction/application-model-ui-settings-storage?v=22.1). Note that a collection source for the List View is created in a separate  [Object Space](https://docs.devexpress.com/eXpressAppFramework/113707/data-manipulation-and-business-logic/object-space?v=22.1). To create the Object Space, use XafApplication again.

## Handle the Execute Event

In the Controller’s Designer, switch to the  _Events_  view in the  **Properties**  window with the Action’s properties. Double-click the  **Execute**  event, add the “**using**“ (“**Imports**“ in VB) directive and replace the auto-generated event handler code with the following code.



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

The  **Execute**  event is raised when clicking the  **OK**  button in the pop-up window. When the handler above is executed, the  **Text**  property value of the selected  **Note**  object will be appended to the  **Task.Description**  property value.

In this code, access the object selected in the pop-up window by using the event handler’s  [PopupWindowShowActionExecuteEventArgs.PopupWindowViewSelectedObjects](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventArgs.PopupWindowViewSelectedObjects?v=22.1)  parameter.

To refresh the editor representing the modified  **Description**  property, first find its  **PropertyEditor**  in the current View’s  [CompositeView.Items](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.CompositeView.Items?v=22.1)  collection using the  [CompositeView.FindItem](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.CompositeView.FindItem(System.String)?v=22.1)  method. To update the value displayed by the Property Editor’s editor, call the  [PropertyEditor.ReadValue](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.PropertyEditor.ReadValue?v=22.1)  method.

In ASP.NET Web Forms applications, Detail Views are displayed in  **View**  and  **Edit**  modes. When the  **ShowNotes**  Action is activated for a DemoTask Detail View that is in  **View**  mode, the changes made to the  **DemoTask.Description**  property should be saved to the database. For this purpose, the  **CommitChanges**  method of the current View’s  **ObjectSpace**  is called. When you use the  **ShowNotes**  Action in a DemoTask Detail View that is in  **Edit**  mode, the changes can be saved or rolled back via the corresponding built-in Actions.

## Add Notes to the UI

-   To add the  **Note**  business class to the UI construction process, add it to the Application Model.
-   To add the  **Note**  business class from the  [Business Class Library](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1)  use the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). Double-click the  _Module.cs_  (_Module.vb_) file within the  _MySolution.Module_  project. The  **Exported Types**  section of the designer lists the business classes that can be added. Locate the  **Referenced Assemblies**  |  **DevExpress.Persistent.BaseImpl.Xpo.v22.1**  |  **Note**  node. Select this node and press the  **SPACEBAR**, or right-click it and choose  **Use Type in Application**  in the invoked context menu.
    
    ![Tutorial_EF_Lesson4_4_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson4_4_1116406.png?v=22.1)
    
-   **Build**  the project.
    
    ![Rebuilding_Solution](https://docs.devexpress.com/eXpressAppFramework/images/rebuilding_solution117405.png?v=22.1)
    
   >NOTE
    To create **Note** objects, you should add the **Note** item to the **New** Action’s items. To do this, perform the steps demonstrated in the [Add an Item to the New Action](https://docs.devexpress.com/eXpressAppFramework/112751/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-new-action?v=22.1) lesson.
    
   To access the existing **Note** objects, add the **Note** item to the **ShowNavigationItem** Action’s items (displayed by the navigation control). To do this, perform the steps demonstrated in the [Add an Item to the Navigation Control](https://docs.devexpress.com/eXpressAppFramework/112749/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-navigation-control?v=22.1) lesson.
    

## Result

Run the WinForms or ASP.NET Web Forms application. Create several  **Note**  objects via the  **New**  Action. Select the  **Task**  item in the navigation control. Double-click one of the listed  **Task**  objects. In the invoked detail form, find the  **Show Notes**  toolbar button that represents the implemented Action. Click this button, which will invoke a pop-up window. Select a  **Note**  object in the list and click  **OK**. Check to see that the  **Task.Description**  property value has been changed.

![Tutorial_EF_Lesson4_5](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson4_5115465.png?v=22.1)

>TIP
For an example of how to create and show a Detail View, refer to the [How to: Create and Show a Detail View of the Selected Object in a Popup Window](https://docs.devexpress.com/eXpressAppFramework/118760/ui-construction/ways-to-access-ui-elements-and-their-controls/how-to-create-and-show-a-detail-view-of-the-selected-object-in-a-popup-window?v=22.1) topic.

You can view the code demonstrated in this tutorial in the  _MySolution.Module_  |  _Controllers_  |  _PopupNotesController.cs_  (_PopupNotesController.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Add an Action with Option Selection (.NET Framework)

>TIP
For **.NET 6** applications, see: [Add an Action with Option Selection (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402159/getting-started/in-depth-tutorial-blazor/extend-functionality/add-an-action-with-option-selection?v=22.1).

In this lesson, you will learn how to create an Action with support for option selection. A new View Controller will be implemented and a  **SingleChoiceAction**  will be added to it. Via this Action, the  **Task.Priority**  and  **Task.Status**  properties will be set to the value selected by an end-user.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)
>-   [Add an Action that Displays a Pop-up Window](https://docs.devexpress.com/eXpressAppFramework/112723/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-that-displays-a-pop-up-window?v=22.1)

-   Add a new View Controller to the  _MySolution.Module_  project, as described in the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  lesson. Name it  _TaskActionsController_.
-   Right-click the  _MySolution.Module_  |  _Controllers_  |  _TaskActionsController.cs_  (_TaskActionsController.vb_) file and choose  **View Designer**  to invoke the Designer. Within the  **DX.22.1: XAF Actions**  Toolbox tab, navigate to  **SingleChoiceAction**  and drag it to the Designer. In the  **SingleChoiceAction**‘s  **Properties**  window, set the  **Name**  and  **ID**  properties to “SetTaskAction”, the  **Caption**  property to “Set Task” and the  **Category**  property to “Edit”. Set the  **ItemType**  property to “ItemIsOperation”.
    
    ![Tutorial_EF_Lesson5_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson5_2115467.png?v=22.1)
    
   >NOTE    
>    -   The [ActionBase.Category](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.Category?v=22.1) property specifies the Action group to which the current Action belongs. All Actions within a single group are displayed together in a UI.
>    -   The [SingleChoiceAction.ItemType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.SingleChoiceAction.ItemType?v=22.1) property specifies a display mode for the Action’s items. With the “ItemIsOperation” value set to this property, the Action’s items will not be displayed by check box items, as they would be if you set the “ItemIsMode” value.
    
-   To activate the  **TaskActionsController**  for  **DemoTask**  objects only, set the Controller’s  [ViewController.TargetObjectType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ViewController.TargetObjectType?v=22.1)  property to  **MySolution.Module.BusinessObjects.DemoTask**.
    
    ![Tutorial_EF_Lesson5_2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson5_2_1116883.png?v=22.1)
    
-   To populate the Action with items, fill the Action’s  [ChoiceActionBase.Items](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ChoiceActionBase.Items?v=22.1)  collection in the Controller’s constructor.
    

    
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
    
    The code above organizes items from the Action’s Items collection as a tree. The first level is formed from the items whose captions correspond to the  **DemoTask.Priority**  and  **DemoTask.Status**  property names. The second level is formed from the  **Priority**  and  **Status**  enumeration values. The first-level item captions are returned by the  [CaptionHelper](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Utils.CaptionHelper?v=22.1)  object; and the second-level item captions are returned by an  [EnumDescriptor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Utils.EnumDescriptor?v=22.1)  object. This is useful when the  **Priority**  and  **Status**  properties and corresponding enumeration values are localized via the Application Model.
    
    >NOTE
        If you create an Action’s Items in the controller’s constructor, they will be created once for each Window. This may be advantageous, for example, if the window’s View is often changed (e.g., if this is the main window and the Multiple Document Interface (MDI) mode is not turned on). Alternatively, you can add Items in the overridden **OnActivated** method. In this instance, Items will not be created until the required View is shown, but will be created each time this View is displayed.
    
    The code snippet below sets the images associated with the  **Priority**  and  **TaskStatus**  enumeration values for the  **SetTask Action**‘s items. Note that the  **TaskStatus**  enumeration is declared in the Business Class Library, and already has images assigned to its values. To assign images to the  **Priority**  enumeration values you declared in the  _DemoTask.cs_  (_DemoTask.vb_) file, decorate them with the  [ImageNameAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ImageNameAttribute?v=22.1)  attribute.
    

    
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
    
>    NOTE
    **The State_Priority_Low**, **State_Priority_Normal** and **State_Priority_High** images are included in the standard image library supplied with XAF. To learn how to use custom images, see the [Assign a Custom Image](https://docs.devexpress.com/eXpressAppFramework/112744/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-custom-image?v=22.1) lesson.
    
   When you populate the [ChoiceActionBase.Items](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ChoiceActionBase.Items?v=22.1) collection in a Controller’s constructor as shown in the code above, you can set an image name, shortcut and a localized caption for the added items using the [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112830/installation-upgrade-version-history/visual-studio-integration/model-editor?v=22.1)‘s **ActionDesign** | **Actions** | **_<Action>_** | **ChoiceActionItems** node. To learn how to invoke and use the Model Editor, refer to the [first lesson in the UI Customization section](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1). However, you may have to populate the **Items** collection in a Controller’s [Controller.Activated](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Controller.Activated?v=22.1) event handler, where you can access the current Application, View, etc. In this instance, the items added to the collection will not be loaded into the Model Editor.
    
-   To implement the code that must be executed when an end-user chooses the Action’s item, handle the  [SingleChoiceAction.Execute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.SingleChoiceAction.Execute?v=22.1)  event as shown below.
    

    
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
    
    As you can see in the code above, the item currently selected in the drop-down list of the  **SetTaskAction**  is accessed via the event handler’s  [SingleChoiceActionExecuteEventArgs.SelectedChoiceActionItem](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventArgs.SelectedChoiceActionItem?v=22.1)  parameter. To assign a chosen value to a property of an object selected in the current View, you can use an  [Object Space](https://docs.devexpress.com/eXpressAppFramework/113707/data-manipulation-and-business-logic/object-space?v=22.1). When the  **SetTaskAction**  is used in a Detail View, the View’s  **Object Space**  is used to manipulate the current object. When the Action is used in a List View, a new  **ObjectSpace**  is created via the  [XafApplication.CreateObjectSpace](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.XafApplication.CreateObjectSpace.overloads?v=22.1)  method. This  **ObjectSpace**  helps manipulate the View’s selected objects.
    
    >NOTE
    Create a separate **Object Space** when you are going to modify multiple objects that are currently displayed. This approach improves performance, as the grid control’s events do not trigger on each object change. In the code above, a new **Object Space** is created when the current View is the List View.
    
    In ASP.NET Web Forms applications, Detail Views are displayed in View and Edit modes. When  **SetTaskAction**  is activated for a  **DemoTask**  Detail View in View mode, the changes made to the  **DemoTask.Priority**  property should be saved to the database. For this purpose, the  [BaseObjectSpace.CommitChanges](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.BaseObjectSpace.CommitChanges?v=22.1)  method of the current View’s  [View.ObjectSpace](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.View.ObjectSpace?v=22.1)  is called. The same technique is used when the  **SetTaskAction**  is activated for a  **DemoTask**  List View. However, when you use the  **SetTaskAction**  in a  **DemoTask**  Detail View in Edit mode, the changes can be saved or rolled back via corresponding built-in Actions.
    
-   The  **Priority**  or  **Status**  property will be changed for the currently selected objects. However, the grid editor used in ASP.NET Web Forms applications does not have selected objects until an end-user selects an object manually. So, disable the Action when no objects are selected. To do this, set the Action’s  [ActionBase.SelectionDependencyType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.SelectionDependencyType?v=22.1)  property to  **RequireMultipleObjects**. The Action will be available only when one or more objects are selected. To specify this property, use the  **Properties**  window.
-   Run the Windows Forms or ASP.NET Web Forms application. Select the  **Task**  item in the navigation control. The  **Set Task**  Action will be displayed. Select one or more  **Task**  objects in the Task List View and select an item in the Action’s drop-down list. The  **Priority**  or  **Status**  property of the selected Task objects will be modified.
    
    ![Tutorial_EF_Lesson5_3_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson5_3_0116189.png?v=22.1)
    
    ![Tutorial_EF_Lesson5_3_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson5_3_2117410.png?v=22.1)
    

You can see the code demonstrated here in the  _MySolution.Module_  |  _Controllers_  |  _TaskActionsController.cs_  (_TaskActionsController.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Add a Simple Action using an Attribute


In the previous  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  lesson, you learned how to add an Action by implementing the View Controller. There is another approach that may be more convenient when the Action is intended for a certain business class. In this lesson, you will learn how to add a Simple Action using an attribute. For this purpose, a new method will be added to the  **DemoTask**  class, and the  [ActionAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ActionAttribute?v=22.1)  attribute will be applied to it.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)
>-   [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)

-   Add the  **Postpone**  method to the  **DemoTask**  class as shown below.
    

    
    ```csharp
    [DefaultClassOptions]
    [ModelDefault("Caption", "Task")]
    public class DemoTask : Task {
        //...
        [Action(ToolTip = "Postpone the task to the next day")]
        public void Postpone() {
            if(DueDate == DateTime.MinValue) {
                DueDate = DateTime.Now;
            }
            DueDate = DueDate + TimeSpan.FromDays(1);
        }
    }
    
    ```
    
    The  **Postpone**  method sets the  **Task.DueDate**  property to the next date, after the date previously specified. Since the  [ActionAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ActionAttribute?v=22.1)  attribute is used, the  **Postpone**  button will be displayed in the UI, and the  **Postpone**  method will be called when clicking this button.
    
-   Run the WinForms or ASP.NET Web Forms application. Select the  **Task**  item in the navigation control. Show the  **Due Date**  column using the  **Column Chooser**. To activate the  **Column Chooser**, right-click the Task List View header. The  **Column Chooser**  allows end users to show or hide columns at runtime, by dragging a column header to or from the table header.
    
    ![Tutorial_EF_Lesson2_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson2_3116404.png?v=22.1)
    
    Select one or more Task objects in the Task List View. Find the  **Postpone**  toolbar button, which represents the  **Postpone**  Action that you have implemented above. Click this button. The  **DueDate**  property of the selected objects displayed in the  **Due Date**  column will be modified.
    
    ![Tutorial_EF_Lesson2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson2_1115457.png?v=22.1)
    
    ![Tutorial_EF_Lesson2_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson2_2116403.png?v=22.1)
    

>TIP
When the browser window shrinks, some Actions become hidden and can be accessed using the “…” button (see [IModelActionWeb.AdaptivePriority](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.SystemModule.IModelActionWeb.AdaptivePriority?v=22.1)).

>NOTE
You can also use the **Action** attribute to implement an action that asks an end user to specify parameters in a popup dialog (e.g., the number of days to postpone a **Task** ). Refer to the [How to: Create an Action Using the Action Attribute](https://docs.devexpress.com/eXpressAppFramework/112619/ui-construction/controllers-and-actions/actions/how-to-create-an-action-using-the-action-attribute?v=22.1) topic to see an example.

You can see the code demonstrated here in the  _MySolution.Module_  |  _Business Objects_  |  _DemoTask.cs_  (_DemoTask.vb_) file of the Main Demo installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Access Editor Settings

This topic demonstrates how to access editors in a  [Detail View](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1)  using a View Controller. This Controller searches the  **Contact**  Detail View for a  **Birthday**  Property Editor that binds data to a control, and specifies that the control should display touch-UI calendar in its drop down.

>NOTE
We recommend reviewing the following topics before proceeding:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)

## Access Editor Settings in a WinForms Application

-   Add a View Controller called “WinDateEditCalendarController” to the  _MySolution.Module.Win_  project as described in the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  lesson (steps 1-3). Switch to code view. Derive the new controller from the  [ObjectViewController<ViewType, ObjectType>](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ObjectViewController-2?v=22.1):
    

    
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
    
-   Override the  **OnActivated**  method. Use the  [DetailViewExtensions.CustomizeViewItemControl(DetailView, Controller, Action<ViewItem>, String[])](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.DetailViewExtensions.CustomizeViewItemControl(DetailView--Controller--Action-ViewItem---String--)?v=22.1)  method to customize the  **Birthday**  [View Item](https://docs.devexpress.com/eXpressAppFramework/112612/ui-construction/view-items-and-property-editors?v=22.1)‘s control.
    

The following code demonstrates the  **WinDateEditCalendarController**:



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

Run the WinForms application and open the  **Contact**  Detail View. The  **Birthday**  editor shows a touch-UI calendar drop down.

![Tutorial_EF_Lesson8_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson8_1115471.png?v=22.1)

>TIP
This approach is not applicable to List View’s [in-place editors](https://docs.devexpress.com/eXpressAppFramework/113249/ui-construction/views/list-view-edit-modes?v=22.1). To customize these editors, do one of the following:
>-   Use a custom property editor as shown in the [How to: Customize a Built-in Property Editor (WinForms)](https://docs.devexpress.com/eXpressAppFramework/113104/ui-construction/view-items-and-property-editors/property-editors/customize-a-built-in-property-editor-winforms?v=22.1) topic.
>-   Access the List Editor control’s events and properties as described in the [Access Grid Control Properties](https://docs.devexpress.com/eXpressAppFramework/113165/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-grid-control-properties?v=22.1) article.

## Access Editor Settings in an ASP.NET Web Forms Application

-   Add a View Controller called “_WebDateEditCalendarController_“ to the  _MySolution.Module.Web_  project as described in the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  topic (steps 1-3). Switch to code view. Derive the new controller from the  [ObjectViewController<ViewType, ObjectType>](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ObjectViewController-2?v=22.1):
    

    
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
    
-   Override the  **OnActivated**  method. Use the  [DetailViewExtensions.CustomizeViewItemControl(DetailView, Controller, Action<ViewItem>, String[])](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.DetailViewExtensions.CustomizeViewItemControl(DetailView--Controller--Action-ViewItem---String--)?v=22.1)  method to customize the  **Birthday**  [View Item](https://docs.devexpress.com/eXpressAppFramework/112612/ui-construction/view-items-and-property-editors?v=22.1)‘s control.

The following code demonstrates the  **WebDateEditCalendarController**:


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

Run the ASP.NET Web Forms application and open the  **Contact**  Detail View. The  **Birthday**  editor shows a touch-UI calendar drop down.

![Tutorial_EF_Lesson8_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson8_3116600.png?v=22.1)

>TIP
This approach does not affect List View’s [in-place editors](https://docs.devexpress.com/eXpressAppFramework/113249/ui-construction/views/list-view-edit-modes?v=22.1). To customize these editors as well, use the solution described in the [How to: Customize a Built-in Property Editor (ASP.NET Web Forms)](https://docs.devexpress.com/eXpressAppFramework/113114/ui-construction/view-items-and-property-editors/property-editors/customize-a-built-in-property-editor-asp-net?v=22.1) topic. Alternatively, access the required in-place Web List Editor as directed in the [ComplexWebListEditor.FindPropertyEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ComplexWebListEditor.FindPropertyEditor.overloads?v=22.1) method description. To apply custom settings to an [ASPxGridListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor?v=22.1)‘s column, handle the [ASPxGridListEditor.CreateCustomGridViewDataColumn](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.CreateCustomGridViewDataColumn?v=22.1) and [ASPxGridListEditor.CustomizeGridViewDataColumn](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.CustomizeGridViewDataColumn?v=22.1) events. If you need to access a template for displaying cells within the current column, use the [ASPxGridListEditor.CreateCustomDataItemTemplate](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.CreateCustomDataItemTemplate?v=22.1) and [ASPxGridListEditor.CreateCustomEditItemTemplate](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.CreateCustomEditItemTemplate?v=22.1) events.



# Access Grid Control Properties (.NET Framework)


>TIP
For Blazor applications, see: [Access List View Grid Component Settings Using a Controller (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/402154/getting-started/in-depth-tutorial-blazor/extend-functionality/access-data-grid-settings?v=22.1).

In this lesson, you will learn how to access the properties of a list form’s Grid Control in WinForms and ASP.NET Web Forms applications. For this purpose, new View Controllers will be implemented. They will set alternating row colors in all List Views represented by the built-in  **GridListEditor**  and  **ASPxGridListEditor**.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)

## Access Editor Settings in a WinForms Application

-   Since the functionality to be implemented is specific to the WinForms platform, changes will be made to the  _MySolution.Module.Win_  project. Add a View Controller to the  _Controllers_  folder in the  _MySolution.Module.Win_  project, as described in the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  lesson. Name it “_WinAlternatingRowsController_“.
-   Invoke the Controller’s Designer. In the  **Properties**  window, set the  **TargetViewType**  property to the “ListView” value. This is necessary because the Controller should appear in List Views only.
    
    ![Tutorial_EF_Lesson10_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson10_3117006.png?v=22.1)
    
-   Since you are going to access the settings of the List View’s Grid Control, you need to ensure that it has already been created. This is why you need to subscribe to the Controller’s  **ViewControlsCreated**  event. In the Properties window, switch to the Events view and double-click the  **ViewControlsCreated**  event. Handle the event as shown below.
    

    
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
    
    As you can see in the code above, to access a list form’s Grid, you should first get the  [ListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.ListEditor?v=22.1), which is the object that binds data to a Grid. To get the  **ListEditor**, use the  [ListView.Editor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ListView.Editor?v=22.1)  property of the required List View. There are  [several types of built-in WinForms ListEditors](https://docs.devexpress.com/eXpressAppFramework/113189/ui-construction/list-editors?v=22.1). The code above is implemented when the current List View is represented by a  [GridListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.Editors.GridListEditor?v=22.1). This  **ListEditor**  represents data via the  **XtraGrid**  control. Use the  [GridListEditor.GridView](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.Editors.GridListEditor.GridView?v=22.1)  property to access this control.
    
-   Run the WinForms application and select an item in the navigation control. The data rows now have alternating colors.
    
    ![Tutorial_EF_Lesson10_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson10_4117007.png?v=22.1)
    

## Access Editor Settings in an ASP.NET Web Forms Application

-   As the functionality to be implemented is specific to the ASP.NET Web Forms platform, changes will be made to  _MySolution.Module.Web_  in this lesson. Add a View Controller to the  _Controllers_  folder in the  _MySolution.Module.Web_  project, as described in the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  lesson. Name it “_WebAlternatingRowsController_“.
-   Invoke the Controller’s  **Designer**. In the  **Properties**  window, set the  **TargetViewType**  property to the “ListView” value. This is necessary because the Controller should appear in List Views only.
    
    ![Tutorial_EF_Lesson10_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson10_1116410.png?v=22.1)
    
-   Since you are going to access the settings of the List View’s Grid Control, you need to ensure that it has already been created. This is why you need to subscribe to the Controller’s  **ViewControlsCreated**  event. In the Properties window, switch to the Events view and double-click the  **ViewControlsCreated**  event. Handle the event as shown below.
    
 
    
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
    
    As you can see in the code above, to access a list form’s Grid, you should first get the  [ListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.ListEditor?v=22.1), which is the object that binds data to a Grid. To get the  **ListEditor**, use the  [ListView.Editor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ListView.Editor?v=22.1)  property of the required List View. There are  [several types of built-in ASP.NET Web Forms ListEditors](https://docs.devexpress.com/eXpressAppFramework/113189/ui-construction/list-editors?v=22.1). The code above is implemented when the current List View is represented by an  [ASPxGridListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor?v=22.1). This  **ListEditor**  represents data via the  **ASPxGridView**  control. To access this control, the  [ASPxGridListEditor.Grid](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.Grid?v=22.1)  property is used.
    
-   Run the ASP.NET Web Forms application. Select an item in the navigation control and ensure that the rows background is changed.
    
    ![Tutorial_EF_Lesson10_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson10_2116409.png?v=22.1)
    

>NOTE
Due to WinForms and ASP.NET Web Forms platform specifics, View Item and List Editor controls may not be immediately ready for customization after the control is created. Consider handling additional platform-dependent events or using alternative approaches if the customizations above do not have any effect.

-   **WinForms:**
    
    Handle the [System.Windows.Forms.Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control) object’s [HandleCreated](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.handlecreated), [VisibleChanged](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.visiblechanged) or [ParentChanged](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.parentchanged) events. You can also handle the **Load** (or similar) event if the current control type exposes it.
    
-   **ASP.NET Web Forms:**
    
    Handle the [System.Web.UI.Control](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control) object’s [Load](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.load) or [Init](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.control.init) server-side event. In certain cases, you may need to handle the [WebWindow.PagePreRender](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.WebWindow.PagePreRender?v=22.1) event. Use the [WebWindow.CurrentRequestWindow](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.WebWindow.CurrentRequestWindow?v=22.1)  _static_ property to get the current **WebWindow** object. You can also perform certain customizations on the client side using JavaScript (see [Client-Side Functionality Overview](https://docs.devexpress.com/AspNet/4222/common-concepts/client-side-functionality?v=22.1)).
    

These additional platform-dependent events indicate the controls’ “ready” state: a control has been added to the form controls hierarchy or has been bound to data. Contact us using the [Support Center](https://supportcenter.devexpress.com/) if you need additional help to perform customizations.


# UI Customization

In this tutorial section, you will customize the automatically generated user interface. Visual elements in your XAF application are based on the data classes you have declared and the information from the assemblies referenced in your application. All the received information is represented as metadata - data that defines database structure and application features via a neutral format, that can be adopted to any target platform. This metadata is called the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1). It is a powerful tool that allows you to customize your application. For this purpose, use the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  - an instrument for customizing the  **Application Model**  at design time. The following lessons will demonstrate what you can customize via the  **Model Editor, and how**:

-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)
-   [Specify Action Settings](https://docs.devexpress.com/eXpressAppFramework/112742/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/specify-action-settings?v=22.1)
-   [Format a Business Object Caption](https://docs.devexpress.com/eXpressAppFramework/112752/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/format-a-business-object-caption?v=22.1)
-   [Assign a Standard Image](https://docs.devexpress.com/eXpressAppFramework/112745/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-standard-image?v=22.1)
-   [Assign a Custom Image](https://docs.devexpress.com/eXpressAppFramework/112744/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-custom-image?v=22.1)
-   [Make a Property Calculable](https://docs.devexpress.com/eXpressAppFramework/112759/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/make-a-property-calculable?v=22.1)
-   [Filter Lookup Editor Data Source](https://docs.devexpress.com/eXpressAppFramework/112755/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/filter-lookup-editor-data-source?v=22.1)
-   [Format a Property Value](https://docs.devexpress.com/eXpressAppFramework/112754/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/format-a-property-value?v=22.1)
-   [Use a Multiline Editor for String Properties](https://docs.devexpress.com/eXpressAppFramework/112753/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/use-a-multiline-editor-for-string-properties?v=22.1)
-   [Localize UI Elements](https://docs.devexpress.com/eXpressAppFramework/112747/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/localize-ui-elements?v=22.1)
-   [Add an Item to the New Action](https://docs.devexpress.com/eXpressAppFramework/112751/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-new-action?v=22.1)
-   [Add an Item to the Navigation Control](https://docs.devexpress.com/eXpressAppFramework/112749/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-item-to-the-navigation-control?v=22.1)
-   [Implement Property Value Validation in the Application Model](https://docs.devexpress.com/eXpressAppFramework/112750/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/implement-property-value-validation-in-the-application-model?v=22.1)
-   [Customize the View Items Layout](https://docs.devexpress.com/eXpressAppFramework/112833/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/customize-the-view-items-layout?v=22.1)
-   [Add an Editor to a Detail View](https://docs.devexpress.com/eXpressAppFramework/112758/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-an-editor-to-a-detail-view?v=22.1)
-   [Change Field Layout and Visibility in a List View](https://docs.devexpress.com/eXpressAppFramework/112746/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/change-field-layout-and-visibility-in-a-list-view?v=22.1)
-   [Display a Detail View with a List View](https://docs.devexpress.com/eXpressAppFramework/112756/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/display-a-detail-view-with-a-list-view?v=22.1)
-   [Make a List View Editable](https://docs.devexpress.com/eXpressAppFramework/112757/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/make-a-list-view-editable?v=22.1)
-   [Add a Preview to a List View](https://docs.devexpress.com/eXpressAppFramework/113378/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/add-a-preview-to-a-list-view?v=22.1)
-   [Filter List Views](https://docs.devexpress.com/eXpressAppFramework/112722/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/filter-list-views?v=22.1)
-   [Apply Grouping to List View Data](https://docs.devexpress.com/eXpressAppFramework/112826/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/apply-grouping-to-list-view-data?v=22.1)
-   [Choose the WinForms UI Type](https://docs.devexpress.com/eXpressAppFramework/113264/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/choose-the-winforms-ui-type?v=22.1)
-   [Toggle the WinForms Ribbon Interface](https://docs.devexpress.com/eXpressAppFramework/113038/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/toggle-the-winforms-ribbon-interface?v=22.1)
-   [Change Style of Navigation Items](https://docs.devexpress.com/eXpressAppFramework/113474/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/change-style-of-navigation-items?v=22.1)

Actually, the Model Editor provides many more ways to customize the Application Model (and, consequently, the application). You can refer to the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112579/ui-construction/application-model-ui-settings-storage?v=22.1)  documentation section to learn more about the Application Model.

If the required option is not available in the Model Editor, you can directly access the options of used controls. Review the  [Access Editor Settings](https://docs.devexpress.com/eXpressAppFramework/112729/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-editor-settings?v=22.1)  and  [Access Grid Control Properties](https://docs.devexpress.com/eXpressAppFramework/113165/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/access-grid-control-properties?v=22.1)  lessons to learn more on this approach.


# Place an Action in a Different Location

In this lesson, you will learn how to place an  [Action](https://docs.devexpress.com/eXpressAppFramework/112622/ui-construction/controllers-and-actions/actions?v=22.1)  in the required place. For this purpose, the  **ClearTasksAction**  that was defined in the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  lesson will be used. It is located together with the  **SaveTo**,  **ExecuteReport**  and  **Refresh**  Actions. This Actions group is called  **View**  [Action Containers](https://docs.devexpress.com/eXpressAppFramework/112610/ui-construction/action-containers?v=22.1)  (the  [ActionBase.Category](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.Category?v=22.1)  property is set to “View” when implementing the  **ClearTasksAction**). The remaining Actions are distributed among other Action Containers. In this lesson, you will move the  **ClearTasksAction**  to the  **RecordEdit**  Action Container.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)
>-   [Add an Action that Displays a Pop-up Window](https://docs.devexpress.com/eXpressAppFramework/112723/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-that-displays-a-pop-up-window?v=22.1)

>TIP
You can also change an Action location in code by handling the [ActionControlsSiteController.CustomizeContainerActions](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ActionControlsSiteController.CustomizeContainerActions?v=22.1) event.

-   Since the  **ClearTasksAction**  is implemented in the common application module, you can specify its location directly in this module. To do this, invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  by double-clicking the  _Model.DesignedDiffs.xafml_  file from the  _MySolution.Module_  project.
    
    ![Tutorial_BMD_Lesson4_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson4_1115428.png?v=22.1)
    
    ![Tutorial_UIC_Lesson1_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson1_1115473.png?v=22.1)
    
    The XAF application interface is based on the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1). The  **Model Editor**  is a tool for browsing and editing the Application Model. This tool is integrated in Visual Studio and displayed as a window pane. Commands specific to the  **Model Editor**  are available in the  **XAF Model Editor**  toolbar.
    
    ![ModelEditor_DesignToolbar](https://docs.devexpress.com/eXpressAppFramework/images/modeleditor_designtoolbar116735.png?v=22.1)
    
    If the  **XAF Model Editor**  toolbar is hidden, you can make it visible by checking the  **XAF Model Editor**  item in the  **VIEW**  |  **Toolbars**  menu.
    
    ![ModelEditor_DesignToolbar_Show](https://docs.devexpress.com/eXpressAppFramework/images/modeleditor_designtoolbar_show116838.png?v=22.1)
    
>    NOTE
    To learn more about **Model Editor** capabilities, refer to the [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1) topic.
    
-   In the  **Model Editor**, navigate to the  **ActionDesign**  |  **ActionToContainerMapping**  node. Its child nodes represent the Action Containers to which the Actions are mapped according to their  **Category**  property values. Expand the  **View**  node representing the  **View**  Action Container. Drag the  **ClearTasksAction**  child node to the  **RecordEdit**  node.
    
    ![Tutorial_UIC_Lesson1_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson1_2115474.png?v=22.1)
    
 >   NOTE
    Alternatively, you can use the context menu’s **Copy**, **Paste**, **Delete** and **Clone** commands to modify the Application Model structure. The modified parts of the Application Model are displayed with a bold font. You can revert any node with all of its child nodes to their original state via the context menu’s **Reset Differences** command.
    
-   Run the WinForms or ASP.NET Web Forms application. Invoke a detail form, since the  **ClearTasksAction**  is activated for  **Detail Views**  only. The following image demonstrates that this Action is located with Actions that belong to the  **RecordEdit**  Action Container.
    
    ![Tutorial_UIC_Lesson1_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson1_3115475.png?v=22.1)
    

You can see the changes made in the lesson in the  **Model Editor**  invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Specify Action Settings

In this lesson, you will learn how to modify Action properties. The  **ClearTasks**  Action will be used. To see how the Action was implemented, refer to the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  lesson. In this lesson, you will add a tooltip, confirmation message and shortcut to it.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

-   Since the  **ClearTasksAction**  is implemented in the common application module, you can specify its properties directly in this module. To do this, invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  by double-clicking the  _Model.DesignedDiffs.xafml_  file in the  _MySolution.Module_  project:
-   In the Model Editor, navigate to the  **ActionDesign**  |  **Actions**  node. Locate the  **ClearTasksAction**  node. To the right, the Action’s settings are represented by properties. These properties are separated into collapsible categories.
-   Navigate to the  **Misc**  category. By default, the  **Tooltip**  property is set to  **Caption**. Set it to “Clear the current Contact’s tasks” instead. Set the  **Shortcut**  property to “Control+Shift+C”, to specify a shortcut for the Action. Note that the specified shortcut will be displayed along with the  **Tooltip**  property value in the Action’s tooltip. By default, the  **ConfirmationMessage**  property is set to the Action’s  [ActionBase.ConfirmationMessage](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ActionBase.ConfirmationMessage?v=22.1)  property value, which is specified in code. Replace this value with “Are you sure you want to clear the {0}’s Tasks list?”. The “{0}” format item will be substituted with the object’s default property value. A property can be specified as default via the  **DefaultProperty**  property of the  **BOModel** | **_<Class>_**  node in the Model Editor. Alternatively, the  **DefaultProperty**  attribute can be applied to the property’s business class declaration.
    
>    NOTE
    Shortcuts are defined by simple strings that you need to type manually. The [IModelAction.Shortcut](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelAction.Shortcut?v=22.1) property is used to parse the strings. Note that shortcuts will only work in a WinForms application.
    
The current object identifier will be inserted into the confirmation message if the Action’s  **SelectionDependencyType**  property is not set to “Independent”. So, assign the “RequireSingleObject” value to the  **SelectionDependencyType**  property. This property belongs to the  **Behavior**  category. You can also set this property to “RequireMultipleObjects”. In this case, the count of selected objects will be substituted to the confirmation message.
    
![Tutorial_UIC_Lesson2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson2_1116707.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application and invoke the  **Detail View**  of any object, by double-clicking an existing one or creating a new one. Check to see if the  **Clear Tasks**  button has the required tooltip, can be executed via the specified shortcut, and a confirmation message with the specified text is invoked.

**WinForms Application**

![Tutorial_UIC_Lesson2_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson2_3116411.png?v=22.1)

**ASP.NET Web Forms Application**

![Tutorial_UIC_Lesson2_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson2_4116412.png?v=22.1)

>NOTE
You can also set an image for an Action. For details, refer to the [Assign a Custom Image](https://docs.devexpress.com/eXpressAppFramework/112744/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-custom-image?v=22.1) topic.

You can see the changes made in this lesson in the Model Editor invoked for the  _Model.DesignedDiffs.xafml_  file, located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Format a Business Object Caption


In this lesson, you will learn how to format the caption of a detail form that displays a business object. For this purpose, the caption of a  **Contact**  object’s detail form will be specified via the  **BOModel**  |  **Contact**  node’s  **ObjectCaptionFormat**  property.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

By default, the class’  [default property](https://docs.devexpress.com/eXpressAppFramework/113525/business-model-design-orm/how-to-specify-a-display-member-for-a-lookup-editor-detail-form-caption?v=22.1)  value is used in the detail form caption. The  **FullName**  property is the  **Person**  class’ default property (specified via the  **DefaultProperty**  attribute). As the  **Contact**  class is inherited from  **Person**  (see  [Inherit from the Business Class Library’s Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)), the  **FullName**  property is also the default property in the  **Contact**  class.

![Tutorial_UIC_Lesson3_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson3_1115477.png?v=22.1)

Perform the following steps to specify the custom caption format.

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  by double-clicking the  _Model.DesignedDiffs.xafml_  file in the  _MySolution.Module_  project.
-   In the Model Editor, navigate to the  **BOModel**  |  **MySolution.Module.BusinessObjects**  node. Select the  **Contact**  node, which defines the  **Contact**  business class. To the right, the class settings are represented by properties.
-   Replace the default value of the  **ObjectCaptionFormat**  property with “{0:FullName} from the {0:Department}”.
    
    >    NOTE
    When setting the object caption format, you can explicitly specify the format string. For instance, **{0:ArticleNo:0000,00#}** or **{0:PeriodDateValue:MM.yyyy}**. For more information about formatting, refer to the [Format Specifiers](https://docs.devexpress.com/WindowsForms/2141/common-features/formatting-values/format-specifiers?v=22.1) topic.
    
    ![Tutorial_UIC_Lesson3_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson3_2115478.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. Invoke a detail form for a  **Contact**  object. The caption must be set to a value, as shown in the following image.
    
    ![Tutorial_UIC_Lesson3_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson3_3115479.png?v=22.1)
    

You can see the changes made in this lesson in the Model Editor invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).

>NOTE
You can use the [ObjectCaptionFormatAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ObjectCaptionFormatAttribute?v=22.1) to specify the object caption in code.



# Assign a Standard Image


**eXpressApp Framework (XAF)**  includes standard images embedded into the  _DevExpress.Images_  assembly. In this lesson, you will learn how to associate a business class with a standard image. This image will represent the class in the navigation control, including detail and list form headers. For this purpose, the  **Department**  and  **Position**  classes will be used, since their ancestor ([BaseObject](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.BaseImpl.BaseObject?v=22.1)  class) is not associated with an image.

To see the available images, browse the following folder:  _%PROGRAMFILES%\DevExpress  22.1\Components\Sources\DevExpress.Images\Images_.

>NOTE
Before proceeding, take a moment to review the [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1) lesson.

Follow the steps below to assign images to the  **Department**  and  **Position**  classes.

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112830/installation-upgrade-version-history/visual-studio-integration/model-editor?v=22.1)  for your WinForms or ASP.NET Web Forms  [application project](https://docs.devexpress.com/eXpressAppFramework/118045/application-shell-and-base-infrastructure/application-solution-components/application-solution-structure?v=22.1).
    
-   Navigate to the  **NavigationItems**  node, and set  [ShowImages](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.IModelRootNavigationItems.ShowImages?v=22.1)  to  **true**.
    
-   For WinForms applications, also set the  [ShowTabImage](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.SystemModule.IModelOptionsWin.ShowTabImage?v=22.1)  property to  **true**  in the  **Options**  node.
    
-   Images are now displayed for business classes. The “BO_Unknown” image is shown for classes that have no preassigned image.
    
    ![BO_Unknown](https://docs.devexpress.com/eXpressAppFramework/images/BO_Unknown_SVG32.png?v=22.1)
    
-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112830/installation-upgrade-version-history/visual-studio-integration/model-editor?v=22.1). Navigate to the  **BOModel**  |  **MySolution.Module.BusinessObjects**  |  **Department**  node and change the  **ImageName**  property value to “BO_Department”. This is the name of the image in the  _%PROGRAMFILES%\DevExpress  22.1\Components\Sources\DevExpress.Images\Images_  folder. This folder represents a  _Standard Image Library_.
    
    ![Tutorial_UIC_Lesson4_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson4_1115480.png?v=22.1)
    
>    NOTE    
    -   When the **ImageName** property is focused, the ellipsis button (![EllipsisButton](https://docs.devexpress.com/eXpressAppFramework/images/ellipsisbutton116182.png?v=22.1)) is displayed to the right of the property value. You can click this button to invoke the **Image Picker** dialog and browse the available images.
    
-   Navigate to the  **BOModel**  |  **MySolution.Module.BusinessObjects**  |  **Position**  node and change the  **ImageName**  property value to “BO_Position”.
    
    ![Tutorial_UIC_Lesson4_1_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson4_1_1116708.png?v=22.1)
    
-   Run the application. You will see that  **Department**  and  **Position**  now have corresponding images displayed within the navigation bar and tab panel. If you run the ASP.NET Web Forms application, you will see similar images within the page header when the  **Department**  (or  **Position**) List View or Detail View is active.
    
    **WinForms Application**
    
    ![Tutorial_UIC_Lesson4_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson4_2.png?v=22.1)
    
    **ASP.NET Web Forms Application**
    
    ![Tutorial_UIC_Lesson4_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson4_3.png?v=22.1)
    

You can see the results in the  **Main Demo**  |  **MainDemo.Module**  project’s Model Editor. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Assign a Custom Image

In this lesson, you will learn how to associate a business class with a custom image. This image will represent the class in the navigation control, including detail and list form headers. For this purpose, the  **Contact**  class will be used. By default, it is associated with the image of its ancestor (the  **Person**  class). You will provide a custom image for the  **Contact**  class.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)
>-   [Assign a Standard Image](https://docs.devexpress.com/eXpressAppFramework/112745/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/assign-a-standard-image?v=22.1)

-   In the  **Solution Explorer**, navigate to the  _Images_  folder in  _MySolution.Module_  project. XAF loads images from this folder.
    
    For this tutorial, you can use custom image files or load them from the  _%PROGRAMFILES%\DevExpress  22.1\Components\Sources\DevExpress.Images\Images_  folder.
    
    ![Assign a Custom Image_Employee](https://docs.devexpress.com/eXpressAppFramework/images/Contact.png?v=22.1)
    
    To use an SVG image in a C# project, save it as as  _\MySolution.Module\Images\Employee.svg_.
    
    To use an SVG image in a Visual Basic project, save it as  _\MySolution.Module\Images\MySolution.Module.Images.Contact.svg_  and ensure “Images” is capitalized in the file name.
    
    For ASP.NET Web Forms applications, use additional files for an icon’s  [active and disabled states](https://docs.devexpress.com/eXpressAppFramework/112792/application-shell-and-base-infrastructure/icons/add-and-replace-icons?v=22.1#naming-images). These items must have the same name as the first file you added and a state’s suffix, for example,  _Employee_Active.svg_  and  _Employee_Disabled.svg_.
    
 >   NOTE
    Refer to the [Add and Replace Icons](https://docs.devexpress.com/eXpressAppFramework/112792/application-shell-and-base-infrastructure/icons/add-and-replace-icons?v=22.1) article for more information on how to use SVG and PNG images in XAF applications.
    
-   In  **Solution Explorer**, select the  [module](https://docs.devexpress.com/eXpressAppFramework/118045/application-shell-and-base-infrastructure/application-solution-components/application-solution-structure?v=22.1)  project and click the  **Show All Files**  (![showall_btn](https://docs.devexpress.com/eXpressAppFramework/images/btn_vs_showall117418.png?v=22.1)) toolbar button. Select the images in the  **Images**  subfolder, right-click the selection, and choose  **Include In Project**.
    
    **C#**
    
    ![Tutorial_UIC_Lesson5_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson5_2.png?v=22.1)
    
    **Visual Basic**
    
    ![Assign_a_Custom_Image_VB](https://docs.devexpress.com/eXpressAppFramework/images/assign_a_custom_image_vb.png?v=22.1)
    
-   Select the images and switch to the  **Properties**  window. Set the  **Build Action**  option to  **Embedded Resource**.
    
    ![Tutorial_UIC_Lesson5_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson5_3.png?v=22.1)
    
-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1). Navigate to the  **BOModel**  |  **MySolution.Module.BusinessObjects**  |  **Contact**  node and set its  **ImageName**  property to “Employee”.
    
    ![Tutorial_UIC_Lesson5_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson5_4115485.png?v=22.1)
    
>    NOTE    
    -   When the **ImageName** property is focused, the ellipsis button (![EllipsisButton](https://docs.devexpress.com/eXpressAppFramework/images/ellipsisbutton116182.png?v=22.1)) is displayed to the right of the property value. You can click this button to invoke the **Image Picker** dialog and browse the available images.
    -   You can use the [ImageNameAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ImageNameAttribute?v=22.1) to specify an image in code.
    
-   Run the application. Notice that the  **Contact**  navigation item now has a custom image assigned.
    
    **WinForms Application**
    
    ![Tutorial_UIC_Lesson5_5](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson5_5.png?v=22.1)
    
    **ASP.NET Web Forms Application**
    
    ![Tutorial_UIC_Lesson5_6](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson5_6.png?v=22.1)
    

You can see the changes made in this lesson in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Make a Property Calculable


In this lesson, you will learn how to manage calculated properties. For this purpose, the  **Payment**  class will be implemented. Its  **Amount**  property value will be calculated using the  **Rate**  and  **Hours**  properties. The value will be updated immediately after changing the  **Rate**  property.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

-   To implement the  **Payment**  class, right-click the  _Business Objects_  folder in the  _MySolution.Module_  project and choose  **Add DevExpress Item**  |  **New Item…**. In the invoked  [Template Gallery](https://docs.devexpress.com/eXpressAppFramework/113455/installation-upgrade-version-history/visual-studio-integration/template-gallery?v=22.1), select the  **XAF Business Object** | **XPO Business Object**  template, enter “Payment” as the file name, and click  **Add**. Replace the automatically generated class declaration with the following code.
    

    
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
    
    The  **Amount**  property is calculated, as it has no  **set**  accessor, and the logic of its value calculation is implemented in the  **get**  accessor.
    
>    NOTE
    In the code above, the **Amount** non-persistent calculated property is decorated with the [PersistentAliasAttribute](https://docs.devexpress.com/XPO/DevExpress.Xpo.PersistentAliasAttribute?v=22.1), to allow filtering and sorting by this property to be performed at the database level. The **PersistentAlias** attribute takes a single parameter that specifies the expression used to calculate the property value on the database server side. A persistent alias must be specified in code as the attribute’s parameter. However, in certain scenarios, the property may require a configurable persistent alias, and it must be configurable by an administrator in a deployed application. In this case, the [CalculatedPersistentAliasAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Xpo.CalculatedPersistentAliasAttribute?v=22.1) should be used.
    
-   Rebuild the  _MySolution.Module_  project and invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for it. Navigate to the  **BOModel**  |  **Payment**  |  **OwnMembers**  |  **Rate**  node. Set the  **Rate**‘s  **ImmediatePostData**  property to  **True**. The  **ImmediatePostData**  property specifies whether or not the property value is updated immediately after changes occur in the current Property Editor’s bound control. As the calculated  **Amount**  property value depends on  **Rate**, these values will be updated simultaneously in the UI.
    
    ![Tutorial_UIC_Lesson6_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson6_1115487.png?v=22.1)
    
>    NOTE
    Alternatively, you can use the [ImmediatePostDataAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ImmediatePostDataAttribute?v=22.1) in code.
    
-   Run the WinForms application. Select the  **Payment**  item in the navigation control. Click the  **New**  button. The detail form for the new  **Payment**  object will be invoked. Specify the  **Rate**  and  **Hours**  properties, and save the changes. Then, change the  **Rate**  and  **Hours**  properties, and see how this affects the  **Amount**  property. The  **Amount**  property value is updated immediately when changing the  **Rate**  property value, and also after the  **Hours**  property field loses focus.
    
    ![Tutorial_UIC_Lesson6_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson6_2116415.png?v=22.1)
    
-   Run the ASP.NET Web Forms application. Select the  **Payment**  item in the navigation control. Invoke the  **Payment**  Detail View in edit mode. Then, change the  **Rate**  and  **Hours**  properties to see how this affects the  **Amount**  property. The page is updated immediately after the  **Rate**  property field loses focus. If you change the  **Hours**  property value, the  **Amount**  value is updated after saving the changes.
    
    ![Tutorial_UIC_Lesson6_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson6_3116416.png?v=22.1)
    

You can see the changes made in this lesson in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx). Note that in  **MainDemo**, the  **ImmediatePostData**  property of  **Hours**  is also set to “**True**“, so the behavior is different from the behavior described in this tutorial.


# Filter Lookup Editor Data Source


In this lesson, you will learn how to filter the data displayed by a lookup editor. This editor is shown in the Detail Views for reference properties. It contains a list of objects of another related class. In this lesson, the  **Contact.Position**  lookup editor will be filtered. For this purpose, a  **Many-to-Many**  relationship will be set between the  **Position**  class and the  **Department**  class. Then, the objects of the  **Position**  class in the Detail View of the  **Contact**  object will be filtered, displaying only those  **Position**s that are related to a corresponding  **Department**.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implement Custom Business Classes and Reference Properties](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Implement Dependent Reference Properties](https://docs.devexpress.com/eXpressAppFramework/112720/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-dependent-reference-properties-xpo?v=22.1)
>-   [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

-   Set a Many-to-Many relationship between the  **Position**  and  **Department**  classes. For details, refer to the  [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)  lesson.
    

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
    
-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Navigate to the  **BOModel**  |  **MySolution.Module.BusinessObjects**  node. Expand the  **Contact**  child node and select the  **Position**  child node. The properties to the right define the  **Contact.Position**  property. Set the  **DataSourceProperty**  property to “Department.Positions”. As a result, the  **Position**  lookup editor will display the  **Department.Positions**  collection.
    
-   Set the  **DataSourcePropertyIsNullMode**  property to “SelectAll”, to display all existing objects in the  **Contact.Position**  editor when the  **Department.Positions**  property is not specified.
    
    ![Tutorial_UIC_Lesson7_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson7_1115488.png?v=22.1)
    
>    NOTE
    You can perform the task defined above in code. See the [Implement Dependent Reference Properties (XPO)](https://docs.devexpress.com/eXpressAppFramework/112720/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-dependent-reference-properties-xpo?v=22.1) topic.
    
-   The data source for the  **Position**  property is changed each time the  **Department**  property is changed. So, the  **Position**  property value should be set to “null” (“Nothing” in VB) after its data source has changed. To set a new value from the recreated data source, replace the  **Department**  property declaration with the following code.

    
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
    
-   Run the WinForms or ASP.NET Web Forms application. Specify the  **Positions**  property for  **Department**  objects. Invoke a Contact Detail View. The dropdown list for the  **Position**  lookup editor contains the Positions assigned to the  **Department**  object that is specified by the  **Department**  editor:
    
    ![Tutorial_UIC_Lesson7_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson7_2115489.png?v=22.1)
    
    ![Tutorial_UIC_Lesson7_2_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson7_2_0115582.png?v=22.1)
    

You can see the changes made in this lesson in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Format a Property Value (WinForms & Web Forms)


In this lesson, you will learn how to set a display format and an edit mask to a business class property. For this purpose, the  **Task.StartDate**,  **Task.DueDate**,  **Task.PercentCompleted**  and  **PhoneNumber.Number**  properties’ display format will be customized using the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1).

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

## Apply an Edit Mask and a Display Format to a DateTime Property Value

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Navigate to the  **BOModel**  |  **DevExpress.Persistent.BaseImpl**  |  **Task**  |  **OwnMembers**  node and select the  **DueDate**  child node. To the right, you will see properties that represent the  **DueDate**  property’s settings.
-   Find the  [DisplayFormat](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.PropertyEditor.DisplayFormat?v=22.1)  property located under the  **Format**  category. Its default value is “{0:d}”. This mask corresponds to the short date pattern (e.g., “3/21/2014”). To use the long date pattern (e.g., “Friday, March 21, 2014”), set the  **DisplayFormat**  property to “{0:D}”. However, the long date pattern is inconvenient when typing the date manually. So, set the  [EditMask](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.PropertyEditor.EditMask?v=22.1)  property value to “d”. This mask will be used when the  **DueDate**  property editor is focused.
    
    ![Tutorial_UIC_Lesson8_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_3116567.png?v=22.1)
    
>    NOTE
    You can set the **DisplayFormat** property to “D” instead of “{0:D}”. These values set the same formatting in a WinForms application. However, note that the “D” value is not valid in an ASP.NET Web Forms application. Use the “{0:<Format_Specifiers>}” syntax instead.
    
-   Select the  **StartDate**  child node. Set the  **DisplayFormat**  property to “{0:D}” and the  **EditMask**  to “d”.
    
    ![Tutorial_UIC_Lesson8_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_4116568.png?v=22.1)
    
-   Run the WinForms application. Invoke a detail form for the DemoTask class. You will see that the formatting of the  **StartDate**  and  **DueDate**  properties depends on the focus. When the Property Editor is focused, the  **EditMask**  is applied, and the property value is formatted according to the short date pattern (the “d” edit mask). When the Property Editor is not focused, the  **DisplayFormat**  is applied, and the property value is formatted according to the long date pattern (the “D” format specifier).
    
-   Run the ASP.NET Web Forms application. Invoke a detail form for the DemoTask class. You will see that the  **DisplayFormat**  is applied, and the  **StartDate**  and  **DueDate**  property values are formatted according to the long date pattern (the “D” format specifier).
    
    ![Tutorial_UIC_Lesson8_6](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_6116570.png?v=22.1)
    
-   Click the  **Edit**  button to display the  **DemoTask**  object in Edit mode. You will see that the  **EditMask**  is applied, and the  **StartDate**  and  **DueDate**  property values are formatted according to the short date pattern (the “d” edit mask).
    
    ![Tutorial_UIC_Lesson8_7](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_7116571.png?v=22.1)
    

>NOTE
Refer to the [Mask Type: Date-time](https://docs.devexpress.com/WindowsForms/1497/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/masks/mask-type-date-time?v=22.1), [Format Specifiers](https://docs.devexpress.com/WindowsForms/2141/common-features/formatting-values/format-specifiers?v=22.1) and [Composite Formatting](https://docs.devexpress.com/WindowsForms/2143/common-features/formatting-values/composite-formatting?v=22.1) topics for details about formatting with masks in WinForms, and the [Mask Types](https://docs.devexpress.com/AspNet/5744/components/data-editors/common-concepts/mask-editing/mask-types?v=22.1) topic for formatting in ASP.NET Web Forms. Note the differences in the use of angle brackets.

## Apply the Display Format to an Integer Property Value

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  **MySolution.Module**  project. Navigate to the  **BOModel**  |  **DevExpress.Persistent.BaseImpl**  |  **Task**  |  **OwnMembers**  node and select the  **PercentCompleted**  child node. To the right, you will see properties that represent the  **PercentCompleted**  property settings.
-   Set the  **DisplayFormat**  property to “{0:N0}%”.
    
    ![Tutorial_UIC_Lesson8_8](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_8116572.png?v=22.1)
    
-   Run the application. Invoke a detail form for the  **DemoTask**  class. You will see that the  **PercentCompleted**  property value is displayed with the ‘%’ sign appended.
    
    In a WinForms application:
    
    ![Tutorial_UIC_Lesson8_9](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_9116573.png?v=22.1)
    
    In an ASP.NET Web Forms application:
    
    ![Tutorial_UIC_Lesson8_10](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_10116574.png?v=22.1)
    
    Since the  **EditMask**  was not specified, the ‘%’ sign is not appended when the editor is focused in a WinForms application. In an ASP.NET Web Forms application, the ‘%’ sign is not appended when the Detail View is in Edit mode.
    

## Apply the Edit Mask to a String Property Value

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Navigate to the  **BOModel**  |  **DevExpress.Persistent.BaseImpl**  |  **PhoneNumber**  |  **OwnMembers**  node and select the  **Number**  child node. To the right, you will see properties that represent the  **Number**  property’s settings.
-   Set the  **EditMask**  property to “(000)000-0000”.
    
    ![Tutorial_UIC_Lesson8_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_1115490.png?v=22.1)
    
>    NOTE    
    >-   The **EditMaskType** property is set to **Simple** by default. However, you can use the [simplified regular expression](https://docs.devexpress.com/WindowsForms/1499/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/masks/mask-type-simplified-regular-expressions?v=22.1) mask by setting this property to **RegEx**. In this instance, an appropriate regular expression for a phone number is “((\d\d\d))\d\d\d-\d\d-\d\d”. However, note that the **RegEx** edit mask type is currently supported in WinForms applications only.
    >-   Use the [MaskSettings](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.SystemModule.IModelMaskSettings.MaskSettings?v=22.1) property instead of the **EditMask** property in **WinForms** application projects.
    
-   Run the WinForms or ASP.NET Web Forms application. Invoke a detail form for the Contact class. Add a  **PhoneNumber**  object to it using the New Action that accompanies the  **PhoneNumbers**  collection. In the  **PhoneNumber**  Detail View, you will see that the  **Number**  property supports the specified mask.
    
    ![Tutorial_UIC_Lesson8_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_2115491.png?v=22.1)
    
    ![Tutorial_UIC_Lesson8_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson8_3117420.png?v=22.1)
    
    The  **PhoneNumber**  Property Editor allows you to input digits at the positions specified by the ‘0’ metacharacters. The ‘(‘, ‘)’ and ‘-‘ characters cannot be removed, and their positions are fixed. As a result, end-users will not be allowed to type an incorrectly formatted phone number.
    
    The ‘(‘, ‘)’ and ‘-‘ characters are saved within the property value, so you do not need to specify the  **DisplayFormat**  to display the parentheses and hyphen when the Property Editor is not focused, or the property value is not editable.
    

Refer to the  [Mask Type: Simple](https://docs.devexpress.com/WindowsForms/1500/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/masks/mask-type-simple?v=22.1)  topic for details.

>NOTE
The **EditMask** and [MaskSettings](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.SystemModule.IModelMaskSettings.MaskSettings?v=22.1) properties do not prohibit users from saving an incorrect value to a database (for example, when they do not fill all the required digits in a phone number). Configure [Validation](https://docs.devexpress.com/eXpressAppFramework/113684/validation-module?v=22.1) settings to prevent data errors.

A custom formatting example is provided in the  **PropertyEditors**  |  **Custom Formatting Properties**  section of the  **FeatureCenter**  demo. By default, the  **FeatureCenter**  application is installed in %PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\FeatureCenter.NETFramework.XPO.

>TIP
You can specify default formatting for all properties of a given type. In a platform-specific project, use [IModelRegisteredPropertyEditor.DefaultDisplayFormat](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.IModelRegisteredPropertyEditor.DefaultDisplayFormat?v=22.1) and [IModelRegisteredPropertyEditor.DefaultEditMask](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.IModelRegisteredPropertyEditor.DefaultEditMask?v=22.1) properties of a **ViewItems** | **PropertyEditors** | **RegisteredPropertyEditor** node.



# Use a Multiline Editor for String Properties

In this lesson, you will learn how to display a multiline editor for string properties. For this purpose, the  **Task.Subject**  property will be used. By default, it is displayed via a single-line text box.

>NOTE
Before proceeding, take a moment to review the [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1) lesson.

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Navigate to the  **BOModel**  |  **DevExpress.Persistent.BaseImpl**  |  **Task**  |  **OwnMembers**  node and select the  **Subject**  child node. To the right, you will see properties that represent the  **Subject**  property’s settings.
-   Set the  **RowCount**  property to “2”. This means that a two-line editor will be created for the  **Subject**  property.
-   Set the  **Size**  property to “200”. This means that an entry of 200 symbols will be allowed in the two-line editor. Alternatively, you can apply the  **Size**  attribute in code.
    
    ![Tutorial_UIC_Lesson9_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson9_1115493.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. Invoke a detail form for a  **DemoTask**  class. The  **Subject**  property will be displayed via a memo editor that contains two lines.
    
    ![Tutorial_UIC_Lesson9_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson9_2115492.png?v=22.1)
    

You can see the changes made in this lesson in the Model Editor invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Localize UI Elements


In this lesson, you will learn the basics of localizing visible UI elements. By default, the application uses the invariant language (English). You will translate your application into German, and create a multi-language application. To illustrate different localization scenarios, the lesson is divided into two sections. They should be performed in order. You will translate several captions for training purposes. To learn how to fully localize an XAF application, first review the  [Localization](https://docs.devexpress.com/eXpressAppFramework/113298/localization?v=22.1)  section, then follow the  [How to: Localize an XAF Application](https://docs.devexpress.com/eXpressAppFramework/113250/localization/localize-an-xaf-application-net-framework?v=22.1)  topic.

>NOTE
Before proceeding, take a moment to review the [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1) lesson.

## Translate Your Application into an Additional Language

Follow the steps below to study the basic concepts of translating your application.

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Find the Model Editor’s toolbar. If it is hidden, check the  **View**  |  **Toolbars**  |  **XAF Model Editor**  menu item. In the toolbar’s  **Language**  combo box (located on the Model Editor’s toolbar), select  **de**. If it is not there, click the  **Language Manager…**  item. In the invoked dialog, click the  **Add**  button and select  **de (German - Deutsch)**.
    
    ![Tutorial_UIC_Lesson11_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson11_0115495.png?v=22.1)
    
    ![Tutorial_UIC_Lesson11_0_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson11_0_0116417.png?v=22.1)
    
-   After adding the language, you should restart Visual Studio.
-   Select the newly added language in the  **Language**  combo box.
    
    ![Tutorial_UIC_Lesson11_0_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson11_0_1115628.png?v=22.1)
    
-   To fully localize your application, you should look through all the nodes and their child nodes to set German values for the properties denoted by the “globe” glyph. The  [Localization Tool](https://docs.devexpress.com/eXpressAppFramework/113297/localization/localization-tool?v=22.1)  simplifies this task. For training purposes, translate a few values to see how this affects your application. Esentially, the  **Caption**  properties can be localized.
    
    ![Tutorial_UIC_Lesson11_0_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson11_0_2116418.png?v=22.1)
    
>    NOTE
    The [How to: Localize an XAF Application](https://docs.devexpress.com/eXpressAppFramework/113250/localization/localize-an-xaf-application-net-framework?v=22.1) topic explains how to localize an **XAF** application.
    
-   In the Model Editor invoked for a WinForms project and/or an ASP.NET Web Forms application project, navigate to the  **Application**  node. In the  **PreferredLanguage**  property’s dropdown list, select “de”. If you need to use the German language in both the WinForms and ASP.NET Web Forms applications, you can specify the  **PreferredLanguage**  property value in the Model Editor invoked for the application module.
    
    ![Tutorial_UIC_Lesson11_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson11_1115494.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. Check to see that the properties that you translated via the Model Editor are displayed in German.

![Tutorial_UIC_Lesson11_1_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson11_1_1116419.png?v=22.1)

## Make a User-Language Application

Perform the steps below if your application needs to be in the user’s language (the user’s operating system language or the language passed by the user’s Internet browser).

-   Translate your application into the required languages. For this purpose, invoke the Model Editor, set the required language in the Model Editor’s  **Language**  toolbar item and translate all localizable property values (as detailed in the previous section). Do this for each required language.
-   In the Model Editor invoked for the WinForms and/or ASP.NET Web Forms application project, navigate to the  **Application**  node. In the  **PreferredLanguage**  property’s dropdown list, select the (**User language**) item.
    
    Alternatively, you can specify the  **PreferredLanguage**  property value in the Model Editor invoked for the application module. In this instance, the user language will be used in both the WinForms and ASP.NET Web Forms applications.
    
    ![Tutorial_UIC_Lesson11_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson11_2115629.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. Check to see if the language corresponds to your system’s current language.
    
    If you did not localize the application to your system’s current language, the default language (English) will be used.
    

You can see a sample application localized into German in the  **Main Demo**. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Add an Item to the New Action


In this lesson, you will learn how to add an item to the  **New**  Action ([NewObjectViewController.NewObjectAction](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.NewObjectViewController.NewObjectAction?v=22.1)). The  **Event**  business class from the Business Class Library will be used.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)
>-   [Add a Class from the Business Class Library and Use the Scheduler Module](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1)

The  **New**  Action’s items are defined in the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1)  by child nodes of the  **CreatableItems**  node. So, to add an item to the  **New**  Action, it is necessary to add a child to the  **CreatableItems**  node. By default, business objects whose declarations are decorated by the  [CreatableItemAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.CreatableItemAttribute?v=22.1)  or  [DefaultClassOptionsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DefaultClassOptionsAttribute?v=22.1)  can be created via the  **New**  Action from any View. However, the  **Event**  class (added in the  [Add a Class from the Business Class Library (XPO)](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1)  topic) has none of these attributes applied. This class is declared in the  [Business Class Library](https://docs.devexpress.com/eXpressAppFramework/112571/business-model-design-orm/built-in-business-classes-and-interfaces?v=22.1). Although it is possible to modify the library sources and recompile the library, it is more convenient to make customizations in the Application Model.

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  by double-clicking the  _Model.DesignedDiffs.xafml_  file from the  _MySolution.Module_  project. In the tree view, navigate to the  **CreatableItems**  node. If you expand this node, you will see the items that correspond to the business classes used in your application. These items were generated because the  **DefaultClassOptions**  attribute is applied to the corresponding classes. To add another item, right-click the  **CreatableItems**  node, and choose  **Add…**  |  **CreatableItem**.
    
    ![Tutorial_UIC_Lesson13_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson13_1115499.png?v=22.1)
    
-   For the newly created node, select “Event” in the  **ModelClass**  dropdown list. The  **Caption**  property will automatically be set to “Scheduler Event”.
    
    ![Tutorial_UIC_Lesson13_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson13_2115500.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. Notice that the  **Scheduler Event**  item has been added to the  **New**  Action’s dropdown list. This item allows you to create  **Event**  objects, when objects of another type are displayed in the List View. Also note that an image has already been assigned to this item.
    
    ![Tutorial_UIC_Lesson13_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson13_3115501.png?v=22.1)
    

You can see the changes made in this lesson in the Model Editor invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Add an Item to the Navigation Control


In this lesson, you will learn how to add an item to the navigation control. For this purpose, the  **Note**  business class from the Business Class Library will be used.

>NOTE
Before proceeding, we recommend that you review the following lessons:
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)
>-   [Add a Class from the Business Class Library and Use the Scheduler Module](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1)

-   If the  **Note**  class is not used as an ancestor in your code, you will need to add it to the UI generation process. To do this, use the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). In the  **Exported Types**  pane, focus the  **Referenced assemblies**  |  **DevExpress.Persistent.BaseImpl.Xpo.v22.1**  |  **Note**  item and press the space bar. Refer to the  [Add a Class from the Business Class Library (XPO)](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1)  lesson for details.
-   The XAF application’s navigation structure is defined by the  **NavigationItems**  node in the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1). To customize the navigation, invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  by double-clicking the  _Model.DesignedDiffs.xafml_  file in the  _MySolution.Module_  project. In the tree view, navigate to the  **NavigationItems** | **Items** | **Default** | **Items**  node. To add a child item to the required navigation item, right-click the  **Items**  node and select  **Add…**  |  **NavigationItem**  from the invoked context menu.
    
    ![Tutorial_UIC_Lesson12_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson12_1115496.png?v=22.1)
    
-   For the newly added node, select “Note_ListView” in the  **View**  dropdown list. The  **Caption**  property will automatically be set to “Note”. Optionally, you can set a user-friendly  **Id**  value.
    
    ![Tutorial_EF_Lesson4_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson4_4115464.png?v=22.1)
    
    As you have seen, there are many ready-to-use Views available in the  **View**  dropdown list. These views are automatically generated based on business classes loaded to the Application Model. One of these classes is  **Note**. So, you only need to add a corresponding View to the navigation items collection.
    
>    NOTE
    You can set shortcuts for navigation items via the **Shortcut** property. In this instance, you will not have to use a mouse to switch between Views, even if the navigation control is hidden via the **View** | **Panels** | **Navigation** | **Hidden** menu item.
    
-   Run the WinForms or ASP.NET Web Forms application. You now have an additional navigation item that allows you to add and edit plain text notes. Also note that this item already has an image assigned.
    
    ![Tutorial_UIC_Lesson12_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson12_3115498.png?v=22.1)
    

>NOTE
When you define a business class in your application, you can apply the [DefaultClassOptionsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DefaultClassOptionsAttribute?v=22.1) or [NavigationItemAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.NavigationItemAttribute?v=22.1) attribute instead of using the Application Model. See the [Inherit from the Business Class Library Class (XPO)](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1) lesson.

You can see the changes made in this lesson in the Model Editor invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project.


# Implement Property Value Validation in the Application Model


In this lesson, you will learn how to check whether or not a property value satisfies a particular rule. For this purpose, the  **DemoTask.Status**  property and the  **MarkCompleted**  Action will be used. This action should not be executed if the current task status is “NotStarted”. Thus, the rule will be checked when executing the  **MarkCompleted**  Action.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Implement Property Value Validation in Code](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

The validation functionality is provided by the  [Validation Module](https://docs.devexpress.com/eXpressAppFramework/113684/validation-module?v=22.1)  that was added in the  [Implement Property Value Validation in Code (XPO)](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)  lesson. When this module is added to the  _MySolution.Module_  project, the  **Validation**  node is available in the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1). This node defines the validation  **Contexts**  and  **Rules**  used in your application. You can use the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  to add Rules and specify  **Contexts**.

-   Invoke the Model Editor for the  _MySolution.Module_  project. Navigate to the  **Validation**  |  **Rules**  node. It already contains child nodes that define the rules to be checked. For example, it may contain the “**RuleRequiredField for Position.Title**“ rule that was implemented in the  [Implement Property Value Validation in Code (XPO)](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)  lesson. To add a new rule that checks specific criteria, right-click the  **Rules**  node and select  **Add…**  |  **RuleCriteria**.
    
    ![Tutorial_UIC_Lesson14_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson14_1115502.png?v=22.1)
    
>    NOTE
    The descriptions of all available rule types are available in the [Validation Rules](https://docs.devexpress.com/eXpressAppFramework/113008/validation/validation-rules?v=22.1) topic.
    
-   For the newly created node, set the  **TargetType**  to “MySolution.Module.BusinessObjects.DemoTask”, and set the  **Criteria**  property to  `Status != 'NotStarted'`. Set the  **ID**  property to “TaskIsNotStarted”,  **TargetContextIDs**  to “MarkCompleted” and  **CustomMessageTemplate**  to “Cannot set the task as completed because it has not started”.
    
    ![Tutorial_UIC_Lesson14_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson14_2115508.png?v=22.1)
    
>    NOTE
    The **Criteria** property value must be specified using the [Criteria Language Syntax](https://docs.devexpress.com/CoreLibraries/4928/devexpress-data-library/criteria-language-syntax?v=22.1). To simplify this task, you can invoke the **Filter Builder** dialog by clicking the ellipsis button (![EllipsisButton](https://docs.devexpress.com/eXpressAppFramework/images/ellipsisbutton116182.png?v=22.1)) to the right of the **Criteria** value. Within this dialog, you can visually design a criteria expression.
    
-   The  **TargetContextIDs**  property is set to “MarkCompleted”. This means that the rule will be checked when executing the Action whose  **ValidationContexts**  property is set to “MarkCompleted”. So, set the  **Mark Completed**  Action’s  **ValidationContexts**  property (in the  **ActionDesign**  |  **Actions**  |  **Task.MarkCompleted**  node) to “MarkCompleted”.
    
    ![Tutorial_UIC_Lesson14_2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson14_2_1116422.png?v=22.1)
    
>    NOTE
    You can also use the **Save** or **Delete** contexts, which are available by default. Rules with these contexts are validated when an object is saved or deleted, respectively (see [Validation Rules](https://docs.devexpress.com/eXpressAppFramework/113008/validation/validation-rules?v=22.1)).
    
-   Run the WinForms or ASP.NET Web Forms application. Assign the “Not Started” value to the  **Status**  property of one of the existing  **DemoTask**  objects. Click the  **MarkCompleted**  button. The following  **Validation Error**  dialog will be displayed.
    
    ![Tutorial_UIC_Lesson14_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson14_4116421.png?v=22.1)
    

>NOTE
Generally, you can add the required rule to a class or property in code (see [Implement Property Value Validation in Code](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)). The approach defined above is useful when the class sources are inaccessible.

You can see the changes made in this lesson in the Model Editor invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Customize the View Items Layout


In this lesson, you will learn how to customize the default editor layout in a Detail View. For this purpose, the Contact Detail View will be used.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Navigate to the  **Views**  |  **MySolution.Module.BusinessObjects**  node. Expand the  **Contact_DetailView**  child node. It contains the  **Items**  and  **Layout**  child nodes. To view and modify the current layout of the Contact Detail View editors, select the  **Layout**  node. The property list to the right will be replaced with a design surface that imitates the Contact Detail View. To modify the editor arrangement, right-click the View’s empty space and choose  **Customize Layout**.

![Tutorial_UIC_Lesson21_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson21_1115630.png?v=22.1)

The  **Customization Form**  will be invoked. In the invoked form, you can drag editors to the required positions.

![Tutorial_UIC_Lesson21_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson21_2115631.png?v=22.1)

Follow the graphical prompts that indicate the item’s new location. In addition, you can remove and restore  **View Items**. Drag the required item from the Detail View to the  **Customization Form**  to remove the item, and drag the item from the  **Customization Form**  to the  **Detail View**  to add it.

To view the layout tree for View Items, click the  **Layout Tree View**  tab on the  **Customization Form**. You can right click a tree item and invoke a context menu, allowing you to hide the  **Customization Form**, reset the layout, create a tabbed group, etc. (See the image below.)

![Tutorial_UIC_Lesson21_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson21_3115632.png?v=22.1)

To learn more about the  **Customization**  form, the  **Layout Tree View**  tab and its context menu, refer to the  [Default Runtime Customization](https://docs.devexpress.com/WindowsForms/2307/controls-and-libraries/form-layout-managers/layout-and-data-layout-controls/design-time-and-runtime-customization/default-runtime-customization?v=22.1)  topic.

Close the  **Customization Form**. Run the WinForms or ASP.NET Web Forms application, and invoke a  **Contact**  Detail View. Notice that the editors are arranged as required.

If you want to reset changes, right-click  **Contact_DetailView**  |  **Layout**  and choose  **Reset Differences**.

![Tutorial_UIC_Lesson21_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson21_4120047.png?v=22.1)

>NOTE
Alternatively, you can customize the **Contact** Detail View layout at runtime, and then merge these customizations into the **MySolution.Module** project. Refer to the [How to: Merge End-User Customizations into the XAF Solution](https://docs.devexpress.com/eXpressAppFramework/113335/ui-construction/application-model-ui-settings-storage/application-model-storages/merge-end-user-customizations-model?v=22.1) topic for details.


# Add an Editor to a Detail View


This lesson explains how to add an editor to a  [Detail View](https://docs.devexpress.com/eXpressAppFramework/112611/ui-construction/views?v=22.1). In this example, we add an editor for the  **Department.Office**  property to the  **Contact**  Detail View.

>NOTE
Before you proceed, take a moment to review the following lesson:
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

## Step-by-Step Instructions

1.  Open the  _Model.DesignedDiffs.xafml_  file in the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1).
    
2.  Navigate to the  **Views**  |  **MySolution.Module.BusinessObjects**  |  **Contact**  node. Expand the  **Contact_DetailView**  child node and click the  **Layout**  node.
    
3.  The Model Editor displays a design surface that imitates the  **Contact**  Detail View. Right-click the View’s empty space and choose  **Customize Layout**.
    
    ![Start layout customization](https://docs.devexpress.com/eXpressAppFramework/images/blazor-tutorial-customize-layout-context-menu.png?v=22.1)
    
4.  In the invoked  **Customization**  window, click the  **Add**  button.
    
    ![Customization Window](https://docs.devexpress.com/eXpressAppFramework/images/blazor-tutorial-customization-window.png?v=22.1)
    
5.  In the  **Object Model**  dialog, expand the  **Department**  node, check the  **Office**  checkbox, and click  **OK**.
    
    ![Object Model Window](https://docs.devexpress.com/eXpressAppFramework/images/blazor-tutorial-object-model-window.png?v=22.1)
    
6.  The  **Office:**  item appears on the  **Hidden Items**  tab of the  **Customization**  window:
    
    ![A new field is added to the Object Model Window](https://docs.devexpress.com/eXpressAppFramework/images/blazor-tutorial-customization-window-new-field.png?v=22.1)
    
7.  Drag the  **Office:**  item to the required position of the  **Contact**  Detail View.
    

8.  Run the WinForms or ASP.NET Web Forms application and invoke a  **Contact Detail**  View. The  **Office**  editor is located in the same column as the  **Department**  editor,  **Position**  editor, and other editors.
    
    ![Tutorial_UIC_Lesson15_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson15_3115505.png?v=22.1)
    

You can see the changes made in this lesson in the  **Model Editor**  invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).

## Detailed Explanation

### Layout Customization

In the customization mode that we activated in  _step 3_  of this lesson, you can change the Detail View layout. See the following topic for more information:  [Customize the View Items Layout](https://docs.devexpress.com/eXpressAppFramework/112833/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/customize-the-view-items-layout?v=22.1).

Users can also customize the Detail View layout. The following topic describes how to change the layout at runtime:  [Default Runtime Customization](https://docs.devexpress.com/WindowsForms/2307/controls-and-libraries/form-layout-managers/layout-and-data-layout-controls/design-time-and-runtime-customization/default-runtime-customization?v=22.1).

In addition, you can customize the  **Contact**  Detail View layout at runtime, and merge these changes into the  **MySolution.Module**  project. See the following topic for details:  [How to: Merge End-User Customizations into the XAF Solution](https://docs.devexpress.com/eXpressAppFramework/113335/ui-construction/application-model-ui-settings-storage/application-model-storages/merge-end-user-customizations-model?v=22.1).


# Change Field Layout and Visibility in a List View


This lesson will guide you through the steps needed to select columns displayed in the  **List View**. For this purpose, the  **Contact**  List View will be used. At runtime, you can right-click a column header and activate the  **Column Chooser**, then drag invisible columns from the  **Column Chooser**  window to the grid control. To set the default table layout, you need to customize it at design-time.

>NOTE
Before proceeding, take a moment to review the [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1) lesson.

In a WinForms application, the customizations made using the  **Runtime Column Chooser**  are persisted in a  _Model.user.xafml_  file, located in the application folder by default. In an ASP.NET Web Forms application, you may need to set the  **SaveListViewStateInCookies**  property of the  **Options**  node and the  **SaveStateInCookies**  property of the corresponding  **Views** | **_<ListView>_**  node to “true”. This enables you to save the  **List View**  state between sessions in a user’s browser cookies, allowing each end-user to customize the List View individually. The set of columns visible by default is generated based on rules described in the  [List View Column Generation](https://docs.devexpress.com/eXpressAppFramework/113285/ui-construction/views/layout/list-view-column-generation?v=22.1)  article. Customizing the default column set may be required. To make required columns visible or invisible within the  **List View**  by default, use the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1).

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project, and navigate to the  **Views**  |  **MySolution.Module.BusinessObjects**  |  **Contact_ListView**  |  **Columns**  node to invoke the  **Grid List Editor Designer**. It will display the default structure of the  **List View**. You can customize the default appearance of the List View by dragging, resizing and grouping the columns. Invoke the  **Customization**  window by right-clicking the table header and selecting  **Column Chooser**.
    
    ![Tutorial_UIC_Lesson16_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson16_1115506.png?v=22.1)
    
-   For example, customize the List View to display the following columns.
    
    1.  **FullName**
    2.  **Position**
    3.  **Department**
    4.  **Email**
    
    ![Tutorial_UIC_Lesson16_1_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson16_1_2117540.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. See if the  **Contact**  List View looks like the following image.
    
    ![Tutorial_UIC_Lesson16_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson16_2115507.png?v=22.1)
    
    ![Tutorial_UIC_Lesson16_2_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson16_2_2121225.png?v=22.1)
    
>    TIP
    When the browser window shrinks, some columns become hidden and can be accessed using the “…” button (see [IModelColumnWeb.AdaptivePriority](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.SystemModule.IModelColumnWeb.AdaptivePriority?v=22.1)).
    
   If you previously customized the visibility of the  **Contact**  List View columns at runtime, the new set of visible columns will not be applied. To remove the previous customization in a WinForms application, click the  **Reset View Settings**  button. Alternatively, you can invoke the  **Runtime Model Editor**  (using the  **Tools**  |  **Edit Model**  menu item), right-click the  **Views**  |  **Contact_ListView**  node and select  **Reset Differences**.
    
![ResetDifferencesOrViewSettings](https://docs.devexpress.com/eXpressAppFramework/images/resetdifferencesorviewsettings120365.png?v=22.1)

You can see the changes made in the lesson in the Model Editor invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).

>NOTE
Alternatively, you can customize column order and visibility by changing the value of the **Index** property of specific columns (**Columns** node’s child nodes). Refer to the [List View Columns Customization](https://docs.devexpress.com/eXpressAppFramework/113679/ui-construction/views/layout/list-view-columns-customization?v=22.1) article to learn more.

>TIP
You can arrange columns into logical groups (bands). For details, refer to the [List View Bands Layout](https://docs.devexpress.com/eXpressAppFramework/113695/ui-construction/views/layout/list-view-bands-layout?v=22.1) topic.



# Display a Detail View with a List View

In this lesson, you will learn how to display a  **Detail View**  together with a  **List View**. For this purpose, the  **Department**  List View will be used. The object selected in it will be displayed in the corresponding  **Detail View**.

>NOTE
Before proceeding, take a moment to review the [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1) lesson.

Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Navigate to the  **Views**  |  **MySolution.Module.BusinessObjects**  |  **Department_ListView**  node. It defines the  **List View**  that is used for  **Department**  objects using the properties to the right. In the  [MasterDetailMode](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelListView.MasterDetailMode?v=22.1)  property’s dropdown list, select  **ListViewAndDetailView**.

![Tutorial_UIC_Lesson17_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson17_1115513.png?v=22.1)

Run the WinForms or ASP.NET Web Forms application. The  **Department**  List View will appear as follows.

**WinForms Application**

![Tutorial_UIC_Lesson17_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson17_2115512.png?v=22.1)

**ASP.NET Web Forms Application**

![Tutorial_UIC_Lesson17_2_Web](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson17_web.png?v=22.1)

In the WinForms application, use the  **Save**  (![btn_Save](https://docs.devexpress.com/eXpressAppFramework/images/btn_save117423.png?v=22.1)) or  **SaveAndClose**  (![btn_SaveClose](https://docs.devexpress.com/eXpressAppFramework/images/btn_saveclose117425.png?v=22.1)) buttons on the toolbar to commit changes made in the  **Detail View**. To cancel the changes, use the  **Cancel**  (![btn_Cancel](https://docs.devexpress.com/eXpressAppFramework/images/btn_cancel117426.png?v=22.1)) button.

>NOTE
>-   You can specify the **Detail View** that should be displayed alongside the **List View** (see [ListView.DetailViewId](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ListView.DetailViewId?v=22.1)).
>-   To specify the **Detail View** location, use the [IModelSplitLayout.Direction](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelSplitLayout.Direction?v=22.1) and [IModelListViewSplitLayout.ViewsOrder](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelListViewSplitLayout.ViewsOrder?v=22.1) properties of the **ListView** | **SplitLayout** node.
>-   The **Reset View Settings** Action resets settings for both List and Detail Views in the **ListViewAndDetailView** display mode.

In the ASP.NET Web Forms Application, the  [IModelListViewWeb.DetailRowMode](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.SystemModule.IModelListViewWeb.DetailRowMode?v=22.1)  option is similar to  **MasterDetailMode**, but it allows you to show a Detail View in a List View’s  [Detail Row](https://docs.devexpress.com/AspNet/3769/components/grid-view/visual-elements/detail-row?v=22.1).

You can see the changes made in this lesson in the  **Model Editor**  invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project and the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module.Web**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Make a List View Editable


In this lesson, you will learn how to make a  **List View**  editable. For this purpose, the  **DemoTask**  List View will be used.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Navigate to the  **Views**  |  **MySolution.Module.BusinessObjects**  |  **DemoTask_ListView**  node. It defines the  **List View**  that is used for  **DemoTask**  objects with the properties to the right. In the  **AllowEdit**  property’s dropdown list, select “True”. When this property is set to “True”, the  **List View**  is editable.
    
    When  **List Views**  are displayed in edit mode, you can apply the  **NewItemRow**  functionality of the  **XtraGrid**  that displays  **ListViews**  in XAF applications. This functionality allows end-users to create new objects directly in a  **List View**  without a  **Detail View**. To add this functionality, set the  **NewItemRowPosition**  property to  **Top**  or  **Bottom**.
    
    ![Tutorial_UIC_Lesson18_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson18_1115510.png?v=22.1)
    
>    TIP
    In ASP.NET Web Forms applications, there are several modes for editing. To set the required mode, use the [IModelListViewWeb.InlineEditMode](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.SystemModule.IModelListViewWeb.InlineEditMode?v=22.1) property in the **Model Editor** invoked for the _MySolution.Module.Web_ project. Various edit modes are illustrated in the [List View Edit Modes](https://docs.devexpress.com/eXpressAppFramework/113249/ui-construction/views/list-view-edit-modes?v=22.1) topic (**ASP.NET Web Forms-Specific Functionality** section).
    
-   Run the WinForms or ASP.NET Web Forms application and edit one of the  **DemoTask**  objects within the  **List View**.
    
    ![Tutorial_UIC_Lesson18_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson18_2115511.png?v=22.1)
    
    To edit one of the  **DemoTask**  objects in an ASP.NET Web Forms application, click  **Edit**(![InlineEdit_EditButton](https://docs.devexpress.com/eXpressAppFramework/images/inlineedit_editbutton116546.png?v=22.1)) or click  **New**(![InlineEdit_NewButton](https://docs.devexpress.com/eXpressAppFramework/images/inlineedit_newbutton116547.png?v=22.1)) to create a new  **Task**.
    
    ![Tutorial_UIC_Lesson18_2_Web](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson18_2_web115979.png?v=22.1)
    
    In a WinForms application, to save the changes made to an object, click the  **Save**  (![btn_Save](https://docs.devexpress.com/eXpressAppFramework/images/btn_save117423.png?v=22.1)) or  **SaveAndClose**  (![btn_SaveClose](https://docs.devexpress.com/eXpressAppFramework/images/btn_saveclose117425.png?v=22.1)) button on the toolbar. To cancel the changes, click the  **Cancel**  (![btn_Cancel](https://docs.devexpress.com/eXpressAppFramework/images/btn_cancel117426.png?v=22.1)) button.
    
    In the ASP.NET Web Forms application, to save changes, click  **Update**  (![btn_Save](https://docs.devexpress.com/eXpressAppFramework/images/btn_save117423.png?v=22.1)). To cancel the changes, click  **Cancel**  (![btn_Cancel](https://docs.devexpress.com/eXpressAppFramework/images/btn_cancel117426.png?v=22.1)).
    

>NOTE
>-   List Views in DataView, ServerView, and InstantFeedbackView [data access modes](https://docs.devexpress.com/eXpressAppFramework/113683/ui-construction/views/list-view-data-access-modes?v=22.1) do not support this functionality.
>-   You can set the edit mode in code. To do this, apply the [DefaultListViewOptionsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.DefaultListViewOptionsAttribute?v=22.1) attribute to the **DemoTask** class.

To see the changes made in this lesson, invoke the  **Model Editor**  for the  **Main Demo’**s  **MainDemo.Module**,  **MainDemo.Module.Win**  and  **MainDemo.Module.Web**  projects. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Add a Preview to a List View


In this lesson, you will learn how to show a preview section in a  **List View**‘s grid. For this purpose, the  **DemoTask**  List View will be used.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Set a Many-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112719/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-many-to-many-relationship-xpo?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

The  **DemoTask**  List View is presented by the  [ASPxGridListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor?v=22.1)  in the ASP.NET Web Forms application and by the  [GridListEditor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.Editors.GridListEditor?v=22.1)  in the WinForms application. These  **List Editor**s support the  **Automatic Preview**  feature provided by the  **ASPxGridView**  and  **XtraGrid**  controls. To enable this feature, you should open the  **Model Editor**  and assign the  **List View**  value to the  **PreviewColumnName**  property. When this property is not set, the feature is disabled. It is disabled by default.

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the MySolution.Module project. Navigate to the  **Views**  |  **MySolution.Module.BusinessObjects**  |  **DemoTask_ListView**  node. It defines the List View that is used for DemoTask objects via the properties to the right. Set the  **PreviewColumnName**  property to “Description”. As a result, the text for the preview section will be retrieved from the  **DemoTask.Description**  property.
    
    ![Tutorial_UIC_Lesson22_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson22_1117008.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. Navigate to the  **DemoTask**  List View. Check to see that the preview section is enabled and it shows the  **DemoTask.Description**  property.
    
    ![Tutorial_EF_Lesson9_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ef_lesson9_1115472.png?v=22.1)
    

To see the changes made in this lesson, invoke the  **Model Editor**  for the  **Main Demo**‘s  **MainDemo.Module**,  **MainDemo.Module.Win**  and  **MainDemo.Module.Web**  projects. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Filter List Views

In this lesson, you will learn how to filter a  **List View**. Three techniques, based on different scenarios, will be illustrated. For this lesson, a filter will be applied to the  **Contact**  List View.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Implement Custom Business Classes and Reference Properties](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Set a One-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112733/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-one-to-many-relationship-xpo?v=22.1)
>-   [Filter Lookup Editor Data Source](https://docs.devexpress.com/eXpressAppFramework/112755/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/filter-lookup-editor-data-source?v=22.1)
>-   [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1)

## Activate a Filter Action

Use this approach to enable an end-user to apply predefined filters to a particular  **List View**. With this approach, the  **SetFilter**  Action (whose items represent predefined filters) is visible in the user interface. This action is activated for  **List View**s only. Predefined filters can be added in the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112580/ui-construction/application-model-ui-settings-storage/how-application-model-works?v=22.1), and are represented by child nodes of the  **Views** | **_<ListView>_**  |  **Filters**  node (see  [Filters Application Model Node](https://docs.devexpress.com/eXpressAppFramework/112992/filtering/in-list-view/filters-application-model-node?v=22.1)).

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Navigate to the  **Views**  |  **MySolution.Module.BusinessObjects**  |  **Contact_ListView**  node. Right-click the  **Filters**  child node and select  **New**  |  **ListViewFilterItem**. For the new node, set the  **Id**  property to “Development Department Contacts”. To specify a criteria, set the  **Criteria**  property to the  `[Department.Title] = 'Development Department'`  value.
    
    ![Tutorial_UIC_Lesson19_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson19_2115515.png?v=22.1)
    
>    NOTE
    The **Criteria** property value must be specified using the [Criteria Language Syntax](https://docs.devexpress.com/CoreLibraries/4928/devexpress-data-library/criteria-language-syntax?v=22.1). To simplify this task, you can invoke the **Filter Builder** dialog by clicking the ellipsis button (![EllipsisButton](https://docs.devexpress.com/eXpressAppFramework/images/ellipsisbutton116182.png?v=22.1)) to the right of the **Criteria** value. Within this dialog, you can design a criteria expression using the visual **Filter Builder**.
    
-   Add one more  **Filter**  node to the  **Filters**  node as defined above. Set the  **Id**  property to “Developers” and the  **Criteria**  property - to  `Position.Title = 'Developer'`.
    
    ![Tutorial_UIC_Lesson19_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson19_3115516.png?v=22.1)
    
-   To be able to view all  **Contact**  objects in the  **List View**, add one more  **Filter**  node to the  **Filters**  node, as defined above. Set the  **Id**  property to “All Contacts” and leave the  **Criteria**  property empty.
    
    ![Tutorial_UIC_Lesson19_3_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson19_3_1116424.png?v=22.1)
    
-   For the  **Filters**  node, set the  **CurrentFilter**  property to “Developers”. Save the changes.
    
    ![Tutorial_UIC_Lesson19_3_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson19_3_2116425.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application and select the  **Contacts**  item in the navigation control. Notice that the  **SetFilter**  Action is now available.
    
    ![Tutorial_UIC_Lesson19_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson19_4115517.png?v=22.1)
    

## Use the Model Editor’s Application | Views | ListView Node

Use this approach to filter a  **List View**  via the  **Model Editor**. Filters applied with the  **Model Editor**  cannot be changed by end-users.

-   Run the  **Model Editor**  for the  _MySolution.Module_  project. Navigate to the  **Views**  |  **MySolution.Module.BusinessObjects**  |  **Contact_ListView**  node. Set its  **Criteria**  property to  `Position.Title = 'Developer'`.
    
    ![Tutorial_UIC_Lesson19_5](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson19_5115518.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. Select the  **Contacts**  item in the navigation control and check to see if the  **Contact**  objects in the  **List View**  are filtered.

## Filter on Data Source Level

Use this approach if you need to apply filters that will not be changed at runtime or via the  **Model Editor**.

-   Create a  **View Controller**  and generate the  **Activated**  event handler, as defined in the  [Add a Simple Action](https://docs.devexpress.com/eXpressAppFramework/112737/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-a-simple-action?v=22.1)  tutorial, as well as the other lessons from the  [Extend Functionality](https://docs.devexpress.com/eXpressAppFramework/112740/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality?v=22.1)  section.
-   Replace the generated code for the  **Activated**  event handler with the following code.
    

    
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
    
-   Run the WinForms or ASP.NET Web Forms application and select the  **Contacts**  item in the navigation control. Check to see if the  **Contact**  objects in the  **List View**  are filtered.



# Apply Grouping to List View Data


This lesson will teach you how to apply grouping to  **List View**  data. For this purpose, you will group  **Contact**  List View data by the  **Department**  property.

>NOTE
Before proceeding, take a moment to review the [Place an Action in a Different Location](https://docs.devexpress.com/eXpressAppFramework/112741/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/place-an-action-in-a-different-location?v=22.1) lesson.

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  _MySolution.Module_  project. Navigate to the  **Views**  |  **MySolution.Module.BusinessObjects**  |  **Contact_ListView**  |  **Columns**  node to invoke the  **Grid List Editor Designer**. It will display the default structure of the List View. You can customize the default appearance of the List View. Invoke the Customization window by right-clicking the table header and selecting  **Show Group By Box**.
    
    ![Tutorial_UIC_Lesson20_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson20_0117547.png?v=22.1)
    
-   This will set  **Contact_ListView**‘s  **IsGroupPanelVisible**  property to true and display a special group area for  **Contact**  List Views in both the WinForms and ASP.NET Web Forms applications. To specify the column by which the  **Contact**  List View will be grouped by default, drag the column’s header to the group area. A nested grouping can be applied by dragging multiple columns to the group area. Group the  **Contact**  List View against the  **Department**  column, then against the  **Position**  column.
    
    ![Tutorial_UIC_Lesson20_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson20_1117548.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application and select the  **Contacts**  item in the navigation control. The group area is displayed in  **Contact**  List View. The column order within this area represents the nesting order of data groups. The  **Contact**  List View is grouped by the  **Department**  and  **Position**  columns.
    
    ![Tutorial_UIC_Lesson20_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson20_3115635.png?v=22.1)
    
-   You can specify this group area in runtime similarly to described above method. If you want to reset changes clicking  **Reset View Settings**  button.
    
    ![Tutorial_UIC_Lesson20_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_lesson20_4120065.png?v=22.1)
    

>NOTE
There is another approach for grouping based on changing the value of **GroupIndex** property of specific columns (**Columns** node’s child nodes). Refer to the [List View Columns Customization](https://docs.devexpress.com/eXpressAppFramework/113679/ui-construction/views/layout/list-view-columns-customization?v=22.1) article to learn more.

You can see the changes made in this lesson in the  **Model Editor**  invoked for the  _Model.DesignedDiffs.xafml_  file located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Choose the WinForms UI Type

In this lesson, you will learn how to change the UI Type of the WinForms application. By default, the  [Solution Wizard](https://docs.devexpress.com/eXpressAppFramework/113624/installation-upgrade-version-history/visual-studio-integration/solution-wizard?v=22.1)  enables the  [Multiple Document Interface](https://docs.devexpress.com/WindowsForms/11355/controls-and-libraries/application-ui-manager/views/tabbed-view?v=22.1)  (**MDI**). You can change this setting via the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1), or in code. For example, you can select  **Single Document Interface (SDI)**  for your application.

Follow the steps below to change the UI Type of your WinForms application using the Model Editor:

-   Invoke the  **Model Editor**  by double-clicking the  _Model.xafml_  file from the  **MySolution.Win**  project. Navigate to the  **Options**  node. This node allows you to edit different UI settings of the application. In the  **UIType**  property’s dropdown list, select the desired option, for example,  **SingleWindowSDI**.
    
    ![MDI_ME](https://docs.devexpress.com/eXpressAppFramework/images/mdi_me116635.png?v=22.1)
    
-   Run the WinForms application. Ensure that the  **SDI**  is enabled, as illustrated in the image below.
    
    ![SDI](https://docs.devexpress.com/eXpressAppFramework/images/sdi116634.png?v=22.1)
    
    In  **SDI**  mode, each invoked  **View**  appears within a single window that replaces the previous one.
    
    >NOTE
    If you have selected **MDI**, you can customize its behavior in the **Model Editor** using the **Options** node’s **MdiDefaultNewWindowTarget** property.
    

To learn how to change the  **UI Type**  in code, refer to the  [WinApplication.ShowViewStrategy](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Win.WinApplication.ShowViewStrategy?v=22.1)  topic If you change the  **UI Type**  in code, changes made to the  **UIType**  property value in the  **Model Editor**‘s  **Options**  node will be ignored.

In the  **Main Demo**, a separate WinForms project is created to demonstrate the  **MDI**. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Toggle the WinForms Ribbon Interface

In this lesson, you will learn how to enable/disable the  [Ribbon User Interface](https://docs.devexpress.com/WindowsForms/2500/controls-and-libraries/ribbon-bars-and-menu/ribbon?v=22.1)  in your application.

>NOTE
Before proceeding, take a moment to review the [Create a Solution using the Wizard](https://docs.devexpress.com/eXpressAppFramework/112717/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/create-a-solution-using-the-wizard?v=22.1) lesson.

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  by double-clicking the  _Model.xafml_  file from the  **MySolution.Win**  project. Navigate to the  **Options**  node. This node allows you to edit different UI settings of the application. In the  **FormStyle**  property’s dropdown list, select  **Ribbon**.
    
    ![RibbonME](https://docs.devexpress.com/eXpressAppFramework/images/ribbonme116638.png?v=22.1)
    
   > NOTE
    Additional ribbon options are available in the **Options** | **RibbonOptions** node.
    
-   Run the WinForms application to view the result.
    
    **Ribbon UI**
    
    ![Ribbon](https://docs.devexpress.com/eXpressAppFramework/images/ribbon116637.png?v=22.1)
    
    **Standard UI**
    
    ![Non-Ribbon](https://docs.devexpress.com/eXpressAppFramework/images/non-ribbon117495.png?v=22.1)
    
    >NOTE
    The **Ribbon UI** provides the Quick Access Toolbar. You can place frequently used Actions on this toolbar to improve the usability of your application. To add a certain Action to this toolbar, navigate to the **ActionDesign** | **Actions** | **_<Action>_** node and set the **QuickAccess** property to “**True**“.
    

In the  **Main Demo**, a separate WinForms project is created to demonstrate the  **Ribbon UI**.


# Change Style of Navigation Items

In this lesson, you will learn how to change the style of navigation items in a WinForms  **XAF**  application. By default, a 32x32 icon with a label below is displayed for each item. This style is inconvenient when you have many navigation items. To save screen space and avoid scrolling, a 16x16 icon with a label to the right can be displayed for each item instead.

-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  by double-clicking the  _Model.DesignedDiffs.xafml_  file located in the  **MySolution.Module**  project. Navigate to the  **NavigationItems** | **Items** | **Default**  node. This node specifies settings for the  **Default**  navigation group that encloses navigation items created in the previous lessons (**Contact**,  **Task**,  **Department**, etc.). In the grid to the right, set the  **ChildItemsDisplayStyle**  property to  **List**  (the default is  **LargeIcons**).
    
    ![Tutorial_UIC_Navigation_01](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_navigation_01117206.png?v=22.1)
    
    For details, see the  [IModelChoiceActionItemChildItemsDisplayStyle.ChildItemsDisplayStyle](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelChoiceActionItemChildItemsDisplayStyle.ChildItemsDisplayStyle?v=22.1)  property and  [ItemsDisplayStyle](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Templates.ActionContainers.ItemsDisplayStyle?v=22.1)  enumeration description.
    
-   Run the WinForms application. You will see that small icons are now used for navigation items in the  **Default**  navigation group. The image below illustrates the changes.
    
    ![Tutorial_UIC_Navigation_02](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_uic_navigation_01117207.png?v=22.1)
    

>NOTE
You can also change the style of the entire navigation control. Run the **Model Editor** and modify the [IModelRootNavigationItems.NavigationStyle](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.IModelRootNavigationItems.NavigationStyle?v=22.1) property of the **NavigationItems** node for this purpose.


# Extra Modules


The  **eXpressApp Framework**  supplies some features in separated assemblies called  [modules](https://docs.devexpress.com/eXpressAppFramework/118046/application-shell-and-base-infrastructure/application-solution-components/modules?v=22.1#modules-shipped-with-xaf)  In this tutorial section, you will learn how to add and use these features in your applications. The following lessons are recommended:

-   [Attach Files to Objects](https://docs.devexpress.com/eXpressAppFramework/112763/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/attach-files-to-objects?v=22.1)
-   [Provide Several View Variants for End-Users](https://docs.devexpress.com/eXpressAppFramework/112765/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/provide-several-view-variants-for-end-users?v=22.1)
-   [Audit Object Changes](https://docs.devexpress.com/eXpressAppFramework/112766/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/audit-object-changes?v=22.1)
-   [Highlight List View Objects](https://docs.devexpress.com/eXpressAppFramework/112854/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/highlight-list-view-objects?v=22.1)
-   [Analyze Data](https://docs.devexpress.com/eXpressAppFramework/113023/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/analyze-data?v=22.1)
-   [Create a Report in Visual Studio](https://docs.devexpress.com/eXpressAppFramework/112734/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/create-a-report-in-visual-studio?v=22.1)
-   [Create a Report at Runtime](https://docs.devexpress.com/eXpressAppFramework/113644/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/create-a-report-at-runtime?v=22.1)
-   [Add the Scheduler Module](https://docs.devexpress.com/eXpressAppFramework/113040/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/add-the-scheduler-module?v=22.1)
-   [Add Validation Rules to Business Classes](https://docs.devexpress.com/eXpressAppFramework/113041/getting-started/in-depth-tutorial-winforms-webforms/extra-modules/add-validation-rules-to-business-classes?v=22.1)



# Attach Files to Objects (.NET Framework)


>TIP
For **.NET 6** applications, see: [Attach Files to Objects (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/403288/getting-started/in-depth-tutorial-blazor/additional-modules/attach-files-to-objects?v=22.1).

In this lesson, you will learn how to attach file collections to business objects. For this purpose, the  **File Attachment**  module will be added to the application, and the new  **Resume**  and  **PortfolioFileData**  business classes will be implemented. The  **Resume**  class will be used to store and manage a  **Contact**‘s resume information: a file data collection and a reference to a  **Contact**. The  **PortfolioFileData**  class will represent the file data collection item. You will also learn how the file data type properties are displayed and managed in a UI.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Implement Custom Business Classes and Reference Properties](https://docs.devexpress.com/eXpressAppFramework/112732/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-custom-business-classes-and-reference-properties-xpo?v=22.1)
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Set a One-to-Many Relationship](https://docs.devexpress.com/eXpressAppFramework/112733/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/set-a-one-to-many-relationship-xpo?v=22.1)

-   Add the  **File Attachments**  module to your WinForms module project. For this purpose, find the  _WinModule.cs_  (_WinModule.vb_) file in the  **MySolution.Module.Win**  project displayed in the  **Solution Explorer**. Double-click this file to invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). In the  **Toolbox**, expand the  **DX.22.1: XAF Modules**  tab. Drag the  **FileAttachmentsWindowsFormsModule**  item to the Designer’s  **Required Modules**  section.
    
    ![Tutorial_EM_Lesson1_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson1_0115637.png?v=22.1)
    
-   Add the  **File Attachments**  module to your ASP.NET Web Forms module project. For this purpose, find the  _WebModule.cs_  (_WebModule.vb_) file in the  **MySolution.Module.Web**  project displayed in the Solution Explorer. Double-click this file to invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). In the  **Toolbox**, expand the  **DX.22.1: XAF Modules**  tab. Drag the  **FileAttachmentsAspNetModule**  item to the Designer’s  **Required Modules**  section.
    
    ![Tutorial_EM_Lesson1_0_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson1_0_1116428.png?v=22.1)
    
-   After you have made changes in the  **Module Designer**, rebuild your solution.
-   Add a new  **Resume**  business class, as described in the  [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)  lesson.
-   Replace the automatically generated  **Resume**  class declaration with the following code.
    

    
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
    
    Declare the  **PortfolioFileData**  class, which is the  **FileAttachmentBase**  descendant, and  **DocumentType**  enumeration as follows.
    

    
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
    
    In the code above, you can see that the  **Resume**  and  **PortfolioFileData**  classes are related with a One-to-Many relationship. Another important point is that in XPO, the  **PortfolioFileData.DocumentType**  property is initialized in the  **AfterConstruction**  method, which is called after creating the corresponding object.
    
    Refer to the  [File Attachment Properties in XPO](https://docs.devexpress.com/eXpressAppFramework/113549/business-model-design-orm/data-types-supported-by-built-in-editors/file-attachment-properties/file-attachment-properties-in-xpo?v=22.1)  topic to learn more about file attachment properties creation.
    
-   Run the WinForms or ASP.NET Web Forms application and create a new  **Resume**  object.
-   To specify the  **File**  property, attach a file in the  **Open**  dialog, invoked via the  **Add From File…**  (![btn_attach](https://docs.devexpress.com/eXpressAppFramework/images/btn_attach117501.png?v=22.1)) button.
    
    ![Tutorial_EM_Lesson1_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson1_1115519.png?v=22.1)
    
-   To open or save a file attached to the  **Portfolio**  collection, or add a new file, use the  **Open…**,  **Save As…**  or  **Add From File…**  Actions supplied with the collection.
    
    ![Tutorial_EM_Lesson1_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson1_3115521.png?v=22.1)
    

>TIP
To save the file stored within the current **FileData** object to the specified stream, use the [IFileData.SaveToStream](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.IFileData.SaveToStream(System.IO.Stream)?v=22.1) method.

You can see the code demonstrated here in the  _Resume.cs_  (_Resume.vb_) file of the  **Main Demo**  installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Provide Several View Variants for End-Users (.NET Framework)


>TIP
For **.NET 6** applications, see: [Create Multiple View Variants (.NET 6)](https://docs.devexpress.com/eXpressAppFramework/403380/getting-started/in-depth-tutorial-blazor/additional-modules/create-multiple-view-variants?v=22.1).

In this lesson, you will learn how to provide several customized variants of the same  **View**, and allow an end-user to choose a desired  **View**  variant at runtime. Variants can be applied to both  **List Views**  and  **Detail Views**. In this lesson, the  **Contact List View**  will be used. Two variants of this  **List View**  will be constructed via the  **Module Editor**. To switch between these  **View**  variants, the special  **ChangeVariant**  Action will be used. To add this Action, the  **ViewVariants**  module will be referenced in the application.

>NOTE
Before proceeding, take a moment to review the following lessons:
>-   [Inherit from the Business Class Library Class](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1)
>-   [Change Field Layout and Visibility in a List View](https://docs.devexpress.com/eXpressAppFramework/112746/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/change-field-layout-and-visibility-in-a-list-view?v=22.1)

-   Add the  **View Variants**  module to your  **MySolution.Module**  project. Find the  _Module.cs_  (_Module.vb_) file in the  **MySolution.Module**  project displayed in the  **Solution Explorer**, and double-click this file. The  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  will be invoked. In the  **Toolbox**, navigate to the  **DX.22.1: XAF Modules**  tab. Drag the  **ViewVariantsModule**  item from this tab to the Designer’s  **Required Modules**  section.
    
    ![Tutorial_EM_Lesson2_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_0115638.png?v=22.1)
    
-   Rebuild your solution so that the changes made in the  **Module Designer**  are loaded to the  **Application Model**.
-   Invoke the  [Model Editor](https://docs.devexpress.com/eXpressAppFramework/112582/ui-construction/application-model-ui-settings-storage/model-editor?v=22.1)  for the  **MySolution.Module**  project. Right-click the  **Views**  node and select  **Add…**  |  **ListView**.
    
    ![Tutorial_EM_Lesson2_0_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_0_1116430.png?v=22.1)
    
    For the new node, set the  **Id**  property to “Contact_ListView_AllColumns” and the  **ModelClass**  property to “Contact”.
    
    ![Tutorial_EM_Lesson2_0_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_0_2116431.png?v=22.1)
    
-   Right-click the newly created node and select  **Generate content**. Columns will be generated using information on the specified class (**BOModel**  |  **Contact**  node) and its ancestors. Leave these columns as is. This  **List View**  will represent the complete variant for the  **Contact**  List View.
    
    ![Tutorial_EM_Lesson2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_1115525.png?v=22.1)
    
-   Right-click the  **Views**  node and select  **Add…**  |  **ListView**. For the new node, set the  **Id**  property to “Contact_ListView_Varied” and the  **ModelClass**  property to “Contact”. Do not generate content for the new node.
    
    ![Tutorial_EM_Lesson2_2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_2_1116617.png?v=22.1)
    
-   Expand the newly added  **Contact_ListView_Varied**  node, right-click the  **Variants**  child node and select  **Add…**  |  **Variant**.
    
    ![Tutorial_EM_Lesson2_2_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_2_2116618.png?v=22.1)
    
-   For the new node, set the  **View**  property to “Contact_ListView”, and set the  **Id**  and  **Caption**  properties to “Few columns”.
    
    ![Tutorial_EM_Lesson2_2_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_2_3116619.png?v=22.1)
    
-   Right-click the  **Variants**  node and select  **Add…**  |  **Variant**. For the new node, set the  **View**  property to “Contact_ListView_AllColumns”, and set the  **Id**  and  **Caption**  properties to “All columns”.
    
    ![Tutorial_EM_Lesson2_2_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_2_4116620.png?v=22.1)
    
-   Navigate to the  **NavigationItems** | **Items** | **Default** | **Items**  |  **Contact**  node. Its  **View**  property, specifying the View displayed when choosing the  **Contact**  navigation item, is “Contact_ListView” by default. Change it to “Contact_ListView_Varied”.
    
    ![Tutorial_EM_Lesson2_2_5](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_2_4116621.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. Select the  **Contact**  item in the navigation control. For the displayed  **Contact**  List View, the  **ChangeVariant**  Action will be activated. This Action’s items represent the view variants specified in the  **Model Editor**.
    
    ![Tutorial_EM_Lesson2_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_3115524.png?v=22.1)
    
    >NOTE
    You can use the **Index** property to specify the sort order of variants in the **ChangeVariant** Action drop-down list. Additionally, you can set the **Current** property of the **Variants** node to specify the default variant.
    
-   Optionally, you can add view variants to the navigation control. For this purpose, invoke the Model Editor and set the  **GenerateRelatedViewVariantsGroup**  property of the  **NavigationItems**  node to  **true**.
    
    ![Tutorial_EM_Lesson2_5](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_5117208.png?v=22.1)
    
    >NOTE
    Ensure that the [IModelChoiceActionItemChildItemsDisplayStyle.ChildItemsDisplayStyle](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Model.IModelChoiceActionItemChildItemsDisplayStyle.ChildItemsDisplayStyle?v=22.1) property of the current navigation group node is set to **List** (see [Change Style of Navigation Items](https://docs.devexpress.com/eXpressAppFramework/113474/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/change-style-of-navigation-items?v=22.1)). Otherwise, the view variants will not be added to the navigation control in the WinForms application.
    
    As a result, the  **Contact**  navigation item will expose child items for each view variant.
    
    ![Tutorial_EM_Lesson2_6](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson2_6117209.png?v=22.1)
    

You can see the changes made in this lesson in the  **Model Editor**  invoked for the  _Model.DesignedDiffs.xafml_  file, located in the  **Main Demo**  |  **MainDemo.Module**  project. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Audit Object Changes (.NET Framework)


In this lesson, you will learn how to audit and analyze the changes that are made to business objects while running the application. For this purpose, the  **Audit Trail**  module will be added to the application. Changes made to the  **Contact**  object will be audited. Two techniques to analyze them will be used.

>NOTE
Before proceeding, take a moment to review the [Inherit from the Business Class Library Class (XPO)](https://docs.devexpress.com/eXpressAppFramework/112718/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/inherit-from-the-business-class-library-class-xpo?v=22.1) lesson.

## Audit Contact Objects

Add the  **AuditTrail**  module to your  **MySolution.Module**  project. For this purpose, find the  _Module.cs_  (_Module.vb_) file in the  **MySolution.Module**  project displayed in the  **Solution Explorer**. Double-click this file to invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). In the  **Toolbox**, expand the  **DX.22.1: XAF Modules**  tab. Drag the  **AuditTrailModule**  item to the Designer’s  **Required Modules**  section.

![Tutorial_EM_Lesson4_0](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson4_0116433.png?v=22.1)

Now, all objects that are created in the application are audited. The  **Audit Trail System**  logs information on the change type (object was created, changed, etc.), who made this change, the object that was changed, the previous and new property values, etc. When an object is saved to the database, any changes between two sequential events are registered.

## Analyze Audit Log in the Application

Use the following approach to view object changes directly in the application.

-   Add a collection property to the  **Contact**  class. The collection’s items will provide log information retrieved from the database.
    

    
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
    
-   Run the WinForms or ASP.NET Web Forms application and invoke a  **Contact**  Detail View. Modify the  **Contact**  object to test the auditing capability, save the changes and click  **Refresh**  (![btn_refresh](https://docs.devexpress.com/eXpressAppFramework/images/btn_refresh117427.png?v=22.1)). The  **Change History**  collection will contain information on the previous  **Contact**  object changes.
    
    ![Tutorial_EM_Lesson4_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson4_1115536.png?v=22.1)
    

>NOTE
As you may remember, the **Office** property is declared in the **Department** class, not the **Contact** class. So, changes to the **Office** property made using the **Contact** Detail View are not displayed in the **Contact**‘s Change History. Instead, these changes appear in the corresponding **Department** object’s **Change History** (if changes made to the **Department** objects are audited). You can acquire the audit log remotely using SQL queries to your database. See the [Analyze the Audit Log](https://docs.devexpress.com/eXpressAppFramework/113615/data-security-and-safety/audit-trail/audit-trail-xpo/analyze-the-audit-log?v=22.1) topic.

You can view the code demonstrated here in the  _Contact.cs_  (_Contact.vb_) file of the  **Main Demo**  installed with XAF. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Highlight List View Objects (.NET Framework)


In this lesson, you will learn how to format data that satisfies the specified criteria. For this purpose, the  [Conditional Appearance](https://docs.devexpress.com/eXpressAppFramework/113286/conditional-appearance?v=22.1)  module will be added to the application. You will highlight the  **DemoTask**  objects whose  **Status**  property is not set to  **Completed**. In addition, you will highlight the  **Priority**  property when it contains the  **High**  value.

-   Add the  **Conditional Appearance**  module to your  **MySolution.Module**  project. For this purpose, double-click the  _Module.cs_  (_Module.vb_) file, located in the  **MySolution.Module**  project. The  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  will be invoked. In the  **Toolbox**, navigate to the  **DX.22.1: XAF Modules**  tab, and drag the  **ConditionalAppearanceModule**  item from this tab to the Designer’s  **Required Modules**  section, as shown below.
    
    ![Tutorial_EM_Lesson_5_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_5_1115688.png?v=22.1)
    
-   Rebuild your solution after you have made changes in the  **Module Designer**.
-   To declare a conditional appearance rule for the  **DemoTask**  class, apply the  [AppearanceAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute?v=22.1)  attribute to this class. As the first parameter, specify the  **Appearance Rule identifier**  (e.g., “FontColorRed”). Then, specify the following parameters.
    
    ![image](https://github.com/jjcolumb/In-Depth-XAF-WinForms-WebForms-Tutorial/assets/126447472/6a2f9861-a7cb-4c8a-a8d1-b2877eda6979)

    
    The following code demonstrates the applied attribute and its parameters to the  **DemoTask**  class, that was declared in  _BusinessObjects_\_DemoTask.cs_  (_DemoTask.vb_) file.
    

    ```csharp
    using DevExpress.ExpressApp.ConditionalAppearance;
    // ...
    [Appearance("FontColorRed", AppearanceItemType = "ViewItem", TargetItems = "*", Context = "ListView",
        Criteria = "Status!='Completed'", FontColor = "Red")]
    public class DemoTask : Task {
        // ...
    }
    
    ```
    
    >NOTE
    The **Criteria** value must be specified using the [Criteria Language Syntax](https://docs.devexpress.com/CoreLibraries/4928/devexpress-data-library/criteria-language-syntax?v=22.1).
    
-   Apply the  [AppearanceAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute?v=22.1)  attribute to the  **DemoTask**  class’  **Priority**  property. As the first positional parameter, specify the  **Appearance Rule identifier**  (e.g., “PriorityBackColorPink”). Then, specify the following parameters.
    
    -   _Specify the target UI elements to be affected by the rule_
        
        Set the  [AppearanceAttribute.AppearanceItemType](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute.AppearanceItemType?v=22.1)  parameter to “ViewItem”. This means that the rule generated from the attribute will affect the  **Priority**  property displayed in the current  **View**.
        
    -   _Specify the conditions under which the rule must be in effect_
        
        Set the  [AppearanceAttribute.Context](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute.Context?v=22.1)  parameter to “Any” and the  [AppearanceAttribute.Criteria](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute.Criteria?v=22.1)  parameter to “Priority=2”. In this instance, the rule generated from the attribute will affect the  **Priority**  property when it is set to 2 (**High**) in any  **DemoTask**  View.
        
    -   _Specify the conditional appearance applied by the rule_
        
        Set the  [AppearanceAttribute.BackColor](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ConditionalAppearance.AppearanceAttribute.BackColor?v=22.1)  parameter to “255, 240, 240”.
        
    
    The following code demonstrates the applied attribute and its parameters.
    

    
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
    
-   Run the WinForms or ASP.NET Web Forms application. The  **DemoTask**  List View and Detail View data will be highlighted, as demonstrated in the following image.
    
    ![Tutorial_EM_Lesson_5_7](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_5_7116957.png?v=22.1)
    

>NOTE
**Appearence Rules** that are declared in code are available in the **Model Editor**. To access them, you can run the **Model Editor** for the **MySolution.Module** project. Navigate to the **BOModel** | **DemoTask** | **AppearanceRules** node. This node has two child nodes (**FontColorRed** and **PriorityBackColorPink**) that are generated automatically from **Appearance** attributes applied to the **DemoTask** class and the **DemoTask.Priority** property. You can create new **Appearance Rules** directly in the **Model Editor** by adding child nodes to the **AppearanceRules** node.

You can see the changes made in the lesson in the  _DemoTask.cs_  (_DemoTask.vb_) file located in the  **MainDemo.Module**  project of the  **MainDemo**  solution. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Analyze Data (.NET Framework)


In this lesson, you will learn how to add the  **Analysis**  functionality to your application. For this purpose, you will add the  **Analysis**  business class and the  [Pivot Chart Module](https://docs.devexpress.com/eXpressAppFramework/113024/analytics/pivot-chart-module?v=22.1)  to your application.

-   Add the  **Analysis**  business class to your  **MySolution.Module**  project using the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). Invoke it by double-clicking the  _Module.cs_  (_Module.vb_) file within the  **MySolution.Module**  project displayed in the  **Solution Explorer**. In the  **Exported Types**  section, locate the  **Referenced Assemblies**  |  **DevExpress.Persistent.BaseImpl.v22.1**  |  **Analysis**  node. Select it and press the  **Spacebar**, or right-click it and choose  **Use Type in Application**  in the invoked menu. The node will be marked in bold. This means that the  **Analysis**  business class will be added to the  [Application Model](https://docs.devexpress.com/eXpressAppFramework/112748/getting-started/in-depth-tutorial-winforms-webforms/ui-customization?v=22.1), and this class will take part in the UI construction process.
    
    ![Tutorial_EM_Lesson_6_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_1115996.png?v=22.1)
    
-   Rebuild your solution so that the changes made in the  **Designer**  are loaded to the  **Application Model**.
-   The  **eXpressApp Framework**  provides the  [Pivot Chart Module](https://docs.devexpress.com/eXpressAppFramework/113024/analytics/pivot-chart-module?v=22.1). When this module is referenced, the  **Self**  property of the  **Analysis**  Detail View is displayed via a special  **Property Editor**. In WinForms applications, this  **Property Editor**  uses the  **PivotGridControl**  supplied by the  [Pivot Grid](https://docs.devexpress.com/WindowsForms/3409/controls-and-libraries/pivot-grid?v=22.1)  library and the  **ChartControl**  from the  [Chart Control](https://docs.devexpress.com/WindowsForms/8117/controls-and-libraries/chart-control?v=22.1)  library. In ASP.NET Web Forms applications, this  **Property Editor**  uses the  **ASP.NET Web Forms Pivot Grid**  that is supplied by the  [ASP.NET Web Forms Pivot Grid](https://docs.devexpress.com/AspNet/5830/components/pivot-grid?v=22.1)  library, and the  **WebChartControl**  from the  [Chart Control](https://docs.devexpress.com/WindowsForms/8117/controls-and-libraries/chart-control?v=22.1)  library. These controls allow end-users to build summarized reports to analyze large quantities of data quickly and easily. Features like filtering, top value display, hierarchical value arrangement on the axes, and grand and group totals give end-users a wide range of tools to control the data level in detail.
    
    To use the  **Pivot Chart Module**  in a WinForms application, add it to the WinForms module project. For this purpose, find the  _WinModule.cs_  (_WinModule.vb_) file in the  **MySolution.Module.Win**  project displayed in the Solution Explorer. Double-click this file. The  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  will be invoked. In the  **Toolbox**, navigate to the  **DX.22.1: XAF Modules**  page. Drag the  **PivotChartWindowsFormsModule**  item to the Designer’s  **Required Modules**  section. Build the project.
    
    ![Tutorial_EM_Lesson_6_2_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_2_1116438.png?v=22.1)
    
    To use the  **Pivot Chart Module**  in the ASP.NET Web Forms application, add it to the ASP.NET Web Forms module project. For this purpose, double-click the  _WebModule.cs_  (_WebModule.vb_) file, located in the  **MySolution.Module.Web**  application project. The  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  will be invoked. In the  **Toolbox**, navigate to the  **DX.22.1: XAF Modules**  tab, and drag the  **PivotChartAspNetModule**  item to the Designer’s  **Required Modules**  section. Build the project.
    
    ![Tutorial_EM_Lesson_6_2_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_2_2116439.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. In the navigation control, select the  **Reports**  |  **Analysis**  item. An empty  **Analysis**  object list will be displayed (called  **Analysis**  List View). Create a new  **Analysis**  object by clicking the  **New**  button. In the invoked  **Detail View**, specify a name for the new  **Analysis**  object and the type of objects to be analyzed via a pivot grid and chart control. For instance, assign the “Tasks” value to the  **Name**  property and choose “Task” in the  **Data Type**  drop-down menu. Click  **Bind Analysis Data**  (![Bind Analysis Data](https://docs.devexpress.com/eXpressAppFramework/images/bind-analysis-data116074.png?v=22.1)).  **Task**  objects will be loaded as the data source for the pivot grid.
    
    ![Tutorial_EM_Lesson_6_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_3116037.png?v=22.1)
    
-   Drag the required fields to the row, column and data areas.
    
    ![Tutorial_EM_Lesson_6_3_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_3_1116440.png?v=22.1)
    
    The following configuration demonstrates how to find out how many tasks are assigned to a contact.
    
    ![Tutorial_EM_Lesson_6_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_4116038.png?v=22.1)
    
-   Switch to the  **Chart**  tab. It displays the data configured in the pivot grid via a chart.
    
    ![Tutorial_EM_Lesson_6_5](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_5116039.png?v=22.1)
    
-   In WinForms applications, you can specify the chart’s settings using the  **ChartWizard**  Action invoked by right-clicking the chart image and choosing  **ChartWizard**.
    
    ![Tutorial_EM_Lesson_6_7_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_7_1116442.png?v=22.1)
    
    In ASP.NET Web Forms applications, you can only set the chart type using the  **ChartType**  combo box.
    
    ![Tutorial_EM_Lesson_6_13](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_13116046.png?v=22.1)
    

The following configurations demonstrate how fields in the pivot grid can be reconfigured based on what you are trying to analyze.

_How many tasks of a particular priority are completed_.

![Tutorial_EM_Lesson_9_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_9_1116080.png?v=22.1)

_How many tasks of a particular priority are assigned to a contact_.

![Tutorial_EM_Lesson_6_8](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_8116041.png?v=22.1)

_How many estimated and actual hours each contact has spent on implementing all tasks assigned to that contact_.

![Tutorial_EM_Lesson_6_10](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_10116043.png?v=22.1)

_How many hours of work are planned for a contact and how many hours a contact has already spent on the completed tasks_.

![Tutorial_EM_Lesson_6_11](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_11116044.png?v=22.1)

_The previous analysis is extended by showing the distribution based on task priority_.

![Tutorial_EM_Lesson_6_12](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_12116045.png?v=22.1)

>NOTE
The images above illustrate how to build an analysis in a WinForms application, but you can follow the same steps in an ASP.NET Web Forms application.

When an  **Analysis**  object is displayed in a Detail View, the  **Export**  button can be used to export the Pivot Grid or Chart to a number of formats.

![Tutorial_EM_Lesson_6_14](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_em_lesson_6_14116814.png?v=22.1)

The  **Export**  Action is available in both WinForms and ASP.NET Web Forms applications.

The  **Print PivotGrid**  (![btn_pivot_print](https://docs.devexpress.com/eXpressAppFramework/images/btn_pivot_print117503.png?v=22.1)) and  **Print Chart**  (![btn_chart_print](https://docs.devexpress.com/eXpressAppFramework/images/btn_chart_print117502.png?v=22.1)) actions can be used to print the Pivot Grid and the Chart. These Actions are not available in an ASP.NET Web Forms application.

You can see the analysis demonstrated above in the  **Main Demo**. The  **MainDemo**  application is installed in  _%PUBLIC%\Documents\DevExpress Demos  22.1\Components\XAF\MainDemo_  by default. The ASP.NET Web Forms version is available online at  [https://demos.devexpress.com/XAF/MainDemo](https://demos.devexpress.com/XAF/MainDemo/Login.aspx).


# Create a Report in Visual Studio (.NET Framework)

In this lesson, you will learn how to create reports in the integrated reporting system. This system is based on the DevExpress  [Reporting](https://docs.devexpress.com/XtraReports/2162/reporting?v=22.1)  library for WinForms and ASP.NET Web Forms. This lesson will guide you through creating a report that shows a list of  **Contact**  objects with their names and email addresses. Report will be available to end-users in both WinForms and ASP.NET Web Forms applications.

## Adding XAF Modules

-   Add the platform-independent  [Reports V2](https://docs.devexpress.com/eXpressAppFramework/113591/shape-export-print-data/reports/reports-v2-module-overview?v=22.1)  module to your project. To do this, double-click the  _Module.cs_  (_Module.vb_) file in the  **MySolution.Module**  project. This will invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). In the  **Toolbox**, navigate to the  **DX.22.1: XAF Modules**  group. Drag the  **ReportsModuleV2**  item from this group to the Designer’s  **Required Modules**  section.
    
    ![ReportsV2_to_Module_cs](https://docs.devexpress.com/eXpressAppFramework/images/reportsv2_to_module_cs117429.png?v=22.1)
    
-   Add a WinForms-specific  **Reports V2**  module to your WinForms module project. Double-click the  _WinModule.cs_  (_WinModule.vb_) file in the  **MySolution.Module.Win**  project. This will invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). In the  **Toolbox**, navigate to the  **DX.22.1: XAF Modules**  group. Drag the  **ReportsWindowsFormsModuleV2**  item from this group to the Designer’s  **Required Modules**  section.
    
    ![ReportsV2_to_WinApp_cs](https://docs.devexpress.com/eXpressAppFramework/images/reportsv2_to_winapp_cs117430.png?v=22.1)
    
-   Add the ASP.NET Web Forms-specific  **Reports V2**  module to your ASP.NET Web Forms application project. Invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  by double-clicking the  _WebModule.cs_  (_WebModule.vb_) file in the  **MySolution.Module.Web**  project. In the  **Toolbox**, navigate to the  **DX.22.1: XAF Modules**  group. Drag the  **ReportsAspNetModuleV2**  item from this group to the Designer’s  **Required Modules**  section.
    
    ![ReportsV2_to_WebApp_cs](https://docs.devexpress.com/eXpressAppFramework/images/reportsv2_to_webapp_cs117431.png?v=22.1)
    
-   Rebuild your solution.

## Design-Time Reporting

-   Right-click the  **MySolution.Module**  project and select  **Add**  |  **New Folder**. Set the name of the new folder to “Reports”. Right-click the  **Reports**  folder and select  **Add**  |  **New Item**.
    
    ![New_Report](https://docs.devexpress.com/eXpressAppFramework/images/new_report117433.png?v=22.1)
    
    >NOTE
    You can place reports in any folder (including the root project folder), although it is recommended that you organize your project files.
    
-   Select the  **DevExpress v22.1  Report**, name it “ContactsReport” and click  **Add**.
    
    ![New_Report_Dialog](https://docs.devexpress.com/eXpressAppFramework/images/new_report_dialog117434.png?v=22.1)
    
-   This invokes the  [Report Wizard](https://docs.devexpress.com/XtraReports/4254/visual-studio-report-designer/report-wizard?v=22.1). Select  **Blank**  and click  **Finish**.
    
    ![XtraReport_Wizard](https://docs.devexpress.com/eXpressAppFramework/images/xtrareport_wizard117445.png?v=22.1)
    
    >NOTE
    Do not use report types other than **Blank**. Other report types will not allow you to select an XAF-specific data source. You will be able to proceed with the **Report Wizard** later, after the data source is selected in the **Report Designer**.
    
-   After clicking  **Finish**, the  [Report Designer](https://docs.devexpress.com/XtraReports/4257/winforms-reporting/end-user-report-designer-for-winforms/api-and-customization?v=22.1)  is invoked. In the  **Toolbox**, navigate to the  **DX.22.1: XAF Data Sources for Reports**  group. Drag the  **CollectionDataSource**  item from this group to the  **Report Designer**  window.
    
    ![CollectionDataSource_to_Report](https://docs.devexpress.com/eXpressAppFramework/images/collectiondatasource_to_report117436.png?v=22.1)
    
-   In the  [Report Explorer](https://docs.devexpress.com/XtraReports/4258/visual-studio-report-designer/dock-panels/report-explorer?v=22.1)  window, select the  **collectionDataSource1**  item. In the  **Properties**  window, assign the “MySolution.Module.BusinessObjects.Contact” value to the  **ObjectTypeName**  property. Note the changes in the  [Field List](https://docs.devexpress.com/XtraReports/4259/visual-studio-report-designer/dock-panels/field-list?v=22.1)  window - the fields of the  **Contact**  class are now available if you expand the  **collectionDataSource1**  node.
    
    ![DataSource_Populate](https://docs.devexpress.com/eXpressAppFramework/images/datasource_populate117437.png?v=22.1)
    
-   Click the  **Report Designer**‘s  [Smart Tag](https://docs.devexpress.com/XtraReports/4260/detailed-guide-to-devexpress-reporting/use-report-controls/manipulate-report-controls?v=22.1)  and select  **Design in Report Wizard…**  in the invoked menu.
    
    ![Report_Designer-Smart_Tag](https://docs.devexpress.com/eXpressAppFramework/images/report_designer-smart_tag117446.png?v=22.1)
    
-   This invokes the  [Report Wizard](https://docs.devexpress.com/XtraReports/4241/visual-studio-report-designer/data-source-wizard/connect-to-a-database?v=22.1). In the first step, you should select the  **Table Report**  and click  **Next**. Since the data source is already specified, you will skip some wizard screens and the second step will allow you to choose the report data.
    
    ![Report_Designer0](https://docs.devexpress.com/eXpressAppFramework/images/report_designer0117505.png?v=22.1)
    
-   Select the fields that to be used within your report. Check the  **collectionDataSource1**  data member on the left and the following data fields on the right:
    
    -   **FirstName**
    -   **LastName**
    -   **Email**
    
    Click  **Next**  when finished.
    
    ![Report_Wizard_1](https://docs.devexpress.com/eXpressAppFramework/images/report_wizard_1117447.png?v=22.1)
    
-   Select the fields by which to group the report rows. Since grouping is not required in this example, click  **Next**  to continue.
    
    ![Report_Wizard_2](https://docs.devexpress.com/eXpressAppFramework/images/report_wizard_2117448.png?v=22.1)
    
-   In the next step, you can customize the report page. Stay these settings unchanged and click  **Next**.
    
    ![Report_Wizard_4](https://docs.devexpress.com/eXpressAppFramework/images/report_wizard_4117450.png?v=22.1)
    
-   Choose a report color scheme, for example,  **Azure**, and click  **Next**.
    
    ![Report_Wizard_ColorScheme](https://docs.devexpress.com/eXpressAppFramework/images/report_wizard_colorscheme.png?v=22.1)
    
-   In the final step, you can set the report’s title. This text will be displayed at the top of your report. Set the title to “Contacts” and click  **Finish**.
    
    ![Report_Wizard_5](https://docs.devexpress.com/eXpressAppFramework/images/report_wizard_5117451.png?v=22.1)
    
-   The report structure you created will be displayed in the  **Report Designer**. Customize and save the report.
    
    ![Report_Structure](https://docs.devexpress.com/eXpressAppFramework/images/report_structure117453.png?v=22.1)
    
    >NOTE
    At design time, the Preview tab of the Report Designer is empty. The [CollectionDataSource](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ReportsV2.CollectionDataSource?v=22.1) and [ViewDataSource](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.ReportsV2.ViewDataSource?v=22.1) components do not connect to a database directly and require an [IObjectSpace](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.IObjectSpace?v=22.1) instance (that can be created at runtime only) to load data. Thus, it cannot load data at design time.
    
-   Now register the report within your XAF application using the  [PredefinedReportsUpdater](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ReportsV2.PredefinedReportsUpdater?v=22.1)  class. To do this, in the  **Solution Explorer**, right-click the  _MySolution.Module_  |  _Module.cs_  (_Module.vb_) file and select  **View Code**  to edit its source code. The code snippet below demonstrates the required changes.
    

    
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
    
-   Run the WinForms or ASP.NET Web Forms application, navigate to  **Reports**  and open the  **Contacts Report**.
    
    ![ReportV2_OK](https://docs.devexpress.com/eXpressAppFramework/images/reportv2_ok117439.png?v=22.1)
    
    ![ReportV2_Web_OK](https://docs.devexpress.com/eXpressAppFramework/images/reportv2_web_ok117440.png?v=22.1)
    

>NOTE
>-   Predefined reports are not editable at runtime, but you can edit a copy of a report (see [Modify an Existing Report](https://docs.devexpress.com/eXpressAppFramework/113647/shape-export-print-data/reports/modify-an-existing-report?v=22.1)).
>-   Report data can be [sorted](https://docs.devexpress.com/eXpressAppFramework/113595/shape-export-print-data/reports/data-sorting-in-reports-v2?v=22.1) and [filtered](https://docs.devexpress.com/eXpressAppFramework/113594/filtering/in-reports/data-filtering-in-reports?v=22.1) according to a parameter defined by the end-user.



# Create a Report at Runtime (.NET Framework)


In this lesson, you will learn how to create reports at runtime. A report showing a list of  **Tasks**  will be created in the WinForms application at runtime and then will be available for printing in both WinForms and ASP.NET Web Forms applications.

>TIP
You can also create a new report in an ASP.NET Web Forms application (see [Create and View Reports in an ASP.NET Web Forms Application](https://docs.devexpress.com/eXpressAppFramework/113648/shape-export-print-data/reports/create-and-view-reports-in-an-asp-net-application?v=22.1)).

1.  Run the WinForms application and go to the  **Reports**  List View.
    
    ![Reports_ListView](https://docs.devexpress.com/eXpressAppFramework/images/reports_listview117466.png?v=22.1)
    
2.  Create a new report by clicking the  **New**  button (![button_new](https://docs.devexpress.com/eXpressAppFramework/images/btn_new117411.png?v=22.1)).
3.  Name this report “Tasks Report”, set the  **Data Type**  to “Task” and click  **Next**.
    
    ![Reports_Wizars_1_Runtime](https://docs.devexpress.com/eXpressAppFramework/images/reports_wizars_1_runtime117467.png?v=22.1)
    
    >NOTE
    The **Data Type** drop-down list shows only those business classes that have the [DefaultClassOptionsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.DefaultClassOptionsAttribute?v=22.1) or [VisibleInReportsAttribute](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.VisibleInReportsAttribute?v=22.1) applied.
    
4.  Choose the “Table Report” type and click  **Next**.
    
5.  Add the following fields.
    
    -   Subject
    -   Priority
    -   Status
    -   Percent Completed
    
    ![Reports_Wizars_Fields_Runtime](https://docs.devexpress.com/eXpressAppFramework/images/reports_wizard_fields_runtime.png?v=22.1)
    

-   Click  **Next**  to skip the grouping configuration, summary functions, and report page settings.
-   Choose the  **Azure**  report color scheme and click  **Next**.
-   Set the title to “Tasks” and click  **Finish**.
-   After clicking  **Finish**, the  [Runtime Report Designer](https://docs.devexpress.com/XtraReports/1763/winforms-reporting/end-user-report-designer-for-winforms/gui/end-user-report-designer-with-a-standard-toolbar?v=22.1)  will be invoked.
    
    ![Runtime_Report_Designer](https://docs.devexpress.com/eXpressAppFramework/images/runtime_report_designer117458.png?v=22.1)
    
-   Customize the report, save it by clicking the  **Save**  button (![btn_report_save](https://docs.devexpress.com/eXpressAppFramework/images/btn_report_save117463.png?v=22.1)), and open it from the  **Reports**  List View. This report will also be available in the ASP.NET Web Forms version of the application.
    
    ![Runtime_Created_Report_Win](https://docs.devexpress.com/eXpressAppFramework/images/runtime_created_report_win117468.png?v=22.1)
    
    ![Report_OK_Web](https://docs.devexpress.com/eXpressAppFramework/images/report_ok_web117489.png?v=22.1)


# Add the Scheduler Module (.NET Framework)


>IMPORTANT
Scheduler requires the **Event** business class to be in your XAF application model. Follow the steps described in the [Add a Class from the Business Class Library](https://docs.devexpress.com/eXpressAppFramework/112721/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/add-a-class-from-the-business-class-library-xpo?v=22.1) lesson to learn how to add it.

The  **eXpressApp Framework (XAF)**  supplies the  [Scheduler module](https://docs.devexpress.com/eXpressAppFramework/112811/event-planning-and-notifications/scheduler-module?v=22.1). When this module is referenced, the  **Event**  List View is displayed via a special control. In WinForms applications, this control is supplied by the  [XtraScheduler Suite](https://www.devexpress.com/products/net/controls/winforms/scheduler/); in ASP.NET Web Forms applications, the control supplied by the  [ASPxScheduler Suite](https://www.devexpress.com/products/net/controls/asp/scheduler/)  is used. Both of these controls provide a number of features that will be helpful if you need to switch between different date views, use a date navigator and various appointment techniques, print and export source data, or customize the appearance. For details, refer to the  [ASP.NET Web Forms Scheduling Demos](https://demos.devexpress.com/ASPxSchedulerDemos/)  and the Scheduler’s  [Main Features](https://docs.devexpress.com/WindowsForms/1971/controls-and-libraries/scheduler?v=22.1)  topic. More examples of using XAF extra modules are provided in the  [Extra Modules](https://docs.devexpress.com/eXpressAppFramework/112770/getting-started/in-depth-tutorial-winforms-webforms/extra-modules?v=22.1)  section of this tutorial.

-   To use the Scheduler module in the WinForms application, add it to the WinForms module project. For this purpose, find the  _WinModule.cs_  (_WinModule.vb_) file in the  _MySolution.Module.Win_  application project displayed in the  **Solution Explorer**. Double-click this file to invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1). In the  **Toolbox**, navigate to the  **DX.22.1: XAF Modules**  section. Drag the  **SchedulerWindowsFormsModule**  item to the Designer’s  **Required Modules**  panel, and build the project.
    
    ![Tutorial_BMD_Lesson4_0_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson4_0_1116400.png?v=22.1)
    
    To use the Scheduler module in an ASP.NET Web Forms application, add it to the ASP.NET Web Forms module project. To do this, invoke the  [Module Designer](https://docs.devexpress.com/eXpressAppFramework/112828/installation-upgrade-version-history/visual-studio-integration/module-designer?v=22.1)  by double-clicking the  _WebModule.cs_  (_WebModule.vb_) file. Then, drag the  **SchedulerAspNetModule**  item from the  **Toolbox**  to the  **RequiredModules**  panel.
    
    ![Tutorial_BMD_Lesson4_0_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson4_0_2116401.png?v=22.1)
    
-   Run the WinForms or ASP.NET Web Forms application. Select the  **Scheduler Event**  item in the  **Navigation Control**. The  **Event**  object list (called the “Event List View”) will be displayed using the  **Scheduler**  control. You can create new  **Event**  objects by clicking the  **New**  (![btn_new](https://docs.devexpress.com/eXpressAppFramework/images/btn_new117411.png?v=22.1)) button on the toolbar. Alternatively, you can select an area in the timeline view, right-click it and choose  **New Appointment**.
    
    ![Tutorial_BMD_Lesson4_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson4_3115430.png?v=22.1)
    
    ![Tutorial_BMD_Lesson4_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_bmd_lesson4_4115966.png?v=22.1)
    

>NOTE
The new Event’s default start and end times correspond to the interval selected in the scheduler control. Additionally, you can create events with the **New** command in the control’s context menu.

>TIP
XAF has a special **Notifications** module that allows to set notifications for events. Refer to the [How to: Use Notifications with the Scheduler Event](https://docs.devexpress.com/eXpressAppFramework/113687/event-planning-and-notifications/how-to-use-notifications-with-the-scheduler-event?v=22.1) help topic to learn how to use it in your application.



# Add Validation Rules to Business Classes

To add validation functionality to your XAF application, follow the steps described in the  [Implement Property Value Validation in Code (XPO)](https://docs.devexpress.com/eXpressAppFramework/112736/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/implement-property-value-validation-in-code-xpo?v=22.1)  and  [Implement Property Value Validation in the Application Model](https://docs.devexpress.com/eXpressAppFramework/112750/getting-started/in-depth-tutorial-winforms-webforms/ui-customization/implement-property-value-validation-in-the-application-model?v=22.1)  lessons.


# Security System

The  **eXpressApp Framework**  provides the Security System used for securing business application data. In this tutorial section, you will learn how to use the Security System and its features. We offer the following lessons.

-   [Using the Security System](https://docs.devexpress.com/eXpressAppFramework/112768/getting-started/in-depth-tutorial-winforms-webforms/security-system/using-the-security-system?v=22.1)
-   [Access the Security System in Code](https://docs.devexpress.com/eXpressAppFramework/112769/getting-started/in-depth-tutorial-winforms-webforms/security-system/access-the-security-system-in-code?v=22.1)



# Using the Security System (.NET Framework)


In this lesson, you will learn how to use a  **Security System**  in the application. When you use this system, the  [SecurityStrategyComplex](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.SecurityStrategyComplex?v=22.1)  security strategy is applied to your application. According to this strategy, Users have  **Roles**, which in turn are characterized by a permission set. This topic will guide you through creating an administrator and a common user in code. The administrator will have a full-access permission set, and the user will have a limited permission set. You will see how the administrator can create  **Users**  and  **Roles**, specify  **Permissions**  for them, and then assign  **Roles**  to  **Users**  at runtime. You will also use the  [AuthenticationStandard](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.AuthenticationStandard?v=22.1)  authentication type to log on to the application.

>NOTE
Before proceeding, take a moment to review the following topics.
>-   [Create a Solution using the Wizard](https://docs.devexpress.com/eXpressAppFramework/112717/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/create-a-solution-using-the-wizard?v=22.1)
>-   [Supply Initial Data](https://docs.devexpress.com/eXpressAppFramework/112788/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/supply-initial-data-xpo?v=22.1)

## Active Directory Authentication

If you have followed the  [Create a Solution using the Wizard](https://docs.devexpress.com/eXpressAppFramework/112717/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/create-a-solution-using-the-wizard?v=22.1)  lesson, you have already enabled the Security System with the  [AuthenticationActiveDirectory](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.AuthenticationActiveDirectory?v=22.1)  authentication.

Invoke the Application Designer for the WinForms application and take a look at the Security section.

![Tutorial_SS_Lesson1_0_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ss_lesson1_0_2117014.png?v=22.1)

As you can see in the image above, a Complex Security Strategy and Active Directory authentication are used, and the  **CreateUserAutomatically**  property is set to  **true**. This means that a user object (**PermissionPolicyUser**) is created automatically when you first run the application. This object’s  **UserName**  property is set to your Active Directory account. You’ve got all permissions as the automatically created user type is an administrator. To see this user’s details at runtime, navigate to the User and MyDetails items in the navigation control.

![Tutorial_SS_Lesson1_0_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ss_lesson1_0_1117013.png?v=22.1)

Now, follow the Tutorial to learn how to change authentication type in your application.

## Standard Authentication

-   Invoke the Application Designer for the WinForms application. To use a standard authentication strategy, drag the  **AuthenticationStandard**  component from the  **DX.22.1: XAF Security**  Toolbox tab to the Designer’s  _Security_  section.
    
    ![Tutorial_SS_Lesson2_0_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ss_lesson2_0_1117017.png?v=22.1)
    
-   Invoke the  **Application Designer**  for the ASP.NET Web Forms application. Drag the  **AuthenticationStandard**  component from the  **DX.22.1: XAF Security**  Toolbox tab to the Designer’s  **Security**  section.

## Create Predefined Users and Roles in Code

-   Before running an application with  **Standard Authentication**  enabled, create several predefined  **Users**  and  **Roles**  business objects, and assign the  **Roles**  to  **Users**. This will allow you to logon and create more  **Users**  at runtime.
    
    The objects that should exist in the database while running the application are created in the  [ModuleUpdater.UpdateDatabaseAfterUpdateSchema](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater.UpdateDatabaseAfterUpdateSchema?v=22.1)  method in the  _MySolution.Module_  |  _DatabaseUpdate_  |  _Updater.cs_/_Updater.vb_  file (see the  [Supply Initial Data](https://docs.devexpress.com/eXpressAppFramework/112788/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/supply-initial-data-xpo?v=22.1)  topic).
    
    First, create  **Roles**. The following code demonstrates how to create an “Administrators”  **Role**.
    

    
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
    
    Here, the “Administrators” Role has full access to objects of all types, because its  [IPermissionPolicyRole.IsAdministrative](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.IPermissionPolicyRole.IsAdministrative?v=22.1)  property is set to  **true**.
    
    Now create a “Users”  **Role**  - a very basic  **Role**  that will have access to the current user object only. You can later extend this  **Role**‘s permission set in the UI using extension methods of the  [PermissionSettingHelper](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.PermissionSettingHelper?v=22.1)  class. See the following code.
    

    
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
    
    The following code demonstrates how to create Users.
    

    
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
    
    Finally, you will assign  **Roles**  to  **Users**.
    

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
    
    >NOTE
    More examples are provided in the [Client-Side Security (2-Tier Architecture)](https://docs.devexpress.com/eXpressAppFramework/113436/data-security-and-safety/security-system/security-tiers/2-tier-security-integrated-mode-and-ui-level?v=22.1) topic.
    
-   Run the WinForms or ASP.NET Web Forms application. The following logon window will be displayed in a WinForms application.
    
    ![Tutorial_SS_Lesson1_1](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ss_lesson1_1115528.png?v=22.1)
    
    The following window will be displayed in the ASP.NET Web Forms application.
    
    ![Tutorial_SS_Lesson1_5](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ss_lesson1_5115539.png?v=22.1)
    
    After the  **Log In**  button is clicked, the user’s credentials are authenticated and the application will run.
    

## Create a Role in a UI

Administrators, and other users with Role creation permission can create Roles as follows.

Select the  **Role**  item in the navigation control and click the  **New**  Action. In the invoked Detail View, set the name and permissions for the new Role.

![Tutorial_SS_Lesson2_2](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ss_lesson2_2115532.png?v=22.1)

With the  **Permission Policy**  property, you can assign “deny all”, “read only all” or “allow all” default permission policies for each role. For each operation, you can explicitly specify the Allow or Deny modifier or leave it blank. If the modifier is not specified, the permission is determined by the role’s permission policy.

## Create a User in a UI

Users who have permission to create Users can do the following.

Select the  **User**  item in the navigation control and click the  **New**  button. In the invoked Detail View, specify the  **User Name**  and assign one or more Roles.

![Tutorial_SS_Lesson2_3](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ss_lesson2_3115533.png?v=22.1)

>NOTE
Set the **Is Active** property to **false** if you need to temporarily prohibit the user from using the application.

To assign a password to a newly created user, click the  **Reset Password**  button. The assigned password should be passed to the user. A User will be able to change it when logging on for the first time.

![Tutorial_SS_Lesson2_4](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ss_lesson2_4115534.png?v=22.1)

>NOTE
This button is the **ResetPassword** Action, which is available to users who are allowed to modify User objects. This button is not available when the Active Directory authentication is used.

## My Details

The  **My Details**  navigation item is available for users who have read access to the current User object. This navigation item opens the current user details.

![SS_Complex_Win](https://docs.devexpress.com/eXpressAppFramework/images/ss_complex_win115679.png?v=22.1)

In an ASP.NET Web Forms application, it can also be opened by clicking the  **My Details**  link at the top-right corner of the page.

![MyDetailWeb](https://docs.devexpress.com/eXpressAppFramework/images/mydetailweb119982.png?v=22.1)

## Change Password

When the standard authentication type is used, the  **Change My Password**  button is available once the  **My Details**  Detail View is displayed. This button opens a dialog where a user can change the password.

![Tutorial_SS_Lesson2_5](https://docs.devexpress.com/eXpressAppFramework/images/tutorial_ss_lesson2_5115535.png?v=22.1)

>NOTE
This button is the **ChangePasswordByUser** Action that is not available if the Active Directory authentication is used. To change a password in this instance, end users can use the operating system’s standard tools (e.g., press **CTRL**+**ALT**+**DEL** and select **Change a password**).



# Access the Security System in Code


This lesson will guide you through using the  [SecurityStrategy](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Security.SecurityStrategy?v=22.1)  class to check whether or not a user has particular permission. The  [SetTask](https://docs.devexpress.com/eXpressAppFramework/112738/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-with-option-selection?v=22.1)  Action will be accessible to users who have permission to modify  **DemoTask**  objects.

>NOTE
Before proceeding, we recommend that you review the following lessons:
>>-   [Add an Action with Option Selection](https://docs.devexpress.com/eXpressAppFramework/112738/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-with-option-selection?v=22.1)

-   Open the  _TaskActionsController.cs_  (_TaskActionsController.vb_) file you created in the  [Add an Action with Option Selection](https://docs.devexpress.com/eXpressAppFramework/112738/getting-started/in-depth-tutorial-winforms-webforms/extend-functionality/add-an-action-with-option-selection?v=22.1)  lesson. Add the “using” directive and modify the  **Activated**  event handler as shown below.
    

    
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
    
    With the added code, the  **Set Task**  Action will be activated for users who have write permissions for the  **Priority**  and  **Status**  properties of the selected  **DemoTask**  objects.
    
-   Add a user who does not have permission to modify the  **DemoTask**  objects (see  [Using the Security System](https://docs.devexpress.com/eXpressAppFramework/112768/getting-started/in-depth-tutorial-winforms-webforms/security-system/using-the-security-system?v=22.1)). Run the application as this new user. The  **Set Task**  Action will not be visible when you display the Demo Task List View.
