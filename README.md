<ul>
    <li>
        <h3>
            What database models do you know?
        </h3>
        <span>
            Hierarchical,Network, Relational, Object-Oriented
        </span>
    </li>
    <li>
        <h3>
            Which are the main functions performed by a Relational Database Management System (RDBMS)?
        </h3>
        <div>
            <ul>
                <li>
                    Represent a bunch of tables together with the relationships between them
                </li>
                <li>
                    Rely on a strong mathematical foundation: the relational algebra
                </li>
                <li>
                    Relational Database Management Systems (RDBMS) manage data stored in tables
                </li>
                <li>
                    RDBMS systems typically implement:
                    <ul>
                        <li>
                            Creating / altering / deleting tables and relationships between them (database schema)
                        </li>
                        <li>
                            Adding, changing, deleting, searching and retrieving of data stored in the tables
                        </li>
                        <li>
                            Support for the SQL language
                        </li>
                        <li>
                            Transaction management (optional)
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
    </li>
    <li>
        <h3>Define what is "table" in database terms.</h3>
        <div>
            <ul>
                <li>
                    Database tables consist of data, arranged in rows and columns
                </li>
                <li>
                    All rows have the same structure
                </li>
                <li>
                    Columns have name and type (number, string, date, image, or other)
                </li>
                <li>
                    The schema of a table is an ordered sequence of column specifications (name and type)
                </li>
            </ul>
        </div>
    </li>
    <li>
        <h3>
            Explain the difference between a primary and a foreign key.
        </h3>
        <div>
            <ul>
                <li>
                    Primary key is a column of the table that uniquely identifies its rows (usually its is a number)
                </li>
                <li>
                    Two records (rows) are different if and only if their primary keys are differen
                </li>
                <li>
                    The primary key can be composed by several columns (composite primary key)
                </li>
                <li>
                    Foreign key are used for describing information stored in another.
                </li>
            </ul>
        </div>
    </li>
    <li>
        <h3>
            Explain the different kinds of relationships between tables in relational databases.
        </h3>
        <div>
            <ul>
                <li>
                    One-To-One
                </li>
                <li>
                    One-To-Many
                </li>
                <li>
                    Many-To-Many
                </li>
            </ul>
        </div>
    </li>
    <li>
        <h3>
            When is a certain database schema normalized?
            What are the advantages of normalized databases?
        </h3>
        <div>
            Database schmea is normalized when there is no repeation of data.
        </div>
    </li>
    <li>
        <h3>
            What are database integrity constraints and when are they used?
        </h3>
        <div>
            We set constraints when we want columns to have specific characterists.
        </div>
    </li>
    <li>
        <h3>
            Point out the pros and cons of using indexes in a database.
        </h3>
        <div>
            Pros: Faster search in data
            Cons:When data is not that large, the process is slow
            Indices use B-Trees.
        </div>
    </li>
    <li>
        <h3>What's the main purpose of the SQL language?</h3>
        <div>
            Queries about extracting, deleting, updating, altering data in the database.
        </div>
    </li>
    <li>
        <h3>What are transactions used for?
Give an example.</h3>
        <div>
            Transactions are a sequence of database operations which are executed as a single unit
            For example: When we make a bank transfer we always want to complete, or abort if there is a problem(s).
        </div>
    </li>
    <li>
        <h3>What is a NoSQL database?</h3>
        <div>
            Document model of representing data.Key-value model, ease to use.Human readble
        </div>
    </li>
    <li>
        <h3>
            Explain the classical non-relational data models.
        </h3>
        <div>
            <ul>
                <li>
                    Data stored as documents
                </li>
                <li>
                    Single entity(document) is a single record
                </li>
                <li>
                    Documents do not have a fixed structure
                </li>
            </ul>
        </div>
    </li>
    <li>
        <h3>Give few examples of NoSQL databases and their pros and cons.</h3>
        <div>
            MongoDb MongoDB is an open-source, document database designed for ease of development and scaling. The Manual introduces key concepts in MongoDB, presents the query language, and provides operational and administrative considerations and procedures as well as a comprehensive reference section.
        </div>
    </li>
</ul>

