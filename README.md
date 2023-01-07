# Entity-Framework-Code-First-Approach

In Code First approach, entities or classes are created first with the primary focus on the domain of an application. You can start creating classes and required properties, without designing the database that matches the entities. Then the Entity Framework creates the tables and database accordingly and when the code is run, the database is created. Code-First is mainly useful in Domain Driven Design. 

![code-first](https://user-images.githubusercontent.com/103368662/211147204-1acee567-7bc3-43d9-bb85-b874c0182975.png)

As you can see in the above figure, EF API will create the database based on your domain classes and configuration. This means you need to start coding first in C# or VB.NET and then EF will create the database from your code.

## Code-First Workflow

The following figure illustrates the code-first development workflow.

![dev-workflow](https://user-images.githubusercontent.com/103368662/211147394-f8612eff-3e10-4b51-8202-00238f35cbd0.jpg)

The development workflow in the code-first approach would be: 

**->** Create or modify domain classes

**->** configure these domain classes using Fluent-API or data annotation attributes

**->** Create or update the database schema using automated migration or code-based migration.

## Advantages and Disadvantages of Code First Approach

**Advantages**
- You can create a database and required tables from business entities
- It is recommended for small applications that does not involve extensive data processing
- You can specify the collections for eager loading and the serialization of data
- It provides full access over the code and you can do modifications easily in the code

**Disadvantages**

- You need to write the code related to the creation of database
- If there is any change in database after the creation, you need to do it in the business entity class of code and run the application to update the database or by using package manager console
- It is difficult to manage the database through code, therefore, it is not recommended in data extensive applications where you need to process large amount of data and have complex logics to builup or maintain the data
- Any manual changes will be lost if you update the code from application
