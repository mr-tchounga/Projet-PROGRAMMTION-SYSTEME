USE Restau;

-- INSERTION TABLE "MATERIAL"
INSERT INTO Material(
    items, qty, "available")
VALUES
    ('bouteille d`eau', 40, 40),
    ('Corbeille a pain', 40, 40),
    ('assiette(entrees)', 150, 150),
    ('assiette(plates)', 150, 150),
    ('assiette(creuses)', 30, 30),
    ('assiette(desserts)', 150, 150),   
    ('couvert(fourchettes)', 150, 150),
    ('couvert(couteaux)', 150, 150),
    ('couvert(cuilleres a soupe)', 150, 150),
    ('couvert(cuilleres a cafe)', 150, 150),
    ('verre(eau)', 150, 150),
    ('verre(vin)', 150, 150),
    ('verre(champagne)', 150, 150),
       ('tasse a cafe', 150, 150),
    ('serviette', 150, 150),
    ('nappe', 40, 40),
    ('serviette', 150, 150),
    ('lave-vaisselle', 1, 1),
    ('machine a laver', 1, 1),
    ('Feux de cuisson', 5, 5),
    ('Casserole', 10, 10),
    ('Poele', 10, 10),
    ('Four', 1, 1),
    ('cuilleres en bois', 10, 10),
    ('Mixeur', 1, 1),
    ('Bol a salade', 5, 5),
    ('Autocuiseur', 2, 2),
    ('Presse-grume', 1, 1),
    ('Tamis', 1, 1),
    ('Entonnoir', 1, 1),
    ('Couteaux de cuisine', 5, 5),
    ('Frigo de travail', 1, 1),
    ('Evier', 1, 1)
;


-- INSERTION TABLE "TABLE"
INSERT INTO "Table"(
    no_places, qty, available)
VALUES
    (2, 10, 10),
    (4, 10, 10),
    (6, 5, 5),
    (8, 5, 5),
    (10, 2, 2)
;

-- INSERTION TABLE "TABLE_MATERIAL"
INSERT INTO table_material(
    id_Table, id_Material, mat_qty
)
VALUES
    (1, 1, 1),
    (2, 1, 1),
    (3, 1, 2),
    (4, 1, 2),
    (5, 1, 2),
    (1, 2, 1),
    (2, 2, 1),
    (3, 2, 2),
    (4, 2, 2),
    (5, 2, 2)
;





select * from material;