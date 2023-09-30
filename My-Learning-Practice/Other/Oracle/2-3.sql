--  ===================================================
--  Author:         Michelle Nesbitt
--  Creation Date:  10/20/2021
--  Changes:        Introduced CRUD procedures n reports
--  into the app/added more
--  ===================================================
create or replace PROCEDURE crud_app(IN OPERATION)
IS
BEGIN


END crud_app;

SET SERVEROUTPUT ON;
DECLARE
    rec_jobs JOBS%ROWTYPE;
    rec_regions REGIONS%ROWTYPE;
    rec_emps EMPLOYEES%ROWTYPE;
    rec_depts EMPLOYEES%ROWTYPE; 

BEGIN
    --jobs fields
    REC_JOBS.JOB_ID           := '245';
    REC_JOBS.JOB_TITLE        := 'FI_ADMIN';
    REC_JOBS.MIN_SALARY       := 20000;
    REC_JOBS.MAX_SALARY       := 50000;
    --insert new record into jobs
INSERT INTO JOBS VALUES REC_JOBS;
        
    --fields
    REC_REGIONS.REGION_ID     := 250;
    REC_REGIONS.REGION_NAME   := 'Nassau County';
 
    --insert new record into 
INSERT INTO REGIONS VALUES REC_REGIONS;

    REC_EMPS.EMPLOYEE_ID      := 555;
    REC_EMPS.FIRST_NAME       := 'Max';
    REC_EMPS.LAST_NAME        := 'Roswell';
    REC_EMPS.EMAIL            := 'me@you.com';
    REC_EMPS.PHONE_NUMBER     := '555-698-8988';
    REC_EMPS.HIRE_DATE        := '2/12/2021';
    REC_EMPS.JOB_ID           := '255';
    REC_EMPS.SALARY           := 24000;
    REC_EMPS.COMMISSION_PCT   := 0.05;
    REC_EMPS.MANAGER_ID       := 5;
    REC_EMPS.DEPARTMENT_ID    := 101;
    
    REC_DEPTS.DEPARTMENT_ID   := 125;
    REC_DEPTS.DEPARTMENT_NAME := 'Accounting';
    REC_DEPTS.MANAGER_ID      := 6;
    REC_DEPTS.LOCATION_ID     := 55;
    
INSERT INTO EMPLOYEES VALUES REC_EMPS;

INSERT INTO DEPARTMENTS VALUES REC_DEPTS;
        
UPDATE EMPLOYEES		
        SET 		
        EMPLOYEE_ID	=	rec_emps.EMPLOYEE_ID,
        FIRST_NAME	=	rec_emps.FIRST_NAME,
        LAST_NAME	=	rec_emps.LAST_NAME,
        EMAIL	=	rec_emps.EMAIL,
        PHONE_NUMBER	=	rec_emps.PHONE_NUMBER,
        HIRE_DATE	=	rec_emps.HIRE_DATE,
        JOB_ID	=	rec_emps.JOB_ID,
        SALARY	=	rec_emps.SALARY,
        COMMISSION_PCT	=	rec_emps.COMMISSION_PCT,
        MANAGER_ID	=	rec_emps.MANAGER_ID,
        DEPARTMENT_ID	=	rec_emps.DEPARTMENT_ID
        WHERE		
    EMPLOYEE_ID	=	rec_emps.EMPLOYEE_ID;   
    
UPDATE DEPARTMENTS		
        SET 		
        DEPARTMENT_ID	=	rec_depts.DEPARTMENT_ID,
        DEPARTMENT_NAME  	=	rec_depts.DEPARTMENT_NAME,  
        MANAGER_ID     	=	rec_depts.MANAGER_ID, 
        LOCATION_ID    	=	rec_depts.LOCATION_ID    
        WHERE		
        DEPARTMENT_ID	=	rec_depts.DEPARTMENT_ID;
    
    --update
UPDATE JOBS
        SET 
        JOB_ID = rec_jobs.JOB_ID,
        JOB_TITLE = rec_jobs.JOB_TITLE,
        MIN_SALARY = rec_jobs.MIN_SALARY,
        MAX_SALARY = rec_jobs.MAX_SALARY
        WHERE
        JOB_ID = rec_jobs.JOB_ID;
        
UPDATE REGIONS
        SET 
        REGION_ID = rec_regions.REGION_ID,
        REGION_NAME = rec_regions.REGION_NAME        
        WHERE
        REGION_ID = rec_regions.REGION_ID;
    
      
-- delete
DELETE FROM JOBS
    WHERE JOB_ID = rec_jobs.JOB_ID;        
DELETE FROM REGIONS
    WHERE REGION_ID = rec_regions.REGION_ID;
DELETE FROM DEPARTMENTS
    WHERE DEPARTMENT_ID = rec_emps.EMPLOYEE_ID;
DELETE FROM EMPLOYEES
    WHERE EMPLOYEE_ID = rec_depts.DEPARTMENT_ID;
EXCEPTION

WHEN NO_DATA_FOUND THEN
    DMBS_OUTPUT.PUT_LINE('Data set no data found');
WHEN TOO_MANY_ROWS THEN
    DMBS_OUTPUT.PUT_LINE('Too many rows returned');
WHEN OTHERS THEN
    NULL;
    
END;
