create table dbo.Products(
	id int not null,
	name varchar(255)

	constraint pk_products_id primary key(id)
);

create table dbo.Categories(
	id int not null,
	name varchar(255)

	constraint pk_categories_id primary key(id)
);

create table dbo.ProductsCategory(
	productid int not null,
	categoryid int not null,

	constraint fk_ProductsCategory_product_id foreign key(productid) references dbo.Products(id),
	constraint fk_ProductsCategory_category_id foreign key(productid) references dbo.Categories(id),
);

insert into dbo.Categories(id,name) Values(1,'Напитки');
insert into dbo.Categories(id,name) Values(2,'Инструменты');
insert into dbo.Categories(id,name) Values(3,'Лекарственные средства');

insert into dbo.Products(id,name) Values(1,'Pepsi');
insert into dbo.Products(id,name) Values(2,'Молоток');
insert into dbo.Products(id,name) Values(3,'Имбирный чай');
insert into dbo.Products(id,name) Values(4,'Рубашка');

insert into dbo.ProductsCategory(productid,categoryid) Values(1,1);
insert into dbo.ProductsCategory(productid,categoryid) Values(2,2);
insert into dbo.ProductsCategory(productid,categoryid) Values(3,1);
insert into dbo.ProductsCategory(productid,categoryid) Values(3,3);

select concat(p.name,' ',c.name) as FullProductName
from dbo.Products p
left join dbo.ProductsCategory pc on pc.productid = p.id
left join dbo.Categories c on pc.categoryid = c.id

