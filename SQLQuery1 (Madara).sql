Create table Students(
St_No varchar(100),
Name varchar(100),
Address varchar(100),
Gender varchar(100),
Status varchar(100),
Primary key(St_No)
)
select* from Students

insert into Students values ('@St_No','@Name','@Address','@Gender','@Status')

truncate table Students




