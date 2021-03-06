CREATE TABLE if not exists Users (
    id    integer PRIMARY KEY GENERATED BY DEFAULT AS IDENTITY,
    name  varchar(30) NOT NULL,
    password varchar(30),
    roleId smallint,
    age smallint
);

CREATE TABLE if not exists Roles(
    id smallint,
    roleName  varchar(30) NOT NULL
);

INSERT into Roles (id, roleName) 
values (1, 'admin'), (2, 'user');

INSERT INTO Users (name, password, roleId, age) values
        ('TestUser','test1', 1, 20),
        ('ivan','user1',1, 30),
        ('Petr','user2',1, 40),
        ('Emma','user3',2, 10),
        ('Alex','user4',2, 50),
        ('Ronald','user5',2, 16);

