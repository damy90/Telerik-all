# Database Systems Homework
## 1.	What database models do you know?
Common logical data models for databases include:

◦	Hierarchical database model

◦	Network model

◦	Relational model

◦	Entity–relationship model

◦	Enhanced entity–relationship model

◦	Object model

◦	Document model

◦	Entity–attribute–value model

◦	Star schema

An object-relational database combines the two related structures.

◦	Physical data models include:

◦	Inverted index

◦	Flat file

◦	Other models include:

◦	Associative model

◦	Multidimensional model

◦	Multivalue model

◦	Semantic model

◦	XML database

◦	Named graph

◦	Triplestore

## 2.	Which are the main functions performed by a Relational Database Management System (RDBMS)?
A relational DBMS is special system software that is used to manage the organization, storage, access, security and integrity of data.  This specialized software allows application systems to focus on the user interface, data validation and screen navigation.  When there is a need to add, modify, delete or display data, the application system simply makes a "call" to the RDBMS.

A relational DBMS stores information in a set of "tables", each of which has a unique identifier or "primary key".  The tables are then related to one another using "foreign keys".   A foreign key is simply the primary key in a different table. Diagrammatically, a foreign key is depicted as a line with an arrow at one end.

By storing data in a RDBMS, undesirable data redundancy can be avoided.  This not only makes data management easier, but it also makes for a flexible database that can respond to changing requirements. 

# 3. Define what is "table" in database terms.
A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.

In relational databases and flat file databases, a table is a set of data elements (values) using a model of vertical columns (which are identified by their name) and horizontal rows, the cell being the unit where a row and column intersect. A table has a specified number of columns, but can have any number of rows. Each row is identified by the values appearing in a particular column subset which has been identified as a unique key index.

Table is another term for relation; although there is the difference in that a table is usually a multiset (bag) of rows where a relation is a set and does not allow duplicates. Besides the actual data rows, tables generally have associated with them some metadata, such as constraints on the table or on the values within particular columns.

The data in a table does not have to be physically stored in the database. Views are also relational tables, but their data are calculated at query time. Another example are nicknames, which represent a pointer to a table in another database.


# 4.	Explain the difference between a primary and a foreign key.
A primary key is a field or combination of fields that uniquely identify a record in a table, so that an individual record can be located without confusion.
A foreign key (sometimes called a referencing key) is a key used to link two tables together. Typically you take the primary key field from one table and insert it into the other table where it becomes a foreign key (it remains a primary key in the original table).

# 5.	Explain the different kinds of relationships between tables in relational databases.
Relationships exist both among the columns within a table and among the tables. These relationships take three logical forms: one-to-one, one-to-many, or many-to-many.

•	Relationship one-to-many (or many-to-one) – A single record in the first table has many corresponding records in the second table

•	Relationship many-to-many – Records in the first table have many correspon-ding records in the second one and vice versa. It is implemented through additional table.

•	Relationship one-to-one – A single record in a table corresponds to a single record in the other table. It is used to model inheritance between tables

# 6.	 When is a certain database schema normalized? What are the advantages of normalized databases?
Database normalization is the process of organizing the fields and tables of a relational database to minimize redundancy. Normalization usually involves dividing large tables into smaller (and less redundant) tables and defining relationships between them. The objective is to isolate data so that additions, deletions, and modifications of a field can be made in just one table and then propagated through the rest of the database using the defined relationships.

# 7.	What are database integrity constraints and when are they used?
Integrity constraints ensure data integrity in the database tables. They enforce data rules which cannot be violated.

Primary key constraint – Ensures that the primary key of a table has unique value for each table row

• Unique key constraint – Ensures that all values in a certain column (or a group of columns) are unique

• Foreign key constraint – Ensures that the value in given column is a key from another table

• Check constraint – Ensures that values in a certain column meet some predefined condition

# 8.	Point out the pros and cons of using indexes in a database.
Indices speed up searching of values in a certain column or group of columns. Usually implemented as B-trees.

Adding and deleting records in indexed tables is slower! Indices should be used for big tables only (e.g. 50 000 rows).

# 9.	What's the main purpose of the SQL language?
SQL (Structured Query Language) is a standardized declarative language for manipulation of relational databases

SQL language supports:

•	Creating, altering, deleting tables and other objects in the database

•	Searching, retrieving, inserting, modifying and deleting table data (rows)

# 10.	What are transactions used for? Give an example.
Transactions are a sequence of database operations which are executed as a single unit. Either all of them execute successfully or none of them is executed at all.

Example:

A bank transfer from one account into another (withdrawal + deposit). If either the withdrawal or the deposit fails the entire operation should be cancelled

# 11.	What is a NoSQL database?
NoSQL (non-relational) databases uses document-based model is a schema-free document storage.

# 12.	Explain the classical non-relational data models.
•	Document model – Set of documents, e.g. JSON strings

•	Key-value model – Set of key-value pairs

•	Hierarchical key-value – Hierarchy of key-value pairs

•	Wide-column model – Key-value model with schema

•	Object model – Set of OOP-style objects

# 13.	Give few examples of NoSQL databases and their pros and cons.
    • DynamoDB
        ◦ Pros
            ▪ Scalable, Simple, Distributed, Flexible and offers Tunable consistency.
            ▪ Automatic data replication across multiple AWS availability zones to protect data and provide high uptime
            ▪ Average service-side latencies in single-digit milliseconds
            ▪ Single API call allows you to atomically increment or decrement numerical attributes
            ▪ Uses secure algorithms to keep your data safe
            ▪ Composite key support
            ▪ Offers Conditional updates
            ▪ It has the property of distributed hash tables hence more performance booster as compared to MySQL
            ▪ Consistent performance
            ▪ Low learning curve
            ▪ It comes with a decent object mapper for Java
        ◦ Cons
            ▪ Poor documentation
            ▪ Limited data types. : It doesn’t accept binary data. You cannot store images, byte arrays etc.
            ▪ Poor query comparison operators
            ▪ Unable to do complex queries
            ▪ 64KB limit on row size
            ▪ 1MB limit on querying
            ▪ Deployable Only on AWS
            ▪ Indexes on column values are not supported. Secondary indexes also are not supported.
            ▪ When you create a table programatically (or even using AWS Console), the table doesn’t become available instantly
            ▪ Dynamo is an expensive and extremely low latency solution, If you are trying to store more than 64KB per item
            ▪ Indexing - Changing or adding keys on-the-fly is impossible without creating a new table.
            ▪ Queries - Querying data is extremely limited. Especially if you want to query non-indexed data. Joins are of course impossible so you have to manage complex data relations on your code/cache layer.
            ▪ Speed - Response time is problematic compared to RDS.
            ▪ A big limitation of DynamoDB and other non-relational database is the lack of multiple indices.
            ▪ DynamoDB is great for lookups by key, not so good for queries, and abysmal for queries with multiple predicates. (Esp. for Eventlog tables)
            ▪ DynamoDB does not support transactions in the traditional SQL sense. Each write operation is atomic to an item. A write operation either successfully updates all of the item's attributes or none of its attributes.
            ▪ No Server-side scripts
            ▪ No triggers
            ▪ No Foreign Keys
    • CouchDB
        ◦ Pros:
            ▪ Simplicity. You can store any JSON data, and each document can have any number of binary attachments.
            ▪ Thanks to map/reduce, querying data is somewhat separated from the data itself. This means that you can index deeply within your data, and on whether or not something exists, and across types, without paying a significant penalty. You just need to write your view functions to handle them.
        ◦ Cons:
            ▪ Arbitrary queries are expensive. To do a query that you haven't created a view for, you need to create a temporary view. This can be solved to some extent by using Lucene.
            ▪ There's a bit of extra space overhead with CouchDB compared to most alternatives.