
CREATE DATABASE Restau;

USE Restau;

DROP TABLE IF EXISTS "Table";
CREATE TABLE "Table"(
    id    		  	int				IDENTITY,
    no_places     	int				NOT NULL,
    qty     	  	int				NOT NULL,
    available     	int				NOT NULL,
    PRIMARY KEY (id)
);



DROP TABLE IF EXISTS "TableRow";
CREATE TABLE "TableRow"(
    id     		  	int				NOT NULL,
    id_Table      	int				NOT NULL,
    PRIMARY KEY (id)
);



DROP TABLE IF EXISTS "Material";
CREATE TABLE "Material"(
    id    		  	int				IDENTITY,
    items     	  	Varchar (100)	NOT NULL,
    qty			  	int				NOT NULL,
    available     	int				NOT NULL,
    PRIMARY KEY (id),
    UNIQUE (items)
);



DROP TABLE IF EXISTS "Staff";
CREATE TABLE "Staff"(
    id    		  	int				IDENTITY,
    name    	  	Varchar (100)	NOT NULL,
    age   	      	int				NOT NULL,
    role     	 	Varchar (100)	NOT NULL,
    phone_no      	int				NOT NULL,
    email     	  	Varchar (100)	NOT NULL,
    employment_date Date 			NOT NULL,
    PRIMARY KEY (id)
);



DROP TABLE IF EXISTS "Kitchen_stuff";
CREATE TABLE "Kitchen_stuff"(
    id    		  	int				IDENTITY,
    items     		Varchar (100)	NOT NULL,
    quantity     	int				NOT NULL,
    available     	int				NOT NULL,
    PRIMARY KEY (id),
    UNIQUE (items)
);



DROP TABLE IF EXISTS "Client";
CREATE TABLE "Client"(
    id    		  	int				IDENTITY,
    name     		Varchar (100)	NOT NULL,
    phone_no     	int				NOT NULL,
    email     		Varchar (100)	NULL,
    presence_date   Date			NULL,
    pref_taste     	Varchar (100)	NULL,
    pref_menu     	Varchar (100)	NULL,
    pref_server     Varchar (100)	NULL,
    command_style   Int				NOT NULL,
    PRIMARY KEY (id)
);



DROP TABLE IF EXISTS "Recipe";
CREATE TABLE "Recipe"(
    id    		  	int				IDENTITY,
    name     		Varchar (100)	NOT NULL,
    price     		int				NOT NULL,
    duration     	Time,
    PRIMARY KEY (id),
    UNIQUE (name)
);



DROP TABLE IF EXISTS "table_material";
CREATE TABLE "table_material"(
    id_Table      	int				NOT NULL,
    id_Material     int				NOT NULL,
    mat_qty         Int             NOT NULL,
    PRIMARY KEY (id_Table,id_Material)
);



DROP TABLE IF EXISTS "command";
CREATE TABLE "command"(
    id    		  	int				IDENTITY,
    amount     		int				NOT NULL,
    command_date    Date 			NOT NULL,
    id_Staff      	int				NOT NULL,
    id_Table      	int				NOT NULL,
    id_Recipe       int				NOT NULL,
    id_Client       int				NOT NULL,
	PRIMARY KEY (id_Staff,id_Table,id_Recipe,id_Client)
);



DROP TABLE IF EXISTS "reserve";
CREATE TABLE "reserve"(
    id    		  	int				IDENTITY,
    amount     		int				NOT NULL,
    reservation_date Date 			NOT NULL,
    id_Client      	int				NOT NULL,
    id_Table      	int				NOT NULL,
    id_Recipe      	int				NOT NULL,
    id_Staff      	int				NOT NULL,
    PRIMARY KEY (id_Client,id_Table,id_Recipe,id_Staff)
);



DROP TABLE IF EXISTS "recipe_stuff";
CREATE TABLE "recipe_stuff"(
    id    		  	int				IDENTITY,
    id_Recipe      	int				NOT NULL,
    id_Kitchen_stuff int			NOT NULL,
    PRIMARY KEY (id_Recipe,id_Kitchen_stuff)
);



ALTER TABLE TableRow ADD CONSTRAINT FK_TableRow_id_Table FOREIGN KEY (id_Table) REFERENCES "Table"(id)
ALTER TABLE table_material ADD CONSTRAINT FK_table_material_id_Table FOREIGN KEY (id_Table) REFERENCES "Table"(id)
ALTER TABLE table_material ADD CONSTRAINT FK_table_material_id_Material FOREIGN KEY (id_Material) REFERENCES Material(id)
ALTER TABLE command ADD CONSTRAINT FK_command_id_Staff FOREIGN KEY (id_Staff) REFERENCES Staff(id)
ALTER TABLE command ADD CONSTRAINT FK_command_id_Table FOREIGN KEY (id_Table) REFERENCES "Table"(id)
ALTER TABLE command ADD CONSTRAINT FK_command_id_Recipe FOREIGN KEY (id_Recipe) REFERENCES Recipe(id)
ALTER TABLE command ADD CONSTRAINT FK_command_id_Client FOREIGN KEY (id_Client) REFERENCES Client(id)
ALTER TABLE reserve ADD CONSTRAINT FK_reserve_id_Client FOREIGN KEY (id_Client) REFERENCES Client(id)
ALTER TABLE reserve ADD CONSTRAINT FK_reserve_id_Table FOREIGN KEY (id_Table) REFERENCES "Table"(id)
ALTER TABLE reserve ADD CONSTRAINT FK_reserve_id_Recipe FOREIGN KEY (id_Recipe) REFERENCES Recipe(id)
ALTER TABLE reserve ADD CONSTRAINT FK_reserve_id_Staff FOREIGN KEY (id_Staff) REFERENCES Staff(id)
ALTER TABLE recipe_stuff ADD CONSTRAINT FK_recipe_stuff_id_Recipe FOREIGN KEY (id_Recipe) REFERENCES Recipe(id)
ALTER TABLE recipe_stuff ADD CONSTRAINT FK_recipe_stuff_id_Kitchen_stuff FOREIGN KEY (id_Kitchen_stuff) REFERENCES Kitchen_stuff(id)
