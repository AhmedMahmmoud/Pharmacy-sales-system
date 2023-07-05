use Pharmacytask

create table suppAddress
(
  S_id int,
  Address nvarchar(50),
  primary key (S_id,Address)
)
create table cust_product
(
  Cus_id int,
  P_id int,
  primary key (Cus_id,p_id)
)
create table prod_supp
(
  P_id int,
  S_id int ,
  primary key (P_id,S_id)
)

create table Usersupp
(
  Userid int,
  Address nvarchar(50),
  primary key (Userid,Address)
)
create table Cus_Category
(
  Ca_id int,
  Cus_id int ,
  primary key (Ca_id,Cus_id)
)
create table Categ_supp
(
  S_id int,
  Ca_id int,
  primary key (S_id,Ca_id)
)
create table cust_User
(
  Cus_id int,
  Userid int,
  primary key (Cus_id,Userid)
)


SELECT * FROM dbo.Users WHERE Userid = 0
update Users
set Userid = 8 where Userid = 0