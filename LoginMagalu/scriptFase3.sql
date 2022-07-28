alter table dbo.tb_product_category add constraint FKProduto foreign key (productId)
references dbo.tb_product(Id)
GO


alter table dbo.tb_product_category add constraint FKCategoria foreign key (categoryId)
references dbo.tb_category(Id)
GO


insert into dbo.tb_product (name, price) values ('computador', 3000 );

insert into dbo.tb_product (name, price) values ('cadeira', 500 );

insert into dbo.tb_product (name, price) values ('teclado', 90 );

select * from dbo.tb_product ;


select * from dbo.tb_category; 

insert into dbo.tb_category (name) values ('eletronico');

insert into dbo.tb_category (name) values ('vestuario');

insert into dbo.tb_category (name) values ('casa');


select * from dbo.tb_product_category;

insert into dbo.tb_product_category (productId, categoryId) values (3,1);

insert into dbo.tb_product_category (productId, categoryId ) values (4,2);

insert into dbo.tb_product_category (productId, categoryId) values (5,3);

select * from dbo.tb_product p where p.price > 100; 

update dbo.tb_product set name='computadorAlt' where Id = 3; 

select * from dbo.tb_product;

delete from dbo.tb_product where Id = 5;

alter table dbo.tb_product_category drop constraint FKProduto;

alter table dbo.tb_product_category drop constraint FKCategoria;


alter table dbo.tb_product_category add constraint FKProduto foreign key (productId)
references dbo.tb_product(Id) ON DELETE CASCADE  ON UPDATE CASCADE
GO

alter table dbo.tb_product_category add constraint FKCategoria foreign key (categoryId)
references dbo.tb_category(Id)  ON DELETE CASCADE  ON UPDATE CASCADE
GO


select * from dbo.tb_product;

delete from dbo.tb_product where Id = 5;