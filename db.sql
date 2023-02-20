-- There are 2 tables in this database employee and employee_uin
-- employee table contains the employee details
-- employee_uin table contains the employee uin details
-- employee_uin table is a child table of employee table
-- employee_uin table has a foreign key constraint on employee table
-- Query to generate are a list of employees who are less than 30 years old
-- First in order of NAME and then in order of ID both in ascending order
-- The result includes UIN and NAME of the employee and not the ID

SELECT e.NAME, e_uin.UIN
FROM employee e
INNER JOIN employee_uin e_uin
ON e.ID = e_uin.ID
WHERE e.AGE < 30
ORDER BY e.NAME ASC, e.ID ASC;