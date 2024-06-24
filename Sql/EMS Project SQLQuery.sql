create database employee
use employee




select * from emp
drop table emp

CREATE TABLE emp(
   EMP_ID int primary key,
   emp_name  varchar(50) NULL,
   contact_num VARCHAR(20) NULL,
   gender varchar(20) NULL,
   position varchar(20) NULL,
   salary int NULL,
   insert_date date NULL,
   update_date date NULL,
   delete_date date NULL,
   status varchar(20) NULL,
   pass varchar(50) NULL,
   MGR_ID int NULL,
   DEPT_ID int foreign key(DEPT_ID) references dept(DEPT_ID)

);


CREATE TABLE dept(
  DEPT_ID int primary key,
  dept_name varchar(50)
);

drop table dept
drop table emp
drop table proj
drop table ticket

CREATE TABLE ticket(
TICKET_ID int primary key,
PROJ_ID int foreign key(PROJ_ID) references proj(PROJ_ID),
EMP_ID int foreign key(EMP_ID) references emp(EMP_ID),
ticket_status varchar(50)
);

CREATE TABLE proj(
  PROJ_ID int primary key, 
  proj_name varchar(50),
  total_ticket int,
  completed_ticket int,
  tickets_in_progress int,
  proj_status varchar(50),
  EMP_ID int foreign key(EMP_ID) references emp(EMP_ID)
);




Update emp set EMP_ID = 1102 where EMP_ID = 1004

DELETE from ticket
Delete from proj

SELECT 
    proj.PROJ_ID, 
    proj.proj_name, 
    proj.total_ticket, 
    proj.completed_ticket, 
    proj.tickets_in_progress, 
    proj.proj_status, 
    proj.EMP_ID  
FROM 
    proj 
INNER JOIN 
    emp 
ON 
    emp.EMP_ID = proj.EMP_ID;


insert into emp values
(1000,'admin','1111','Male','President',0000,null,null,null,'Active','Abc1234@',0,30);

insert into dept values
(10,'Sales'),
(20,'Development'),
(30,'HR'),
(40,'Testing');

Select * from emp where delete_date IS NULL

delete from emp;

  SELECT 
      m.EMP_ID,
      m.emp_name,
      m.MGR_ID,
      p.PROJ_ID,
      p.proj_name,
      p.total_ticket,
      p.completed_ticket,
      p.tickets_in_progress,
      p.proj_status
  FROM 
      emp e
  JOIN 
      emp m ON e.MGR_ID = m.EMP_ID
  LEFT JOIN 
      proj p ON p.EMP_ID = m.EMP_ID
  WHERE 
      e.EMP_ID = 1101 AND p.proj_status = 'Available'



Update ticket 
set ticket_status = 'hold'
where EMP_ID = 1101

Insert into ticket values(1111, 111, 1101, 'Available');

SELECT completed_ticket, tickets_in_progress FROM proj WHERE proj_status='Available' AND PROJ_ID=111

SELECT TICKET_ID, PROJ_ID, ticket_status FROM ticket WHERE EMP_ID =1101 AND ticket_status = 'hold';

UPDATE proj SET proj_status = 'complete' where proj_status = 'Available' AND (total_ticket + tickets_in_progress) = 0;

Insert into proj values(4, 'SMS', 0, 4, 0, 'Available', 1002)

UPDATE ticket SET ticket.ticket_status = 'complete' where TICKET_ID = 21;


UPDATE proj SET proj.completed_ticket = proj.completed_ticket+1, proj.tickets_in_progress = proj.tickets_in_progress-1 
from proj 
inner join ticket t
on proj.PROJ_ID = t.PROJ_ID
WHERE t.ticket_status = 'complete' AND proj.tickets_in_progress > 0;


SELECT * from emp;
SELECT * from dept;
SELECT * from proj;
SELECT * from ticket;
SELECT * from emp;



SELECT * from proj where EMP_ID=1001;


SELECT EMP_ID,emp_name,position,salary,MGR_ID,DEPT_ID FROM emp WHERE EMP_ID=1001;




SELECT t.TICKET_ID ,t.PROJ_ID, t.EMP_ID,t.ticket_status 
from ticket t 
inner join emp e 
on t.EMP_ID=e.EMP_ID 
WHERE e.MGR_ID=1001

delete from proj
delete from ticket
delete from emp


SELECT 
    EMP_ID, 
    emp_name, 
    CASE 
        WHEN position LIKE '%Project Manager%' THEN 'Proj Manager' 
        ELSE position 
    END AS position, 
    salary, 
    MGR_ID, 
    DEPT_ID 
FROM emp 
WHERE EMP_ID = 1001;


SELECT proj.PROJ_ID, proj.proj_name, proj.total_ticket, proj.completed_ticket, proj.tickets_in_progress, proj.proj_status, proj.EMP_ID FROM proj INNER JOIN emp ON emp.EMP_ID = proj.EMP_ID where emp.status='Active'

SELECT t.TICKET_ID , e.emp_name ,t.PROJ_ID, t.EMP_ID,t.ticket_status from ticket t inner join emp e on t.EMP_ID=e.EMP_ID WHERE e.MGR_ID=1001
